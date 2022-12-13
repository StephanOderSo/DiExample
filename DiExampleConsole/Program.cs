// See https://aka.ms/new-console-template for more information
using DiExampleConsole;

Console.WriteLine("Hello, World!");


ConsoleLogger cLogger = new ConsoleLogger();
TextLogger tLogger = new TextLogger("C:\\temp\\di.log");

/// <summary>
/// At this point, the Logtype will be injected via constructor
/// </summary>
Client consoleClient = new Client(cLogger);
Client textClient = new Client(tLogger);


consoleClient.DoSomething();
textClient.DoSomething();

Console.ReadLine();