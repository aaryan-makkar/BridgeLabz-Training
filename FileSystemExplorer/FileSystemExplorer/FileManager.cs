using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemExplorer
{
    public class FileManager
    {
        private List<FileData> files = new List<FileData>();

        public void Add(FileData file)
        {
            files.Add(file);
        }

        public List<FileData> SortByName()
        {
            return files.OrderBy(f => f.FileName).ToList();
        }

        public List<FileData> SortBySize()
        {
            return files.OrderBy(f => f.Size).ToList();
        }

        public List<FileData> SortByDate()
        {
            return files.OrderBy(f => f.CreatedDate).ToList();
        }

        public FileData BinarySearch(string fileName)
        {
            List<FileData> sorted = SortByName();

            int left = 0;
            int right = sorted.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                int result = string.Compare(sorted[mid].FileName,fileName);

                if (result == 0)
                {
                    return sorted[mid];
                }

                if (result < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return null;
        }
    }
}
