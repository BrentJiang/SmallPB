using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmallPB.database;
using SmallPB.entitymodel;

namespace bizmanage
{
    public static class CheckStatus
    {
        /// <summary>
        /// 需要判断`TradeDate.SystemStatus`是否等于'SyncDone=1`
        /// </summary>
        /// <param name="checkT0"></param>
        public static void CheckSyncDone(TradeContext syncDb, bool checkT0, int date)
        {
            var tradedate = syncDb.TradeDate.FirstOrDefault();
            if (tradedate == null)
            {
                Console.WriteLine("Failed! no trade date exists!");
                return;
            }

            Console.WriteLine("CheckSyncDone Success!");
        }

        public static void CheckTrading(TradeContext db, bool checkT0)
        {
            
        }

        public static void CheckClosed(TradeContext db, bool checkT0)
        {
            
        }

        public static void CheckSettled(TradeContext db, bool checkT0)
        {
            
        }
    }
}
