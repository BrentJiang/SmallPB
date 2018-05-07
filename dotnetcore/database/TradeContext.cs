
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
            modelBuilder.Entity<StpTradeDate>().HasKey(b => new  {
                b.TradingDay,
            });
        
            /// total 3 key-elements
            modelBuilder.Entity<StpInstrument>().HasKey(b => new  {
                b.ExchangeID,
                b.ProductID,
                b.InstrumentID,
            });
        
            /// total 1 key-elements
            modelBuilder.Entity<StpCompany>().HasKey(b => new  {
                b.CompanyID,
            });
        
            /// total 1 key-elements
            modelBuilder.Entity<StpOperator>().HasKey(b => new  {
                b.OperatorID,
            });
        
            /// total 1 key-elements
            modelBuilder.Entity<StpAuthInfo>().HasKey(b => new  {
                b.AuthID,
            });
        
            /// total 2 key-elements
            modelBuilder.Entity<StpOpAuthInfo>().HasKey(b => new  {
                b.OperatorID,
                b.AuthID,
            });
        
            /// total 1 key-elements
            modelBuilder.Entity<StpIntefAuthInfo>().HasKey(b => new  {
                b.CmdID,
            });
        
            /// total 1 key-elements
            modelBuilder.Entity<StpRole>().HasKey(b => new  {
                b.RoleID,
            });
        
            /// total 2 key-elements
            modelBuilder.Entity<StpRoleAuth>().HasKey(b => new  {
                b.RoleID,
                b.AuthID,
            });
        
            /// total 2 key-elements
            modelBuilder.Entity<StpFileDownload>().HasKey(b => new  {
                b.SysDate,
                b.SysSeqID,
            });
        
            /// total 1 key-elements
            modelBuilder.Entity<StpCmdSequence>().HasKey(b => new  {
                b.SeqName,
            });
        
            /// total 2 key-elements
            modelBuilder.Entity<StpOpMarket>().HasKey(b => new  {
                b.MarketDataType,
                b.OperatorID,
            });
        
            /// total 3 key-elements
            modelBuilder.Entity<StpMarketDataPay>().HasKey(b => new  {
                b.CompanyID,
                b.ExchangeID,
                b.PaySubject,
            });
        
            /// total 1 key-elements
            modelBuilder.Entity<StpMarketDataPayFlow>().HasKey(b => new  {
                b.PayID,
            });
        
            /// total 2 key-elements
            modelBuilder.Entity<StpAccount>().HasKey(b => new  {
                b.AccountID,
                b.TradingDay,
            });
        
            /// total 2 key-elements
            modelBuilder.Entity<StpAccountCombo>().HasKey(b => new  {
                b.ComboID,
                b.TradingDay,
            });
        
            /// total 2 key-elements
            modelBuilder.Entity<StpInvestor>().HasKey(b => new  {
                b.InvestorID,
                b.TradingDay,
            });
        
            /// total 4 key-elements
            modelBuilder.Entity<StpTradingCode>().HasKey(b => new  {
                b.TradingDay,
                b.AccountID,
                b.ExchangeID,
                b.TradingCodeType,
            });
        
            /// total 2 key-elements
            modelBuilder.Entity<StpTradeChannel>().HasKey(b => new  {
                b.ChannelID,
                b.TradingDay,
            });
        
            /// total 3 key-elements
            modelBuilder.Entity<StpAccountAsset>().HasKey(b => new  {
                b.TradingDay,
                b.AccountID,
                b.CurrencyID,
            });
        
            /// total 8 key-elements
            modelBuilder.Entity<StpAccountPosition>().HasKey(b => new  {
                b.AccountID,
                b.ExchangeID,
                b.InstrumentID,
                b.CoveredFlag,
                b.PosiDirection,
                b.TradeCode,
                b.TradingCodeType,
                b.TradingDay,
            });
        
            /// total 9 key-elements
            modelBuilder.Entity<StpComboPosition>().HasKey(b => new  {
                b.AccountID,
                b.ExchangeID,
                b.ComboID,
                b.InstrumentID,
                b.CoveredFlag,
                b.PosiDirection,
                b.TradeCode,
                b.TradingCodeType,
                b.TradingDay,
            });
        
            /// total 5 key-elements
            modelBuilder.Entity<StpDayTradePositionAdjReq>().HasKey(b => new  {
                b.OperatorID,
                b.AccountID,
                b.ExchangeID,
                b.ComboID,
                b.InstrumentID,
            });
        
            /// total 11 key-elements
            modelBuilder.Entity<StpAccountPositionDtl>().HasKey(b => new  {
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
            });
        
            /// total 12 key-elements
            modelBuilder.Entity<StpFeeSet>().HasKey(b => new  {
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
            });
        
            /// total 10 key-elements
            modelBuilder.Entity<StpMarginRate>().HasKey(b => new  {
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
            });
        
            /// total 5 key-elements
            modelBuilder.Entity<StpOrder>().HasKey(b => new  {
                b.TradingDay,
                b.AccountID,
                b.ExchangeID,
                b.SeatID,
                b.OrderLocalID,
            });
        
            /// total 5 key-elements
            modelBuilder.Entity<StpTrade>().HasKey(b => new  {
                b.TradingDay,
                b.AccountID,
                b.ExchangeID,
                b.TradeID,
                b.Direction,
            });
        
            /// total 2 key-elements
            modelBuilder.Entity<StpRiskRule>().HasKey(b => new  {
                b.TradingDay,
                b.RiskId,
            });
        
            /// total 2 key-elements
            modelBuilder.Entity<StpRiskRuleLog>().HasKey(b => new  {
                b.TradingDay,
                b.SequenceNo,
            });
        
            /// total 2 key-elements
            modelBuilder.Entity<StpAdminCommand>().HasKey(b => new  {
                b.TradingDay,
                b.SequenceNo,
            });
        
        }

    
        public DbSet<StpTradeDate> TradeDate { get; set; }
      
        public DbSet<StpInstrument> Instrument { get; set; }
      
        public DbSet<StpCompany> Company { get; set; }
      
        public DbSet<StpOperator> Operator { get; set; }
      
        public DbSet<StpAuthInfo> AuthInfo { get; set; }
      
        public DbSet<StpOpAuthInfo> OpAuthInfo { get; set; }
      
        public DbSet<StpIntefAuthInfo> IntefAuthInfo { get; set; }
      
        public DbSet<StpOpLog> OpLog { get; set; }
      
        public DbSet<StpRole> Role { get; set; }
      
        public DbSet<StpRoleAuth> RoleAuth { get; set; }
      
        public DbSet<StpFileDownload> FileDownload { get; set; }
      
        public DbSet<StpCmdSequence> CmdSequence { get; set; }
      
        public DbSet<StpOpMarket> OpMarket { get; set; }
      
        public DbSet<StpMarketDataPay> MarketDataPay { get; set; }
      
        public DbSet<StpMarketDataPayFlow> MarketDataPayFlow { get; set; }
      
        public DbSet<StpAccount> Account { get; set; }
      
        public DbSet<StpAccountCombo> AccountCombo { get; set; }
      
        public DbSet<StpInvestor> Investor { get; set; }
      
        public DbSet<StpTradingCode> TradingCode { get; set; }
      
        public DbSet<StpTradeChannel> TradeChannel { get; set; }
      
        public DbSet<StpAccountAsset> AccountAsset { get; set; }
      
        public DbSet<StpAccountPosition> AccountPosition { get; set; }
      
        public DbSet<StpComboPosition> ComboPosition { get; set; }
      
        public DbSet<StpDayTradePositionAdjReq> DayTradePositionAdjReq { get; set; }
      
        public DbSet<StpAccountPositionDtl> AccountPositionDtl { get; set; }
      
        public DbSet<StpFeeSet> FeeSet { get; set; }
      
        public DbSet<StpMarginRate> MarginRate { get; set; }
      
        public DbSet<StpOrder> Order { get; set; }
      
        public DbSet<StpTrade> Trade { get; set; }
      
        public DbSet<StpRiskRule> RiskRule { get; set; }
      
        public DbSet<StpRiskRuleLog> RiskRuleLog { get; set; }
      
        public DbSet<StpAdminCommand> AdminCommand { get; set; }
      
        public DbSet<StpOperationLog> OperationLog { get; set; }
      
        public DbSet<StpPosChangeLog> PosChangeLog { get; set; }
      
        public DbSet<StpActChangeLog> ActChangeLog { get; set; }
      
    }


    /// <summary>
    /// A factory to create an instance of the StudentsContext 
    /// </summary>
    /// <remarks>
    /// for MySQL, see https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core.html
    ///  Install-Package MySql.Data.EntityFrameworkCore -Version 8.0.11	
    /// </remarks>
    public static class ContextFactory
    {
        public static TradeContext Create(string connectionString)
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<TradeContext>();
                if (IsMySQLConnectionString(connectionString))
                {
                    optionsBuilder.UseMySQL(connectionString);
                }
                else
                {
                    optionsBuilder.UseSqlite(connectionString);
                }

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

        public static bool IsMySQLConnectionString(string connectionString)
        {
            return connectionString.Contains("server")
                && connectionString.Contains("database")
                && connectionString.Contains("user")
                && connectionString.Contains("password")
                ;
        }

        public static string MakeMySQLConnectionString(string schema, string server)
        {
            return $"server={server};database=pb_{schema};user=trade;password=zij/)Z3sO0;persistsecurityinfo=True;SslMode=none";
        }
	}

}
  