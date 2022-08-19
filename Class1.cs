namespace HumanTimeSpanParser
{
    public class HumanTimeSpanParser
    {
        public TimeSpan Parse(string input)
        {
            TimeSpan ParsedTimeSpan = new();
            double AmountOfTime;

            string[] split = input.Split(' ');

            foreach (string s in split)
                s.Trim().ToLower();

            if (!double.TryParse(split[0], out AmountOfTime))
                throw new ArgumentException("Input string does not specify amount of time");

            switch (split[1])
            {
                case string s when s.StartsWith("milis"):
                    ParsedTimeSpan = TimeSpan.FromMilliseconds(AmountOfTime);
                    break;
                case string s when s.StartsWith("sec"):
                    ParsedTimeSpan = TimeSpan.FromSeconds(AmountOfTime);
                    break;
                case string s when s.StartsWith("mi"):
                    ParsedTimeSpan = TimeSpan.FromMinutes(AmountOfTime);
                    break;
                case string s when s.StartsWith("h"):
                    ParsedTimeSpan = TimeSpan.FromHours(AmountOfTime);
                    break;
                case string s when s.StartsWith("d"):
                    ParsedTimeSpan = TimeSpan.FromDays(AmountOfTime);
                    break;
                case string s when s.StartsWith("w"):
                    ParsedTimeSpan = TimeSpan.FromDays(AmountOfTime * 7);
                    break;
                case string s when s.StartsWith("mo"):
                    ParsedTimeSpan = TimeSpan.FromDays((AmountOfTime * 30));
                    break;
                case string s when s.StartsWith("year"):
                    ParsedTimeSpan = TimeSpan.FromDays(AmountOfTime * 365);
                    break;
            }

            return ParsedTimeSpan;
        }
    }
    
}