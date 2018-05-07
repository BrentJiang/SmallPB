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
                Console.WriteLine("usage: <program> <0:schema-name(bizdata|sync|trade|settle|dump)> <1:database-info(./)>");
                Console.WriteLine("  where database info is different for MySQL or SQLite:");
                Console.WriteLine($" - MySQL: <server-address>");
                Console.WriteLine($"   note: you need add user: trade/trade123 before use this utility.");
                Console.WriteLine($" - SQLite: <work-dir>");
                return;
            }
            try
            {
                TradeContext context = null;
                IPAddress address = null;
                if (IPAddress.TryParse(args[1], out address)) // IsUnc
                {
                    context = ContextFactory.Create(ContextFactory.MakeMySQLConnectionString(args[0], args[1]));
                }
                else
                {
                    var fn = $"{args[1].Replace('\\', '/').TrimEnd('/')}";
                    Directory.CreateDirectory(fn);
                    context = ContextFactory.Create($"DataSource={fn}/pb_{args[0].Trim()}.db");
                }
                if (context == null)
                {
                    Console.WriteLine("Failed!");
                }
                else
                {
                    Console.WriteLine("Success!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
