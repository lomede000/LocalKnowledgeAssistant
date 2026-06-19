using System;
using System.Collections.Generic;
using System.Text;

namespace LocalKnowledgeAssistant.Services
{
    internal class FileScannerService
    {
        public void SearchFiles(string path)
        {
            var files = Directory.GetFiles(path,"*.PNG",
                SearchOption.AllDirectories);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
