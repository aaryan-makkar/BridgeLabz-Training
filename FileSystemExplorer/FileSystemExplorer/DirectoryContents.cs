using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemExplorer
{
    public class FileNode
    {
        public FileData Data { get; set; }
        public FileNode Next { get; set; }
        public FileNode Previous { get; set; }

        public FileNode(FileData data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }

    public class DirectoryContents
    {
        private FileNode head;
        private FileNode tail;

        public void AddAtBeginning(FileData file)
        {
            FileNode newNode = new FileNode(file); 
            if(head == null)
            {
                head = tail = newNode;
                return;
            }

            newNode.Next = head;
            head.Previous = newNode;
            head = newNode;
        }

        public void AddAtEnd(FileData file)
        {
            FileNode newNode = new FileNode(file);
            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }

        public FileNode NextFile(FileNode rightNow)
        {
            if (rightNow == null)
            {
                return null;
            }
            if (rightNow.Next == null)
            {
                return null;
            }
            return rightNow.Next;
        }

        public FileNode PreviousFile(FileNode rightNow)
        {
            if (rightNow == null)
            {
                return null;
            }
            if (rightNow.Previous == null)
            { 
                return null;
            }
            return rightNow.Previous;
        }

        public void Display()
        {
            FileNode current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
