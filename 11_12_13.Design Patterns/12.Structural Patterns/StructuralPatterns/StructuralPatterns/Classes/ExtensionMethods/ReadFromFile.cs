using Proxy.Abstractions;

namespace Proxy.Classes.ExtensionMethods
{
    public static class ReadFromFile
    {
        public static IEnumerable<ClientData> ReadFromFileMethod(this string textFile)
        {
            int count = 0;
            using(StreamReader sr = new StreamReader(textFile))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    string[] infos = line.Split(';');
                    CardType cardType;
                    Enum.TryParse(infos[1], out cardType);

                    yield return new ClientData {
                        UserId = count++,
                        FullName = infos[0],
                        CreditCard = cardType,
                        CardNumber = infos[2],
                        ExpirationDate = infos[3],
                        CsvNumber = infos[4],
                        Address = infos[5],
                        City = infos[6],
                        Province = infos[7],
                        PostalCode = infos[8],
                        Country = infos[9],
                    };
                }
            }
           
        }
    }
}
