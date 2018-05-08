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
                Console.WriteLine($"Usage:");
                Console.WriteLine($"  check status - <program> chkstatus <1:db-info(./)> <2:status(1-SyncDone,2-Trading,3-Closed,4-Settled)> <3:checkT0(1-yes,0-no)> <4:date(20180508)>");
                Console.WriteLine($"  add new operator - <program> addoper <1:db-info(./)> <2:combos(1,2,...)>");
                Console.WriteLine($"  assign security - <program> assign <1:db-info(./)> <2.source-account(1|2|...)> <3.source-combo(1|2|...)> <4.dst-combo(101|102|...)> <5.market(SH|SZ)> <6.instrument> <7.quality>");
                Console.WriteLine($"----------");
                Console.WriteLine($"　where db info is different for MySQL or SQLite:");
                Console.WriteLine($" - MySQL: <server-address>");
                Console.WriteLine($"   note: you need add user: trade/trade123 before use this utility.");
                Console.WriteLine($" - SQLite: <work-dir>");
                return;
            }

            if (args.Length > 2)
            {
                if (args[0].ToLower() == "chkstatus" && args.Length == 5)
                {
                    bool checkT0 = args[3] != "0";
                    switch ((StpSystemStatusEnum)Convert.ToInt32(args[2]))
                    {
                        case StpSystemStatusEnum.STSSyncDone:
                        {
                            TradeContext db = ContextFactory.GetContext("sync", args[0].Trim());
                            if (db == null)
                            {
                                Console.WriteLine($"Failed to init database at {args[1]}!");
                                return;
                            }
                            CheckStatus.CheckSyncDone(db, checkT0, Convert.ToInt32(args[4]));
                            break;
                        }
                        case StpSystemStatusEnum.STSTrading:
                        {
                            TradeContext db = ContextFactory.GetContext("sync", args[0].Trim());
                            if (db == null)
                            {
                                Console.WriteLine($"Failed to init database at {args[1]}!");
                                return;
                            }
                            CheckStatus.CheckTrading(db, checkT0);
                            break;
                        }
                        case StpSystemStatusEnum.STSClosed:
                        {
                            TradeContext db = ContextFactory.GetContext("sync", args[0].Trim());
                            if (db == null)
                            {
                                Console.WriteLine($"Failed to init database at {args[1]}!");
                                return;
                            }
                            CheckStatus.CheckClosed(db, checkT0);
                            break;
                        }
                        case StpSystemStatusEnum.STSSettled:
                        {
                            TradeContext db = ContextFactory.GetContext("sync", args[0].Trim());
                            if (db == null)
                            {
                                Console.WriteLine($"Failed to init database at {args[1]}!");
                                return;
                            }
                            CheckStatus.CheckSettled(db, checkT0);
                            break;
                        }
                        default:
                            Console.WriteLine("Wrong status value!");
                            break;
                    }
                }
                else if (args[0].ToLower() == "assign" && args.Length == 8)
                {
                    TradeContext db = ContextFactory.GetContext("trade", args[0].Trim());
                    if (db == null)
                    {
                        Console.WriteLine($"Failed to init database at {args[1]}!");
                        return;
                    }

                    // [web-日内盘前分券-0001] 
                    // decrease from source combo and addOrUpdate to dst combo.
                    // 交易组合需要设定3个字段：TotalPosition、DayTradeInitVolume、DayTradeAvailVolume
                    var source = db.ComboPosition.SingleOrDefault(p => p.ExchangeID == args[5].ToUpper() &&
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
                    var target = db.ComboPosition.SingleOrDefault(p => p.ExchangeID == args[5].ToUpper() &&
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
