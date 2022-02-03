using System.IO;
using System.Text;

namespace AnglicanDailyReading.Helpers
{
    public sealed class ExtendedStringWriter : StringWriter
    {
        public ExtendedStringWriter(Encoding desiredEncoding)
        {
            Encoding = desiredEncoding;
        }

        public override Encoding Encoding { get; }
    }
}
