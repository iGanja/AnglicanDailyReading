using AnglicanDailyReading.Helpers;
using AnglicanDailyReading.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private static DateTime Today
        {
            get
            {
                return DateTime.Today;
            }
        }
        private static HolyDays HolyDays
        {
            get
            {
                return Data.AnglicanStore.HolyDays.First(d => d.Year == Today.Year);
            }
        }
        private static int[] Days
        {
            get
            {
                return new int[] {HolyDays.AshWednesday.DayOfYear,
                HolyDays.MaundyThursday.DayOfYear, HolyDays.GoodFriday.DayOfYear,
                HolyDays.HolySaturday.DayOfYear, HolyDays.EasterSunday.DayOfYear,
                HolyDays.Ascension.DayOfYear, HolyDays.Pentecost.DayOfYear};
            }
        }
        private static int TwoYear
        {
            get
            {
                // return 2 on even years, 1 on odd years
                return DateTime.Today.Year % 2 == 0 ? 2 : 1;
            }
        }
        private static string ThreeYear
        {
            get
            {
                // return A on years divisible by 3, then B then C
                return DateTime.Today.Year % 3 == 0 ? "A" : DateTime.Today.Year % 3 == 1 ? "B" : "C";
            }
        }

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

                        if (Days.Contains(i))
                        {
                            x = GetHolyDay(i) ?? x;
                        }

                        x.Morning.ForEach(y =>
                        {
                            writer.WriteStartElement("passage");
                            writer.WriteValue(y);
                            writer.WriteEndElement();
                        });
                        x.Evening.ForEach(y =>
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
        [Route("twoyear/office")]
        public ContentResult TwoYearOffice()
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

                        if (Days.Contains(i))
                        {
                            x = GetHolyDay(i) ?? x;
                        }

                        if (TwoYear == 1)
                        {
                            x.Morning.ForEach(y =>
                            {
                                writer.WriteStartElement("passage");
                                writer.WriteValue(y);
                                writer.WriteEndElement();
                            });
                        }
                        else
                        {
                            x.Evening.ForEach(y =>
                            {
                            writer.WriteStartElement("passage");
                            writer.WriteValue(y);
                            writer.WriteEndElement();
                            });
                        }
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
                    readingPlan.Passages.ForEach(x =>
                    {
                        writer.WriteStartElement("reading");
                        writer.WriteStartElement("day");
                        writer.WriteValue(i);
                        writer.WriteEndElement();

                        if (Days.Contains(i))
                        {
                            x = GetHolyDay(i) ?? x;
                        }

                        x.Morning.ForEach(y =>
                        {
                            if (y.Contains("Psalm"))
                            {
                                writer.WriteStartElement("passage");
                                writer.WriteValue(y);
                                writer.WriteEndElement();
                            }
                        });
                        x.Evening.ForEach(y =>
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

        private static Daily GetHolyDay(int day)
        {
            if (day == HolyDays.AshWednesday.DayOfYear)
                return Data.AnglicanStore.AshWednesday;
            else if (day == HolyDays.MaundyThursday.DayOfYear)
                return Data.AnglicanStore.MaundyThursday;
            else if (day == HolyDays.GoodFriday.DayOfYear)
                return Data.AnglicanStore.GoodFriday;
            else if (day == HolyDays.HolySaturday.DayOfYear)
                return Data.AnglicanStore.HolySaturday;
            else if (day == HolyDays.EasterSunday.DayOfYear)
                return Data.AnglicanStore.EasterSunday;
            else if (day == HolyDays.Ascension.DayOfYear)
                return Data.AnglicanStore.Ascension;
            else if (day == HolyDays.Pentecost.DayOfYear)
                return Data.AnglicanStore.Pentecost;
            else return null;
        }
    }
}
