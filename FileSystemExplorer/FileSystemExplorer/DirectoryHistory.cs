using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemExplorer
{
    public class DirectoryHistory
    {
        private Stack<string> history = new Stack<string>();

        public void visit(string path)
        {
            history.Push(path);
        }

        public string GoBack()
        {
            if(history.Count == 0)
            {
                return "Already at root";
            }
            return history.Pop();
        }
    }
}
