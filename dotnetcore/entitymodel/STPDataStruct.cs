
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPB.entitymodel
{
    ///交易日期
    public class StpTradeDate // struct
    {
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///下一交易日
		//[Column("I2")]
        public Int32 NextTradingDay { get; set; }
        ///系统状态
		//[Column("I3")]
        public char SystemStatus { get; set; }
    };
	
    ///期权合约
    public class StpInstrument // struct
    {
        ///交易所代码
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///产品代码
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
		[StringLength(CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID { get; set; } 
        ///证券代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///证券交易代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTCODE_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTCODE_LEN)]
        public string InstrumentCode { get; set; } 
        ///合约名称
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTNAME_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTNAME_LEN)]
        public string InstrumentName { get; set; } 
        ///证券类别
		//[Column("I6")]
        public char ProductClass { get; set; }
        ///合约数量乘数
		//[Column("I7")]
        public Int32 VolumeMultiple { get; set; }
        ///最小变动价位
		//[Column("I8")]
        public double PriceTick { get; set; }
        ///上市日
		//[Column("I9")]
        public Int32 OpenDate { get; set; }
        ///到期日
		//[Column("I10")]
        public Int32 ExpireDate { get; set; }
        ///当前是否交易
		//[Column("I11")]
        public Int32 IsTrading { get; set; }
        ///期权执行价格
		//[Column("I12")]
        public double ExecPrice { get; set; }
        ///期权单手保证金
		//[Column("I13")]
        public double UnitMargin { get; set; }
        ///交易日
		//[Column("I14")]
        public Int32 TradingDay { get; set; }
        ///行权日
		//[Column("I15")]
        public Int32 ExerciseDay { get; set; }
        ///开始交割日
		//[Column("I16")]
        public Int32 StartDeliveryDay { get; set; }
        ///结束交割日
		//[Column("I17")]
        public Int32 EndDeliveryDay { get; set; }
        ///市价最大下单量
		//[Column("I18")]
        public Int32 MaxMarketOrderVolume { get; set; }
        ///市价最小下单量
		//[Column("I19")]
        public Int32 MinMarketOrderVolume { get; set; }
        ///限价最大下单量
		//[Column("I20")]
        public Int32 MaxLimitOrderVolume { get; set; }
        ///限价最小下单量
		//[Column("I21")]
        public Int32 MinLimitOrderVolume { get; set; }
        ///涨停板价
		//[Column("I22")]
        public double UpperLimitPrice { get; set; }
        ///跌停板价
		//[Column("I23")]
        public double LowerLimitPrice { get; set; }
        ///期权类型
		//[Column("I24")]
        public char OptionType { get; set; }
        ///最小买入变动手数
		//[Column("I25")]
        public Int32 BuyVolumeTick { get; set; }
        ///最小卖出变动手数
		//[Column("I26")]
        public Int32 SellVolumeTick { get; set; }
        ///基础商品代码
		//[Column("I27")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_UNDERLYINGINSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_UNDERLYINGINSTRUMENTID_LEN)]
        public string UnderlyingInstrumentID { get; set; } 
        ///基础商品乘数
		//[Column("I28")]
        public Int32 UnderlyingMultiple { get; set; }
        ///回报证券标志
		//[Column("I29")]
        public char StockRealBack { get; set; }
        ///回报资金标志
		//[Column("I30")]
        public char FundRealBack { get; set; }
    };
	
    ///公司信息
    public class StpCompany // struct
    {
        ///公司编号
		//[Column("I1")]
        public Int32 CompanyID { get; set; }
        ///公司名称
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMPANYNAME_LEN)]
		[StringLength(CommonDef.STP_COMPANYNAME_LEN)]
        public string CompanyName { get; set; } 
        ///公司类型
		//[Column("I3")]
        public char CompanyType { get; set; }
        ///联系人
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LINKMAN_LEN)]
		[StringLength(CommonDef.STP_LINKMAN_LEN)]
        public string LinkMan { get; set; } 
        ///联系地址
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADDRESS_LEN)]
		[StringLength(CommonDef.STP_ADDRESS_LEN)]
        public string Address { get; set; } 
        ///联系电话
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TEL_LEN)]
		[StringLength(CommonDef.STP_TEL_LEN)]
        public string Tel { get; set; } 
        ///电子邮箱
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EMAIL_LEN)]
		[StringLength(CommonDef.STP_EMAIL_LEN)]
        public string Email { get; set; } 
    };
	
    ///公司操作员信息
    public class StpOperator // struct
    {
        ///操作员代码
		//[Column("I1")]
        public Int32 OperatorID { get; set; }
        ///公司编号
		//[Column("I2")]
        public Int32 CompanyID { get; set; }
        ///操作员名称
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPERATORNAME_LEN)]
		[StringLength(CommonDef.STP_OPERATORNAME_LEN)]
        public string OperatorName { get; set; } 
        ///密码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
		[StringLength(CommonDef.STP_PASSWORD_LEN)]
        public string Password { get; set; } 
        ///操作员角色
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPROLES_LEN)]
		[StringLength(CommonDef.STP_OPROLES_LEN)]
        public string OpRoles { get; set; } 
        ///(已废除)操作员可以查询的账户集合
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_QRYACCOUNTIDS_LEN)]
		[StringLength(CommonDef.STP_QRYACCOUNTIDS_LEN)]
        public string QryAccountIDs { get; set; } 
        ///(已废除)操作员可以操作的账户集合
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPACCOUNTIDS_LEN)]
		[StringLength(CommonDef.STP_OPACCOUNTIDS_LEN)]
        public string OpAccountIDs { get; set; } 
        ///操作员可以查询的组合集合
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_QRYCOMBOIDS_LEN)]
		[StringLength(CommonDef.STP_QRYCOMBOIDS_LEN)]
        public string QryComboIDs { get; set; } 
        ///操作员可以操作的组合集合
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPCOMBOIDS_LEN)]
		[StringLength(CommonDef.STP_OPCOMBOIDS_LEN)]
        public string OpComboIDs { get; set; } 
        ///操作员电话
		//[Column("I10")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPTEL_LEN)]
		[StringLength(CommonDef.STP_OPTEL_LEN)]
        public string OpTel { get; set; } 
        ///操作员邮箱
		//[Column("I11")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPEMAIL_LEN)]
		[StringLength(CommonDef.STP_OPEMAIL_LEN)]
        public string OpEmail { get; set; } 
        ///注册时间
		//[Column("I12")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REGIDATE_LEN)]
		[StringLength(CommonDef.STP_REGIDATE_LEN)]
        public string RegiDate { get; set; } 
        ///状态标志
		//[Column("I13")]
        public char EnbFlag { get; set; }
        ///修改时间
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_UPTTIME_LEN)]
		[StringLength(CommonDef.STP_UPTTIME_LEN)]
        public string UptTime { get; set; } 
        ///登录时间
		//[Column("I15")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LOGTIME_LEN)]
		[StringLength(CommonDef.STP_LOGTIME_LEN)]
        public string LogTime { get; set; } 
        ///密码修改时间
		//[Column("I16")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PWDUPTTIME_LEN)]
		[StringLength(CommonDef.STP_PWDUPTTIME_LEN)]
        public string PwdUptTime { get; set; } 
        ///登录错误时间
		//[Column("I17")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LOGERRTIME_LEN)]
		[StringLength(CommonDef.STP_LOGERRTIME_LEN)]
        public string LogErrTime { get; set; } 
        ///密码错误次数
		//[Column("I18")]
        public Int32 PwdErrCnt { get; set; }
        ///备注
		//[Column("I19")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REMARK_LEN)]
		[StringLength(CommonDef.STP_REMARK_LEN)]
        public string Remark { get; set; } 
        ///公司类型
		//[Column("I20")]
        public char CompanyType { get; set; }
    };
	
    ///系统权限信息
    public class StpAuthInfo // struct
    {
        ///权限ID
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
		[StringLength(CommonDef.STP_AUTHID_LEN)]
        public string AuthID { get; set; } 
        ///权限级别
		//[Column("I2")]
        public Int32 AuthLevel { get; set; }
        ///权限描述
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHDESC_LEN)]
		[StringLength(CommonDef.STP_AUTHDESC_LEN)]
        public string AuthDesc { get; set; } 
        ///父权限
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PARENTID_LEN)]
		[StringLength(CommonDef.STP_PARENTID_LEN)]
        public string ParentID { get; set; } 
        ///是否有下级权限
		//[Column("I5")]
        public Int32 HaveSon { get; set; }
        ///顺序号
		//[Column("I6")]
        public Int32 ID { get; set; }
        ///状态标志
		//[Column("I7")]
        public char EnbFlag { get; set; }
        ///缺省状态
		//[Column("I8")]
        public Int32 IsDefault { get; set; }
        ///权限是否作为功能显示在控台
		//[Column("I9")]
        public Int32 IsDisplay { get; set; }
        ///动作
		//[Column("I10")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTION_LEN)]
		[StringLength(CommonDef.STP_ACTION_LEN)]
        public string Action { get; set; } 
        ///保留
		//[Column("I11")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RESV_LEN)]
		[StringLength(CommonDef.STP_RESV_LEN)]
        public string Resv { get; set; } 
        ///创建时间
		//[Column("I12")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CRTTIME_LEN)]
		[StringLength(CommonDef.STP_CRTTIME_LEN)]
        public string CrtTime { get; set; } 
        ///最近一次更新时间
		//[Column("I13")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUPTTIME_LEN)]
		[StringLength(CommonDef.STP_LASTUPTTIME_LEN)]
        public string LastUptTime { get; set; } 
        ///功能类型
		//[Column("I14")]
        public char ActionType { get; set; }
        ///权限类型
		//[Column("I15")]
        public char AuthType { get; set; }
    };
	
    ///操作员权限信息
    public class StpOpAuthInfo // struct
    {
        ///操作员代码
		//[Column("I1")]
        public Int32 OperatorID { get; set; }
        ///权限ID
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
		[StringLength(CommonDef.STP_AUTHID_LEN)]
        public string AuthID { get; set; } 
        ///状态标志
		//[Column("I3")]
        public char EnbFlag { get; set; }
        ///最近一次使用时间
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUSRTIME_LEN)]
		[StringLength(CommonDef.STP_LASTUSRTIME_LEN)]
        public string LastUsrTime { get; set; } 
        ///使用次数
		//[Column("I5")]
        public Int32 UsrCount { get; set; }
        ///保留
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RESV_LEN)]
		[StringLength(CommonDef.STP_RESV_LEN)]
        public string Resv { get; set; } 
        ///创建时间
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CRTTIME_LEN)]
		[StringLength(CommonDef.STP_CRTTIME_LEN)]
        public string CrtTime { get; set; } 
        ///最近一次更新时间
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUPTTIME_LEN)]
		[StringLength(CommonDef.STP_LASTUPTTIME_LEN)]
        public string LastUptTime { get; set; } 
    };
	
    ///接口权限
    public class StpIntefAuthInfo // struct
    {
        ///接口标识
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CMDID_LEN)]
		[StringLength(CommonDef.STP_CMDID_LEN)]
        public string CmdID { get; set; } 
        ///权限ID
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
		[StringLength(CommonDef.STP_AUTHID_LEN)]
        public string AuthID { get; set; } 
    };
	
    ///操作员日志
    public class StpOpLog // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///系统日期
		//[Column("I1")]
        public Int32 SysDate { get; set; }
        ///系统时间
		//[Column("I2")]
        public Int32 SysTime { get; set; }
        ///操作员代码
		//[Column("I3")]
        public Int32 OperatorID { get; set; }
        ///动作
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTION_LEN)]
		[StringLength(CommonDef.STP_ACTION_LEN)]
        public string Action { get; set; } 
        ///动作描述
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTIONDESC_LEN)]
		[StringLength(CommonDef.STP_ACTIONDESC_LEN)]
        public string ActionDesc { get; set; } 
    };
	
    ///角色信息
    public class StpRole // struct
    {
        ///角色号
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLEID_LEN)]
		[StringLength(CommonDef.STP_ROLEID_LEN)]
        public string RoleID { get; set; } 
        ///角色名称
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLENAME_LEN)]
		[StringLength(CommonDef.STP_ROLENAME_LEN)]
        public string RoleName { get; set; } 
        ///公司类型
		//[Column("I3")]
        public char CompanyType { get; set; }
    };
	
    ///角色权限信息
    public class StpRoleAuth // struct
    {
        ///角色号
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLEID_LEN)]
		[StringLength(CommonDef.STP_ROLEID_LEN)]
        public string RoleID { get; set; } 
        ///权限ID
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
		[StringLength(CommonDef.STP_AUTHID_LEN)]
        public string AuthID { get; set; } 
    };
	
    ///下载文件列表
    public class StpFileDownload // struct
    {
        ///系统日期
		//[Column("I1")]
        public Int32 SysDate { get; set; }
        ///系统流水
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSSEQID_LEN)]
		[StringLength(CommonDef.STP_SYSSEQID_LEN)]
        public string SysSeqID { get; set; } 
        ///操作员代码
		//[Column("I3")]
        public Int32 OperatorID { get; set; }
        ///文件名称
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILENAME_LEN)]
		[StringLength(CommonDef.STP_FILENAME_LEN)]
        public string FileName { get; set; } 
        ///文件存储路径
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEURL_LEN)]
		[StringLength(CommonDef.STP_FILEURL_LEN)]
        public string FileUrl { get; set; } 
        ///文件查询条件
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEINFO_LEN)]
		[StringLength(CommonDef.STP_FILEINFO_LEN)]
        public string FileInfo { get; set; } 
        ///请求执行状态
		//[Column("I7")]
        public char FileFlag { get; set; }
        ///后缀文件类型
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEPOSTFIX_LEN)]
		[StringLength(CommonDef.STP_FILEPOSTFIX_LEN)]
        public string FilePostFix { get; set; } 
        ///文件生成日期
		//[Column("I9")]
        public Int32 CreateDate { get; set; }
        ///文件生成时间
		//[Column("I10")]
        public Int32 CreateTime { get; set; }
        ///更新日期
		//[Column("I11")]
        public Int32 UpdateDate { get; set; }
        ///最后修改时间
		//[Column("I12")]
        public Int32 UpdateTime { get; set; }
    };
	
    ///控台序列表
    public class StpCmdSequence // struct
    {
        ///序列名称
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEQNAME_LEN)]
		[StringLength(CommonDef.STP_SEQNAME_LEN)]
        public string SeqName { get; set; } 
        ///当前序列值
		//[Column("I2")]
        public Int32 CurrentVal { get; set; }
        ///当前增长值
		//[Column("I3")]
        public Int32 IncrementVal { get; set; }
    };
	
    ///操作员行情配置信息
    public class StpOpMarket // struct
    {
        ///公司编号
		//[Column("I1")]
        public Int32 CompanyID { get; set; }
        ///行情配置类型
		//[Column("I2")]
        public char MarketDataType { get; set; }
        ///操作员代码
		//[Column("I3")]
        public Int32 OperatorID { get; set; }
        ///允许连接个数
		//[Column("I4")]
        public Int32 LimitConNum { get; set; }
        ///允许订阅个数
		//[Column("I5")]
        public Int32 LimitSubNum { get; set; }
        ///连接IP地址白名单
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_IPADDRESS_LEN)]
		[StringLength(CommonDef.STP_IPADDRESS_LEN)]
        public string IpAddress { get; set; } 
    };
	
    ///公司行情缴费信息
    public class StpMarketDataPay // struct
    {
        ///公司编号
		//[Column("I1")]
        public Int32 CompanyID { get; set; }
        ///交易所代码
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///缴费科目
		//[Column("I3")]
        public char PaySubject { get; set; }
        ///最近缴费时间
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTPAYTIME_LEN)]
		[StringLength(CommonDef.STP_LASTPAYTIME_LEN)]
        public string LastPayTime { get; set; } 
        ///缴费金额
		//[Column("I5")]
        public double PayBalance { get; set; }
        ///起始日期
		//[Column("I6")]
        public Int32 StartDate { get; set; }
        ///到期日期
		//[Column("I7")]
        public Int32 EndDate { get; set; }
    };
	
    ///公司行情缴费流水
    public class StpMarketDataPayFlow // struct
    {
        ///流水序号
		//[Column("I1")]
        public Int32 PayID { get; set; }
        ///公司编号
		//[Column("I2")]
        public Int32 CompanyID { get; set; }
        ///交易所代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///缴费科目
		//[Column("I4")]
        public char PaySubject { get; set; }
        ///缴费时间
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PAYTIME_LEN)]
		[StringLength(CommonDef.STP_PAYTIME_LEN)]
        public string PayTime { get; set; } 
        ///缴费金额
		//[Column("I6")]
        public double PayBalance { get; set; }
        ///起始日期
		//[Column("I7")]
        public Int32 StartDate { get; set; }
        ///到期日期
		//[Column("I8")]
        public Int32 EndDate { get; set; }
    };
	
    ///账户信息
    public class StpAccount // struct
    {
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///公司编号
		//[Column("I2")]
        public Int32 CompanyID { get; set; }
        ///资金账户名称
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
		[StringLength(CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName { get; set; } 
        ///投资者代码
		//[Column("I4")]
        public Int32 InvestorID { get; set; }
        ///账户类型
		//[Column("I5")]
        public char AccountType { get; set; }
        ///状态标志
		//[Column("I6")]
        public char EnbFlag { get; set; }
        ///交易日
		//[Column("I7")]
        public Int32 TradingDay { get; set; }
        ///交易通道编号
		//[Column("I8")]
        public Int32 ChannelID { get; set; }
        ///默认组合
		//[Column("I9")]
        public Int32 DefaultCombo { get; set; }
    };
	
    ///投资组合
    public class StpAccountCombo // struct
    {
        ///组合编号
		//[Column("I1")]
        public Int32 ComboID { get; set; }
        ///账户编号
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///组合名称
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBONAME_LEN)]
		[StringLength(CommonDef.STP_COMBONAME_LEN)]
        public string ComboName { get; set; } 
        ///交易所代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///投资组合对应的合约代码
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_KEYINSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_KEYINSTRUMENTID_LEN)]
        public string KeyInstrumentID { get; set; } 
        ///是否活跃
		//[Column("I6")]
        public Int32 IsActive { get; set; }
        ///缺省状态
		//[Column("I7")]
        public Int32 IsDefault { get; set; }
        ///交易日
		//[Column("I8")]
        public Int32 TradingDay { get; set; }
        ///允许日内交易
		//[Column("I9")]
        public byte DayTradeEnable { get; set; }
    };
	
    ///投资者信息
    public class StpInvestor // struct
    {
        ///投资者代码
		//[Column("I1")]
        public Int32 InvestorID { get; set; }
        ///交易日
		//[Column("I2")]
        public Int32 TradingDay { get; set; }
        ///经纪公司代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BROKERID_LEN)]
		[StringLength(CommonDef.STP_BROKERID_LEN)]
        public string BrokerID { get; set; } 
        ///母账户代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BROKERINVESTORID_LEN)]
		[StringLength(CommonDef.STP_BROKERINVESTORID_LEN)]
        public string BrokerInvestorID { get; set; } 
        ///用户代码
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_USERID_LEN)]
		[StringLength(CommonDef.STP_USERID_LEN)]
        public string UserID { get; set; } 
        ///客户号
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CLIENTID_LEN)]
		[StringLength(CommonDef.STP_CLIENTID_LEN)]
        public string ClientID { get; set; } 
        ///资金账户代码
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTCODE_LEN)]
		[StringLength(CommonDef.STP_ACCOUNTCODE_LEN)]
        public string AccountCode { get; set; } 
        ///密码
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
		[StringLength(CommonDef.STP_PASSWORD_LEN)]
        public string Password { get; set; } 
        ///投资者名称
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INVESTORNAME_LEN)]
		[StringLength(CommonDef.STP_INVESTORNAME_LEN)]
        public string InvestorName { get; set; } 
        ///投资者类型
		//[Column("I10")]
        public char InvestorType { get; set; }
        ///证件类型
		//[Column("I11")]
        public char IDCardType { get; set; }
        ///证件号
		//[Column("I12")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_IDCARDNO_LEN)]
		[StringLength(CommonDef.STP_IDCARDNO_LEN)]
        public string IDCardNo { get; set; } 
        ///是否活跃
		//[Column("I13")]
        public Int32 IsActive { get; set; }
        ///分组编号
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_GROUPID_LEN)]
		[StringLength(CommonDef.STP_GROUPID_LEN)]
        public string GroupID { get; set; } 
        ///O32操作员代码
		//[Column("I15")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32OPERATORNO_LEN)]
		[StringLength(CommonDef.STP_O32OPERATORNO_LEN)]
        public string O32OperatorNo { get; set; } 
        ///O32操作员密码
		//[Column("I16")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32OPERATORPWD_LEN)]
		[StringLength(CommonDef.STP_O32OPERATORPWD_LEN)]
        public string O32OperatorPwd { get; set; } 
        ///O32基金代码
		//[Column("I17")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32ACCOUNTCODE_LEN)]
		[StringLength(CommonDef.STP_O32ACCOUNTCODE_LEN)]
        public string O32AccountCode { get; set; } 
        ///O32组合编号
		//[Column("I18")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32COMBINO_LEN)]
		[StringLength(CommonDef.STP_O32COMBINO_LEN)]
        public string O32CombiNo { get; set; } 
        ///O32资产单元编号
		//[Column("I19")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32ASSETNO_LEN)]
		[StringLength(CommonDef.STP_O32ASSETNO_LEN)]
        public string O32AssetNo { get; set; } 
    };
	
    ///投资者交易编码
    public class StpTradingCode // struct
    {
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///账户编号
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///交易所代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///交易编码类型
		//[Column("I4")]
        public char TradingCodeType { get; set; }
        ///交易编码
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
		[StringLength(CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///营业部代码
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
		[StringLength(CommonDef.STP_BRANCHID_LEN)]
        public string BranchID { get; set; } 
        ///席位号
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
		[StringLength(CommonDef.STP_SEATID_LEN)]
        public string SeatID { get; set; } 
        ///投资者账户子编码
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPTCLIENTID_LEN)]
		[StringLength(CommonDef.STP_OPTCLIENTID_LEN)]
        public string OptClientID { get; set; } 
        ///是否活跃
		//[Column("I9")]
        public Int32 IsActive { get; set; }
    };
	
    ///交易通道信息
    public class StpTradeChannel // struct
    {
        ///交易通道编号
		//[Column("I1")]
        public Int32 ChannelID { get; set; }
        ///通道名称
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CHANNELNAME_LEN)]
		[StringLength(CommonDef.STP_CHANNELNAME_LEN)]
        public string ChannelName { get; set; } 
        ///通道类型
		//[Column("I3")]
        public char ChannelType { get; set; }
        ///分仓接口IP
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSIP_LEN)]
		[StringLength(CommonDef.STP_SYSIP_LEN)]
        public string SysIP { get; set; } 
        ///分仓接口端口
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSPORT_LEN)]
		[StringLength(CommonDef.STP_SYSPORT_LEN)]
        public string SysPort { get; set; } 
        ///分仓其他配置
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CHANNELCONFIG_LEN)]
		[StringLength(CommonDef.STP_CHANNELCONFIG_LEN)]
        public string ChannelConfig { get; set; } 
        ///交易日
		//[Column("I7")]
        public Int32 TradingDay { get; set; }
    };
	
    ///账户资金信息
    public class StpAccountAsset // struct
    {
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///账户编号
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///币种代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CURRENCYID_LEN)]
		[StringLength(CommonDef.STP_CURRENCYID_LEN)]
        public string CurrencyID { get; set; } 
        ///上次存款额
		//[Column("I4")]
        public double PreDeposit { get; set; }
        ///上次占用的保证金
		//[Column("I5")]
        public double PreMargin { get; set; }
        ///上次结算准备金
		//[Column("I6")]
        public double PreBalance { get; set; }
        ///当前资金
		//[Column("I7")]
        public double Balance { get; set; }
        ///入金金额
		//[Column("I8")]
        public double Deposit { get; set; }
        ///冻结的保证金
		//[Column("I9")]
        public double FrozenMargin { get; set; }
        ///冻结的手续费
		//[Column("I10")]
        public double FrozenCommission { get; set; }
        ///冻结的资金
		//[Column("I11")]
        public double FrozenCash { get; set; }
        ///手工冻结的资金
		//[Column("I12")]
        public double ManualFrozenCash { get; set; }
        ///核对调整资金
		//[Column("I13")]
        public double CheckCash { get; set; }
        ///仓位占用保证金
		//[Column("I14")]
        public double UseMargin { get; set; }
        ///手续费
		//[Column("I15")]
        public double Commission { get; set; }
        ///可取资金
		//[Column("I16")]
        public double WithdrawQuota { get; set; }
        ///保证金可用余额
		//[Column("I17")]
        public double Credit { get; set; }
        ///现金
		//[Column("I18")]
        public double Available { get; set; }
        ///平仓盈亏
		//[Column("I19")]
        public double CloseProfit { get; set; }
        ///持仓盈亏
		//[Column("I20")]
        public double PositionProfit { get; set; }
        ///资金差额
		//[Column("I21")]
        public double CashIn { get; set; }
        ///出金金额
		//[Column("I22")]
        public double CashOut { get; set; }
        ///缺省状态
		//[Column("I23")]
        public Int32 IsDefault { get; set; }
    };
	
    ///查询账户资金信息
    public class StpUserAccountAsset // struct
    {
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///资金账户名称
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
		[StringLength(CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName { get; set; } 
        ///当前资金
		//[Column("I3")]
        public double Balance { get; set; }
        ///可用资金
		//[Column("I4")]
        public double EnableBalance { get; set; }
        ///冻结的资金
		//[Column("I5")]
        public double FrozenCash { get; set; }
        ///手工冻结的资金
		//[Column("I6")]
        public double ManualFrozenCash { get; set; }
        ///核对调整资金
		//[Column("I7")]
        public double CheckCash { get; set; }
    };
	
    ///账户持仓信息
    public class StpAccountPosition // struct
    {
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///交易所代码
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///证券代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///备兑标志
		//[Column("I4")]
        public char CoveredFlag { get; set; }
        ///持仓多空方向
		//[Column("I5")]
        public char PosiDirection { get; set; }
        ///交易编码
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
		[StringLength(CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///交易编码类型
		//[Column("I7")]
        public char TradingCodeType { get; set; }
        ///交易日
		//[Column("I8")]
        public Int32 TradingDay { get; set; }
        ///上日持仓
		//[Column("I9")]
        public double YdPosition { get; set; }
        ///上次占用的保证金
		//[Column("I10")]
        public double PreMargin { get; set; }
        ///今持仓
		//[Column("I11")]
        public double TodayPosition { get; set; }
        ///总持仓
		//[Column("I12")]
        public double TotalPosition { get; set; }
        ///仓位占用保证金
		//[Column("I13")]
        public double UseMargin { get; set; }
        ///开仓量
		//[Column("I14")]
        public double OpenVolume { get; set; }
        ///平仓量
		//[Column("I15")]
        public double CloseVolume { get; set; }
        ///平昨仓量
		//[Column("I16")]
        public double CloseYdVolume { get; set; }
        ///本次结算价
		//[Column("I17")]
        public double SettlementPrice { get; set; }
        ///上次结算价
		//[Column("I18")]
        public double PreSettlementPrice { get; set; }
        ///手续费
		//[Column("I19")]
        public double Commission { get; set; }
        ///冻结的手续费
		//[Column("I20")]
        public double FrozenCommission { get; set; }
        ///冻结的保证金
		//[Column("I21")]
        public double FrozenMargin { get; set; }
        ///开仓成本
		//[Column("I22")]
        public double OpenCost { get; set; }
        ///持仓成本
		//[Column("I23")]
        public double PositionCost { get; set; }
        ///平仓盈亏
		//[Column("I24")]
        public double CloseProfit { get; set; }
        ///持仓盈亏
		//[Column("I25")]
        public double PositionProfit { get; set; }
        ///开仓金额
		//[Column("I26")]
        public double OpenAmount { get; set; }
        ///平仓金额
		//[Column("I27")]
        public double CloseAmount { get; set; }
        ///平昨仓金额
		//[Column("I28")]
        public double CloseYdAmount { get; set; }
        ///多头冻结
		//[Column("I29")]
        public double LongFrozen { get; set; }
        ///开仓冻结金额
		//[Column("I30")]
        public double LongFrozenAmount { get; set; }
        ///空头冻结
		//[Column("I31")]
        public double ShortFrozen { get; set; }
        ///开仓冻结金额
		//[Column("I32")]
        public double ShortFrozenAmount { get; set; }
        ///冻结数量
		//[Column("I33")]
        public double FrozenVolume { get; set; }
        ///手工冻结数量
		//[Column("I34")]
        public double ManualFrozenVolume { get; set; }
        ///核对调整数量
		//[Column("I35")]
        public double CheckVolume { get; set; }
        ///可用数量
		//[Column("I36")]
        public double EnableVolume { get; set; }
    };
	
    ///查询组合持仓信息
    public class StpUserComboPosition // struct
    {
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///资金账户名称
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
		[StringLength(CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName { get; set; } 
        ///组合编号
		//[Column("I3")]
        public Int32 ComboID { get; set; }
        ///组合名称
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBONAME_LEN)]
		[StringLength(CommonDef.STP_COMBONAME_LEN)]
        public string ComboName { get; set; } 
        ///交易所代码
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///证券代码
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///合约名称
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTNAME_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTNAME_LEN)]
        public string InstrumentName { get; set; } 
        ///总持仓
		//[Column("I8")]
        public double TotalPosition { get; set; }
        ///冻结数量
		//[Column("I9")]
        public double FrozenVolume { get; set; }
        ///手工冻结数量
		//[Column("I10")]
        public double ManualFrozenVolume { get; set; }
        ///核对调整数量
		//[Column("I11")]
        public double CheckVolume { get; set; }
        ///可用数量
		//[Column("I12")]
        public double EnableVolume { get; set; }
        ///持仓成本
		//[Column("I13")]
        public double PositionCost { get; set; }
        ///成本价
		//[Column("I14")]
        public double CostPrice { get; set; }
        ///最新价
		//[Column("I15")]
        public double LastPrice { get; set; }
        ///持仓市值
		//[Column("I16")]
        public double OpenMarketValue { get; set; }
        ///浮动盈亏
		//[Column("I17")]
        public double FloatProfi { get; set; }
        ///多头冻结
		//[Column("I18")]
        public double LongFrozen { get; set; }
        ///空头冻结
		//[Column("I19")]
        public double ShortFrozen { get; set; }
        ///日内初始数量
		//[Column("I20")]
        public Int32 DayTradeInitVolume { get; set; }
        ///日内可用数量
		//[Column("I21")]
        public Int32 DayTradeAvailVolume { get; set; }
        ///浮动盈亏
		//[Column("I22")]
        public double DayTradeFloatProfitLoss { get; set; }
        ///日内持仓成本价
		//[Column("I23")]
        public double DayTradePositionCost { get; set; }
        ///日内平仓盈亏
		//[Column("I24")]
        public double DayTradeCloseProfit { get; set; }
        ///日内累买
		//[Column("I25")]
        public double DayTradeAccumBuy { get; set; }
        ///日内累卖
		//[Column("I26")]
        public double DayTradeAccumSell { get; set; }
    };
	
    ///组合持仓信息
    public class StpComboPosition // struct
    {
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///交易所代码
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///组合编号
		//[Column("I3")]
        public Int32 ComboID { get; set; }
        ///证券代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///备兑标志
		//[Column("I5")]
        public char CoveredFlag { get; set; }
        ///持仓多空方向
		//[Column("I6")]
        public char PosiDirection { get; set; }
        ///交易编码
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
		[StringLength(CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///交易编码类型
		//[Column("I8")]
        public char TradingCodeType { get; set; }
        ///交易日
		//[Column("I9")]
        public Int32 TradingDay { get; set; }
        ///上日持仓
		//[Column("I10")]
        public double YdPosition { get; set; }
        ///上次占用的保证金
		//[Column("I11")]
        public double PreMargin { get; set; }
        ///今持仓
		//[Column("I12")]
        public double TodayPosition { get; set; }
        ///总持仓
		//[Column("I13")]
        public double TotalPosition { get; set; }
        ///仓位占用保证金
		//[Column("I14")]
        public double UseMargin { get; set; }
        ///开仓量
		//[Column("I15")]
        public double OpenVolume { get; set; }
        ///平仓量
		//[Column("I16")]
        public double CloseVolume { get; set; }
        ///平昨仓量
		//[Column("I17")]
        public double CloseYdVolume { get; set; }
        ///本次结算价
		//[Column("I18")]
        public double SettlementPrice { get; set; }
        ///上次结算价
		//[Column("I19")]
        public double PreSettlementPrice { get; set; }
        ///手续费
		//[Column("I20")]
        public double Commission { get; set; }
        ///冻结的手续费
		//[Column("I21")]
        public double FrozenCommission { get; set; }
        ///冻结的保证金
		//[Column("I22")]
        public double FrozenMargin { get; set; }
        ///开仓成本
		//[Column("I23")]
        public double OpenCost { get; set; }
        ///持仓成本
		//[Column("I24")]
        public double PositionCost { get; set; }
        ///平仓盈亏
		//[Column("I25")]
        public double CloseProfit { get; set; }
        ///持仓盈亏
		//[Column("I26")]
        public double PositionProfit { get; set; }
        ///开仓金额
		//[Column("I27")]
        public double OpenAmount { get; set; }
        ///平仓金额
		//[Column("I28")]
        public double CloseAmount { get; set; }
        ///平昨仓金额
		//[Column("I29")]
        public double CloseYdAmount { get; set; }
        ///多头冻结
		//[Column("I30")]
        public double LongFrozen { get; set; }
        ///开仓冻结金额
		//[Column("I31")]
        public double LongFrozenAmount { get; set; }
        ///空头冻结
		//[Column("I32")]
        public double ShortFrozen { get; set; }
        ///开仓冻结金额
		//[Column("I33")]
        public double ShortFrozenAmount { get; set; }
        ///冻结数量
		//[Column("I34")]
        public double FrozenVolume { get; set; }
        ///手工冻结数量
		//[Column("I35")]
        public double ManualFrozenVolume { get; set; }
        ///核对调整数量
		//[Column("I36")]
        public double CheckVolume { get; set; }
        ///可用数量
		//[Column("I37")]
        public double EnableVolume { get; set; }
        ///日内初始数量
		//[Column("I38")]
        public Int32 DayTradeInitVolume { get; set; }
        ///日内可用数量
		//[Column("I39")]
        public Int32 DayTradeAvailVolume { get; set; }
        ///浮动盈亏
		//[Column("I40")]
        public double DayTradeFloatProfitLoss { get; set; }
        ///日内持仓成本价
		//[Column("I41")]
        public double DayTradePositionCost { get; set; }
        ///日内平仓盈亏
		//[Column("I42")]
        public double DayTradeCloseProfit { get; set; }
        ///日内累买
		//[Column("I43")]
        public double DayTradeAccumBuy { get; set; }
        ///日内累卖
		//[Column("I44")]
        public double DayTradeAccumSell { get; set; }
    };
	
    ///日内持仓调整
    public class StpDayTradePositionAdjReq // struct
    {
        ///操作员代码
		//[Column("I1")]
        public Int32 OperatorID { get; set; }
        ///账户编号
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///交易所代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///组合编号
		//[Column("I4")]
        public Int32 ComboID { get; set; }
        ///证券代码
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///日内调仓数量
		//[Column("I6")]
        public Int32 DayTradePositionAdjAmount { get; set; }
        ///日内调仓价格
		//[Column("I7")]
        public double DayTradePositionAdjCost { get; set; }
        ///操作信息
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPERATEMSG_LEN)]
		[StringLength(CommonDef.STP_OPERATEMSG_LEN)]
        public string OperateMsg { get; set; } 
    };
	
    ///账户持仓明细
    public class StpAccountPositionDtl // struct
    {
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///交易所代码
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///组合编号
		//[Column("I3")]
        public Int32 ComboID { get; set; }
        ///证券代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///备兑标志
		//[Column("I5")]
        public char CoveredFlag { get; set; }
        ///持仓多空方向
		//[Column("I6")]
        public char PosiDirection { get; set; }
        ///上市日
		//[Column("I7")]
        public Int32 OpenDate { get; set; }
        ///成交编号
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
		[StringLength(CommonDef.STP_TRADEID_LEN)]
        public string TradeID { get; set; } 
        ///交易编码
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
		[StringLength(CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///交易编码类型
		//[Column("I10")]
        public char TradingCodeType { get; set; }
        ///交易日
		//[Column("I11")]
        public Int32 TradingDay { get; set; }
        ///成交量
		//[Column("I12")]
        public Int32 Volume { get; set; }
        ///本次结算价
		//[Column("I13")]
        public double SettlementPrice { get; set; }
        ///上次结算价
		//[Column("I14")]
        public double PreSettlementPrice { get; set; }
        ///今开盘
		//[Column("I15")]
        public double OpenPrice { get; set; }
        ///投资者保证金
		//[Column("I16")]
        public double Margin { get; set; }
        ///投资者保证金率
		//[Column("I17")]
        public double MarginRate { get; set; }
        ///平仓量
		//[Column("I18")]
        public double CloseVolume { get; set; }
        ///平仓金额
		//[Column("I19")]
        public double CloseAmount { get; set; }
    };
	
    ///费用设置信息
    public class StpFeeSet // struct
    {
        ///公司编号
		//[Column("I1")]
        public Int32 CompanyID { get; set; }
        ///账户编号
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///交易所代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///证券代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///证券类别
		//[Column("I5")]
        public char ProductClass { get; set; }
        ///产品代码
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
		[StringLength(CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID { get; set; } 
        ///买卖方向
		//[Column("I7")]
        public char Direction { get; set; }
        ///开平标志
		//[Column("I8")]
        public char OffsetFlag { get; set; }
        ///备兑标志
		//[Column("I9")]
        public char CoveredFlag { get; set; }
        ///投机套保标志
		//[Column("I10")]
        public char HedgeFlag { get; set; }
        ///费用类别
		//[Column("I11")]
        public char FeeType { get; set; }
        ///费用按成交金额比例
		//[Column("I12")]
        public double BalanceRatio { get; set; }
        ///费用按成交面值比例
		//[Column("I13")]
        public double FaceValueRatio { get; set; }
        ///费用按成交数量比例
		//[Column("I14")]
        public double AmountRatio { get; set; }
        ///最高收费
		//[Column("I15")]
        public double MaxFee { get; set; }
        ///最低收费
		//[Column("I16")]
        public double MinFee { get; set; }
        ///费用计算模式
		//[Column("I17")]
        public char CalculateType { get; set; }
        ///交易日
		//[Column("I18")]
        public Int32 TradingDay { get; set; }
    };
	
    ///保证金率
    public class StpMarginRate // struct
    {
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///账户编号
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///投资者范围
		//[Column("I3")]
        public char InvestorRange { get; set; }
        ///交易所代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///证券代码
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///备兑标志
		//[Column("I6")]
        public char CoveredFlag { get; set; }
        ///投机套保标志
		//[Column("I7")]
        public char HedgeFlag { get; set; }
        ///期权类型
		//[Column("I8")]
        public char OptionType { get; set; }
        ///证券类别
		//[Column("I9")]
        public char ProductClass { get; set; }
        ///产品代码
		//[Column("I10")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
		[StringLength(CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID { get; set; } 
        ///多头保证金率
		//[Column("I11")]
        public double LongMarginRatioByMoney { get; set; }
        ///多头保证金费
		//[Column("I12")]
        public double LongMarginRatioByVolume { get; set; }
        ///空头保证金率
		//[Column("I13")]
        public double ShortMarginRatioByMoney { get; set; }
        ///空头保证金费
		//[Column("I14")]
        public double ShortMarginRatioByVolume { get; set; }
        ///是否按比例上浮
		//[Column("I15")]
        public Int32 IsFloat { get; set; }
    };
	
    ///报单
    public class StpOrder // struct
    {
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///账户编号
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///组合编号
		//[Column("I3")]
        public Int32 ComboID { get; set; }
        ///会话编号
		//[Column("I4")]
        public Int32 SessionID { get; set; }
        ///前置编号
		//[Column("I5")]
        public Int32 FrontID { get; set; }
        ///报单引用
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
		[StringLength(CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef { get; set; } 
        ///交易所代码
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///席位号
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
		[StringLength(CommonDef.STP_SEATID_LEN)]
        public string SeatID { get; set; } 
        ///本地报单编号
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
		[StringLength(CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
        ///买卖方向
		//[Column("I10")]
        public char Direction { get; set; }
        ///操作员代码
		//[Column("I11")]
        public Int32 OperatorID { get; set; }
        ///交易编码
		//[Column("I12")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
		[StringLength(CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///营业部代码
		//[Column("I13")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
		[StringLength(CommonDef.STP_BRANCHID_LEN)]
        public string BranchID { get; set; } 
        ///证券代码
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///报单价格条件
		//[Column("I15")]
        public char OrderPriceType { get; set; }
        ///开平标志
		//[Column("I16")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBOFFSETFLAG_LEN)]
		[StringLength(CommonDef.STP_COMBOFFSETFLAG_LEN)]
        public string CombOffsetFlag { get; set; } 
        ///投机套保标志
		//[Column("I17")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBHEDGEFLAG_LEN)]
		[StringLength(CommonDef.STP_COMBHEDGEFLAG_LEN)]
        public string CombHedgeFlag { get; set; } 
        ///备兑标志
		//[Column("I18")]
        public char CoveredFlag { get; set; }
        ///价格
		//[Column("I19")]
        public double LimitPrice { get; set; }
        ///原始数量
		//[Column("I20")]
        public Int32 VolumeTotalOriginal { get; set; }
        ///有效期类型
		//[Column("I21")]
        public char TimeCondition { get; set; }
        ///成交量类型
		//[Column("I22")]
        public char VolumeCondition { get; set; }
        ///最小成交量
		//[Column("I23")]
        public Int32 MinVolume { get; set; }
        ///触发条件
		//[Column("I24")]
        public char ContingentCondition { get; set; }
        ///止损价
		//[Column("I25")]
        public double StopPrice { get; set; }
        ///请求编号
		//[Column("I26")]
        public Int32 ORRequestID { get; set; }
        ///报单编号
		//[Column("I27")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERSYSID_LEN)]
		[StringLength(CommonDef.STP_ORDERSYSID_LEN)]
        public string OrderSysID { get; set; } 
        ///报单状态
		//[Column("I28")]
        public char OrderStatus { get; set; }
        ///报单类型
		//[Column("I29")]
        public char OrderType { get; set; }
        ///今成交数量
		//[Column("I30")]
        public Int32 VolumeTraded { get; set; }
        ///今成交金额
		//[Column("I31")]
        public double AmountTraded { get; set; }
        ///剩余数量
		//[Column("I32")]
        public Int32 VolumeRemain { get; set; }
        ///报单日期
		//[Column("I33")]
        public Int32 InsertDate { get; set; }
        ///委托时间
		//[Column("I34")]
        public Int32 InsertTime { get; set; }
        ///最后修改时间
		//[Column("I35")]
        public Int32 UpdateTime { get; set; }
        ///撤销时间
		//[Column("I36")]
        public Int32 CancelTime { get; set; }
        ///被撤单引用
		//[Column("I37")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERACTIONREF_LEN)]
		[StringLength(CommonDef.STP_ORDERACTIONREF_LEN)]
        public string OrderActionRef { get; set; } 
        ///状态信息
		//[Column("I38")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_STATUSMSG_LEN)]
		[StringLength(CommonDef.STP_STATUSMSG_LEN)]
        public string StatusMsg { get; set; } 
        ///发起标志
		//[Column("I39")]
        public char OwnerType { get; set; }
        ///预留字段1
		//[Column("I40")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF1_LEN)]
		[StringLength(CommonDef.STP_THIRDREFF1_LEN)]
        public string ThirdReff1 { get; set; } 
        ///预留字段2
		//[Column("I41")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF2_LEN)]
		[StringLength(CommonDef.STP_THIRDREFF2_LEN)]
        public string ThirdReff2 { get; set; } 
        ///撤成\废单数量
		//[Column("I42")]
        public Int32 VolumeCanceled { get; set; }
        ///备注
		//[Column("I43")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REMARK_LEN)]
		[StringLength(CommonDef.STP_REMARK_LEN)]
        public string Remark { get; set; } 
        ///撤单标志
		//[Column("I44")]
        public char CancelFlag { get; set; }
        ///订单IP
		//[Column("I45")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
		[StringLength(CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP { get; set; } 
        ///订单MAC
		//[Column("I46")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
		[StringLength(CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC { get; set; } 
        ///订单硬盘序列号
		//[Column("I47")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
		[StringLength(CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum { get; set; } 
        ///订单机器码
		//[Column("I48")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
		[StringLength(CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode { get; set; } 
        ///订单操作系统
		//[Column("I49")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
		[StringLength(CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS { get; set; } 
        ///当前资金
		//[Column("I50")]
        public double Balance { get; set; }
        ///手续费
		//[Column("I51")]
        public double Commission { get; set; }
    };
	
    ///成交
    public class StpTrade // struct
    {
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///账户编号
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///组合编号
		//[Column("I3")]
        public Int32 ComboID { get; set; }
        ///交易所代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///成交编号
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
		[StringLength(CommonDef.STP_TRADEID_LEN)]
        public string TradeID { get; set; } 
        ///买卖方向
		//[Column("I6")]
        public char Direction { get; set; }
        ///交易编码
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
		[StringLength(CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///席位号
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
		[StringLength(CommonDef.STP_SEATID_LEN)]
        public string SeatID { get; set; } 
        ///营业部代码
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
		[StringLength(CommonDef.STP_BRANCHID_LEN)]
        public string BranchID { get; set; } 
        ///证券交易代码
		//[Column("I10")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTCODE_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTCODE_LEN)]
        public string InstrumentCode { get; set; } 
        ///证券代码
		//[Column("I11")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///操作员代码
		//[Column("I12")]
        public Int32 OperatorID { get; set; }
        ///请求编号
		//[Column("I13")]
        public Int32 ORRequestID { get; set; }
        ///报单编号
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERSYSID_LEN)]
		[StringLength(CommonDef.STP_ORDERSYSID_LEN)]
        public string OrderSysID { get; set; } 
        ///本地报单编号
		//[Column("I15")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
		[StringLength(CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
        ///报单引用
		//[Column("I16")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
		[StringLength(CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef { get; set; } 
        ///开平标志
		//[Column("I17")]
        public char OffsetFlag { get; set; }
        ///备兑标志
		//[Column("I18")]
        public char CoveredFlag { get; set; }
        ///投机套保标志
		//[Column("I19")]
        public char HedgeFlag { get; set; }
        ///价格
		//[Column("I20")]
        public double Price { get; set; }
        ///成交量
		//[Column("I21")]
        public Int32 Volume { get; set; }
        ///成交金额
		//[Column("I22")]
        public double TradeAmount { get; set; }
        ///成交时期
		//[Column("I23")]
        public Int32 TradeDate { get; set; }
        ///成交时间
		//[Column("I24")]
        public Int32 TradeTime { get; set; }
        ///手续费
		//[Column("I25")]
        public double Commission { get; set; }
        ///序号
		//[Column("I26")]
        public Int32 SequenceNo { get; set; }
        ///发起标志
		//[Column("I27")]
        public char OwnerType { get; set; }
    };
	
    ///风控规则
    public class StpRiskRule // struct
    {
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///规则ID
		//[Column("I2")]
        public Int32 RiskId { get; set; }
        ///规则代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
		[StringLength(CommonDef.STP_RULECODE_LEN)]
        public string RuleCode { get; set; } 
        ///公司编号
		//[Column("I4")]
        public Int32 CompanyID { get; set; }
        ///交易所代码
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///证券代码集合
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTIDS_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTIDS_LEN)]
        public string InstrumentIDs { get; set; } 
        ///证券控制层级
		//[Column("I7")]
        public char InstrumentControlLevel { get; set; }
        ///证券范围
		//[Column("I8")]
        public char InstrumentRangeType { get; set; }
        ///证券联合风控
		//[Column("I9")]
        public byte InstrumentUnionFlag { get; set; }
        ///账户集合
		//[Column("I10")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTIDS_LEN)]
		[StringLength(CommonDef.STP_ACCOUNTIDS_LEN)]
        public string AccountIDs { get; set; } 
        ///账户集合控制层级
		//[Column("I11")]
        public char AccountControlLevel { get; set; }
        ///账户集合范围
		//[Column("I12")]
        public char AccountRangeType { get; set; }
        ///投资账户联合风控
		//[Column("I13")]
        public byte AccountUnionFlag { get; set; }
        ///规则名称
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULENAME_LEN)]
		[StringLength(CommonDef.STP_RULENAME_LEN)]
        public string RuleName { get; set; } 
        ///是否活跃
		//[Column("I15")]
        public Int32 IsActive { get; set; }
        ///修改内容明细（json字符串）
		//[Column("I16")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
		[StringLength(CommonDef.STP_VALUE_LEN)]
        public string Value { get; set; } 
    };
	
    ///触发风控规则日志
    public class StpRiskRuleLog // struct
    {
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///序号
		//[Column("I2")]
        public Int32 SequenceNo { get; set; }
        ///公司编号
		//[Column("I3")]
        public Int32 CompanyID { get; set; }
        ///登录成功时间
		//[Column("I4")]
        public Int32 ExecuteTime { get; set; }
        ///规则ID
		//[Column("I5")]
        public Int32 RiskId { get; set; }
        ///规则代码
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
		[StringLength(CommonDef.STP_RULECODE_LEN)]
        public string RuleCode { get; set; } 
        ///规则名称
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULENAME_LEN)]
		[StringLength(CommonDef.STP_RULENAME_LEN)]
        public string RuleName { get; set; } 
        ///交易所代码
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///证券代码集合
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTIDS_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTIDS_LEN)]
        public string InstrumentIDs { get; set; } 
        ///账户编号
		//[Column("I10")]
        public Int32 AccountID { get; set; }
        ///报单引用
		//[Column("I11")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
		[StringLength(CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef { get; set; } 
        ///规则阀值
		//[Column("I12")]
        public double Threshold { get; set; }
        ///计算指标值
		//[Column("I13")]
        public double CalcValue { get; set; }
        ///错误信息
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
		[StringLength(CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg { get; set; } 
    };
	
    ///管理员指令
    public class StpAdminCommand // struct
    {
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///序号
		//[Column("I2")]
        public Int32 SequenceNo { get; set; }
        ///操作员代码
		//[Column("I3")]
        public Int32 OperatorID { get; set; }
        ///指令代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADMINCODE_LEN)]
		[StringLength(CommonDef.STP_ADMINCODE_LEN)]
        public string AdminCode { get; set; } 
        ///修改内容明细（json字符串）
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
		[StringLength(CommonDef.STP_VALUE_LEN)]
        public string Value { get; set; } 
        ///错误代码
		//[Column("I6")]
        public Int32 ErrorID { get; set; }
        ///错误信息
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
		[StringLength(CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg { get; set; } 
    };
	
    ///指令日志
    public class StpOperationLog // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///操作员代码
		//[Column("I2")]
        public Int32 OperatorID { get; set; }
        ///投资者代码
		//[Column("I3")]
        public Int32 InvestorID { get; set; }
        ///登录成功时间
		//[Column("I4")]
        public Int32 ExecuteTime { get; set; }
        ///指令代码
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADMINCODE_LEN)]
		[StringLength(CommonDef.STP_ADMINCODE_LEN)]
        public string AdminCode { get; set; } 
        ///修改内容明细（json字符串）
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
		[StringLength(CommonDef.STP_VALUE_LEN)]
        public string Value { get; set; } 
        ///错误代码
		//[Column("I7")]
        public Int32 ErrorID { get; set; }
        ///错误信息
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
		[StringLength(CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg { get; set; } 
    };
	
    ///持仓变动日志
    public class StpPosChangeLog // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///操作员代码
		//[Column("I2")]
        public Int32 OperatorID { get; set; }
        ///操作类型
		//[Column("I3")]
        public char OperationType { get; set; }
        ///变动类型
		//[Column("I4")]
        public char ChangeType { get; set; }
        ///账户编号
		//[Column("I5")]
        public Int32 AccountID { get; set; }
        ///组合编号
		//[Column("I6")]
        public Int32 ComboID { get; set; }
        ///证券代码
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///交易所代码
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///备兑标志
		//[Column("I9")]
        public char CoveredFlag { get; set; }
        ///持仓多空方向
		//[Column("I10")]
        public char PosiDirection { get; set; }
        ///登录成功时间
		//[Column("I11")]
        public Int32 ExecuteTime { get; set; }
        ///原始值
		//[Column("I12")]
        public double OriginValue { get; set; }
        ///更新值
		//[Column("I13")]
        public double NewValue { get; set; }
        ///备注
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_MEMO_LEN)]
		[StringLength(CommonDef.STP_MEMO_LEN)]
        public string Memo { get; set; } 
    };
	
    ///资金变动日志
    public class StpActChangeLog // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///操作员代码
		//[Column("I2")]
        public Int32 OperatorID { get; set; }
        ///操作类型
		//[Column("I3")]
        public char OperationType { get; set; }
        ///变动类型
		//[Column("I4")]
        public char ChangeType { get; set; }
        ///账户编号
		//[Column("I5")]
        public Int32 AccountID { get; set; }
        ///登录成功时间
		//[Column("I6")]
        public Int32 ExecuteTime { get; set; }
        ///原始值
		//[Column("I7")]
        public double OriginValue { get; set; }
        ///更新值
		//[Column("I8")]
        public double NewValue { get; set; }
        ///备注
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_MEMO_LEN)]
		[StringLength(CommonDef.STP_MEMO_LEN)]
        public string Memo { get; set; } 
    };
	
    ///返回信息
    public class StpRspInfo // struct
    {
        ///错误代码
		//[Column("I1")]
        public Int32 ErrorID { get; set; }
        ///结束标志
		//[Column("I2")]
        public Int32 IsLast { get; set; }
        ///错误信息
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
		[StringLength(CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg { get; set; } 
    };
	
    ///登录请求
    public class StpUserLoginReq // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///操作员代码
		//[Column("I1")]
        public Int32 OperatorID { get; set; }
        ///密码
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
		[StringLength(CommonDef.STP_PASSWORD_LEN)]
        public string Password { get; set; } 
    };
	
    ///登录请求
    public class StpLoginReq // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///操作员代码
		//[Column("I1")]
        public Int32 OperatorID { get; set; }
        ///密码
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
		[StringLength(CommonDef.STP_PASSWORD_LEN)]
        public string Password { get; set; } 
        ///订单IP
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
		[StringLength(CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP { get; set; } 
        ///订单MAC
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
		[StringLength(CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC { get; set; } 
        ///订单硬盘序列号
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
		[StringLength(CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum { get; set; } 
        ///订单机器码
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
		[StringLength(CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode { get; set; } 
        ///订单操作系统
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
		[StringLength(CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS { get; set; } 
    };
	
    ///注销请求
    public class StpLogoutReq // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///操作员代码
		//[Column("I1")]
        public Int32 OperatorID { get; set; }
    };
	
    ///登入请求响应
    public class StpRspLogin // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///交易日
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///登录成功时间
		//[Column("I2")]
        public Int32 LoginTime { get; set; }
        ///操作员代码
		//[Column("I3")]
        public Int32 OperatorID { get; set; }
        ///前置编号
		//[Column("I4")]
        public Int32 FrontID { get; set; }
        ///会话编号
		//[Column("I5")]
        public Int32 SessionID { get; set; }
        ///最大报单引用
		//[Column("I6")]
        public Int32 MaxOrderRef { get; set; }
    };
	
    ///报单录入请求
    public class StpOrderReq // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///操作员代码
		//[Column("I2")]
        public Int32 OperatorID { get; set; }
        ///组合编号
		//[Column("I3")]
        public Int32 ComboID { get; set; }
        ///证券代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///报单引用
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
		[StringLength(CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef { get; set; } 
        ///交易所代码
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///报单价格条件
		//[Column("I7")]
        public char OrderPriceType { get; set; }
        ///买卖方向
		//[Column("I8")]
        public char Direction { get; set; }
        ///开平标志
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBOFFSETFLAG_LEN)]
		[StringLength(CommonDef.STP_COMBOFFSETFLAG_LEN)]
        public string CombOffsetFlag { get; set; } 
        ///投机套保标志
		//[Column("I10")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBHEDGEFLAG_LEN)]
		[StringLength(CommonDef.STP_COMBHEDGEFLAG_LEN)]
        public string CombHedgeFlag { get; set; } 
        ///备兑标志
		//[Column("I11")]
        public char CoveredFlag { get; set; }
        ///价格
		//[Column("I12")]
        public double LimitPrice { get; set; }
        ///原始数量
		//[Column("I13")]
        public Int32 VolumeTotalOriginal { get; set; }
        ///有效期类型
		//[Column("I14")]
        public char TimeCondition { get; set; }
        ///成交量类型
		//[Column("I15")]
        public char VolumeCondition { get; set; }
        ///预留字段1
		//[Column("I16")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF1_LEN)]
		[StringLength(CommonDef.STP_THIRDREFF1_LEN)]
        public string ThirdReff1 { get; set; } 
        ///预留字段2
		//[Column("I17")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF2_LEN)]
		[StringLength(CommonDef.STP_THIRDREFF2_LEN)]
        public string ThirdReff2 { get; set; } 
        ///订单IP
		//[Column("I18")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
		[StringLength(CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP { get; set; } 
        ///订单MAC
		//[Column("I19")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
		[StringLength(CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC { get; set; } 
        ///订单硬盘序列号
		//[Column("I20")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
		[StringLength(CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum { get; set; } 
        ///订单机器码
		//[Column("I21")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
		[StringLength(CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode { get; set; } 
        ///订单操作系统
		//[Column("I22")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
		[StringLength(CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS { get; set; } 
    };
	
    ///取消报单请求
    public class StpOrderCancelReq // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///操作员代码
		//[Column("I2")]
        public Int32 OperatorID { get; set; }
        ///被撤单引用
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERACTIONREF_LEN)]
		[StringLength(CommonDef.STP_ORDERACTIONREF_LEN)]
        public string OrderActionRef { get; set; } 
        ///本地报单编号
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
		[StringLength(CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
        ///订单IP
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
		[StringLength(CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP { get; set; } 
        ///订单MAC
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
		[StringLength(CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC { get; set; } 
        ///订单硬盘序列号
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
		[StringLength(CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum { get; set; } 
        ///订单机器码
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
		[StringLength(CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode { get; set; } 
        ///订单操作系统
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
		[StringLength(CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS { get; set; } 
    };
	
    ///查询风控请求
    public class StpQryRiskRule // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///规则ID
		//[Column("I1")]
        public Int32 RiskId { get; set; }
        ///规则代码
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
		[StringLength(CommonDef.STP_RULECODE_LEN)]
        public string RuleCode { get; set; } 
    };
	
    ///查询产品信息
    public class StpQryInstrument // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///交易所代码
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///证券代码
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
    };
	
    ///查询产品手续费信息
    public class StpQryCommissionRate // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///交易所代码
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///证券代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///买卖方向
		//[Column("I4")]
        public char Direction { get; set; }
        ///开平标志
		//[Column("I5")]
        public char OffsetFlag { get; set; }
        ///备兑标志
		//[Column("I6")]
        public char CoveredFlag { get; set; }
        ///投机套保标志
		//[Column("I7")]
        public char HedgeFlag { get; set; }
    };
	
    ///查询产品保证金率信息
    public class StpQryMarginRate // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///交易所代码
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///证券代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///买卖方向
		//[Column("I4")]
        public char Direction { get; set; }
        ///开平标志
		//[Column("I5")]
        public char OffsetFlag { get; set; }
        ///备兑标志
		//[Column("I6")]
        public char CoveredFlag { get; set; }
        ///投机套保标志
		//[Column("I7")]
        public char HedgeFlag { get; set; }
    };
	
    ///查询报单
    public class StpQryOrder // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///组合编号
		//[Column("I2")]
        public Int32 ComboID { get; set; }
        ///交易所代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///证券代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///本地报单编号
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
		[StringLength(CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
    };
	
    ///查询成交
    public class StpQryTrade // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///组合编号
		//[Column("I2")]
        public Int32 ComboID { get; set; }
        ///交易所代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///证券代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///成交编号
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
		[StringLength(CommonDef.STP_TRADEID_LEN)]
        public string TradeID { get; set; } 
        ///本地报单编号
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
		[StringLength(CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
    };
	
    ///查询账户资金
    public class StpQryAccountAsset // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
    };
	
    ///查询账户基础信息
    public class StpQryAccount // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///查询账户类型
		//[Column("I2")]
        public char QryAccountType { get; set; }
    };
	
    ///查询投资者持仓
    public class StpQryPosition // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///组合编号
		//[Column("I2")]
        public Int32 ComboID { get; set; }
        ///交易所代码
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///证券代码
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
    };
	
    ///查询投资组合
    public class StpQryCombo // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///账户编号
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///组合编号
		//[Column("I2")]
        public Int32 ComboID { get; set; }
    };
	
}
  