
# 重新跑清算脚本

需要执行的逻辑包括：
- 恢复`${SETTLE_SCHEMA}`和`${BIZDATA_SCHEMA}`的`tradedate.SystemStatus`为`3`(Closed): 
- 恢复当日已经做过的日初的数据
- 将状态准备用于启动核心系统。

```sql
-- 模拟重新进行前一日(2018-05-07)的清算，并进行当日2018-05-08日初pb_sync
-- sync should already be done
delete from pb_settle.tradedate;
insert into pb_settle.tradedate (tradingday, nexttradingday, systemstatus) values (20180507,20180508, 3)
UPDATE pb_bizdata.tradedate SET SystemStatus=3;

-- 可能已经做过2018-05-08的日初，把日期恢复成上一日
UPDATE pb_trade.accountasset SET TradingDay=(SELECT TradingDay FROM pb_sync.tradedate);
UPDATE pb_trade.comboposition SET TradingDay=(SELECT TradingDay FROM pb_sync.tradedate);
UPDATE pb_trade.`order` SET TradingDay=(SELECT TradingDay FROM pb_sync.tradedate);
UPDATE pb_trade.trade SET TradingDay=(SELECT TradingDay FROM pb_sync.tradedate);
UPDATE pb_trade.tradedate SET TradingDay=(SELECT TradingDay FROM pb_sync.tradedate);

-- 此处执行settlementT0.sql

-- prepare for ./startSyncData.sh
UPDATE pb_bizdata.tradedate SET SystemStatus=1;
delete from pb_settle.tradedate;
insert into pb_settle.tradedate (tradingday, nexttradingday, systemstatus) values (20180507,20180508, 4)

-- prepare for ./startTradeService.sh
delete from pb_sync.tradedate;
insert into pb_sync.tradedate (tradingday, nexttradingday, systemstatus) values (20180507,20180508, 4)
```