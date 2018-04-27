
using System;
using Microsoft.EntityFrameworkCore;
using SmallPB.entitymodel;

namespace SmallPB.database
{

    public class TradeContext : DbContext
    {
        public TradeContext(DbContextOptions<TradeContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    
            /// total 1 key-elements
            modelBuilder.Entity<StpTradeDate>().HasIndex(b => new {
                b.TradingDay,
            }).IsUnique(true);
        
            /// total 3 key-elements
            modelBuilder.Entity<StpInstrument>().HasIndex(b => new {
                b.ExchangeID,
                b.ProductID,
                b.InstrumentID,
            }).IsUnique(true);
        
            /// total 1 key-elements
            modelBuilder.Entity<StpCompany>().HasIndex(b => new {
                b.CompanyID,
            }).IsUnique(true);
        
            /// total 1 key-elements
            modelBuilder.Entity<StpOperator>().HasIndex(b => new {
                b.OperatorID,
            }).IsUnique(true);
        
            /// total 1 key-elements
            modelBuilder.Entity<StpAuthInfo>().HasIndex(b => new {
                b.AuthID,
            }).IsUnique(true);
        
            /// total 2 key-elements
            modelBuilder.Entity<StpOpAuthInfo>().HasIndex(b => new {
                b.OperatorID,
                b.AuthID,
            }).IsUnique(true);
        
            /// total 1 key-elements
            modelBuilder.Entity<StpIntefAuthInfo>().HasIndex(b => new {
                b.CmdID,
            }).IsUnique(true);
        
            /// total 1 key-elements
            modelBuilder.Entity<StpRole>().HasIndex(b => new {
                b.RoleID,
            }).IsUnique(true);
        
            /// total 2 key-elements
            modelBuilder.Entity<StpRoleAuth>().HasIndex(b => new {
                b.RoleID,
                b.AuthID,
            }).IsUnique(true);
        
            /// total 2 key-elements
            modelBuilder.Entity<StpFileDownload>().HasIndex(b => new {
                b.SysDate,
                b.SysSeqID,
            }).IsUnique(true);
        
            /// total 1 key-elements
            modelBuilder.Entity<StpCmdSequence>().HasIndex(b => new {
                b.SeqName,
            }).IsUnique(true);
        
            /// total 2 key-elements
            modelBuilder.Entity<StpOpMarket>().HasIndex(b => new {
                b.MarketDataType,
                b.OperatorID,
            }).IsUnique(true);
        
            /// total 3 key-elements
            modelBuilder.Entity<StpMarketDataPay>().HasIndex(b => new {
                b.CompanyID,
                b.ExchangeID,
                b.PaySubject,
            }).IsUnique(true);
        
            /// total 1 key-elements
            modelBuilder.Entity<StpMarketDataPayFlow>().HasIndex(b => new {
                b.PayID,
            }).IsUnique(true);
        
            /// total 2 key-elements
            modelBuilder.Entity<StpAccount>().HasIndex(b => new {
                b.AccountID,
                b.TradingDay,
            }).IsUnique(true);
        
            /// total 2 key-elements
            modelBuilder.Entity<StpAccountCombo>().HasIndex(b => new {
                b.ComboID,
                b.TradingDay,
            }).IsUnique(true);
        
            /// total 2 key-elements
            modelBuilder.Entity<StpInvestor>().HasIndex(b => new {
                b.InvestorID,
                b.TradingDay,
            }).IsUnique(true);
        
            /// total 4 key-elements
            modelBuilder.Entity<StpTradingCode>().HasIndex(b => new {
                b.TradingDay,
                b.AccountID,
                b.ExchangeID,
                b.TradingCodeType,
            }).IsUnique(true);
        
            /// total 2 key-elements
            modelBuilder.Entity<StpTradeChannel>().HasIndex(b => new {
                b.ChannelID,
                b.TradingDay,
            }).IsUnique(true);
        
            /// total 3 key-elements
            modelBuilder.Entity<StpAccountAsset>().HasIndex(b => new {
                b.TradingDay,
                b.AccountID,
                b.CurrencyID,
            }).IsUnique(true);
        
            /// total 8 key-elements
            modelBuilder.Entity<StpAccountPosition>().HasIndex(b => new {
                b.AccountID,
                b.ExchangeID,
                b.InstrumentID,
                b.CoveredFlag,
                b.PosiDirection,
                b.TradeCode,
                b.TradingCodeType,
                b.TradingDay,
            }).IsUnique(true);
        
            /// total 9 key-elements
            modelBuilder.Entity<StpComboPosition>().HasIndex(b => new {
                b.AccountID,
                b.ExchangeID,
                b.ComboID,
                b.InstrumentID,
                b.CoveredFlag,
                b.PosiDirection,
                b.TradeCode,
                b.TradingCodeType,
                b.TradingDay,
            }).IsUnique(true);
        
            /// total 5 key-elements
            modelBuilder.Entity<StpDayTradePositionAdjReq>().HasIndex(b => new {
                b.OperatorID,
                b.AccountID,
                b.ExchangeID,
                b.ComboID,
                b.InstrumentID,
            }).IsUnique(true);
        
            /// total 11 key-elements
            modelBuilder.Entity<StpAccountPositionDtl>().HasIndex(b => new {
                b.AccountID,
                b.ExchangeID,
                b.ComboID,
                b.InstrumentID,
                b.CoveredFlag,
                b.PosiDirection,
                b.OpenDate,
                b.TradeID,
                b.TradeCode,
                b.TradingCodeType,
                b.TradingDay,
            }).IsUnique(true);
        
            /// total 12 key-elements
            modelBuilder.Entity<StpFeeSet>().HasIndex(b => new {
                b.CompanyID,
                b.AccountID,
                b.ExchangeID,
                b.InstrumentID,
                b.ProductClass,
                b.ProductID,
                b.Direction,
                b.OffsetFlag,
                b.CoveredFlag,
                b.HedgeFlag,
                b.FeeType,
                b.TradingDay,
            }).IsUnique(true);
        
            /// total 10 key-elements
            modelBuilder.Entity<StpMarginRate>().HasIndex(b => new {
                b.TradingDay,
                b.AccountID,
                b.InvestorRange,
                b.ExchangeID,
                b.InstrumentID,
                b.CoveredFlag,
                b.HedgeFlag,
                b.OptionType,
                b.ProductClass,
                b.ProductID,
            }).IsUnique(true);
        
            /// total 5 key-elements
            modelBuilder.Entity<StpOrder>().HasIndex(b => new {
                b.TradingDay,
                b.AccountID,
                b.ExchangeID,
                b.SeatID,
                b.OrderLocalID,
            }).IsUnique(true);
        
            /// total 5 key-elements
            modelBuilder.Entity<StpTrade>().HasIndex(b => new {
                b.TradingDay,
                b.AccountID,
                b.ExchangeID,
                b.TradeID,
                b.Direction,
            }).IsUnique(true);
        
            /// total 2 key-elements
            modelBuilder.Entity<StpRiskRule>().HasIndex(b => new {
                b.TradingDay,
                b.RiskId,
            }).IsUnique(true);
        
            /// total 2 key-elements
            modelBuilder.Entity<StpRiskRuleLog>().HasIndex(b => new {
                b.TradingDay,
                b.SequenceNo,
            }).IsUnique(true);
        
            /// total 2 key-elements
            modelBuilder.Entity<StpAdminCommand>().HasIndex(b => new {
                b.TradingDay,
                b.SequenceNo,
            }).IsUnique(true);
        
        }

    
        public DbSet<StpTradeDate> TradeDates { get; set; }
      
