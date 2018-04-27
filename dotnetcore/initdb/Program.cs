using System;
using SmallPB.database;

namespace initdb
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("usage: <program> <schema-name(bizdata|sync|trade|settle|dump)> <work-dir(./)>");
                return;
            }


        }

        public static TradeContext GetContext(string connectionString)
        {
            return ContextFactory.Create(connectionString);
        }
    }
}
