using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentMain.Assignment.Abstractions;

namespace AssignmentMain.Assignment;

public class CreateHeroes : ICreateFolder
{

    public string CurrentPath { get; set; }
    public FileStream CreateFile(string nameFile)
    {

        string newFilePath = Path.Combine(CurrentPath, nameFile);
        FileStream fileStream = File.Create(newFilePath);

        return fileStream;
    }

    public void CreateFolder(string nameFolder)
    {
        string newDirPath = Path.Combine(CurrentPath, nameFolder);
        if (!Directory.Exists(newDirPath)) 
            Directory.CreateDirectory(newDirPath);
    }

    public void WriteInFile(FileStream fileStream)
    {
        using (StreamWriter sw = new StreamWriter(fileStream))
        {
            sw.WriteLine(new Heroes { Id = 1, Name = "SuperMan", Power = "Super strenght", Age = 32 });
            sw.WriteLine(new Heroes { Id = 2, Name = "Batman", Power = "Super smart", Age = 34 });
            sw.WriteLine(new Heroes { Id = 3, Name = "Spiderman", Power = "Spidey Power", Age = 20 });
        }
    }

    public void ReadFromFile(string textFile)
    {
        using (StreamReader streamReader = new StreamReader(textFile))
        {
            while (!streamReader.EndOfStream)
            {
                var name = streamReader.ReadLine();
                CreateFolder(Path.Combine(CurrentPath, name.Split(":")[1]));
            }
        }
        Console.WriteLine("Am creat folderele");
    }

    public IEnumerable<string> GetFileName()
    {

        DirectoryInfo dirInfo = new DirectoryInfo(CurrentPath);
        foreach (var folder in dirInfo.GetDirectories())
        {
            yield return folder.Name;
        }

    }

    public void CreateFilesHeroes()
    {
        foreach (var folder in GetFileName())
        {

            string path = Path.Combine(CurrentPath, folder);
            CurrentPath = path;
            var newFile = CreateFile(folder + ".txt");
            using (StreamWriter streamWriter = new StreamWriter(newFile))
            {
                streamWriter.WriteLine(folder);
            }

            CurrentPath = Path.GetFullPath(Path.Combine(path, @"..\")); //revenim la folder parinte

        }

        Console.WriteLine("Am creat fisierele");
    }



}
