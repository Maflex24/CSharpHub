string projectName = "SimpleLogger";
string loggersPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), projectName);

string logFileName = "log.txt";
string logFilePath = Path.Combine(loggersPath, logFileName);

if (!Directory.Exists(loggersPath))
    Directory.CreateDirectory(loggersPath);

if (!File.Exists(logFilePath))
    using (FileStream fs = new FileStream(logFilePath, FileMode.Create)) { }


while (true)
{
    var logs = File.ReadAllLines(logFilePath).ToList();
    foreach (var log in logs)
    {
        Console.WriteLine(log);
    }

    Console.Write("Add your log context: ");
    var newLog = Console.ReadLine();

    if (newLog != "" && newLog != "exit")
    {
        logs.Add($"{DateTime.Now} | {newLog}");
        File.WriteAllLines(logFilePath, logs);
        continue;
    }

    return;
}


