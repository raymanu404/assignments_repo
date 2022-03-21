using System.IO;
using System;
using AssignmentMain.Assignment;

namespace AssignmentMain;

class Program
{
    static async Task Main(string[] args)
    {

        String currentPath = Directory.GetCurrentDirectory();
        
        CreateHeroes createHeroes = new CreateHeroes() { CurrentPath = currentPath};
        createHeroes.CreateFolder("MyFolder");            
        
        string herosTxt = Path.Combine(createHeroes.CurrentPath, "MyFolder/Heroes.txt");
        createHeroes.CurrentPath = Path.Combine(currentPath, "MyFolder");

        FileStream fileStream = createHeroes.CreateFile("Heroes.txt");
        createHeroes.WriteInFile(fileStream);
        createHeroes.ReadFromFile(herosTxt);

        createHeroes.CreateFilesHeroes();

    }
}

