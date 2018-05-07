
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SmallPB.entitymodel
{
    /// AdminCodeType��һ������Ա��������
    public enum eStpAdminCode
    {
        [Description("���")]
        CI = 0,
        [Description("����")]
        CO = 1,
        [Description("����")]
        FZ = 2,
        [Description("�ⶳ")]
        UF = 3
    }
    
    /// <summary>
    /// ProductClassType��һ��֤ȯ�������
    /// </summary>
    public enum eStpProductClass
    {
        [Description("�ڻ�")]
        STP_PC_Futures = '1', 
        [Description("��Ȩ")]
        STP_PC_Options = '2', 
        [Description("��Ʊ")]
        STP_PC_Stock = '3', 
        [Description("ծȯ")]
        STP_PC_Bond = '4', 
        [Description("����")]
        STP_PC_Fund = '5', 
        [Description("ָ��")]
        STP_PC_Index = '6', 
        [Description("Ȩ֤")]
        STP_PC_Warrant = '7', 
        [Description("�ع�")]
        STP_PC_Repo = '8', 
        [Description("����")]
        STP_PC_Other = '9', 
    }
    
    /// <summary>
    /// InvestorRangeType��һ��Ͷ���߷�Χ����
    /// </summary>
    public enum eStpInvestorRange
    {
        [Description("����")]
        STP_IR_All = '1', 
        [Description("Ͷ������")]
        STP_IR_Group = '2', 
        [Description("��һͶ����")]
        STP_IR_Single = '3', 
        [Description("����Ͷ�ʵ�Ԫ")]
        STP_IR_AllInvestUnit = '4', 
        [Description("��һͶ�ʵ�Ԫ")]
        STP_IR_SingleInvestUnit = '5', 
    }
    
    /// <summary>
    /// ProviderTypeType��һ����̨��������
    /// </summary>
    public enum eStpProviderType
    {
        [Description("ctp�ڻ�����")]
        STP_PT_CtpFutureTd = '0', 
        [Description("ctp�ڻ�����")]
        STP_PT_CtpFutureMd = '1', 
        [Description("ctp�ڻ���ѯ")]
        STP_PT_CtpFutureQry = '2', 
        [Description("Stp����Ȩ����")]
        STP_PT_STPOptionTd = '3', 
        [Description("Stp����Ȩ��ѯ")]
        STP_PT_STPOptionQry = '4', 
        [Description("Stp�Ĺ�Ʊ����")]
        STP_PT_STPStockTd = '5', 
        [Description("Stp�Ĺ�Ʊ��ѯ")]
        STP_PT_STPStockQry = '6', 
        [Description("Femas�ڻ�����")]
        STP_PT_FemasFutureTd = '7', 
        [Description("Femas�ڻ�����")]
        STP_PT_FemasFutureMd = '8', 
        [Description("Femas�ڻ���ѯ")]
        STP_PT_FemasFutureQry = '9', 
    }
    
    /// <summary>
    /// DirectionType��һ��������������
    /// </summary>
    public enum eStpDirection
    {
        [Description("��")]
        STP_D_Buy = '0', 
        [Description("��")]
        STP_D_Sell = '1', 
        [Description("ETF�깺")]
        STP_D_ETFPur = '2', 
        [Description("ETF���")]
        STP_D_ETFRed = '3', 
        [Description("�ֽ������ֻ�����ر�")]
        STP_D_CashIn = '4', 
        [Description("ծȯ���")]
        STP_D_PledgeBondIn = '5', 
        [Description("ծȯ����")]
        STP_D_PledgeBondOut = '6', 
        [Description("���")]
        STP_D_Doublened = '7', 
        [Description("ת�й�")]
        STP_D_DepositoryTransfer = '8', 
        [Description("�����˻����")]
        STP_D_CreditDoublened = '9', 
        [Description("����Ʒ����")]
        STP_D_BuyCollateral = 'A', 
        [Description("����Ʒ����")]
        STP_D_SellCollateral = 'B', 
        [Description("����Ʒת��")]
        STP_D_CollateralTransferIn = 'C', 
        [Description("����Ʒת��")]
        STP_D_CollateralTransferOut = 'D', 
        [Description("��������")]
        STP_D_MarginTrade = 'E', 
        [Description("��ȯ����")]
        STP_D_ShortSell = 'F', 
        [Description("��ȯ����")]
        STP_D_RepayMargin = 'G', 
        [Description("��ȯ��ȯ")]
        STP_D_RepayStock = 'H', 
        [Description("ֱ�ӻ���")]
        STP_D_DirectRepayMargin = 'I', 
        [Description("ֱ�ӻ�ȯ")]
        STP_D_DirectRepayStock = 'J', 
        [Description("��ȯ��ת")]
        STP_D_ExcessStockTransfer = 'K', 
        [Description("OF�깺")]
        STP_D_OFPur = 'L', 
        [Description("OF���")]
        STP_D_OFRed = 'M', 
        [Description("SF���")]
        STP_D_SFSplit = 'N', 
        [Description("SF�ϲ�")]
        STP_D_SFMerge = 'O', 
        [Description("����")]
        STP_D_Covered = 'P', 
        [Description("֤ȯ����(��)/�ⶳ(ƽ)")]
        STP_D_Freeze = 'Q', 
        [Description("��Ȩ")]
        STP_D_Execute = 'R', 
        [Description("CB����")]
        STP_D_CBRed = 'S', 
        [Description("CBת��")]
        STP_D_CBConv = 'T', 
        [Description("OF�Ϲ�")]
        STP_D_OFSub = 'U', 
    }
    
    /// <summary>
    /// QryAccountTypeType��һ����ѯ�˻���������
    /// </summary>
    public enum eStpQryAccountType
    {
        [Description("����")]
        STP_QAT_Operate = '0', 
        [Description("��ѯ")]
        STP_QAT_Query = '1', 
    }
    
    /// <summary>
    /// HedgeFlagType��һ��Ͷ���ױ���־����
    /// </summary>
    public enum eStpHedgeFlag
    {
        [Description("Ͷ��")]
        STP_HF_Speculation = '1', 
        [Description("����")]
        STP_HF_Arbitrage = '2', 
        [Description("�ױ�")]
        STP_HF_Hedge = '3', 
        [Description("������")]
        STP_HF_MarketMaker = '4', 
    }
    
    /// <summary>
    /// UserTypeType��һ���û���������
    /// </summary>
    public enum eStpUserType
    {
        [Description("Ͷ����")]
        STP_UT_Investor = '0', 
        [Description("����Ա")]
        STP_UT_Operator = '1', 
        [Description("����Ա")]
        STP_UT_SuperUser = '2', 
    }
    
    /// <summary>
    /// CoveredFlagType��һ�����ұ�־����
    /// </summary>
    public enum eStpCoveredFlag
    {
        [Description("�Ǳ���")]
        STP_CF_Uncovered = '0', 
        [Description("����")]
        STP_CF_Covered = '1', 
    }
    
    /// <summary>
    /// OwnerTypeType��һ�������־����
    /// </summary>
    public enum eStpOwnerType
    {
        [Description("����Ͷ����")]
        STP_OT_0 = '0', 
        [Description("����������")]
        STP_OT_1 = '1', 
        [Description("��Ȩ��Ӫ����")]
        STP_OT_2 = '2', 
        [Description("����Ͷ���߷���")]
        STP_OT_3 = '3', 
        [Description("��Ӫ���׷���")]
        STP_OT_4 = '4', 
        [Description("�����Է����ṩ�̷���")]
        STP_OT_5 = '5', 
    }
    
    /// <summary>
    /// InvestorLevelType��һ��Ͷ���߽��׵ȼ�����
    /// </summary>
    public enum eStpInvestorLevel
    {
        [Description("һ��")]
        STP_IL_1 = '0', 
        [Description("����")]
        STP_IL_2 = '1', 
        [Description("����")]
        STP_IL_3 = '2', 
        [Description("�ǽ��׼��𣬴˼���investor���ɽ���")]
        STP_IL_9 = '9', 
    }
    
    /// <summary>
    /// OffsetFlagType��һ����ƽ��־����
    /// </summary>
    public enum eStpOffsetFlag
    {
        [Description("����")]
        STP_OF_Open = '0', 
        [Description("ƽ��")]
        STP_OF_Close = '1', 
        [Description("ǿƽ")]
        STP_OF_ForceClose = '2', 
        [Description("ƽ��")]
        STP_OF_CloseToday = '3', 
        [Description("ƽ��")]
        STP_OF_CloseYesterday = '4', 
        [Description("ǿ��")]
        STP_OF_ForceOff = '5', 
        [Description("����ǿƽ")]
        STP_OF_LocalForceClose = '6', 
        [Description("�Զ�����ƽ��ƽ���ж�(�ݲ�֧�֣�")]
        STP_OF_Auto = '7', 
        [Description("�Ϲ�")]
        STP_OF_Call = '8', 
        [Description("�Ϲ�")]
        STP_OF_Put = '9', 
    }
    
    /// <summary>
    /// OrderPriceTypeType��һ�������۸���������
    /// </summary>
    public enum eStpOrderPriceType
    {
        [Description("�����")]
        STP_OPT_AnyPrice = '1', 
        [Description("�޼�")]
        STP_OPT_LimitPrice = '2', 
        [Description("���ż�")]
        STP_OPT_BestPrice = '3', 
        [Description("���¼�")]
        STP_OPT_LastPrice = '4', 
        [Description("�������¼�")]
        STP_OPT_LocalBestPrice = '5', 
        [Description("�嵵���ż�")]
        STP_OPT_FiveLevelPrice = '6', 
        [Description("ETF�깺")]
        STP_OPT_PurchasesETF  = 'd', 
        [Description("ETF���")]
        STP_OPT_RedeemETF = 'e', 
    }
    
    /// <summary>
    /// TimeConditionType��һ����Ч����������
    /// </summary>
    public enum eStpTimeCondition
    {
        [Description("������ɣ�������")]
        STP_TC_IOC = '1', 
        [Description("������Ч")]
        STP_TC_GFS = '2', 
        [Description("������Ч")]
        STP_TC_GFD = '3', 
        [Description("ָ������ǰ��Ч")]
        STP_TC_GTD = '4', 
        [Description("����ǰ��Ч")]
        STP_TC_GTC = '5', 
        [Description("���Ͼ�����Ч")]
        STP_TC_GFA = '6', 
    }
    
    /// <summary>
    /// VolumeConditionType��һ���ɽ�����������
    /// </summary>
    public enum eStpVolumeCondition
    {
        [Description("�κ�����")]
        STP_VC_AV = '1', 
        [Description("��С����")]
        STP_VC_MV = '2', 
        [Description("ȫ������")]
        STP_VC_CV = '3', 
    }
    
    /// <summary>
    /// ContingentConditionType��һ��������������
    /// </summary>
    public enum eStpContingentCondition
    {
        [Description("����")]
        STP_CC_Immediately = '1', 
        [Description("ֹ��")]
        STP_CC_Touch = '2', 
        [Description("ֹӮ")]
        STP_CC_TouchProfit = '3', 
        [Description("Ԥ��")]
        STP_CC_ParkedOrder = '4', 
    }
    
    /// <summary>
    /// OrderStatusType��һ������״̬����
    /// </summary>
    public enum eStpOrderStatus
    {
        [Description("����")]
        STP_OST_Unknown = '0', 
        [Description("����")]
        STP_OST_PendingNew = '1', 
        [Description("�ѱ�")]
        STP_OST_New = '2', 
        [Description("����")]
        STP_OST_PartilyFilled = '3', 
        [Description("�ѳ�")]
        STP_OST_Filled = '4', 
        [Description("����")]
        STP_OST_PartilyCanceled = '5', 
        [Description("�ѳ�")]
        STP_OST_Canceled = '6', 
        [Description("�ϵ�")]
        STP_OST_Rejected = '7', 
    }
    
    /// <summary>
    /// OrderTypeType��һ��������������
    /// </summary>
    public enum eStpOrderType
    {
        [Description("����")]
        STP_ORDT_Normal = '0', 
        [Description("��������")]
        STP_ORDT_DeriveFromQuote = '1', 
        [Description("�������")]
        STP_ORDT_DeriveFromCombination = '2', 
        [Description("��ϱ���")]
        STP_ORDT_Combination = '3', 
        [Description("������")]
        STP_ORDT_ConditionalOrder = '4', 
        [Description("������")]
        STP_ORDT_Swap = '5', 
    }
    
    /// <summary>
    /// PosiDirectionType��һ���ֲֶ�շ�������
    /// </summary>
    public enum eStpPosiDirection
    {
        [Description("��ͷ")]
        STP_PD_Short = '1', 
        [Description("��ͷ")]
        STP_PD_Long = '0', 
    }
    
    /// <summary>
    /// ChangeTypeType��һ���䶯��������
    /// </summary>
    public enum eStpChangeType
    {
        [Description("�˶�ֵ")]
        STP_CGT_check = '1', 
        [Description("���Ṧ��")]
        STP_CGT_fronzen = '2', 
        [Description("��ǰֵ")]
        STP_CGT_current = '3', 
        [Description("�ֲֳɱ�")]
        STP_CGT_cost = '4', 
    }
    
    /// <summary>
    /// CapitalDirectionType��һ���ʽ�仯��������
    /// </summary>
    public enum eStpCapitalDirection
    {
        [Description("����")]
        STP_CPD_Nochange = '0', 
        [Description("����")]
        STP_CPD_Increase = '1', 
        [Description("����")]
        STP_CPD_Decrease = '2', 
    }
    
    /// <summary>
    /// PositionDirectionType��һ���ֱֲ仯��������
    /// </summary>
    public enum eStpPositionDirection
    {
        [Description("����")]
        STP_PSD_Nochange = '0', 
        [Description("����")]
        STP_PSD_Increase = '1', 
        [Description("����")]
        STP_PSD_Decrease = '2', 
    }
    
    /// <summary>
    /// PositionDateType��һ���ֲ����ڱ�־����
    /// </summary>
    public enum eStpPositionDate
    {
        [Description("���ճֲ�")]
        STP_PSD_Today = '1', 
        [Description("��ʷ�ֲ�")]
        STP_PSD_History = '2', 
    }
    
    /// <summary>
    /// TradingPhaseType��һ�����׽׶�����
    /// </summary>
    public enum eStpTradingPhase
    {
        [Description("�ǽ���ʱ��")]
        STP_TP_NonTrade = '0', 
        [Description("���Ͼ���ʱ��")]
        STP_TP_Bidding = '1', 
        [Description("��������ʱ��")]
        STP_TP_Continuous = '2', 
        [Description("ͣ��ʱ��")]
        STP_TP_Suspension = '3', 
        [Description("�۶�ʱ��")]
        STP_TP_Fuse = '4', 
    }
    
    /// <summary>
    /// OpenRestrictionType��һ��������������
    /// </summary>
    public enum eStpOpenRestriction
    {
        [Description("�޿�������")]
        STP_OR_None = '0', 
        [Description("���Ʊ��ҿ���")]
        STP_OR_NoCoverOpen = '1', 
        [Description("������������")]
        STP_OR_NoSellOpen = '2', 
        [Description("�����������֡����ҿ���")]
        STP_OR_NoSellAndCoverOpen = '3', 
        [Description("�������뿪��")]
        STP_OR_NoBuyOpen = '4', 
        [Description("�������뿪�֡����ҿ���")]
        STP_OR_NoBuyAndCoverOpen = '5', 
        [Description("�������뿪�֡���������")]
        STP_OR_NoBuyAndSellOpen = '6', 
        [Description("�������뿪�֡��������֡����ҿ���")]
        STP_OR_NoBuySellAndCoverOpen = '7', 
    }
    
    /// <summary>
    /// PositionTypeType��һ���ֲ���������
    /// </summary>
    public enum eStpPositionType
    {
        [Description("���ֲ�")]
        STP_PT_Net = '1', 
        [Description("�ۺϳֲ�")]
        STP_PT_Gross = '2', 
    }
    
    /// <summary>
    /// PositionDateTypeType��һ���ֲ�������������
    /// </summary>
    public enum eStpPositionDateType
    {
        [Description("ʹ����ʷ�ֲ�")]
        STP__UseHistory = '1', 
        [Description("��ʹ����ʷ�ֲ�")]
        STP__NoUseHistory = '2', 
    }
    
    /// <summary>
    /// InvestorTypeType��һ��Ͷ������������
    /// </summary>
    public enum eStpInvestorType
    {
        [Description("��Ȼ��")]
        STP_IT_Person = '1', 
        [Description("����")]
        STP_IT_Company = '2', 
        [Description("Ͷ�ʻ���")]
        STP_IT_Fund = '3', 
        [Description("���ⷨ��")]
        STP_IT_SpecialOrgan = '4', 
        [Description("�ʹܻ�")]
        STP_IT_Asset = '5', 
        [Description("ϵͳ����Ա")]
        STP_IT_Admin = 'a', 
    }
    
    /// <summary>
    /// IDCardTypeType��һ��֤����������
    /// </summary>
    public enum eStpIDCardType
    {
        [Description("��֯��������")]
        STP_DCT_EID = '0', 
        [Description("�й��������֤")]
        STP_DCT_IDCard = '1', 
        [Description("����֤")]
        STP_DCT_OfficerIDCard = '2', 
        [Description("����֤")]
        STP_DCT_PoliceIDCard = '3', 
        [Description("ʿ��֤")]
        STP_DCT_SoldierIDCard = '4', 
        [Description("���ڲ�")]
        STP_DCT_HouseholdRegister  = '5', 
        [Description("����")]
        STP_DCT_Passport = '6', 
        [Description("̨��֤")]
        STP_DCT_TaiwanCompatriotIDCard  = '7', 
        [Description("����֤")]
        STP_DCT_HomeComingCard = '8', 
        [Description("Ӫҵִ�պ�")]
        STP_DCT_LicenseNo = '9', 
        [Description("˰��ǼǺ�/������˰ID")]
        STP_DCT_TaxNo = 'A', 
        [Description("�۰ľ��������ڵ�ͨ��֤")]
        STP_DCT_HMMainlandTravelPermit  = 'B', 
        [Description("̨�����������½ͨ��֤")]
        STP_DCT_TwMainlandTravelPermit = 'C', 
        [Description("����")]
        STP_DCT_DrivingLicense = 'D', 
        [Description("�����籣ID")]
        STP_DCT_SocialID = 'F', 
        [Description("�������֤")]
        STP_DCT_LocalID = 'G', 
        [Description("��ҵ�Ǽ�֤")]
        STP_DCT_BusinessRegistration  = 'H', 
        [Description("�۰������Ծ������֤")]
        STP_DCT_HKMCIDCard  = 'I', 
        [Description("���п������֤")]
        STP_DCT_AccountsPermits = 'J', 
        [Description("��������þ���֤")]
        STP_DCT_PermanantResidence = 'K', 
        [Description("�ʹܲ�Ʒ������")]
        STP_DCT_AssetProductRecord = 'L', 
        [Description("����֤��")]
        STP_DCT_OtherCard = 'x', 
    }
    
    /// <summary>
    /// TradingCodeTypeType��һ�����ױ�����������
    /// </summary>
    public enum eStpTradingCodeType
    {
        [Description("Ͷ��")]
        STP_TC_Speculation = '1', 
        [Description("����")]
        STP_TC_Arbitrage = '2', 
        [Description("�ױ�")]
        STP_TC_Hedge = '3', 
        [Description("������")]
        STP_TC_MarketMaker = '4', 
    }
    
    /// <summary>
    /// OptCommissionTypeType��һ����Ȩ������������
    /// </summary>
    public enum eStpOptCommissionType
    {
        [Description("��Ȩ��")]
        STP_OPT_CT_StrikeFee = '1', 
        [Description("����Ȩ��")]
        STP_OPT_CT_BeStrikeDFee = '2', 
        [Description("��Ȩ������")]
        STP_OPT_CT_TransferFee = '3', 
        [Description("���ַ�")]
        STP_OPT_CT_Brokerage = '4', 
        [Description("���׷�")]
        STP_OPT_CT_TradeFee = '5', 
        [Description("�����")]
        STP_OPT_CT_SettleFee = '6', 
    }
    
    /// <summary>
    /// CommDirectionType��һ��ί�з�������
    /// </summary>
    public enum eStpCommDirection
    {
        [Description("��")]
        STP_CD_BuyOpen = '1', 
        [Description("��ƽ")]
        STP_CD_BuyClose = '2', 
        [Description("����")]
        STP_CD_SellOpen = '3', 
        [Description("��ƽ")]
        STP_CD_SellClose = '4', 
        [Description("��Ȩ�Ϲ�")]
        STP_CD_CallStrike = '5', 
        [Description("��Ȩ�Ϲ�")]
        STP_CD_PutStrike = '6', 
    }
    
    /// <summary>
    /// RateTypeType��һ�����㷽ʽ����
    /// </summary>
    public enum eStpRateType
    {
        [Description("������")]
        STP_RT_ByVolume = '1', 
        [Description("�����")]
        STP_RT_ByMoney = '2', 
        [Description("����ֵ")]
        STP_RT_ByFace = '3', 
    }
    
    /// <summary>
    /// OperationTypeType��һ��������������
    /// </summary>
    public enum eStpOperationType
    {
        [Description("�ճ�ͬ������")]
        STP_OPNT_Sync = '1', 
        [Description("����ָ�����")]
        STP_OPNT_Admin = '2', 
        [Description("�����ֲֵ�������")]
        STP_OPNT_Settle = '3', 
        [Description("��������")]
        STP_OPNT_Other = '0', 
    }
    
    /// <summary>
    /// OptionTypeType��һ����Ȩ��������
    /// </summary>
    public enum eStpOptionType
    {
        [Description("�Ϲ�")]
        STP_OPT_TY_Call = 'C', 
        [Description("�Ϲ�")]
        STP_OPT_TY_Put = 'P', 
    }
    
    /// <summary>
    /// SystemStatusType��һ��ϵͳ״̬����
    /// </summary>
    public enum eStpSystemStatus
    {
        [Description("�����������")]
        STP_STS_SyncDone = '1', 
        [Description("���н���״̬")]
        STP_STS_Trading = '2', 
        [Description("�������")]
        STP_STS_Closed = '3', 
        [Description("�������")]
        STP_STS_Settled = '4', 
    }
    
    /// <summary>
    /// InstrumentRangeType��һ����Լ��Χ����
    /// </summary>
    public enum eStpInstrumentRange
    {
        [Description("����")]
        STP_INSTR_ALL = '1', 
        [Description("֤ȯ���")]
        STP_INSTR_PRODUCT_CLASS = '2', 
        [Description("��һ��Լ")]
        STP_INSTR_SINGLE = '3', 
    }
    
    /// <summary>
    /// SeatTypeType��һ��ϯλ��������
    /// </summary>
    public enum eStpSeatType
    {
        [Description("�Ͻ�����Ȩ")]
        STP_ST_SHOPT = '1', 
        [Description("�Ͻ�����Ʊ")]
        STP_ST_SHSTK = '2', 
        [Description("�����Ȩ")]
        STP_ST_SZOPT = '3', 
        [Description("�����Ʊ")]
        STP_ST_SZSTK = '4', 
        [Description("����")]
        STP_ST_FEMAS = '5', 
    }
    
    /// <summary>
    /// ResumeTypeType��һ��˽�����ش���ʽ����
    /// </summary>
    public enum eStpResumeType
    {
        [Description("�ش�")]
        STP_RT_Restart = '0', 
        [Description("����")]
        STP_RT_Resume = '1', 
        [Description("��ǰ��ʼ")]
        STP_RT_Quick = '2', 
    }
    
    /// <summary>
    /// CompanyTypeType��һ����˾��������
    /// </summary>
    public enum eStpCompanyType
    {
        [Description("�ڲ�����")]
        STP_CT_INSIDE = '1', 
        [Description("�����ͻ�")]
        STP_CT_ORGAN = '2', 
        [Description("���˿ͻ�")]
        STP_CT_USER = '3', 
    }
    
    /// <summary>
    /// EnbFlagType��һ��״̬��־����
    /// </summary>
    public enum eStpEnbFlag
    {
        [Description("����")]
        STP_EF_NORMAL = 'N', 
        [Description("���ر�")]
        STP_EF_OFF = 'C', 
        [Description("����")]
        STP_EF_LOCK = 'L', 
        [Description("����δͬ��")]
        STP_EF_UNSYNC = '1', 
    }
    
    /// <summary>
    /// ActionTypeType��һ��������������
    /// </summary>
    public enum eStpActionType
    {
        [Description("�ͻ���")]
        STP_ACT_CLIENT = '1', 
        [Description("web��")]
        STP_ACT_WEB = '2', 
        [Description("����ƽ̨")]
        STP_ACT_MARKET = '3', 
    }
    
    /// <summary>
    /// AuthTypeType��һ��Ȩ����������
    /// </summary>
    public enum eStpAuthType
    {
        [Description("ͨ��")]
        STP_AUT_GENERAL = '0', 
        [Description("ȯ���ڲ�")]
        STP_AUT_INSIDE = '1', 
        [Description("�ⲿ�ͻ�")]
        STP_AUT_OUTSIDE = '2', 
    }
    
    /// <summary>
    /// FileFlagType��һ������ִ��״̬����
    /// </summary>
    public enum eStpFileFlag
    {
        [Description("������")]
        STP__InProgress = 'I', 
        [Description("���ɳɹ�")]
        STP__Success = 'S', 
        [Description("����ʧ��")]
        STP__Fail = 'F', 
    }
    
    /// <summary>
    /// MarketDataTypeType��һ������������������
    /// </summary>
    public enum eStpMarketDataType
    {
        [Description("ʵʱ����")]
        STP_MDT_REAL = '0', 
        [Description("��ʷ����")]
        STP_MDT_HIS = '1', 
    }
    
    /// <summary>
    /// PaySubjectType��һ���ɷѿ�Ŀ����
    /// </summary>
    public enum eStpPaySubject
    {
        [Description("ͨ�÷���")]
        STP_PSJ_GENERAL = '1', 
    }
    
    /// <summary>
    /// AccountTypeType��һ���˻���������
    /// </summary>
    public enum eStpAccountType
    {
        [Description("��֤ͨȯ�˻�")]
        STP_AT_STOCK = '1', 
        [Description("�����˻�")]
        STP_AT_CREDIT = '2', 
        [Description("����Ʒ�˻�")]
        STP_AT_DERIVATIVE = '3', 
        [Description("�ڻ��˻�")]
        STP_AT_FUTURES = '4', 
    }
    
    /// <summary>
    /// ChannelTypeType��һ��ͨ����������
    /// </summary>
    public enum eStpChannelType
    {
        [Description("UFT�ֲ�")]
        STP_CHT_UFT = '1', 
        [Description("CTP�ֲ�")]
        STP_CHT_CTP = '2', 
        [Description("����ֲ�")]
        STP_CHT_FEMAS = '3', 
        [Description("O32�ֲ�")]
        STP_CHT_O32 = '4', 
        [Description("ģ�⽻����")]
        STP_CHT_SIMULATE = '5', 
    }
    
    /// <summary>
    /// FeeTypeType��һ�������������
    /// </summary>
    public enum eStpFeeType
    {
        [Description("���׷�")]
        STP_FT_TRADEFEE = '1', 
        [Description("ӡ��˰")]
        STP_FT_STAMPTAX = '2', 
        [Description("������")]
        STP_FT_TRANSFERFEE = '3', 
        [Description("Ӷ��")]
        STP_FT_BROKERFEE = '4', 
        [Description("���ַ�")]
        STP_FT_HANDLINGFEE = '5', 
        [Description("֤�ܷ�")]
        STP_FT_ADMINFEE = '6', 
        [Description("������")]
        STP_FT_OTHERFEE = '7', 
        [Description("�����")]
        STP_FT_CLEARINGFEE = 'a', 
        [Description("�����")]
        STP_FT_SETTLEFEE = 'b', 
        [Description("ί���걨��")]
        STP_FT_PERORDER = 'c', 
        [Description("�����걨��")]
        STP_FT_PERCANCEL = 'd', 
    }
    
    /// <summary>
    /// CalculateTypeType��һ�����ü���ģʽ����
    /// </summary>
    public enum eStpCalculateType
    {
        [Description("�ֱ�")]
        STP_CT_TOTAL = '1', 
        [Description("�ϱ�")]
        STP_CT_PER = '2', 
    }
    
    /// <summary>
    /// CancelFlagType��һ��������־����
    /// </summary>
    public enum eStpCancelFlag
    {
        [Description("��ͨί��")]
        STP_CF_ORDER = '1', 
        [Description("����ί��")]
        STP_CF_CANCEL = '2', 
    }
    
    /// <summary>
    /// StockRealBackType��һ���ر�֤ȯ��־����
    /// </summary>
    public enum eStpStockRealBack
    {
        [Description("����֤ȯ���첻����")]
        STP_SRB_FALSE = '0', 
        [Description("����֤�������")]
        STP_SRB_TRUE = '1', 
    }
    
    /// <summary>
    /// FundRealBackType��һ���ر��ʽ��־����
    /// </summary>
    public enum eStpFundRealBack
    {
        [Description("�����ʽ𲻿���")]
        STP_FRB_FALSE = '0', 
        [Description("�����ʽ������")]
        STP_FRB_TRUE = '1', 
    }
    
    /// <summary>
    /// InstrumentControlLevelType��һ��֤ȯ���Ʋ㼶����
    /// </summary>
    public enum eStpInstrumentControlLevel
    {
        [Description("֤ȯ���")]
        STP_INSTC_LEVEL_PRODUCT_CLASS = '1', 
        [Description("��һ֤ȯ")]
        STP_INSTC_LEVEL_SINGLE = '3', 
    }
    
    /// <summary>
    /// InstrumentRangeTypeType��һ��֤ȯ��Χ����
    /// </summary>
    public enum eStpInstrumentRangeType
    {
        [Description("����")]
        STP_INSTC_RANGE_ALL = '1', 
        [Description("����")]
        STP_INSTC_RANGE_SET = '3', 
    }
    
    /// <summary>
    /// AccountControlLevelType��һ���˻����Ͽ��Ʋ㼶����
    /// </summary>
    public enum eStpAccountControlLevel
    {
        [Description("��˾")]
        STP_AR_LEVEL_COMPANY = '1', 
        [Description("�˻�")]
        STP_AR_LEVEL_ACCOUNT = '2', 
        [Description("���")]
        STP_AR_LEVEL_COMBO = '3', 
    }
    
    /// <summary>
    /// AccountRangeTypeType��һ���˻����Ϸ�Χ����
    /// </summary>
    public enum eStpAccountRangeType
    {
        [Description("����")]
        STP_AR_RANGE_ALL = '1', 
        [Description("����")]
        STP_AR_RANGE_SET = '3', 
    }
    
}
  