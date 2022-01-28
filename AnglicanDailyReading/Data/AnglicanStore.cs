using AnglicanDailyReading.Models;
using System;
using System.Collections.Generic;

namespace AnglicanDailyReading.Data
{
    public static class AnglicanStore
    {
        public static List<string> February29
        {
            get
            {
                return new List<string>
                {
                    "Psalm 90",
                    "2 Kings 2",
                    "Luke 24:44-53",
                    "Psalm 104",
                    "Joel 2",
                    "2 Peter 3"
                };
            }
        }

        public static List<string> AshWednesday
        {
            get
            {
                return new List<string>
                {
                    "Psalm 38",
                    "Isaiah 58:1-12",
                    "Luke 18:9-14",
                    "Psalm 6",
                    "Psalm 32",
                    "Jonah 3",
                    "1 Corinthians 9:24-27"
                };
            }
        }

        public static List<string> MaundyThursday
        {
            get
            {
                return new List<string>
                {
                    "Psalm 41",
                    "Daniel 9",
                    "John 13:1-20",
                    "Psalm 142-143",
                    "1 Corinthians 10:1-22",
                    "John 13:1-20"
                };
            }
        }

        public static List<string> GoodFriday
        {
            get
            {
                return new List<string>
                {
                    "Psalm 40",
                    "Lamentations 3:1-36",
                    "John 18",
                    "Psalm 102",
                    "1 Peter 2:11-25",
                    "Luke 23:18-49"
                };
            }
        }

        public static List<string> HolySaturday
        {
            get
            {
                return new List<string>
                {
                    "Psalm 88",
                    "Lamentations 3:37-58",
                    "Hebrews 4",
                    "Psalm 91",
                    "1 Peter 4:1-8",
                    "Luke 23:50-56"
                };
            }
        }

        public static List<string> EasterSunday
        {
            get
            {
                return new List<string>
                {
                    "Psalm 118",
                    "Exodus 15",
                    "Acts 2:22-32",
                    "Psalm 111-114",
                    "Romans 6",
                    "Luke 24:13-43"
                };
            }
        }

        public static List<string> Ascension
        {
            get
            {
                return new List<string>
                {
                    "Psalm 8",
                    "Psalm 47",
                    "2 Kings 2",
                    "Ephensians 4:1-17",
                    "Psalm 21",
                    "Psalm 24",
                    "Hebrews 8",
                    "Luke 24:44-53"
                };
            }
        }

        public static List<string> Pentecost
        {
            get
            {
                return new List<string>
                {
                    "Psalm 48",
                    "Isiah 11",
                    "John 16:1-15",
                    "Psalm 145",
                    "Acts 2",
                    "Acts 10:34-48"
                };
            }
        }

        public static List<HolyDays> HolyDays
        {
            get
            {
                return new List<HolyDays>
                {
                    new HolyDays
                    {
                        Year = 2022,
                        AshWednesday = new DateOnly(2022, 3, 2),
                        EasterSunday = new DateOnly(2022, 4, 17),
                        HolySaturday = new DateOnly(2022, 4, 16),
                        GoodFriday = new DateOnly(2022, 4, 15),
                        MaundyThursday = new DateOnly(2022, 4, 14),
                        Ascension = new DateOnly(2022, 5, 26),
                        Pentecost = new DateOnly(2022, 6, 5)
                    },
                    new HolyDays
                    {
                        Year = 2023,
                        AshWednesday = new DateOnly(2023, 2, 22),
                        EasterSunday = new DateOnly(2023, 4, 9),
                        HolySaturday = new DateOnly(2023, 4, 8),
                        GoodFriday = new DateOnly(2023, 4, 7),
                        MaundyThursday = new DateOnly(2023, 4, 6),
                        Ascension = new DateOnly(2023, 5, 18),
                        Pentecost = new DateOnly(2023, 5, 28)
                    },
                    new HolyDays
                    {
                        Year = 2024,
                        AshWednesday = new DateOnly(2023, 2, 14),
                        EasterSunday = new DateOnly(2023, 3, 31),
                        HolySaturday = new DateOnly(2023, 4, 30),
                        GoodFriday = new DateOnly(2023, 4, 29),
                        MaundyThursday = new DateOnly(2023, 4, 28),
                        Ascension = new DateOnly(2023, 5, 10),
                        Pentecost = new DateOnly(2023, 5, 20)
                    },
                    new HolyDays
                    {
                        Year = 2025,
                        AshWednesday = new DateOnly(2025, 3, 5),
                        EasterSunday = new DateOnly(2025, 4, 20),
                        HolySaturday = new DateOnly(2025, 4, 19),
                        GoodFriday = new DateOnly(2025, 4, 18),
                        MaundyThursday = new DateOnly(2025, 4, 17),
                        Ascension = new DateOnly(2025, 5, 29),
                        Pentecost = new DateOnly(2025, 6, 8)
                    },
                    new HolyDays
                    {
                        Year = 2026,
                        AshWednesday = new DateOnly(2026, 2, 18),
                        EasterSunday = new DateOnly(2026, 4, 5),
                        HolySaturday = new DateOnly(2026, 4, 4),
                        GoodFriday = new DateOnly(2026, 4, 3),
                        MaundyThursday = new DateOnly(2026, 4, 2),
                        Ascension = new DateOnly(2026, 5, 14),
                        Pentecost = new DateOnly(2026, 5, 24)
                    },
                    new HolyDays
                    {
                        Year = 2027,
                        AshWednesday = new DateOnly(2027, 2, 10),
                        EasterSunday = new DateOnly(2027, 3, 28),
                        HolySaturday = new DateOnly(2027, 3, 27),
                        GoodFriday = new DateOnly(2027, 3, 26),
                        MaundyThursday = new DateOnly(2027, 3, 25),
                        Ascension = new DateOnly(2027, 5, 6),
                        Pentecost = new DateOnly(2027, 5, 16)
                    },
                    new HolyDays
                    {
                        Year = 2028,
                        AshWednesday = new DateOnly(2028, 3, 1),
                        EasterSunday = new DateOnly(2028, 4, 16),
                        HolySaturday = new DateOnly(2028, 4, 15),
                        GoodFriday = new DateOnly(2028, 4, 14),
                        MaundyThursday = new DateOnly(2028, 4, 13),
                        Ascension = new DateOnly(2028, 5, 25),
                        Pentecost = new DateOnly(2028, 6, 4)
                    },
                };
            }
        }

