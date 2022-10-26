using System;
using System.Collections.Generic;
using System.Text;

namespace Explorer_Tools
{
    public interface IDisplayForm
    {
        public void SelectFile(IFileIcon File);
        public void SelectFolder(IFolderIcon Folder);
        public void DeselectFile(IFileIcon File);
        public void DeselectFolder(IFolderIcon Folder);
    }
    public interface IFileIcon
    {
        public bool IsSelected { get; set; }
        public IDisplayForm Owner { get; set; }
        public string FilePath { get; set; }
        public int FileId { get; set; }
        public abstract void Selected();
        public abstract void Deselected();
    }
    public interface IFolderIcon
    {
        public bool IsSelected { get; set; }
        public IDisplayForm Owner { get; set; }
        public string FilePath { get; set; }
        public abstract void Selected(); 
        public abstract void Deselected();
    }
}
