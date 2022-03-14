using System.Globalization;


//String format
var current_date = string.Format("Current DateTime: {0}", DateTime.Now);

//String interpolation
var current_date2 = $"Current DateTime: { DateTime.Now }";

//Split String
var countryList = "Romania,Bulgaria, Franta".Split(",");
var extension = "Test.pdf".Split(".")[1];


//Replace String
var replaceString = "1,2,3,4,5,6".Replace(",", ":");

//Contains String
var fullName = "Emanuel Caprariu";
var hasFirstName = fullName.Contains("Emanuel");

//Compare String
//A < B  = -1
//A = B = 0
//A > B = 1
var compare = string.Compare("a", "A",StringComparison.InvariantCultureIgnoreCase); //nu tine cont de cultura deci sunt egale
var compare2 = string.Compare("alabala", "abama", StringComparison.InvariantCultureIgnoreCase); // 1


//TimeSpan
var timeSpan = new TimeSpan(6, 0, 0);
var currentDate = DateTime.Now - timeSpan; // scazi 6 ore din data curenta
Console.WriteLine($"Current date - timespan: {currentDate}");
currentDate = DateTime.Now.Date.Add(timeSpan); // setezi din acea zi 6 ore
Console.WriteLine($"Current date with timespan : {currentDate}");

//DateTime
var dateTimeUTC = DateTime.UtcNow;
var dateTimeOffSet = DateTimeOffset.Now; // te ajuta pentru regiuni offsetul raportat la UTC

Console.WriteLine($"Date time utc: {dateTimeUTC}\nDate time offset: {dateTimeOffSet}");

//Convert DateTime
var date = new DateTime(DateTime.Now.Year - 23, 03, 14);
var formattedDate = date.ToString("dd.MM.yyyy");
var secondFormattedDate = date.ToString("dddd MMMM");
var thirdFormattedDate = date.ToString("dddd MMMM", CultureInfo.CreateSpecificCulture("ro-RO"));
Console.WriteLine($"Formatted Date: {formattedDate}");

var numberCulture = 10.ToString("C", new CultureInfo("ro-RO"));


//NumberFormatInfo
NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
numberFormatInfo.NumberGroupSeparator = " ";
Console.WriteLine(12134.214124.ToString("N1",numberFormatInfo)); // 12 134.213124

Console.WriteLine(numberCulture);
