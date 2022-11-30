using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Explorer_Tools
{
    public interface IColorPicker
    {
        public void UpdateColor(Color newColor);
    }
    public interface IRegisteredColor
    {
        public void UpdateVisuals();
        public void Register(ColorReg reg, IRegisteredColor invoker);
    }

    public enum ColorRegType
    {
        Default,
        Tag,
        Type,
        Custom
    }

    public class ColorReg
    {
        public ColorRegType RegType = ColorRegType.Default;
    }

    public class TagReg : ColorReg
    {
        public TagReg()
        {
            RegType = ColorRegType.Tag;
        }
        public Metadata.Tag RegisteredTag;
    }

    public class TypeReg : ColorReg
    {
        public TypeReg()
        {
            RegType = ColorRegType.Type;
        }
        public Metadata.Types RegisteredType;
    }

    public class CustomReg : ColorReg
    {
        public CustomReg()
        {
            RegType = ColorRegType.Custom;
        }
        public int CustomRegID;
    }

    public interface IDisplayForm
    {
        public void SelectFile(IFileIcon File);
        public void SelectFolder(IFolderIcon Folder);
        public void DeselectFile(IFileIcon File);
        public void DeselectFolder(IFolderIcon Folder);
        public void RemoveFile(IFileIcon File);
    }
    public interface IFileIcon
    {
        public bool IsSelected { get; set; }
        public IDisplayForm Owner { get; set; }
        public string FilePath { get; set; }
        public int FileId { get; set; }
        public Metadata.Types FileType { get; set; }
        public abstract void Selected();
        public abstract void Deselected();
    }
    public interface IFolderIcon
    {
        public bool IsSelected { get; set; }
        public IDisplayForm Owner { get; set; }
        public string FolderPath { get; set; }
        public int FolderId { get; set; }
        public abstract void Selected(); 
        public abstract void Deselected();
    }
}
