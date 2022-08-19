# HumanTimeSpanParser
Simple code for parsing human time span into TimeSpan object
Inputting string containing time span will return TimeSpan object.

3 d > 0 seconds, 0 minutes, 0 hours, 3 days
4 days > 0 seconds, 0 minutes, 0 hours, 4 days
30 sec > 30 seconds, 0 minutes, 0 hours, 0 days
37 years > 0 seconds, 0 minutes, 0 hours, 13505 days

It supports miliseconds, seconds, minutes, hours, days, weeks, months and years. Currently only works in english.

# Usage

```cs
var TSparser = new HumanTimeSpanParser();
TimeSpan ts = TSparser.Parse(input);
```
