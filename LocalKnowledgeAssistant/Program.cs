using LocalKnowledgeAssistant.Services;

var scanner = new FileScannerService();

Console.Write("Ordner: ");

var path = Console.ReadLine();

scanner.SearchFiles(path!);