using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using static Explorer_Tools.StyleOptions;

namespace Explorer_Tools
{
    public static class Metadata
    {
        public enum Types
        {
            File,
            Folder,
            Image,
            Text,
            Doc,
            URL
        }
        public enum FilterTypes
        {
            Type,
            Extension,
            Tag,
            None
        }

        public enum SortTypes
        {
            Name,
            Size,
            DateModified,
            Tag
        }

        [Serializable]
        public struct ExtSlot
        {
            public string ext { get; set; }
            public string path { get; set; }
        }
        [Serializable]
        public struct Tag
        {
            public override string ToString()
            {
                return Name;
            }
            public string Name { get; set; }
            public List<string> Aliases { get; set; }
            public List<StyleOptions.ColorSlot> Colors { get; set; }
            public string Icon { get; set; }
        }

        [Serializable]
        public class MDFile
        {
            public List<md_File> FileMD { get; set; }
            public List<md_Folder> FolderMD { get; set; }
            public List<Tag> TagData { get; set; }
            public List<string> IconPaths;
            public List<ExtSlot> ExtIcoPaths;
        }
        public static MDFile main;
        public static List<md_File> FileMetadata;
        public static List<md_Folder> FolderMetadata;
        public static List<string> Icons;
        public static List<ExtSlot> ExtIcons;
        public static List<Tag> Tags;
        public static void Initialize()
        {
            if (File.Exists(".\\FileData.FD"))
            {
                LoadData();
            }
            else
            {
                FileMetadata = new List<md_File>();
                FolderMetadata = new List<md_Folder> { };
                Icons = new List<string> { ".\\Icons\\Default.png" };
                ExtIcons = new List<ExtSlot>();
                main = new MDFile();
                Tags = new List<Tag> { new Tag() { Name = "TEST TAG 1" }, new Tag() { Name = "TEST TAG 2" } };
                main.FileMD = FileMetadata;
                main.FolderMD = FolderMetadata;
                main.ExtIcoPaths = ExtIcons;
                main.TagData = Tags;
                SaveData();
            }
        }

        public static md_Folder FindFolderData(string Path)
        {
            if(Path==null)
            {
                return new md_Folder(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            }
            if(FolderMetadata.Exists(x => x.FolderPath.Equals(Path)))
            {
                return FolderMetadata.Find(x => x.FolderPath.Equals(Path));
            }
            md_Folder md = new md_Folder(Path);
            FolderMetadata.Add(md);
            SaveData();
            return md;
        }

        public static md_File FindFileData(string Path)
        {
            if (FileMetadata.Exists(x => x.FilePath.Equals(Path)))
            {
                return FileMetadata.Find(x => x.FilePath.Equals(Path));
            }
            md_File md = new md_File(Path);
            FileMetadata.Add(md);
            SaveData();
            return md;
        }

        public static void UpdateFolderData(md_Folder toUpdate)
        {
            FolderMetadata.Remove((from x in FolderMetadata where x.FolderId == toUpdate.FolderId select x).First());
            FolderMetadata.Add(toUpdate);
            SaveData();
        }

        public static void UpdateFileData(md_File toUpdate)
        {
            FileMetadata.Remove((from x in FileMetadata where x.FileId == toUpdate.FileId select x).First());
            FileMetadata.Add(toUpdate);
            SaveData();
        }

        public static Types GetFileType(string path)
        {
            List<string> ImageTypes = new List<string> { ".bmp", ".png", ".jpg", ".jpeg", ".gif" };
            List<string> TextTypes = new List<string> { ".txt" };
            List<string> DocTypes = new List<string> { ".docx" };
            string ext = "." + path.Split('.').Last();
            if (ImageTypes.Contains(ext)) { return Types.Image; }
            else if (TextTypes.Contains(ext)) { return Types.Text; }
            else if (DocTypes.Contains(ext)) { return Types.Doc; }
            else { return Types.File; }
        }
        public static void LoadData()
        {
            if (File.Exists(".\\FileData.FD")) main = JsonSerializer.Deserialize<MDFile>(File.ReadAllText(".\\FileData.FD"));
            else { main = new MDFile(); main.FileMD = new List<md_File>(); main.FolderMD = new List<md_Folder>(); }
            FolderMetadata = main.FolderMD;
            FileMetadata = main.FileMD;
            Icons = main.IconPaths;
            Tags = main.TagData;
        }

        public static void SaveData()
        {
            string toSave = JsonSerializer.Serialize(main);
            File.WriteAllText(".\\FileData.FD", toSave);
        }
    }
    [Serializable]
    public class md_Folder 
    {
        public string IconPath { get; set; }
        public string DisplayName { get; set; }
        public string FolderPath { get; set; }
        public int FolderId { get; set; }
        public List<ColorSlot> FormColors { get; set; }
        public string IconOverride { get; set; }
        public string FolderDesc { get; set; }
        public string FolderDetails { get; set; }
        public DateTime ScanDate { get; set; }

        public md_Folder()
        {
            FolderPath = "C:\\";
            IconPath = ".\\Icons\\Default.png";
        }

        public md_Folder(string folderPath, string displayName = "")
        {
            FolderPath = folderPath;
            FormColors = new List<ColorSlot> { 
                new ColorSlot(colorSlot.SelectedColor), 
                new ColorSlot(colorSlot.EntryColor), 
                new ColorSlot(colorSlot.HeaderColor),
                new ColorSlot(colorSlot.BorderColor),
                new ColorSlot(colorSlot.BorderCornerColor),
                new ColorSlot(colorSlot.TextColor)
            };
            if (folderPath == null)
            {
                return;
            }
            if(displayName.Length > 1) { DisplayName = displayName; } else { DisplayName = FolderPath.Split('\\')[FolderPath.Split('\\').Length - 1]; }
            FolderId = 1;
            while (Metadata.FileMetadata.Find(x => x.FileId == FolderId) != null)
            {
                FolderId++;
            }
            IconPath = ".\\Icons\\Default.png";
        }

        public void SetIcon(string iconPath)
        {
            if(File.Exists(iconPath))
            {
                File.Replace(iconPath, $".\\Icons\\{FolderId}", null);
            }
            IconPath = iconPath;
        }
    }
    [Serializable]
    public class md_File
    {
        public Metadata.Types Type;
        public string IconPath { get; set; }
        public string DisplayName { get; set; }
        public string FilePath { get; set; }
        public int FileId { get; set; }
        public List<ColorSlot> FormColors { get; set; }
        public string IconOverride { get; set; }
        public md_File()
        {

        }
        public md_File(string filePath, string displayName = "")
        {
            FileId = 1;
            while(Metadata.FileMetadata.Find(x => x.FileId == FileId) != null)
            {
                FileId++;
            }
            FormColors = new List<ColorSlot>();
            FilePath = filePath;
            if (displayName.Length > 1) { DisplayName = displayName; } else { DisplayName = FilePath.Split('\\')[FilePath.Split('\\').Length - 1]; }
            FormColors = new List<ColorSlot> {
                new ColorSlot(colorSlot.SelectedColor),
                new ColorSlot(colorSlot.EntryColor),
                new ColorSlot(colorSlot.HeaderColor),
                new ColorSlot(colorSlot.BorderColor),
                new ColorSlot(colorSlot.BorderCornerColor),
                new ColorSlot(colorSlot.TextColor)
            };
        }
    }
}
