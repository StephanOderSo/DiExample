// See https://aka.ms/new-console-template for more information
using DiExampleConsole;

Console.WriteLine("Hello, World!");


ConsoleLogger cLogger = new ConsoleLogger();
TextLogger tLogger = new TextLogger();

Client client = new Client(cLogger);

client.DoSomething();

Console.ReadLine();