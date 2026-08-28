using System;

namespace FileSystemExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            FileData file1 = new FileData("Resume.pdf",DateTime.Now,1024,"/Documents/Resume.pdf");

            FileData file2 = new FileData(
                "Notes.txt",
                DateTime.Now,
                512,
                "/Documents/Notes.txt");

            FileData file3 = new FileData(
                "Photo.jpg",
                DateTime.Now,
                2048,
                "/Pictures/Photo.jpg");

            Console.WriteLine("DIRECTORY CONTENTS");

            DirectoryContents directory = new DirectoryContents();

            directory.AddAtBeginning(file1);
            directory.AddAtBeginning(file2);

            Console.WriteLine("Files added to directory.");

            Console.WriteLine();

            Console.WriteLine("DIRECTORY HISTORY");

            DirectoryHistory history = new DirectoryHistory();

            history.visit("/");

            history.visit("/Documents");

            history.visit("/Pictures");

            Console.WriteLine($"Back: {history.GoBack()}");
            Console.WriteLine($"Back: {history.GoBack()}");
            Console.WriteLine($"Back: {history.GoBack()}");
            Console.WriteLine($"Back: {history.GoBack()}");

            Console.WriteLine();

            Console.WriteLine("RECENT LOCATIONS");

            RecentLocations recent = new RecentLocations();

            recent.Add("/");

            recent.Add("/Documents");

            recent.Add("/Pictures");

            recent.ShowNext();
            recent.ShowNext();
            recent.ShowNext();
            recent.ShowNext();

            Console.WriteLine();

            Console.WriteLine("FILE INDEXER");

            FileIndexer indexer = new FileIndexer();

            indexer.AddJob(file1);
            indexer.AddJob(file2);
            indexer.AddJob(file3);

            indexer.ProcessJobs();
            indexer.ProcessJobs();
            indexer.ProcessJobs();
            indexer.ProcessJobs();

            Console.WriteLine();

            Console.WriteLine("FILE LOOKUP");

            FileLookup lookup = new FileLookup();

            lookup.Add(file1);
            lookup.Add(file2);
            lookup.Add(file3);

            FileData found =
                lookup.Find("/Documents/Resume.pdf");

            if (found != null)
            {
                Console.WriteLine($"Found: {found}");
            }
            else
            {
                Console.WriteLine("File not found");
            }

            Console.WriteLine();

            Console.WriteLine("SORTING & SEARCHING");

            FileManager manager = new FileManager();

            manager.Add(file1);
            manager.Add(file2);
            manager.Add(file3);

            Console.WriteLine("Sorted By Name:");

            foreach (FileData file in manager.SortByName())
            {
                Console.WriteLine(file);
            }

            Console.WriteLine();

            Console.WriteLine("Sorted By Size:");

            foreach (FileData file in manager.SortBySize())
            {
                Console.WriteLine(file);
            }

            Console.WriteLine();

            FileData searchResult =
                manager.BinarySearch("Resume.pdf");

            if (searchResult != null)
            {
                Console.WriteLine(
                    $"Binary Search Found: {searchResult}");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}