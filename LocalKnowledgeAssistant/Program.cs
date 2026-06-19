using LocalKnowledgeAssistant.Services;

var scanner = new FileScannerService();

Console.Write("Ordner: ");

var path = Console.ReadLine();

Console.WriteLine("Suchbegriff: ");

var searchTerm = Console.ReadLine();

Console.WriteLine($"searchTerm: {searchTerm}");

scanner.SearchFiles(path!, searchTerm!);

