using System.IO;
using System.Text;

namespace AnglicanDailyReading.Helpers
{
    public sealed class ExtendedStringWriter : StringWriter
    {
        private readonly Encoding stringWriterEncoding;
        public ExtendedStringWriter(Encoding desiredEncoding)
        {
            stringWriterEncoding = desiredEncoding;
        }

        public override Encoding Encoding
        {
            get
            {
                return stringWriterEncoding;
            }
        }
    }
}
