
# 检查系统状态

## PB交易系统当前状态的数据校验

对于`SystemStatus`的四种状态：
- SyncDone=1，导入数据完成，表示日初程序执行完成，
- Trading=2，盘中交易状态
- Closed=3，收市完成
- Settled=4，结算完成

检查`TradeDate`、`ComboPosition`等数据表格中的数据是否正确。

### SyncDone

在`${SYNC_SCHEMA}.TradeDate`中应该有一条当日交易数据：

  | TraddingDay | NextTradingDay | SystemStatus|
  |--|--|
  | 2018-05-07 | 2018-05-08 | 1 | 

### Trading

### Closed



### Settled

1.3.0版本增加了T+0交易功能，新增的`ComboPosition`表格的一些字段需要在清算后在`${SETTLE_SCHEMA}`中清零，而`${DUMP_SCHEMA}`中保留从`${TRADE_SCHEMA}`中复制的数据。
