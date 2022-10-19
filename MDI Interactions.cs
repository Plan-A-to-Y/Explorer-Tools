using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Explorer_Tools
{
    interface MDI_Interactions
    {
        public void FolderSelected(string FolderPath);
        public void FileSelected(File file);
    }
}
