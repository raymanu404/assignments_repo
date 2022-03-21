using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMain.Assignment.Abstractions
{
    public interface ICreateFolder
    {
        void CreateFolder(string nameFolder);
        FileStream CreateFile(string nameFile);
    }
}
