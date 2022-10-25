using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Explorer_Tools
{
    public static class Metadata
    {
        public static List<md_File> FileMetadata;
        public static List<md_Folder> FolderMetadata;

        public static void Initialize()
        {

        }

    }

    public class md_Folder 
    {
        public string IconPath { get; set; }
        public string DisplayName { get; set; }
        public string FolderPath { get; set; }
        public int FolderId { get; set; }
        public md_Folder(string folderPath, string displayName = "")
        {
            FolderPath = folderPath;
            if(displayName.Length > 1) { DisplayName = displayName; } else { DisplayName = FolderPath.Split('\\')[FolderPath.Split('\\').Length - 1]; }
            int i = 0;
            while((from folder in Metadata.FolderMetadata where folder.FolderId == i select folder).Count() > 0)
            {
                i++;
            }
            FolderId = i;
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

    public class md_File
    {
        public fileDisplayType FDT;
        public string IconPath { get; set; }
        public string DisplayName { get; set; }
        public string FilePath { get; set; }
        public int FileId { get; set; }

        public md_File(string filePath, string displayName = "")
        {
            FilePath = filePath;
            if (displayName.Length > 1) { DisplayName = displayName; } else { DisplayName = FilePath.Split('\\')[FilePath.Split('\\').Length - 1]; }
        }
    }

    public enum fileDisplayType
    {
        basic,
        image,
        text
    }
}
