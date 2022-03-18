using System.IO;
using System;
using AssignmentMain.Assignment;

namespace AssignmentMain;

class Program
{
    static async Task Main(string[] args)
    {

        String currentPath = Directory.GetCurrentDirectory();
        
        MyCustomClass myCustomClass = new MyCustomClass(currentPath);
        //cream un fisier unde sa avem o lista cu nume pentru fisiere

        myCustomClass.CreateFolder("MyFolder");
        
       

        HashSet<string> listOfFolders = new HashSet<string>();
        string herosTxt = Path.Combine(currentPath, "MyFolder/Heroes.txt");
        string myfolder = Path.Combine(currentPath, "MyFolder");


        FileStream fileStream = myCustomClass.CreateFile("MyFolder", "Heroes.txt");

        using (StreamWriter sw = new StreamWriter(fileStream))
        {
            sw.WriteLine(new Heroes { Id = 1, Name = "SuperMan", Power = "Super strenght", Age = 32 });
            sw.WriteLine(new Heroes { Id = 2, Name = "Batman", Power = "Super smart", Age = 34 });
            sw.WriteLine(new Heroes { Id = 3, Name = "Spiderman", Power = "Spidey Power", Age = 20 });
        }


        using (StreamReader streamReader = new StreamReader(herosTxt))
        {
            while (!streamReader.EndOfStream)
            {
                var name = streamReader.ReadLine();
                myCustomClass.CreateFolder(Path.Combine(myfolder, name.Split(":")[1]));              
            }
        }
        Console.WriteLine("Am creat folderele"); 
        
        DirectoryInfo dirInfo = new DirectoryInfo(myfolder);
      
        foreach (var folder in dirInfo.GetDirectories())
        {
            listOfFolders.Add(folder.Name);
        }

        foreach(var folder in listOfFolders)
        {
            string path = @""+ myfolder + "\\" + folder;
            var newFile = myCustomClass.CreateFile(path, folder + ".txt");
            using (StreamWriter streamWriter = new StreamWriter(newFile))
            {
                streamWriter.WriteLine(folder);
            }

            string newPath = Path.GetFullPath(Path.Combine(path, @"..\"));
        }

        Console.WriteLine("Am creat fisierele");



    }
}

