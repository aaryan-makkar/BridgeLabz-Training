using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemExplorer
{
    public class FileIndexer
    {
        private Queue<FileData> queue = new Queue<FileData>();

        public void AddJob(FileData file)
        {
            queue.Enqueue(file);
        }

        public void ProcessJobs()
        {
            if(queue.Count == 0)
            {
                Console.WriteLine("No indexing jobs");
                return;
            }

            FileData file = queue.Dequeue();
            Console.WriteLine($"Indexed: {file.FileName}");
        }
    }
}
