using AnglicanDailyReading.Helpers;
using AnglicanDailyReading.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Xml;

namespace AnglicanDailyReading.Controllers
{
    [ApiController]
    [Route("")]
    public class DefaultController : ControllerBase
    {
        private readonly ReadingPlan readingPlan = new();
        private readonly ILogger<DefaultController> _logger;

        public DefaultController(ILogger<DefaultController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("office")]
        public ContentResult Office()
        {
            readingPlan.Passages.AddRange(
                Data.AnglicanStore.Office
            );

            XmlWriterSettings settings = new()
            {
                Encoding = Encoding.UTF8,
                OmitXmlDeclaration = true,
                ConformanceLevel = ConformanceLevel.Fragment,
                CloseOutput = false
            };

            string xml = "";
            using (var sww = new ExtendedStringWriter(Encoding.UTF8))
            {
                using (XmlWriter writer = XmlWriter.Create(sww, settings))
                {
                    //writer.WriteStartDocument();
                    writer.WriteStartElement("plan");
                    writer.WriteStartElement("title");
                    writer.WriteValue("Anglican Daily Office");
                    writer.WriteEndElement();
                    int i = 1;
                    readingPlan.Passages.ForEach(x =>
                    {
                        writer.WriteStartElement("reading");
                        writer.WriteStartElement("day");
                        writer.WriteValue(i);
                        writer.WriteEndElement();
                        x.ForEach(y =>
                        {
                            writer.WriteStartElement("passage");
                            writer.WriteValue(y);
                            writer.WriteEndElement();
                        });
                        writer.WriteEndElement();
                        i++;
                    });

                    writer.WriteEndElement();
                    //writer.WriteEndDocument();
                }

                xml = sww.ToString();
            }

            return new ContentResult
            {
                Content = xml,
                ContentType = "application/xml",
                StatusCode = 200
            };

        }

        [HttpGet]
        [Route("psalter")]
        public ContentResult Psalter()
        {
            readingPlan.Passages.AddRange(
                Data.AnglicanStore.Office
            );

            XmlWriterSettings settings = new()
            {
                Encoding = Encoding.UTF8,
                OmitXmlDeclaration = true,
                ConformanceLevel = ConformanceLevel.Fragment,
                CloseOutput = false
            };

            string xml = "";
            using (var sww = new ExtendedStringWriter(Encoding.UTF8))
            {
                using (XmlWriter writer = XmlWriter.Create(sww, settings))
                {
                    //writer.WriteStartDocument();
                    writer.WriteStartElement("plan");
                    writer.WriteStartElement("title");
                    writer.WriteValue("Anglican 60 Day Psalter");
                    writer.WriteEndElement();
                    int i = 1;
                    foreach(var x in readingPlan.Passages)
                    {
                        writer.WriteStartElement("reading");
                        writer.WriteStartElement("day");
                        writer.WriteValue(i);
                        writer.WriteEndElement();
                        x.ForEach(y =>
                        {
                            if (y.Contains("Psalm"))
                            {
                                writer.WriteStartElement("passage");
                                writer.WriteValue(y);
                                writer.WriteEndElement();
                            }
                        });
                        writer.WriteEndElement();
                        i++;
                    };

                    writer.WriteEndElement();
                    //writer.WriteEndDocument();
                }

                xml = sww.ToString();
            }

            return new ContentResult
            {
                Content = xml,
                ContentType = "application/xml",
                StatusCode = 200
            };

        }
    }
}
