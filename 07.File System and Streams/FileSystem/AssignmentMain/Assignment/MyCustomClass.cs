using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentMain.Assignment.Abstractions;

namespace AssignmentMain.Assignment;

public class MyCustomClass : ICreateFolder
{

    public String CurrentPath { get; set; }
    public MyCustomClass(String currentPath)
    {
        CurrentPath = currentPath;
    }
    public FileStream CreateFile(String currentPath,string nameFile)
    {
        string current_folder = Path.Combine(Directory.GetCurrentDirectory(), currentPath);
        string newFilePath = Path.Combine(current_folder, nameFile);
        FileStream fileStream = null;
        //if (!File.Exists(newFilePath))
        fileStream = File.Create(newFilePath);
        return fileStream;
    }

    public void CreateFolder(string nameFolder)
    {
        string newDirPath = Path.Combine(CurrentPath, nameFolder);
        if (!Directory.Exists(newDirPath)) 
            Directory.CreateDirectory(newDirPath);
    }



}
