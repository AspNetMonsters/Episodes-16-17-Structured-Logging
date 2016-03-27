using System;
using Serilog;
using GenFu;
using System.Threading;

namespace AspNetCoreLogging
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()              
              .WriteTo.File("log.txt")
              .WriteTo.Seq("http://localhost:5341")
              .CreateLogger();
            
            Log.Logger.Information("Executed at {ExecutionTime}", Environment.TickCount);

            var people = A.ListOf<Person>(100);

            people.ForEach(p =>
                {
                    Log.Logger.Information("{@Person} added at {EntryTime}", p, Environment.TickCount);
                    Thread.Sleep(15);
                });

        }

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

}
