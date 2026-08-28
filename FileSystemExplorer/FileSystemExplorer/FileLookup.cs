using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemExplorer
{
    public class FileLookup
    {
        private Dictionary<string, FileData> files = new Dictionary<string, FileData>();

        public void Add(FileData file)
        {
            files[file.Path] = file;
        }

        public FileData Find(string path)
        {
            if(files.ContainsKey(path))
            {
                return files[path];
            }

            return null;
        }
    }
}
