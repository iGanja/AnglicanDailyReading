using System.IO;
using System.Text;

namespace AnglicanDailyReading.Helpers
{
    public sealed class ExtendedStringWriter(Encoding desiredEncoding) : StringWriter
    {
        public override Encoding Encoding { get; } = desiredEncoding;
    }
}
