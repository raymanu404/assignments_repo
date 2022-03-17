using System.IO;
using System;
using AssignmentMain.Assignment;

namespace AssignmentMain;

class Program
{
    static async Task Main(string[] args)
    {

        String currentPath = Directory.GetCurrentDirectory();
        
        MyCustomClass myCustomClass = new MyCustomClass(Directory.GetCurrentDirectory());
        //cream un fisier unde sa avem o lista cu nume pentru fisiere
        myCustomClass.CreateFolder("MyFolder");

        //FileStream fileStream = myCustomClass.CreateFile("MyFolder", "Heroes.txt");

        HashSet<string> listOfFolders = new HashSet<string>();
        string herosTxt = Path.Combine(currentPath, "MyFolder/Heroes.txt");
        string myfolder = Path.Combine(currentPath, "MyFolder");

        using (StreamReader streamReader = new StreamReader(herosTxt))
        {
            while (!streamReader.EndOfStream)
            {
                myCustomClass.CreateFolder(Path.Combine(myfolder, streamReader.ReadLine()));              
            }
        }
          
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
       
       
    }
}

