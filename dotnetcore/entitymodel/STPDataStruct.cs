
using System;
using System.Runtime.InteropServices;

namespace SmallPB.entitymodel
{
    ///��������
    public class StpTradeDate // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///��һ������
        public Int32 NextTradingDay { get; set; }
        ///ϵͳ״̬
        public char SystemStatus { get; set; }
    };
    
    ///��Ȩ��Լ
    public class StpInstrument // struct
    {
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///��Ʒ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///֤ȯ���״���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTCODE_LEN)]
        public string InstrumentCode { get; set; } 
        ///��Լ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTNAME_LEN)]
        public string InstrumentName { get; set; } 
        ///֤ȯ���
        public char ProductClass { get; set; }
        ///��Լ��������
        public Int32 VolumeMultiple { get; set; }
        ///��С�䶯��λ
        public double PriceTick { get; set; }
        ///������
        public Int32 OpenDate { get; set; }
        ///������
        public Int32 ExpireDate { get; set; }
        ///��ǰ�Ƿ���
        public Int32 IsTrading { get; set; }
        ///��Ȩִ�м۸�
        public double ExecPrice { get; set; }
        ///��Ȩ���ֱ�֤��
        public double UnitMargin { get; set; }
        ///������
        public Int32 TradingDay { get; set; }
        ///��Ȩ��
        public Int32 ExerciseDay { get; set; }
        ///��ʼ������
        public Int32 StartDeliveryDay { get; set; }
        ///����������
        public Int32 EndDeliveryDay { get; set; }
        ///�м�����µ���
        public Int32 MaxMarketOrderVolume { get; set; }
        ///�м���С�µ���
        public Int32 MinMarketOrderVolume { get; set; }
        ///�޼�����µ���
        public Int32 MaxLimitOrderVolume { get; set; }
        ///�޼���С�µ���
        public Int32 MinLimitOrderVolume { get; set; }
        ///��ͣ���
        public double UpperLimitPrice { get; set; }
        ///��ͣ���
        public double LowerLimitPrice { get; set; }
        ///��Ȩ����
        public char OptionType { get; set; }
        ///��С����䶯����
        public Int32 BuyVolumeTick { get; set; }
        ///��С�����䶯����
        public Int32 SellVolumeTick { get; set; }
        ///������Ʒ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_UNDERLYINGINSTRUMENTID_LEN)]
        public string UnderlyingInstrumentID { get; set; } 
        ///������Ʒ����
        public Int32 UnderlyingMultiple { get; set; }
        ///�ر�֤ȯ��־
        public char StockRealBack { get; set; }
        ///�ر��ʽ��־
        public char FundRealBack { get; set; }
    };
    
    ///��˾��Ϣ
    public class StpCompany // struct
    {
        ///��˾���
        public Int32 CompanyID { get; set; }
        ///��˾����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMPANYNAME_LEN)]
        public string CompanyName { get; set; } 
        ///��˾����
        public char CompanyType { get; set; }
        ///��ϵ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LINKMAN_LEN)]
        public string LinkMan { get; set; } 
        ///��ϵ��ַ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADDRESS_LEN)]
        public string Address { get; set; } 
        ///��ϵ�绰
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TEL_LEN)]
        public string Tel { get; set; } 
        ///��������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EMAIL_LEN)]
        public string Email { get; set; } 
    };
    
    ///��˾����Ա��Ϣ
    public class StpOperator // struct
    {
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///��˾���
        public Int32 CompanyID { get; set; }
        ///����Ա����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPERATORNAME_LEN)]
        public string OperatorName { get; set; } 
        ///����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
        public string Password { get; set; } 
        ///����Ա��ɫ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPROLES_LEN)]
        public string OpRoles { get; set; } 
        ///(�ѷϳ�)����Ա���Բ�ѯ���˻�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_QRYACCOUNTIDS_LEN)]
        public string QryAccountIDs { get; set; } 
        ///(�ѷϳ�)����Ա���Բ������˻�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPACCOUNTIDS_LEN)]
        public string OpAccountIDs { get; set; } 
        ///����Ա���Բ�ѯ����ϼ���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_QRYCOMBOIDS_LEN)]
        public string QryComboIDs { get; set; } 
        ///����Ա���Բ�������ϼ���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPCOMBOIDS_LEN)]
        public string OpComboIDs { get; set; } 
        ///����Ա�绰
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPTEL_LEN)]
        public string OpTel { get; set; } 
        ///����Ա����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPEMAIL_LEN)]
        public string OpEmail { get; set; } 
        ///ע��ʱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REGIDATE_LEN)]
        public string RegiDate { get; set; } 
        ///״̬��־
        public char EnbFlag { get; set; }
        ///�޸�ʱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_UPTTIME_LEN)]
        public string UptTime { get; set; } 
        ///��¼ʱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LOGTIME_LEN)]
        public string LogTime { get; set; } 
        ///�����޸�ʱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PWDUPTTIME_LEN)]
        public string PwdUptTime { get; set; } 
        ///��¼����ʱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LOGERRTIME_LEN)]
        public string LogErrTime { get; set; } 
        ///����������
        public Int32 PwdErrCnt { get; set; }
        ///��ע
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REMARK_LEN)]
        public string Remark { get; set; } 
        ///��˾����
        public char CompanyType { get; set; }
    };
    
    ///ϵͳȨ����Ϣ
    public class StpAuthInfo // struct
    {
        ///Ȩ��ID
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
        public string AuthID { get; set; } 
        ///Ȩ�޼���
        public Int32 AuthLevel { get; set; }
        ///Ȩ������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHDESC_LEN)]
        public string AuthDesc { get; set; } 
        ///��Ȩ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PARENTID_LEN)]
        public string ParentID { get; set; } 
        ///�Ƿ����¼�Ȩ��
        public Int32 HaveSon { get; set; }
        ///˳���
        public Int32 ID { get; set; }
        ///״̬��־
        public char EnbFlag { get; set; }
        ///ȱʡ״̬
        public Int32 IsDefault { get; set; }
        ///Ȩ���Ƿ���Ϊ������ʾ�ڿ�̨
        public Int32 IsDisplay { get; set; }
        ///����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTION_LEN)]
        public string Action { get; set; } 
        ///����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RESV_LEN)]
        public string Resv { get; set; } 
        ///����ʱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CRTTIME_LEN)]
        public string CrtTime { get; set; } 
        ///���һ�θ���ʱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUPTTIME_LEN)]
        public string LastUptTime { get; set; } 
        ///��������
        public char ActionType { get; set; }
        ///Ȩ������
        public char AuthType { get; set; }
    };
    
    ///����ԱȨ����Ϣ
    public class StpOpAuthInfo // struct
    {
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///Ȩ��ID
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
        public string AuthID { get; set; } 
        ///״̬��־
        public char EnbFlag { get; set; }
        ///���һ��ʹ��ʱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUSRTIME_LEN)]
        public string LastUsrTime { get; set; } 
        ///ʹ�ô���
        public Int32 UsrCount { get; set; }
        ///����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RESV_LEN)]
        public string Resv { get; set; } 
        ///����ʱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CRTTIME_LEN)]
        public string CrtTime { get; set; } 
        ///���һ�θ���ʱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUPTTIME_LEN)]
        public string LastUptTime { get; set; } 
    };
    
    ///�ӿ�Ȩ��
    public class StpIntefAuthInfo // struct
    {
        ///�ӿڱ�ʶ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CMDID_LEN)]
        public string CmdID { get; set; } 
        ///Ȩ��ID
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
        public string AuthID { get; set; } 
    };
    
    ///����Ա��־
    public class StpOpLog // struct
    {
        ///ϵͳ����
        public Int32 SysDate { get; set; }
        ///ϵͳʱ��
        public Int32 SysTime { get; set; }
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTION_LEN)]
        public string Action { get; set; } 
        ///��������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTIONDESC_LEN)]
        public string ActionDesc { get; set; } 
    };
    
    ///��ɫ��Ϣ
    public class StpRole // struct
    {
        ///��ɫ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLEID_LEN)]
        public string RoleID { get; set; } 
        ///��ɫ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLENAME_LEN)]
        public string RoleName { get; set; } 
        ///��˾����
        public char CompanyType { get; set; }
    };
    
    ///��ɫȨ����Ϣ
    public class StpRoleAuth // struct
    {
        ///��ɫ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLEID_LEN)]
        public string RoleID { get; set; } 
        ///Ȩ��ID
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
        public string AuthID { get; set; } 
    };
    
    ///�����ļ��б�
    public class StpFileDownload // struct
    {
        ///ϵͳ����
        public Int32 SysDate { get; set; }
        ///ϵͳ��ˮ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSSEQID_LEN)]
        public string SysSeqID { get; set; } 
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///�ļ�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILENAME_LEN)]
        public string FileName { get; set; } 
        ///�ļ��洢·��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEURL_LEN)]
        public string FileUrl { get; set; } 
        ///�ļ���ѯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEINFO_LEN)]
        public string FileInfo { get; set; } 
        ///����ִ��״̬
        public char FileFlag { get; set; }
        ///��׺�ļ�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEPOSTFIX_LEN)]
        public string FilePostFix { get; set; } 
        ///�ļ���������
        public Int32 CreateDate { get; set; }
        ///�ļ�����ʱ��
        public Int32 CreateTime { get; set; }
        ///��������
        public Int32 UpdateDate { get; set; }
        ///����޸�ʱ��
        public Int32 UpdateTime { get; set; }
    };
    
    ///��̨���б�
    public class StpCmdSequence // struct
    {
        ///��������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEQNAME_LEN)]
        public string SeqName { get; set; } 
        ///��ǰ����ֵ
        public Int32 CurrentVal { get; set; }
        ///��ǰ����ֵ
        public Int32 IncrementVal { get; set; }
    };
    
    ///����Ա����������Ϣ
    public class StpOpMarket // struct
    {
        ///��˾���
        public Int32 CompanyID { get; set; }
        ///������������
        public char MarketDataType { get; set; }
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///�������Ӹ���
        public Int32 LimitConNum { get; set; }
        ///�����ĸ���
        public Int32 LimitSubNum { get; set; }
        ///����IP��ַ������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_IPADDRESS_LEN)]
        public string IpAddress { get; set; } 
    };
    
    ///��˾����ɷ���Ϣ
    public class StpMarketDataPay // struct
    {
        ///��˾���
        public Int32 CompanyID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///�ɷѿ�Ŀ
        public char PaySubject { get; set; }
        ///����ɷ�ʱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTPAYTIME_LEN)]
        public string LastPayTime { get; set; } 
        ///�ɷѽ��
        public double PayBalance { get; set; }
        ///��ʼ����
        public Int32 StartDate { get; set; }
        ///��������
        public Int32 EndDate { get; set; }
    };
    
    ///��˾����ɷ���ˮ
    public class StpMarketDataPayFlow // struct
    {
        ///��ˮ���
        public Int32 PayID { get; set; }
        ///��˾���
        public Int32 CompanyID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///�ɷѿ�Ŀ
        public char PaySubject { get; set; }
        ///�ɷ�ʱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PAYTIME_LEN)]
        public string PayTime { get; set; } 
        ///�ɷѽ��
        public double PayBalance { get; set; }
        ///��ʼ����
        public Int32 StartDate { get; set; }
        ///��������
        public Int32 EndDate { get; set; }
    };
    
    ///�˻���Ϣ
    public class StpAccount // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///��˾���
        public Int32 CompanyID { get; set; }
        ///�ʽ��˻�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName { get; set; } 
        ///Ͷ���ߴ���
        public Int32 InvestorID { get; set; }
        ///�˻�����
        public char AccountType { get; set; }
        ///״̬��־
        public char EnbFlag { get; set; }
        ///������
        public Int32 TradingDay { get; set; }
        ///����ͨ�����
        public Int32 ChannelID { get; set; }
        ///Ĭ�����
        public Int32 DefaultCombo { get; set; }
    };
    
    ///Ͷ�����
    public class StpAccountCombo // struct
    {
        ///��ϱ��
        public Int32 ComboID { get; set; }
        ///�˻����
        public Int32 AccountID { get; set; }
        ///�������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBONAME_LEN)]
        public string ComboName { get; set; } 
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///Ͷ����϶�Ӧ�ĺ�Լ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_KEYINSTRUMENTID_LEN)]
        public string KeyInstrumentID { get; set; } 
        ///�Ƿ��Ծ
        public Int32 IsActive { get; set; }
        ///ȱʡ״̬
        public Int32 IsDefault { get; set; }
        ///������
        public Int32 TradingDay { get; set; }
        ///�������ڽ���
        public byte DayTradeEnable { get; set; }
    };
    
    ///Ͷ������Ϣ
    public class StpInvestor // struct
    {
        ///Ͷ���ߴ���
        public Int32 InvestorID { get; set; }
        ///������
        public Int32 TradingDay { get; set; }
        ///���͹�˾����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BROKERID_LEN)]
        public string BrokerID { get; set; } 
        ///ĸ�˻�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BROKERINVESTORID_LEN)]
        public string BrokerInvestorID { get; set; } 
        ///�û�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_USERID_LEN)]
        public string UserID { get; set; } 
        ///�ͻ���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CLIENTID_LEN)]
        public string ClientID { get; set; } 
        ///�ʽ��˻�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTCODE_LEN)]
        public string AccountCode { get; set; } 
        ///����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
        public string Password { get; set; } 
        ///Ͷ��������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INVESTORNAME_LEN)]
        public string InvestorName { get; set; } 
        ///Ͷ��������
        public char InvestorType { get; set; }
        ///֤������
        public char IDCardType { get; set; }
        ///֤����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_IDCARDNO_LEN)]
        public string IDCardNo { get; set; } 
        ///�Ƿ��Ծ
        public Int32 IsActive { get; set; }
        ///������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_GROUPID_LEN)]
        public string GroupID { get; set; } 
        ///O32����Ա����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32OPERATORNO_LEN)]
        public string O32OperatorNo { get; set; } 
        ///O32����Ա����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32OPERATORPWD_LEN)]
        public string O32OperatorPwd { get; set; } 
        ///O32�������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32ACCOUNTCODE_LEN)]
        public string O32AccountCode { get; set; } 
        ///O32��ϱ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32COMBINO_LEN)]
        public string O32CombiNo { get; set; } 
        ///O32�ʲ���Ԫ���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32ASSETNO_LEN)]
        public string O32AssetNo { get; set; } 
    };
    
    ///Ͷ���߽��ױ���
    public class StpTradingCode // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///�˻����
        public Int32 AccountID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///���ױ�������
        public char TradingCodeType { get; set; }
        ///���ױ���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///Ӫҵ������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
        public string BranchID { get; set; } 
        ///ϯλ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
        public string SeatID { get; set; } 
        ///Ͷ�����˻��ӱ���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPTCLIENTID_LEN)]
        public string OptClientID { get; set; } 
        ///�Ƿ��Ծ
        public Int32 IsActive { get; set; }
    };
    
    ///����ͨ����Ϣ
    public class StpTradeChannel // struct
    {
        ///����ͨ�����
        public Int32 ChannelID { get; set; }
        ///ͨ������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CHANNELNAME_LEN)]
        public string ChannelName { get; set; } 
        ///ͨ������
        public char ChannelType { get; set; }
        ///�ֲֽӿ�IP
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSIP_LEN)]
        public string SysIP { get; set; } 
        ///�ֲֽӿڶ˿�
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSPORT_LEN)]
        public string SysPort { get; set; } 
        ///�ֲ���������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CHANNELCONFIG_LEN)]
        public string ChannelConfig { get; set; } 
        ///������
        public Int32 TradingDay { get; set; }
    };
    
    ///�˻��ʽ���Ϣ
    public class StpAccountAsset // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///�˻����
        public Int32 AccountID { get; set; }
        ///���ִ���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CURRENCYID_LEN)]
        public string CurrencyID { get; set; } 
        ///�ϴδ���
        public double PreDeposit { get; set; }
        ///�ϴ�ռ�õı�֤��
        public double PreMargin { get; set; }
        ///�ϴν���׼����
        public double PreBalance { get; set; }
        ///��ǰ�ʽ�
        public double Balance { get; set; }
        ///�����
        public double Deposit { get; set; }
        ///����ı�֤��
        public double FrozenMargin { get; set; }
        ///�����������
        public double FrozenCommission { get; set; }
        ///������ʽ�
        public double FrozenCash { get; set; }
        ///�ֹ�������ʽ�
        public double ManualFrozenCash { get; set; }
        ///�˶Ե����ʽ�
        public double CheckCash { get; set; }
        ///��λռ�ñ�֤��
        public double UseMargin { get; set; }
        ///������
        public double Commission { get; set; }
        ///��ȡ�ʽ�
        public double WithdrawQuota { get; set; }
        ///��֤��������
        public double Credit { get; set; }
        ///�ֽ�
        public double Available { get; set; }
        ///ƽ��ӯ��
        public double CloseProfit { get; set; }
        ///�ֲ�ӯ��
        public double PositionProfit { get; set; }
        ///�ʽ���
        public double CashIn { get; set; }
        ///������
        public double CashOut { get; set; }
        ///ȱʡ״̬
        public Int32 IsDefault { get; set; }
    };
    
    ///��ѯ�˻��ʽ���Ϣ
    public class StpUserAccountAsset // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///�ʽ��˻�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName { get; set; } 
        ///��ǰ�ʽ�
        public double Balance { get; set; }
        ///�����ʽ�
        public double EnableBalance { get; set; }
        ///������ʽ�
        public double FrozenCash { get; set; }
        ///�ֹ�������ʽ�
        public double ManualFrozenCash { get; set; }
        ///�˶Ե����ʽ�
        public double CheckCash { get; set; }
    };
    
    ///�˻��ֲ���Ϣ
    public class StpAccountPosition // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///���ұ�־
        public char CoveredFlag { get; set; }
        ///�ֲֶ�շ���
        public char PosiDirection { get; set; }
        ///���ױ���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///���ױ�������
        public char TradingCodeType { get; set; }
        ///������
        public Int32 TradingDay { get; set; }
        ///���ճֲ�
        public double YdPosition { get; set; }
        ///�ϴ�ռ�õı�֤��
        public double PreMargin { get; set; }
        ///��ֲ�
        public double TodayPosition { get; set; }
        ///�ֲܳ�
        public double TotalPosition { get; set; }
        ///��λռ�ñ�֤��
        public double UseMargin { get; set; }
        ///������
        public double OpenVolume { get; set; }
        ///ƽ����
        public double CloseVolume { get; set; }
        ///ƽ�����
        public double CloseYdVolume { get; set; }
        ///���ν����
        public double SettlementPrice { get; set; }
        ///�ϴν����
        public double PreSettlementPrice { get; set; }
        ///������
        public double Commission { get; set; }
        ///�����������
        public double FrozenCommission { get; set; }
        ///����ı�֤��
        public double FrozenMargin { get; set; }
        ///���ֳɱ�
        public double OpenCost { get; set; }
        ///�ֲֳɱ�
        public double PositionCost { get; set; }
        ///ƽ��ӯ��
        public double CloseProfit { get; set; }
        ///�ֲ�ӯ��
        public double PositionProfit { get; set; }
        ///���ֽ��
        public double OpenAmount { get; set; }
        ///ƽ�ֽ��
        public double CloseAmount { get; set; }
        ///ƽ��ֽ��
        public double CloseYdAmount { get; set; }
        ///��ͷ����
        public double LongFrozen { get; set; }
        ///���ֶ�����
        public double LongFrozenAmount { get; set; }
        ///��ͷ����
        public double ShortFrozen { get; set; }
        ///���ֶ�����
        public double ShortFrozenAmount { get; set; }
        ///��������
        public double FrozenVolume { get; set; }
        ///�ֹ���������
        public double ManualFrozenVolume { get; set; }
        ///�˶Ե�������
        public double CheckVolume { get; set; }
        ///��������
        public double EnableVolume { get; set; }
    };
    
    ///��ѯ��ϳֲ���Ϣ
    public class StpUserComboPosition // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///�ʽ��˻�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName { get; set; } 
        ///��ϱ��
        public Int32 ComboID { get; set; }
        ///�������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBONAME_LEN)]
        public string ComboName { get; set; } 
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///��Լ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTNAME_LEN)]
        public string InstrumentName { get; set; } 
        ///�ֲܳ�
        public double TotalPosition { get; set; }
        ///��������
        public double FrozenVolume { get; set; }
        ///�ֹ���������
        public double ManualFrozenVolume { get; set; }
        ///�˶Ե�������
        public double CheckVolume { get; set; }
        ///��������
        public double EnableVolume { get; set; }
        ///�ֲֳɱ�
        public double PositionCost { get; set; }
        ///�ɱ���
        public double CostPrice { get; set; }
        ///���¼�
        public double LastPrice { get; set; }
        ///�ֲ���ֵ
        public double OpenMarketValue { get; set; }
        ///����ӯ��
        public double FloatProfi { get; set; }
        ///��ͷ����
        public double LongFrozen { get; set; }
        ///��ͷ����
        public double ShortFrozen { get; set; }
        ///���ڳ�ʼ����
        public Int32 DayTradeInitVolume { get; set; }
        ///���ڿ�������
        public Int32 DayTradeAvailVolume { get; set; }
        ///����ӯ��
        public double DayTradeFloatProfitLoss { get; set; }
        ///���ڳֲֳɱ���
        public double DayTradePositionCost { get; set; }
        ///����ƽ��ӯ��
        public double DayTradeCloseProfit { get; set; }
        ///��������
        public double DayTradeAccumBuy { get; set; }
        ///��������
        public double DayTradeAccumSell { get; set; }
    };
    
    ///��ϳֲ���Ϣ
    public class StpComboPosition // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///��ϱ��
        public Int32 ComboID { get; set; }
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///���ұ�־
        public char CoveredFlag { get; set; }
        ///�ֲֶ�շ���
        public char PosiDirection { get; set; }
        ///���ױ���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///���ױ�������
        public char TradingCodeType { get; set; }
        ///������
        public Int32 TradingDay { get; set; }
        ///���ճֲ�
        public double YdPosition { get; set; }
        ///�ϴ�ռ�õı�֤��
        public double PreMargin { get; set; }
        ///��ֲ�
        public double TodayPosition { get; set; }
        ///�ֲܳ�
        public double TotalPosition { get; set; }
        ///��λռ�ñ�֤��
        public double UseMargin { get; set; }
        ///������
        public double OpenVolume { get; set; }
        ///ƽ����
        public double CloseVolume { get; set; }
        ///ƽ�����
        public double CloseYdVolume { get; set; }
        ///���ν����
        public double SettlementPrice { get; set; }
        ///�ϴν����
        public double PreSettlementPrice { get; set; }
        ///������
        public double Commission { get; set; }
        ///�����������
        public double FrozenCommission { get; set; }
        ///����ı�֤��
        public double FrozenMargin { get; set; }
        ///���ֳɱ�
        public double OpenCost { get; set; }
        ///�ֲֳɱ�
        public double PositionCost { get; set; }
        ///ƽ��ӯ��
        public double CloseProfit { get; set; }
        ///�ֲ�ӯ��
        public double PositionProfit { get; set; }
        ///���ֽ��
        public double OpenAmount { get; set; }
        ///ƽ�ֽ��
        public double CloseAmount { get; set; }
        ///ƽ��ֽ��
        public double CloseYdAmount { get; set; }
        ///��ͷ����
        public double LongFrozen { get; set; }
        ///���ֶ�����
        public double LongFrozenAmount { get; set; }
        ///��ͷ����
        public double ShortFrozen { get; set; }
        ///���ֶ�����
        public double ShortFrozenAmount { get; set; }
        ///��������
        public double FrozenVolume { get; set; }
        ///�ֹ���������
        public double ManualFrozenVolume { get; set; }
        ///�˶Ե�������
        public double CheckVolume { get; set; }
        ///��������
        public double EnableVolume { get; set; }
        ///���ڳ�ʼ����
        public Int32 DayTradeInitVolume { get; set; }
        ///���ڿ�������
        public Int32 DayTradeAvailVolume { get; set; }
        ///����ӯ��
        public double DayTradeFloatProfitLoss { get; set; }
        ///���ڳֲֳɱ���
        public double DayTradePositionCost { get; set; }
        ///����ƽ��ӯ��
        public double DayTradeCloseProfit { get; set; }
        ///��������
        public double DayTradeAccumBuy { get; set; }
        ///��������
        public double DayTradeAccumSell { get; set; }
    };
    
    ///���ڳֲֵ���
    public class StpDayTradePositionAdjReq // struct
    {
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///�˻����
        public Int32 AccountID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///��ϱ��
        public Int32 ComboID { get; set; }
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///���ڵ�������
        public Int32 DayTradePositionAdjAmount { get; set; }
        ///���ڵ��ּ۸�
        public double DayTradePositionAdjCost { get; set; }
        ///������Ϣ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPERATEMSG_LEN)]
        public string OperateMsg { get; set; } 
    };
    
    ///�˻��ֲ���ϸ
    public class StpAccountPositionDtl // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///��ϱ��
        public Int32 ComboID { get; set; }
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///���ұ�־
        public char CoveredFlag { get; set; }
        ///�ֲֶ�շ���
        public char PosiDirection { get; set; }
        ///������
        public Int32 OpenDate { get; set; }
        ///�ɽ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
        public string TradeID { get; set; } 
        ///���ױ���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///���ױ�������
        public char TradingCodeType { get; set; }
        ///������
        public Int32 TradingDay { get; set; }
        ///�ɽ���
        public Int32 Volume { get; set; }
        ///���ν����
        public double SettlementPrice { get; set; }
        ///�ϴν����
        public double PreSettlementPrice { get; set; }
        ///����
        public double OpenPrice { get; set; }
        ///Ͷ���߱�֤��
        public double Margin { get; set; }
        ///Ͷ���߱�֤����
        public double MarginRate { get; set; }
        ///ƽ����
        public double CloseVolume { get; set; }
        ///ƽ�ֽ��
        public double CloseAmount { get; set; }
    };
    
    ///����������Ϣ
    public class StpFeeSet // struct
    {
        ///��˾���
        public Int32 CompanyID { get; set; }
        ///�˻����
        public Int32 AccountID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///֤ȯ���
        public char ProductClass { get; set; }
        ///��Ʒ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID { get; set; } 
        ///��������
        public char Direction { get; set; }
        ///��ƽ��־
        public char OffsetFlag { get; set; }
        ///���ұ�־
        public char CoveredFlag { get; set; }
        ///Ͷ���ױ���־
        public char HedgeFlag { get; set; }
        ///�������
        public char FeeType { get; set; }
        ///���ð��ɽ�������
        public double BalanceRatio { get; set; }
        ///���ð��ɽ���ֵ����
        public double FaceValueRatio { get; set; }
        ///���ð��ɽ���������
        public double AmountRatio { get; set; }
        ///����շ�
        public double MaxFee { get; set; }
        ///����շ�
        public double MinFee { get; set; }
        ///���ü���ģʽ
        public char CalculateType { get; set; }
        ///������
        public Int32 TradingDay { get; set; }
    };
    
    ///��֤����
    public class StpMarginRate // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///�˻����
        public Int32 AccountID { get; set; }
        ///Ͷ���߷�Χ
        public char InvestorRange { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///���ұ�־
        public char CoveredFlag { get; set; }
        ///Ͷ���ױ���־
        public char HedgeFlag { get; set; }
        ///��Ȩ����
        public char OptionType { get; set; }
        ///֤ȯ���
        public char ProductClass { get; set; }
        ///��Ʒ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID { get; set; } 
        ///��ͷ��֤����
        public double LongMarginRatioByMoney { get; set; }
        ///��ͷ��֤���
        public double LongMarginRatioByVolume { get; set; }
        ///��ͷ��֤����
        public double ShortMarginRatioByMoney { get; set; }
        ///��ͷ��֤���
        public double ShortMarginRatioByVolume { get; set; }
        ///�Ƿ񰴱����ϸ�
        public Int32 IsFloat { get; set; }
    };
    
    ///����
    public class StpOrder // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///�˻����
        public Int32 AccountID { get; set; }
        ///��ϱ��
        public Int32 ComboID { get; set; }
        ///�Ự���
        public Int32 SessionID { get; set; }
        ///ǰ�ñ��
        public Int32 FrontID { get; set; }
        ///��������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef { get; set; } 
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///ϯλ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
        public string SeatID { get; set; } 
        ///���ر������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
        ///��������
        public char Direction { get; set; }
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///���ױ���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///Ӫҵ������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
        public string BranchID { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///�����۸�����
        public char OrderPriceType { get; set; }
        ///��ƽ��־
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBOFFSETFLAG_LEN)]
        public string CombOffsetFlag { get; set; } 
        ///Ͷ���ױ���־
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBHEDGEFLAG_LEN)]
        public string CombHedgeFlag { get; set; } 
        ///���ұ�־
        public char CoveredFlag { get; set; }
        ///�۸�
        public double LimitPrice { get; set; }
        ///ԭʼ����
        public Int32 VolumeTotalOriginal { get; set; }
        ///��Ч������
        public char TimeCondition { get; set; }
        ///�ɽ�������
        public char VolumeCondition { get; set; }
        ///��С�ɽ���
        public Int32 MinVolume { get; set; }
        ///��������
        public char ContingentCondition { get; set; }
        ///ֹ���
        public double StopPrice { get; set; }
        ///������
        public Int32 ORRequestID { get; set; }
        ///�������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERSYSID_LEN)]
        public string OrderSysID { get; set; } 
        ///����״̬
        public char OrderStatus { get; set; }
        ///��������
        public char OrderType { get; set; }
        ///��ɽ�����
        public Int32 VolumeTraded { get; set; }
        ///��ɽ����
        public double AmountTraded { get; set; }
        ///ʣ������
        public Int32 VolumeRemain { get; set; }
        ///��������
        public Int32 InsertDate { get; set; }
        ///ί��ʱ��
        public Int32 InsertTime { get; set; }
        ///����޸�ʱ��
        public Int32 UpdateTime { get; set; }
        ///����ʱ��
        public Int32 CancelTime { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERACTIONREF_LEN)]
        public string OrderActionRef { get; set; } 
        ///״̬��Ϣ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_STATUSMSG_LEN)]
        public string StatusMsg { get; set; } 
        ///�����־
        public char OwnerType { get; set; }
        ///Ԥ���ֶ�1
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF1_LEN)]
        public string ThirdReff1 { get; set; } 
        ///Ԥ���ֶ�2
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF2_LEN)]
        public string ThirdReff2 { get; set; } 
        ///����\�ϵ�����
        public Int32 VolumeCanceled { get; set; }
        ///��ע
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REMARK_LEN)]
        public string Remark { get; set; } 
        ///������־
        public char CancelFlag { get; set; }
        ///����IP
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP { get; set; } 
        ///����MAC
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC { get; set; } 
        ///����Ӳ�����к�
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum { get; set; } 
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode { get; set; } 
        ///��������ϵͳ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS { get; set; } 
        ///��ǰ�ʽ�
        public double Balance { get; set; }
        ///������
        public double Commission { get; set; }
    };
    
    ///�ɽ�
    public class StpTrade // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///�˻����
        public Int32 AccountID { get; set; }
        ///��ϱ��
        public Int32 ComboID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///�ɽ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
        public string TradeID { get; set; } 
        ///��������
        public char Direction { get; set; }
        ///���ױ���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode { get; set; } 
        ///ϯλ��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
        public string SeatID { get; set; } 
        ///Ӫҵ������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
        public string BranchID { get; set; } 
        ///֤ȯ���״���
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTCODE_LEN)]
        public string InstrumentCode { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///������
        public Int32 ORRequestID { get; set; }
        ///�������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERSYSID_LEN)]
        public string OrderSysID { get; set; } 
        ///���ر������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
        ///��������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef { get; set; } 
        ///��ƽ��־
        public char OffsetFlag { get; set; }
        ///���ұ�־
        public char CoveredFlag { get; set; }
        ///Ͷ���ױ���־
        public char HedgeFlag { get; set; }
        ///�۸�
        public double Price { get; set; }
        ///�ɽ���
        public Int32 Volume { get; set; }
        ///�ɽ����
        public double TradeAmount { get; set; }
        ///�ɽ�ʱ��
        public Int32 TradeDate { get; set; }
        ///�ɽ�ʱ��
        public Int32 TradeTime { get; set; }
        ///������
        public double Commission { get; set; }
        ///���
        public Int32 SequenceNo { get; set; }
        ///�����־
        public char OwnerType { get; set; }
    };
    
    ///��ع���
    public class StpRiskRule // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///����ID
        public Int32 RiskId { get; set; }
        ///�������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
        public string RuleCode { get; set; } 
        ///��˾���
        public Int32 CompanyID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ���뼯��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTIDS_LEN)]
        public string InstrumentIDs { get; set; } 
        ///֤ȯ���Ʋ㼶
        public char InstrumentControlLevel { get; set; }
        ///֤ȯ��Χ
        public char InstrumentRangeType { get; set; }
        ///֤ȯ���Ϸ��
        public byte InstrumentUnionFlag { get; set; }
        ///�˻�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTIDS_LEN)]
        public string AccountIDs { get; set; } 
        ///�˻����Ͽ��Ʋ㼶
        public char AccountControlLevel { get; set; }
        ///�˻����Ϸ�Χ
        public char AccountRangeType { get; set; }
        ///Ͷ���˻����Ϸ��
        public byte AccountUnionFlag { get; set; }
        ///��������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULENAME_LEN)]
        public string RuleName { get; set; } 
        ///�Ƿ��Ծ
        public Int32 IsActive { get; set; }
        ///�޸�������ϸ��json�ַ�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
        public string Value { get; set; } 
    };
    
    ///������ع�����־
    public class StpRiskRuleLog // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///���
        public Int32 SequenceNo { get; set; }
        ///��˾���
        public Int32 CompanyID { get; set; }
        ///��¼�ɹ�ʱ��
        public Int32 ExecuteTime { get; set; }
        ///����ID
        public Int32 RiskId { get; set; }
        ///�������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
        public string RuleCode { get; set; } 
        ///��������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULENAME_LEN)]
        public string RuleName { get; set; } 
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ���뼯��
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTIDS_LEN)]
        public string InstrumentIDs { get; set; } 
        ///�˻����
        public Int32 AccountID { get; set; }
        ///��������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef { get; set; } 
        ///����ֵ
        public double Threshold { get; set; }
        ///����ָ��ֵ
        public double CalcValue { get; set; }
        ///������Ϣ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg { get; set; } 
    };
    
    ///����Աָ��
    public class StpAdminCommand // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///���
        public Int32 SequenceNo { get; set; }
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///ָ�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADMINCODE_LEN)]
        public string AdminCode { get; set; } 
        ///�޸�������ϸ��json�ַ�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
        public string Value { get; set; } 
        ///�������
        public Int32 ErrorID { get; set; }
        ///������Ϣ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg { get; set; } 
    };
    
    ///ָ����־
    public class StpOperationLog // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///Ͷ���ߴ���
        public Int32 InvestorID { get; set; }
        ///��¼�ɹ�ʱ��
        public Int32 ExecuteTime { get; set; }
        ///ָ�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADMINCODE_LEN)]
        public string AdminCode { get; set; } 
        ///�޸�������ϸ��json�ַ�����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
        public string Value { get; set; } 
        ///�������
        public Int32 ErrorID { get; set; }
        ///������Ϣ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg { get; set; } 
    };
    
    ///�ֱֲ䶯��־
    public class StpPosChangeLog // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///��������
        public char OperationType { get; set; }
        ///�䶯����
        public char ChangeType { get; set; }
        ///�˻����
        public Int32 AccountID { get; set; }
        ///��ϱ��
        public Int32 ComboID { get; set; }
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///���ұ�־
        public char CoveredFlag { get; set; }
        ///�ֲֶ�շ���
        public char PosiDirection { get; set; }
        ///��¼�ɹ�ʱ��
        public Int32 ExecuteTime { get; set; }
        ///ԭʼֵ
        public double OriginValue { get; set; }
        ///����ֵ
        public double NewValue { get; set; }
        ///��ע
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_MEMO_LEN)]
        public string Memo { get; set; } 
    };
    
    ///�ʽ�䶯��־
    public class StpActChangeLog // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///��������
        public char OperationType { get; set; }
        ///�䶯����
        public char ChangeType { get; set; }
        ///�˻����
        public Int32 AccountID { get; set; }
        ///��¼�ɹ�ʱ��
        public Int32 ExecuteTime { get; set; }
        ///ԭʼֵ
        public double OriginValue { get; set; }
        ///����ֵ
        public double NewValue { get; set; }
        ///��ע
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_MEMO_LEN)]
        public string Memo { get; set; } 
    };
    
    ///������Ϣ
    public class StpRspInfo // struct
    {
        ///�������
        public Int32 ErrorID { get; set; }
        ///������־
        public Int32 IsLast { get; set; }
        ///������Ϣ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg { get; set; } 
    };
    
    ///��¼����
    public class StpUserLoginReq // struct
    {
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
        public string Password { get; set; } 
    };
    
    ///��¼����
    public class StpLoginReq // struct
    {
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
        public string Password { get; set; } 
        ///����IP
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP { get; set; } 
        ///����MAC
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC { get; set; } 
        ///����Ӳ�����к�
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum { get; set; } 
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode { get; set; } 
        ///��������ϵͳ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS { get; set; } 
    };
    
    ///ע������
    public class StpLogoutReq // struct
    {
        ///����Ա����
        public Int32 OperatorID { get; set; }
    };
    
    ///����������Ӧ
    public class StpRspLogin // struct
    {
        ///������
        public Int32 TradingDay { get; set; }
        ///��¼�ɹ�ʱ��
        public Int32 LoginTime { get; set; }
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///ǰ�ñ��
        public Int32 FrontID { get; set; }
        ///�Ự���
        public Int32 SessionID { get; set; }
        ///��󱨵�����
        public Int32 MaxOrderRef { get; set; }
    };
    
    ///����¼������
    public class StpOrderReq // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///��ϱ��
        public Int32 ComboID { get; set; }
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///��������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef { get; set; } 
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///�����۸�����
        public char OrderPriceType { get; set; }
        ///��������
        public char Direction { get; set; }
        ///��ƽ��־
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBOFFSETFLAG_LEN)]
        public string CombOffsetFlag { get; set; } 
        ///Ͷ���ױ���־
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBHEDGEFLAG_LEN)]
        public string CombHedgeFlag { get; set; } 
        ///���ұ�־
        public char CoveredFlag { get; set; }
        ///�۸�
        public double LimitPrice { get; set; }
        ///ԭʼ����
        public Int32 VolumeTotalOriginal { get; set; }
        ///��Ч������
        public char TimeCondition { get; set; }
        ///�ɽ�������
        public char VolumeCondition { get; set; }
        ///Ԥ���ֶ�1
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF1_LEN)]
        public string ThirdReff1 { get; set; } 
        ///Ԥ���ֶ�2
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF2_LEN)]
        public string ThirdReff2 { get; set; } 
        ///����IP
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP { get; set; } 
        ///����MAC
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC { get; set; } 
        ///����Ӳ�����к�
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum { get; set; } 
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode { get; set; } 
        ///��������ϵͳ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS { get; set; } 
    };
    
    ///ȡ����������
    public class StpOrderCancelReq // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///����Ա����
        public Int32 OperatorID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERACTIONREF_LEN)]
        public string OrderActionRef { get; set; } 
        ///���ر������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
        ///����IP
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP { get; set; } 
        ///����MAC
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC { get; set; } 
        ///����Ӳ�����к�
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum { get; set; } 
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode { get; set; } 
        ///��������ϵͳ
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS { get; set; } 
    };
    
    ///��ѯ�������
    public class StpQryRiskRule // struct
    {
        ///����ID
        public Int32 RiskId { get; set; }
        ///�������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
        public string RuleCode { get; set; } 
    };
    
    ///��ѯ��Ʒ��Ϣ
    public class StpQryInstrument // struct
    {
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
    };
    
    ///��ѯ��Ʒ��������Ϣ
    public class StpQryCommissionRate // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///��������
        public char Direction { get; set; }
        ///��ƽ��־
        public char OffsetFlag { get; set; }
        ///���ұ�־
        public char CoveredFlag { get; set; }
        ///Ͷ���ױ���־
        public char HedgeFlag { get; set; }
    };
    
    ///��ѯ��Ʒ��֤������Ϣ
    public class StpQryMarginRate // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///��������
        public char Direction { get; set; }
        ///��ƽ��־
        public char OffsetFlag { get; set; }
        ///���ұ�־
        public char CoveredFlag { get; set; }
        ///Ͷ���ױ���־
        public char HedgeFlag { get; set; }
    };
    
    ///��ѯ����
    public class StpQryOrder // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///��ϱ��
        public Int32 ComboID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///���ر������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
    };
    
    ///��ѯ�ɽ�
    public class StpQryTrade // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///��ϱ��
        public Int32 ComboID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
        ///�ɽ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
        public string TradeID { get; set; } 
        ///���ر������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID { get; set; } 
    };
    
    ///��ѯ�˻��ʽ�
    public class StpQryAccountAsset // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
    };
    
    ///��ѯ�˻�������Ϣ
    public class StpQryAccount // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///��ѯ�˻�����
        public char QryAccountType { get; set; }
    };
    
    ///��ѯͶ���ֲ߳�
    public class StpQryPosition // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///��ϱ��
        public Int32 ComboID { get; set; }
        ///����������
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID { get; set; } 
        ///֤ȯ����
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID { get; set; } 
    };
    
    ///��ѯͶ�����
    public class StpQryCombo // struct
    {
        ///�˻����
        public Int32 AccountID { get; set; }
        ///��ϱ��
        public Int32 ComboID { get; set; }
    };
    
}
  