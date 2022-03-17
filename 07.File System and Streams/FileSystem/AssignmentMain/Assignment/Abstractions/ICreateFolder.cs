using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMain.Assignment.Abstractions
{
    public interface ICreateFolder
    {
        void CreateFolder(String nameFolder);
        FileStream CreateFile(String currentPath, String nameFile);
    }
}
