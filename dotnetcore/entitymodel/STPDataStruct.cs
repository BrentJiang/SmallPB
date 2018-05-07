
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPB.entitymodel
{
    ///��������
    public class StpTradeDate // struct
    {
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///��һ������
		//[Column("I2")]
        public Int32 NextTradingDay { get; set; }
        ///ϵͳ״̬
		//[Column("I3")]
        public char SystemStatus { get; set; }
    };
	
    ///��Ȩ��Լ
    public class StpInstrument // struct
    {
        ///����������
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///��Ʒ����
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
		[StringLength(CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID { get; set; } 
        ///֤ȯ����
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///֤ȯ���״���
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTCODE_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTCODE_LEN)]
        public string InstrumentCode { get; set; } 
        ///��Լ����
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTNAME_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTNAME_LEN)]
        public string InstrumentName { get; set; } 
        ///֤ȯ���
		//[Column("I6")]
        public char ProductClass { get; set; }
        ///��Լ��������
		//[Column("I7")]
        public Int32 VolumeMultiple { get; set; }
        ///��С�䶯��λ
		//[Column("I8")]
        public double PriceTick { get; set; }
        ///������
		//[Column("I9")]
        public Int32 OpenDate { get; set; }
        ///������
		//[Column("I10")]
        public Int32 ExpireDate { get; set; }
        ///��ǰ�Ƿ���
		//[Column("I11")]
        public Int32 IsTrading { get; set; }
        ///��Ȩִ�м۸�
		//[Column("I12")]
        public double ExecPrice { get; set; }
        ///��Ȩ���ֱ�֤��
		//[Column("I13")]
        public double UnitMargin { get; set; }
        ///������
		//[Column("I14")]
        public Int32 TradingDay { get; set; }
        ///��Ȩ��
		//[Column("I15")]
        public Int32 ExerciseDay { get; set; }
        ///��ʼ������
		//[Column("I16")]
        public Int32 StartDeliveryDay { get; set; }
        ///����������
		//[Column("I17")]
        public Int32 EndDeliveryDay { get; set; }
        ///�м�����µ���
		//[Column("I18")]
        public Int32 MaxMarketOrderVolume { get; set; }
        ///�м���С�µ���
		//[Column("I19")]
        public Int32 MinMarketOrderVolume { get; set; }
        ///�޼�����µ���
		//[Column("I20")]
        public Int32 MaxLimitOrderVolume { get; set; }
        ///�޼���С�µ���
		//[Column("I21")]
        public Int32 MinLimitOrderVolume { get; set; }
        ///��ͣ���
		//[Column("I22")]
        public double UpperLimitPrice { get; set; }
        ///��ͣ���
		//[Column("I23")]
        public double LowerLimitPrice { get; set; }
        ///��Ȩ����
		//[Column("I24")]
        public char OptionType { get; set; }
        ///��С����䶯����
		//[Column("I25")]
        public Int32 BuyVolumeTick { get; set; }
        ///��С�����䶯����
		//[Column("I26")]
        public Int32 SellVolumeTick { get; set; }
        ///������Ʒ����
		//[Column("I27")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_UNDERLYINGINSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_UNDERLYINGINSTRUMENTID_LEN)]
        public string UnderlyingInstrumentID { get; set; } 
        ///������Ʒ����
		//[Column("I28")]
        public Int32 UnderlyingMultiple { get; set; }
        ///�ر�֤ȯ��־
		//[Column("I29")]
        public char StockRealBack { get; set; }
        ///�ر��ʽ��־
		//[Column("I30")]
        public char FundRealBack { get; set; }
    };
	
    ///��˾��Ϣ
    public class StpCompany // struct
    {
        ///��˾���
		//[Column("I1")]
        public Int32 CompanyID { get; set; }
        ///��˾����
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMPANYNAME_LEN)]
		[StringLength(CommonDef.STP_COMPANYNAME_LEN)]
        public string CompanyName { get; set; } 
        ///��˾����
		//[Column("I3")]
        public char CompanyType { get; set; }
        ///��ϵ��
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LINKMAN_LEN)]
		[StringLength(CommonDef.STP_LINKMAN_LEN)]
        public string LinkMan { get; set; } 
        ///��ϵ��ַ
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADDRESS_LEN)]
		[StringLength(CommonDef.STP_ADDRESS_LEN)]
        public string Address { get; set; } 
        ///��ϵ�绰
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TEL_LEN)]
		[StringLength(CommonDef.STP_TEL_LEN)]
        public string Tel { get; set; } 
        ///��������
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EMAIL_LEN)]
		[StringLength(CommonDef.STP_EMAIL_LEN)]
        public string Email { get; set; } 
    };
	
    ///��˾����Ա��Ϣ
    public class StpOperator // struct
    {
        ///����Ա����
		//[Column("I1")]
        public Int32 OperatorID { get; set; }
        ///��˾���
		//[Column("I2")]
        public Int32 CompanyID { get; set; }
        ///����Ա����
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPERATORNAME_LEN)]
		[StringLength(CommonDef.STP_OPERATORNAME_LEN)]
        public string OperatorName { get; set; } 
        ///����
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
		[StringLength(CommonDef.STP_PASSWORD_LEN)]
        public string Password { get; set; } 
        ///����Ա��ɫ
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPROLES_LEN)]
		[StringLength(CommonDef.STP_OPROLES_LEN)]
        public string OpRoles { get; set; } 
        ///(�ѷϳ�)����Ա���Բ�ѯ���˻�����
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_QRYACCOUNTIDS_LEN)]
		[StringLength(CommonDef.STP_QRYACCOUNTIDS_LEN)]
        public string QryAccountIDs { get; set; } 
        ///(�ѷϳ�)����Ա���Բ������˻�����
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPACCOUNTIDS_LEN)]
		[StringLength(CommonDef.STP_OPACCOUNTIDS_LEN)]
        public string OpAccountIDs { get; set; } 
        ///����Ա���Բ�ѯ����ϼ���
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_QRYCOMBOIDS_LEN)]
		[StringLength(CommonDef.STP_QRYCOMBOIDS_LEN)]
        public string QryComboIDs { get; set; } 
        ///����Ա���Բ�������ϼ���
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPCOMBOIDS_LEN)]
		[StringLength(CommonDef.STP_OPCOMBOIDS_LEN)]
        public string OpComboIDs { get; set; } 
        ///����Ա�绰
		//[Column("I10")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPTEL_LEN)]
		[StringLength(CommonDef.STP_OPTEL_LEN)]
        public string OpTel { get; set; } 
        ///����Ա����
		//[Column("I11")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPEMAIL_LEN)]
		[StringLength(CommonDef.STP_OPEMAIL_LEN)]
        public string OpEmail { get; set; } 
        ///ע��ʱ��
		//[Column("I12")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REGIDATE_LEN)]
		[StringLength(CommonDef.STP_REGIDATE_LEN)]
        public string RegiDate { get; set; } 
        ///״̬��־
		//[Column("I13")]
        public char EnbFlag { get; set; }
        ///�޸�ʱ��
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_UPTTIME_LEN)]
		[StringLength(CommonDef.STP_UPTTIME_LEN)]
        public string UptTime { get; set; } 
        ///��¼ʱ��
		//[Column("I15")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LOGTIME_LEN)]
		[StringLength(CommonDef.STP_LOGTIME_LEN)]
        public string LogTime { get; set; } 
        ///�����޸�ʱ��
		//[Column("I16")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PWDUPTTIME_LEN)]
		[StringLength(CommonDef.STP_PWDUPTTIME_LEN)]
        public string PwdUptTime { get; set; } 
        ///��¼����ʱ��
		//[Column("I17")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LOGERRTIME_LEN)]
		[StringLength(CommonDef.STP_LOGERRTIME_LEN)]
        public string LogErrTime { get; set; } 
        ///����������
		//[Column("I18")]
        public Int32 PwdErrCnt { get; set; }
        ///��ע
		//[Column("I19")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REMARK_LEN)]
		[StringLength(CommonDef.STP_REMARK_LEN)]
        public string Remark { get; set; } 
        ///��˾����
		//[Column("I20")]
        public char CompanyType { get; set; }
    };
	
    ///ϵͳȨ����Ϣ
    public class StpAuthInfo // struct
    {
        ///Ȩ��ID
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
		[StringLength(CommonDef.STP_AUTHID_LEN)]
        public string AuthID { get; set; } 
        ///Ȩ�޼���
		//[Column("I2")]
        public Int32 AuthLevel { get; set; }
        ///Ȩ������
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHDESC_LEN)]
		[StringLength(CommonDef.STP_AUTHDESC_LEN)]
        public string AuthDesc { get; set; } 
        ///��Ȩ��
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PARENTID_LEN)]
		[StringLength(CommonDef.STP_PARENTID_LEN)]
        public string ParentID { get; set; } 
        ///�Ƿ����¼�Ȩ��
		//[Column("I5")]
        public Int32 HaveSon { get; set; }
        ///˳���
		//[Column("I6")]
        public Int32 ID { get; set; }
        ///״̬��־
		//[Column("I7")]
        public char EnbFlag { get; set; }
        ///ȱʡ״̬
		//[Column("I8")]
        public Int32 IsDefault { get; set; }
        ///Ȩ���Ƿ���Ϊ������ʾ�ڿ�̨
		//[Column("I9")]
        public Int32 IsDisplay { get; set; }
        ///����
		//[Column("I10")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTION_LEN)]
		[StringLength(CommonDef.STP_ACTION_LEN)]
        public string Action { get; set; } 
        ///����
		//[Column("I11")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RESV_LEN)]
		[StringLength(CommonDef.STP_RESV_LEN)]
        public string Resv { get; set; } 
        ///����ʱ��
		//[Column("I12")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CRTTIME_LEN)]
		[StringLength(CommonDef.STP_CRTTIME_LEN)]
        public string CrtTime { get; set; } 
        ///���һ�θ���ʱ��
		//[Column("I13")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUPTTIME_LEN)]
		[StringLength(CommonDef.STP_LASTUPTTIME_LEN)]
        public string LastUptTime { get; set; } 
        ///��������
		//[Column("I14")]
        public char ActionType { get; set; }
        ///Ȩ������
		//[Column("I15")]
        public char AuthType { get; set; }
    };
	
    ///����ԱȨ����Ϣ
    public class StpOpAuthInfo // struct
    {
        ///����Ա����
		//[Column("I1")]
        public Int32 OperatorID { get; set; }
        ///Ȩ��ID
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
		[StringLength(CommonDef.STP_AUTHID_LEN)]
        public string AuthID { get; set; } 
        ///״̬��־
		//[Column("I3")]
        public char EnbFlag { get; set; }
        ///���һ��ʹ��ʱ��
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUSRTIME_LEN)]
		[StringLength(CommonDef.STP_LASTUSRTIME_LEN)]
        public string LastUsrTime { get; set; } 
        ///ʹ�ô���
		//[Column("I5")]
        public Int32 UsrCount { get; set; }
        ///����
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RESV_LEN)]
		[StringLength(CommonDef.STP_RESV_LEN)]
        public string Resv { get; set; } 
        ///����ʱ��
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CRTTIME_LEN)]
		[StringLength(CommonDef.STP_CRTTIME_LEN)]
        public string CrtTime { get; set; } 
        ///���һ�θ���ʱ��
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUPTTIME_LEN)]
		[StringLength(CommonDef.STP_LASTUPTTIME_LEN)]
        public string LastUptTime { get; set; } 
    };
	
    ///�ӿ�Ȩ��
    public class StpIntefAuthInfo // struct
    {
        ///�ӿڱ�ʶ
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CMDID_LEN)]
		[StringLength(CommonDef.STP_CMDID_LEN)]
        public string CmdID { get; set; } 
        ///Ȩ��ID
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
		[StringLength(CommonDef.STP_AUTHID_LEN)]
        public string AuthID { get; set; } 
    };
	
    ///����Ա��־
    public class StpOpLog // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///ϵͳ����
		//[Column("I1")]
        public Int32 SysDate { get; set; }
        ///ϵͳʱ��
		//[Column("I2")]
        public Int32 SysTime { get; set; }
        ///����Ա����
		//[Column("I3")]
        public Int32 OperatorID { get; set; }
        ///����
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTION_LEN)]
		[StringLength(CommonDef.STP_ACTION_LEN)]
        public string Action { get; set; } 
        ///��������
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTIONDESC_LEN)]
		[StringLength(CommonDef.STP_ACTIONDESC_LEN)]
        public string ActionDesc { get; set; } 
    };
	
    ///��ɫ��Ϣ
    public class StpRole // struct
    {
        ///��ɫ��
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLEID_LEN)]
		[StringLength(CommonDef.STP_ROLEID_LEN)]
        public string RoleID { get; set; } 
        ///��ɫ����
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLENAME_LEN)]
		[StringLength(CommonDef.STP_ROLENAME_LEN)]
        public string RoleName { get; set; } 
        ///��˾����
		//[Column("I3")]
        public char CompanyType { get; set; }
    };
	
    ///��ɫȨ����Ϣ
    public class StpRoleAuth // struct
    {
        ///��ɫ��
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLEID_LEN)]
		[StringLength(CommonDef.STP_ROLEID_LEN)]
        public string RoleID { get; set; } 
        ///Ȩ��ID
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
		[StringLength(CommonDef.STP_AUTHID_LEN)]
        public string AuthID { get; set; } 
    };
	
    ///�����ļ��б�
    public class StpFileDownload // struct
    {
        ///ϵͳ����
		//[Column("I1")]
        public Int32 SysDate { get; set; }
        ///ϵͳ��ˮ
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSSEQID_LEN)]
		[StringLength(CommonDef.STP_SYSSEQID_LEN)]
        public string SysSeqID { get; set; } 
        ///����Ա����
		//[Column("I3")]
        public Int32 OperatorID { get; set; }
        ///�ļ�����
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILENAME_LEN)]
		[StringLength(CommonDef.STP_FILENAME_LEN)]
        public string FileName { get; set; } 
        ///�ļ��洢·��
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEURL_LEN)]
		[StringLength(CommonDef.STP_FILEURL_LEN)]
        public string FileUrl { get; set; } 
        ///�ļ���ѯ����
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEINFO_LEN)]
		[StringLength(CommonDef.STP_FILEINFO_LEN)]
        public string FileInfo { get; set; } 
        ///����ִ��״̬
		//[Column("I7")]
        public char FileFlag { get; set; }
        ///��׺�ļ�����
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEPOSTFIX_LEN)]
		[StringLength(CommonDef.STP_FILEPOSTFIX_LEN)]
        public string FilePostFix { get; set; } 
        ///�ļ���������
		//[Column("I9")]
        public Int32 CreateDate { get; set; }
        ///�ļ�����ʱ��
		//[Column("I10")]
        public Int32 CreateTime { get; set; }
        ///��������
		//[Column("I11")]
        public Int32 UpdateDate { get; set; }
        ///����޸�ʱ��
		//[Column("I12")]
        public Int32 UpdateTime { get; set; }
    };
	
    ///��̨���б�
    public class StpCmdSequence // struct
    {
        ///��������
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEQNAME_LEN)]
		[StringLength(CommonDef.STP_SEQNAME_LEN)]
        public string SeqName { get; set; } 
        ///��ǰ����ֵ
		//[Column("I2")]
        public Int32 CurrentVal { get; set; }
        ///��ǰ����ֵ
		//[Column("I3")]
        public Int32 IncrementVal { get; set; }
    };
	
    ///����Ա����������Ϣ
    public class StpOpMarket // struct
    {
        ///��˾���
		//[Column("I1")]
        public Int32 CompanyID { get; set; }
        ///������������
		//[Column("I2")]
        public char MarketDataType { get; set; }
        ///����Ա����
		//[Column("I3")]
        public Int32 OperatorID { get; set; }
        ///�������Ӹ���
		//[Column("I4")]
        public Int32 LimitConNum { get; set; }
        ///�����ĸ���
		//[Column("I5")]
        public Int32 LimitSubNum { get; set; }
        ///����IP��ַ������
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_IPADDRESS_LEN)]
		[StringLength(CommonDef.STP_IPADDRESS_LEN)]
        public string IpAddress { get; set; } 
    };
	
    ///��˾����ɷ���Ϣ
    public class StpMarketDataPay // struct
    {
        ///��˾���
		//[Column("I1")]
        public Int32 CompanyID { get; set; }
        ///����������
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///�ɷѿ�Ŀ
		//[Column("I3")]
        public char PaySubject { get; set; }
        ///����ɷ�ʱ��
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTPAYTIME_LEN)]
		[StringLength(CommonDef.STP_LASTPAYTIME_LEN)]
        public string LastPayTime { get; set; } 
        ///�ɷѽ��
		//[Column("I5")]
        public double PayBalance { get; set; }
        ///��ʼ����
		//[Column("I6")]
        public Int32 StartDate { get; set; }
        ///��������
		//[Column("I7")]
        public Int32 EndDate { get; set; }
    };
	
    ///��˾����ɷ���ˮ
    public class StpMarketDataPayFlow // struct
    {
        ///��ˮ���
		//[Column("I1")]
        public Int32 PayID { get; set; }
        ///��˾���
		//[Column("I2")]
        public Int32 CompanyID { get; set; }
        ///����������
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///�ɷѿ�Ŀ
		//[Column("I4")]
        public char PaySubject { get; set; }
        ///�ɷ�ʱ��
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PAYTIME_LEN)]
		[StringLength(CommonDef.STP_PAYTIME_LEN)]
        public string PayTime { get; set; } 
        ///�ɷѽ��
		//[Column("I6")]
        public double PayBalance { get; set; }
        ///��ʼ����
		//[Column("I7")]
        public Int32 StartDate { get; set; }
        ///��������
		//[Column("I8")]
        public Int32 EndDate { get; set; }
    };
	
    ///�˻���Ϣ
    public class StpAccount // struct
    {
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///��˾���
		//[Column("I2")]
        public Int32 CompanyID { get; set; }
        ///�ʽ��˻�����
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
		[StringLength(CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName { get; set; } 
        ///Ͷ���ߴ���
		//[Column("I4")]
        public Int32 InvestorID { get; set; }
        ///�˻�����
		//[Column("I5")]
        public char AccountType { get; set; }
        ///״̬��־
		//[Column("I6")]
        public char EnbFlag { get; set; }
        ///������
		//[Column("I7")]
        public Int32 TradingDay { get; set; }
        ///����ͨ�����
		//[Column("I8")]
        public Int32 ChannelID { get; set; }
        ///Ĭ�����
		//[Column("I9")]
        public Int32 DefaultCombo { get; set; }
    };
	
    ///Ͷ�����
    public class StpAccountCombo // struct
    {
        ///��ϱ��
		//[Column("I1")]
        public Int32 ComboID { get; set; }
        ///�˻����
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///�������
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBONAME_LEN)]
		[StringLength(CommonDef.STP_COMBONAME_LEN)]
        public string ComboName { get; set; } 
        ///����������
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///Ͷ����϶�Ӧ�ĺ�Լ����
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_KEYINSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_KEYINSTRUMENTID_LEN)]
        public string KeyInstrumentID { get; set; } 
        ///�Ƿ��Ծ
		//[Column("I6")]
        public Int32 IsActive { get; set; }
        ///ȱʡ״̬
		//[Column("I7")]
        public Int32 IsDefault { get; set; }
        ///������
		//[Column("I8")]
        public Int32 TradingDay { get; set; }
        ///�������ڽ���
		//[Column("I9")]
        public byte DayTradeEnable { get; set; }
    };
	
    ///Ͷ������Ϣ
    public class StpInvestor // struct
    {
        ///Ͷ���ߴ���
		//[Column("I1")]
        public Int32 InvestorID { get; set; }
        ///������
		//[Column("I2")]
        public Int32 TradingDay { get; set; }
        ///���͹�˾����
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BROKERID_LEN)]
		[StringLength(CommonDef.STP_BROKERID_LEN)]
        public string BrokerID { get; set; } 
        ///ĸ�˻�����
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BROKERINVESTORID_LEN)]
		[StringLength(CommonDef.STP_BROKERINVESTORID_LEN)]
        public string BrokerInvestorID { get; set; } 
        ///�û�����
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_USERID_LEN)]
		[StringLength(CommonDef.STP_USERID_LEN)]
        public string UserID { get; set; } 
        ///�ͻ���
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CLIENTID_LEN)]
		[StringLength(CommonDef.STP_CLIENTID_LEN)]
        public string ClientID { get; set; } 
        ///�ʽ��˻�����
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTCODE_LEN)]
		[StringLength(CommonDef.STP_ACCOUNTCODE_LEN)]
        public string AccountCode { get; set; } 
        ///����
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
		[StringLength(CommonDef.STP_PASSWORD_LEN)]
        public string Password { get; set; } 
        ///Ͷ��������
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INVESTORNAME_LEN)]
		[StringLength(CommonDef.STP_INVESTORNAME_LEN)]
        public string InvestorName { get; set; } 
        ///Ͷ��������
		//[Column("I10")]
        public char InvestorType { get; set; }
        ///֤������
		//[Column("I11")]
        public char IDCardType { get; set; }
        ///֤����
		//[Column("I12")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_IDCARDNO_LEN)]
		[StringLength(CommonDef.STP_IDCARDNO_LEN)]
        public string IDCardNo { get; set; } 
        ///�Ƿ��Ծ
		//[Column("I13")]
        public Int32 IsActive { get; set; }
        ///������
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_GROUPID_LEN)]
		[StringLength(CommonDef.STP_GROUPID_LEN)]
        public string GroupID { get; set; } 
        ///O32����Ա����
		//[Column("I15")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32OPERATORNO_LEN)]
		[StringLength(CommonDef.STP_O32OPERATORNO_LEN)]
        public string O32OperatorNo { get; set; } 
        ///O32����Ա����
		//[Column("I16")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32OPERATORPWD_LEN)]
		[StringLength(CommonDef.STP_O32OPERATORPWD_LEN)]
        public string O32OperatorPwd { get; set; } 
        ///O32�������
		//[Column("I17")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32ACCOUNTCODE_LEN)]
		[StringLength(CommonDef.STP_O32ACCOUNTCODE_LEN)]
        public string O32AccountCode { get; set; } 
        ///O32��ϱ��
		//[Column("I18")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32COMBINO_LEN)]
		[StringLength(CommonDef.STP_O32COMBINO_LEN)]
        public string O32CombiNo { get; set; } 
        ///O32�ʲ���Ԫ���
		//[Column("I19")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32ASSETNO_LEN)]
		[StringLength(CommonDef.STP_O32ASSETNO_LEN)]
        public string O32AssetNo { get; set; } 
    };
	
    ///Ͷ���߽��ױ���
    public class StpTradingCode // struct
    {
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///�˻����
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///����������
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///���ױ�������
		//[Column("I4")]
        public char TradingCodeType { get; set; }
        ///���ױ���
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
		[StringLength(CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///Ӫҵ������
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
		[StringLength(CommonDef.STP_BRANCHID_LEN)]
        public string BranchID { get; set; } 
        ///ϯλ��
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
		[StringLength(CommonDef.STP_SEATID_LEN)]
        public string SeatID { get; set; } 
        ///Ͷ�����˻��ӱ���
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPTCLIENTID_LEN)]
		[StringLength(CommonDef.STP_OPTCLIENTID_LEN)]
        public string OptClientID { get; set; } 
        ///�Ƿ��Ծ
		//[Column("I9")]
        public Int32 IsActive { get; set; }
    };
	
    ///����ͨ����Ϣ
    public class StpTradeChannel // struct
    {
        ///����ͨ�����
		//[Column("I1")]
        public Int32 ChannelID { get; set; }
        ///ͨ������
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CHANNELNAME_LEN)]
		[StringLength(CommonDef.STP_CHANNELNAME_LEN)]
        public string ChannelName { get; set; } 
        ///ͨ������
		//[Column("I3")]
        public char ChannelType { get; set; }
        ///�ֲֽӿ�IP
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSIP_LEN)]
		[StringLength(CommonDef.STP_SYSIP_LEN)]
        public string SysIP { get; set; } 
        ///�ֲֽӿڶ˿�
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSPORT_LEN)]
		[StringLength(CommonDef.STP_SYSPORT_LEN)]
        public string SysPort { get; set; } 
        ///�ֲ���������
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CHANNELCONFIG_LEN)]
		[StringLength(CommonDef.STP_CHANNELCONFIG_LEN)]
        public string ChannelConfig { get; set; } 
        ///������
		//[Column("I7")]
        public Int32 TradingDay { get; set; }
    };
	
    ///�˻��ʽ���Ϣ
    public class StpAccountAsset // struct
    {
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///�˻����
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///���ִ���
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CURRENCYID_LEN)]
		[StringLength(CommonDef.STP_CURRENCYID_LEN)]
        public string CurrencyID { get; set; } 
        ///�ϴδ���
		//[Column("I4")]
        public double PreDeposit { get; set; }
        ///�ϴ�ռ�õı�֤��
		//[Column("I5")]
        public double PreMargin { get; set; }
        ///�ϴν���׼����
		//[Column("I6")]
        public double PreBalance { get; set; }
        ///��ǰ�ʽ�
		//[Column("I7")]
        public double Balance { get; set; }
        ///�����
		//[Column("I8")]
        public double Deposit { get; set; }
        ///����ı�֤��
		//[Column("I9")]
        public double FrozenMargin { get; set; }
        ///�����������
		//[Column("I10")]
        public double FrozenCommission { get; set; }
        ///������ʽ�
		//[Column("I11")]
        public double FrozenCash { get; set; }
        ///�ֹ�������ʽ�
		//[Column("I12")]
        public double ManualFrozenCash { get; set; }
        ///�˶Ե����ʽ�
		//[Column("I13")]
        public double CheckCash { get; set; }
        ///��λռ�ñ�֤��
		//[Column("I14")]
        public double UseMargin { get; set; }
        ///������
		//[Column("I15")]
        public double Commission { get; set; }
        ///��ȡ�ʽ�
		//[Column("I16")]
        public double WithdrawQuota { get; set; }
        ///��֤��������
		//[Column("I17")]
        public double Credit { get; set; }
        ///�ֽ�
		//[Column("I18")]
        public double Available { get; set; }
        ///ƽ��ӯ��
		//[Column("I19")]
        public double CloseProfit { get; set; }
        ///�ֲ�ӯ��
		//[Column("I20")]
        public double PositionProfit { get; set; }
        ///�ʽ���
		//[Column("I21")]
        public double CashIn { get; set; }
        ///������
		//[Column("I22")]
        public double CashOut { get; set; }
        ///ȱʡ״̬
		//[Column("I23")]
        public Int32 IsDefault { get; set; }
    };
	
    ///��ѯ�˻��ʽ���Ϣ
    public class StpUserAccountAsset // struct
    {
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///�ʽ��˻�����
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
		[StringLength(CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName { get; set; } 
        ///��ǰ�ʽ�
		//[Column("I3")]
        public double Balance { get; set; }
        ///�����ʽ�
		//[Column("I4")]
        public double EnableBalance { get; set; }
        ///������ʽ�
		//[Column("I5")]
        public double FrozenCash { get; set; }
        ///�ֹ�������ʽ�
		//[Column("I6")]
        public double ManualFrozenCash { get; set; }
        ///�˶Ե����ʽ�
		//[Column("I7")]
        public double CheckCash { get; set; }
    };
	
    ///�˻��ֲ���Ϣ
    public class StpAccountPosition // struct
    {
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///����������
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///���ұ�־
		//[Column("I4")]
        public char CoveredFlag { get; set; }
        ///�ֲֶ�շ���
		//[Column("I5")]
        public char PosiDirection { get; set; }
        ///���ױ���
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
		[StringLength(CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///���ױ�������
		//[Column("I7")]
        public char TradingCodeType { get; set; }
        ///������
		//[Column("I8")]
        public Int32 TradingDay { get; set; }
        ///���ճֲ�
		//[Column("I9")]
        public double YdPosition { get; set; }
        ///�ϴ�ռ�õı�֤��
		//[Column("I10")]
        public double PreMargin { get; set; }
        ///��ֲ�
		//[Column("I11")]
        public double TodayPosition { get; set; }
        ///�ֲܳ�
		//[Column("I12")]
        public double TotalPosition { get; set; }
        ///��λռ�ñ�֤��
		//[Column("I13")]
        public double UseMargin { get; set; }
        ///������
		//[Column("I14")]
        public double OpenVolume { get; set; }
        ///ƽ����
		//[Column("I15")]
        public double CloseVolume { get; set; }
        ///ƽ�����
		//[Column("I16")]
        public double CloseYdVolume { get; set; }
        ///���ν����
		//[Column("I17")]
        public double SettlementPrice { get; set; }
        ///�ϴν����
		//[Column("I18")]
        public double PreSettlementPrice { get; set; }
        ///������
		//[Column("I19")]
        public double Commission { get; set; }
        ///�����������
		//[Column("I20")]
        public double FrozenCommission { get; set; }
        ///����ı�֤��
		//[Column("I21")]
        public double FrozenMargin { get; set; }
        ///���ֳɱ�
		//[Column("I22")]
        public double OpenCost { get; set; }
        ///�ֲֳɱ�
		//[Column("I23")]
        public double PositionCost { get; set; }
        ///ƽ��ӯ��
		//[Column("I24")]
        public double CloseProfit { get; set; }
        ///�ֲ�ӯ��
		//[Column("I25")]
        public double PositionProfit { get; set; }
        ///���ֽ��
		//[Column("I26")]
        public double OpenAmount { get; set; }
        ///ƽ�ֽ��
		//[Column("I27")]
        public double CloseAmount { get; set; }
        ///ƽ��ֽ��
		//[Column("I28")]
        public double CloseYdAmount { get; set; }
        ///��ͷ����
		//[Column("I29")]
        public double LongFrozen { get; set; }
        ///���ֶ�����
		//[Column("I30")]
        public double LongFrozenAmount { get; set; }
        ///��ͷ����
		//[Column("I31")]
        public double ShortFrozen { get; set; }
        ///���ֶ�����
		//[Column("I32")]
        public double ShortFrozenAmount { get; set; }
        ///��������
		//[Column("I33")]
        public double FrozenVolume { get; set; }
        ///�ֹ���������
		//[Column("I34")]
        public double ManualFrozenVolume { get; set; }
        ///�˶Ե�������
		//[Column("I35")]
        public double CheckVolume { get; set; }
        ///��������
		//[Column("I36")]
        public double EnableVolume { get; set; }
    };
	
    ///��ѯ��ϳֲ���Ϣ
    public class StpUserComboPosition // struct
    {
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///�ʽ��˻�����
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
		[StringLength(CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName { get; set; } 
        ///��ϱ��
		//[Column("I3")]
        public Int32 ComboID { get; set; }
        ///�������
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBONAME_LEN)]
		[StringLength(CommonDef.STP_COMBONAME_LEN)]
        public string ComboName { get; set; } 
        ///����������
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///��Լ����
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTNAME_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTNAME_LEN)]
        public string InstrumentName { get; set; } 
        ///�ֲܳ�
		//[Column("I8")]
        public double TotalPosition { get; set; }
        ///��������
		//[Column("I9")]
        public double FrozenVolume { get; set; }
        ///�ֹ���������
		//[Column("I10")]
        public double ManualFrozenVolume { get; set; }
        ///�˶Ե�������
		//[Column("I11")]
        public double CheckVolume { get; set; }
        ///��������
		//[Column("I12")]
        public double EnableVolume { get; set; }
        ///�ֲֳɱ�
		//[Column("I13")]
        public double PositionCost { get; set; }
        ///�ɱ���
		//[Column("I14")]
        public double CostPrice { get; set; }
        ///���¼�
		//[Column("I15")]
        public double LastPrice { get; set; }
        ///�ֲ���ֵ
		//[Column("I16")]
        public double OpenMarketValue { get; set; }
        ///����ӯ��
		//[Column("I17")]
        public double FloatProfi { get; set; }
        ///��ͷ����
		//[Column("I18")]
        public double LongFrozen { get; set; }
        ///��ͷ����
		//[Column("I19")]
        public double ShortFrozen { get; set; }
        ///���ڳ�ʼ����
		//[Column("I20")]
        public Int32 DayTradeInitVolume { get; set; }
        ///���ڿ�������
		//[Column("I21")]
        public Int32 DayTradeAvailVolume { get; set; }
        ///����ӯ��
		//[Column("I22")]
        public double DayTradeFloatProfitLoss { get; set; }
        ///���ڳֲֳɱ���
		//[Column("I23")]
        public double DayTradePositionCost { get; set; }
        ///����ƽ��ӯ��
		//[Column("I24")]
        public double DayTradeCloseProfit { get; set; }
        ///��������
		//[Column("I25")]
        public double DayTradeAccumBuy { get; set; }
        ///��������
		//[Column("I26")]
        public double DayTradeAccumSell { get; set; }
    };
	
    ///��ϳֲ���Ϣ
    public class StpComboPosition // struct
    {
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///����������
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///��ϱ��
		//[Column("I3")]
        public Int32 ComboID { get; set; }
        ///֤ȯ����
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///���ұ�־
		//[Column("I5")]
        public char CoveredFlag { get; set; }
        ///�ֲֶ�շ���
		//[Column("I6")]
        public char PosiDirection { get; set; }
        ///���ױ���
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
		[StringLength(CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///���ױ�������
		//[Column("I8")]
        public char TradingCodeType { get; set; }
        ///������
		//[Column("I9")]
        public Int32 TradingDay { get; set; }
        ///���ճֲ�
		//[Column("I10")]
        public double YdPosition { get; set; }
        ///�ϴ�ռ�õı�֤��
		//[Column("I11")]
        public double PreMargin { get; set; }
        ///��ֲ�
		//[Column("I12")]
        public double TodayPosition { get; set; }
        ///�ֲܳ�
		//[Column("I13")]
        public double TotalPosition { get; set; }
        ///��λռ�ñ�֤��
		//[Column("I14")]
        public double UseMargin { get; set; }
        ///������
		//[Column("I15")]
        public double OpenVolume { get; set; }
        ///ƽ����
		//[Column("I16")]
        public double CloseVolume { get; set; }
        ///ƽ�����
		//[Column("I17")]
        public double CloseYdVolume { get; set; }
        ///���ν����
		//[Column("I18")]
        public double SettlementPrice { get; set; }
        ///�ϴν����
		//[Column("I19")]
        public double PreSettlementPrice { get; set; }
        ///������
		//[Column("I20")]
        public double Commission { get; set; }
        ///�����������
		//[Column("I21")]
        public double FrozenCommission { get; set; }
        ///����ı�֤��
		//[Column("I22")]
        public double FrozenMargin { get; set; }
        ///���ֳɱ�
		//[Column("I23")]
        public double OpenCost { get; set; }
        ///�ֲֳɱ�
		//[Column("I24")]
        public double PositionCost { get; set; }
        ///ƽ��ӯ��
		//[Column("I25")]
        public double CloseProfit { get; set; }
        ///�ֲ�ӯ��
		//[Column("I26")]
        public double PositionProfit { get; set; }
        ///���ֽ��
		//[Column("I27")]
        public double OpenAmount { get; set; }
        ///ƽ�ֽ��
		//[Column("I28")]
        public double CloseAmount { get; set; }
        ///ƽ��ֽ��
		//[Column("I29")]
        public double CloseYdAmount { get; set; }
        ///��ͷ����
		//[Column("I30")]
        public double LongFrozen { get; set; }
        ///���ֶ�����
		//[Column("I31")]
        public double LongFrozenAmount { get; set; }
        ///��ͷ����
		//[Column("I32")]
        public double ShortFrozen { get; set; }
        ///���ֶ�����
		//[Column("I33")]
        public double ShortFrozenAmount { get; set; }
        ///��������
		//[Column("I34")]
        public double FrozenVolume { get; set; }
        ///�ֹ���������
		//[Column("I35")]
        public double ManualFrozenVolume { get; set; }
        ///�˶Ե�������
		//[Column("I36")]
        public double CheckVolume { get; set; }
        ///��������
		//[Column("I37")]
        public double EnableVolume { get; set; }
        ///���ڳ�ʼ����
		//[Column("I38")]
        public Int32 DayTradeInitVolume { get; set; }
        ///���ڿ�������
		//[Column("I39")]
        public Int32 DayTradeAvailVolume { get; set; }
        ///����ӯ��
		//[Column("I40")]
        public double DayTradeFloatProfitLoss { get; set; }
        ///���ڳֲֳɱ���
		//[Column("I41")]
        public double DayTradePositionCost { get; set; }
        ///����ƽ��ӯ��
		//[Column("I42")]
        public double DayTradeCloseProfit { get; set; }
        ///��������
		//[Column("I43")]
        public double DayTradeAccumBuy { get; set; }
        ///��������
		//[Column("I44")]
        public double DayTradeAccumSell { get; set; }
    };
	
    ///���ڳֲֵ���
    public class StpDayTradePositionAdjReq // struct
    {
        ///����Ա����
		//[Column("I1")]
        public Int32 OperatorID { get; set; }
        ///�˻����
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///����������
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///��ϱ��
		//[Column("I4")]
        public Int32 ComboID { get; set; }
        ///֤ȯ����
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///���ڵ�������
		//[Column("I6")]
        public Int32 DayTradePositionAdjAmount { get; set; }
        ///���ڵ��ּ۸�
		//[Column("I7")]
        public double DayTradePositionAdjCost { get; set; }
        ///������Ϣ
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPERATEMSG_LEN)]
		[StringLength(CommonDef.STP_OPERATEMSG_LEN)]
        public string OperateMsg { get; set; } 
    };
	
    ///�˻��ֲ���ϸ
    public class StpAccountPositionDtl // struct
    {
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///����������
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///��ϱ��
		//[Column("I3")]
        public Int32 ComboID { get; set; }
        ///֤ȯ����
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///���ұ�־
		//[Column("I5")]
        public char CoveredFlag { get; set; }
        ///�ֲֶ�շ���
		//[Column("I6")]
        public char PosiDirection { get; set; }
        ///������
		//[Column("I7")]
        public Int32 OpenDate { get; set; }
        ///�ɽ����
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
		[StringLength(CommonDef.STP_TRADEID_LEN)]
        public string TradeID { get; set; } 
        ///���ױ���
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
		[StringLength(CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///���ױ�������
		//[Column("I10")]
        public char TradingCodeType { get; set; }
        ///������
		//[Column("I11")]
        public Int32 TradingDay { get; set; }
        ///�ɽ���
		//[Column("I12")]
        public Int32 Volume { get; set; }
        ///���ν����
		//[Column("I13")]
        public double SettlementPrice { get; set; }
        ///�ϴν����
		//[Column("I14")]
        public double PreSettlementPrice { get; set; }
        ///����
		//[Column("I15")]
        public double OpenPrice { get; set; }
        ///Ͷ���߱�֤��
		//[Column("I16")]
        public double Margin { get; set; }
        ///Ͷ���߱�֤����
		//[Column("I17")]
        public double MarginRate { get; set; }
        ///ƽ����
		//[Column("I18")]
        public double CloseVolume { get; set; }
        ///ƽ�ֽ��
		//[Column("I19")]
        public double CloseAmount { get; set; }
    };
	
    ///����������Ϣ
    public class StpFeeSet // struct
    {
        ///��˾���
		//[Column("I1")]
        public Int32 CompanyID { get; set; }
        ///�˻����
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///����������
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///֤ȯ���
		//[Column("I5")]
        public char ProductClass { get; set; }
        ///��Ʒ����
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
		[StringLength(CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID { get; set; } 
        ///��������
		//[Column("I7")]
        public char Direction { get; set; }
        ///��ƽ��־
		//[Column("I8")]
        public char OffsetFlag { get; set; }
        ///���ұ�־
		//[Column("I9")]
        public char CoveredFlag { get; set; }
        ///Ͷ���ױ���־
		//[Column("I10")]
        public char HedgeFlag { get; set; }
        ///�������
		//[Column("I11")]
        public char FeeType { get; set; }
        ///���ð��ɽ�������
		//[Column("I12")]
        public double BalanceRatio { get; set; }
        ///���ð��ɽ���ֵ����
		//[Column("I13")]
        public double FaceValueRatio { get; set; }
        ///���ð��ɽ���������
		//[Column("I14")]
        public double AmountRatio { get; set; }
        ///����շ�
		//[Column("I15")]
        public double MaxFee { get; set; }
        ///����շ�
		//[Column("I16")]
        public double MinFee { get; set; }
        ///���ü���ģʽ
		//[Column("I17")]
        public char CalculateType { get; set; }
        ///������
		//[Column("I18")]
        public Int32 TradingDay { get; set; }
    };
	
    ///��֤����
    public class StpMarginRate // struct
    {
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///�˻����
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///Ͷ���߷�Χ
		//[Column("I3")]
        public char InvestorRange { get; set; }
        ///����������
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///���ұ�־
		//[Column("I6")]
        public char CoveredFlag { get; set; }
        ///Ͷ���ױ���־
		//[Column("I7")]
        public char HedgeFlag { get; set; }
        ///��Ȩ����
		//[Column("I8")]
        public char OptionType { get; set; }
        ///֤ȯ���
		//[Column("I9")]
        public char ProductClass { get; set; }
        ///��Ʒ����
		//[Column("I10")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
		[StringLength(CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID { get; set; } 
        ///��ͷ��֤����
		//[Column("I11")]
        public double LongMarginRatioByMoney { get; set; }
        ///��ͷ��֤���
		//[Column("I12")]
        public double LongMarginRatioByVolume { get; set; }
        ///��ͷ��֤����
		//[Column("I13")]
        public double ShortMarginRatioByMoney { get; set; }
        ///��ͷ��֤���
		//[Column("I14")]
        public double ShortMarginRatioByVolume { get; set; }
        ///�Ƿ񰴱����ϸ�
		//[Column("I15")]
        public Int32 IsFloat { get; set; }
    };
	
    ///����
    public class StpOrder // struct
    {
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///�˻����
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///��ϱ��
		//[Column("I3")]
        public Int32 ComboID { get; set; }
        ///�Ự���
		//[Column("I4")]
        public Int32 SessionID { get; set; }
        ///ǰ�ñ��
		//[Column("I5")]
        public Int32 FrontID { get; set; }
        ///��������
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
		[StringLength(CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef { get; set; } 
        ///����������
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///ϯλ��
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
		[StringLength(CommonDef.STP_SEATID_LEN)]
        public string SeatID { get; set; } 
        ///���ر������
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
		[StringLength(CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
        ///��������
		//[Column("I10")]
        public char Direction { get; set; }
        ///����Ա����
		//[Column("I11")]
        public Int32 OperatorID { get; set; }
        ///���ױ���
		//[Column("I12")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
		[StringLength(CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///Ӫҵ������
		//[Column("I13")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
		[StringLength(CommonDef.STP_BRANCHID_LEN)]
        public string BranchID { get; set; } 
        ///֤ȯ����
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///�����۸�����
		//[Column("I15")]
        public char OrderPriceType { get; set; }
        ///��ƽ��־
		//[Column("I16")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBOFFSETFLAG_LEN)]
		[StringLength(CommonDef.STP_COMBOFFSETFLAG_LEN)]
        public string CombOffsetFlag { get; set; } 
        ///Ͷ���ױ���־
		//[Column("I17")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBHEDGEFLAG_LEN)]
		[StringLength(CommonDef.STP_COMBHEDGEFLAG_LEN)]
        public string CombHedgeFlag { get; set; } 
        ///���ұ�־
		//[Column("I18")]
        public char CoveredFlag { get; set; }
        ///�۸�
		//[Column("I19")]
        public double LimitPrice { get; set; }
        ///ԭʼ����
		//[Column("I20")]
        public Int32 VolumeTotalOriginal { get; set; }
        ///��Ч������
		//[Column("I21")]
        public char TimeCondition { get; set; }
        ///�ɽ�������
		//[Column("I22")]
        public char VolumeCondition { get; set; }
        ///��С�ɽ���
		//[Column("I23")]
        public Int32 MinVolume { get; set; }
        ///��������
		//[Column("I24")]
        public char ContingentCondition { get; set; }
        ///ֹ���
		//[Column("I25")]
        public double StopPrice { get; set; }
        ///������
		//[Column("I26")]
        public Int32 ORRequestID { get; set; }
        ///�������
		//[Column("I27")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERSYSID_LEN)]
		[StringLength(CommonDef.STP_ORDERSYSID_LEN)]
        public string OrderSysID { get; set; } 
        ///����״̬
		//[Column("I28")]
        public char OrderStatus { get; set; }
        ///��������
		//[Column("I29")]
        public char OrderType { get; set; }
        ///��ɽ�����
		//[Column("I30")]
        public Int32 VolumeTraded { get; set; }
        ///��ɽ����
		//[Column("I31")]
        public double AmountTraded { get; set; }
        ///ʣ������
		//[Column("I32")]
        public Int32 VolumeRemain { get; set; }
        ///��������
		//[Column("I33")]
        public Int32 InsertDate { get; set; }
        ///ί��ʱ��
		//[Column("I34")]
        public Int32 InsertTime { get; set; }
        ///����޸�ʱ��
		//[Column("I35")]
        public Int32 UpdateTime { get; set; }
        ///����ʱ��
		//[Column("I36")]
        public Int32 CancelTime { get; set; }
        ///����������
		//[Column("I37")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERACTIONREF_LEN)]
		[StringLength(CommonDef.STP_ORDERACTIONREF_LEN)]
        public string OrderActionRef { get; set; } 
        ///״̬��Ϣ
		//[Column("I38")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_STATUSMSG_LEN)]
		[StringLength(CommonDef.STP_STATUSMSG_LEN)]
        public string StatusMsg { get; set; } 
        ///�����־
		//[Column("I39")]
        public char OwnerType { get; set; }
        ///Ԥ���ֶ�1
		//[Column("I40")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF1_LEN)]
		[StringLength(CommonDef.STP_THIRDREFF1_LEN)]
        public string ThirdReff1 { get; set; } 
        ///Ԥ���ֶ�2
		//[Column("I41")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF2_LEN)]
		[StringLength(CommonDef.STP_THIRDREFF2_LEN)]
        public string ThirdReff2 { get; set; } 
        ///����\�ϵ�����
		//[Column("I42")]
        public Int32 VolumeCanceled { get; set; }
        ///��ע
		//[Column("I43")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REMARK_LEN)]
		[StringLength(CommonDef.STP_REMARK_LEN)]
        public string Remark { get; set; } 
        ///������־
		//[Column("I44")]
        public char CancelFlag { get; set; }
        ///����IP
		//[Column("I45")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
		[StringLength(CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP { get; set; } 
        ///����MAC
		//[Column("I46")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
		[StringLength(CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC { get; set; } 
        ///����Ӳ�����к�
		//[Column("I47")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
		[StringLength(CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum { get; set; } 
        ///����������
		//[Column("I48")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
		[StringLength(CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode { get; set; } 
        ///��������ϵͳ
		//[Column("I49")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
		[StringLength(CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS { get; set; } 
        ///��ǰ�ʽ�
		//[Column("I50")]
        public double Balance { get; set; }
        ///������
		//[Column("I51")]
        public double Commission { get; set; }
    };
	
    ///�ɽ�
    public class StpTrade // struct
    {
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///�˻����
		//[Column("I2")]
        public Int32 AccountID { get; set; }
        ///��ϱ��
		//[Column("I3")]
        public Int32 ComboID { get; set; }
        ///����������
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///�ɽ����
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
		[StringLength(CommonDef.STP_TRADEID_LEN)]
        public string TradeID { get; set; } 
        ///��������
		//[Column("I6")]
        public char Direction { get; set; }
        ///���ױ���
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
		[StringLength(CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///ϯλ��
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
		[StringLength(CommonDef.STP_SEATID_LEN)]
        public string SeatID { get; set; } 
        ///Ӫҵ������
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
		[StringLength(CommonDef.STP_BRANCHID_LEN)]
        public string BranchID { get; set; } 
        ///֤ȯ���״���
		//[Column("I10")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTCODE_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTCODE_LEN)]
        public string InstrumentCode { get; set; } 
        ///֤ȯ����
		//[Column("I11")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///����Ա����
		//[Column("I12")]
        public Int32 OperatorID { get; set; }
        ///������
		//[Column("I13")]
        public Int32 ORRequestID { get; set; }
        ///�������
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERSYSID_LEN)]
		[StringLength(CommonDef.STP_ORDERSYSID_LEN)]
        public string OrderSysID { get; set; } 
        ///���ر������
		//[Column("I15")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
		[StringLength(CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
        ///��������
		//[Column("I16")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
		[StringLength(CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef { get; set; } 
        ///��ƽ��־
		//[Column("I17")]
        public char OffsetFlag { get; set; }
        ///���ұ�־
		//[Column("I18")]
        public char CoveredFlag { get; set; }
        ///Ͷ���ױ���־
		//[Column("I19")]
        public char HedgeFlag { get; set; }
        ///�۸�
		//[Column("I20")]
        public double Price { get; set; }
        ///�ɽ���
		//[Column("I21")]
        public Int32 Volume { get; set; }
        ///�ɽ����
		//[Column("I22")]
        public double TradeAmount { get; set; }
        ///�ɽ�ʱ��
		//[Column("I23")]
        public Int32 TradeDate { get; set; }
        ///�ɽ�ʱ��
		//[Column("I24")]
        public Int32 TradeTime { get; set; }
        ///������
		//[Column("I25")]
        public double Commission { get; set; }
        ///���
		//[Column("I26")]
        public Int32 SequenceNo { get; set; }
        ///�����־
		//[Column("I27")]
        public char OwnerType { get; set; }
    };
	
    ///��ع���
    public class StpRiskRule // struct
    {
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///����ID
		//[Column("I2")]
        public Int32 RiskId { get; set; }
        ///�������
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
		[StringLength(CommonDef.STP_RULECODE_LEN)]
        public string RuleCode { get; set; } 
        ///��˾���
		//[Column("I4")]
        public Int32 CompanyID { get; set; }
        ///����������
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ���뼯��
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTIDS_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTIDS_LEN)]
        public string InstrumentIDs { get; set; } 
        ///֤ȯ���Ʋ㼶
		//[Column("I7")]
        public char InstrumentControlLevel { get; set; }
        ///֤ȯ��Χ
		//[Column("I8")]
        public char InstrumentRangeType { get; set; }
        ///֤ȯ���Ϸ��
		//[Column("I9")]
        public byte InstrumentUnionFlag { get; set; }
        ///�˻�����
		//[Column("I10")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTIDS_LEN)]
		[StringLength(CommonDef.STP_ACCOUNTIDS_LEN)]
        public string AccountIDs { get; set; } 
        ///�˻����Ͽ��Ʋ㼶
		//[Column("I11")]
        public char AccountControlLevel { get; set; }
        ///�˻����Ϸ�Χ
		//[Column("I12")]
        public char AccountRangeType { get; set; }
        ///Ͷ���˻����Ϸ��
		//[Column("I13")]
        public byte AccountUnionFlag { get; set; }
        ///��������
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULENAME_LEN)]
		[StringLength(CommonDef.STP_RULENAME_LEN)]
        public string RuleName { get; set; } 
        ///�Ƿ��Ծ
		//[Column("I15")]
        public Int32 IsActive { get; set; }
        ///�޸�������ϸ��json�ַ�����
		//[Column("I16")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
		[StringLength(CommonDef.STP_VALUE_LEN)]
        public string Value { get; set; } 
    };
	
    ///������ع�����־
    public class StpRiskRuleLog // struct
    {
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///���
		//[Column("I2")]
        public Int32 SequenceNo { get; set; }
        ///��˾���
		//[Column("I3")]
        public Int32 CompanyID { get; set; }
        ///��¼�ɹ�ʱ��
		//[Column("I4")]
        public Int32 ExecuteTime { get; set; }
        ///����ID
		//[Column("I5")]
        public Int32 RiskId { get; set; }
        ///�������
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
		[StringLength(CommonDef.STP_RULECODE_LEN)]
        public string RuleCode { get; set; } 
        ///��������
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULENAME_LEN)]
		[StringLength(CommonDef.STP_RULENAME_LEN)]
        public string RuleName { get; set; } 
        ///����������
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ���뼯��
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTIDS_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTIDS_LEN)]
        public string InstrumentIDs { get; set; } 
        ///�˻����
		//[Column("I10")]
        public Int32 AccountID { get; set; }
        ///��������
		//[Column("I11")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
		[StringLength(CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef { get; set; } 
        ///����ֵ
		//[Column("I12")]
        public double Threshold { get; set; }
        ///����ָ��ֵ
		//[Column("I13")]
        public double CalcValue { get; set; }
        ///������Ϣ
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
		[StringLength(CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg { get; set; } 
    };
	
    ///����Աָ��
    public class StpAdminCommand // struct
    {
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///���
		//[Column("I2")]
        public Int32 SequenceNo { get; set; }
        ///����Ա����
		//[Column("I3")]
        public Int32 OperatorID { get; set; }
        ///ָ�����
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADMINCODE_LEN)]
		[StringLength(CommonDef.STP_ADMINCODE_LEN)]
        public string AdminCode { get; set; } 
        ///�޸�������ϸ��json�ַ�����
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
		[StringLength(CommonDef.STP_VALUE_LEN)]
        public string Value { get; set; } 
        ///�������
		//[Column("I6")]
        public Int32 ErrorID { get; set; }
        ///������Ϣ
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
		[StringLength(CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg { get; set; } 
    };
	
    ///ָ����־
    public class StpOperationLog // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///����Ա����
		//[Column("I2")]
        public Int32 OperatorID { get; set; }
        ///Ͷ���ߴ���
		//[Column("I3")]
        public Int32 InvestorID { get; set; }
        ///��¼�ɹ�ʱ��
		//[Column("I4")]
        public Int32 ExecuteTime { get; set; }
        ///ָ�����
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADMINCODE_LEN)]
		[StringLength(CommonDef.STP_ADMINCODE_LEN)]
        public string AdminCode { get; set; } 
        ///�޸�������ϸ��json�ַ�����
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
		[StringLength(CommonDef.STP_VALUE_LEN)]
        public string Value { get; set; } 
        ///�������
		//[Column("I7")]
        public Int32 ErrorID { get; set; }
        ///������Ϣ
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
		[StringLength(CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg { get; set; } 
    };
	
    ///�ֱֲ䶯��־
    public class StpPosChangeLog // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///����Ա����
		//[Column("I2")]
        public Int32 OperatorID { get; set; }
        ///��������
		//[Column("I3")]
        public char OperationType { get; set; }
        ///�䶯����
		//[Column("I4")]
        public char ChangeType { get; set; }
        ///�˻����
		//[Column("I5")]
        public Int32 AccountID { get; set; }
        ///��ϱ��
		//[Column("I6")]
        public Int32 ComboID { get; set; }
        ///֤ȯ����
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///����������
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///���ұ�־
		//[Column("I9")]
        public char CoveredFlag { get; set; }
        ///�ֲֶ�շ���
		//[Column("I10")]
        public char PosiDirection { get; set; }
        ///��¼�ɹ�ʱ��
		//[Column("I11")]
        public Int32 ExecuteTime { get; set; }
        ///ԭʼֵ
		//[Column("I12")]
        public double OriginValue { get; set; }
        ///����ֵ
		//[Column("I13")]
        public double NewValue { get; set; }
        ///��ע
		//[Column("I14")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_MEMO_LEN)]
		[StringLength(CommonDef.STP_MEMO_LEN)]
        public string Memo { get; set; } 
    };
	
    ///�ʽ�䶯��־
    public class StpActChangeLog // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///����Ա����
		//[Column("I2")]
        public Int32 OperatorID { get; set; }
        ///��������
		//[Column("I3")]
        public char OperationType { get; set; }
        ///�䶯����
		//[Column("I4")]
        public char ChangeType { get; set; }
        ///�˻����
		//[Column("I5")]
        public Int32 AccountID { get; set; }
        ///��¼�ɹ�ʱ��
		//[Column("I6")]
        public Int32 ExecuteTime { get; set; }
        ///ԭʼֵ
		//[Column("I7")]
        public double OriginValue { get; set; }
        ///����ֵ
		//[Column("I8")]
        public double NewValue { get; set; }
        ///��ע
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_MEMO_LEN)]
		[StringLength(CommonDef.STP_MEMO_LEN)]
        public string Memo { get; set; } 
    };
	
    ///������Ϣ
    public class StpRspInfo // struct
    {
        ///�������
		//[Column("I1")]
        public Int32 ErrorID { get; set; }
        ///������־
		//[Column("I2")]
        public Int32 IsLast { get; set; }
        ///������Ϣ
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
		[StringLength(CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg { get; set; } 
    };
	
    ///��¼����
    public class StpUserLoginReq // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///����Ա����
		//[Column("I1")]
        public Int32 OperatorID { get; set; }
        ///����
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
		[StringLength(CommonDef.STP_PASSWORD_LEN)]
        public string Password { get; set; } 
    };
	
    ///��¼����
    public class StpLoginReq // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///����Ա����
		//[Column("I1")]
        public Int32 OperatorID { get; set; }
        ///����
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
		[StringLength(CommonDef.STP_PASSWORD_LEN)]
        public string Password { get; set; } 
        ///����IP
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
		[StringLength(CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP { get; set; } 
        ///����MAC
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
		[StringLength(CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC { get; set; } 
        ///����Ӳ�����к�
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
		[StringLength(CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum { get; set; } 
        ///����������
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
		[StringLength(CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode { get; set; } 
        ///��������ϵͳ
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
		[StringLength(CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS { get; set; } 
    };
	
    ///ע������
    public class StpLogoutReq // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///����Ա����
		//[Column("I1")]
        public Int32 OperatorID { get; set; }
    };
	
    ///����������Ӧ
    public class StpRspLogin // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///������
		//[Column("I1")]
        public Int32 TradingDay { get; set; }
        ///��¼�ɹ�ʱ��
		//[Column("I2")]
        public Int32 LoginTime { get; set; }
        ///����Ա����
		//[Column("I3")]
        public Int32 OperatorID { get; set; }
        ///ǰ�ñ��
		//[Column("I4")]
        public Int32 FrontID { get; set; }
        ///�Ự���
		//[Column("I5")]
        public Int32 SessionID { get; set; }
        ///��󱨵�����
		//[Column("I6")]
        public Int32 MaxOrderRef { get; set; }
    };
	
    ///����¼������
    public class StpOrderReq // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///����Ա����
		//[Column("I2")]
        public Int32 OperatorID { get; set; }
        ///��ϱ��
		//[Column("I3")]
        public Int32 ComboID { get; set; }
        ///֤ȯ����
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///��������
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
		[StringLength(CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef { get; set; } 
        ///����������
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///�����۸�����
		//[Column("I7")]
        public char OrderPriceType { get; set; }
        ///��������
		//[Column("I8")]
        public char Direction { get; set; }
        ///��ƽ��־
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBOFFSETFLAG_LEN)]
		[StringLength(CommonDef.STP_COMBOFFSETFLAG_LEN)]
        public string CombOffsetFlag { get; set; } 
        ///Ͷ���ױ���־
		//[Column("I10")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBHEDGEFLAG_LEN)]
		[StringLength(CommonDef.STP_COMBHEDGEFLAG_LEN)]
        public string CombHedgeFlag { get; set; } 
        ///���ұ�־
		//[Column("I11")]
        public char CoveredFlag { get; set; }
        ///�۸�
		//[Column("I12")]
        public double LimitPrice { get; set; }
        ///ԭʼ����
		//[Column("I13")]
        public Int32 VolumeTotalOriginal { get; set; }
        ///��Ч������
		//[Column("I14")]
        public char TimeCondition { get; set; }
        ///�ɽ�������
		//[Column("I15")]
        public char VolumeCondition { get; set; }
        ///Ԥ���ֶ�1
		//[Column("I16")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF1_LEN)]
		[StringLength(CommonDef.STP_THIRDREFF1_LEN)]
        public string ThirdReff1 { get; set; } 
        ///Ԥ���ֶ�2
		//[Column("I17")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF2_LEN)]
		[StringLength(CommonDef.STP_THIRDREFF2_LEN)]
        public string ThirdReff2 { get; set; } 
        ///����IP
		//[Column("I18")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
		[StringLength(CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP { get; set; } 
        ///����MAC
		//[Column("I19")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
		[StringLength(CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC { get; set; } 
        ///����Ӳ�����к�
		//[Column("I20")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
		[StringLength(CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum { get; set; } 
        ///����������
		//[Column("I21")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
		[StringLength(CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode { get; set; } 
        ///��������ϵͳ
		//[Column("I22")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
		[StringLength(CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS { get; set; } 
    };
	
    ///ȡ����������
    public class StpOrderCancelReq // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///����Ա����
		//[Column("I2")]
        public Int32 OperatorID { get; set; }
        ///����������
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERACTIONREF_LEN)]
		[StringLength(CommonDef.STP_ORDERACTIONREF_LEN)]
        public string OrderActionRef { get; set; } 
        ///���ر������
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
		[StringLength(CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
        ///����IP
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
		[StringLength(CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP { get; set; } 
        ///����MAC
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
		[StringLength(CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC { get; set; } 
        ///����Ӳ�����к�
		//[Column("I7")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
		[StringLength(CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum { get; set; } 
        ///����������
		//[Column("I8")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
		[StringLength(CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode { get; set; } 
        ///��������ϵͳ
		//[Column("I9")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
		[StringLength(CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS { get; set; } 
    };
	
    ///��ѯ�������
    public class StpQryRiskRule // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///����ID
		//[Column("I1")]
        public Int32 RiskId { get; set; }
        ///�������
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
		[StringLength(CommonDef.STP_RULECODE_LEN)]
        public string RuleCode { get; set; } 
    };
	
    ///��ѯ��Ʒ��Ϣ
    public class StpQryInstrument // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///����������
		//[Column("I1")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
    };
	
    ///��ѯ��Ʒ��������Ϣ
    public class StpQryCommissionRate // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///����������
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///��������
		//[Column("I4")]
        public char Direction { get; set; }
        ///��ƽ��־
		//[Column("I5")]
        public char OffsetFlag { get; set; }
        ///���ұ�־
		//[Column("I6")]
        public char CoveredFlag { get; set; }
        ///Ͷ���ױ���־
		//[Column("I7")]
        public char HedgeFlag { get; set; }
    };
	
    ///��ѯ��Ʒ��֤������Ϣ
    public class StpQryMarginRate // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///����������
		//[Column("I2")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///��������
		//[Column("I4")]
        public char Direction { get; set; }
        ///��ƽ��־
		//[Column("I5")]
        public char OffsetFlag { get; set; }
        ///���ұ�־
		//[Column("I6")]
        public char CoveredFlag { get; set; }
        ///Ͷ���ױ���־
		//[Column("I7")]
        public char HedgeFlag { get; set; }
    };
	
    ///��ѯ����
    public class StpQryOrder // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///��ϱ��
		//[Column("I2")]
        public Int32 ComboID { get; set; }
        ///����������
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///���ر������
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
		[StringLength(CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
    };
	
    ///��ѯ�ɽ�
    public class StpQryTrade // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///��ϱ��
		//[Column("I2")]
        public Int32 ComboID { get; set; }
        ///����������
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///�ɽ����
		//[Column("I5")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
		[StringLength(CommonDef.STP_TRADEID_LEN)]
        public string TradeID { get; set; } 
        ///���ر������
		//[Column("I6")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
		[StringLength(CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
    };
	
    ///��ѯ�˻��ʽ�
    public class StpQryAccountAsset // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
    };
	
    ///��ѯ�˻�������Ϣ
    public class StpQryAccount // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///��ѯ�˻�����
		//[Column("I2")]
        public char QryAccountType { get; set; }
    };
	
    ///��ѯͶ���ֲ߳�
    public class StpQryPosition // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///��ϱ��
		//[Column("I2")]
        public Int32 ComboID { get; set; }
        ///����������
		//[Column("I3")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
		[StringLength(CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
		//[Column("I4")]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
		[StringLength(CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
    };
	
    ///��ѯͶ�����
    public class StpQryCombo // struct
    {
        [Key]
        public Int64 SmallSysId { get; set; }
	  
        ///�˻����
		//[Column("I1")]
        public Int32 AccountID { get; set; }
        ///��ϱ��
		//[Column("I2")]
        public Int32 ComboID { get; set; }
    };
	
}
  