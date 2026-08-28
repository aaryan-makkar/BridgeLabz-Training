using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemExplorer
{
    public class FileData
    {
        public string FileName { get; set; }
        public DateTime CreatedDate { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }

        public FileData(string fileName, DateTime createdDate, long size, string path)
        {
            FileName = fileName;
            CreatedDate = createdDate;
            Size = size;
            Path = path;
        }

        public override string ToString()
        {
            return $"{FileName} - {Size} bytes";
        }
    }
}
