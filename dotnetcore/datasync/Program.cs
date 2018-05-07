using System;
using SmallPB.database;

namespace datasync
{
    class Program
    {
        public static string TimeStr(DateTime dateTime)
        {
            return $"{dateTime:yyyy-MM-dd HH:mm:ss.zzz}";
        }

        public static string Now()
        {
            return TimeStr(DateTime.Now);
        }

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: <program> <work-dir(./)>");
                return;
            }
            var fn = $"{args[0].Replace('\\', '/').TrimEnd('/')}";
            Console.WriteLine($"{Now()} Start DataSync (For UFT)! Data directory: {fn}");
            var dbSync = GetContext("DataSource={fn}/pb_sync.db");
            if (dbSync == null)
            {
                Console.WriteLine($"failed to get pb_sync.db at {fn}");
                return;
            }

            // 修改TradeDate

        }
        public static TradeContext GetContext(string connectionString)
        {
            return ContextFactory.Create(connectionString);
        }
    }
}
