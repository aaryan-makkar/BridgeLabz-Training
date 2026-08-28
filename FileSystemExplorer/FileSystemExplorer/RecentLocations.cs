using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemExplorer
{
    public class LocationNode
    {
        public string Path { get; set; }
        public LocationNode Next { get; set; }
        public LocationNode(string path)
        {
            Path = path;
            Next = null;
        }
    }

    public class RecentLocations
    {
        private LocationNode tail;
        public void Add(string path)
        {
            LocationNode newNode = new LocationNode(path);

            if(tail == null)
            {
                tail = newNode;
                tail.Next = tail;
                return;
            }

            newNode.Next = tail.Next;
            tail.Next = newNode;
            tail = newNode;
        }

        public string ShowNext()
        {
            if (tail == null)
                return null;

            tail = tail.Next;
            return tail.Path;
        }
    }
}
