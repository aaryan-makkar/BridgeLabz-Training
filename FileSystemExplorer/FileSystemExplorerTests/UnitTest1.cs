using NUnit.Framework;
using System;
using FileSystemExplorer;

namespace FileSystemExplorer.Tests
{
    [TestFixture]
    public class FileSystemExplorerTests
    {
        [Test]
        public void FileData_Constructor_InitializesProperties()
        {
            DateTime date = DateTime.Now;

            FileData file = new FileData("Resume.pdf",date,1024,"/Documents/Resume.pdf");

            Assert.That(file.FileName, Is.EqualTo("Resume.pdf"));
            Assert.That(file.CreatedDate, Is.EqualTo(date));
            Assert.That(file.Size, Is.EqualTo(1024));
            Assert.That(file.Path, Is.EqualTo("/Documents/Resume.pdf"));
        }

        [Test]
        public void DirectoryHistory_GoBack_ReturnsLastVisitedDirectory()
        {
            DirectoryHistory history = new DirectoryHistory();

            history.visit("/");
            history.visit("/Documents");
            history.visit("/Pictures");

            string result = history.GoBack();

            Assert.That(result, Is.EqualTo("/Pictures"));
        }

        [Test]
        public void DirectoryHistory_GoBack_WhenEmpty_ReturnsRootMessage()
        {
            DirectoryHistory history = new DirectoryHistory();

            string result = history.GoBack();

            Assert.That(result, Is.EqualTo("Already at root"));
        }

        [Test]
        public void FileLookup_Find_ExistingFile_ReturnsFile()
        {
            FileLookup lookup = new FileLookup();

            FileData file = new FileData("Resume.pdf", DateTime.Now, 1000, "/Documents/Resume.pdf");

            lookup.Add(file);

            FileData result = lookup.Find("/Documents/Resume.pdf");

            Assert.That(result, Is.Not.Null);
            Assert.That(result.FileName, Is.EqualTo("Resume.pdf"));
        }

        [Test]
        public void FileLookup_Find_InvalidPath_ReturnsNull()
        {
            FileLookup lookup = new FileLookup();

            FileData result = lookup.Find("/Invalid/File.txt");

            Assert.That(result, Is.Null);
        }

        [Test]
        public void FileManager_SortByName_ReturnsAlphabeticalOrder()
        {
            FileManager manager = new FileManager();

            manager.Add(new FileData("Zebra.txt", DateTime.Now, 100, "/Zebra.txt"));

            manager.Add(new FileData("Apple.txt", DateTime.Now, 100, "/Apple.txt"));

            var sorted = manager.SortByName();

            Assert.That(sorted[0].FileName, Is.EqualTo("Apple.txt"));

            Assert.That(sorted[1].FileName, Is.EqualTo("Zebra.txt"));
        }

        [Test]
        public void FileManager_SortBySize_ReturnsAscendingOrder()
        {
            FileManager manager = new FileManager();

            manager.Add(new FileData("Large.txt", DateTime.Now, 1000, "/Large.txt"));

            manager.Add(new FileData("Small.txt", DateTime.Now, 100, "/Small.txt"));

            var sorted = manager.SortBySize();

            Assert.That(sorted[0].Size, Is.EqualTo(100));
            Assert.That(sorted[1].Size, Is.EqualTo(1000));
        }

        [Test]
        public void FileManager_BinarySearch_ExistingFile_ReturnsFile()
        {
            FileManager manager = new FileManager();

            manager.Add(new FileData("Resume.pdf", DateTime.Now, 500, "/Resume.pdf"));

            manager.Add(new FileData("Notes.txt", DateTime.Now, 300, "/Notes.txt"));

            FileData result = manager.BinarySearch("Resume.pdf");

            Assert.That(result, Is.Not.Null);
            Assert.That(result.FileName, Is.EqualTo("Resume.pdf"));
        }

        [Test]
        public void FileManager_BinarySearch_MissingFile_ReturnsNull()
        {
            FileManager manager = new FileManager();

            manager.Add(new FileData(
                "Resume.pdf",
                DateTime.Now,
                500,
                "/Resume.pdf"));

            FileData result =
                manager.BinarySearch("Missing.txt");

            Assert.That(result, Is.Null);
        }

        [Test]
        public void Integration_AddFile_LookupAndSearch_Workflow()
        {
            FileLookup lookup = new FileLookup();

            FileManager manager = new FileManager();

            FileData file =
                new FileData(
                    "Resume.pdf",
                    DateTime.Now,
                    500,
                    "/Documents/Resume.pdf");

            lookup.Add(file);

            manager.Add(file);

            FileData lookupResult =
                lookup.Find("/Documents/Resume.pdf");

            FileData searchResult =
                manager.BinarySearch("Resume.pdf");

            Assert.That(lookupResult, Is.Not.Null);
            Assert.That(searchResult, Is.Not.Null);

            Assert.That(
                lookupResult.FileName,
                Is.EqualTo(searchResult.FileName));
        }

        [Test]
        public void Integration_DirectoryNavigation_Workflow()
        {
            DirectoryHistory history =
                new DirectoryHistory();

            history.visit("/");

            history.visit("/Documents");

            history.visit("/Projects");

            string firstBack =
                history.GoBack();

            string secondBack =
                history.GoBack();

            Assert.That(
                firstBack,
                Is.EqualTo("/Projects"));

            Assert.That(
                secondBack,
                Is.EqualTo("/Documents"));
        }
    }
}