        public static List<List<string>> Office
        {
            get
            {
                return new List<List<string>>
                {
                    new List<string> //1/1
                    {
                        "Psalm 1-2",
                        "Genesis 1",
                        "John 1:1-28",
                        "Psalm 3-4",
                        "Galatians 1",
                        "Luke 2:8-21"
                    },
                    new List<string> //1/2
                    {
                        "Psalm 5-6",
                        "Genesis 2",
                        "John 1:29-51",
                        "Psalm 7",
                        "Jeremiah 1",
                        "Galatians 2"
                    },
                    new List<string> //1/3
                    {
                        "Psalm 9",
                        "Genesis 3",
                        "John 2",
                        "Psalm 10",
                        "Jeremiah 2",
                        "Galatians 3"
                    },
                    new List<string> //1/4
                    {
                        "Psalm 8",
                        "Psalm 11",
                        "Genesis 4",
                        "John 3:1-21",
                        "Psalm 15-16",
                        "Jeremiah 3",
                        "Galatians 4"
                    },
                    new List<string> //1/5
                    {
                        "Psalm 12-14",
                        "Genesis 5",
                        "John 3:22-36",
                        "Psalm 17",
                        "Jeremiah 4",
                        "Galatians 5"
                    },
                    new List<string> //1/6
                    {
                        "Psalm 96-97",
                        "Genesis 6",
                        "Matthew 2:1-12",
                        "Psalm 67",
                        "Psalm 72",
                        "Jeremiah 5",
                        "John 2:1-12"
                    },
                    new List<string> //1/7
                    {
                        "Psalm 18:1-20",
                        "Genesis 7",
                        "John 4:1-26",
                        "Psalm 18:21-52",
                        "Jeremiah 6",
                        "Galatians 6"
                    },
                    new List<string> //1/8
                    {
                        "Psalm 19",
                        "Genesis 8",
                        "John 4:27-54",
                        "Psalm 20-21",
                        "Jeremiah 7",
                        "1 Thessalonians 1"
                    },
                    new List<string> //1/9
                    {
                        "Psalm 22",
                        "Genesis 9",
                        "John 5:1-24",
                        "Psalm 23-24",
                        "Jeremiah 8",
                        "1 Thessalonians 2:1-16"
                    },
                    new List<string> //1/10
                    {
                        "Psalm 25",
                        "Genesis 10",
                        "John 5:25-47",
                        "Psalm 27",
                        "Jeremiah 9",
                        "1 Thessalonians 2:17-3:13"
                    },
                    new List<string> //1/11
                    {
                        "Psalm 26",
                        "Psalm 28",
                        "Genesis 11",
                        "John 6:1-21",
                        "Psalm 31",
                        "Jeremiah 10",
                        "1 Thessalonians 4:1-12"
                    },
                    new List<string> //1/12
                    {
                        "Psalm 29-30",
                        "Genesis 12",
                        "John 6:22-40",
                        "Psalm 33",
                        "Jeremiah 11",
                        "1 Thessalonians 4:13-5:11"
                    },
                    new List<string> //1/13
                    {
                        "Psalm 34",
                        "Genesis 13",
                        "John 6:41-71",
                        "Psalm 35",
                        "Jeremiah 12",
                        "1 Thessalonians 5:12-28"
                    },
                    new List<string> //1/14
                    {
                        "Psalm 32",
                        "Psalm 36",
                        "Genesis 14",
                        "John 7:1-24",
                        "Psalm 38",
                        "Jeremiah 13",
                        "2 Thessalonians 1"
                    },
                    new List<string> //1/15
                    {
                        "Psalm 37:1-17",
                        "Genesis 15",
                        "John 7:25-52",
                        "Psalm 37:18-41",
                        "Jeremiah 14",
                        "2 Thessalonians 2"
                    },
                    new List<string> //1/16
                    {
                        "Psalm 40",
                        "Genesis 16",
                        "John 7:53-8:30",
                        "Psalm 39",
                        "Psalm 41",
                        "Jeremiah 15",
                        "2 Thessalonians 3"
                    },
                    new List<string> //1/17
                    {
                        "Psalm 42-43",
                        "Genesis 17",
                        "John 8:31-59",
                        "Psalm 44",
                        "Jeremiah 16",
                        "1 Corinthians 1:1-25"
                    },
                    new List<string> //1/18
                    {
                        "Psalm 45",
                        "Genesis 18",
                        "Matthew 16:13-20",
                        "Psalm 46",
                        "Jeremiah 17",
                        "1 Corinthians 1:26-2:16"
                    },
                    new List<string> //1/19
                    {
                        "Psalm 47-48",
                        "Genesis 19",
                        "John 9",
                        "Psalm 49",
                        "Jeremiah 18",
                        "1 Corinthians 3"
                    },
                    new List<string> //1/20
                    {
                        "Psalm 50",
                        "Genesis 20",
                        "John 10:1-21",
                        "Psalm 51",
                        "Jeremiah 19",
                        "1 Corinthians 4:1-17"
                    },
                    new List<string> //1/21
                    {
                        "Psalm 52-54",
                        "Genesis 21",
                        "John 10:22-42",
                        "Psalm 55",
                        "Jeremiah 20",
                        "1 Corinthians 4:18-5:13"
                    },
                    new List<string> //1/22
                    {
                        "Psalm 56-57",
                        "Genesis 22",
                        "John 11:1-44",
                        "Psalm 58",
                        "Psalm 60",
                        "Jeremiah 21",
                        "1 Corinthians 6"
                    },
                    new List<string> //1/23
                    {
                        "Psalm 59",
                        "Genesis 23",
                        "John 11:45-57",
                        "Psalm 63-64",
                        "Jeremiah 22",
                        "1 Corinthians 7"
                    },
                    new List<string> //1/24
                    {
                        "Psalm 61-62",
                        "Genesis 24",
                        "John 12:1-19",
                        "Psalm 65",
                        "Psalm 67",
                        "Jeremiah 23",
                        "1 Corinthians 8"
                    },
                    new List<string> //1/25
                    {
                        "Psalm 68:1-18",
                        "Acts 9:1-22",
                        "John 12:20-50",
                        "Psalm 68:19-36",
                        "Jeremiah 24",
                        "1 Corinthians 9"
                    },
                    new List<string> //1/26
                    {
                        "Psalm 69:1-18",
                        "Genesis 25",
                        "John 13",
                        "Psalm 69:19-37",
                        "Jeremiah 25",
                        "1 Corinthians 10"
                    },
                    new List<string> //1/27
                    {
                        "Psalm 66",
                        "Genesis 26",
                        "John 14:1-14",
                        "Psalm 70",
                        "Psalm 72",
                        "Jeremiah 26",
                        "1 Corinthians 11"
                    },
                    new List<string> //1/28
                    {
                        "Psalm 71",
                        "Genesis 27",
                        "John 14:15-31",
                        "Psalm 73",
                        "Jeremiah 27",
                        "1 Corinthians 12"
                    },
                    new List<string> //1/29
                    {
                        "Psalm 74",
                        "Genesis 28",
                        "John 15:1-17",
                        "Psalm 77",
                        "Jeremiah 28",
                        "1 Corinthians 13"
                    },
                    new List<string> //1/30
                    {
                        "Psalm 75-76",
                        "Genesis 29",
                        "John 15:18-27",
                        "Psalm 79",
                        "Psalm 82",
                        "Jeremiah 29",
                        "1 Corinthians 14:1-19"
                    },
                    new List<string> //1/31
                    {
                        "Psalm 78:1-18",
                        "Genesis 30",
                        "John 16:1-15",
                        "Psalm 78:19-40",
                        "Jeremiah 30",
                        "1 Corinthians 14:20-40"
                    },
                    new List<string> //2/1
                    {
                        "Psalm 78:41-73",
                        "Genesis 31",
                        "John 16:16-33",
                        "Psalm 80",
                        "Jeremiah 31",
                        "1 Corinthians 15:1-34"
                    },
                    new List<string> //2/2
                    {
                        "Psalm 24",
                        "Psalm 81",
                        "Genesis 32",
                        "Luke 2:22-40",
                        "Psalm 84",
                        "Jeremiah 32",
                        "1 Corinthians 15:35-58"
                    },
                    new List<string> //2/3
                    {
                        "Psalm 83",
                        "Genesis 33",
                        "John 17",
                        "Psalm 85",
                        "Jeremiah 33",
                        "1 Corinthians 16"
                    },
                    new List<string> //2/4
                    {
                        "Psalm 86-87",
                        "Genesis 34",
                        "John 18:1-27",
                        "Psalm 88",
                        "Jeremiah 34",
                        "2 Corinthians 1:1-2:11"
                    },
                    new List<string> //2/5
                    {
                        "Psalm 89:1-18",
                        "Genesis 35",
                        "John 18:28-40",
                        "Psalm 89:19-51",
                        "Jeremiah 35",
                        "2 Corinthians 2:12-3:18"
                    },
                    new List<string> //2/6
                    {
                        "Psalm 90",
                        "Genesis 36",
                        "John 19:1-37",
                        "Psalm 91",
                        "Jeremiah 36",
                        "2 Corinthians 4"
                    },
                    new List<string> //2/7
                    {
                        "Psalm 92-93",
                        "Genesis 37",
                        "John 19:38-42",
                        "Psalm 94",
                        "Jeremiah 37",
                        "2 Corinthians 5"
                    },
                    new List<string> //2/8
                    {
                        "Psalm 95-96",
                        "Genesis 38",
                        "John 20",
                        "Psalm 97-98",
                        "Jeremiah 38",
                        "2 Corinthians 6"
                    },
                    new List<string> //2/9
                    {
                        "Psalm 99-101",
                        "Genesis 39",
                        "John 21",
                        "Psalm 102",
                        "Jeremiah 39",
                        "2 Corinthians 7"
                    },
                    new List<string> //2/10
                    {
                        "Psalm 103",
                        "Genesis 40",
                        "John 1:1-17",
                        "Psalm 104",
                        "Jeremiah 40",
                        "2 Corinthians 8"
                    },
                    new List<string> //2/11
                    {
                        "Psalm 105:1-22",
                        "Genesis 41",
                        "John 1:18-25",
                        "Psalm 105:23-44",
                        "Jeremiah 41",
                        "2 Corinthians 9"
                    },
                    new List<string> //2/12
                    {
                        "Psalm 106:1-18",
                        "Genesis 42",
                        "Matthew 2",
                        "Psalm 106:19-46",
                        "Jeremiah 42",
                        "2 Corinthians 10"
                    },
                    new List<string> //2/13
                    {
                        "Psalm 107:1-22",
                        "Genesis 43",
                        "Matthew 3",
                        "Psalm 107:23-43",
                        "Jeremiah 43",
                        "2 Corinthians 11"
                    },
                    new List<string> //2/14
                    {
                        "Psalm 108",
                        "Psalm 110",
                        "Genesis 44",
                        "Matthew 4",
                        "Psalm 109",
                        "Jeremiah 44",
                        "2 Corinthians 12:1-13"
                    },
                    new List<string> //2/15
                    {
                        "Psalm 111-112",
                        "Genesis 45",
                        "Matthew 5:1-20",
                        "Psalm 113-114",
                        "Jeremiah 45",
                        "2 Corinthians 12:14-13:14"
                    },
                    new List<string> //2/16
                    {
                        "Psalm 115",
                        "Genesis 46",
                        "Matthew 5:21-48",
                        "Psalm 116-117",
                        "Jeremiah 46",
                        "Romans 1"
                    },
                    new List<string> //2/17
                    {
                        "Psalm 119:1-24",
                        "Genesis 47",
                        "Matthew 6:1-18",
                        "Psalm 119:25-48",
                        "Jeremiah 47",
                        "Romans 2"
                    },
                    new List<string> //2/18
                    {
                        "Psalm 119:49-72",
                        "Genesis 48",
                        "Matthew 6:19-34",
                        "Psalm 119:73-88",
                        "Jeremiah 48",
                        "Romans 3"
                    },
                    new List<string> //2/19
                    {
                        "Psalm 119:89-104",
                        "Genesis 49",
                        "Matthew 7",
                        "Psalm 119:105-128",
                        "Jeremiah 49",
                        "Romans 4"
                    },
                    new List<string> //2/20
                    {
                        "Psalm 119:129-152",
                        "Genesis 50",
                        "Matthew 8:1-17",
                        "Psalm 119:153-176",
                        "Jeremiah 50",
                        "Romans 5"
                    },
                    new List<string> //2/21
                    {
                        "Psalm 118",
                        "Exodus 1",
                        "Matthew 8:18-34",
                        "Psalm 120-121",
                        "Jeremiah 51",
                        "Romans 6"
                    },
                    new List<string> //2/22
                    {
                        "Psalm 122-123",
                        "Exodus 2",
                        "Matthew 9:1-17",
                        "Psalm 124-126",
                        "Jeremiah 52",
                        "Romans 7"
                    },
                    new List<string> //2/23
                    {
                        "Psalm 127-128",
                        "Exodus 3",
                        "Matthew 9:18-34",
                        "Psalm 129-131",
                        "Baruch 4",
                        "Romans 8:1-17"
                    },
                    new List<string> //2/24
                    {
                        "Psalm 132-133",
                        "Acts 1:15-26",
                        "Matthew 9:35-10:23",
                        "Psalm 134-135",
                        "Baruch 5",
                        "Romans 8:18-39"
                    },
                    new List<string> //2/25
                    {
                        "Psalm 136",
                        "Exodus 4",
                        "Matthew 10:24-42",
                        "Psalm 137-138",
                        "Lamentations 1",
                        "Romans 9"
                    },
                    new List<string> //2/26
                    {
                        "Psalm 139",
                        "Exodus 5",
                        "Matthew 11",
                        "Psalm 141-142",
                        "Lamentations 2",
                        "Romans 10"
                    },
                    new List<string> //2/27
                    {
                        "Psalm 140",
                        "Exodus 6",
                        "Matthew 12:1-21",
                        "Psalm 143",
                        "Lamentations 3",
                        "Romans 11"
                    },
                    new List<string> //2/28
                    {
                        "Psalm 144",
                        "Exodus 7",
                        "Matthew 12:22-50",
                        "Psalm 145",
                        "Lamentations 4",
                        "Romans 12"
                    },
                    new List<string> //3/1
                    {
                        "Psalm 146",
                        "Exodus 8",
                        "Matthew 13:1-23",
                        "Psalm 147",
                        "Lamentations 5",
                        "Romans 13"
                    },
                    new List<string> //3/2
                    {
                        "Psalm 148",
                        "Exodus 9",
                        "Matthew 13:24-43",
                        "Psalm 149-150",
                        "Proverbs 1",
                        "Romans 14"
                    },
                    new List<string> //3/3
                    {
                        "Psalm 1-2",
                        "Exodus 10",
                        "Matthew 13:44-58",
                        "Psalm 3-4",
                        "Proverbs 2",
                        "Romans 15"
                    },
                    new List<string> //3/4
                    {
                        "Psalm 5-6",
                        "Exodus 11",
                        "Matthew 14",
                        "Psalm 7",
                        "Proverbs 3",
                        "Romans 16"
                    },
                    new List<string> //3/5
                    {
                        "Psalm 9",
                        "Exodus 12",
                        "Matthew 15:1-28",
                        "Psalm 10",
                        "Proverbs 4",
                        "Philippians 1:1-11"
                    },
                    new List<string> //3/6
                    {
                        "Psalm 8",
                        "Psalm 11",
                        "Exodus 13",
                        "Matthew 15:29-16:12",
                        "Psalm 15-16",
                        "Proverbs 5",
                        "Philippians 1:12-30"
                    },
                    new List<string> //3/7
                    {
                        "Psalm 12-14",
                        "Psalm 11",
                        "Exodus 14",
                        "Matthew 16:13-28",
                        "Psalm 17",
                        "Proverbs 6",
                        "Philippians 2:1-11"
                    },
                    new List<string> //3/8
                    {
                        "Psalm 18:1-20",
                        "Exodus 15",
                        "Matthew 17:1-23",
                        "Psalm 18:21-52",
                        "Proverbs 7",
                        "Philippians 2:12-30"
                    },
                    new List<string> //3/9
                    {
                        "Psalm 19",
                        "Exodus 16",
                        "Matthew 17:24-18:14",
                        "Psalm 20-21",
                        "Proverbs 8",
                        "Philippians 3"
                    },
                    new List<string> //3/10
                    {
                        "Psalm 22",
                        "Exodus 17",
                        "Matthew 18:15-35",
                        "Psalm 23-24",
                        "Proverbs 9",
                        "Philippians 4"
                    },
                    new List<string> //3/11
                    {
                        "Psalm 25",
                        "Exodus 18",
                        "Matthew 19:1-15",
                        "Psalm 27",
                        "Proverbs 10",
                        "Colossians 1:1-20"
                    },
                    new List<string> //3/12
                    {
                        "Psalm 26",
                        "Psalm 28",
                        "Exodus 19",
                        "Matthew 19:16-20:16",
                        "Psalm 31",
                        "Proverbs 11",
                        "Colossians 1:21-2:7"
                    },
                    new List<string> //3/13
                    {
                        "Psalm 29-30",
                        "Exodus 20",
                        "Matthew 20:17-34",
                        "Psalm 33",
                        "Proverbs 12",
                        "Colossians 2:8-19"
                    },
                    new List<string> //3/14
                    {
                        "Psalm 34",
                        "Exodus 21",
                        "Matthew 21:1-22",
                        "Psalm 35",
                        "Proverbs 13",
                        "Colossians 2:20-3:11"
                    },
                    new List<string> //3/15
                    {
                        "Psalm 32",
                        "Psalm 36",
                        "Exodus 22",
                        "Matthew 21:23-46",
                        "Psalm 38",
                        "Proverbs 14",
                        "Colossians 3:12-25"
                    },
                    new List<string> //3/16
                    {
                        "Psalm 37:1-17",
                        "Exodus 23",
                        "Matthew 22:1-33",
                        "Psalm 37:18-41",
                        "Proverbs 15",
                        "Colossians 4"
                    },
                    new List<string> //3/17
                    {
                        "Psalm 40",
                        "Exodus 24",
                        "Matthew 22:34-23:12",
                        "Psalm 39",
                        "Psalm 41",
                        "Proverbs 16",
                        "Philemon 1"
                    },
                    new List<string> //3/18
                    {
                        "Psalm 42-43",
                        "Exodus 25",
                        "Matthew 23:13-39",
                        "Psalm 44",
                        "Proverbs 17",
                        "Ephesians 1:1-14"
                    },
                    new List<string> //3/19
                    {
                        "Psalm 45",
                        "Exodus 26",
                        "Matthew 24:1-28",
                        "Psalm 46",
                        "Ephesians 1:15-23",
                        "Matthew 1:18-25"
                    },
                    new List<string> //3/20
                    {
                        "Psalm 47-48",
                        "Exodus 27",
                        "Matthew 24:29-51",
                        "Psalm 49",
                        "Proverbs 18",
                        "Ephesians 2:1-10"
                    },
                    new List<string> //3/21
                    {
                        "Psalm 50",
                        "Exodus 28",
                        "Matthew 25:1-30",
                        "Psalm 51",
                        "Proverbs 19",
                        "Ephesians 2:11-22"
                    },
                    new List<string> //3/22
                    {
                        "Psalm 52-54",
                        "Exodus 29",
                        "Matthew 25:31-46",
                        "Psalm 55",
                        "Proverbs 20",
                        "Ephesians 3"
                    },
                    new List<string> //3/23
                    {
                        "Psalm 56-57",
                        "Exodus 30",
                        "Matthew 26:1-30",
                        "Psalm 58",
                        "Psalm 60",
                        "Proverbs 21",
                        "Ephesians 4:1-16"
                    },
                    new List<string> //3/24
                    {
                        "Psalm 59",
                        "Exodus 31",
                        "Matthew 26:31-56",
                        "Psalm 63-64",
                        "Proverbs 22",
                        "Ephesians 4:17-32"
                    },
                    new List<string> //3/25
                    {
                        "Psalm 113",
                        "Psalm 138",
                        "Exodus 32",
                        "Luke 1:26-38",
                        "Psalm 131-132",
                        "Proverbs 23",
                        "Ephesians 5:1-17"
                    },
                    new List<string> //3/26
                    {
                        "Psalm 61-62",
                        "Exodus 33",
                        "Matthew 26:57-75",
                        "Psalm 65",
                        "Psalm 67",
                        "Proverbs 24",
                        "Ephesians 5:18-33"
                    },
                    new List<string> //3/27
                    {
                        "Psalm 68:1-18",
                        "Exodus 34",
                        "Matthew 27:1-26",
                        "Psalm 68:19-36",
                        "Proverbs 25",
                        "Ephesians 6:1-9"
                    },
                    new List<string> //3/28
                    {
                        "Psalm 69:1-18",
                        "Exodus 35",
                        "Matthew 27:27-56",
                        "Psalm 69:19-37",
                        "Proverbs 26",
                        "Ephesians 6:10-24"
                    },
                    new List<string> //3/29
                    {
                        "Psalm 66",
                        "Exodus 36",
                        "Matthew 27:57-28:20",
                        "Psalm 70",
                        "Psalm 72",
                        "Proverbs 27",
                        "1 Timothy 1:1-17"
                    },
                    new List<string> //3/30
                    {
                        "Psalm 71",
                        "Exodus 37",
                        "Mark 1:1-13",
                        "Psalm 73",
                        "Proverbs 28",
                        "1 Timothy 1:18-2:15"
                    },
                    new List<string> //3/31
                    {
                        "Psalm 74",
                        "Exodus 38",
                        "Mark 1:14-31",
                        "Psalm 77",
                        "Proverbs 29",
                        "1 Timothy 3"
                    },
                    new List<string> //4/1
                    {
                        "Psalm 75-76",
                        "Exodus 39",
                        "Mark 1:32-45",
                        "Psalm 79",
                        "Psalm 82",
                        "Proverbs 30",
                        "1 Timothy 4"
                    },
                    new List<string> //4/2
                    {
                        "Psalm 78:1-18",
                        "Exodus 40",
                        "Mark 2:1-22",
                        "Psalm 78:19-40",
                        "Proverbs 31",
                        "1 Timothy 5"
                    },
                    new List<string> //4/3
                    {
                        "Psalm 78:41-73",
                        "Leviticus 1",
                        "Mark 2:23-3:12",
                        "Psalm 80",
                        "Job 1",
                        "1 Timothy 6"
                    },
                    new List<string> //4/4
                    {
                        "Psalm 81",
                        "Leviticus 8",
                        "Mark 3:13-35",
                        "Psalm 83",
                        "Job 2",
                        "Titus 1"
                    },
                    new List<string> //4/5
                    {
                        "Psalm 84",
                        "Leviticus 10",
                        "Mark 4:1-34",
                        "Psalm 85",
                        "Job 3",
                        "Titus 2"
                    },
                    new List<string> //4/6
                    {
                        "Psalm 86-87",
                        "Leviticus 16",
                        "Mark 4:35-5:20",
                        "Psalm 88",
                        "Job 4",
                        "Titus 3"
                    },
                    new List<string> //4/7
                    {
                        "Psalm 89:1-18",
                        "Leviticus 17",
                        "Mark 5:21-43",
                        "Psalm 89:19-51",
                        "Job 5",
                        "2 Timothy 1"
                    },
                    new List<string> //4/8
                    {
                        "Psalm 90",
                        "Leviticus 18",
                        "Mark 6:1-29",
                        "Psalm 91",
                        "Job 6",
                        "2 Timothy 2"
                    },
                    new List<string> //4/9
                    {
                        "Psalm 92-93",
                        "Leviticus 19",
                        "Mark 6:30-56",
                        "Psalm 94",
                        "Job 7",
                        "2 Timothy 3"
                    },
                    new List<string> //4/10
                    {
                        "Psalm 95-96",
                        "Leviticus 20",
                        "Mark 7:1-23",
                        "Psalm 97-98",
                        "Job 8",
                        "2 Timothy 4"
                    },
                    new List<string> //4/11
                    {
                        "Psalm 99-101",
                        "Leviticus 23",
                        "Mark 7:24-8:10",
                        "Psalm 102",
                        "Job 9",
                        "Hebrews 1"
                    },
                    new List<string> //4/12
                    {
                        "Psalm 103",
                        "Leviticus 26",
                        "Mark 8:11-38",
                        "Psalm 104",
                        "Job 10",
                        "Hebrews 2"
                    },
                    new List<string> //4/13
                    {
                        "Psalm 105:1-22",
                        "Numbers 6",
                        "Mark 9:1-29",
                        "Psalm 105:23-44",
                        "Job 11",
                        "Hebrews 3"
                    },
                    new List<string> //4/14
                    {
                        "Psalm 106:1-18",
                        "Numbers 8",
                        "Mark 9:30-50",
                        "Psalm 106:19-46",
                        "Job 12",
                        "Hebrews 4:1-13"
                    },
                    new List<string> //4/15
                    {
                        "Psalm 107:1-22",
                        "Numbers 11",
                        "Mark 10:1-31",
                        "Psalm 107:23-43",
                        "Job 13",
                        "Hebrews 4:14-5:10"
                    },
                    new List<string> //4/16
                    {
                        "Psalm 108",
                        "Psalm 110",
                        "Numbers 12",
                        "Mark 10:32-52",
                        "Psalm 109",
                        "Job 14",
                        "Hebrews 5:1-6:20"
                    },
                    new List<string> //4/17
                    {
                        "Psalm 111-112",
                        "Numbers 13",
                        "Mark 11:1-26",
                        "Psalm 113-114",
                        "Job 15",
                        "Hebrews 7"
                    },
                    new List<string> //4/18
                    {
                        "Psalm 115",
                        "Numbers 14",
                        "Mark 11:27-12:12",
                        "Psalm 116-117",
                        "Job 16",
                        "Hebrews 8"
                    },
                    new List<string> //4/19
                    {
                        "Psalm 119:1-24",
                        "Numbers 15",
                        "Mark 12:13-34",
                        "Psalm 119:25-48",
                        "Job 17",
                        "Hebrews 9:1-14"
                    },
                    new List<string> //4/20
                    {
                        "Psalm 119:49-72",
                        "Numbers 16",
                        "Mark 12:35-13:13",
                        "Psalm 119:73-88",
                        "Job 18",
                        "Hebrews 9:15-28"
                    },
                    new List<string> //4/21
                    {
                        "Psalm 119:89-104",
                        "Numbers 17",
                        "Mark 13:14-37",
                        "Psalm 119:105-128",
                        "Job 19",
                        "Hebrews 10:1-18"
                    },
                    new List<string> //4/22
                    {
                        "Psalm 119:129-152",
                        "Numbers 18",
                        "Mark 14:1-25",
                        "Psalm 119:153-176",
                        "Job 20",
                        "Hebrews 10:19-39"
                    },
                    new List<string> //4/23
                    {
                        "Psalm 118",
                        "Numbers 20",
                        "Mark 14:26-52",
                        "Psalm 120-121",
                        "Job 21",
                        "Hebrews 11"
                    },
                    new List<string> //4/24
                    {
                        "Psalm 122-123",
                        "Numbers 21",
                        "Mark 14:53-72",
                        "Psalm 124-126",
                        "Job 22",
                        "Hebrews 12:1-17"
                    },
                    new List<string> //4/25
                    {
                        "Psalm 127-128",
                        "Acts 12:11-25",
                        "Mark 15",
                        "Psalm 129-131",
                        "Job 23",
                        "Hebrews 12:18-29"
                    },
                    new List<string> //4/26
                    {
                        "Psalm 132-133",
                        "Numbers 22",
                        "Mark 16",
                        "Psalm 134-135",
                        "Job 24",
                        "Hebrews 13"
                    },
                    new List<string> //4/27
                    {
                        "Psalm 136",
                        "Numbers 23",
                        "Luke 1:1-23",
                        "Psalm 137-138",
                        "Job 25-26",
                        "James 1"
                    },
                    new List<string> //4/28
                    {
                        "Psalm 139",
                        "Numbers 24",
                        "Luke 1:24-56",
                        "Psalm 141-142",
                        "Job 27",
                        "James 2:1-13"
                    },
                    new List<string> //4/29
                    {
                        "Psalm 140",
                        "Numbers 25",
                        "Luke 1:57-80",
                        "Psalm 143",
                        "Job 28",
                        "James 2:14-26"
                    },
                    new List<string> //4/30
                    {
                        "Psalm 144",
                        "Deuteronomy 1",
                        "Luke 2:1-21",
                        "Psalm 145",
                        "Job 29",
                        "James 3"
                    },
                    new List<string> //5/1
                    {
                        "Psalm 146",
                        "Deuteronomy 2",
                        "Luke 2:22-52",
                        "Psalm 147",
                        "James 4",
                        "John 1:43-51"
                    },
                    new List<string> //5/2
                    {
                        "Psalm 148",
                        "Deuteronomy 3",
                        "Luke 3:1-22",
                        "Psalm 149-150",
                        "Job 30",
                        "James 5"
                    },
                    new List<string> //5/3
                    {
                        "Psalm 1-2",
                        "Deuteronomy 4",
                        "Luke 3:23-38",
                        "Psalm 3-4",
                        "Job 31",
                        "1 Peter 1:1-21"
                    },
                    new List<string> //5/4
                    {
                        "Psalm 5-6",
                        "Deuteronomy 5",
                        "Luke 4:1-30",
                        "Psalm 7",
                        "Job 32",
                        "1 Peter 1:22-2:10"
                    },
                    new List<string> //5/5
                    {
                        "Psalm 9",
                        "Deuteronomy 6",
                        "Luke 4:31-44",
                        "Psalm 10",
                        "Job 33",
                        "1 Peter 2:11-3:7"
                    },
                    new List<string> //5/6
                    {
                        "Psalm 8",
                        "Psalm 11",
                        "Deuteronomy 7",
                        "Luke 5:1-16",
                        "Psalm 15-16",
                        "Job 34",
                        "1 Peter 3:8-4:6"
                    },
                    new List<string> //5/7
                    {
                        "Psalm 12-14",
                        "Deuteronomy 8",
                        "Luke 5:17-39",
                        "Psalm 17",
                        "Job 35",
                        "1 Peter 4:7-19"
                    },
                    new List<string> //5/8
                    {
                        "Psalm 18:1-20",
                        "Deuteronomy 9",
                        "Luke 6:1-19",
                        "Psalm 18:21-52",
                        "Job 36",
                        "1 Peter 5"
                    },
                    new List<string> //5/9
                    {
                        "Psalm 19",
                        "Deuteronomy 10",
                        "Luke 6:20-38",
                        "Psalm 20-21",
                        "Job 37",
                        "2 Peter 1"
                    },
                    new List<string> //5/10
                    {
                        "Psalm 22",
                        "Deuteronomy 11",
                        "Luke 6:39-7:10",
                        "Psalm 23-24",
                        "Job 38",
                        "2 Peter 2"
                    },
                    new List<string> //5/11
                    {
                        "Psalm 25",
                        "Deuteronomy 12",
                        "Luke 7:11-35",
                        "Psalm 27",
                        "Job 39",
                        "2 Peter 3"
                    },
                    new List<string> //5/12
                    {
                        "Psalm 26",
                        "Psalm 28",
                        "Deuteronomy 13",
                        "Luke 7:36-50",
                        "Psalm 31",
                        "Job 40",
                        "Jude 1"
                    },
                    new List<string> //5/13
                    {
                        "Psalm 29-30",
                        "Deuteronomy 14",
                        "Luke 8:1-21",
                        "Psalm 33",
                        "Job 41",
                        "1 John 1:1-26"
                    },
                    new List<string> //5/14
                    {
                        "Psalm 34",
                        "Deuteronomy 15",
                        "Luke 8:22-56",
                        "Psalm 35",
                        "Job 42",
                        "1 John 2:7-29"
                    },
                    new List<string> //5/15
                    {
                        "Psalm 32",
                        "Psalm 36",
                        "Deuteronomy 16",
                        "Luke 9:1-17",
                        "Psalm 38",
                        "Ecclesiastes 1",
                        "1 John 3:1-10"
                    },
                    new List<string> //5/16
                    {
                        "Psalm 37:1-17",
                        "Deuteronomy 17",
                        "Luke 9:18-50",
                        "Psalm 37:18-41",
                        "Ecclesiastes 2",
                        "1 John 3:11-4:6"
                    },
                    new List<string> //5/17
                    {
                        "Psalm 40",
                        "Deuteronomy 18",
                        "Luke 9:51-62",
                        "Psalm 39",
                        "Psalm 41",
                        "Ecclesiastes 3",
                        "1 John 4:7-21"
                    },
                    new List<string> //5/18
                    {
                        "Psalm 42-43",
                        "Deuteronomy 19",
                        "Luke 10:1-24",
                        "Psalm 44",
                        "Ecclesiastes 4",
                        "1 John 5"
                    },
                    new List<string> //5/19
                    {
                        "Psalm 45",
                        "Deuteronomy 20",
                        "Luke 10:25-42",
                        "Psalm 46",
                        "Ecclesiastes 5",
                        "2 John 1"
                    },
                    new List<string> //5/20
                    {
                        "Psalm 47-48",
                        "Deuteronomy 21",
                        "Luke 11:1-28",
                        "Psalm 49",
                        "Ecclesiastes 6",
                        "3 John 1"
                    },
                    new List<string> //5/21
                    {
                        "Psalm 50",
                        "Deuteronomy 22",
                        "Luke 11:29-54",
                        "Psalm 51",
                        "Ecclesiastes 7",
                        "Acts 1:1-14"
                    },
                    new List<string> //5/22
                    {
                        "Psalm 52-54",
                        "Deuteronomy 23",
                        "Luke 12:1-34",
                        "Psalm 55",
                        "Ecclesiastes 8",
                        "Acts 1:15-26"
                    },
                    new List<string> //5/23
                    {
                        "Psalm 56-57",
                        "Deuteronomy 24",
                        "Luke 12:35-53",
                        "Psalm 58",
                        "Psalm 60",
                        "Ecclesiastes 9",
                        "Acts 2:1-21"
                    },
                    new List<string> //5/24
                    {
                        "Psalm 59",
                        "Deuteronomy 25",
                        "Luke 12:54-13:9",
                        "Psalm 63-64",
                        "Ecclesiastes 10",
                        "Acts 2:22-47"
                    },
                    new List<string> //5/25
                    {
                        "Psalm 61-62",
                        "Deuteronomy 26",
                        "Luke 13:10-35",
                        "Psalm 65",
                        "Psalm 67",
                        "Ecclesiastes 11",
                        "Acts 3:1-4:4"
                    },
                    new List<string> //5/26
                    {
                        "Psalm 68:1-18",
                        "Deuteronomy 27",
                        "Luke 14:1-24",
                        "Psalm 68:19-36",
                        "Ecclesiastes 12",
                        "Acts 4:5-31"
                    },
                    new List<string> //5/27
                    {
                        "Psalm 69:1-18",
                        "Deuteronomy 28",
                        "Luke 14:25-15:10",
                        "Psalm 69:19-37",
                        "Ezekiel 1",
                        "Acts 4:32-5:11"
                    },
                    new List<string> //5/28
                    {
                        "Psalm 66",
                        "Deuteronomy 29",
                        "Luke 15:11-32",
                        "Psalm 70",
                        "Psalm 72",
                        "Ezekiel 2",
                        "Acts 5:12-42"
                    },
                    new List<string> //5/29
                    {
                        "Psalm 71",
                        "Deuteronomy 30",
                        "Luke 16",
                        "Psalm 73",
                        "Ezekiel 3",
                        "Acts 6:1-7:16"
                    },
                    new List<string> //5/30
                    {
                        "Psalm 74",
                        "Deuteronomy 31",
                        "Luke 17:1-19",
                        "Psalm 77",
                        "Ezekiel 4",
                        "Acts 7:17-34"
                    },
                    new List<string> //5/31
                    {
                        "Psalm 75-76",
                        "Deuteronomy 32",
                        "Luke 1:39-56",
                        "Psalm 79",
                        "Psalm 82",
                        "Ezekiel 5",
                        "Acts 7:35-8:3"
                    },
                    new List<string> //6/1
                    {
                        "Psalm 78:1-18",
                        "Deuteronomy 33",
                        "Luke 17:20-37",
                        "Psalm 78:19-40",
                        "Ezekiel 6",
                        "Acts 8:4-25"
                    },
                    new List<string> //6/2
                    {
                        "Psalm 78:41-73",
                        "Deuteronomy 34",
                        "Luke 18:1-30",
                        "Psalm 80",
                        "Ezekiel 7",
                        "Acts 8:26-40"
                    },
                    new List<string> //6/3
                    {
                        "Psalm 81",
                        "Joshua 1",
                        "Luke 18:31-19:10",
                        "Psalm 83",
                        "Ezekiel 8",
                        "Acts 9:1-30"
                    },
                    new List<string> //6/4
                    {
                        "Psalm 84",
                        "Joshua 2",
                        "Luke 19:11-28",
                        "Psalm 85",
                        "Ezekiel 9",
                        "Acts 9:32-43"
                    },
                    new List<string> //6/5
                    {
                        "Psalm 86-87",
                        "Joshua 3",
                        "Luke 19:29-48",
                        "Psalm 88",
                        "Ezekiel 10",
                        "Acts 10:1-23"
                    },
                    new List<string> //6/6
                    {
                        "Psalm 89:1-18",
                        "Joshua 4",
                        "Luke 20:1-26",
                        "Psalm 89:19-51",
                        "Ezekiel 11",
                        "Acts 10:24-48"
                    },
                    new List<string> //6/7
                    {
                        "Psalm 90",
                        "Joshua 5",
                        "Luke 20:27-21:4",
                        "Psalm 91",
                        "Ezekiel 12",
                        "Acts 11:1-18"
                    },
                    new List<string> //6/8
                    {
                        "Psalm 92-93",
                        "Joshua 6",
                        "Luke 21:5-38",
                        "Psalm 94",
                        "Ezekiel 13",
                        "Acts 11:19-30"
                    },
                    new List<string> //6/9
                    {
                        "Psalm 95-96",
                        "Joshua 7",
                        "Luke 22:1-38",
                        "Psalm 97-98",
                        "Ezekiel 14",
                        "Acts 12:1-24"
                    },
                    new List<string> //6/10
                    {
                        "Psalm 99-101",
                        "Joshua 8",
                        "Luke 22:39-53",
                        "Psalm 102",
                        "Ezekiel 15",
                        "Acts 12:25-13:12"
                    },
                    new List<string> //6/11
                    {
                        "Psalm 103",
                        "Acts 4:32-37",
                        "Luke 22:54-71",
                        "Psalm 104",
                        "Ezekiel 16",
                        "Acts 13:13-43"
                    },
                    new List<string> //6/12
                    {
                        "Psalm 105:1-22",
                        "Joshaua 9",
                        "Luke 23:1-25",
                        "Psalm 105:23-44",
                        "Ezekiel 17",
                        "Acts 13:44-14:7"
                    },
                    new List<string> //6/13
                    {
                        "Psalm 106:1-18",
                        "Joshaua 10",
                        "Luke 23:26-49",
                        "Psalm 106:19-46",
                        "Ezekiel 18",
                        "Acts 14:8-28"
                    },
                    new List<string> //6/14
                    {
                        "Psalm 107:1-22",
                        "Joshaua 14",
                        "Luke 23:50-24:12",
                        "Psalm 107:23-43",
                        "Ezekiel 33",
                        "Acts 15:1-21"
                    },
                    new List<string> //6/15
                    {
                        "Psalm 108",
                        "Psalm 110",
                        "Joshaua 22",
                        "Luke 24:13-53",
                        "Psalm 109",
                        "Ezekiel 34",
                        "Acts 15:22-35"
                    },
                    new List<string> //6/16
                    {
                        "Psalm 111-112",
                        "Joshaua 23",
                        "Galatians 1",
                        "Psalm 113-114",
                        "Ezekiel 35",
                        "Acts 15:36-16:5"
                    },
                    new List<string> //6/17
                    {
                        "Psalm 115",
                        "Joshaua 24",
                        "Galatians 2",
                        "Psalm 116-117",
                        "Ezekiel 36",
                        "Acts 16:6-40"
                    },
                    new List<string> //6/18
                    {
                        "Psalm 119:1-24",
                        "Judges 1",
                        "Galatians 3",
                        "Psalm 119:25-48",
                        "Ezekiel 37",
                        "Acts 17:1-15"
                    },
                    new List<string> //6/19
                    {
                        "Psalm 119:49-72",
                        "Judges 2",
                        "Galatians 4",
                        "Psalm 119:73-88",
                        "Ezekiel 40",
                        "Acts 17:16-34"
                    },
                    new List<string> //6/20
                    {
                        "Psalm 119:89-104",
                        "Judges 3",
                        "Galatians 5",
                        "Psalm 119:105-128",
                        "Ezekiel 43",
                        "Acts 18:1-23"
                    },
                    new List<string> //6/21
                    {
                        "Psalm 119:129-152",
                        "Judges 4",
                        "Galatians 6",
                        "Psalm 119:153-176",
                        "Ezekiel 47",
                        "Acts 18:24-19:7"
                    },
                    new List<string> //6/22
                    {
                        "Psalm 118",
                        "Judges 5",
                        "1 Thessalonians 1",
                        "Psalm 120-121",
                        "Daniel 1",
                        "Acts 19:8-20"
                    },
                    new List<string> //6/23
                    {
                        "Psalm 122-123",
                        "Judges 6",
                        "1 Thessalonians 2:1-16",
                        "Psalm 124-126",
                        "Daniel 2",
                        "Acts 19:21-41"
                    },
                    new List<string> //6/24
                    {
                        "Psalm 127-128",
                        "1 Thessalonians 2:17-3:13",
                        "Matthew 14:1-13",
                        "Psalm 129-131",
                        "Daniel 3",
                        "Acts 20:1-16"
                    },
                    new List<string> //6/25
                    {
                        "Psalm 132-133",
                        "Judges 7",
                        "1 Thessalonians 4:1-12",
                        "Psalm 134-135",
                        "Daniel 4",
                        "Acts 20:17-38"
                    },
                    new List<string> //6/26
                    {
                        "Psalm 136",
                        "Judges 8",
                        "1 Thessalonians 4:13-5:11",
                        "Psalm 137-138",
                        "Daniel 5",
                        "Acts 21:1-16"
                    },
                    new List<string> //6/27
                    {
                        "Psalm 139",
                        "Judges 9",
                        "1 Thessalonians 5:12-28",
                        "Psalm 141-142",
                        "Daniel 6",
                        "Acts 21:17-36"
                    },
                    new List<string> //6/28
                    {
                        "Psalm 140",
                        "Judges 10",
                        "2 Thessalonians 1",
                        "Psalm 143",
                        "Daniel 7",
                        "Acts 21:37-22:22"
                    },
                    new List<string> //6/29
                    {
                        "Psalm 144",
                        "2 Thessalonians 2",
                        "2 Peter 3:14-18",
                        "Psalm 145",
                        "Daniel 8",
                        "Acts 22:23-23:11"
                    },
                    new List<string> //6/30
                    {
                        "Psalm 146",
                        "Judges 11",
                        "2 Thessalonians 2",
                        "Psalm 147",
                        "Daniel 9",
                        "Acts 23:12-35"
                    },
                    new List<string> //7/1
                    {
                        "Psalm 148",
                        "Judges 12",
                        "1 Corinthians 1:1-25",
                        "Psalm 149-150",
                        "Daniel 10",
                        "Acts 24:1-23"
                    },
                    new List<string> //7/2
                    {
                        "Psalm 1-2",
                        "Judges 13",
                        "1 Corinthians 1:26-2:16",
                        "Psalm 3-4",
                        "Daniel 11",
                        "Acts 24:24-25:12"
                    },
                    new List<string> //7/3
                    {
                        "Psalm 5-6",
                        "Judges 14",
                        "1 Corinthians 3",
                        "Psalm 7",
                        "Daniel 12",
                        "Acts 25:12-27"
                    },
                    new List<string> //7/4
                    {
                        "Psalm 9",
                        "Judges 15",
                        "1 Corinthians 4:1-17",
                        "Psalm 10",
                        "Susanna 1",
                        "Acts 26"
                    },
                    new List<string> //7/5
                    {
                        "Psalm 8",
                        "Psalm 11",
                        "Judges 16",
                        "1 Corinthians 4:18-5:13",
                        "Psalm 15-16",
                        "Esther 1",
                        "Acts 27"
                    },
                    new List<string> //7/6
                    {
                        "Psalm 12-14",
                        "Ruth 1",
                        "1 Corinthians 6",
                        "Psalm 17",
                        "Esther 2",
                        "Acts 28:1-15"
                    },
                    new List<string> //7/7
                    {
                        "Psalm 18:1-20",
                        "Ruth 2",
                        "1 Corinthians 7",
                        "Psalm 18:21-52",
                        "Esther 3",
                        "Acts 28:16-31"
                    },
                    new List<string> //7/8
                    {
                        "Psalm 19",
                        "Ruth 3",
                        "1 Corinthians 8",
                        "Psalm 20-21",
                        "Esther 4",
                        "Philemon 1"
                    },
                    new List<string> //7/9
                    {
                        "Psalm 22",
                        "Ruth 4",
                        "1 Corinthians 9",
                        "Psalm 23-24",
                        "Esther 5",
                        "1 Timothy 1:1-17"
                    },
                    new List<string> //7/10
                    {
                        "Psalm 25",
                        "1 Samuel 1",
                        "1 Corinthians 10",
                        "Psalm 27",
                        "Esther 6",
                        "1 Timothy 1:18-2:15"
                    },
                    new List<string> //7/11
                    {
                        "Psalm 26",
                        "Psalm 28",
                        "1 Samuel 2",
                        "1 Corinthians 11",
                        "Psalm 31",
                        "Esther 7",
                        "1 Timothy 3"
                    },
                    new List<string> //7/12
                    {
                        "Psalm 29-30",
                        "1 Samuel 3",
                        "1 Corinthians 12",
                        "Psalm 33",
                        "Esther 8",
                        "1 Timothy 4"
                    },
                    new List<string> //7/13
                    {
                        "Psalm 34",
                        "1 Samuel 4",
                        "1 Corinthians 13",
                        "Psalm 35",
                        "Esther 9-10",
                        "1 Timothy 5"
                    },
                    new List<string> //7/14
                    {
                        "Psalm 32",
                        "Psalm 36",
                        "1 Samuel 5",
                        "1 Corinthians 14:1-19",
                        "Psalm 38",
                        "Ezra 1",
                        "1 Timothy 6"
                    },
                    new List<string> //7/15
                    {
                        "Psalm 37:1-17",
                        "1 Samuel 6",
                        "1 Corinthians 14:20-40",
                        "Psalm 37:18-41",
                        "Ezra 3",
                        "Titus 1"
                    },
                    new List<string> //7/16
                    {
                        "Psalm 40",
                        "1 Samuel 7",
                        "1 Corinthians 15:1-34",
                        "Psalm 39",
                        "Psalm 41",
                        "Ezra 4",
                        "Titus 2"
                    },
                    new List<string> //7/17
                    {
                        "Psalm 42-43",
                        "1 Samuel 8",
                        "1 Corinthians 15:35-58",
                        "Psalm 44",
                        "Ezra 5",
                        "Titus 3"
                    },
                    new List<string> //7/18
                    {
                        "Psalm 45",
                        "1 Samuel 9",
                        "1 Corinthians 16",
                        "Psalm 46",
                        "Ezra 6",
                        "2 Timothy 1"
                    },
                    new List<string> //7/19
                    {
                        "Psalm 47-48",
                        "1 Samuel 10",
                        "2 Corinthians 1:1-2:11",
                        "Psalm 49",
                        "Ezra 7",
                        "2 Timothy 2"
                    },
                    new List<string> //7/20
                    {
                        "Psalm 50",
                        "1 Samuel 11",
                        "2 Corinthians 2:12-3:18",
                        "Psalm 51",
                        "Ezra 8",
                        "2 Timothy 3"
                    },
                    new List<string> //7/21
                    {
                        "Psalm 52-54",
                        "1 Samuel 12",
                        "2 Corinthians 4",
                        "Psalm 55",
                        "Ezra 9",
                        "2 Timothy 4"
                    },
                    new List<string> //7/22
                    {
                        "Psalm 56-57",
                        "2 Corinthians 5",
                        "Luke 7:36-8:3",
                        "Psalm 58",
                        "Psalm 60",
                        "Ezra 10",
                        "John 1:1-28"
                    },
                    new List<string> //7/23
                    {
                        "Psalm 59",
                        "1 Samuel 13",
                        "2 Corinthians 6",
                        "Psalm 63-64",
                        "Nehemiah 1",
                        "John 1:29-51"
                    },
                    new List<string> //7/24
                    {
                        "Psalm 61-62",
                        "1 Samuel 14",
                        "2 Corinthians 7",
                        "Psalm 65",
                        "Psalm 67",
                        "Nehemiah 2",
                        "John 2"
                    },
                    new List<string> //7/25
                    {
                        "Psalm 68:1-18",
                        "2 Corinthians 8",
                        "Mark 1:14-20",
                        "Psalm 68:19-36",
                        "Nehemiah 3",
                        "John 3:1-21"
                    },
                    new List<string> //7/26
                    {
                        "Psalm 69:1-18",
                        "1 Samuel 15",
                        "2 Corinthians 9",
                        "Psalm 69:19-37",
                        "Nehemiah 4",
                        "John 3:22-36"
                    },
                    new List<string> //7/27
                    {
                        "Psalm 66",
                        "1 Samuel 16",
                        "2 Corinthians 10",
                        "Psalm 70",
                        "Psalm 72",
                        "Nehemiah 5",
                        "John 4:1-26"
                    },
                    new List<string> //7/28
                    {
                        "Psalm 71",
                        "1 Samuel 17",
                        "2 Corinthians 11",
                        "Psalm 73",
                        "Nehemiah 6",
                        "John 4:27-54"
                    },
                    new List<string> //7/29
                    {
                        "Psalm 74",
                        "1 Samuel 18",
                        "2 Corinthians 12:1-13",
                        "Psalm 77",
                        "Nehemiah 8",
                        "John 5:1-24"
                    },
                    new List<string> //7/30
                    {
                        "Psalm 75",
                        "1 Samuel 19",
                        "2 Corinthians 12:14-13:14",
                        "Psalm 79",
                        "Psalm 82",
                        "Nehemiah 9",
                        "John 5:25-47"
                    },
                    new List<string> //7/31
                    {
                        "Psalm 78:1-18",
                        "1 Samuel 20",
                        "Romans 1",
                        "Psalm 78:19-40",
                        "Nehemiah 10",
                        "John 6:1-21"
                    },
                    new List<string> //8/1
                    {
                        "Psalm 78:41-73",
                        "1 Samuel 21",
                        "Romans 2",
                        "Psalm 80",
                        "Nehemiah 12",
                        "John 6:22-40"
                    },
                    new List<string> //8/2
                    {
                        "Psalm 81",
                        "1 Samuel 22",
                        "Romans 3",
                        "Psalm 83",
                        "Nehemiah 13",
                        "John 6:41-71"
                    },
                    new List<string> //8/3
                    {
                        "Psalm 84",
                        "1 Samuel 23",
                        "Romans 4",
                        "Psalm 85",
                        "Hosea 1",
                        "John 7:1-24"
                    },
                    new List<string> //8/4
                    {
                        "Psalm 86-87",
                        "1 Samuel 24",
                        "Romans 5",
                        "Psalm 88",
                        "Hosea 2",
                        "John 7:25-52"
                    },
                    new List<string> //8/5
                    {
                        "Psalm 89:1-18",
                        "1 Samuel 25",
                        "Romans 6",
                        "Psalm 89:19-51",
                        "Hosea 3",
                        "John 7:53-30"
                    },
                    new List<string> //8/6
                    {
                        "Psalm 27",
                        "Romans 7",
                        "Mark 9:2-10",
                        "Psalm 80",
                        "Hosea 4",
                        "John 8:31-59"
                    },
                    new List<string> //8/7
                    {
                        "Psalm 90",
                        "1 Samuel 26",
                        "Romans 8:1-17",
                        "Psalm 91",
                        "Hosea 5",
                        "John 9"
                    },
                    new List<string> //8/8
                    {
                        "Psalm 92-93",
                        "1 Samuel 27",
                        "Romans 8:18-39",
                        "Psalm 94",
                        "Hosea 6",
                        "John 10:1-21"
                    },
                    new List<string> //8/9
                    {
                        "Psalm 95-96",
                        "1 Samuel 28",
                        "Romans 9",
                        "Psalm 97-98",
                        "Hosea 7",
                        "John 10:22-42"
                    },
                    new List<string> //8/10
                    {
                        "Psalm 99-101",
                        "1 Samuel 29",
                        "Romans 10",
                        "Psalm 102",
                        "Hosea 8",
                        "John 11:1-44"
                    },
                    new List<string> //8/11
                    {
                        "Psalm 103",
                        "1 Samuel 30",
                        "Romans 11",
                        "Psalm 104",
                        "Hosea 9",
                        "John 11:45-57"
                    },
                    new List<string> //8/12
                    {
                        "Psalm 105:1-22",
                        "1 Samuel 31",
                        "Romans 12",
                        "Psalm 105:23-44",
                        "Hosea 10",
                        "John 12:1-19"
                    },
                    new List<string> //8/13
                    {
                        "Psalm 106:1-18",
                        "2 Samuel 1",
                        "Romans 13",
                        "Psalm 106:19-46",
                        "Hosea 11",
                        "John 12:20-50"
                    },
                    new List<string> //8/14
                    {
                        "Psalm 107:1-22",
                        "2 Samuel 2",
                        "Romans 14",
                        "Psalm 107:23-43",
                        "Hosea 12",
                        "John 13"
                    },
                    new List<string> //8/15
                    {
                        "Psalm 108",
                        "Psalm 110",
                        "2 Samuel 3",
                        "Luke 1:26-38",
                        "Psalm 109",
                        "Hosea 13",
                        "John 14:1-14"
                    },
                    new List<string> //8/16
                    {
                        "Psalm 111-112",
                        "2 Samuel 4",
                        "Romans 15",
                        "Psalm 113-114",
                        "Hosea 14",
                        "John 14:15-31"
                    },
                    new List<string> //8/17
                    {
                        "Psalm 115",
                        "2 Samuel 5",
                        "Romans 16",
                        "Psalm 116-117",
                        "Joel 1",
                        "John 15:1-17"
                    },
                    new List<string> //8/18
                    {
                        "Psalm 119:1-24",
                        "2 Samuel 6",
                        "Philippians 1:1-11",
                        "Psalm 119:25-48",
                        "Joel 2",
                        "John 15:18-27"
                    },
                    new List<string> //8/19
                    {
                        "Psalm 119:49-72",
                        "2 Samuel 7",
                        "Philippians 1:12-30",
                        "Psalm 119:73-88",
                        "Joel 3",
                        "John 16:1-15"
                    },
                    new List<string> //8/20
                    {
                        "Psalm 119:89-104",
                        "2 Samuel 8",
                        "Philippians 2:1-11",
                        "Psalm 119:105-128",
                        "Amos 1",
                        "John 16:16-33"
                    },
                    new List<string> //8/21
                    {
                        "Psalm 119:129-152",
                        "2 Samuel 9",
                        "Philippians 2:12-30",
                        "Psalm 119:153-176",
                        "Amos 2",
                        "John 17"
                    },
                    new List<string> //8/22
                    {
                        "Psalm 118",
                        "2 Samuel 10",
                        "Philippians 3",
                        "Psalm 120-121",
                        "Amos 3",
                        "John 18:1-27"
                    },
                    new List<string> //8/23
                    {
                        "Psalm 122-123",
                        "2 Samuel 11",
                        "Philippians 4",
                        "Psalm 124-126",
                        "Amos 4",
                        "John 18:28-40"
                    },
                    new List<string> //8/24
                    {
                        "Psalm 127-128",
                        "Colossians 1:1-20",
                        "Luke 6:12-16",
                        "Psalm 129-131",
                        "Amos 5",
                        "John 19:1-37"
                    },
                    new List<string> //8/25
                    {
                        "Psalm 132-133",
                        "2 Samuel 12",
                        "Colossians 1:21-2:7",
                        "Psalm 134-135",
                        "Amos 6",
                        "John 19:38-42"
                    },
                    new List<string> //8/26
                    {
                        "Psalm 136",
                        "2 Samuel 13",
                        "Colossians 2:8-19",
                        "Psalm 137-138",
                        "Amos 7",
                        "John 20"
                    },
                    new List<string> //8/27
                    {
                        "Psalm 139",
                        "2 Samuel 14",
                        "Colossians 2:20-3:11",
                        "Psalm 141-142",
                        "Amos 8",
                        "John 21"
                    },
                    new List<string> //8/28
                    {
                        "Psalm 140",
                        "2 Samuel 15",
                        "Colossians 3:12-25",
                        "Psalm 143",
                        "Amos 9",
                        "Matthew 1:1-17"
                    },
                    new List<string> //8/29
                    {
                        "Psalm 144",
                        "2 Samuel 16",
                        "Colossians 4",
                        "Psalm 145",
                        "Obadiah 1",
                        "Matthew 1:18-25"
                    },
                    new List<string> //8/30
                    {
                        "Psalm 146",
                        "2 Samuel 17",
                        "Philemon",
                        "Psalm 147",
                        "Jonah 1",
                        "Matthew 2"
                    },
                    new List<string> //8/31
                    {
                        "Psalm 148",
                        "2 Samuel 18",
                        "Ephesians 1:1-14",
                        "Psalm 149-150",
                        "Jonah 2",
                        "Matthew 3"
                    },
                    new List<string> //9/1
                    {
                        "Psalm 1-2",
                        "2 Samuel 19",
                        "Ephesians 1:15-23",
                        "Psalm 3-4",
                        "Jonah 3",
                        "Matthew 4"
                    },
                    new List<string> //9/2
                    {
                        "Psalm 5-6",
                        "2 Samuel 20",
                        "Ephesians 2:1-10",
                        "Psalm 7",
                        "Jonah 4",
                        "Matthew 5:1-20"
                    },
                    new List<string> //9/3
                    {
                        "Psalm 9",
                        "2 Samuel 21",
                        "Ephesians 2:11-22",
                        "Psalm 10",
                        "Micah 1",
                        "Matthew 5:21-48"
                    },
                    new List<string> //9/4
                    {
                        "Psalm 8",
                        "Psalm 11",
                        "2 Samuel 22",
                        "Ephesians 3",
                        "Psalm 15-16",
                        "Micah 2",
                        "Matthew 6:1-18"
                    },
                    new List<string> //9/5
                    {
                        "Psalm 12-14",
                        "2 Samuel 23",
                        "Ephesians 4:1-16",
                        "Psalm 17",
                        "Micah 3",
                        "Matthew 6:19-34"
                    },
                    new List<string> //9/6
                    {
                        "Psalm 18:1-20",
                        "2 Samuel 24",
                        "Ephesians 4:17-32",
                        "Psalm 18:21-52",
                        "Micah 4",
                        "Matthew 7"
                    },
                    new List<string> //9/7
                    {
                        "Psalm 19",
                        "1 Chronicles 22",
                        "Ephesians 5:1-17",
                        "Psalm 20-21",
                        "Micah 5",
                        "Matthew 8:1-17"
                    },
                    new List<string> //9/8
                    {
                        "Psalm 22",
                        "1 Kings 1",
                        "Ephesians 5:18-33",
                        "Psalm 23-24",
                        "Micah 6",
                        "Matthew 8:18-34"
                    },
                    new List<string> //9/9
                    {
                        "Psalm 25",
                        "1 Chronicles 28",
                        "Ephesians 6",
                        "Psalm 27",
                        "Micah 7",
                        "Matthew 9:1-17"
                    },
                    new List<string> //9/10
                    {
                        "Psalm 26",
                        "Psalm 28",
                        "1 Kings 2",
                        "Hebrews 1",
                        "Psalm 31",
                        "Nahum 1",
                        "Matthew 9:18-34"
                    },
                    new List<string> //9/11
                    {
                        "Psalm 29-30",
                        "1 Kings 3",
                        "Hebrews 2",
                        "Psalm 33",
                        "Nahum 2",
                        "Matthew 9:35-10:23"
                    },
                    new List<string> //9/12
                    {
                        "Psalm 34",
                        "1 Kings 4",
                        "Hebrews 3",
                        "Psalm 35",
                        "Nahum 3",
                        "Matthew 10:24-42"
                    },
                    new List<string> //9/13
                    {
                        "Psalm 32",
                        "Psalm 36",
                        "1 Kings 5",
                        "Hebrews 4:1-13",
                        "Psalm 38",
                        "Habakkuk 1",
                        "Matthew 11"
                    },
                    new List<string> //9/14
                    {
                        "Psalm 37:1-17",
                        "Hebrews 4:14-5:10",
                        "John 12:23-33",
                        "Psalm 37:18-41",
                        "Habakkuk 2",
                        "Matthew 12:1-21"                    
                    },
                    new List<string> //9/15
                    {
                        "Psalm 40",
                        "1 Kings 6",
                        "Hebrews 5:11-6:20",
                        "Psalm 39",
                        "Psalm 41",
                        "Habakkuk 3",
                        "Matthew 12:22-50"
                    },
                    new List<string> //9/16
                    {
                        "Psalm 42-43",
                        "1 Kings 7",
                        "Hebrews 7",
                        "Psalm 44",
                        "Zephaniah 1",
                        "Matthew 13:1-23"
                    },
                    new List<string> //9/17
                    {
                        "Psalm 45",
                        "1 Kings 8",
                        "Hebrews 8",
                        "Psalm 46",
                        "Zephaniah 2",
                        "Matthew 13:24-43"
                    },
                    new List<string> //9/18
                    {
                        "Psalm 47-48",
                        "1 Kings 9",
                        "Hebrews 9:1-14",
                        "Psalm 49",
                        "Zephaniah 3",
                        "Matthew 13:44-58"
                    },
                    new List<string> //9/19
                    {
                        "Psalm 50",
                        "1 Kings 10",
                        "Hebrews 9:15-28",
                        "Psalm 51",
                        "Haggai 1",
                        "Matthew 14"
                    },
                    new List<string> //9/20
                    {
                        "Psalm 52-54",
                        "1 Kings 11",
                        "Hebrews 10:1-18",
                        "Psalm 55",
                        "Haggai 2",
                        "Matthew 15:1-28"
                    },
                    new List<string> //9/21
                    {
                        "Psalm 56-57",
                        "1 Kings 11",
                        "Hebrews 10:19-39",
                        "Psalm 58",
                        "Psalm 60",
                        "Zachariah 1",
                        "Matthew 15:29-16:12"
                    },
                    new List<string> //9/22
                    {
                        "Psalm 59",
                        "1 Kings 12",
                        "Hebrews 11",
                        "Psalm 63-64",
                        "Zachariah 2",
                        "Matthew 16:13-28"
                    },
                    new List<string> //9/23
                    {
                        "Psalm 61-62",
                        "1 Kings 13",
                        "Hebrews 12:1-17",
                        "Psalm 65",
                        "Psalm 67",
                        "Zachariah 3",
                        "Matthew 17:1-23"
                    },
                    new List<string> //9/24
                    {
                        "Psalm 68:1-18",
                        "1 Kings 14",
                        "Hebrews 12:18-29",
                        "Psalm 68:19-36",
                        "Zachariah 4",
                        "Matthew 17:24-18:14"
                    },
                    new List<string> //9/25
                    {
                        "Psalm 69:1-18",
                        "2 Chronicles 12",
                        "Hebrews 13",
                        "Psalm 68:19-37",
                        "Zachariah 5",
                        "Matthew 18:15-35"
                    },
                    new List<string> //9/26
                    {
                        "Psalm 66",
                        "2 Chronicles 13",
                        "James 1",
                        "Psalm 70",
                        "Psalm 72",
                        "Zachariah 6",
                        "Matthew 19:1-15"
                    },
                    new List<string> //9/27
                    {
                        "Psalm 71",
                        "2 Chronicles 14",
                        "James 2:1-13",
                        "Psalm 73",
                        "Zachariah 7",
                        "Matthew 19:16-20:16"
                    },
                    new List<string> //9/28
                    {
                        "Psalm 74",
                        "2 Chronicles 15",
                        "James 2:14-26",
                        "Psalm 77",
                        "Zachariah 8",
                        "Matthew 20:17-34"
                    },
                    new List<string> //9/29
                    {
                        "Psalm 75-76",
                        "Revelation 12:7-12",
                        "James 3",
                        "Psalm 79",
                        "Psalm 82",
                        "Zachariah 9",
                        "Matthew 21:1-22"
                    },
                    new List<string> //9/30
                    {
                        "Psalm 78:1-18",
                        "2 Cronicles 16",
                        "James 4",
                        "Psalm 78:19-40",
                        "Zachariah 10",
                        "Matthew 21:23-46"
                    },
                    new List<string> //10/1
                    {
                        "Psalm 78:41-73",
                        "1 Kings 15",
                        "James 5",
                        "Psalm 80",
                        "Zachariah 11",
                        "Matthew 22:1-33"
                    },
                    new List<string> //10/2
                    {
                        "Psalm 81",
                        "1 Kings 16",
                        "1 Peter 1:1-21",
                        "Psalm 83",
                        "Zachariah 12",
                        "Matthew 22:34-23:12"
                    },
                    new List<string> //10/3
                    {
                        "Psalm 84",
                        "1 Kings 17",
                        "1 Peter 1:22-2:10",
                        "Psalm 85",
                        "Zachariah 13",
                        "Matthew 23:13-39"
                    },
                    new List<string> //10/4
                    {
                        "Psalm 86-87",
                        "1 Kings 18",
                        "1 Peter 2:11-3:7",
                        "Psalm 88",
                        "Zachariah 14",
                        "Matthew 24:1-28"
                    },
                    new List<string> //10/5
                    {
                        "Psalm 89:1-18",
                        "1 Kings 19",
                        "1 Peter 3:8-4:6",
                        "Psalm 89:19-51",
                        "Malachi 1",
                        "Matthew 24:29-51"
                    },
                    new List<string> //10/6
                    {
                        "Psalm 90",
                        "1 Kings 20",
                        "1 Peter 4:7-19",
                        "Psalm 91",
                        "Malachi 2",
                        "Matthew 25:1-30"
                    },
                    new List<string> //10/7
                    {
                        "Psalm 92-93",
                        "1 Kings 21",
                        "1 Peter 5",
                        "Psalm 94",
                        "Malachi 3",
                        "Matthew 25:31-46"
                    },
                    new List<string> //10/8
                    {
                        "Psalm 95-96",
                        "1 Kings 22",
                        "2 Peter 1",
                        "Psalm 97-98",
                        "Malachi 4",
                        "Matthew 26:1-30"
                    },
                    new List<string> //10/9
                    {
                        "Psalm 99-101",
                        "2 Chronicles 20",
                        "2 Peter 2",
                        "Psalm 102",
                        "1 Maccabees 1",
                        "Matthew 26:31-56"
                    },
                    new List<string> //10/10
                    {
                        "Psalm 103",
                        "2 Kings 1",
                        "2 Peter 3",
                        "Psalm 104",
                        "1 Maccabees 2",
                        "Matthew 26:57-75"
                    },
                    new List<string> //10/11
                    {
                        "Psalm 105:1-22",
                        "2 Kings 2",
                        "Jude",
                        "Psalm 105:23-44",
                        "2 Maccabees 6",
                        "Matthew 27:1-26"
                    },
                    new List<string> //10/12
                    {
                        "Psalm 106:1-18",
                        "2 Kings 3",
                        "1 John 1:1-2:6",
                        "Psalm 106:19-46",
                        "2 Maccabees 7",
                        "Matthew 27:27-56"
                    },
                    new List<string> //10/13
                    {
                        "Psalm 107:1-22",
                        "2 Kings 4",
                        "1 John 2:7-29",
                        "Psalm 107:23-43",
                        "2 Maccabees 8",
                        "Matthew 27:57-28:20"
                    },
                    new List<string> //10/14
                    {
                        "Psalm 108",
                        "Psalm 110",
                        "2 Kings 5",
                        "1 John 3:1-10",
                        "Psalm 109",
                        "2 Maccabees 10",
                        "Mark 1:1-13"
                    },
                    new List<string> //10/15
                    {
                        "Psalm 111-112",
                        "2 Kings 6",
                        "1 John 3:11-4:6",
                        "Psalm 113-114",
                        "1 Maccabees 7",
                        "Mark 1:14-31"
                    },
                    new List<string> //10/16
                    {
                        "Psalm 115",
                        "2 Kings 7",
                        "1 John 4:7-21",
                        "Psalm 116-117",
                        "1 Maccabees 9",
                        "Mark 1:32-45"
                    },
                    new List<string> //10/17
                    {
                        "Psalm 119:1-24",
                        "2 Kings 8",
                        "1 John 5",
                        "Psalm 119:25-48",
                        "1 Maccabees 13",
                        "Mark 2:1-22"
                    },
                    new List<string> //10/18
                    {
                        "Psalm 119:49-72",
                        "2 John 1",
                        "Luke 1:1-4",
                        "Psalm 119:73-88",
                        "1 Maccabees 14",
                        "Mark 2:23-3:12"
                    },
                    new List<string> //10/19
                    {
                        "Psalm 119:89-104",
                        "2 Kings 9",
                        "3 John 1",
                        "Psalm 119:105-128",
                        "Isaiah 1",
                        "Mark 3:13-35"
                    },
                    new List<string> //10/20
                    {
                        "Psalm 119:129-152",
                        "2 Kings 10",
                        "Acts 1:1-14",
                        "Psalm 119:153-176",
                        "Isaiah 2",
                        "Mark 4:1-34"
                    },
                    new List<string> //10/21
                    {
                        "Psalm 118",
                        "2 Kings 11",
                        "Acts 1:15-26",
                        "Psalm 120-121",
                        "Isaiah 3",
                        "Mark 4:35-5:20"
                    },
                    new List<string> //10/22
                    {
                        "Psalm 122-123",
                        "2 Kings 12",
                        "Acts 2:1-21",
                        "Psalm 124-126",
                        "Isaiah 4",
                        "Mark 5:21-43"
                    },
                    new List<string> //10/23
                    {
                        "Psalm 127-128",
                        "Acts 2:22-47",
                        "James 1",
                        "Psalm 129-131",
                        "Isaiah 5",
                        "Mark 6:1-29"
                    },
                    new List<string> //10/24
                    {
                        "Psalm 132-133",
                        "2 Kings 13",
                        "Acts 3:1-4:4",
                        "Psalm 134-135",
                        "Isaiah 6",
                        "Mark 6:30-56"
                    },
                    new List<string> //10/25
                    {
                        "Psalm 136",
                        "2 Kings 14",
                        "Acts 4:5-31",
                        "Psalm 137-138",
                        "Isaiah 7",
                        "Mark 7:1-23"
                    },
                    new List<string> //10/26
                    {
                        "Psalm 139",
                        "2 Chronicles 26",
                        "Acts 4:32-5:11",
                        "Psalm 141-142",
                        "Isaiah 8",
                        "Mark 7:24-8:10"
                    },
                    new List<string> //10/27
                    {
                        "Psalm 140",
                        "2 Kings 15",
                        "Acts 5:12-42",
                        "Psalm 143",
                        "Isaiah 9",
                        "Mark 8:11-38"
                    },
                    new List<string> //10/28
                    {
                        "Psalm 144",
                        "Acts 6:1-7:16",
                        "John 14:15-31",
                        "Psalm 145",
                        "Isaiah 10",
                        "Mark 9:1-29"
                    },
                    new List<string> //10/29
                    {
                        "Psalm 146",
                        "2 Kings 16",
                        "Acts 7:17-34",
                        "Psalm 147",
                        "Isaiah 11",
                        "Mark 9:30-50"
                    },
                    new List<string> //10/30
                    {
                        "Psalm 148",
                        "2 Kings 17",
                        "Acts 7:35-8:3",
                        "Psalm 149-150",
                        "Isaiah 12",
                        "Mark 10:1-31"
                    },
                    new List<string> //10/31
                    {
                        "Psalm 2",
                        "2 Chronicles 28",
                        "Acts 8:4-25",
                        "Psalm 3-4",
                        "Isaiah 13",
                        "Mark 10:32-52"
                    },
                    new List<string> //11/1
                    {
                        "Psalm 1",
                        "Psalm 15",
                        "Hebrews 11:32-12:2",
                        "Acts 8:26-40",
                        "Psalm 34",
                        "Isaiah 14",
                        "Revelation 19:1-16"
                    },
                    new List<string> //11/2
                    {
                        "Psalm 5-6",
                        "2 Chronicles 29",
                        "Acts 9:1-31",
                        "Psalm 7",
                        "Isaiah 15",
                        "Mark 11:1-26"
                    },
                    new List<string> //11/3
                    {
                        "Psalm 9",
                        "2 Chronicles 30",
                        "Acts 9:32-43",
                        "Psalm 10",
                        "Isaiah 16",
                        "Mark 11:27-12:12"
                    },
                    new List<string> //11/4
                    {
                        "Psalm 8",
                        "Psalm 11",
                        "2 Kings 18",
                        "Acts 10:1-23",
                        "Psalm 15-16",
                        "Isaiah 17",
                        "Mark 12:13-34"
                    },
                    new List<string> //11/5
                    {
                        "Psalm 12-14",
                        "2 Kings 19",
                        "Acts 10:24-48",
                        "Psalm 17",
                        "Isaiah 18",
                        "Mark 12:35-13:13"
                    },
                    new List<string> //11/6
                    {
                        "Psalm 18:1-20",
                        "2 Kings 20",
                        "Acts 11:1-18",
                        "Psalm 18:21-52",
                        "Isaiah 19",
                        "Mark 13:14-37"
                    },
                    new List<string> //11/7
                    {
                        "Psalm 19",
                        "2 Chronicles 33",
                        "Acts 11:19-30",
                        "Psalm 20-21",
                        "Isaiah 20",
                        "Mark 14:1-25"
                    },
                    new List<string> //11/8
                    {
                        "Psalm 22",
                        "2 Kings 21",
                        "Acts 12:1-24",
                        "Psalm 23-24",
                        "Isaiah 21",
                        "Mark 14:26-52"
                    },
                    new List<string> //11/9
                    {
                        "Psalm 25",
                        "2 Kings 22",
                        "Acts 12:25-13:12",
                        "Psalm 27",
                        "Isaiah 22",
                        "Mark 14:53-72"
                    },
                    new List<string> //11/10
                    {
                        "Psalm 26",
                        "Psalm 28",
                        "2 Kings 23",
                        "Acts 13:13-43",
                        "Psalm 31",
                        "Isaiah 23",
                        "Mark 15"
                    },
                    new List<string> //11/11
                    {
                        "Psalm 29-30",
                        "2 Kings 24",
                        "Acts 13:44-14:7",
                        "Psalm 33",
                        "Isaiah 24",
                        "Mark 16"
                    },
                    new List<string> //11/12
                    {
                        "Psalm 34",
                        "2 Kings 25",
                        "Acts 14:8-28",
                        "Psalm 35",
                        "Isaiah 25",
                        "Luke 1:1-23"
                    },
                    new List<string> //11/13
                    {
                        "Psalm 32",
                        "Psalm 36",
                        "Judith 4",
                        "Acts 15:1-21",
                        "Psalm 38",
                        "Isaiah 26",
                        "Luke 1:24-56"
                    },
                    new List<string> //11/14
                    {
                        "Psalm 37:1-17",
                        "Judith 8",
                        "Acts 15:22-35",
                        "Psalm 37:18-41",
                        "Isaiah 27",
                        "Luke 1:57-80"
                    },
                    new List<string> //11/15
                    {
                        "Psalm 40",
                        "Judith 9",
                        "Acts 15:36-16:5",
                        "Psalm 39",
                        "Psalm 41",
                        "Isaiah 28",
                        "Luke 2:1-21"
                    },
                    new List<string> //11/16
                    {
                        "Psalm 42-43",
                        "Judith 10",
                        "Acts 16:6-40",
                        "Psalm 44",
                        "Isaiah 29",
                        "Luke 2:22-52"
                    },
                    new List<string> //11/17
                    {
                        "Psalm 45",
                        "Judith 11",
                        "Acts 17:1-15",
                        "Psalm 46",
                        "Isaiah 30",
                        "Luke 3:1-22"
                    },
                    new List<string> //11/18
                    {
                        "Psalm 47-48",
                        "Judith 12",
                        "Acts 17:16-34",
                        "Psalm 49",
                        "Isaiah 31",
                        "Luke 3:23-38"
                    },
                    new List<string> //11/19
                    {
                        "Psalm 50",
                        "Judith 13",
                        "Acts 18:1-23",
                        "Psalm 51",
                        "Isaiah 32",
                        "Luke 4:1-30"
                    },
                    new List<string> //11/20
                    {
                        "Psalm 52-54",
                        "Judith 14",
                        "Acts 18:24-19:7",
                        "Psalm 55",
                        "Isaiah 33",
                        "Luke 4:31-44"
                    },
                    new List<string> //11/21
                    {
                        "Psalm 56-57",
                        "Judith 15",
                        "Acts 19:8-20",
                        "Psalm 58",
                        "Psalm 60",
                        "Isaiah 34",
                        "Luke 5:1-16"
                    },
                    new List<string> //11/22
                    {
                        "Psalm 59",
                        "Judith 16",
                        "Acts 19:21-41",
                        "Psalm 63-64",
                        "Isaiah 35",
                        "Luke 5:17-39"
                    },
                    new List<string> //11/23
                    {
                        "Psalm 61-62",
                        "Sirach 1",
                        "Acts 20:1-16",
                        "Psalm 65",
                        "Psalm 67",
                        "Isaiah 36",
                        "Luke 6:1-19"
                    },
                    new List<string> //11/24
                    {
                        "Psalm 68:1-18",
                        "Sirach 2",
                        "Acts 20:17-38",
                        "Psalm 68:19-36",
                        "Isaiah 37",
                        "Luke 6:20-38"
                    },
                    new List<string> //11/25
                    {
                        "Psalm 69:1-18",
                        "Sirach 4",
                        "Acts 21:1-16",
                        "Psalm 69:19-37",
                        "Isaiah 38",
                        "Luke 6:39-7:10"
                    },
                    new List<string> //11/26
                    {
                        "Psalm 66",
                        "Sirach 6",
                        "Acts 21:17-36",
                        "Psalm 70",
                        "Psalm 72",
                        "Isaiah 39",
                        "Luke 7:11-35"
                    },
                    new List<string> //11/27
                    {
                        "Psalm 71",
                        "Sirach 7",
                        "Acts 21:37-22:22",
                        "Psalm 73",
                        "Isaiah 40",
                        "Luke 7:36-50"
                    },
                    new List<string> //11/28
                    {
                        "Psalm 74",
                        "Sirach 9",
                        "Acts 22:23-23:11",
                        "Psalm 77",
                        "Isaiah 41",
                        "Luke 8:1-21"
                    },
                    new List<string> //11/29
                    {
                        "Psalm 75-76",
                        "Sirach 10",
                        "Acts 23:12-35",
                        "Psalm 79",
                        "Psalm 82",
                        "Isaiah 42",
                        "Luke 8:22-56"
                    },
                    new List<string> //11/30
                    {
                        "Psalm 78:1-18",
                        "Sirach 11",
                        "John 1:35-42",
                        "Psalm 78:19-40",
                        "Isaiah 43",
                        "Luke 9:1-17"
                    },
                    new List<string> //12/1
                    {
                        "Psalm 78:41-73",
                        "Sirach 14",
                        "Acts 24:1-23",
                        "Psalm 80",
                        "Isaiah 44",
                        "Luke 9:18-50"
                    },
                    new List<string> //12/2
                    {
                        "Psalm 81",
                        "Sirach 17",
                        "Acts 24:24-25:12",
                        "Psalm 83",
                        "Isaiah 45",
                        "Luke 9:51-62"
                    },
                    new List<string> //12/3
                    {
                        "Psalm 84",
                        "Sirach 18",
                        "Acts 25:13-27",
                        "Psalm 85",
                        "Isaiah 46",
                        "Luke 10:1-24"
                    },
                    new List<string> //12/4
                    {
                        "Psalm 86-87",
                        "Sirach 21",
                        "Acts 26",
                        "Psalm 88",
                        "Isaiah 47",
                        "Luke 10:25-42"
                    },
                    new List<string> //12/5
                    {
                        "Psalm 89:1-18",
                        "Sirach 34",
                        "Acts 27",
                        "Psalm 89:19-51",
                        "Isaiah 48",
                        "Luke 11:1-28"
                    },
                    new List<string> //12/6
                    {
                        "Psalm 90",
                        "Sirach 38",
                        "Acts 28:1-15",
                        "Psalm 91",
                        "Isaiah 49",
                        "Luke 11:29-54"
                    },
                    new List<string> //12/7
                    {
                        "Psalm 92-93",
                        "Sirach 39",
                        "Acts 28:16-31",
                        "Psalm 94",
                        "Isaiah 50",
                        "Luke 12:1-34"
                    },
                    new List<string> //12/8
                    {
                        "Psalm 95-96",
                        "Sirach 44",
                        "Revelation 1",
                        "Psalm 97-98",
                        "Isaiah 51",
                        "Luke 12:35-53"
                    },
                    new List<string> //12/9
                    {
                        "Psalm 99-101",
                        "Sirach 45",
                        "Revelation 2:1-17",
                        "Psalm 102",
                        "Isaiah 52",
                        "Luke 12:54-13:9"
                    },
                    new List<string> //12/10
                    {
                        "Psalm 103",
                        "Sirach 46",
                        "Revelation 2:18-3:6",
                        "Psalm 104",
                        "Isaiah 53",
                        "Luke 13:10-35"
                    },
                    new List<string> //12/11
                    {
                        "Psalm 105:1-22",
                        "Sirach 47",
                        "Revelation 3:7-22",
                        "Psalm 105:23-44",
                        "Isaiah 54",
                        "Luke 14:1-24"
                    },
                    new List<string> //12/12
                    {
                        "Psalm 106:1-18",
                        "Sirach 48",
                        "Revelation 4",
                        "Psalm 106:19-46",
                        "Isaiah 55",
                        "Luke 14:25-15:10"
                    },
                    new List<string> //12/13
                    {
                        "Psalm 107:1-22",
                        "Sirach 49",
                        "Revelation 5",
                        "Psalm 107:23-43",
                        "Isaiah 56",
                        "Luke 15:11-32"
                    },
                    new List<string> //12/14
                    {
                        "Psalm 108",
                        "Psalm 110",
                        "Sirach 50",
                        "Revelation 6",
                        "Psalm 109",
                        "Isaiah 57",
                        "Luke 16"
                    },
                    new List<string> //12/15
                    {
                        "Psalm 111-112",
                        "Sirach 51",
                        "Revelation 7",
                        "Psalm 113-114",
                        "Isaiah 58",
                        "Luke 17:1-19"
                    },
                    new List<string> //12/16
                    {
                        "Psalm 115",
                        "Wisdom 1",
                        "Revelation 8",
                        "Psalm 116-117",
                        "Isaiah 59",
                        "Luke 17:20-37"
                    },
                    new List<string> //12/17
                    {
                        "Psalm 119:1-24",
                        "Wisdom 2",
                        "Revelation 9",
                        "Psalm 119:25-48",
                        "Isaiah 60",
                        "Luke 18:1-30"
                    },
                    new List<string> //12/18
                    {
                        "Psalm 119:49-72",
                        "Wisdom 3",
                        "Revelation 10",
                        "Psalm 119:73-88",
                        "Isaiah 61",
                        "Luke 18:31-19:10"
                    },
                    new List<string> //12/19
                    {
                        "Psalm 119:89-104",
                        "Wisdom 4",
                        "Revelation 11",
                        "Psalm 119:105-128",
                        "Isaiah 62",
                        "Luke 19:11-28"
                    },
                    new List<string> //12/20
                    {
                        "Psalm 119:129-152",
                        "Wisdom 5",
                        "Revelation 12",
                        "Psalm 119:153-176",
                        "Isaiah 63",
                        "Luke 19:29-48"
                    },
                    new List<string> //12/21
                    {
                        "Psalm 118",
                        "Revelation 13",
                        "John 14:1-7",
                        "Psalm 120-121",
                        "Isaiah 64",
                        "Luke 20:1-26"
                    },
                    new List<string> //12/22
                    {
                        "Psalm 122-123",
                        "Wisdon 6",
                        "Revelation 14",
                        "Psalm 124-126",
                        "Isaiah 65",
                        "Luke 20:27-21:4"
                    },
                    new List<string> //12/23
                    {
                        "Psalm 127-128",
                        "Wisdon 7",
                        "Revelation 15",
                        "Psalm 129-131",
                        "Isaiah 66",
                        "Luke 21:5-38"
                    },
                    new List<string> //12/24
                    {
                        "Psalm 132-133",
                        "Wisdon 8",
                        "Revelation 16",
                        "Psalm 134-135",
                        "Song 1",
                        "Luke 22:1-38"
                    },
                    new List<string> //12/25
                    {
                        "Psalm 19",
                        "Psalm 45",
                        "Isaiah 9:1-7",
                        "Revelation 17",
                        "Psalm 85",
                        "Psalm 110",
                        "Song 2",
                        "Luke 2:1-14"
                    },
                    new List<string> //12/26
                    {
                        "Psalm 136",
                        "Acts 6:8-15",
                        "Acts 7:6",
                        "Acts 7:17-41",
                        "Acts 7:44-60",
                        "Revelation 18",
                        "Psalm 137-138",
                        "Song 3",
                        "Luke 22:39-53"
                    },
                    new List<string> //12/27
                    {
                        "Psalm 139",
                        "Revelation 19",
                        "1 John 1",
                        "Psalm 141-142",
                        "Song 4",
                        "Luke 22:54-71"
                    },
                    new List<string> //12/28
                    {
                        "Psalm 140",
                        "Jeremiah 31:1-17",
                        "Revelation 19",
                        "Psalm 143",
                        "Song 5",
                        "Luke 23:1-25"
                    },
                    new List<string> //12/29
                    {
                        "Psalm 144",
                        "Wisdom 5",
                        "Revelation 21:1-14",
                        "Psalm 145",
                        "Song 6",
                        "Luke 23:26-49"
                    },
                    new List<string> //12/30
                    {
                        "Psalm 146",
                        "Wisdom 10",
                        "Revelation 21:15-22:5",
                        "Psalm 147",
                        "Song 7",
                        "Luke 23:50-24:12"
                    },
                    new List<string> //12/31
                    {
                        "Psalm 148",
                        "Wisdom 11",
                        "Revelation 22:6-21",
                        "Psalm 149-150",
                        "Song 8",
                        "Luke 24:13-53"
                    }
                };
            }
        }
    }
}
