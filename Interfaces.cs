using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Explorer_Tools
{
    public interface IColorPicker
    {
        public void UpdateColor(Color newColor);
    }
    public interface IRegisteredColor
    {
        public void UpdateVisuals();
        public void Register(ColorReg reg, IRegisteredColor invoker)
        {
            ColorRegistry.RegisterColor(reg, invoker);
        }
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
        public IRegisteredColor owner;
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
        public string DisplayName { get; set; }
        public IView OwningView { get; set; }
        public List<IIcon> SelectedItems { get; set; }
        public virtual void SelectFile(IFileIcon File)
        {
            SelectedItems.Add(File);
        }
        public abstract void SelectItem(IIcon ToSelect);
        public abstract void DeselectItem(IIcon ToRemove);
        public abstract void RemoveItem(IIcon ToRemove);
        public abstract void AddItem(IIcon ToRemove);
        public virtual void Copy()
        {
            if(SelectedItems.Count == 0) { MessageBox.Show("Nothing to copy"); return; }

            foreach(IIcon I in SelectedItems)
            {
                GlobalData.CopyBuffer.Add(I);
            }
            List<IIcon> ToDeselect = SelectedItems;
            while(SelectedItems.Count > 0)
            {
                SelectedItems[0].IconDeselect();
            }
        }
        public virtual void Paste()
        {
            foreach(IIcon I in GlobalData.CopyBuffer)
            {
                AddItem(I);
                SelectItem(I);
            }
            GlobalData.CopyBuffer.Clear();
        }
    }
    public interface IIcon
    {
        public string IcoName { get; set; }
        public bool isSelected { get; set; }
        public virtual void IconSelect()
        {
            Owner.SelectItem(this);
        }
        public virtual void IconDeselect()
        {
            Owner.DeselectItem(this);
        }
        public IDisplayForm Owner { get; set; }
    }

    public interface IView
    {
        public IDisplayForm ActiveDisplayForm { get; set; }
    }

    public interface IFileIcon : IIcon
    {
        public string FilePath { get; set; }
        public int FileId { get; set; }
        public Metadata.Types FileType { get; set; }
    }
    public interface IFolderIcon : IIcon
    {
        public string FolderPath { get; set; }
        public int FolderId { get; set; }
    }
}
