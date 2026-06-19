using System;
using System.Collections.Generic;
using System.Text;

namespace LocalKnowledgeAssistant.Services
{
    internal class FileScannerService
    {
        public void SearchFiles(string path, string searchTerm)
        {
            var files = Directory.GetFiles(
                path,
                "*",
                SearchOption.AllDirectories);

            int count = 0;

            foreach (var file in files)
            {
                if (Path.GetFileName(file).Contains(
                    searchTerm,
                    StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(file);
                    count++;
                }
            }

            Console.WriteLine($"\n{count} Treffer gefunden.");
        }
    }
}