        public DbSet<StpInstrument> Instruments { get; set; }
      
        public DbSet<StpCompany> Companys { get; set; }
      
        public DbSet<StpOperator> Operators { get; set; }
      
        public DbSet<StpAuthInfo> AuthInfos { get; set; }
      
        public DbSet<StpOpAuthInfo> OpAuthInfos { get; set; }
      
        public DbSet<StpIntefAuthInfo> IntefAuthInfos { get; set; }
      
        public DbSet<StpOpLog> OpLogs { get; set; }
      
        public DbSet<StpRole> Roles { get; set; }
      
        public DbSet<StpRoleAuth> RoleAuths { get; set; }
      
        public DbSet<StpFileDownload> FileDownloads { get; set; }
      
        public DbSet<StpCmdSequence> CmdSequences { get; set; }
      
        public DbSet<StpOpMarket> OpMarkets { get; set; }
      
        public DbSet<StpMarketDataPay> MarketDataPays { get; set; }
      
        public DbSet<StpMarketDataPayFlow> MarketDataPayFlows { get; set; }
      
        public DbSet<StpAccount> Accounts { get; set; }
      
        public DbSet<StpAccountCombo> AccountCombos { get; set; }
      
        public DbSet<StpInvestor> Investors { get; set; }
      
        public DbSet<StpTradingCode> TradingCodes { get; set; }
      
        public DbSet<StpTradeChannel> TradeChannels { get; set; }
      
        public DbSet<StpAccountAsset> AccountAssets { get; set; }
      
        public DbSet<StpAccountPosition> AccountPositions { get; set; }
      
        public DbSet<StpComboPosition> ComboPositions { get; set; }
      
        public DbSet<StpDayTradePositionAdjReq> DayTradePositionAdjReqs { get; set; }
      
        public DbSet<StpAccountPositionDtl> AccountPositionDtls { get; set; }
      
        public DbSet<StpFeeSet> FeeSets { get; set; }
      
        public DbSet<StpMarginRate> MarginRates { get; set; }
      
        public DbSet<StpOrder> Orders { get; set; }
      
        public DbSet<StpTrade> Trades { get; set; }
      
        public DbSet<StpRiskRule> RiskRules { get; set; }
      
        public DbSet<StpRiskRuleLog> RiskRuleLogs { get; set; }
      
        public DbSet<StpAdminCommand> AdminCommands { get; set; }
      
        public DbSet<StpOperationLog> OperationLogs { get; set; }
      
        public DbSet<StpPosChangeLog> PosChangeLogs { get; set; }
      
        public DbSet<StpActChangeLog> ActChangeLogs { get; set; }
      
    }

    /// <summary>
    /// A factory to create an instance of the StudentsContext 
    /// </summary>
    public static class ContextFactory
    {
        public static TradeContext Create(string connectionString)
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<TradeContext>();
                optionsBuilder.UseSqlite(connectionString);

                // Ensure that the SQLite database and sechema is created!
                var context = new TradeContext(optionsBuilder.Options);
                context.Database.EnsureCreated();

                return context;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }

}
  