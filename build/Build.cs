﻿using Nuke.Common;
using Nuke.Common.BuildServers;
using Nuke.Common.Tools.DotNet;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.IO.FileSystemTasks;

class Build : NukeBuild
{
    // Console application entry. Also defines the default target.
    public static int Main () => Execute<Build>(x => x.Test);

    // Auto-injection fields:
    // [GitVersion] readonly GitVersion GitVersion;
    //  - Semantic versioning. Must have 'GitVersion.CommandLine' referenced.
    // [GitRepository] readonly GitRepository GitRepository;
    //  - Parses origin, branch name and head from git config.
    // [Parameter] readonly string MyGetApiKey;
    //  - Returns command-line arguments and environment variables.

    public bool IsTagged => AppVeyor.Instance?.RepositoryTag ?? false;

    int Revision => AppVeyor.Instance?.BuildNumber ?? 1;

    public string RevisionString => IsTagged ? null : $"rev{Revision:D4}";

    Target Clean => _ => _
            .Executes(() =>
            {
                EnsureCleanDirectory(OutputDirectory);
                EnsureCleanDirectory(ArtifactsDirectory);
            });

    Target Restore => _ => _
            .DependsOn(Clean)
            .Executes(() =>
            {
                DotNetRestore(s => DefaultDotNetRestore);
            });

    Target Compile => _ => _
            .DependsOn(Restore)
            .Executes(() =>
            {
                DotNetBuild(s => DefaultDotNetBuild
                    .SetVersionSuffix(RevisionString));
            });

    Target Pack => _ => _
        .DependsOn(Compile, Test)
        .Executes(() =>
        {
            DotNetPack(s => DefaultDotNetPack
                .SetOutputDirectory(ArtifactsDirectory)
                .SetProject(RootDirectory / "src" / "DateTimeExtensions")
                .SetVersionSuffix(RevisionString));
        });

    Target Test => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            DotNetTest(s => s
                .SetProjectFile(RootDirectory / "tests" / "DateTimeExtensions.Tests"));
        });
}
