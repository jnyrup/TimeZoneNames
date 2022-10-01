using TimeZoneNames;

Console.WriteLine("Hello world");
IDictionary<string, string> displayNames = TZNames.GetDisplayNames("fr-CA");
string pacific = displayNames["Pacific Standard Time"];
Console.WriteLine(pacific);

// Exercise some code calling TZConvert
string displayName = TZNames.GetDisplayNameForTimeZone("Yukon Standard Time", "en");
Console.WriteLine(displayName);