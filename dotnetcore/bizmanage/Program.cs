using System;
using System.Linq;
using SmallPB.database;
using SmallPB.entitymodel;

namespace bizmanage
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("  add new operator - <program> addoper <db(/proj/STP/pb_trade|...)> <combos(1,2,...)>");
                Console.WriteLine("  assign security - <program> assign <1.db(/proj/STP/pb_trade|...)> <2.source-account(1|2|...)> <3.source-combo(1|2|...)> <4.dst-combo(101|102|...)> <5.market(SH|SZ)> <6.instrument> <7.quality>");
                return;
            }

            if (args.Length > 2)
            {
                TradeContext db = GetContext(args[1]);
                if (db == null)
                {
                    Console.WriteLine($"Failed to init database at {args[1]}!");
                    return;
                }
                if (args[0] == "assign" && args.Length == 8)
                {
                    // [web-日内盘前分券-0001] 
                    // decrease from source combo and addOrUpdate to dst combo.
                    // 交易组合需要设定3个字段：TotalPosition、DayTradeInitVolume、DayTradeAvailVolume
                    var source = db.ComboPositions.SingleOrDefault(p => p.ExchangeID == args[5].ToUpper() &&
                                                           p.InstrumentID == args[6].ToUpper() && p.AccountID == Convert.ToInt32(args[2])
                                                           && p.ComboID == Convert.ToInt32(args[3]));
                    if (source == null)
                    {
                        Console.WriteLine($"Failed to get instrument {args[5]} {args[6]}");
                        return;
                    }
                    var chg = Convert.ToInt32(args[7]);
                    source.TotalPosition -= chg;
                    source.DayTradeInitVolume -= chg;
                    source.DayTradeAvailVolume -= chg;
                    var target = db.ComboPositions.SingleOrDefault(p => p.ExchangeID == args[5].ToUpper() &&
                                                                        p.InstrumentID == args[6].ToUpper() && 
                                                                        p.AccountID == Convert.ToInt32(args[2])
                                                                        && p.ComboID == Convert.ToInt32(args[4]));
                    if (target == null)
                    {
                        target = new StpComboPosition
                        {
                            AccountID = Convert.ToInt32(args[2]),
                            InstrumentID = args[6].ToUpper(),
                            ExchangeID = args[5].ToUpper(),
                            ComboID = Convert.ToInt32(args[4])
                        };
                        db.Add(target);
                    }
                    else
                    {
                        db.Update(target);
                    }
                    target.TotalPosition += chg;
                    target.DayTradeInitVolume += chg;
                    target.DayTradeAvailVolume += chg;
                    db.Update(source);
                    db.SaveChanges();
                }
            }
        }
        public static TradeContext GetContext(string connectionString)
        {
            return ContextFactory.Create(connectionString);
        }
    }
}
