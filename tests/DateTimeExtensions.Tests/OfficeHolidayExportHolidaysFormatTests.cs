using System.IO;
using DateTimeExtensions.Export;
using DateTimeExtensions.WorkingDays;
using NUnit.Framework;

namespace DateTimeExtensions.Tests
{
    public class OfficeHolidayExportHolidaysFormatTests
    {
        [Test]
        public void can_export_office_format()
        {
            var exporter = ExportHolidayFormatLocator.LocateByType(ExportType.OfficeHolidays);
            using (var memoryStream = new MemoryStream())
            {
                using (var textwriter = new StreamWriter(memoryStream))
                {
                    exporter.Export(new WorkingDayCultureInfo("pt-PT"), 2012, textwriter);
                    textwriter.Flush();
                    Assert.IsTrue(memoryStream.Length > 0);
                }
            }
        }

        [Test]
        public void can_save_to_file()
        {
            var exporter = ExportHolidayFormatLocator.LocateByType(ExportType.OfficeHolidays);
            string tempfile = Path.GetTempFileName();
            using (var memoryStream = File.Create(tempfile))
            {
                using (var textwriter = new StreamWriter(memoryStream))
                {
                    exporter.Export(new WorkingDayCultureInfo("pt-PT"), 2012, textwriter);
                    textwriter.Flush();
                    Assert.IsTrue(memoryStream.Length > 0);
                }
            }
            File.Delete(tempfile);
        }
    }
}