using BehavioralPatterns.Domain;
using BehavioralPatterns.Domain.Enums;

namespace BehavioralPatterns.ExtensionMethods
{
    public static class ExtensionMethodsClass
    {
        private static IEnumerable<ClientData> ReadFromFileMethod(this string textFile)
        {
            int count = 0;
            using (StreamReader sr = new StreamReader(textFile))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    string[] infos = line.Split(';');
                    CardType cardType;
                    Enum.TryParse(infos[1], out cardType);

                    yield return new ClientData
                    {
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

        public static IEnumerable<ClientData> GetClients(this List<ClientData> clients)
        {

            string changeNameOfSource = Directory.GetCurrentDirectory();
            changeNameOfSource = changeNameOfSource.Replace("ObserverPattern", "BehavioralPatterns");

            var currentTextFile = Path.Combine(changeNameOfSource, "clients.txt");
            IEnumerable<ClientData> listOfClients = currentTextFile.ReadFromFileMethod();
            foreach (ClientData client in listOfClients)
            {
                clients.Add(client);
                //am incercat si cu yield return
            }

            return clients;
        }
    }
}
