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

//TimeSpan
var timeSpan = new TimeSpan(6, 0, 0);
var currentDate = DateTime.Now - timeSpan; // scazi 6 ore din data curenta
currentDate = DateTime.Now.Date.Add(timeSpan); // adaugi 6 ore

//DateTime

var dateTimeUTC = DateTime.UtcNow;
var dateTimeOffSet = DateTimeOffset.Now; // te ajuta pentru regiuni offsetul asta raportat la UTC

//Convert DateTime
var date = new DateTime(2002, 03, 14);
var formattedDate = date.ToString("yyyy-MM-dd");
var secondFormattedDate = date.ToString("dddd MMMM");
var thirdFormattedDate = date.ToString("dddd MMMM", CultureInfo.CreateSpecificCulture("ro-RO"));

var numberCulture = 10.ToString("C", new CultureInfo("en-BW"));


Console.WriteLine(numberCulture);
