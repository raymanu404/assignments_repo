using System;
using System.IO;
using System.Threading.Tasks;


namespace FileSystem;

class Program
{
    static async Task Main(string[] args)
    {
        DriveInfo[] driveInfos = DriveInfo.GetDrives();

        Console.WriteLine("----------------DRIVES--------------------");

        foreach(var info in driveInfos)
        {
            Console.WriteLine($"{info.Name}, {info.IsReady}, {info.AvailableFreeSpace} ");
        }

        Console.WriteLine("-------------- DIRECTORIES ---------------------");

        string currentDiretory = Directory.GetCurrentDirectory();
        DirectoryInfo dirInfo = new DirectoryInfo(currentDiretory);

        Console.WriteLine(dirInfo.FullName);
        DirectoryInfo parent = new DirectoryInfo(currentDiretory).Parent;

        //creare folder nou
        //Path.Combine este mai ok decat concatenare manuala
        string newDirPath = Path.Combine(Directory.GetCurrentDirectory(), "MyNewFolder");
        Directory.CreateDirectory(newDirPath);

        //creare fisier nou
        string newFilePath = Path.Combine(newDirPath, "MyFile.txt");
        FileStream fileStream = File.Create(newFilePath);
        

        //mereu ne folosim de StreamWriter / StreamReader sa nu ne batem capul cu convertirea in bytes
        //iar StreamWriter este legat de streamul nostru FileStream
        using (StreamWriter streamWriter = new StreamWriter(fileStream))
        {
            
            for (int i = 1; i <= 10; i++)
            {
                streamWriter.WriteLine($"This is line number: {i}");
            }
        }

        //la fel nu ne batem capul cu conertirea in bytes, stie StreamReader sa faca el
        //iar cu using face Close / Dispose 
        using (StreamReader streamReader = new StreamReader(newFilePath))
        {
            while (!streamReader.EndOfStream)
            {
                Console.WriteLine(streamReader.ReadLine());
            }
        }


        //sau varianta 2 
        StreamReader streamReader1 = new StreamReader(newFilePath);
        Console.WriteLine(streamReader1.ReadToEnd());
        streamReader1.Close();


        
    }

}
