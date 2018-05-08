using System;
using System.IO;
using System.Net;
using SmallPB.database;

namespace initdb
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("usage: <program> <0:schema-name(bizdata|sync|trade|settle|dump)> <1:db-info(./)>");
                Console.WriteLine("  where db info is different for MySQL or SQLite:");
                Console.WriteLine($" - MySQL: <server-address>");
                Console.WriteLine($"   note: you need add user: trade/trade123 before use this utility.");
                Console.WriteLine($" - SQLite: <work-dir>");
                return;
            }
            TradeContext context = ContextFactory.GetContext(args[0], args[1]);

            if (context == null)
            {
                Console.WriteLine("Failed!");
            }
            else
            {
                Console.WriteLine("Success!");
            }
        }

    }
}
