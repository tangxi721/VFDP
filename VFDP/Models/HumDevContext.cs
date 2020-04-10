using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VFDP.Models
{
    public partial class HumDevContext : DbContext
    {
        public HumDevContext()
        {
        }

        public HumDevContext(DbContextOptions<HumDevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlarmHistory> AlarmHistory { get; set; }
        public virtual DbSet<BizAlarmactMasMv> BizAlarmactMasMv { get; set; }
        public virtual DbSet<BizArealvlInfMv> BizArealvlInfMv { get; set; }
        public virtual DbSet<BizCommonlayerInfMv> BizCommonlayerInfMv { get; set; }
        public virtual DbSet<BizDurableattrDetMv> BizDurableattrDetMv { get; set; }
        public virtual DbSet<BizEqpgrpMasMv> BizEqpgrpMasMv { get; set; }
        public virtual DbSet<BizFurnacemonmappInfMv> BizFurnacemonmappInfMv { get; set; }
        public virtual DbSet<BizHessdatasyncInf> BizHessdatasyncInf { get; set; }
        public virtual DbSet<BizLotCodMv> BizLotCodMv { get; set; }
        public virtual DbSet<BizLotholdInfMv> BizLotholdInfMv { get; set; }
        public virtual DbSet<BizLotmoveInfMv> BizLotmoveInfMv { get; set; }
        public virtual DbSet<BizLotscrapInfMv> BizLotscrapInfMv { get; set; }
        public virtual DbSet<BizObjtypdefInf> BizObjtypdefInf { get; set; }
        public virtual DbSet<BizPfointlockInfMv> BizPfointlockInfMv { get; set; }
        public virtual DbSet<BizPrinterlockInfMv> BizPrinterlockInfMv { get; set; }
        public virtual DbSet<BizReasonCodMv> BizReasonCodMv { get; set; }
        public virtual DbSet<BizRecipemapInfMv> BizRecipemapInfMv { get; set; }
        public virtual DbSet<BizTfomodelDefMv> BizTfomodelDefMv { get; set; }
        public virtual DbSet<BizTpfomodelDefMv> BizTpfomodelDefMv { get; set; }
        public virtual DbSet<DcpAlarmHis> DcpAlarmHis { get; set; }
        public virtual DbSet<DcpAreaMas> DcpAreaMas { get; set; }
        public virtual DbSet<DcpBiasavgHis> DcpBiasavgHis { get; set; }
        public virtual DbSet<DcpBiasavgparamHis> DcpBiasavgparamHis { get; set; }
        public virtual DbSet<DcpBiaslotHis> DcpBiaslotHis { get; set; }
        public virtual DbSet<DcpBiasparamHis> DcpBiasparamHis { get; set; }
        public virtual DbSet<DcpCmncodMas> DcpCmncodMas { get; set; }
        public virtual DbSet<DcpCmnmsgHis> DcpCmnmsgHis { get; set; }
        public virtual DbSet<DcpCommonSpecLotcode> DcpCommonSpecLotcode { get; set; }
        public virtual DbSet<DcpCommonSpecMas> DcpCommonSpecMas { get; set; }
        public virtual DbSet<DcpDccopyrltHis> DcpDccopyrltHis { get; set; }
        public virtual DbSet<DcpDccopyrltSum> DcpDccopyrltSum { get; set; }
        public virtual DbSet<DcpDcolHis> DcpDcolHis { get; set; }
        public virtual DbSet<DcpDcolMas> DcpDcolMas { get; set; }
        public virtual DbSet<DcpDcolcompHis> DcpDcolcompHis { get; set; }
        public virtual DbSet<DcpDcolcomprltInf> DcpDcolcomprltInf { get; set; }
        public virtual DbSet<DcpDcolconvcolInf> DcpDcolconvcolInf { get; set; }
        public virtual DbSet<DcpDcoldataInf> DcpDcoldataInf { get; set; }
        public virtual DbSet<DcpDcoldataitemInf> DcpDcoldataitemInf { get; set; }
        public virtual DbSet<DcpDcoldatarsltInf> DcpDcoldatarsltInf { get; set; }
        public virtual DbSet<DcpDcoldatasampInf> DcpDcoldatasampInf { get; set; }
        public virtual DbSet<DcpDcoldervitemDet> DcpDcoldervitemDet { get; set; }
        public virtual DbSet<DcpDcoldervitemHis> DcpDcoldervitemHis { get; set; }
        public virtual DbSet<DcpDcoldrvitemeqlimitHis> DcpDcoldrvitemeqlimitHis { get; set; }
        public virtual DbSet<DcpDcoldrvitemeqlimitInf> DcpDcoldrvitemeqlimitInf { get; set; }
        public virtual DbSet<DcpDcoldrvitemlimitHis> DcpDcoldrvitemlimitHis { get; set; }
        public virtual DbSet<DcpDcoldrvitemlimitInf> DcpDcoldrvitemlimitInf { get; set; }
        public virtual DbSet<DcpDcoldrvnpweqlimitInf> DcpDcoldrvnpweqlimitInf { get; set; }
        public virtual DbSet<DcpDcolextHis> DcpDcolextHis { get; set; }
        public virtual DbSet<DcpDcolformulabaseHis> DcpDcolformulabaseHis { get; set; }
        public virtual DbSet<DcpDcolformulabaseInf> DcpDcolformulabaseInf { get; set; }
        public virtual DbSet<DcpDcolformulaitemDet> DcpDcolformulaitemDet { get; set; }
        public virtual DbSet<DcpDcolformulaitemHis> DcpDcolformulaitemHis { get; set; }
        public virtual DbSet<DcpDcolitemCod> DcpDcolitemCod { get; set; }
        public virtual DbSet<DcpDcolitemHis> DcpDcolitemHis { get; set; }
        public virtual DbSet<DcpDcolitemInf> DcpDcolitemInf { get; set; }
        public virtual DbSet<DcpDcolitemeqlimitHis> DcpDcolitemeqlimitHis { get; set; }
        public virtual DbSet<DcpDcolitemeqlimitInf> DcpDcolitemeqlimitInf { get; set; }
        public virtual DbSet<DcpDcolitemlimitHis> DcpDcolitemlimitHis { get; set; }
        public virtual DbSet<DcpDcolitemlimitInf> DcpDcolitemlimitInf { get; set; }
        public virtual DbSet<DcpDcolitemnpweqlimitInf> DcpDcolitemnpweqlimitInf { get; set; }
        public virtual DbSet<DcpDcollimitsepInf> DcpDcollimitsepInf { get; set; }
        public virtual DbSet<DcpDcolporefInf> DcpDcolporefInf { get; set; }
        public virtual DbSet<DcpDcolproceqpInf> DcpDcolproceqpInf { get; set; }
        public virtual DbSet<DcpDcolsiteInf> DcpDcolsiteInf { get; set; }
        public virtual DbSet<DcpDcolsummHis> DcpDcolsummHis { get; set; }
        public virtual DbSet<DcpElapsedHis> DcpElapsedHis { get; set; }
        public virtual DbSet<DcpEmailMas> DcpEmailMas { get; set; }
        public virtual DbSet<DcpErrlogHis> DcpErrlogHis { get; set; }
        public virtual DbSet<DcpFilterMas> DcpFilterMas { get; set; }
        public virtual DbSet<DcpGoldenmapDet> DcpGoldenmapDet { get; set; }
        public virtual DbSet<DcpGoldenmapHis> DcpGoldenmapHis { get; set; }
        public virtual DbSet<DcpIcanslotHis> DcpIcanslotHis { get; set; }
        public virtual DbSet<DcpIcansmsgHis> DcpIcansmsgHis { get; set; }
        public virtual DbSet<DcpIcansparamHis> DcpIcansparamHis { get; set; }
        public virtual DbSet<DcpIcanswfHis> DcpIcanswfHis { get; set; }
        public virtual DbSet<DcpInterfaceHis> DcpInterfaceHis { get; set; }
        public virtual DbSet<DcpInterlockHis> DcpInterlockHis { get; set; }
        public virtual DbSet<DcpListenmsgHis> DcpListenmsgHis { get; set; }
        public virtual DbSet<DcpLocMas> DcpLocMas { get; set; }
        public virtual DbSet<DcpLoggerMas> DcpLoggerMas { get; set; }
        public virtual DbSet<DcpLotcdmapHis> DcpLotcdmapHis { get; set; }
        public virtual DbSet<DcpMaininfoInf> DcpMaininfoInf { get; set; }
        public virtual DbSet<DcpMdptimekeyMas> DcpMdptimekeyMas { get; set; }
        public virtual DbSet<DcpMvouSync> DcpMvouSync { get; set; }
        public virtual DbSet<DcpMvouSyncRaw> DcpMvouSyncRaw { get; set; }
        public virtual DbSet<DcpOllotHis> DcpOllotHis { get; set; }
        public virtual DbSet<DcpOlparamHis> DcpOlparamHis { get; set; }
        public virtual DbSet<DcpOlstatisticsHis> DcpOlstatisticsHis { get; set; }
        public virtual DbSet<DcpOlwfHis> DcpOlwfHis { get; set; }
        public virtual DbSet<DcpOperMas> DcpOperMas { get; set; }
        public virtual DbSet<DcpParameterHis> DcpParameterHis { get; set; }
        public virtual DbSet<DcpPfointlockInf> DcpPfointlockInf { get; set; }
        public virtual DbSet<DcpPredcoldataInf> DcpPredcoldataInf { get; set; }
        public virtual DbSet<DcpPredcoldataitemInf> DcpPredcoldataitemInf { get; set; }
        public virtual DbSet<DcpPredcoldatarsltInf> DcpPredcoldatarsltInf { get; set; }
        public virtual DbSet<DcpPredcoldatasampInf> DcpPredcoldatasampInf { get; set; }
        public virtual DbSet<DcpProcessMas> DcpProcessMas { get; set; }
        public virtual DbSet<DcpProdMas> DcpProdMas { get; set; }
        public virtual DbSet<DcpRecoveryexecHis> DcpRecoveryexecHis { get; set; }
        public virtual DbSet<DcpRecoveryprocMas> DcpRecoveryprocMas { get; set; }
        public virtual DbSet<DcpScanrlotHis> DcpScanrlotHis { get; set; }
        public virtual DbSet<DcpSyslogHis> DcpSyslogHis { get; set; }
        public virtual DbSet<DcpSysqueryMas> DcpSysqueryMas { get; set; }
        public virtual DbSet<DcpTableActionHis> DcpTableActionHis { get; set; }
        public virtual DbSet<DcpTfomodelDef> DcpTfomodelDef { get; set; }
        public virtual DbSet<DcpTpfomodelDef> DcpTpfomodelDef { get; set; }
        public virtual DbSet<DcpWaferHis> DcpWaferHis { get; set; }
        public virtual DbSet<DcpWaferInf> DcpWaferInf { get; set; }
        public virtual DbSet<DcpWaferMainInf> DcpWaferMainInf { get; set; }
        public virtual DbSet<DcpWaferModuleInf> DcpWaferModuleInf { get; set; }
        public virtual DbSet<DcpWafertidHis> DcpWafertidHis { get; set; }
        public virtual DbSet<DcpWfinterlockHis> DcpWfinterlockHis { get; set; }
        public virtual DbSet<DcpWfinterlockMas> DcpWfinterlockMas { get; set; }
        public virtual DbSet<EventHistory> EventHistory { get; set; }
        public virtual DbSet<FxusrProgMas> FxusrProgMas { get; set; }
        public virtual DbSet<FxusrUserMas> FxusrUserMas { get; set; }
        public virtual DbSet<HesproCopyIoilink> HesproCopyIoilink { get; set; }
        public virtual DbSet<HespscIoilink> HespscIoilink { get; set; }
        public virtual DbSet<HespscyIoilink> HespscyIoilink { get; set; }
        public virtual DbSet<LmsAreaDataMas> LmsAreaDataMas { get; set; }
        public virtual DbSet<LmsDcoldatarefInf> LmsDcoldatarefInf { get; set; }
        public virtual DbSet<LmsEngrNoteTrx> LmsEngrNoteTrx { get; set; }
        public virtual DbSet<LmsEqpMas> LmsEqpMas { get; set; }
        public virtual DbSet<LmsInformDataTrx> LmsInformDataTrx { get; set; }
        public virtual DbSet<LmsLotInformDataHis> LmsLotInformDataHis { get; set; }
        public virtual DbSet<LmsLotTrx> LmsLotTrx { get; set; }
        public virtual DbSet<LmsMachineTrx> LmsMachineTrx { get; set; }
        public virtual DbSet<LmsNoticeMas> LmsNoticeMas { get; set; }
        public virtual DbSet<LmsParamMas> LmsParamMas { get; set; }
        public virtual DbSet<LmsPreMeasMas> LmsPreMeasMas { get; set; }
        public virtual DbSet<LmsProcessMas> LmsProcessMas { get; set; }
        public virtual DbSet<LmsRecipeParamMas> LmsRecipeParamMas { get; set; }
        public virtual DbSet<LmsSheetMas> LmsSheetMas { get; set; }
        public virtual DbSet<MesCommontypDetMv> MesCommontypDetMv { get; set; }
        public virtual DbSet<MesCommontypMasMv> MesCommontypMasMv { get; set; }
        public virtual DbSet<MesDurableMasMv> MesDurableMasMv { get; set; }
        public virtual DbSet<MesEqpMasMv> MesEqpMasMv { get; set; }
        public virtual DbSet<MesEqpmasExtMv> MesEqpmasExtMv { get; set; }
        public virtual DbSet<MesFlowMasMv> MesFlowMasMv { get; set; }
        public virtual DbSet<MesLotMasMv> MesLotMasMv { get; set; }
        public virtual DbSet<MesNodeMasMv> MesNodeMasMv { get; set; }
        public virtual DbSet<MesNodeRelMv> MesNodeRelMv { get; set; }
        public virtual DbSet<MesOperMasMv> MesOperMasMv { get; set; }
        public virtual DbSet<MesProdMasMv> MesProdMasMv { get; set; }
        public virtual DbSet<MesWfMasMv> MesWfMasMv { get; set; }
        public virtual DbSet<SystemCode> SystemCode { get; set; }
        public virtual DbSet<TestProcessMas> TestProcessMas { get; set; }
        public virtual DbSet<TestRecipeParamMas> TestRecipeParamMas { get; set; }
        public virtual DbSet<VfdpWaferHistory> VfdpWaferHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=infogram.database.windows.net;Database=Hum-Dev;uid=HumAdmin;pwd=Admin601;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlarmHistory>(entity =>
            {
                entity.HasKey(e => new { e.TimeKey, e.EquipmentId, e.AlarmId })
                    .HasName("AlarmHistory_PK");

                entity.Property(e => e.TimeKey)
                    .HasMaxLength(21)
                    .IsFixedLength();

                entity.Property(e => e.EquipmentId)
                    .HasColumnName("EquipmentID")
                    .HasMaxLength(50);

                entity.Property(e => e.AlarmId)
                    .HasColumnName("AlarmID")
                    .HasMaxLength(50);

                entity.Property(e => e.AlarmCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AlarmDescription).HasMaxLength(100);

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasColumnName("CreateUserID")
                    .HasMaxLength(50);

                entity.Property(e => e.LotCode).HasMaxLength(50);

                entity.Property(e => e.LotId)
                    .HasColumnName("LotID")
                    .HasMaxLength(50);

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(100);

                entity.Property(e => e.ProcessFlowId)
                    .HasColumnName("ProcessFlowID")
                    .HasMaxLength(100);

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasMaxLength(100);

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RecipeID")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<BizAlarmactMasMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.AlarmId, e.ActTyp })
                    .HasName("BIZ_ALARMACT_MAS_PK");

                entity.ToTable("BIZ_ALARMACT_MAS_MV");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AlarmId)
                    .HasColumnName("ALARM_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ActTyp)
                    .HasColumnName("ACT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ActAttrVal1)
                    .HasColumnName("ACT_ATTR_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ActAttrVal2)
                    .HasColumnName("ACT_ATTR_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ActAttrVal3)
                    .HasColumnName("ACT_ATTR_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ActAttrVal4)
                    .HasColumnName("ACT_ATTR_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.AlarmGrpCd)
                    .HasColumnName("ALARM_GRP_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.AlarmLvlCd)
                    .HasColumnName("ALARM_LVL_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.GoalAreaId)
                    .HasColumnName("GOAL_AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Intval)
                    .HasColumnName("INTVAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<BizArealvlInfMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.AreaLvlId1, e.AreaLvlId2, e.AreaCatgTyp, e.AreaCatgCd })
                    .HasName("BIZ_AREALVL_INF_PK");

                entity.ToTable("BIZ_AREALVL_INF_MV");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaLvlId1)
                    .HasColumnName("AREA_LVL_ID_1")
                    .HasMaxLength(200);

                entity.Property(e => e.AreaLvlId2)
                    .HasColumnName("AREA_LVL_ID_2")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaCatgTyp)
                    .HasColumnName("AREA_CATG_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaCatgCd)
                    .HasColumnName("AREA_CATG_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaCatgEnNm)
                    .HasColumnName("AREA_CATG_EN_NM")
                    .HasMaxLength(200);

                entity.Property(e => e.AreaCatgNm)
                    .HasColumnName("AREA_CATG_NM")
                    .HasMaxLength(200);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .IsRequired()
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .IsRequired()
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<BizCommonlayerInfMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.CommonCd, e.CatgCd, e.TypVal })
                    .HasName("BIZ_COMMONLAYER_INF_PK_MV");

                entity.ToTable("BIZ_COMMONLAYER_INF_MV");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CommonCd)
                    .HasColumnName("COMMON_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.CatgCd)
                    .HasColumnName("CATG_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.TypVal)
                    .HasColumnName("TYP_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .IsRequired()
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ConstVal)
                    .HasColumnName("CONST_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .IsRequired()
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(4000);

                entity.Property(e => e.InqSeq)
                    .HasColumnName("INQ_SEQ")
                    .HasColumnType("decimal(10, 0)");
            });

            modelBuilder.Entity<BizDurableattrDetMv>(entity =>
            {
                entity.HasKey(e => new { e.DurableId, e.AttrNm })
                    .HasName("BIZ_DURABLEATTR_DET_PK");

                entity.ToTable("BIZ_DURABLEATTR_DET_MV");

                entity.Property(e => e.DurableId)
                    .HasColumnName("DURABLE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AttrNm)
                    .HasColumnName("ATTR_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.AttrVal)
                    .HasColumnName("ATTR_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<BizEqpgrpMasMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.EqpGrpId })
                    .HasName("BIZ_EQPGRP_MAS_PK");

                entity.ToTable("BIZ_EQPGRP_MAS_MV");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpId)
                    .HasColumnName("EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AreaId)
                    .HasColumnName("AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.BatchRuleCd)
                    .HasColumnName("BATCH_RULE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.BayNm)
                    .HasColumnName("BAY_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId1)
                    .HasColumnName("CHG_EQP_GRP_ID_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId10)
                    .HasColumnName("CHG_EQP_GRP_ID_10")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId11)
                    .HasColumnName("CHG_EQP_GRP_ID_11")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId12)
                    .HasColumnName("CHG_EQP_GRP_ID_12")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId13)
                    .HasColumnName("CHG_EQP_GRP_ID_13")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId14)
                    .HasColumnName("CHG_EQP_GRP_ID_14")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId15)
                    .HasColumnName("CHG_EQP_GRP_ID_15")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId16)
                    .HasColumnName("CHG_EQP_GRP_ID_16")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId17)
                    .HasColumnName("CHG_EQP_GRP_ID_17")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId18)
                    .HasColumnName("CHG_EQP_GRP_ID_18")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId19)
                    .HasColumnName("CHG_EQP_GRP_ID_19")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId2)
                    .HasColumnName("CHG_EQP_GRP_ID_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId20)
                    .HasColumnName("CHG_EQP_GRP_ID_20")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId21)
                    .HasColumnName("CHG_EQP_GRP_ID_21")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId22)
                    .HasColumnName("CHG_EQP_GRP_ID_22")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId23)
                    .HasColumnName("CHG_EQP_GRP_ID_23")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId24)
                    .HasColumnName("CHG_EQP_GRP_ID_24")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId25)
                    .HasColumnName("CHG_EQP_GRP_ID_25")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId26)
                    .HasColumnName("CHG_EQP_GRP_ID_26")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId27)
                    .HasColumnName("CHG_EQP_GRP_ID_27")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId28)
                    .HasColumnName("CHG_EQP_GRP_ID_28")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId29)
                    .HasColumnName("CHG_EQP_GRP_ID_29")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId3)
                    .HasColumnName("CHG_EQP_GRP_ID_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId30)
                    .HasColumnName("CHG_EQP_GRP_ID_30")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId31)
                    .HasColumnName("CHG_EQP_GRP_ID_31")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId32)
                    .HasColumnName("CHG_EQP_GRP_ID_32")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId33)
                    .HasColumnName("CHG_EQP_GRP_ID_33")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId34)
                    .HasColumnName("CHG_EQP_GRP_ID_34")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId35)
                    .HasColumnName("CHG_EQP_GRP_ID_35")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId36)
                    .HasColumnName("CHG_EQP_GRP_ID_36")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId37)
                    .HasColumnName("CHG_EQP_GRP_ID_37")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId38)
                    .HasColumnName("CHG_EQP_GRP_ID_38")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId39)
                    .HasColumnName("CHG_EQP_GRP_ID_39")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId4)
                    .HasColumnName("CHG_EQP_GRP_ID_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId40)
                    .HasColumnName("CHG_EQP_GRP_ID_40")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId5)
                    .HasColumnName("CHG_EQP_GRP_ID_5")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId6)
                    .HasColumnName("CHG_EQP_GRP_ID_6")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId7)
                    .HasColumnName("CHG_EQP_GRP_ID_7")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId8)
                    .HasColumnName("CHG_EQP_GRP_ID_8")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgEqpGrpId9)
                    .HasColumnName("CHG_EQP_GRP_ID_9")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DspRuleTyp)
                    .HasColumnName("DSP_RULE_TYP")
                    .HasMaxLength(1024);

                entity.Property(e => e.EmcEqpTyp)
                    .HasColumnName("EMC_EQP_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpTyp)
                    .HasColumnName("EQP_GRP_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxIdleTime)
                    .HasColumnName("MAX_IDLE_TIME")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ObjId)
                    .HasColumnName("OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ParaCatgCd)
                    .HasColumnName("PARA_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvLimitVal)
                    .HasColumnName("RESV_LIMIT_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SeasonEnableVal)
                    .HasColumnName("SEASON_ENABLE_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<BizFurnacemonmappInfMv>(entity =>
            {
                entity.HasKey(e => new { e.LoadTyp, e.MaxProduceCnt, e.MaxMonCnt, e.MonNm, e.ProduceNm })
                    .HasName("BIZ_FURNACEMONMAPP_INF_PK");

                entity.ToTable("BIZ_FURNACEMONMAPP_INF_MV");

                entity.Property(e => e.LoadTyp)
                    .HasColumnName("LOAD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxProduceCnt)
                    .HasColumnName("MAX_PRODUCE_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxMonCnt)
                    .HasColumnName("MAX_MON_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.MonNm)
                    .HasColumnName("MON_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ProduceNm)
                    .HasColumnName("PRODUCE_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(1024);
            });

            modelBuilder.Entity<BizHessdatasyncInf>(entity =>
            {
                entity.HasKey(e => new { e.Timekey, e.WorkId, e.TableNm })
                    .HasName("BIZ_HESSDATASYNC_INF_PK");

                entity.ToTable("BIZ_HESSDATASYNC_INF");

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.WorkId)
                    .HasColumnName("WORK_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.TableNm)
                    .HasColumnName("TABLE_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.CompleteYn)
                    .HasColumnName("COMPLETE_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal1)
                    .HasColumnName("RESV_FIELD_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal2)
                    .HasColumnName("RESV_FIELD_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal3)
                    .HasColumnName("RESV_FIELD_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal4)
                    .HasColumnName("RESV_FIELD_VAL_4")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<BizLotCodMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.LotCd })
                    .HasName("BIZ_LOT_COD_MV_PK");

                entity.ToTable("BIZ_LOT_COD_MV");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.AreaId)
                    .HasColumnName("AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkItemCd)
                    .HasColumnName("CHK_ITEM_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.MetalTyp)
                    .HasColumnName("METAL_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.NpwTyp)
                    .HasColumnName("NPW_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerCdTyp)
                    .HasColumnName("OWNER_CD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.PccbApplyTm)
                    .HasColumnName("PCCB_APPLY_TM")
                    .HasMaxLength(40);

                entity.Property(e => e.PccbStatCd)
                    .HasColumnName("PCCB_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RepresentLotCd)
                    .HasColumnName("REPRESENT_LOT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.StepperDeviceCd)
                    .HasColumnName("STEPPER_DEVICE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.TrackDeviceCd)
                    .HasColumnName("TRACK_DEVICE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.WorkTyp)
                    .HasColumnName("WORK_TYP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BizLotholdInfMv>(entity =>
            {
                entity.HasKey(e => new { e.LotId, e.Timekey })
                    .HasName("BIZ_LOTHOLD_INF_PK");

                entity.ToTable("BIZ_LOTHOLD_INF_MV");

                entity.HasIndex(e => e.Timekey)
                    .HasName("BIZ_LOTHOLD_INF_MV_IX1");

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.CarrierId)
                    .HasColumnName("CARRIER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FindAreaId)
                    .HasColumnName("FIND_AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FindFlowId)
                    .HasColumnName("FIND_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FindOperId)
                    .HasColumnName("FIND_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FrFabId)
                    .HasColumnName("FR_FAB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.HoldCd)
                    .HasColumnName("HOLD_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.HoldDesc)
                    .HasColumnName("HOLD_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.HoldEngrUserId)
                    .HasColumnName("HOLD_ENGR_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.HoldOpratorUserId)
                    .HasColumnName("HOLD_OPRATOR_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.HoldTm)
                    .HasColumnName("HOLD_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.InfoDiscardQty)
                    .HasColumnName("INFO_DISCARD_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InfoDiscardWfId)
                    .HasColumnName("INFO_DISCARD_WF_ID")
                    .HasMaxLength(1000);

                entity.Property(e => e.InfoGradeCd)
                    .HasColumnName("INFO_GRADE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.InfoRsltVal)
                    .HasColumnName("INFO_RSLT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.InfoRwkQty)
                    .HasColumnName("INFO_RWK_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InfoRwkWfId)
                    .HasColumnName("INFO_RWK_WF_ID")
                    .HasMaxLength(1000);

                entity.Property(e => e.MainEqpId)
                    .HasColumnName("MAIN_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveOutTyp)
                    .HasColumnName("MOVE_OUT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ObjId)
                    .HasColumnName("OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OwnerCd)
                    .HasColumnName("OWNER_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProduceTyp)
                    .HasColumnName("PRODUCE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonAreaId)
                    .HasColumnName("REASON_AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonEqpId)
                    .HasColumnName("REASON_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonFlowId)
                    .HasColumnName("REASON_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonOperId)
                    .HasColumnName("REASON_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReleaseCd)
                    .HasColumnName("RELEASE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ReleaseDesc1)
                    .HasColumnName("RELEASE_DESC_1")
                    .HasMaxLength(512);

                entity.Property(e => e.ReleaseDesc2)
                    .HasColumnName("RELEASE_DESC_2")
                    .HasMaxLength(512);

                entity.Property(e => e.ReleaseDesc3)
                    .HasColumnName("RELEASE_DESC_3")
                    .HasMaxLength(512);

                entity.Property(e => e.ReleaseEngrUserId)
                    .HasColumnName("RELEASE_ENGR_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReleaseOpratorUserId)
                    .HasColumnName("RELEASE_OPRATOR_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReleaseTm)
                    .HasColumnName("RELEASE_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReleaseYn)
                    .HasColumnName("RELEASE_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TrblAlarmYn)
                    .HasColumnName("TRBL_ALARM_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.WfQty)
                    .HasColumnName("WF_QTY")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<BizLotmoveInfMv>(entity =>
            {
                entity.HasKey(e => new { e.LotId, e.Timekey })
                    .HasName("BIZ_LOTMOVE_INF_PK");

                entity.ToTable("BIZ_LOTMOVE_INF_MV");

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.BakLotYn)
                    .HasColumnName("BAK_LOT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.CarrierCatgCd)
                    .HasColumnName("CARRIER_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CarrierId)
                    .HasColumnName("CARRIER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CarrierObjId)
                    .HasColumnName("CARRIER_OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkOperId)
                    .HasColumnName("CHK_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChuckId)
                    .HasColumnName("CHUCK_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrEqpId)
                    .HasColumnName("CURR_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CurrEqpRecipeId)
                    .HasColumnName("CURR_EQP_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CurrMesProcStatCd)
                    .HasColumnName("CURR_MES_PROC_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CurrOperId)
                    .HasColumnName("CURR_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CurrRwkStatCd)
                    .HasColumnName("CURR_RWK_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CurrWfQty)
                    .HasColumnName("CURR_WF_QTY")
                    .HasMaxLength(40);

                entity.Property(e => e.DataSendYn)
                    .HasColumnName("DATA_SEND_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.DedicId)
                    .HasColumnName("DEDIC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DiscardSlotNo)
                    .HasColumnName("DISCARD_SLOT_NO")
                    .HasMaxLength(200);

                entity.Property(e => e.EqpGrpId)
                    .HasColumnName("EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EventDesc)
                    .HasColumnName("EVENT_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.HotTyp)
                    .HasColumnName("HOT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventFacId)
                    .HasColumnName("LAST_EVENT_FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventTimekey)
                    .HasColumnName("LAST_EVENT_TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.LastReticleId)
                    .HasColumnName("LAST_RETICLE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotHoldDesc)
                    .HasColumnName("LOT_HOLD_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.LotHoldStatCd)
                    .HasColumnName("LOT_HOLD_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEqpId)
                    .HasColumnName("MAIN_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEventTm)
                    .HasColumnName("MAIN_EVENT_TM")
                    .HasMaxLength(40);

                entity.Property(e => e.MainFlowId)
                    .HasColumnName("MAIN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MergeId)
                    .HasColumnName("MERGE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveEventDesc)
                    .HasColumnName("MOVE_EVENT_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.MoveEventTm)
                    .HasColumnName("MOVE_EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.MoveFacId)
                    .HasColumnName("MOVE_FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveFlowId)
                    .HasColumnName("MOVE_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveOperId)
                    .HasColumnName("MOVE_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveOperatNm)
                    .HasColumnName("MOVE_OPERAT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveProdId)
                    .HasColumnName("MOVE_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveStatCd)
                    .HasColumnName("MOVE_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveTyp)
                    .HasColumnName("MOVE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MultiBakTyp)
                    .HasColumnName("MULTI_BAK_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MultiReturnOperId)
                    .HasColumnName("MULTI_RETURN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.NonProcLotYn)
                    .HasColumnName("NON_PROC_LOT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.ObjId)
                    .HasColumnName("OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OpratorUserId)
                    .HasColumnName("OPRATOR_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ParentLotId)
                    .HasColumnName("PARENT_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdReqId)
                    .HasColumnName("PROD_REQ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProduceTyp)
                    .HasColumnName("PRODUCE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.RecipeDedicEqpLval)
                    .HasColumnName("RECIPE_DEDIC_EQP_LVAL")
                    .HasMaxLength(300);

                entity.Property(e => e.RecipeDedicOperLval)
                    .HasColumnName("RECIPE_DEDIC_OPER_LVAL")
                    .HasMaxLength(300);

                entity.Property(e => e.RecipeDedicRecipeLval)
                    .HasColumnName("RECIPE_DEDIC_RECIPE_LVAL")
                    .HasMaxLength(1200);

                entity.Property(e => e.RecipeDedicStepperLval)
                    .HasColumnName("RECIPE_DEDIC_STEPPER_LVAL")
                    .HasMaxLength(1200);

                entity.Property(e => e.RecvOpratorUserId)
                    .HasColumnName("RECV_OPRATOR_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RecycYn)
                    .HasColumnName("RECYC_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvAttrVal1)
                    .HasColumnName("RESV_ATTR_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvAttrVal2)
                    .HasColumnName("RESV_ATTR_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvAttrVal3)
                    .HasColumnName("RESV_ATTR_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvAttrVal4)
                    .HasColumnName("RESV_ATTR_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvAttrVal5)
                    .HasColumnName("RESV_ATTR_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleVer)
                    .HasColumnName("RETICLE_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.RetnMsgId)
                    .HasColumnName("RETN_MSG_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnCarrierId)
                    .HasColumnName("RETURN_CARRIER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnEventDesc)
                    .HasColumnName("RETURN_EVENT_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.ReturnEventTm)
                    .HasColumnName("RETURN_EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReturnFlowId)
                    .HasColumnName("RETURN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnOperId)
                    .HasColumnName("RETURN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnOperatNm)
                    .HasColumnName("RETURN_OPERAT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnProdId)
                    .HasColumnName("RETURN_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnWfId)
                    .HasColumnName("RETURN_WF_ID")
                    .HasMaxLength(512);

                entity.Property(e => e.ReturnWfQty)
                    .HasColumnName("RETURN_WF_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReturnYn)
                    .HasColumnName("RETURN_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.SendMsgId)
                    .HasColumnName("SEND_MSG_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SendPlanId)
                    .HasColumnName("SEND_PLAN_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SendRecipeId)
                    .HasColumnName("SEND_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.WfQty)
                    .HasColumnName("WF_QTY")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<BizLotscrapInfMv>(entity =>
            {
                entity.HasKey(e => new { e.LotId, e.Timekey })
                    .HasName("PK_BIZ_LOTSCRAP_INF_PK");

                entity.ToTable("BIZ_LOTSCRAP_INF_MV");

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.ChargeAreaId)
                    .HasColumnName("CHARGE_AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.DiscardCarrierId)
                    .HasColumnName("DISCARD_CARRIER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DiscardCd)
                    .HasColumnName("DISCARD_CD")
                    .HasMaxLength(1000);

                entity.Property(e => e.DiscardQty)
                    .HasColumnName("DISCARD_QTY")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrUserId)
                    .HasColumnName("ENGR_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EventDesc)
                    .HasColumnName("EVENT_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FrFabId)
                    .HasColumnName("FR_FAB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainLotId)
                    .HasColumnName("MAIN_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ObjId)
                    .HasColumnName("OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OpratorUserId)
                    .HasColumnName("OPRATOR_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OwnerCd)
                    .HasColumnName("OWNER_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.PositionVal)
                    .HasColumnName("POSITION_VAL")
                    .HasMaxLength(100);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProduceTyp)
                    .HasColumnName("PRODUCE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonEqpId)
                    .HasColumnName("REASON_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonFlowId)
                    .HasColumnName("REASON_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonOperId)
                    .HasColumnName("REASON_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcFabId)
                    .HasColumnName("RESRC_FAB_ID")
                    .HasMaxLength(250);

                entity.Property(e => e.TransDestCd)
                    .HasColumnName("TRANS_DEST_CD")
                    .HasMaxLength(1000);

                entity.Property(e => e.WfId)
                    .HasColumnName("WF_ID")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<BizObjtypdefInf>(entity =>
            {
                entity.HasKey(e => new { e.ObjTypId, e.TypVal })
                    .HasName("BIZ_OBJTYPDEF_INF_PK");

                entity.ToTable("BIZ_OBJTYPDEF_INF");

                entity.Property(e => e.ObjTypId)
                    .HasColumnName("OBJ_TYP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.TypVal)
                    .HasColumnName("TYP_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.AcssTyp)
                    .HasColumnName("ACSS_TYP")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.ResvAttrVal)
                    .HasColumnName("RESV_ATTR_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<BizPfointlockInfMv>(entity =>
            {
                entity.HasKey(e => new { e.RelId, e.FacId, e.ProdId, e.ProdVer, e.FlowId, e.FlowVer, e.OperId, e.OperVer, e.ObjId, e.ObjNm, e.ModelTyp, e.ModelObjNm })
                    .HasName("BIZ_PFOINTLOCK_INF_PK");

                entity.ToTable("BIZ_PFOINTLOCK_INF_MV");

                entity.Property(e => e.RelId)
                    .HasColumnName("REL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer)
                    .HasColumnName("PROD_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ObjId)
                    .HasColumnName("OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ObjNm)
                    .HasColumnName("OBJ_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelTyp)
                    .HasColumnName("MODEL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelObjNm)
                    .HasColumnName("MODEL_OBJ_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.ModelObjAttrVal1)
                    .HasColumnName("MODEL_OBJ_ATTR_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelObjAttrVal10)
                    .HasColumnName("MODEL_OBJ_ATTR_VAL_10")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelObjAttrVal11)
                    .HasColumnName("MODEL_OBJ_ATTR_VAL_11")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelObjAttrVal12)
                    .HasColumnName("MODEL_OBJ_ATTR_VAL_12")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelObjAttrVal2)
                    .HasColumnName("MODEL_OBJ_ATTR_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelObjAttrVal3)
                    .HasColumnName("MODEL_OBJ_ATTR_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelObjAttrVal4)
                    .HasColumnName("MODEL_OBJ_ATTR_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelObjAttrVal5)
                    .HasColumnName("MODEL_OBJ_ATTR_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelObjAttrVal6)
                    .HasColumnName("MODEL_OBJ_ATTR_VAL_6")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelObjAttrVal7)
                    .HasColumnName("MODEL_OBJ_ATTR_VAL_7")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelObjAttrVal8)
                    .HasColumnName("MODEL_OBJ_ATTR_VAL_8")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelObjAttrVal9)
                    .HasColumnName("MODEL_OBJ_ATTR_VAL_9")
                    .HasMaxLength(500);

                entity.Property(e => e.ResvFieldVal1)
                    .HasColumnName("RESV_FIELD_VAL_1")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<BizPrinterlockInfMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.ProdId, e.ProdVer, e.FlowId, e.FlowVer, e.OperId, e.OperVer })
                    .HasName("BIZ_PRINTERLOCK_INF_PK");

                entity.ToTable("BIZ_PRINTERLOCK_INF_MV");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer)
                    .HasColumnName("PROD_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal1)
                    .HasColumnName("RESV_FIELD_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal10)
                    .HasColumnName("RESV_FIELD_VAL_10")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal2)
                    .HasColumnName("RESV_FIELD_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal3)
                    .HasColumnName("RESV_FIELD_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal4)
                    .HasColumnName("RESV_FIELD_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal5)
                    .HasColumnName("RESV_FIELD_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal6)
                    .HasColumnName("RESV_FIELD_VAL_6")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal7)
                    .HasColumnName("RESV_FIELD_VAL_7")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal8)
                    .HasColumnName("RESV_FIELD_VAL_8")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal9)
                    .HasColumnName("RESV_FIELD_VAL_9")
                    .HasMaxLength(40);

                entity.Property(e => e.Unit1Pr1)
                    .HasColumnName("UNIT1_PR1")
                    .HasMaxLength(40);

                entity.Property(e => e.Unit1Pr2)
                    .HasColumnName("UNIT1_PR2")
                    .HasMaxLength(40);

                entity.Property(e => e.Unit1Pr3)
                    .HasColumnName("UNIT1_PR3")
                    .HasMaxLength(40);

                entity.Property(e => e.Unit2Pr1)
                    .HasColumnName("UNIT2_PR1")
                    .HasMaxLength(40);

                entity.Property(e => e.Unit2Pr2)
                    .HasColumnName("UNIT2_PR2")
                    .HasMaxLength(40);

                entity.Property(e => e.Unit2Pr3)
                    .HasColumnName("UNIT2_PR3")
                    .HasMaxLength(40);

                entity.Property(e => e.Unit3Pr1)
                    .HasColumnName("UNIT3_PR1")
                    .HasMaxLength(40);

                entity.Property(e => e.Unit3Pr2)
                    .HasColumnName("UNIT3_PR2")
                    .HasMaxLength(40);

                entity.Property(e => e.Unit3Pr3)
                    .HasColumnName("UNIT3_PR3")
                    .HasMaxLength(40);

                entity.Property(e => e.Unit4Pr1)
                    .HasColumnName("UNIT4_PR1")
                    .HasMaxLength(40);

                entity.Property(e => e.Unit4Pr2)
                    .HasColumnName("UNIT4_PR2")
                    .HasMaxLength(40);

                entity.Property(e => e.Unit4Pr3)
                    .HasColumnName("UNIT4_PR3")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<BizReasonCodMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.ReasonCatgCd, e.ReasonCd })
                    .HasName("BIZ_REASON_COD_PK");

                entity.ToTable("BIZ_REASON_COD_MV");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonCatgCd)
                    .HasColumnName("REASON_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonCd)
                    .HasColumnName("REASON_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ActualHoldTyp)
                    .HasColumnName("ACTUAL_HOLD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoRwkTyp)
                    .HasColumnName("AUTO_RWK_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoTyp)
                    .HasColumnName("AUTO_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DefaultYn)
                    .HasColumnName("DEFAULT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.EnableYn)
                    .HasColumnName("ENABLE_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.FutureHoldActCd)
                    .HasColumnName("FUTURE_HOLD_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.HoldTyp)
                    .HasColumnName("HOLD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.LevelNo)
                    .HasColumnName("LEVEL_NO")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MdmIfTyp)
                    .HasColumnName("MDM_IF_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ObjId)
                    .HasColumnName("OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonDesc)
                    .HasColumnName("REASON_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.TrblAlarmYn)
                    .HasColumnName("TRBL_ALARM_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperReasonCd)
                    .HasColumnName("UPPER_REASON_CD")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<BizRecipemapInfMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.ProdId, e.FlowId, e.OperId, e.EqpId, e.EqpModelCd, e.RecipeId })
                    .HasName("BIZ_RECIPEMAP_INF_PK");

                entity.ToTable("BIZ_RECIPEMAP_INF_MV");

                entity.HasIndex(e => new { e.ProdId, e.EqpId, e.RecipeId })
                    .HasName("BIZ_RECIPEMAP_INF_MV_IX1");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpModelCd)
                    .HasColumnName("EQP_MODEL_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ApplyLotIdPattnVal)
                    .HasColumnName("APPLY_LOT_ID_PATTN_VAL")
                    .HasMaxLength(200);

                entity.Property(e => e.ChemicalLowerLimit)
                    .HasColumnName("CHEMICAL_LOWER_LIMIT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ChemicalUpperLimit)
                    .HasColumnName("CHEMICAL_UPPER_LIMIT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.Dcnt)
                    .HasColumnName("DCNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DelayQtimePrimaryYn)
                    .HasColumnName("DELAY_QTIME_PRIMARY_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.DepThk)
                    .HasColumnName("DEP_THK")
                    .HasMaxLength(40);

                entity.Property(e => e.DepThkRsltVal)
                    .HasColumnName("DEP_THK_RSLT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.EnablePortNo)
                    .HasColumnName("ENABLE_PORT_NO")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpTyp)
                    .HasColumnName("EQP_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.FurnaceMonYn)
                    .HasColumnName("FURNACE_MON_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.IncrTm)
                    .HasColumnName("INCR_TM")
                    .HasMaxLength(40);

                entity.Property(e => e.LastUseTm)
                    .HasColumnName("LAST_USE_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LifecountLowerLimit)
                    .HasColumnName("LIFECOUNT_LOWER_LIMIT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LifecountUpperLimit)
                    .HasColumnName("LIFECOUNT_UPPER_LIMIT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LogicalChambCondCtn)
                    .HasColumnName("LOGICAL_CHAMB_COND_CTN")
                    .HasMaxLength(250);

                entity.Property(e => e.LotCnt)
                    .HasColumnName("LOT_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LowerBatchCnt)
                    .HasColumnName("LOWER_BATCH_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.MeasSlotNm)
                    .HasColumnName("MEAS_SLOT_NM")
                    .HasMaxLength(200);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.PPRelId)
                    .HasColumnName("P_P_REL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ParaInvalidYn)
                    .HasColumnName("PARA_INVALID_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.PhotoDedicRecipeId)
                    .HasColumnName("PHOTO_DEDIC_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PhotoDedicRecipeYn)
                    .HasColumnName("PHOTO_DEDIC_RECIPE_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.PrimaryYn)
                    .HasColumnName("PRIMARY_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.PrimaryYnDelaychemical)
                    .HasColumnName("PRIMARY_YN_DELAYCHEMICAL")
                    .HasMaxLength(40);

                entity.Property(e => e.PrimaryYnDelaylifecount)
                    .HasColumnName("PRIMARY_YN_DELAYLIFECOUNT")
                    .HasMaxLength(40);

                entity.Property(e => e.Priority)
                    .HasColumnName("PRIORITY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProcIntvalAlarmId)
                    .HasColumnName("PROC_INTVAL_ALARM_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProcTm)
                    .HasColumnName("PROC_TM")
                    .HasMaxLength(40);

                entity.Property(e => e.ProcTmIntval)
                    .HasColumnName("PROC_TM_INTVAL")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer)
                    .HasColumnName("PROD_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.QtimeLlVla)
                    .HasColumnName("QTIME_LL_VLA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.QtimeUlVal)
                    .HasColumnName("QTIME_UL_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RawChambCondVal)
                    .HasColumnName("RAW_CHAMB_COND_VAL")
                    .HasMaxLength(250);

                entity.Property(e => e.RecipeIdleDcnt)
                    .HasColumnName("RECIPE_IDLE_DCNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ResvAttrVal1)
                    .HasColumnName("RESV_ATTR_VAL_1")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal10)
                    .HasColumnName("RESV_ATTR_VAL_10")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal2)
                    .HasColumnName("RESV_ATTR_VAL_2")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal3)
                    .HasColumnName("RESV_ATTR_VAL_3")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal4)
                    .HasColumnName("RESV_ATTR_VAL_4")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal5)
                    .HasColumnName("RESV_ATTR_VAL_5")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal6)
                    .HasColumnName("RESV_ATTR_VAL_6")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal7)
                    .HasColumnName("RESV_ATTR_VAL_7")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal8)
                    .HasColumnName("RESV_ATTR_VAL_8")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal9)
                    .HasColumnName("RESV_ATTR_VAL_9")
                    .HasMaxLength(100);

                entity.Property(e => e.SampSeq)
                    .HasColumnName("SAMP_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SlotRecipeIdUseYn)
                    .HasColumnName("SLOT_RECIPE_ID_USE_YN")
                    .HasMaxLength(6);

                entity.Property(e => e.SopFirstRecipeYn)
                    .HasColumnName("SOP_FIRST_RECIPE_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.StatCd)
                    .HasColumnName("STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SubRecipeId)
                    .HasColumnName("SUB_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SubRecipeIdUseYn)
                    .HasColumnName("SUB_RECIPE_ID_USE_YN")
                    .HasMaxLength(6);

                entity.Property(e => e.SubTotCnt)
                    .HasColumnName("SUB_TOT_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.TotCnt)
                    .HasColumnName("TOT_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.TotThk)
                    .HasColumnName("TOT_THK")
                    .HasMaxLength(40);

                entity.Property(e => e.TrblTyp)
                    .HasColumnName("TRBL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperBatchCnt)
                    .HasColumnName("UPPER_BATCH_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.UseLotCnt)
                    .HasColumnName("USE_LOT_CNT")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<BizTfomodelDefMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.FlowId, e.FlowVer, e.OperId, e.OperVer })
                    .HasName("BIZ_TFOMODEL_DEF_PK");

                entity.ToTable("BIZ_TFOMODEL_DEF_MV");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.CondId)
                    .HasColumnName("COND_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtcalLayerYn)
                    .HasColumnName("CRTCAL_LAYER_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolActCd)
                    .HasColumnName("DCOL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolFormulaCtn)
                    .HasColumnName("DCOL_FORMULA_CTN")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.EnableTyp)
                    .HasColumnName("ENABLE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpId)
                    .HasColumnName("EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowGrpNm)
                    .HasColumnName("FLOW_GRP_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowSheetNm)
                    .HasColumnName("FLOW_SHEET_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.FurnaceMonYn)
                    .HasColumnName("FURNACE_MON_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.LotBatchId)
                    .HasColumnName("LOT_BATCH_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperatCrtcalLayerVal)
                    .HasColumnName("OPERAT_CRTCAL_LAYER_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.ProcUnitNm)
                    .HasColumnName("PROC_UNIT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnFlowId)
                    .HasColumnName("RETURN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnOperId)
                    .HasColumnName("RETURN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RptSubAreaId)
                    .HasColumnName("RPT_SUB_AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkFlowId)
                    .HasColumnName("RWK_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkLimitCnt)
                    .HasColumnName("RWK_LIMIT_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkOperId)
                    .HasColumnName("RWK_OPER_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<BizTpfomodelDefMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.FlowId, e.FlowVer, e.OperId, e.OperVer })
                    .HasName("BIZ_TPFOMODEL_DEF_PK");

                entity.ToTable("BIZ_TPFOMODEL_DEF_MV");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoRenEqpId)
                    .HasColumnName("AUTO_REN_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoRenObjNm)
                    .HasColumnName("AUTO_REN_OBJ_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoRenObjTyp)
                    .HasColumnName("AUTO_REN_OBJ_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoRenSuffNm)
                    .HasColumnName("AUTO_REN_SUFF_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoRenTyp)
                    .HasColumnName("AUTO_REN_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.CapaCd)
                    .HasColumnName("CAPA_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CondId)
                    .IsRequired()
                    .HasColumnName("COND_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtcalLayerYn)
                    .HasColumnName("CRTCAL_LAYER_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolActCd)
                    .HasColumnName("DCOL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolFormulaCtn)
                    .HasColumnName("DCOL_FORMULA_CTN")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.EnableTyp)
                    .HasColumnName("ENABLE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpId)
                    .HasColumnName("EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpRecipeId)
                    .HasColumnName("EQP_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowDesc)
                    .HasColumnName("FLOW_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.FurnaceLoadTyp)
                    .HasColumnName("FURNACE_LOAD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.FurnaceMonYn)
                    .HasColumnName("FURNACE_MON_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.FurnaceSortTyp)
                    .HasColumnName("FURNACE_SORT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.IdleToleranceTime)
                    .HasColumnName("IDLE_TOLERANCE_TIME")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LotBatchSize)
                    .HasColumnName("LOT_BATCH_SIZE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NpwReturnFlowId)
                    .HasColumnName("NPW_RETURN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.NpwReturnOperId)
                    .HasColumnName("NPW_RETURN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ObjBehaviorCd)
                    .HasColumnName("OBJ_BEHAVIOR_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.OperatCrtcalLayerVal)
                    .HasColumnName("OPERAT_CRTCAL_LAYER_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.PfoStkId)
                    .HasColumnName("PFO_STK_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer)
                    .IsRequired()
                    .HasColumnName("PROD_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnFlowId)
                    .HasColumnName("RETURN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnOperId)
                    .HasColumnName("RETURN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkFlowId)
                    .HasColumnName("RWK_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkLimitCnt)
                    .HasColumnName("RWK_LIMIT_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkOperId)
                    .HasColumnName("RWK_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.WetEtchR2rYn)
                    .HasColumnName("WET_ETCH_R2R_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.WfLevelR2rYn)
                    .HasColumnName("WF_LEVEL_R2R_YN")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpAlarmHis>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.AlarmId, e.Timekey, e.LotId, e.EventTm })
                    .HasName("DCP_ALARM_HIS_PK");

                entity.ToTable("DCP_ALARM_HIS");

                entity.HasIndex(e => e.CrtTm)
                    .HasName("DCP_ALARM_HIS_IX5");

                entity.HasIndex(e => new { e.FacId, e.EventTm })
                    .HasName("DCP_ALARM_HIS_IX1");

                entity.HasIndex(e => new { e.FacId, e.AlarmId, e.EventTm })
                    .HasName("DCP_ALARM_HIS_IX2");

                entity.HasIndex(e => new { e.FacId, e.LotId, e.EventTm })
                    .HasName("DCP_ALARM_HIS_IX3");

                entity.HasIndex(e => new { e.FacId, e.AlarmId, e.Timekey, e.LotId })
                    .HasName("DCP_ALARM_HIS_IX4");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AlarmId)
                    .HasColumnName("ALARM_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActAttrVal1)
                    .HasColumnName("ACT_ATTR_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ActAttrVal2)
                    .HasColumnName("ACT_ATTR_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ActTyp)
                    .HasColumnName("ACT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.AlarmGrpCd)
                    .HasColumnName("ALARM_GRP_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.AlarmLevelCd)
                    .HasColumnName("ALARM_LEVEL_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CarrierId)
                    .HasColumnName("CARRIER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EventDesc)
                    .HasColumnName("EVENT_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.EventUserId)
                    .HasColumnName("EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LimitTyp)
                    .HasColumnName("LIMIT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerLimitVal)
                    .HasColumnName("LOWER_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleId)
                    .HasColumnName("RETICLE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RsltVal)
                    .HasColumnName("RSLT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.StatCd)
                    .HasColumnName("STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperLimitVal)
                    .HasColumnName("UPPER_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.WfId)
                    .HasColumnName("WF_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpAreaMas>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.LotCd, e.ProdId, e.OperId, e.EqpId, e.ChuckId, e.ShotX, e.ShotY })
                    .HasName("DCP_AREA_MAS_PK");

                entity.ToTable("DCP_AREA_MAS");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ChuckId)
                    .HasColumnName("CHUCK_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ShotX)
                    .HasColumnName("SHOT_X")
                    .HasMaxLength(50);

                entity.Property(e => e.ShotY)
                    .HasColumnName("SHOT_Y")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUsr)
                    .HasColumnName("CRT_USR")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UPDATE_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUsr)
                    .HasColumnName("UPDATE_USR")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DcpBiasavgHis>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.CrtDt, e.MainEqpId })
                    .HasName("DCP_BIASAVG_HIS_PK");

                entity.ToTable("DCP_BIASAVG_HIS");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.MainEqpId)
                    .HasColumnName("MAIN_EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ChuckId)
                    .HasColumnName("CHUCK_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.EdgeOperId)
                    .HasColumnName("EDGE_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.IcansOperId)
                    .HasColumnName("ICANS_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.LinkKey)
                    .HasColumnName("LINK_KEY")
                    .HasMaxLength(128);

                entity.Property(e => e.LinkWfKey)
                    .HasColumnName("LINK_WF_KEY")
                    .HasMaxLength(128);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.NormalOperId)
                    .HasColumnName("NORMAL_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefKey)
                    .HasColumnName("REF_KEY")
                    .HasMaxLength(1024);

                entity.Property(e => e.RefLotId)
                    .HasColumnName("REF_LOT_ID")
                    .HasMaxLength(1024);

                entity.Property(e => e.RefOrgWfId)
                    .HasColumnName("REF_ORG_WF_ID")
                    .HasMaxLength(1024);

                entity.Property(e => e.RefWfId)
                    .HasColumnName("REF_WF_ID")
                    .HasMaxLength(1024);

                entity.Property(e => e.RefWfKey)
                    .HasColumnName("REF_WF_KEY")
                    .HasMaxLength(1024);

                entity.Property(e => e.ReticleId)
                    .HasColumnName("RETICLE_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.StepperRecipeId)
                    .HasColumnName("STEPPER_RECIPE_ID")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<DcpBiasavgparamHis>(entity =>
            {
                entity.HasKey(e => new { e.LinkKey, e.LinkWfKey, e.TestNo, e.Fieldx, e.Fieldy })
                    .HasName("DCP_BIASAVGPARAM_HIS_PK");

                entity.ToTable("DCP_BIASAVGPARAM_HIS");

                entity.Property(e => e.LinkKey)
                    .HasColumnName("LINK_KEY")
                    .HasMaxLength(128);

                entity.Property(e => e.LinkWfKey)
                    .HasColumnName("LINK_WF_KEY")
                    .HasMaxLength(128);

                entity.Property(e => e.TestNo)
                    .HasColumnName("TEST_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldx)
                    .HasColumnName("FIELDX")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldy)
                    .HasColumnName("FIELDY")
                    .HasMaxLength(50);

                entity.Property(e => e.BiasXVal)
                    .HasColumnName("BIAS_X_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.BiasYVal)
                    .HasColumnName("BIAS_Y_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DcpBiaslotHis>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.Timekey, e.MainEqpId, e.WfId })
                    .HasName("DCP_BIASLOT_HIS_PK");

                entity.ToTable("DCP_BIASLOT_HIS");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(50);

                entity.Property(e => e.MainEqpId)
                    .HasColumnName("MAIN_EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.WfId)
                    .HasColumnName("WF_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ChuckId)
                    .HasColumnName("CHUCK_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdgeOperId)
                    .HasColumnName("EDGE_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.IcansLinkKey)
                    .HasColumnName("ICANS_LINK_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.IcansLinkWfKey)
                    .HasColumnName("ICANS_LINK_WF_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.IcansOperId)
                    .HasColumnName("ICANS_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.IncludeYn)
                    .HasColumnName("INCLUDE_YN")
                    .HasMaxLength(10);

                entity.Property(e => e.LastRwkTm)
                    .HasColumnName("LAST_RWK_TM")
                    .HasMaxLength(50);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.NormalOperId)
                    .HasColumnName("NORMAL_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrgWfId)
                    .HasColumnName("ORG_WF_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReticleId)
                    .HasColumnName("RETICLE_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.StepperRecipeId)
                    .HasColumnName("STEPPER_RECIPE_ID")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<DcpBiasparamHis>(entity =>
            {
                entity.HasKey(e => new { e.IcansLinkKey, e.IcansLinkWfKey, e.OvLinkKey, e.OvLinkWfKey, e.TestNo, e.OvFieldx, e.OvFieldy })
                    .HasName("DCP_BIASPARAM_HIS_PK");

                entity.ToTable("DCP_BIASPARAM_HIS");

                entity.Property(e => e.IcansLinkKey)
                    .HasColumnName("ICANS_LINK_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.IcansLinkWfKey)
                    .HasColumnName("ICANS_LINK_WF_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.OvLinkKey)
                    .HasColumnName("OV_LINK_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.OvLinkWfKey)
                    .HasColumnName("OV_LINK_WF_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.TestNo)
                    .HasColumnName("TEST_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.OvFieldx)
                    .HasColumnName("OV_FIELDX")
                    .HasMaxLength(50);

                entity.Property(e => e.OvFieldy)
                    .HasColumnName("OV_FIELDY")
                    .HasMaxLength(50);

                entity.Property(e => e.BiasXVal)
                    .HasColumnName("BIAS_X_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.BiasYVal)
                    .HasColumnName("BIAS_Y_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefectId)
                    .HasColumnName("DEFECT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldrelx)
                    .HasColumnName("FIELDRELX")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldrely)
                    .HasColumnName("FIELDRELY")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldxpos)
                    .HasColumnName("FIELDXPOS")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldypos)
                    .HasColumnName("FIELDYPOS")
                    .HasMaxLength(50);

                entity.Property(e => e.IcansFieldx)
                    .HasColumnName("ICANS_FIELDX")
                    .HasMaxLength(50);

                entity.Property(e => e.IcansFieldy)
                    .HasColumnName("ICANS_FIELDY")
                    .HasMaxLength(50);

                entity.Property(e => e.KnnDesc)
                    .HasColumnName("KNN_DESC")
                    .HasMaxLength(1024);

                entity.Property(e => e.Overlayx)
                    .HasColumnName("OVERLAYX")
                    .HasMaxLength(50);

                entity.Property(e => e.Overlayy)
                    .HasColumnName("OVERLAYY")
                    .HasMaxLength(50);

                entity.Property(e => e.TgtTestNo)
                    .HasColumnName("TGT_TEST_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.TgtX)
                    .HasColumnName("TGT_X")
                    .HasMaxLength(50);

                entity.Property(e => e.TgtY)
                    .HasColumnName("TGT_Y")
                    .HasMaxLength(50);

                entity.Property(e => e.X).HasMaxLength(50);

                entity.Property(e => e.Y).HasMaxLength(50);
            });

            modelBuilder.Entity<DcpCmncodMas>(entity =>
            {
                entity.HasKey(e => new { e.CdGrp, e.CdNm })
                    .HasName("DCP_CMNCOD_MAS_PK");

                entity.ToTable("DCP_CMNCOD_MAS");

                entity.Property(e => e.CdGrp)
                    .HasColumnName("CD_GRP")
                    .HasMaxLength(50);

                entity.Property(e => e.CdNm)
                    .HasColumnName("CD_NM")
                    .HasMaxLength(50);

                entity.Property(e => e.CdVal)
                    .HasColumnName("CD_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DispOrder)
                    .HasColumnName("DISP_ORDER")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DcpCmnmsgHis>(entity =>
            {
                entity.HasKey(e => new { e.DcolDataId, e.FacId })
                    .HasName("DCP_CMNMSG_HIS_PK");

                entity.ToTable("DCP_CMNMSG_HIS");

                entity.HasIndex(e => new { e.CrtTm, e.FacId })
                    .HasName("DCP_CMNMSG_HIS_IX2");

                entity.HasIndex(e => new { e.EqpId, e.CrtTm })
                    .HasName("DCP_CMNMSG_HIS_IX5");

                entity.HasIndex(e => new { e.LotId, e.CrtTm })
                    .HasName("DCP_CMNMSG_HIS_IX4");

                entity.HasIndex(e => new { e.Timekey, e.FacId })
                    .HasName("DCP_CMNMSG_HIS_IX1");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EventCd)
                    .HasColumnName("EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEqpId)
                    .HasColumnName("MAIN_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEventTm)
                    .HasColumnName("MAIN_EVENT_TM")
                    .HasMaxLength(40);

                entity.Property(e => e.MainFlowId)
                    .HasColumnName("MAIN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal1)
                    .HasColumnName("RESV_FIELD_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal10)
                    .HasColumnName("RESV_FIELD_VAL_10")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal2)
                    .HasColumnName("RESV_FIELD_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal3)
                    .HasColumnName("RESV_FIELD_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal4)
                    .HasColumnName("RESV_FIELD_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal5)
                    .HasColumnName("RESV_FIELD_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal6)
                    .HasColumnName("RESV_FIELD_VAL_6")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal7)
                    .HasColumnName("RESV_FIELD_VAL_7")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal8)
                    .HasColumnName("RESV_FIELD_VAL_8")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal9)
                    .HasColumnName("RESV_FIELD_VAL_9")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.XmlMsg)
                    .HasColumnName("XML_MSG")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DcpCommonSpecLotcode>(entity =>
            {
                entity.HasKey(e => new { e.LotCd, e.OperId })
                    .HasName("DCP_COMMON_SPEC_LOTCODE_PK");

                entity.ToTable("DCP_COMMON_SPEC_LOTCODE");

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpCommonSpecMas>(entity =>
            {
                entity.HasKey(e => e.OperId)
                    .HasName("DCP_COMMON_SPEC_MAS_PK");

                entity.ToTable("DCP_COMMON_SPEC_MAS");

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDccopyrltHis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DCP_DCCOPYRLT_HIS");

                entity.HasIndex(e => new { e.FacId, e.LotCd, e.ProdId, e.FlowId, e.OperId, e.DcolId, e.DcolVer, e.TableNm, e.ProcTyp, e.ApplyInf, e.Timekey, e.TranTyp })
                    .HasName("DCP_DCCOPYRLT_HIS_IX01");

                entity.Property(e => e.ApplyInf)
                    .HasColumnName("APPLY_INF")
                    .HasMaxLength(2048);

                entity.Property(e => e.CopyRslt)
                    .HasColumnName("COPY_RSLT")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProcTyp)
                    .HasColumnName("PROC_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RsltDesc)
                    .HasColumnName("RSLT_DESC")
                    .HasMaxLength(2048);

                entity.Property(e => e.SrcDcolId)
                    .HasColumnName("SRC_DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SrcDcolVer)
                    .HasColumnName("SRC_DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.SrcFacId)
                    .HasColumnName("SRC_FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SrcFlowId)
                    .HasColumnName("SRC_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SrcLotCd)
                    .HasColumnName("SRC_LOT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SrcOperId)
                    .HasColumnName("SRC_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SrcProdId)
                    .HasColumnName("SRC_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SrcTableNm)
                    .HasColumnName("SRC_TABLE_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.TableNm)
                    .HasColumnName("TABLE_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.TranTyp)
                    .HasColumnName("TRAN_TYP")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDccopyrltSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DCP_DCCOPYRLT_SUM");

                entity.HasIndex(e => new { e.Timekey, e.FacId, e.LotCd, e.ProdId, e.FlowId, e.OperId, e.DcolId, e.DcolVer })
                    .HasName("DCP_DCCOPYRLT_SUM_IX1");

                entity.Property(e => e.CopyRslt)
                    .HasColumnName("COPY_RSLT")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.NgCnt)
                    .HasColumnName("NG_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.OkCnt)
                    .HasColumnName("OK_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RollbackCnt)
                    .HasColumnName("ROLLBACK_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.SkipCnt)
                    .HasColumnName("SKIP_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolHis>(entity =>
            {
                entity.HasKey(e => new { e.DcolId, e.DcolVer, e.Timekey })
                    .HasName("DCP_DCOL_HIS_PK");

                entity.ToTable("DCP_DCOL_HIS");

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoChgYn)
                    .HasColumnName("AUTO_CHG_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoParaChgYn)
                    .HasColumnName("AUTO_PARA_CHG_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolTyp)
                    .HasColumnName("DCOL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EventCd)
                    .HasColumnName("EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventDesc)
                    .HasColumnName("EVENT_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventUserId)
                    .HasColumnName("EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MatlTyp)
                    .HasColumnName("MATL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.SampCnt)
                    .HasColumnName("SAMP_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SampMatlTyp)
                    .HasColumnName("SAMP_MATL_TYP")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolMas>(entity =>
            {
                entity.HasKey(e => new { e.DcolId, e.DcolVer })
                    .HasName("DCP_DCOL_MAS_PK");

                entity.ToTable("DCP_DCOL_MAS");

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ActiveStatCd)
                    .HasColumnName("ACTIVE_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoChgYn)
                    .HasColumnName("AUTO_CHG_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoParaChgYn)
                    .HasColumnName("AUTO_PARA_CHG_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkStatCd)
                    .HasColumnName("CHK_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkoutTm)
                    .HasColumnName("CHKOUT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChkoutUserId)
                    .HasColumnName("CHKOUT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DcolTyp)
                    .HasColumnName("DCOL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MatlTyp)
                    .HasColumnName("MATL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.SampCnt)
                    .HasColumnName("SAMP_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SampMatlTyp)
                    .HasColumnName("SAMP_MATL_TYP")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolcompHis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DCP_DCOLCOMP_HIS");

                entity.HasIndex(e => new { e.CrtTm, e.DcpDcolDataId, e.EdbDcolDataId, e.SampMatlId, e.EdbSampMatlId })
                    .HasName("DCP_DCOLCOMP_HIS_IX1");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcpDcolCrtTm)
                    .HasColumnName("DCP_DCOL_CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DcpDcolDataId)
                    .HasColumnName("DCP_DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DcpRsltCnt)
                    .HasColumnName("DCP_RSLT_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EdbDcolDataId)
                    .HasColumnName("EDB_DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EdbFacId)
                    .HasColumnName("EDB_FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EdbProdId)
                    .HasColumnName("EDB_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EdbRsltCnt)
                    .HasColumnName("EDB_RSLT_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EdbSampMatlId)
                    .HasColumnName("EDB_SAMP_MATL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.NgNotmatchCnt)
                    .HasColumnName("NG_NOTMATCH_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NgNovalCnt)
                    .HasColumnName("NG_NOVAL_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OkCnt)
                    .HasColumnName("OK_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SampMatlId)
                    .HasColumnName("SAMP_MATL_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolcomprltInf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DCP_DCOLCOMPRLT_INF");

                entity.HasIndex(e => new { e.FacId, e.ProdId, e.FlowId, e.OperId })
                    .HasName("DCP_DCOLCOMPRLT_INF_IX1");

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(1024);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ValidRslt)
                    .HasColumnName("VALID_RSLT")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolconvcolInf>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.ProdId, e.FlowId, e.OperId, e.EqpGrpId })
                    .HasName("DCP_DCOLCONVCOL_INF_PK");

                entity.ToTable("DCP_DCOLCONVCOL_INF");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpId)
                    .HasColumnName("EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcoldataInf>(entity =>
            {
                entity.HasKey(e => e.DcolDataId)
                    .HasName("DCP_DCOLDATA_INF_PK");

                entity.ToTable("DCP_DCOLDATA_INF");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BatchZoneCd)
                    .HasColumnName("BATCH_ZONE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtDesc)
                    .HasColumnName("CRT_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolTyp)
                    .HasColumnName("DCOL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpRecipeId)
                    .HasColumnName("EQP_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEqpId)
                    .HasColumnName("MAIN_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEventTm)
                    .HasColumnName("MAIN_EVENT_TM")
                    .HasMaxLength(40);

                entity.Property(e => e.MainFlowId)
                    .HasColumnName("MAIN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MatlNm)
                    .HasColumnName("MATL_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.MatlTyp)
                    .HasColumnName("MATL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MesSendSkip)
                    .HasColumnName("MES_SEND_SKIP")
                    .HasMaxLength(10);

                entity.Property(e => e.MsgTid)
                    .HasColumnName("MSG_TID")
                    .HasMaxLength(150);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.OutTyp)
                    .HasColumnName("OUT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer)
                    .HasColumnName("PROD_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.SampLotId)
                    .HasColumnName("SAMP_LOT_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcoldataitemInf>(entity =>
            {
                entity.HasKey(e => new { e.DcolDataId, e.DcolItemCd })
                    .HasName("DCP_DCOLDATAITEM_INF_PK");

                entity.ToTable("DCP_DCOLDATAITEM_INF");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcoldatarsltInf>(entity =>
            {
                entity.HasKey(e => new { e.DcolDataId, e.SampMatlId, e.DcolItemCd, e.DcsiteId, e.DervItemNm })
                    .HasName("DCP_DCOLDATARSLT_INF_PK");

                entity.ToTable("DCP_DCOLDATARSLT_INF");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SampMatlId)
                    .HasColumnName("SAMP_MATL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DcsiteId)
                    .HasColumnName("DCSITE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DervItemNm)
                    .HasColumnName("DERV_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.DataTyp)
                    .HasColumnName("DATA_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.Desc)
                    .HasColumnName("DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.ItemType)
                    .HasColumnName("ITEM_TYPE")
                    .HasMaxLength(80);

                entity.Property(e => e.RsltVal)
                    .HasColumnName("RSLT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UnitId)
                    .HasColumnName("UNIT_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcoldatasampInf>(entity =>
            {
                entity.HasKey(e => new { e.DcolDataId, e.SampMatlId })
                    .HasName("DCP_DCOLDATASAMP_INF_PK");

                entity.ToTable("DCP_DCOLDATASAMP_INF");

                entity.HasIndex(e => new { e.SampMatlId, e.DcolDataId })
                    .HasName("DCP_DCOLDATASAMP_INF_IX1");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SampMatlId)
                    .HasColumnName("SAMP_MATL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtDesc)
                    .HasColumnName("CRT_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SampMatlTyp)
                    .HasColumnName("SAMP_MATL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.SampNo)
                    .HasColumnName("SAMP_NO")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DcpDcoldervitemDet>(entity =>
            {
                entity.HasKey(e => new { e.DcolId, e.DcolVer, e.DervItemNm })
                    .HasName("DCP_DCOLDERVITEM_DET_PK");

                entity.ToTable("DCP_DCOLDERVITEM_DET");

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DervItemNm)
                    .HasColumnName("DERV_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.AliasItemNm)
                    .HasColumnName("ALIAS_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DataTyp)
                    .HasColumnName("DATA_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolTyp)
                    .HasColumnName("DCOL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DervExpr)
                    .HasColumnName("DERV_EXPR")
                    .HasMaxLength(2048);

                entity.Property(e => e.DervFormula)
                    .HasColumnName("DERV_FORMULA")
                    .HasMaxLength(250);

                entity.Property(e => e.DervRawFormula)
                    .HasColumnName("DERV_RAW_FORMULA")
                    .HasMaxLength(1024);

                entity.Property(e => e.DervTyp)
                    .HasColumnName("DERV_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DispOptTyp)
                    .HasColumnName("DISP_OPT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.SecondVal)
                    .HasColumnName("SECOND_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcoldervitemHis>(entity =>
            {
                entity.HasKey(e => new { e.DcolId, e.DcolVer, e.DervItemNm, e.Timekey })
                    .HasName("DCP_DCOLDERVITEM_HIS_PK");

                entity.ToTable("DCP_DCOLDERVITEM_HIS");

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DervItemNm)
                    .HasColumnName("DERV_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.AliasItemNm)
                    .HasColumnName("ALIAS_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DataTyp)
                    .HasColumnName("DATA_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolTyp)
                    .HasColumnName("DCOL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DervExpr)
                    .HasColumnName("DERV_EXPR")
                    .HasMaxLength(2048);

                entity.Property(e => e.DervFormula)
                    .HasColumnName("DERV_FORMULA")
                    .HasMaxLength(250);

                entity.Property(e => e.DervRawFormula)
                    .HasColumnName("DERV_RAW_FORMULA")
                    .HasMaxLength(1024);

                entity.Property(e => e.DervTyp)
                    .HasColumnName("DERV_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DispOptTyp)
                    .HasColumnName("DISP_OPT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventCd)
                    .HasColumnName("EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventDesc)
                    .HasColumnName("EVENT_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventUserId)
                    .HasColumnName("EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.SecondVal)
                    .HasColumnName("SECOND_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcoldrvitemeqlimitHis>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.DcolId, e.DcolVer, e.DervItemNm, e.OperId, e.EqpId, e.Timekey })
                    .HasName("DCP_DCOLDRVITEMEQLIMIT_HIS_PK");

                entity.ToTable("DCP_DCOLDRVITEMEQLIMIT_HIS");

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DervItemNm)
                    .HasColumnName("DERV_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventCd)
                    .HasColumnName("EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventDesc)
                    .HasColumnName("EVENT_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventUserId)
                    .HasColumnName("EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerRwkLimitVal)
                    .HasColumnName("LOWER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkActCd)
                    .HasColumnName("RWK_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcRuleChkYn)
                    .HasColumnName("SPC_RULE_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperRwkLimitVal)
                    .HasColumnName("UPPER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcoldrvitemeqlimitInf>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.DcolId, e.DcolVer, e.DervItemNm, e.OperId, e.EqpId })
                    .HasName("DCP_DCOLDRVITEMEQLIMIT_INF_PK");

                entity.ToTable("DCP_DCOLDRVITEMEQLIMIT_INF");

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DervItemNm)
                    .HasColumnName("DERV_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerRwkLimitVal)
                    .HasColumnName("LOWER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkActCd)
                    .HasColumnName("RWK_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcRuleChkYn)
                    .HasColumnName("SPC_RULE_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperRwkLimitVal)
                    .HasColumnName("UPPER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcoldrvitemlimitHis>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.DcolId, e.DcolVer, e.DervItemNm, e.Timekey })
                    .HasName("DCP_DCP_DCOLDRVITEMLIMIT_HIS_PK");

                entity.ToTable("DCP_DCOLDRVITEMLIMIT_HIS");

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DervItemNm)
                    .HasColumnName("DERV_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventCd)
                    .HasColumnName("EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventDesc)
                    .HasColumnName("EVENT_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventUserId)
                    .HasColumnName("EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerChgstrLimitVal)
                    .HasColumnName("LOWER_CHGSTR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerRwkLimitVal)
                    .HasColumnName("LOWER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerSndrclLimitVal)
                    .HasColumnName("LOWER_SNDRCL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkActCd)
                    .HasColumnName("RWK_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcRuleChkYn)
                    .HasColumnName("SPC_RULE_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperChgstrLimitVal)
                    .HasColumnName("UPPER_CHGSTR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperRwkLimitVal)
                    .HasColumnName("UPPER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperSndrclLimitVal)
                    .HasColumnName("UPPER_SNDRCL_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcoldrvitemlimitInf>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.DcolId, e.DcolVer, e.DervItemNm })
                    .HasName("DCP_DCOLDRVITEMLIMIT_INF_PK");

                entity.ToTable("DCP_DCOLDRVITEMLIMIT_INF");

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DervItemNm)
                    .HasColumnName("DERV_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerChgstrLimitVal)
                    .HasColumnName("LOWER_CHGSTR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerRwkLimitVal)
                    .HasColumnName("LOWER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerSndrclLimitVal)
                    .HasColumnName("LOWER_SNDRCL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkActCd)
                    .HasColumnName("RWK_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcRuleChkYn)
                    .HasColumnName("SPC_RULE_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperChgstrLimitVal)
                    .HasColumnName("UPPER_CHGSTR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperRwkLimitVal)
                    .HasColumnName("UPPER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperSndrclLimitVal)
                    .HasColumnName("UPPER_SNDRCL_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcoldrvnpweqlimitInf>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.DcolId, e.DcolVer, e.DervItemNm, e.EqpId, e.SlotId })
                    .HasName("DCP_DCOLDRVNPWEQLIMIT_INF_PK");

                entity.ToTable("DCP_DCOLDRVNPWEQLIMIT_INF");

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DervItemNm)
                    .HasColumnName("DERV_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SlotId)
                    .HasColumnName("SLOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerRwkLimitVal)
                    .HasColumnName("LOWER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkActCd)
                    .HasColumnName("RWK_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcRuleChkYn)
                    .HasColumnName("SPC_RULE_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperRwkLimitVal)
                    .HasColumnName("UPPER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolextHis>(entity =>
            {
                entity.HasKey(e => new { e.Tid, e.AliasNm, e.Fab, e.EqpId, e.Prod, e.ProcFlow, e.Oper, e.LotId, e.CrtTm, e.DcolDataId })
                    .HasName("DCP_DCOLEXT_HIS_PK");

                entity.ToTable("DCP_DCOLEXT_HIS");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasMaxLength(80);

                entity.Property(e => e.AliasNm)
                    .HasColumnName("ALIAS_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.Fab)
                    .HasColumnName("FAB")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Prod)
                    .HasColumnName("PROD")
                    .HasMaxLength(40);

                entity.Property(e => e.ProcFlow)
                    .HasColumnName("PROC_FLOW")
                    .HasMaxLength(40);

                entity.Property(e => e.Oper)
                    .HasColumnName("OPER")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(22, 0)");

                entity.Property(e => e.BatchCnt)
                    .HasColumnName("BATCH_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.BatchId)
                    .HasColumnName("BATCH_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CarrierId)
                    .HasColumnName("CARRIER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PortId)
                    .HasColumnName("PORT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProcJobId)
                    .HasColumnName("PROC_JOB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleId)
                    .HasColumnName("RETICLE_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolformulabaseHis>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.ProdId, e.FlowId, e.OperId, e.FormulaNm, e.Timekey })
                    .HasName("DCP_DCOLFORMULABASE_HIS_PK");

                entity.ToTable("DCP_DCOLFORMULABASE_HIS");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FormulaNm)
                    .HasColumnName("FORMULA_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.ApplyYn)
                    .HasColumnName("APPLY_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.CalcFormulaCtn)
                    .HasColumnName("CALC_FORMULA_CTN")
                    .HasMaxLength(200);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EventCd)
                    .HasColumnName("EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventDesc)
                    .HasColumnName("EVENT_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventUserId)
                    .HasColumnName("EVENT_USER_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolformulabaseInf>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.ProdId, e.FlowId, e.OperId, e.FormulaNm });

                entity.ToTable("DCP_DCOLFORMULABASE_INF");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FormulaNm)
                    .HasColumnName("FORMULA_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ApplyYn)
                    .HasColumnName("APPLY_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.CalcFormulaCtn)
                    .HasColumnName("CALC_FORMULA_CTN")
                    .HasMaxLength(200);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolformulaitemDet>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.ProdId, e.FlowId, e.OperId, e.FormulaNm, e.FormulaCharVal })
                    .HasName("DCP_DCOLFORMULAITEM_DET_IX1");

                entity.ToTable("DCP_DCOLFORMULAITEM_DET");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FormulaNm)
                    .HasColumnName("FORMULA_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.FormulaCharVal)
                    .HasColumnName("FORMULA_CHAR_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.CalcYn)
                    .HasColumnName("CALC_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.CaloperCd)
                    .HasColumnName("CALOPER_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CountifMax)
                    .HasColumnName("COUNTIF_MAX")
                    .HasMaxLength(40);

                entity.Property(e => e.CountifMin)
                    .HasColumnName("COUNTIF_MIN")
                    .HasMaxLength(40);

                entity.Property(e => e.FormulaTyp)
                    .HasColumnName("FORMULA_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.NoFormulaCd)
                    .HasColumnName("NO_FORMULA_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.PointVal)
                    .HasColumnName("POINT_VAL")
                    .HasMaxLength(1500);

                entity.Property(e => e.PreFlowId)
                    .HasColumnName("PRE_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PreOperId)
                    .HasColumnName("PRE_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PreProdId)
                    .HasColumnName("PRE_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RearrangePoint)
                    .HasColumnName("REARRANGE_POINT")
                    .HasMaxLength(1500);
            });

            modelBuilder.Entity<DcpDcolformulaitemHis>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.ProdId, e.FlowId, e.OperId, e.FormulaNm, e.FormulaCharVal, e.Timekey })
                    .HasName("DCP_DCOLFORMULAITEM_HIS_IX1");

                entity.ToTable("DCP_DCOLFORMULAITEM_HIS");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FormulaNm)
                    .HasColumnName("FORMULA_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.FormulaCharVal)
                    .HasColumnName("FORMULA_CHAR_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.CalcYn)
                    .HasColumnName("CALC_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.CaloperCd)
                    .HasColumnName("CALOPER_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CountifMax)
                    .HasColumnName("COUNTIF_MAX")
                    .HasMaxLength(40);

                entity.Property(e => e.CountifMin)
                    .HasColumnName("COUNTIF_MIN")
                    .HasMaxLength(40);

                entity.Property(e => e.EventCd)
                    .HasColumnName("EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventDesc)
                    .HasColumnName("EVENT_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventUserId)
                    .HasColumnName("EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FormulaTyp)
                    .HasColumnName("FORMULA_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.NoFormulaCd)
                    .HasColumnName("NO_FORMULA_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.PointVal)
                    .HasColumnName("POINT_VAL")
                    .HasMaxLength(400);

                entity.Property(e => e.PreFlowId)
                    .HasColumnName("PRE_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PreOperId)
                    .HasColumnName("PRE_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PreProdId)
                    .HasColumnName("PRE_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RearrangePoint)
                    .HasColumnName("REARRANGE_POINT")
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<DcpDcolitemCod>(entity =>
            {
                entity.HasKey(e => e.DcolItemCd)
                    .HasName("DCP_DCOLITEM_COD_PK");

                entity.ToTable("DCP_DCOLITEM_COD");

                entity.HasIndex(e => e.ItemTyp)
                    .HasName("DCP_DCOLITEM_COD_IX2");

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CalcFmtTyp)
                    .HasColumnName("CALC_FMT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.CalcUnitVal)
                    .HasColumnName("CALC_UNIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DataTyp)
                    .HasColumnName("DATA_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EfctDigitVal)
                    .HasColumnName("EFCT_DIGIT_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExcludeVal1)
                    .HasColumnName("EXCLUDE_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ExcludeVal2)
                    .HasColumnName("EXCLUDE_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ExcludeVal3)
                    .HasColumnName("EXCLUDE_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ExcludeVal4)
                    .HasColumnName("EXCLUDE_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ExcludeVal5)
                    .HasColumnName("EXCLUDE_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.Idx)
                    .HasColumnName("IDX")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ItemTyp)
                    .HasColumnName("ITEM_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxUnitVal)
                    .HasColumnName("MAX_UNIT_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ObjItemNm)
                    .HasColumnName("OBJ_ITEM_NM")
                    .HasMaxLength(120);

                entity.Property(e => e.RawDataUnitVal)
                    .HasColumnName("RAW_DATA_UNIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UomCd)
                    .HasColumnName("UOM_CD")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolitemHis>(entity =>
            {
                entity.HasKey(e => new { e.DcolId, e.DcolVer, e.DcolItemCd, e.Timekey })
                    .HasName("DCP_DCOLITEM_HIS_PK");

                entity.ToTable("DCP_DCOLITEM_HIS");

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.AliasItemNm)
                    .HasColumnName("ALIAS_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DataTyp)
                    .HasColumnName("DATA_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolItemCatgCd)
                    .HasColumnName("DCOL_ITEM_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolTyp)
                    .HasColumnName("DCOL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DcsiteCnt)
                    .HasColumnName("DCSITE_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DcsiteNm)
                    .HasColumnName("DCSITE_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.DispOptTyp)
                    .HasColumnName("DISP_OPT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventCd)
                    .HasColumnName("EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventDesc)
                    .HasColumnName("EVENT_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventUserId)
                    .HasColumnName("EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ItemSeq)
                    .HasColumnName("ITEM_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.ObjItemNm)
                    .HasColumnName("OBJ_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.OutofspecChkCtn)
                    .HasColumnName("OUTOFSPEC_CHK_CTN")
                    .HasMaxLength(40);

                entity.Property(e => e.ParentDcolItemNm)
                    .HasColumnName("PARENT_DCOL_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.PointSeq)
                    .HasColumnName("POINT_SEQ")
                    .HasMaxLength(200);

                entity.Property(e => e.RenmDcolItemCd)
                    .HasColumnName("RENM_DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcS1Desc)
                    .HasColumnName("RESRC_S1_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcS1PersonCtn)
                    .HasColumnName("RESRC_S1_PERSON_CTN")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcS2Desc)
                    .HasColumnName("RESRC_S2_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcS2PersonCtn)
                    .HasColumnName("RESRC_S2_PERSON_CTN")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcS3Desc)
                    .HasColumnName("RESRC_S3_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcS3PersonCtn)
                    .HasColumnName("RESRC_S3_PERSON_CTN")
                    .HasMaxLength(40);

                entity.Property(e => e.SlotNo)
                    .HasColumnName("SLOT_NO")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcRuleChkYn)
                    .HasColumnName("SPC_RULE_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UnitCnt)
                    .HasColumnName("UNIT_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolitemInf>(entity =>
            {
                entity.HasKey(e => new { e.DcolId, e.DcolVer, e.DcolItemCd })
                    .HasName("DCP_DCOLITEM_INF_PK");

                entity.ToTable("DCP_DCOLITEM_INF");

                entity.HasIndex(e => e.DcolId)
                    .HasName("DCP_DCOLITEM_INF_IX01");

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.AliasItemNm)
                    .HasColumnName("ALIAS_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DataTyp)
                    .HasColumnName("DATA_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolItemCatgCd)
                    .HasColumnName("DCOL_ITEM_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolTyp)
                    .HasColumnName("DCOL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DcsiteCnt)
                    .HasColumnName("DCSITE_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DcsiteNm)
                    .HasColumnName("DCSITE_NM")
                    .HasMaxLength(250);

                entity.Property(e => e.DispOptTyp)
                    .HasColumnName("DISP_OPT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ItemSeq)
                    .HasColumnName("ITEM_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.ObjItemNm)
                    .HasColumnName("OBJ_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.OutofspecChkCtn)
                    .HasColumnName("OUTOFSPEC_CHK_CTN")
                    .HasMaxLength(40);

                entity.Property(e => e.ParentDcolItemNm)
                    .HasColumnName("PARENT_DCOL_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.PointSeq)
                    .HasColumnName("POINT_SEQ")
                    .HasMaxLength(200);

                entity.Property(e => e.RenmDcolItemCd)
                    .HasColumnName("RENM_DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcS1Desc)
                    .HasColumnName("RESRC_S1_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcS1PersonCtn)
                    .HasColumnName("RESRC_S1_PERSON_CTN")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcS2Desc)
                    .HasColumnName("RESRC_S2_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcS2PersonCtn)
                    .HasColumnName("RESRC_S2_PERSON_CTN")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcS3Desc)
                    .HasColumnName("RESRC_S3_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcS3PersonCtn)
                    .HasColumnName("RESRC_S3_PERSON_CTN")
                    .HasMaxLength(40);

                entity.Property(e => e.SlotNo)
                    .HasColumnName("SLOT_NO")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcRuleChkYn)
                    .HasColumnName("SPC_RULE_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UnitCnt)
                    .HasColumnName("UNIT_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolitemeqlimitHis>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.DcolId, e.DcolVer, e.DcolItemCd, e.OperId, e.EqpId, e.Timekey })
                    .HasName("DCP_DCOLITEMEQLIMIT_HIS_PK");

                entity.ToTable("DCP_DCOLITEMEQLIMIT_HIS");

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventCd)
                    .HasColumnName("EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventDesc)
                    .HasColumnName("EVENT_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventUserId)
                    .HasColumnName("EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerRwkLimitVal)
                    .HasColumnName("LOWER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.OutPointVal)
                    .HasColumnName("OUT_POINT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkActCd)
                    .HasColumnName("RWK_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcRuleChkYn)
                    .HasColumnName("SPC_RULE_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperRwkLimitVal)
                    .HasColumnName("UPPER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolitemeqlimitInf>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.DcolId, e.DcolVer, e.DcolItemCd, e.OperId, e.EqpId })
                    .HasName("DCP_DCOLITEMEQLIMIT_INF_PK");

                entity.ToTable("DCP_DCOLITEMEQLIMIT_INF");

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerRwkLimitVal)
                    .HasColumnName("LOWER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.OutPointVal)
                    .HasColumnName("OUT_POINT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkActCd)
                    .HasColumnName("RWK_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcRuleChkYn)
                    .HasColumnName("SPC_RULE_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperRwkLimitVal)
                    .HasColumnName("UPPER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolitemlimitHis>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.DcolId, e.DcolVer, e.DcolItemCd, e.Timekey })
                    .HasName("DCP_DCOLITEMLIMIT_HIS_PK");

                entity.ToTable("DCP_DCOLITEMLIMIT_HIS");

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventCd)
                    .HasColumnName("EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EventDesc)
                    .HasColumnName("EVENT_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventUserId)
                    .HasColumnName("EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerChgstrLimitVal)
                    .HasColumnName("LOWER_CHGSTR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerRwkLimitVal)
                    .HasColumnName("LOWER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerSndrclLimitVal)
                    .HasColumnName("LOWER_SNDRCL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.OutPointVal)
                    .HasColumnName("OUT_POINT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkActCd)
                    .HasColumnName("RWK_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcRuleChkYn)
                    .HasColumnName("SPC_RULE_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperChgstrLimitVal)
                    .HasColumnName("UPPER_CHGSTR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperRwkLimitVal)
                    .HasColumnName("UPPER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperSndrclLimitVal)
                    .HasColumnName("UPPER_SNDRCL_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolitemlimitInf>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.DcolId, e.DcolVer, e.DcolItemCd })
                    .HasName("DCP_DCOLITEMLIMIT_INF_IX1");

                entity.ToTable("DCP_DCOLITEMLIMIT_INF");

                entity.HasIndex(e => new { e.DcolId, e.DcolItemCd })
                    .HasName("DCP_DCOLITEMLIMIT_INF_IX02");

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerChgstrLimitVal)
                    .HasColumnName("LOWER_CHGSTR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerRwkLimitVal)
                    .HasColumnName("LOWER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerSndrclLimitVal)
                    .HasColumnName("LOWER_SNDRCL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.OutPointVal)
                    .HasColumnName("OUT_POINT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkActCd)
                    .HasColumnName("RWK_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcRuleChkYn)
                    .HasColumnName("SPC_RULE_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperChgstrLimitVal)
                    .HasColumnName("UPPER_CHGSTR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperRwkLimitVal)
                    .HasColumnName("UPPER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperSndrclLimitVal)
                    .HasColumnName("UPPER_SNDRCL_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolitemnpweqlimitInf>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.DcolId, e.DcolVer, e.DcolItemCd, e.EqpId, e.SlotId })
                    .HasName("DCP_DCOLITEMNPWEQLIMIT_INF_PK");

                entity.ToTable("DCP_DCOLITEMNPWEQLIMIT_INF");

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SlotId)
                    .HasColumnName("SLOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CautActCd)
                    .HasColumnName("CAUT_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtrlActCd)
                    .HasColumnName("CTRL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrActCd)
                    .HasColumnName("ENGR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrActCd)
                    .HasColumnName("ERR_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FatalActCd)
                    .HasColumnName("FATAL_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCautLimitVal)
                    .HasColumnName("LOWER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerCtrlLimitVal)
                    .HasColumnName("LOWER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerEngrLimitVal)
                    .HasColumnName("LOWER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerErrLimitVal)
                    .HasColumnName("LOWER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerFatalLimitVal)
                    .HasColumnName("LOWER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerRwkLimitVal)
                    .HasColumnName("LOWER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerScreenLimitVal)
                    .HasColumnName("LOWER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.OutPointVal)
                    .HasColumnName("OUT_POINT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkActCd)
                    .HasColumnName("RWK_ACT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcRuleChkYn)
                    .HasColumnName("SPC_RULE_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCautLimitVal)
                    .HasColumnName("UPPER_CAUT_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperCtrlLimitVal)
                    .HasColumnName("UPPER_CTRL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEngrLimitVal)
                    .HasColumnName("UPPER_ENGR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperErrLimitVal)
                    .HasColumnName("UPPER_ERR_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperFatalLimitVal)
                    .HasColumnName("UPPER_FATAL_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperRwkLimitVal)
                    .HasColumnName("UPPER_RWK_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperScreenLimitVal)
                    .HasColumnName("UPPER_SCREEN_LIMIT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcollimitsepInf>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.TechNm, e.LotCd, e.OperId, e.DcolItemCd })
                    .HasName("DCP_DCOLLIMITSEP_INF_PK");

                entity.ToTable("DCP_DCOLLIMITSEP_INF");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.TechNm)
                    .HasColumnName("TECH_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DeleteYn)
                    .HasColumnName("DELETE_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerLimitVal)
                    .HasColumnName("LOWER_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerSepCode)
                    .HasColumnName("LOWER_SEP_CODE")
                    .HasMaxLength(40);

                entity.Property(e => e.LowerSetupVal)
                    .HasColumnName("LOWER_SETUP_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.SepTyp)
                    .HasColumnName("SEP_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.SeplimitDesc)
                    .HasColumnName("SEPLIMIT_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.UpperLimitVal)
                    .HasColumnName("UPPER_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperSepCode)
                    .HasColumnName("UPPER_SEP_CODE")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperSetupVal)
                    .HasColumnName("UPPER_SETUP_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolporefInf>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.ProdId, e.FlowId, e.OperId, e.PrePostItemNm, e.PreProdId, e.PreFlowId, e.PreOperId })
                    .HasName("DCP_DCOLPOREF_INF_IX1");

                entity.ToTable("DCP_DCOLPOREF_INF");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PrePostItemNm)
                    .HasColumnName("PRE_POST_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.PreProdId)
                    .HasColumnName("PRE_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PreFlowId)
                    .HasColumnName("PRE_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PreOperId)
                    .HasColumnName("PRE_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CalcFmtTyp)
                    .HasColumnName("CALC_FMT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.CalcFmtTyp2nd)
                    .HasColumnName("CALC_FMT_TYP_2ND")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcsiteId)
                    .HasColumnName("DCSITE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FirstCaloperLocTyp)
                    .HasColumnName("FIRST_CALOPER_LOC_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.PfoMstTyp)
                    .HasColumnName("PFO_MST_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.PostItemNm)
                    .HasColumnName("POST_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.PreItemNm)
                    .HasColumnName("PRE_ITEM_NM")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolproceqpInf>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.DcolId, e.DcolVer, e.ItemNm, e.LotId, e.OperId })
                    .HasName("DCP_DCOLPROCEQP_INF_PK");

                entity.ToTable("DCP_DCOLPROCEQP_INF");

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ItemNm)
                    .HasColumnName("ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolTm)
                    .HasColumnName("DCOL_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal1)
                    .HasColumnName("RESV_FIELD_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal10)
                    .HasColumnName("RESV_FIELD_VAL_10")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal2)
                    .HasColumnName("RESV_FIELD_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal3)
                    .HasColumnName("RESV_FIELD_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal4)
                    .HasColumnName("RESV_FIELD_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal5)
                    .HasColumnName("RESV_FIELD_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal6)
                    .HasColumnName("RESV_FIELD_VAL_6")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal7)
                    .HasColumnName("RESV_FIELD_VAL_7")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal8)
                    .HasColumnName("RESV_FIELD_VAL_8")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal9)
                    .HasColumnName("RESV_FIELD_VAL_9")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpDcolsiteInf>(entity =>
            {
                entity.HasKey(e => new { e.RelDcsiteNm, e.DcsiteId })
                    .HasName("DCP_DCOLSITE_INF_IX1");

                entity.ToTable("DCP_DCOLSITE_INF");

                entity.Property(e => e.RelDcsiteNm)
                    .HasColumnName("REL_DCSITE_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.DcsiteId)
                    .HasColumnName("DCSITE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DcsiteCnt)
                    .HasColumnName("DCSITE_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DcsitePositionNo)
                    .HasColumnName("DCSITE_POSITION_NO")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DcsiteSeq)
                    .HasColumnName("DCSITE_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DcsiteTyp)
                    .HasColumnName("DCSITE_TYP")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxDcsiteCnt)
                    .HasColumnName("MAX_DCSITE_CNT")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DcpDcolsummHis>(entity =>
            {
                entity.HasKey(e => e.DcolDataId)
                    .HasName("DCP_DCOLSUMM_HIS_PK");

                entity.ToTable("DCP_DCOLSUMM_HIS");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ErrCnt)
                    .HasColumnName("ERR_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProcessNm)
                    .HasColumnName("PROCESS_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ServerIp)
                    .HasColumnName("SERVER_IP")
                    .HasMaxLength(40);

                entity.Property(e => e.TotProcTm)
                    .HasColumnName("TOT_PROC_TM")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DcpElapsedHis>(entity =>
            {
                entity.HasKey(e => new { e.DcolDataId, e.TraceSeq })
                    .HasName("DCP_ELAPSED_HIS_PK");

                entity.ToTable("DCP_ELAPSED_HIS");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TraceSeq)
                    .HasColumnName("TRACE_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IntvalTm)
                    .HasColumnName("INTVAL_TM")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MethodNm)
                    .HasColumnName("METHOD_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.TraceDesc)
                    .HasColumnName("TRACE_DESC")
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<DcpEmailMas>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.Email })
                    .HasName("DCP_EMAIL_MAS_PK");

                entity.ToTable("DCP_EMAIL_MAS");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DcpErrlogHis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DCP_ERRLOG_HIS");

                entity.HasIndex(e => new { e.DcolDataId, e.LogLevel })
                    .HasName("DCP_ERRLOG_HIS_IX3");

                entity.HasIndex(e => new { e.LotId, e.CrtTm })
                    .HasName("DCP_ERRLOG_HIS_IX2");

                entity.HasIndex(e => new { e.MsgTid, e.CrtTm })
                    .HasName("DCP_ERRLOG_HIS_IX5");

                entity.HasIndex(e => new { e.EqpId, e.CrtTm, e.ServiceNm })
                    .HasName("DCP_ERRLOG_HIS_IX4");

                entity.HasIndex(e => new { e.CrtTm, e.Ip, e.ProcId, e.MethodNm, e.LogLevel, e.ServiceNm })
                    .HasName("DCP_ERRLOG_HIS_IX1")
                    .IsUnique();

                entity.Property(e => e.ClassNm)
                    .HasColumnName("CLASS_NM")
                    .HasMaxLength(256);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(22, 0)");

                entity.Property(e => e.Desc)
                    .HasColumnName("DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.HostNm)
                    .IsRequired()
                    .HasColumnName("HOST_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(40);

                entity.Property(e => e.LogCause)
                    .HasColumnName("LOG_CAUSE")
                    .HasMaxLength(4000);

                entity.Property(e => e.LogLevel)
                    .IsRequired()
                    .HasColumnName("LOG_LEVEL")
                    .HasMaxLength(40);

                entity.Property(e => e.LogMsg)
                    .HasColumnName("LOG_MSG")
                    .HasMaxLength(4000);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MethodNm)
                    .HasColumnName("METHOD_NM")
                    .HasMaxLength(256);

                entity.Property(e => e.MsgTid)
                    .HasColumnName("MSG_TID")
                    .HasMaxLength(80);

                entity.Property(e => e.ProcId)
                    .HasColumnName("PROC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ServiceNm)
                    .HasColumnName("SERVICE_NM")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpFilterMas>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.LotCd, e.ProdId, e.RouteId, e.OperId, e.DataTyp, e.FilterVal, e.CorrectPara, e.EqpId })
                    .HasName("DCP_FILTER_MAS_PK");

                entity.ToTable("DCP_FILTER_MAS");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RouteId)
                    .HasColumnName("ROUTE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DataTyp)
                    .HasColumnName("DATA_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.FilterVal)
                    .HasColumnName("FILTER_VAL")
                    .HasMaxLength(100);

                entity.Property(e => e.CorrectPara)
                    .HasColumnName("CORRECT_PARA")
                    .HasMaxLength(100);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ApplyYn)
                    .HasColumnName("APPLY_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CorrectRawData)
                    .HasColumnName("CORRECT_RAW_DATA")
                    .HasMaxLength(500);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CtrlDesc)
                    .HasColumnName("CTRL_DESC")
                    .HasMaxLength(500);

                entity.Property(e => e.FilterLlVal)
                    .HasColumnName("FILTER_LL_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.FilterRawData)
                    .HasColumnName("FILTER_RAW_DATA")
                    .HasMaxLength(500);

                entity.Property(e => e.FilterUlVal)
                    .HasColumnName("FILTER_UL_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinMaxYn)
                    .HasColumnName("MIN_MAX_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Offset)
                    .HasColumnName("OFFSET")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rawid)
                    .HasColumnName("RAWID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SendYn)
                    .HasColumnName("SEND_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(10);

                entity.Property(e => e.WarnLlVal)
                    .HasColumnName("WARN_LL_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.WarnUlVal)
                    .HasColumnName("WARN_UL_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpGoldenmapDet>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.LotCd, e.OperId, e.NormalOperId, e.EdgeOperId, e.EqpId, e.ChuckId, e.ProdId, e.FlowId, e.ReticleId, e.StepperRecipeId, e.TestNo, e.Fieldx, e.Fieldy })
                    .HasName("DCP_GOLDENMAP_DET_PK");

                entity.ToTable("DCP_GOLDENMAP_DET");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.NormalOperId)
                    .HasColumnName("NORMAL_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.EdgeOperId)
                    .HasColumnName("EDGE_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ChuckId)
                    .HasColumnName("CHUCK_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReticleId)
                    .HasColumnName("RETICLE_ID")
                    .HasMaxLength(2048);

                entity.Property(e => e.StepperRecipeId)
                    .HasColumnName("STEPPER_RECIPE_ID")
                    .HasMaxLength(250);

                entity.Property(e => e.TestNo)
                    .HasColumnName("TEST_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldx)
                    .HasColumnName("FIELDX")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldy)
                    .HasColumnName("FIELDY")
                    .HasMaxLength(50);

                entity.Property(e => e.ChgDt)
                    .HasColumnName("CHG_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.GoldenXTyp)
                    .HasColumnName("GOLDEN_X_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.GoldenXVal)
                    .HasColumnName("GOLDEN_X_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.GoldenYTyp)
                    .HasColumnName("GOLDEN_Y_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.GoldenYVal)
                    .HasColumnName("GOLDEN_Y_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.ParaTyp)
                    .HasColumnName("PARA_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.TgtX)
                    .HasColumnName("TGT_X")
                    .HasMaxLength(50);

                entity.Property(e => e.TgtY)
                    .HasColumnName("TGT_Y")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DcpGoldenmapHis>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.LotCd, e.OperId, e.NormalOperId, e.EdgeOperId, e.EqpId, e.ChuckId, e.ProdId, e.FlowId, e.ReticleId, e.StepperRecipeId })
                    .HasName("DCP_GOLDENMAP_HIS_PK");

                entity.ToTable("DCP_GOLDENMAP_HIS");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.NormalOperId)
                    .HasColumnName("NORMAL_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.EdgeOperId)
                    .HasColumnName("EDGE_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ChuckId)
                    .HasColumnName("CHUCK_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReticleId)
                    .HasColumnName("RETICLE_ID")
                    .HasMaxLength(2048);

                entity.Property(e => e.StepperRecipeId)
                    .HasColumnName("STEPPER_RECIPE_ID")
                    .HasMaxLength(250);

                entity.Property(e => e.BiasIcansRatio)
                    .HasColumnName("BIAS_ICANS_RATIO")
                    .HasMaxLength(50);

                entity.Property(e => e.BiasRemoveFilterYn)
                    .HasColumnName("BIAS_REMOVE_FILTER_YN")
                    .HasMaxLength(20);

                entity.Property(e => e.CalcTyp)
                    .HasColumnName("CALC_TYP")
                    .HasMaxLength(20);

                entity.Property(e => e.CdOperId)
                    .HasColumnName("CD_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CdParaName)
                    .HasColumnName("CD_PARA_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CdRelXCoordParaNm)
                    .HasColumnName("CD_REL_X_COORD_PARA_NM")
                    .HasMaxLength(1024);

                entity.Property(e => e.CdRelYCoordParaNm)
                    .HasColumnName("CD_REL_Y_COORD_PARA_NM")
                    .HasMaxLength(1024);

                entity.Property(e => e.ChgDt)
                    .HasColumnName("CHG_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CutoffDay)
                    .HasColumnName("CUTOFF_DAY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Damping)
                    .HasColumnName("DAMPING")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EdgeReplaceModelYn)
                    .HasColumnName("EDGE_REPLACE_MODEL_YN")
                    .HasMaxLength(50);

                entity.Property(e => e.FilterVal)
                    .HasColumnName("FILTER_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FilterYn)
                    .HasColumnName("FILTER_YN")
                    .HasMaxLength(10);

                entity.Property(e => e.GoldenYn)
                    .HasColumnName("GOLDEN_YN")
                    .HasMaxLength(50);

                entity.Property(e => e.Inter)
                    .HasColumnName("INTER")
                    .HasMaxLength(20);

                entity.Property(e => e.Intra)
                    .HasColumnName("INTRA")
                    .HasMaxLength(20);

                entity.Property(e => e.IntraBiasMonMeasCnt)
                    .HasColumnName("INTRA_BIAS_MON_MEAS_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IntraBiasMonRangeVal)
                    .HasColumnName("INTRA_BIAS_MON_RANGE_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IntraBiasMonUseYn)
                    .HasColumnName("INTRA_BIAS_MON_USE_YN")
                    .HasMaxLength(20);

                entity.Property(e => e.Knnpercent)
                    .HasColumnName("KNNPERCENT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Knnrange)
                    .HasColumnName("KNNRANGE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MaBiasRefFlowId)
                    .HasColumnName("MA_BIAS_REF_FLOW_ID")
                    .HasMaxLength(512);

                entity.Property(e => e.MaBiasRefProdId)
                    .HasColumnName("MA_BIAS_REF_PROD_ID")
                    .HasMaxLength(512);

                entity.Property(e => e.MaGrpId)
                    .HasColumnName("MA_GRP_ID")
                    .HasMaxLength(256);

                entity.Property(e => e.OffsetX)
                    .HasColumnName("OFFSET_X")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OffsetY)
                    .HasColumnName("OFFSET_Y")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OperatorX)
                    .HasColumnName("OPERATOR_X")
                    .HasMaxLength(20);

                entity.Property(e => e.OperatorY)
                    .HasColumnName("OPERATOR_Y")
                    .HasMaxLength(20);

                entity.Property(e => e.PassRatioVal)
                    .HasColumnName("PASS_RATIO_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.PassRatioXVal)
                    .HasColumnName("PASS_RATIO_X_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.PassRatioYVal)
                    .HasColumnName("PASS_RATIO_Y_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.RaFilterYn)
                    .HasColumnName("RA_FILTER_YN")
                    .HasMaxLength(50);

                entity.Property(e => e.RefLotCnt)
                    .HasColumnName("REF_LOT_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ResetDt)
                    .HasColumnName("RESET_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.SigmaVal)
                    .HasColumnName("SIGMA_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.XIndirVarbVal)
                    .HasColumnName("X_INDIR_VARB_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.XVarbIndirOperId)
                    .HasColumnName("X_VARB_INDIR_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.YIndirVarbVal)
                    .HasColumnName("Y_INDIR_VARB_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.YVarbIndirOperId)
                    .HasColumnName("Y_VARB_INDIR_OPER_ID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DcpIcanslotHis>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.ActTm, e.ActEqpId, e.ActualTm })
                    .HasName("DCP_ICANSLOT_HIS_PK");

                entity.ToTable("DCP_ICANSLOT_HIS");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ActTm)
                    .HasColumnName("ACT_TM")
                    .HasMaxLength(50);

                entity.Property(e => e.ActEqpId)
                    .HasColumnName("ACT_EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ActualTm)
                    .HasColumnName("ACTUAL_TM")
                    .HasMaxLength(50);

                entity.Property(e => e.ActOperId)
                    .HasColumnName("ACT_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ActRteId)
                    .HasColumnName("ACT_RTE_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.BasePlanId)
                    .HasColumnName("BASE_PLAN_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CmdVal)
                    .HasColumnName("CMD_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.Cmt)
                    .HasColumnName("CMT")
                    .HasMaxLength(2000);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.DcolTyp)
                    .HasColumnName("DCOL_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.EdgeOperId)
                    .HasColumnName("EDGE_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.EnvNm)
                    .HasColumnName("ENV_NM")
                    .HasMaxLength(50);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.IcansOperId)
                    .HasColumnName("ICANS_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.LastRwkTm)
                    .HasColumnName("LAST_RWK_TM")
                    .HasMaxLength(50);

                entity.Property(e => e.LinkKey)
                    .HasColumnName("LINK_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MainEqpId)
                    .HasColumnName("MAIN_EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MeasEqpId)
                    .HasColumnName("MEAS_EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MeasOperId)
                    .HasColumnName("MEAS_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MeasRteId)
                    .HasColumnName("MEAS_RTE_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MsgId)
                    .HasColumnName("MSG_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.NormalOperId)
                    .HasColumnName("NORMAL_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.PmsYn)
                    .HasColumnName("PMS_YN")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdVer)
                    .HasColumnName("PROD_VER")
                    .HasMaxLength(50);

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RECIPE_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.RecovYn)
                    .HasColumnName("RECOV_YN")
                    .HasMaxLength(50);

                entity.Property(e => e.RecvProcId)
                    .HasColumnName("RECV_PROC_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReticleId)
                    .HasColumnName("RETICLE_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.RwkYn)
                    .HasColumnName("RWK_YN")
                    .HasMaxLength(50);

                entity.Property(e => e.SampLotId)
                    .HasColumnName("SAMP_LOT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.SendLocId)
                    .HasColumnName("SEND_LOC_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.SendProcId)
                    .HasColumnName("SEND_PROC_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.SetId)
                    .HasColumnName("SET_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.SetVer)
                    .HasColumnName("SET_VER")
                    .HasMaxLength(50);

                entity.Property(e => e.SpecOutTyp)
                    .HasColumnName("SPEC_OUT_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.StepperRecipeId)
                    .HasColumnName("STEPPER_RECIPE_ID")
                    .HasMaxLength(250);

                entity.Property(e => e.ZoneCd)
                    .HasColumnName("ZONE_CD")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DcpIcansmsgHis>(entity =>
            {
                entity.HasKey(e => new { e.LinkKey, e.LinkWfKey })
                    .HasName("DCP_ICANSMSG_HIS_PK");

                entity.ToTable("DCP_ICANSMSG_HIS");

                entity.Property(e => e.LinkKey)
                    .HasColumnName("LINK_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.LinkWfKey)
                    .HasColumnName("LINK_WF_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Msg).HasColumnName("MSG");
            });

            modelBuilder.Entity<DcpIcansparamHis>(entity =>
            {
                entity.HasKey(e => new { e.LinkWfKey, e.DefectId, e.Fieldx, e.Fieldy })
                    .HasName("DCP_ICANSPARAM_HIS_PK");

                entity.ToTable("DCP_ICANSPARAM_HIS");

                entity.Property(e => e.LinkWfKey)
                    .HasColumnName("LINK_WF_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.DefectId)
                    .HasColumnName("DEFECT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldx)
                    .HasColumnName("FIELDX")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldy)
                    .HasColumnName("FIELDY")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fieldrelx)
                    .HasColumnName("FIELDRELX")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldrely)
                    .HasColumnName("FIELDRELY")
                    .HasMaxLength(50);

                entity.Property(e => e.X).HasMaxLength(50);

                entity.Property(e => e.Y).HasMaxLength(50);
            });

            modelBuilder.Entity<DcpIcanswfHis>(entity =>
            {
                entity.HasKey(e => new { e.LinkKey, e.LinkWfKey })
                    .HasName("DCP_ICANSWF_HIS_PK");

                entity.ToTable("DCP_ICANSWF_HIS");

                entity.Property(e => e.LinkKey)
                    .HasColumnName("LINK_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.LinkWfKey)
                    .HasColumnName("LINK_WF_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.ChambId)
                    .HasColumnName("CHAMB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.WfId)
                    .HasColumnName("WF_ID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DcpInterfaceHis>(entity =>
            {
                entity.HasKey(e => new { e.CrtTm, e.LotId, e.EqpId, e.AliasNm, e.DcolDataId })
                    .HasName("DCP_INTERFACE_HIS_PK");

                entity.ToTable("DCP_INTERFACE_HIS");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AliasNm)
                    .HasColumnName("ALIAS_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProcNm)
                    .HasColumnName("PROC_NM")
                    .HasMaxLength(100);

                entity.Property(e => e.SendMsg)
                    .HasColumnName("SEND_MSG")
                    .IsUnicode(false);

                entity.Property(e => e.SendTyp)
                    .HasColumnName("SEND_TYP")
                    .HasMaxLength(20);

                entity.Property(e => e.SendYn)
                    .HasColumnName("SEND_YN")
                    .HasMaxLength(20);

                entity.Property(e => e.ServerIp)
                    .HasColumnName("SERVER_IP")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DcpInterlockHis>(entity =>
            {
                entity.HasKey(e => new { e.CrtTm, e.EqpId, e.InterlockNm })
                    .HasName("DCP_INTERLOCK_HIS_PK");

                entity.ToTable("DCP_INTERLOCK_HIS");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.InterlockNm)
                    .HasColumnName("INTERLOCK_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.AppNm)
                    .HasColumnName("APP_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasMaxLength(40);

                entity.Property(e => e.InterlockCause)
                    .HasColumnName("INTERLOCK_CAUSE")
                    .HasMaxLength(100);

                entity.Property(e => e.InterlockCd)
                    .HasColumnName("INTERLOCK_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.RepMsg)
                    .HasColumnName("REP_MSG")
                    .HasMaxLength(2000);

                entity.Property(e => e.ReqMsg)
                    .HasColumnName("REQ_MSG")
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<DcpListenmsgHis>(entity =>
            {
                entity.HasKey(e => new { e.CrtTm, e.EqpId, e.AliasNm, e.Tid, e.DcolDataId })
                    .HasName("DCP_LISTENMSG_HIS_PK");

                entity.ToTable("DCP_LISTENMSG_HIS");

                entity.HasIndex(e => new { e.DcolDataId, e.CrtTm })
                    .HasName("DCP_LISTENMSG_HIS_IX1");

                entity.HasIndex(e => new { e.EqpId, e.CrtTm })
                    .HasName("DCP_LISTENMSG_HIS_IX2");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AliasNm)
                    .HasColumnName("ALIAS_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasMaxLength(80);

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Msg).HasColumnName("MSG");

                entity.Property(e => e.ProcNm)
                    .HasColumnName("PROC_NM")
                    .HasMaxLength(100);

                entity.Property(e => e.ServerIp)
                    .HasColumnName("SERVER_IP")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DcpLocMas>(entity =>
            {
                entity.HasKey(e => new { e.Fab, e.LotId, e.EqpId, e.CarrierId, e.Oper, e.Prod, e.ProcFlow, e.DcolId })
                    .HasName("DCP_LOC_MAS_IX1");

                entity.ToTable("DCP_LOC_MAS");

                entity.HasIndex(e => new { e.Fab, e.CarrierId, e.EqpId })
                    .HasName("DCP_LOC_MAS_IX2_");

                entity.Property(e => e.Fab)
                    .HasColumnName("FAB")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CarrierId)
                    .HasColumnName("CARRIER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Oper)
                    .HasColumnName("OPER")
                    .HasMaxLength(40);

                entity.Property(e => e.Prod)
                    .HasColumnName("PROD")
                    .HasMaxLength(128);

                entity.Property(e => e.ProcFlow)
                    .HasColumnName("PROC_FLOW")
                    .HasMaxLength(128);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DcpLoggerMas>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.ProcId })
                    .HasName("DCP_LOGGER_MAS_PK");

                entity.ToTable("DCP_LOGGER_MAS");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcId)
                    .HasColumnName("PROC_ID")
                    .HasMaxLength(128);

                entity.Property(e => e.DataKeepDur)
                    .HasColumnName("DATA_KEEP_DUR")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LogPath)
                    .IsRequired()
                    .HasColumnName("LOG_PATH")
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<DcpLotcdmapHis>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.LotCd, e.ProdId })
                    .HasName("DCP_LOTCDMAP_HIS_PK");

                entity.ToTable("DCP_LOTCDMAP_HIS");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(20);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MapOffsetXVal)
                    .HasColumnName("MAP_OFFSET_X_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MapOffsetYVal)
                    .HasColumnName("MAP_OFFSET_Y_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ShotXCnt)
                    .HasColumnName("SHOT_X_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ShotYCnt)
                    .HasColumnName("SHOT_Y_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WfMapXCoord)
                    .HasColumnName("WF_MAP_X_COORD")
                    .HasMaxLength(50);

                entity.Property(e => e.WfMapYCoord)
                    .HasColumnName("WF_MAP_Y_COORD")
                    .HasMaxLength(50);

                entity.Property(e => e.WfPitchXSize)
                    .HasColumnName("WF_PITCH_X_SIZE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WfPitchYSize)
                    .HasColumnName("WF_PITCH_Y_SIZE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ZOffsetVal)
                    .HasColumnName("Z_OFFSET_VAL")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DcpMaininfoInf>(entity =>
            {
                entity.HasKey(e => new { e.DcolId, e.DcolVer, e.DcolItemCd })
                    .HasName("DCP_MAININFO_INF_IX1");

                entity.ToTable("DCP_MAININFO_INF");

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(100);

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(100);

                entity.Property(e => e.ApplyFlag)
                    .HasColumnName("APPLY_FLAG")
                    .HasMaxLength(20);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpMdptimekeyMas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DCP_MDPTIMEKEY_MAS");

                entity.HasIndex(e => new { e.DataTyp, e.FacId })
                    .HasName("DCP_MDPTIMEKEY_MAS_PK")
                    .IsUnique();

                entity.Property(e => e.CancelTimekey)
                    .HasColumnName("CANCEL_TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataTyp)
                    .HasColumnName("DATA_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MsgId)
                    .HasColumnName("MSG_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal1)
                    .HasColumnName("RESV_FIELD_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal2)
                    .HasColumnName("RESV_FIELD_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal3)
                    .HasColumnName("RESV_FIELD_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal4)
                    .HasColumnName("RESV_FIELD_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal5)
                    .HasColumnName("RESV_FIELD_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvTimekey)
                    .HasColumnName("RESV_TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpMvouSync>(entity =>
            {
                entity.HasKey(e => e.MsgKey)
                    .HasName("DCP_MVOU_SYNC_PK");

                entity.ToTable("DCP_MVOU_SYNC");

                entity.Property(e => e.MsgKey)
                    .HasColumnName("MSG_KEY")
                    .HasMaxLength(600);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Fab)
                    .HasColumnName("FAB")
                    .HasMaxLength(20);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SyncYn)
                    .HasColumnName("SYNC_YN")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DcpMvouSyncRaw>(entity =>
            {
                entity.HasKey(e => new { e.Fab, e.EqpId, e.Tid })
                    .HasName("DCP_MVOU_SYNC_RAW_IX1");

                entity.ToTable("DCP_MVOU_SYNC_RAW");

                entity.Property(e => e.Fab)
                    .HasColumnName("FAB")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasMaxLength(120);

                entity.Property(e => e.Msg).HasColumnName("MSG");

                entity.Property(e => e.Trycount)
                    .HasColumnName("TRYCOUNT")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DcpOllotHis>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.Timekey, e.EqpId })
                    .HasName("DCP_OLLOT_HIS_PK");

                entity.ToTable("DCP_OLLOT_HIS");

                entity.HasIndex(e => e.LinkKey)
                    .HasName("DCP_OLLOT_HIS_IX1");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(50);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.BatchCnt)
                    .HasColumnName("BATCH_CNT")
                    .HasMaxLength(50);

                entity.Property(e => e.BatchId)
                    .HasColumnName("BATCH_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CarrierId)
                    .HasColumnName("CARRIER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtrlJobId)
                    .HasColumnName("CTRL_JOB_ID")
                    .HasMaxLength(150);

                entity.Property(e => e.DataSeq)
                    .HasColumnName("DATA_SEQ")
                    .HasMaxLength(50);

                entity.Property(e => e.DestId)
                    .HasColumnName("DEST_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.EdgeOperId)
                    .HasColumnName("EDGE_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.LinkKey)
                    .HasColumnName("LINK_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(20);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.LotType)
                    .HasColumnName("LOT_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.MainEqpId)
                    .HasColumnName("MAIN_EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.NormalOperId)
                    .HasColumnName("NORMAL_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrgTyp)
                    .HasColumnName("ORG_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.PortNo)
                    .HasColumnName("PORT_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcJobId)
                    .HasColumnName("PROC_JOB_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ProcSeq)
                    .HasColumnName("PROC_SEQ")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RECIPE_ID")
                    .HasMaxLength(120);

                entity.Property(e => e.RecovYn)
                    .HasColumnName("RECOV_YN")
                    .HasMaxLength(50);

                entity.Property(e => e.ReticleId)
                    .HasColumnName("RETICLE_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.SkipYn)
                    .HasColumnName("SKIP_YN")
                    .HasMaxLength(50);

                entity.Property(e => e.StepperRecipeId)
                    .HasColumnName("STEPPER_RECIPE_ID")
                    .HasMaxLength(250);

                entity.Property(e => e.SubjId)
                    .HasColumnName("SUBJ_ID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DcpOlparamHis>(entity =>
            {
                entity.HasKey(e => new { e.LinkWfKey, e.TestNo, e.Fieldx, e.Fieldy });

                entity.ToTable("DCP_OLPARAM_HIS");

                entity.HasIndex(e => new { e.LinkWfKey, e.TestNo, e.Fieldx, e.Fieldy })
                    .HasName("DCP_OLPARAM_HIS_PK")
                    .IsUnique();

                entity.Property(e => e.LinkWfKey)
                    .HasColumnName("LINK_WF_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.TestNo)
                    .HasColumnName("TEST_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldx)
                    .HasColumnName("FIELDX")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldy)
                    .HasColumnName("FIELDY")
                    .HasMaxLength(50);

                entity.Property(e => e.Areaexclude)
                    .HasColumnName("AREAEXCLUDE")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fieldxpos)
                    .HasColumnName("FIELDXPOS")
                    .HasMaxLength(50);

                entity.Property(e => e.Fieldypos)
                    .HasColumnName("FIELDYPOS")
                    .HasMaxLength(50);

                entity.Property(e => e.FilterTyp)
                    .HasColumnName("FILTER_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.FilterxVal)
                    .HasColumnName("FILTERX_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.FilteryVal)
                    .HasColumnName("FILTERY_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.GoldenXVal)
                    .HasColumnName("GOLDEN_X_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.GolednXTyp)
                    .HasColumnName("GOLEDN_X_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.GolednYTyp)
                    .HasColumnName("GOLEDN_Y_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.GolednYVal)
                    .HasColumnName("GOLEDN_Y_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.MaLinkKey)
                    .HasColumnName("MA_LINK_KEY")
                    .HasMaxLength(128);

                entity.Property(e => e.MaXVal)
                    .HasColumnName("MA_X_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.MaYVal)
                    .HasColumnName("MA_Y_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.OlX)
                    .HasColumnName("OL_X")
                    .HasMaxLength(50);

                entity.Property(e => e.OlY)
                    .HasColumnName("OL_Y")
                    .HasMaxLength(50);

                entity.Property(e => e.ResidualXVal)
                    .HasColumnName("RESIDUAL_X_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.ResidualYVal)
                    .HasColumnName("RESIDUAL_Y_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.ResultXVal)
                    .HasColumnName("RESULT_X_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.ResultYVal)
                    .HasColumnName("RESULT_Y_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.TgtTestNo)
                    .HasColumnName("TGT_TEST_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.TgtX)
                    .HasColumnName("TGT_X")
                    .HasMaxLength(50);

                entity.Property(e => e.TgtY)
                    .HasColumnName("TGT_Y")
                    .HasMaxLength(50);

                entity.Property(e => e.XIndirRsltExpr)
                    .HasColumnName("X_INDIR_RSLT_EXPR")
                    .HasMaxLength(1000);

                entity.Property(e => e.XIndirRsltVal)
                    .HasColumnName("X_INDIR_RSLT_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.XMeasDifExpr)
                    .HasColumnName("X_MEAS_DIF_EXPR")
                    .HasMaxLength(1000);

                entity.Property(e => e.XMeasDifVal)
                    .HasColumnName("X_MEAS_DIF_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.XOlLinkWfKey)
                    .HasColumnName("X_OL_LINK_WF_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.YIndirRsltExpr)
                    .HasColumnName("Y_INDIR_RSLT_EXPR")
                    .HasMaxLength(1000);

                entity.Property(e => e.YIndirRsltVal)
                    .HasColumnName("Y_INDIR_RSLT_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.YMeasDifExpr)
                    .HasColumnName("Y_MEAS_DIF_EXPR")
                    .HasMaxLength(1000);

                entity.Property(e => e.YMeasDifVal)
                    .HasColumnName("Y_MEAS_DIF_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.YOlLinkWfKey)
                    .HasColumnName("Y_OL_LINK_WF_KEY")
                    .HasMaxLength(120);
            });

            modelBuilder.Entity<DcpOlstatisticsHis>(entity =>
            {
                entity.HasKey(e => new { e.LinkWfKey, e.ParaNm, e.DataVal })
                    .HasName("DCP_OLSTATISTICS_HIS_PK");

                entity.ToTable("DCP_OLSTATISTICS_HIS");

                entity.Property(e => e.LinkWfKey)
                    .HasColumnName("LINK_WF_KEY")
                    .HasMaxLength(128);

                entity.Property(e => e.ParaNm)
                    .HasColumnName("PARA_NM")
                    .HasMaxLength(50);

                entity.Property(e => e.DataVal)
                    .HasColumnName("DATA_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DcpOlwfHis>(entity =>
            {
                entity.HasKey(e => new { e.LinkKey, e.LinkWfKey })
                    .HasName("DCP_OLWF_HIS_PK");

                entity.ToTable("DCP_OLWF_HIS");

                entity.Property(e => e.LinkKey)
                    .HasColumnName("LINK_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.LinkWfKey)
                    .HasColumnName("LINK_WF_KEY")
                    .HasMaxLength(120);

                entity.Property(e => e.ChuckId)
                    .HasColumnName("CHUCK_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrgWfId)
                    .HasColumnName("ORG_WF_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.SlotId)
                    .HasColumnName("SLOT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.WfId)
                    .HasColumnName("WF_ID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DcpOperMas>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.OperId })
                    .HasName("DCP_OPER_MAS_PK");

                entity.ToTable("DCP_OPER_MAS");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ActiveStatCd)
                    .HasColumnName("ACTIVE_STAT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.ChkStatCd)
                    .HasColumnName("CHK_STAT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DetOperTyp)
                    .HasColumnName("DET_OPER_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.MidOperTyp)
                    .HasColumnName("MID_OPER_TYP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DcpParameterHis>(entity =>
            {
                entity.HasKey(e => new { e.Tid, e.ParaNm, e.ParaTyp, e.StartIdx, e.CrtTm, e.DcolDataId })
                    .HasName("DCP_PARAMETER_HIS_PK");

                entity.ToTable("DCP_PARAMETER_HIS");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasMaxLength(80);

                entity.Property(e => e.ParaNm)
                    .HasColumnName("PARA_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ParaTyp)
                    .HasColumnName("PARA_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.StartIdx)
                    .HasColumnName("START_IDX")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Data001)
                    .HasColumnName("DATA001")
                    .HasMaxLength(40);

                entity.Property(e => e.Data002)
                    .HasColumnName("DATA002")
                    .HasMaxLength(40);

                entity.Property(e => e.Data003)
                    .HasColumnName("DATA003")
                    .HasMaxLength(40);

                entity.Property(e => e.Data004)
                    .HasColumnName("DATA004")
                    .HasMaxLength(40);

                entity.Property(e => e.Data005)
                    .HasColumnName("DATA005")
                    .HasMaxLength(40);

                entity.Property(e => e.Data006)
                    .HasColumnName("DATA006")
                    .HasMaxLength(40);

                entity.Property(e => e.Data007)
                    .HasColumnName("DATA007")
                    .HasMaxLength(40);

                entity.Property(e => e.Data008)
                    .HasColumnName("DATA008")
                    .HasMaxLength(40);

                entity.Property(e => e.Data009)
                    .HasColumnName("DATA009")
                    .HasMaxLength(40);

                entity.Property(e => e.Data010)
                    .HasColumnName("DATA010")
                    .HasMaxLength(40);

                entity.Property(e => e.Data011)
                    .HasColumnName("DATA011")
                    .HasMaxLength(40);

                entity.Property(e => e.Data012)
                    .HasColumnName("DATA012")
                    .HasMaxLength(40);

                entity.Property(e => e.Data013)
                    .HasColumnName("DATA013")
                    .HasMaxLength(40);

                entity.Property(e => e.Data014)
                    .HasColumnName("DATA014")
                    .HasMaxLength(40);

                entity.Property(e => e.Data015)
                    .HasColumnName("DATA015")
                    .HasMaxLength(40);

                entity.Property(e => e.Data016)
                    .HasColumnName("DATA016")
                    .HasMaxLength(40);

                entity.Property(e => e.Data017)
                    .HasColumnName("DATA017")
                    .HasMaxLength(40);

                entity.Property(e => e.Data018)
                    .HasColumnName("DATA018")
                    .HasMaxLength(40);

                entity.Property(e => e.Data019)
                    .HasColumnName("DATA019")
                    .HasMaxLength(40);

                entity.Property(e => e.Data020)
                    .HasColumnName("DATA020")
                    .HasMaxLength(40);

                entity.Property(e => e.Data021)
                    .HasColumnName("DATA021")
                    .HasMaxLength(40);

                entity.Property(e => e.Data022)
                    .HasColumnName("DATA022")
                    .HasMaxLength(40);

                entity.Property(e => e.Data023)
                    .HasColumnName("DATA023")
                    .HasMaxLength(40);

                entity.Property(e => e.Data024)
                    .HasColumnName("DATA024")
                    .HasMaxLength(40);

                entity.Property(e => e.Data025)
                    .HasColumnName("DATA025")
                    .HasMaxLength(40);

                entity.Property(e => e.Data026)
                    .HasColumnName("DATA026")
                    .HasMaxLength(40);

                entity.Property(e => e.Data027)
                    .HasColumnName("DATA027")
                    .HasMaxLength(40);

                entity.Property(e => e.Data028)
                    .HasColumnName("DATA028")
                    .HasMaxLength(40);

                entity.Property(e => e.Data029)
                    .HasColumnName("DATA029")
                    .HasMaxLength(40);

                entity.Property(e => e.Data030)
                    .HasColumnName("DATA030")
                    .HasMaxLength(40);

                entity.Property(e => e.Data031)
                    .HasColumnName("DATA031")
                    .HasMaxLength(40);

                entity.Property(e => e.Data032)
                    .HasColumnName("DATA032")
                    .HasMaxLength(40);

                entity.Property(e => e.Data033)
                    .HasColumnName("DATA033")
                    .HasMaxLength(40);

                entity.Property(e => e.Data034)
                    .HasColumnName("DATA034")
                    .HasMaxLength(40);

                entity.Property(e => e.Data035)
                    .HasColumnName("DATA035")
                    .HasMaxLength(40);

                entity.Property(e => e.Data036)
                    .HasColumnName("DATA036")
                    .HasMaxLength(40);

                entity.Property(e => e.Data037)
                    .HasColumnName("DATA037")
                    .HasMaxLength(40);

                entity.Property(e => e.Data038)
                    .HasColumnName("DATA038")
                    .HasMaxLength(40);

                entity.Property(e => e.Data039)
                    .HasColumnName("DATA039")
                    .HasMaxLength(40);

                entity.Property(e => e.Data040)
                    .HasColumnName("DATA040")
                    .HasMaxLength(40);

                entity.Property(e => e.Data041)
                    .HasColumnName("DATA041")
                    .HasMaxLength(40);

                entity.Property(e => e.Data042)
                    .HasColumnName("DATA042")
                    .HasMaxLength(40);

                entity.Property(e => e.Data043)
                    .HasColumnName("DATA043")
                    .HasMaxLength(40);

                entity.Property(e => e.Data044)
                    .HasColumnName("DATA044")
                    .HasMaxLength(40);

                entity.Property(e => e.Data045)
                    .HasColumnName("DATA045")
                    .HasMaxLength(40);

                entity.Property(e => e.Data046)
                    .HasColumnName("DATA046")
                    .HasMaxLength(40);

                entity.Property(e => e.Data047)
                    .HasColumnName("DATA047")
                    .HasMaxLength(40);

                entity.Property(e => e.Data048)
                    .HasColumnName("DATA048")
                    .HasMaxLength(40);

                entity.Property(e => e.Data049)
                    .HasColumnName("DATA049")
                    .HasMaxLength(40);

                entity.Property(e => e.Data050)
                    .HasColumnName("DATA050")
                    .HasMaxLength(40);

                entity.Property(e => e.Data051)
                    .HasColumnName("DATA051")
                    .HasMaxLength(40);

                entity.Property(e => e.Data052)
                    .HasColumnName("DATA052")
                    .HasMaxLength(40);

                entity.Property(e => e.Data053)
                    .HasColumnName("DATA053")
                    .HasMaxLength(40);

                entity.Property(e => e.Data054)
                    .HasColumnName("DATA054")
                    .HasMaxLength(40);

                entity.Property(e => e.Data055)
                    .HasColumnName("DATA055")
                    .HasMaxLength(40);

                entity.Property(e => e.Data056)
                    .HasColumnName("DATA056")
                    .HasMaxLength(40);

                entity.Property(e => e.Data057)
                    .HasColumnName("DATA057")
                    .HasMaxLength(40);

                entity.Property(e => e.Data058)
                    .HasColumnName("DATA058")
                    .HasMaxLength(40);

                entity.Property(e => e.Data059)
                    .HasColumnName("DATA059")
                    .HasMaxLength(40);

                entity.Property(e => e.Data060)
                    .HasColumnName("DATA060")
                    .HasMaxLength(40);

                entity.Property(e => e.Data061)
                    .HasColumnName("DATA061")
                    .HasMaxLength(40);

                entity.Property(e => e.Data062)
                    .HasColumnName("DATA062")
                    .HasMaxLength(40);

                entity.Property(e => e.Data063)
                    .HasColumnName("DATA063")
                    .HasMaxLength(40);

                entity.Property(e => e.Data064)
                    .HasColumnName("DATA064")
                    .HasMaxLength(40);

                entity.Property(e => e.Data065)
                    .HasColumnName("DATA065")
                    .HasMaxLength(40);

                entity.Property(e => e.Data066)
                    .HasColumnName("DATA066")
                    .HasMaxLength(40);

                entity.Property(e => e.Data067)
                    .HasColumnName("DATA067")
                    .HasMaxLength(40);

                entity.Property(e => e.Data068)
                    .HasColumnName("DATA068")
                    .HasMaxLength(40);

                entity.Property(e => e.Data069)
                    .HasColumnName("DATA069")
                    .HasMaxLength(40);

                entity.Property(e => e.Data070)
                    .HasColumnName("DATA070")
                    .HasMaxLength(40);

                entity.Property(e => e.Data071)
                    .HasColumnName("DATA071")
                    .HasMaxLength(40);

                entity.Property(e => e.Data072)
                    .HasColumnName("DATA072")
                    .HasMaxLength(40);

                entity.Property(e => e.Data073)
                    .HasColumnName("DATA073")
                    .HasMaxLength(40);

                entity.Property(e => e.Data074)
                    .HasColumnName("DATA074")
                    .HasMaxLength(40);

                entity.Property(e => e.Data075)
                    .HasColumnName("DATA075")
                    .HasMaxLength(40);

                entity.Property(e => e.Data076)
                    .HasColumnName("DATA076")
                    .HasMaxLength(40);

                entity.Property(e => e.Data077)
                    .HasColumnName("DATA077")
                    .HasMaxLength(40);

                entity.Property(e => e.Data078)
                    .HasColumnName("DATA078")
                    .HasMaxLength(40);

                entity.Property(e => e.Data079)
                    .HasColumnName("DATA079")
                    .HasMaxLength(40);

                entity.Property(e => e.Data080)
                    .HasColumnName("DATA080")
                    .HasMaxLength(40);

                entity.Property(e => e.Data081)
                    .HasColumnName("DATA081")
                    .HasMaxLength(40);

                entity.Property(e => e.Data082)
                    .HasColumnName("DATA082")
                    .HasMaxLength(40);

                entity.Property(e => e.Data083)
                    .HasColumnName("DATA083")
                    .HasMaxLength(40);

                entity.Property(e => e.Data084)
                    .HasColumnName("DATA084")
                    .HasMaxLength(40);

                entity.Property(e => e.Data085)
                    .HasColumnName("DATA085")
                    .HasMaxLength(40);

                entity.Property(e => e.Data086)
                    .HasColumnName("DATA086")
                    .HasMaxLength(40);

                entity.Property(e => e.Data087)
                    .HasColumnName("DATA087")
                    .HasMaxLength(40);

                entity.Property(e => e.Data088)
                    .HasColumnName("DATA088")
                    .HasMaxLength(40);

                entity.Property(e => e.Data089)
                    .HasColumnName("DATA089")
                    .HasMaxLength(40);

                entity.Property(e => e.Data090)
                    .HasColumnName("DATA090")
                    .HasMaxLength(40);

                entity.Property(e => e.Data091)
                    .HasColumnName("DATA091")
                    .HasMaxLength(40);

                entity.Property(e => e.Data092)
                    .HasColumnName("DATA092")
                    .HasMaxLength(40);

                entity.Property(e => e.Data093)
                    .HasColumnName("DATA093")
                    .HasMaxLength(40);

                entity.Property(e => e.Data094)
                    .HasColumnName("DATA094")
                    .HasMaxLength(40);

                entity.Property(e => e.Data095)
                    .HasColumnName("DATA095")
                    .HasMaxLength(40);

                entity.Property(e => e.Data096)
                    .HasColumnName("DATA096")
                    .HasMaxLength(40);

                entity.Property(e => e.Data097)
                    .HasColumnName("DATA097")
                    .HasMaxLength(40);

                entity.Property(e => e.Data098)
                    .HasColumnName("DATA098")
                    .HasMaxLength(40);

                entity.Property(e => e.Data099)
                    .HasColumnName("DATA099")
                    .HasMaxLength(40);

                entity.Property(e => e.Data100)
                    .HasColumnName("DATA100")
                    .HasMaxLength(40);

                entity.Property(e => e.Data101)
                    .HasColumnName("DATA101")
                    .HasMaxLength(40);

                entity.Property(e => e.Data102)
                    .HasColumnName("DATA102")
                    .HasMaxLength(40);

                entity.Property(e => e.Data103)
                    .HasColumnName("DATA103")
                    .HasMaxLength(40);

                entity.Property(e => e.Data104)
                    .HasColumnName("DATA104")
                    .HasMaxLength(40);

                entity.Property(e => e.Data105)
                    .HasColumnName("DATA105")
                    .HasMaxLength(40);

                entity.Property(e => e.Data106)
                    .HasColumnName("DATA106")
                    .HasMaxLength(40);

                entity.Property(e => e.Data107)
                    .HasColumnName("DATA107")
                    .HasMaxLength(40);

                entity.Property(e => e.Data108)
                    .HasColumnName("DATA108")
                    .HasMaxLength(40);

                entity.Property(e => e.Data109)
                    .HasColumnName("DATA109")
                    .HasMaxLength(40);

                entity.Property(e => e.Data110)
                    .HasColumnName("DATA110")
                    .HasMaxLength(40);

                entity.Property(e => e.Data111)
                    .HasColumnName("DATA111")
                    .HasMaxLength(40);

                entity.Property(e => e.Data112)
                    .HasColumnName("DATA112")
                    .HasMaxLength(40);

                entity.Property(e => e.Data113)
                    .HasColumnName("DATA113")
                    .HasMaxLength(40);

                entity.Property(e => e.Data114)
                    .HasColumnName("DATA114")
                    .HasMaxLength(40);

                entity.Property(e => e.Data115)
                    .HasColumnName("DATA115")
                    .HasMaxLength(40);

                entity.Property(e => e.Data116)
                    .HasColumnName("DATA116")
                    .HasMaxLength(40);

                entity.Property(e => e.Data117)
                    .HasColumnName("DATA117")
                    .HasMaxLength(40);

                entity.Property(e => e.Data118)
                    .HasColumnName("DATA118")
                    .HasMaxLength(40);

                entity.Property(e => e.Data119)
                    .HasColumnName("DATA119")
                    .HasMaxLength(40);

                entity.Property(e => e.Data120)
                    .HasColumnName("DATA120")
                    .HasMaxLength(40);

                entity.Property(e => e.Data121)
                    .HasColumnName("DATA121")
                    .HasMaxLength(40);

                entity.Property(e => e.Data122)
                    .HasColumnName("DATA122")
                    .HasMaxLength(40);

                entity.Property(e => e.Data123)
                    .HasColumnName("DATA123")
                    .HasMaxLength(40);

                entity.Property(e => e.Data124)
                    .HasColumnName("DATA124")
                    .HasMaxLength(40);

                entity.Property(e => e.Data125)
                    .HasColumnName("DATA125")
                    .HasMaxLength(40);

                entity.Property(e => e.Data126)
                    .HasColumnName("DATA126")
                    .HasMaxLength(40);

                entity.Property(e => e.Data127)
                    .HasColumnName("DATA127")
                    .HasMaxLength(40);

                entity.Property(e => e.Data128)
                    .HasColumnName("DATA128")
                    .HasMaxLength(40);

                entity.Property(e => e.Data129)
                    .HasColumnName("DATA129")
                    .HasMaxLength(40);

                entity.Property(e => e.Data130)
                    .HasColumnName("DATA130")
                    .HasMaxLength(40);

                entity.Property(e => e.Data131)
                    .HasColumnName("DATA131")
                    .HasMaxLength(40);

                entity.Property(e => e.Data132)
                    .HasColumnName("DATA132")
                    .HasMaxLength(40);

                entity.Property(e => e.Data133)
                    .HasColumnName("DATA133")
                    .HasMaxLength(40);

                entity.Property(e => e.Data134)
                    .HasColumnName("DATA134")
                    .HasMaxLength(40);

                entity.Property(e => e.Data135)
                    .HasColumnName("DATA135")
                    .HasMaxLength(40);

                entity.Property(e => e.Data136)
                    .HasColumnName("DATA136")
                    .HasMaxLength(40);

                entity.Property(e => e.Data137)
                    .HasColumnName("DATA137")
                    .HasMaxLength(40);

                entity.Property(e => e.Data138)
                    .HasColumnName("DATA138")
                    .HasMaxLength(40);

                entity.Property(e => e.Data139)
                    .HasColumnName("DATA139")
                    .HasMaxLength(40);

                entity.Property(e => e.Data140)
                    .HasColumnName("DATA140")
                    .HasMaxLength(40);

                entity.Property(e => e.Data141)
                    .HasColumnName("DATA141")
                    .HasMaxLength(40);

                entity.Property(e => e.Data142)
                    .HasColumnName("DATA142")
                    .HasMaxLength(40);

                entity.Property(e => e.Data143)
                    .HasColumnName("DATA143")
                    .HasMaxLength(40);

                entity.Property(e => e.Data144)
                    .HasColumnName("DATA144")
                    .HasMaxLength(40);

                entity.Property(e => e.Data145)
                    .HasColumnName("DATA145")
                    .HasMaxLength(40);

                entity.Property(e => e.Data146)
                    .HasColumnName("DATA146")
                    .HasMaxLength(40);

                entity.Property(e => e.Data147)
                    .HasColumnName("DATA147")
                    .HasMaxLength(40);

                entity.Property(e => e.Data148)
                    .HasColumnName("DATA148")
                    .HasMaxLength(40);

                entity.Property(e => e.Data149)
                    .HasColumnName("DATA149")
                    .HasMaxLength(40);

                entity.Property(e => e.Data150)
                    .HasColumnName("DATA150")
                    .HasMaxLength(40);

                entity.Property(e => e.Data151)
                    .HasColumnName("DATA151")
                    .HasMaxLength(40);

                entity.Property(e => e.Data152)
                    .HasColumnName("DATA152")
                    .HasMaxLength(40);

                entity.Property(e => e.Data153)
                    .HasColumnName("DATA153")
                    .HasMaxLength(40);

                entity.Property(e => e.Data154)
                    .HasColumnName("DATA154")
                    .HasMaxLength(40);

                entity.Property(e => e.Data155)
                    .HasColumnName("DATA155")
                    .HasMaxLength(40);

                entity.Property(e => e.Data156)
                    .HasColumnName("DATA156")
                    .HasMaxLength(40);

                entity.Property(e => e.Data157)
                    .HasColumnName("DATA157")
                    .HasMaxLength(40);

                entity.Property(e => e.Data158)
                    .HasColumnName("DATA158")
                    .HasMaxLength(40);

                entity.Property(e => e.Data159)
                    .HasColumnName("DATA159")
                    .HasMaxLength(40);

                entity.Property(e => e.Data160)
                    .HasColumnName("DATA160")
                    .HasMaxLength(40);

                entity.Property(e => e.Data161)
                    .HasColumnName("DATA161")
                    .HasMaxLength(40);

                entity.Property(e => e.Data162)
                    .HasColumnName("DATA162")
                    .HasMaxLength(40);

                entity.Property(e => e.Data163)
                    .HasColumnName("DATA163")
                    .HasMaxLength(40);

                entity.Property(e => e.Data164)
                    .HasColumnName("DATA164")
                    .HasMaxLength(40);

                entity.Property(e => e.Data165)
                    .HasColumnName("DATA165")
                    .HasMaxLength(40);

                entity.Property(e => e.Data166)
                    .HasColumnName("DATA166")
                    .HasMaxLength(40);

                entity.Property(e => e.Data167)
                    .HasColumnName("DATA167")
                    .HasMaxLength(40);

                entity.Property(e => e.Data168)
                    .HasColumnName("DATA168")
                    .HasMaxLength(40);

                entity.Property(e => e.Data169)
                    .HasColumnName("DATA169")
                    .HasMaxLength(40);

                entity.Property(e => e.Data170)
                    .HasColumnName("DATA170")
                    .HasMaxLength(40);

                entity.Property(e => e.Data171)
                    .HasColumnName("DATA171")
                    .HasMaxLength(40);

                entity.Property(e => e.Data172)
                    .HasColumnName("DATA172")
                    .HasMaxLength(40);

                entity.Property(e => e.Data173)
                    .HasColumnName("DATA173")
                    .HasMaxLength(40);

                entity.Property(e => e.Data174)
                    .HasColumnName("DATA174")
                    .HasMaxLength(40);

                entity.Property(e => e.Data175)
                    .HasColumnName("DATA175")
                    .HasMaxLength(40);

                entity.Property(e => e.Data176)
                    .HasColumnName("DATA176")
                    .HasMaxLength(40);

                entity.Property(e => e.Data177)
                    .HasColumnName("DATA177")
                    .HasMaxLength(40);

                entity.Property(e => e.Data178)
                    .HasColumnName("DATA178")
                    .HasMaxLength(40);

                entity.Property(e => e.Data179)
                    .HasColumnName("DATA179")
                    .HasMaxLength(40);

                entity.Property(e => e.Data180)
                    .HasColumnName("DATA180")
                    .HasMaxLength(40);

                entity.Property(e => e.Data181)
                    .HasColumnName("DATA181")
                    .HasMaxLength(40);

                entity.Property(e => e.Data182)
                    .HasColumnName("DATA182")
                    .HasMaxLength(40);

                entity.Property(e => e.Data183)
                    .HasColumnName("DATA183")
                    .HasMaxLength(40);

                entity.Property(e => e.Data184)
                    .HasColumnName("DATA184")
                    .HasMaxLength(40);

                entity.Property(e => e.Data185)
                    .HasColumnName("DATA185")
                    .HasMaxLength(40);

                entity.Property(e => e.Data186)
                    .HasColumnName("DATA186")
                    .HasMaxLength(40);

                entity.Property(e => e.Data187)
                    .HasColumnName("DATA187")
                    .HasMaxLength(40);

                entity.Property(e => e.Data188)
                    .HasColumnName("DATA188")
                    .HasMaxLength(40);

                entity.Property(e => e.Data189)
                    .HasColumnName("DATA189")
                    .HasMaxLength(40);

                entity.Property(e => e.Data190)
                    .HasColumnName("DATA190")
                    .HasMaxLength(40);

                entity.Property(e => e.Data191)
                    .HasColumnName("DATA191")
                    .HasMaxLength(40);

                entity.Property(e => e.Data192)
                    .HasColumnName("DATA192")
                    .HasMaxLength(40);

                entity.Property(e => e.Data193)
                    .HasColumnName("DATA193")
                    .HasMaxLength(40);

                entity.Property(e => e.Data194)
                    .HasColumnName("DATA194")
                    .HasMaxLength(40);

                entity.Property(e => e.Data195)
                    .HasColumnName("DATA195")
                    .HasMaxLength(40);

                entity.Property(e => e.Data196)
                    .HasColumnName("DATA196")
                    .HasMaxLength(40);

                entity.Property(e => e.Data197)
                    .HasColumnName("DATA197")
                    .HasMaxLength(40);

                entity.Property(e => e.Data198)
                    .HasColumnName("DATA198")
                    .HasMaxLength(40);

                entity.Property(e => e.Data199)
                    .HasColumnName("DATA199")
                    .HasMaxLength(40);

                entity.Property(e => e.Data200)
                    .HasColumnName("DATA200")
                    .HasMaxLength(40);

                entity.Property(e => e.Data201)
                    .HasColumnName("DATA201")
                    .HasMaxLength(40);

                entity.Property(e => e.Data202)
                    .HasColumnName("DATA202")
                    .HasMaxLength(40);

                entity.Property(e => e.Data203)
                    .HasColumnName("DATA203")
                    .HasMaxLength(40);

                entity.Property(e => e.Data204)
                    .HasColumnName("DATA204")
                    .HasMaxLength(40);

                entity.Property(e => e.Data205)
                    .HasColumnName("DATA205")
                    .HasMaxLength(40);

                entity.Property(e => e.Data206)
                    .HasColumnName("DATA206")
                    .HasMaxLength(40);

                entity.Property(e => e.Data207)
                    .HasColumnName("DATA207")
                    .HasMaxLength(40);

                entity.Property(e => e.Data208)
                    .HasColumnName("DATA208")
                    .HasMaxLength(40);

                entity.Property(e => e.Data209)
                    .HasColumnName("DATA209")
                    .HasMaxLength(40);

                entity.Property(e => e.Data210)
                    .HasColumnName("DATA210")
                    .HasMaxLength(40);

                entity.Property(e => e.Data211)
                    .HasColumnName("DATA211")
                    .HasMaxLength(40);

                entity.Property(e => e.Data212)
                    .HasColumnName("DATA212")
                    .HasMaxLength(40);

                entity.Property(e => e.Data213)
                    .HasColumnName("DATA213")
                    .HasMaxLength(40);

                entity.Property(e => e.Data214)
                    .HasColumnName("DATA214")
                    .HasMaxLength(40);

                entity.Property(e => e.Data215)
                    .HasColumnName("DATA215")
                    .HasMaxLength(40);

                entity.Property(e => e.Data216)
                    .HasColumnName("DATA216")
                    .HasMaxLength(40);

                entity.Property(e => e.Data217)
                    .HasColumnName("DATA217")
                    .HasMaxLength(40);

                entity.Property(e => e.Data218)
                    .HasColumnName("DATA218")
                    .HasMaxLength(40);

                entity.Property(e => e.Data219)
                    .HasColumnName("DATA219")
                    .HasMaxLength(40);

                entity.Property(e => e.Data220)
                    .HasColumnName("DATA220")
                    .HasMaxLength(40);

                entity.Property(e => e.Data221)
                    .HasColumnName("DATA221")
                    .HasMaxLength(40);

                entity.Property(e => e.Data222)
                    .HasColumnName("DATA222")
                    .HasMaxLength(40);

                entity.Property(e => e.Data223)
                    .HasColumnName("DATA223")
                    .HasMaxLength(40);

                entity.Property(e => e.Data224)
                    .HasColumnName("DATA224")
                    .HasMaxLength(40);

                entity.Property(e => e.Data225)
                    .HasColumnName("DATA225")
                    .HasMaxLength(40);

                entity.Property(e => e.Data226)
                    .HasColumnName("DATA226")
                    .HasMaxLength(40);

                entity.Property(e => e.Data227)
                    .HasColumnName("DATA227")
                    .HasMaxLength(40);

                entity.Property(e => e.Data228)
                    .HasColumnName("DATA228")
                    .HasMaxLength(40);

                entity.Property(e => e.Data229)
                    .HasColumnName("DATA229")
                    .HasMaxLength(40);

                entity.Property(e => e.Data230)
                    .HasColumnName("DATA230")
                    .HasMaxLength(40);

                entity.Property(e => e.Data231)
                    .HasColumnName("DATA231")
                    .HasMaxLength(40);

                entity.Property(e => e.Data232)
                    .HasColumnName("DATA232")
                    .HasMaxLength(40);

                entity.Property(e => e.Data233)
                    .HasColumnName("DATA233")
                    .HasMaxLength(40);

                entity.Property(e => e.Data234)
                    .HasColumnName("DATA234")
                    .HasMaxLength(40);

                entity.Property(e => e.Data235)
                    .HasColumnName("DATA235")
                    .HasMaxLength(40);

                entity.Property(e => e.Data236)
                    .HasColumnName("DATA236")
                    .HasMaxLength(40);

                entity.Property(e => e.Data237)
                    .HasColumnName("DATA237")
                    .HasMaxLength(40);

                entity.Property(e => e.Data238)
                    .HasColumnName("DATA238")
                    .HasMaxLength(40);

                entity.Property(e => e.Data239)
                    .HasColumnName("DATA239")
                    .HasMaxLength(40);

                entity.Property(e => e.Data240)
                    .HasColumnName("DATA240")
                    .HasMaxLength(40);

                entity.Property(e => e.Data241)
                    .HasColumnName("DATA241")
                    .HasMaxLength(40);

                entity.Property(e => e.Data242)
                    .HasColumnName("DATA242")
                    .HasMaxLength(40);

                entity.Property(e => e.Data243)
                    .HasColumnName("DATA243")
                    .HasMaxLength(40);

                entity.Property(e => e.Data244)
                    .HasColumnName("DATA244")
                    .HasMaxLength(40);

                entity.Property(e => e.Data245)
                    .HasColumnName("DATA245")
                    .HasMaxLength(40);

                entity.Property(e => e.Data246)
                    .HasColumnName("DATA246")
                    .HasMaxLength(40);

                entity.Property(e => e.Data247)
                    .HasColumnName("DATA247")
                    .HasMaxLength(40);

                entity.Property(e => e.Data248)
                    .HasColumnName("DATA248")
                    .HasMaxLength(40);

                entity.Property(e => e.Data249)
                    .HasColumnName("DATA249")
                    .HasMaxLength(40);

                entity.Property(e => e.Data250)
                    .HasColumnName("DATA250")
                    .HasMaxLength(40);

                entity.Property(e => e.Data251)
                    .HasColumnName("DATA251")
                    .HasMaxLength(40);

                entity.Property(e => e.Data252)
                    .HasColumnName("DATA252")
                    .HasMaxLength(40);

                entity.Property(e => e.Data253)
                    .HasColumnName("DATA253")
                    .HasMaxLength(40);

                entity.Property(e => e.Data254)
                    .HasColumnName("DATA254")
                    .HasMaxLength(40);

                entity.Property(e => e.Data255)
                    .HasColumnName("DATA255")
                    .HasMaxLength(40);

                entity.Property(e => e.Data256)
                    .HasColumnName("DATA256")
                    .HasMaxLength(40);

                entity.Property(e => e.Data257)
                    .HasColumnName("DATA257")
                    .HasMaxLength(40);

                entity.Property(e => e.Data258)
                    .HasColumnName("DATA258")
                    .HasMaxLength(40);

                entity.Property(e => e.Data259)
                    .HasColumnName("DATA259")
                    .HasMaxLength(40);

                entity.Property(e => e.Data260)
                    .HasColumnName("DATA260")
                    .HasMaxLength(40);

                entity.Property(e => e.Data261)
                    .HasColumnName("DATA261")
                    .HasMaxLength(40);

                entity.Property(e => e.Data262)
                    .HasColumnName("DATA262")
                    .HasMaxLength(40);

                entity.Property(e => e.Data263)
                    .HasColumnName("DATA263")
                    .HasMaxLength(40);

                entity.Property(e => e.Data264)
                    .HasColumnName("DATA264")
                    .HasMaxLength(40);

                entity.Property(e => e.Data265)
                    .HasColumnName("DATA265")
                    .HasMaxLength(40);

                entity.Property(e => e.Data266)
                    .HasColumnName("DATA266")
                    .HasMaxLength(40);

                entity.Property(e => e.Data267)
                    .HasColumnName("DATA267")
                    .HasMaxLength(40);

                entity.Property(e => e.Data268)
                    .HasColumnName("DATA268")
                    .HasMaxLength(40);

                entity.Property(e => e.Data269)
                    .HasColumnName("DATA269")
                    .HasMaxLength(40);

                entity.Property(e => e.Data270)
                    .HasColumnName("DATA270")
                    .HasMaxLength(40);

                entity.Property(e => e.Data271)
                    .HasColumnName("DATA271")
                    .HasMaxLength(40);

                entity.Property(e => e.Data272)
                    .HasColumnName("DATA272")
                    .HasMaxLength(40);

                entity.Property(e => e.Data273)
                    .HasColumnName("DATA273")
                    .HasMaxLength(40);

                entity.Property(e => e.Data274)
                    .HasColumnName("DATA274")
                    .HasMaxLength(40);

                entity.Property(e => e.Data275)
                    .HasColumnName("DATA275")
                    .HasMaxLength(40);

                entity.Property(e => e.Data276)
                    .HasColumnName("DATA276")
                    .HasMaxLength(40);

                entity.Property(e => e.Data277)
                    .HasColumnName("DATA277")
                    .HasMaxLength(40);

                entity.Property(e => e.Data278)
                    .HasColumnName("DATA278")
                    .HasMaxLength(40);

                entity.Property(e => e.Data279)
                    .HasColumnName("DATA279")
                    .HasMaxLength(40);

                entity.Property(e => e.Data280)
                    .HasColumnName("DATA280")
                    .HasMaxLength(40);

                entity.Property(e => e.Data281)
                    .HasColumnName("DATA281")
                    .HasMaxLength(40);

                entity.Property(e => e.Data282)
                    .HasColumnName("DATA282")
                    .HasMaxLength(40);

                entity.Property(e => e.Data283)
                    .HasColumnName("DATA283")
                    .HasMaxLength(40);

                entity.Property(e => e.Data284)
                    .HasColumnName("DATA284")
                    .HasMaxLength(40);

                entity.Property(e => e.Data285)
                    .HasColumnName("DATA285")
                    .HasMaxLength(40);

                entity.Property(e => e.Data286)
                    .HasColumnName("DATA286")
                    .HasMaxLength(40);

                entity.Property(e => e.Data287)
                    .HasColumnName("DATA287")
                    .HasMaxLength(40);

                entity.Property(e => e.Data288)
                    .HasColumnName("DATA288")
                    .HasMaxLength(40);

                entity.Property(e => e.Data289)
                    .HasColumnName("DATA289")
                    .HasMaxLength(40);

                entity.Property(e => e.Data290)
                    .HasColumnName("DATA290")
                    .HasMaxLength(40);

                entity.Property(e => e.Data291)
                    .HasColumnName("DATA291")
                    .HasMaxLength(40);

                entity.Property(e => e.Data292)
                    .HasColumnName("DATA292")
                    .HasMaxLength(40);

                entity.Property(e => e.Data293)
                    .HasColumnName("DATA293")
                    .HasMaxLength(40);

                entity.Property(e => e.Data294)
                    .HasColumnName("DATA294")
                    .HasMaxLength(40);

                entity.Property(e => e.Data295)
                    .HasColumnName("DATA295")
                    .HasMaxLength(40);

                entity.Property(e => e.Data296)
                    .HasColumnName("DATA296")
                    .HasMaxLength(40);

                entity.Property(e => e.Data297)
                    .HasColumnName("DATA297")
                    .HasMaxLength(40);

                entity.Property(e => e.Data298)
                    .HasColumnName("DATA298")
                    .HasMaxLength(40);

                entity.Property(e => e.Data299)
                    .HasColumnName("DATA299")
                    .HasMaxLength(40);

                entity.Property(e => e.Data300)
                    .HasColumnName("DATA300")
                    .HasMaxLength(40);

                entity.Property(e => e.Data301)
                    .HasColumnName("DATA301")
                    .HasMaxLength(40);

                entity.Property(e => e.Data302)
                    .HasColumnName("DATA302")
                    .HasMaxLength(40);

                entity.Property(e => e.Data303)
                    .HasColumnName("DATA303")
                    .HasMaxLength(40);

                entity.Property(e => e.Data304)
                    .HasColumnName("DATA304")
                    .HasMaxLength(40);

                entity.Property(e => e.Data305)
                    .HasColumnName("DATA305")
                    .HasMaxLength(40);

                entity.Property(e => e.Data306)
                    .HasColumnName("DATA306")
                    .HasMaxLength(40);

                entity.Property(e => e.Data307)
                    .HasColumnName("DATA307")
                    .HasMaxLength(40);

                entity.Property(e => e.Data308)
                    .HasColumnName("DATA308")
                    .HasMaxLength(40);

                entity.Property(e => e.Data309)
                    .HasColumnName("DATA309")
                    .HasMaxLength(40);

                entity.Property(e => e.Data310)
                    .HasColumnName("DATA310")
                    .HasMaxLength(40);

                entity.Property(e => e.Data311)
                    .HasColumnName("DATA311")
                    .HasMaxLength(40);

                entity.Property(e => e.Data312)
                    .HasColumnName("DATA312")
                    .HasMaxLength(40);

                entity.Property(e => e.Data313)
                    .HasColumnName("DATA313")
                    .HasMaxLength(40);

                entity.Property(e => e.Data314)
                    .HasColumnName("DATA314")
                    .HasMaxLength(40);

                entity.Property(e => e.Data315)
                    .HasColumnName("DATA315")
                    .HasMaxLength(40);

                entity.Property(e => e.Data316)
                    .HasColumnName("DATA316")
                    .HasMaxLength(40);

                entity.Property(e => e.Data317)
                    .HasColumnName("DATA317")
                    .HasMaxLength(40);

                entity.Property(e => e.Data318)
                    .HasColumnName("DATA318")
                    .HasMaxLength(40);

                entity.Property(e => e.Data319)
                    .HasColumnName("DATA319")
                    .HasMaxLength(40);

                entity.Property(e => e.Data320)
                    .HasColumnName("DATA320")
                    .HasMaxLength(40);

                entity.Property(e => e.Data321)
                    .HasColumnName("DATA321")
                    .HasMaxLength(40);

                entity.Property(e => e.Data322)
                    .HasColumnName("DATA322")
                    .HasMaxLength(40);

                entity.Property(e => e.Data323)
                    .HasColumnName("DATA323")
                    .HasMaxLength(40);

                entity.Property(e => e.Data324)
                    .HasColumnName("DATA324")
                    .HasMaxLength(40);

                entity.Property(e => e.Data325)
                    .HasColumnName("DATA325")
                    .HasMaxLength(40);

                entity.Property(e => e.Data326)
                    .HasColumnName("DATA326")
                    .HasMaxLength(40);

                entity.Property(e => e.Data327)
                    .HasColumnName("DATA327")
                    .HasMaxLength(40);

                entity.Property(e => e.Data328)
                    .HasColumnName("DATA328")
                    .HasMaxLength(40);

                entity.Property(e => e.Data329)
                    .HasColumnName("DATA329")
                    .HasMaxLength(40);

                entity.Property(e => e.Data330)
                    .HasColumnName("DATA330")
                    .HasMaxLength(40);

                entity.Property(e => e.Data331)
                    .HasColumnName("DATA331")
                    .HasMaxLength(40);

                entity.Property(e => e.Data332)
                    .HasColumnName("DATA332")
                    .HasMaxLength(40);

                entity.Property(e => e.Data333)
                    .HasColumnName("DATA333")
                    .HasMaxLength(40);

                entity.Property(e => e.Data334)
                    .HasColumnName("DATA334")
                    .HasMaxLength(40);

                entity.Property(e => e.Data335)
                    .HasColumnName("DATA335")
                    .HasMaxLength(40);

                entity.Property(e => e.Data336)
                    .HasColumnName("DATA336")
                    .HasMaxLength(40);

                entity.Property(e => e.Data337)
                    .HasColumnName("DATA337")
                    .HasMaxLength(40);

                entity.Property(e => e.Data338)
                    .HasColumnName("DATA338")
                    .HasMaxLength(40);

                entity.Property(e => e.Data339)
                    .HasColumnName("DATA339")
                    .HasMaxLength(40);

                entity.Property(e => e.Data340)
                    .HasColumnName("DATA340")
                    .HasMaxLength(40);

                entity.Property(e => e.Data341)
                    .HasColumnName("DATA341")
                    .HasMaxLength(40);

                entity.Property(e => e.Data342)
                    .HasColumnName("DATA342")
                    .HasMaxLength(40);

                entity.Property(e => e.Data343)
                    .HasColumnName("DATA343")
                    .HasMaxLength(40);

                entity.Property(e => e.Data344)
                    .HasColumnName("DATA344")
                    .HasMaxLength(40);

                entity.Property(e => e.Data345)
                    .HasColumnName("DATA345")
                    .HasMaxLength(40);

                entity.Property(e => e.Data346)
                    .HasColumnName("DATA346")
                    .HasMaxLength(40);

                entity.Property(e => e.Data347)
                    .HasColumnName("DATA347")
                    .HasMaxLength(40);

                entity.Property(e => e.Data348)
                    .HasColumnName("DATA348")
                    .HasMaxLength(40);

                entity.Property(e => e.Data349)
                    .HasColumnName("DATA349")
                    .HasMaxLength(40);

                entity.Property(e => e.Data350)
                    .HasColumnName("DATA350")
                    .HasMaxLength(40);

                entity.Property(e => e.Data351)
                    .HasColumnName("DATA351")
                    .HasMaxLength(40);

                entity.Property(e => e.Data352)
                    .HasColumnName("DATA352")
                    .HasMaxLength(40);

                entity.Property(e => e.Data353)
                    .HasColumnName("DATA353")
                    .HasMaxLength(40);

                entity.Property(e => e.Data354)
                    .HasColumnName("DATA354")
                    .HasMaxLength(40);

                entity.Property(e => e.Data355)
                    .HasColumnName("DATA355")
                    .HasMaxLength(40);

                entity.Property(e => e.Data356)
                    .HasColumnName("DATA356")
                    .HasMaxLength(40);

                entity.Property(e => e.Data357)
                    .HasColumnName("DATA357")
                    .HasMaxLength(40);

                entity.Property(e => e.Data358)
                    .HasColumnName("DATA358")
                    .HasMaxLength(40);

                entity.Property(e => e.Data359)
                    .HasColumnName("DATA359")
                    .HasMaxLength(40);

                entity.Property(e => e.Data360)
                    .HasColumnName("DATA360")
                    .HasMaxLength(40);

                entity.Property(e => e.Data361)
                    .HasColumnName("DATA361")
                    .HasMaxLength(40);

                entity.Property(e => e.Data362)
                    .HasColumnName("DATA362")
                    .HasMaxLength(40);

                entity.Property(e => e.Data363)
                    .HasColumnName("DATA363")
                    .HasMaxLength(40);

                entity.Property(e => e.Data364)
                    .HasColumnName("DATA364")
                    .HasMaxLength(40);

                entity.Property(e => e.Data365)
                    .HasColumnName("DATA365")
                    .HasMaxLength(40);

                entity.Property(e => e.Data366)
                    .HasColumnName("DATA366")
                    .HasMaxLength(40);

                entity.Property(e => e.Data367)
                    .HasColumnName("DATA367")
                    .HasMaxLength(40);

                entity.Property(e => e.Data368)
                    .HasColumnName("DATA368")
                    .HasMaxLength(40);

                entity.Property(e => e.Data369)
                    .HasColumnName("DATA369")
                    .HasMaxLength(40);

                entity.Property(e => e.Data370)
                    .HasColumnName("DATA370")
                    .HasMaxLength(40);

                entity.Property(e => e.Data371)
                    .HasColumnName("DATA371")
                    .HasMaxLength(40);

                entity.Property(e => e.Data372)
                    .HasColumnName("DATA372")
                    .HasMaxLength(40);

                entity.Property(e => e.Data373)
                    .HasColumnName("DATA373")
                    .HasMaxLength(40);

                entity.Property(e => e.Data374)
                    .HasColumnName("DATA374")
                    .HasMaxLength(40);

                entity.Property(e => e.Data375)
                    .HasColumnName("DATA375")
                    .HasMaxLength(40);

                entity.Property(e => e.Data376)
                    .HasColumnName("DATA376")
                    .HasMaxLength(40);

                entity.Property(e => e.Data377)
                    .HasColumnName("DATA377")
                    .HasMaxLength(40);

                entity.Property(e => e.Data378)
                    .HasColumnName("DATA378")
                    .HasMaxLength(40);

                entity.Property(e => e.Data379)
                    .HasColumnName("DATA379")
                    .HasMaxLength(40);

                entity.Property(e => e.Data380)
                    .HasColumnName("DATA380")
                    .HasMaxLength(40);

                entity.Property(e => e.Data381)
                    .HasColumnName("DATA381")
                    .HasMaxLength(40);

                entity.Property(e => e.Data382)
                    .HasColumnName("DATA382")
                    .HasMaxLength(40);

                entity.Property(e => e.Data383)
                    .HasColumnName("DATA383")
                    .HasMaxLength(40);

                entity.Property(e => e.Data384)
                    .HasColumnName("DATA384")
                    .HasMaxLength(40);

                entity.Property(e => e.Data385)
                    .HasColumnName("DATA385")
                    .HasMaxLength(40);

                entity.Property(e => e.Data386)
                    .HasColumnName("DATA386")
                    .HasMaxLength(40);

                entity.Property(e => e.Data387)
                    .HasColumnName("DATA387")
                    .HasMaxLength(40);

                entity.Property(e => e.Data388)
                    .HasColumnName("DATA388")
                    .HasMaxLength(40);

                entity.Property(e => e.Data389)
                    .HasColumnName("DATA389")
                    .HasMaxLength(40);

                entity.Property(e => e.Data390)
                    .HasColumnName("DATA390")
                    .HasMaxLength(40);

                entity.Property(e => e.Data391)
                    .HasColumnName("DATA391")
                    .HasMaxLength(40);

                entity.Property(e => e.Data392)
                    .HasColumnName("DATA392")
                    .HasMaxLength(40);

                entity.Property(e => e.Data393)
                    .HasColumnName("DATA393")
                    .HasMaxLength(40);

                entity.Property(e => e.Data394)
                    .HasColumnName("DATA394")
                    .HasMaxLength(40);

                entity.Property(e => e.Data395)
                    .HasColumnName("DATA395")
                    .HasMaxLength(40);

                entity.Property(e => e.Data396)
                    .HasColumnName("DATA396")
                    .HasMaxLength(40);

                entity.Property(e => e.Data397)
                    .HasColumnName("DATA397")
                    .HasMaxLength(40);

                entity.Property(e => e.Data398)
                    .HasColumnName("DATA398")
                    .HasMaxLength(40);

                entity.Property(e => e.Data399)
                    .HasColumnName("DATA399")
                    .HasMaxLength(40);

                entity.Property(e => e.Data400)
                    .HasColumnName("DATA400")
                    .HasMaxLength(40);

                entity.Property(e => e.Data401)
                    .HasColumnName("DATA401")
                    .HasMaxLength(40);

                entity.Property(e => e.Data402)
                    .HasColumnName("DATA402")
                    .HasMaxLength(40);

                entity.Property(e => e.Data403)
                    .HasColumnName("DATA403")
                    .HasMaxLength(40);

                entity.Property(e => e.Data404)
                    .HasColumnName("DATA404")
                    .HasMaxLength(40);

                entity.Property(e => e.Data405)
                    .HasColumnName("DATA405")
                    .HasMaxLength(40);

                entity.Property(e => e.Data406)
                    .HasColumnName("DATA406")
                    .HasMaxLength(40);

                entity.Property(e => e.Data407)
                    .HasColumnName("DATA407")
                    .HasMaxLength(40);

                entity.Property(e => e.Data408)
                    .HasColumnName("DATA408")
                    .HasMaxLength(40);

                entity.Property(e => e.Data409)
                    .HasColumnName("DATA409")
                    .HasMaxLength(40);

                entity.Property(e => e.Data410)
                    .HasColumnName("DATA410")
                    .HasMaxLength(40);

                entity.Property(e => e.Data411)
                    .HasColumnName("DATA411")
                    .HasMaxLength(40);

                entity.Property(e => e.Data412)
                    .HasColumnName("DATA412")
                    .HasMaxLength(40);

                entity.Property(e => e.Data413)
                    .HasColumnName("DATA413")
                    .HasMaxLength(40);

                entity.Property(e => e.Data414)
                    .HasColumnName("DATA414")
                    .HasMaxLength(40);

                entity.Property(e => e.Data415)
                    .HasColumnName("DATA415")
                    .HasMaxLength(40);

                entity.Property(e => e.Data416)
                    .HasColumnName("DATA416")
                    .HasMaxLength(40);

                entity.Property(e => e.Data417)
                    .HasColumnName("DATA417")
                    .HasMaxLength(40);

                entity.Property(e => e.Data418)
                    .HasColumnName("DATA418")
                    .HasMaxLength(40);

                entity.Property(e => e.Data419)
                    .HasColumnName("DATA419")
                    .HasMaxLength(40);

                entity.Property(e => e.Data420)
                    .HasColumnName("DATA420")
                    .HasMaxLength(40);

                entity.Property(e => e.Data421)
                    .HasColumnName("DATA421")
                    .HasMaxLength(40);

                entity.Property(e => e.Data422)
                    .HasColumnName("DATA422")
                    .HasMaxLength(40);

                entity.Property(e => e.Data423)
                    .HasColumnName("DATA423")
                    .HasMaxLength(40);

                entity.Property(e => e.Data424)
                    .HasColumnName("DATA424")
                    .HasMaxLength(40);

                entity.Property(e => e.Data425)
                    .HasColumnName("DATA425")
                    .HasMaxLength(40);

                entity.Property(e => e.Data426)
                    .HasColumnName("DATA426")
                    .HasMaxLength(40);

                entity.Property(e => e.Data427)
                    .HasColumnName("DATA427")
                    .HasMaxLength(40);

                entity.Property(e => e.Data428)
                    .HasColumnName("DATA428")
                    .HasMaxLength(40);

                entity.Property(e => e.Data429)
                    .HasColumnName("DATA429")
                    .HasMaxLength(40);

                entity.Property(e => e.Data430)
                    .HasColumnName("DATA430")
                    .HasMaxLength(40);

                entity.Property(e => e.Data431)
                    .HasColumnName("DATA431")
                    .HasMaxLength(40);

                entity.Property(e => e.Data432)
                    .HasColumnName("DATA432")
                    .HasMaxLength(40);

                entity.Property(e => e.Data433)
                    .HasColumnName("DATA433")
                    .HasMaxLength(40);

                entity.Property(e => e.Data434)
                    .HasColumnName("DATA434")
                    .HasMaxLength(40);

                entity.Property(e => e.Data435)
                    .HasColumnName("DATA435")
                    .HasMaxLength(40);

                entity.Property(e => e.Data436)
                    .HasColumnName("DATA436")
                    .HasMaxLength(40);

                entity.Property(e => e.Data437)
                    .HasColumnName("DATA437")
                    .HasMaxLength(40);

                entity.Property(e => e.Data438)
                    .HasColumnName("DATA438")
                    .HasMaxLength(40);

                entity.Property(e => e.Data439)
                    .HasColumnName("DATA439")
                    .HasMaxLength(40);

                entity.Property(e => e.Data440)
                    .HasColumnName("DATA440")
                    .HasMaxLength(40);

                entity.Property(e => e.Data441)
                    .HasColumnName("DATA441")
                    .HasMaxLength(40);

                entity.Property(e => e.Data442)
                    .HasColumnName("DATA442")
                    .HasMaxLength(40);

                entity.Property(e => e.Data443)
                    .HasColumnName("DATA443")
                    .HasMaxLength(40);

                entity.Property(e => e.Data444)
                    .HasColumnName("DATA444")
                    .HasMaxLength(40);

                entity.Property(e => e.Data445)
                    .HasColumnName("DATA445")
                    .HasMaxLength(40);

                entity.Property(e => e.Data446)
                    .HasColumnName("DATA446")
                    .HasMaxLength(40);

                entity.Property(e => e.Data447)
                    .HasColumnName("DATA447")
                    .HasMaxLength(40);

                entity.Property(e => e.Data448)
                    .HasColumnName("DATA448")
                    .HasMaxLength(40);

                entity.Property(e => e.Data449)
                    .HasColumnName("DATA449")
                    .HasMaxLength(40);

                entity.Property(e => e.Data450)
                    .HasColumnName("DATA450")
                    .HasMaxLength(40);

                entity.Property(e => e.Data451)
                    .HasColumnName("DATA451")
                    .HasMaxLength(40);

                entity.Property(e => e.Data452)
                    .HasColumnName("DATA452")
                    .HasMaxLength(40);

                entity.Property(e => e.Data453)
                    .HasColumnName("DATA453")
                    .HasMaxLength(40);

                entity.Property(e => e.Data454)
                    .HasColumnName("DATA454")
                    .HasMaxLength(40);

                entity.Property(e => e.Data455)
                    .HasColumnName("DATA455")
                    .HasMaxLength(40);

                entity.Property(e => e.Data456)
                    .HasColumnName("DATA456")
                    .HasMaxLength(40);

                entity.Property(e => e.Data457)
                    .HasColumnName("DATA457")
                    .HasMaxLength(40);

                entity.Property(e => e.Data458)
                    .HasColumnName("DATA458")
                    .HasMaxLength(40);

                entity.Property(e => e.Data459)
                    .HasColumnName("DATA459")
                    .HasMaxLength(40);

                entity.Property(e => e.Data460)
                    .HasColumnName("DATA460")
                    .HasMaxLength(40);

                entity.Property(e => e.Data461)
                    .HasColumnName("DATA461")
                    .HasMaxLength(40);

                entity.Property(e => e.Data462)
                    .HasColumnName("DATA462")
                    .HasMaxLength(40);

                entity.Property(e => e.Data463)
                    .HasColumnName("DATA463")
                    .HasMaxLength(40);

                entity.Property(e => e.Data464)
                    .HasColumnName("DATA464")
                    .HasMaxLength(40);

                entity.Property(e => e.Data465)
                    .HasColumnName("DATA465")
                    .HasMaxLength(40);

                entity.Property(e => e.Data466)
                    .HasColumnName("DATA466")
                    .HasMaxLength(40);

                entity.Property(e => e.Data467)
                    .HasColumnName("DATA467")
                    .HasMaxLength(40);

                entity.Property(e => e.Data468)
                    .HasColumnName("DATA468")
                    .HasMaxLength(40);

                entity.Property(e => e.Data469)
                    .HasColumnName("DATA469")
                    .HasMaxLength(40);

                entity.Property(e => e.Data470)
                    .HasColumnName("DATA470")
                    .HasMaxLength(40);

                entity.Property(e => e.Data471)
                    .HasColumnName("DATA471")
                    .HasMaxLength(40);

                entity.Property(e => e.Data472)
                    .HasColumnName("DATA472")
                    .HasMaxLength(40);

                entity.Property(e => e.Data473)
                    .HasColumnName("DATA473")
                    .HasMaxLength(40);

                entity.Property(e => e.Data474)
                    .HasColumnName("DATA474")
                    .HasMaxLength(40);

                entity.Property(e => e.Data475)
                    .HasColumnName("DATA475")
                    .HasMaxLength(40);

                entity.Property(e => e.Data476)
                    .HasColumnName("DATA476")
                    .HasMaxLength(40);

                entity.Property(e => e.Data477)
                    .HasColumnName("DATA477")
                    .HasMaxLength(40);

                entity.Property(e => e.Data478)
                    .HasColumnName("DATA478")
                    .HasMaxLength(40);

                entity.Property(e => e.Data479)
                    .HasColumnName("DATA479")
                    .HasMaxLength(40);

                entity.Property(e => e.Data480)
                    .HasColumnName("DATA480")
                    .HasMaxLength(40);

                entity.Property(e => e.Data481)
                    .HasColumnName("DATA481")
                    .HasMaxLength(40);

                entity.Property(e => e.Data482)
                    .HasColumnName("DATA482")
                    .HasMaxLength(40);

                entity.Property(e => e.Data483)
                    .HasColumnName("DATA483")
                    .HasMaxLength(40);

                entity.Property(e => e.Data484)
                    .HasColumnName("DATA484")
                    .HasMaxLength(40);

                entity.Property(e => e.Data485)
                    .HasColumnName("DATA485")
                    .HasMaxLength(40);

                entity.Property(e => e.Data486)
                    .HasColumnName("DATA486")
                    .HasMaxLength(40);

                entity.Property(e => e.Data487)
                    .HasColumnName("DATA487")
                    .HasMaxLength(40);

                entity.Property(e => e.Data488)
                    .HasColumnName("DATA488")
                    .HasMaxLength(40);

                entity.Property(e => e.Data489)
                    .HasColumnName("DATA489")
                    .HasMaxLength(40);

                entity.Property(e => e.Data490)
                    .HasColumnName("DATA490")
                    .HasMaxLength(40);

                entity.Property(e => e.Data491)
                    .HasColumnName("DATA491")
                    .HasMaxLength(40);

                entity.Property(e => e.Data492)
                    .HasColumnName("DATA492")
                    .HasMaxLength(40);

                entity.Property(e => e.Data493)
                    .HasColumnName("DATA493")
                    .HasMaxLength(40);

                entity.Property(e => e.Data494)
                    .HasColumnName("DATA494")
                    .HasMaxLength(40);

                entity.Property(e => e.Data495)
                    .HasColumnName("DATA495")
                    .HasMaxLength(40);

                entity.Property(e => e.Data496)
                    .HasColumnName("DATA496")
                    .HasMaxLength(40);

                entity.Property(e => e.Data497)
                    .HasColumnName("DATA497")
                    .HasMaxLength(40);

                entity.Property(e => e.Data498)
                    .HasColumnName("DATA498")
                    .HasMaxLength(40);

                entity.Property(e => e.Data499)
                    .HasColumnName("DATA499")
                    .HasMaxLength(40);

                entity.Property(e => e.Data500)
                    .HasColumnName("DATA500")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpPfointlockInf>(entity =>
            {
                entity.HasKey(e => new { e.IntlockId, e.FacId, e.ProdId, e.ProdVer, e.FlowId, e.FlowVer, e.OperId, e.OperVer, e.IntlockTyp })
                    .HasName("DCP_PFOINTLOCK_INF_PK");

                entity.ToTable("DCP_PFOINTLOCK_INF");

                entity.Property(e => e.IntlockId)
                    .HasColumnName("INTLOCK_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer)
                    .HasColumnName("PROD_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.IntlockTyp)
                    .HasColumnName("INTLOCK_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.AndOrTyp)
                    .HasColumnName("AND_OR_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkFlowId)
                    .HasColumnName("CHK_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkOperId)
                    .HasColumnName("CHK_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkProdId)
                    .HasColumnName("CHK_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.HoldCd)
                    .HasColumnName("HOLD_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.HoldCtn)
                    .HasColumnName("HOLD_CTN")
                    .HasMaxLength(512);

                entity.Property(e => e.HoldNm)
                    .HasColumnName("HOLD_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.InOutTyp)
                    .HasColumnName("IN_OUT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ItemNm)
                    .HasColumnName("ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.LlVal)
                    .HasColumnName("LL_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LotWfGbnCd)
                    .HasColumnName("LOT_WF_GBN_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.UlVal)
                    .HasColumnName("UL_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpPredcoldataInf>(entity =>
            {
                entity.HasKey(e => e.DcolDataId)
                    .HasName("DCP_PREDCOLDATA_INF_PK");

                entity.ToTable("DCP_PREDCOLDATA_INF");

                entity.HasIndex(e => new { e.LotId, e.MesSendSkip })
                    .HasName("DCP_PREDCOLDATA_INF_IX1");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BatchZoneCd)
                    .HasColumnName("BATCH_ZONE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtDesc)
                    .HasColumnName("CRT_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolTyp)
                    .HasColumnName("DCOL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpRecipeId)
                    .HasColumnName("EQP_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEqpId)
                    .HasColumnName("MAIN_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEventTm)
                    .HasColumnName("MAIN_EVENT_TM")
                    .HasMaxLength(40);

                entity.Property(e => e.MainFlowId)
                    .HasColumnName("MAIN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MatlNm)
                    .HasColumnName("MATL_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.MatlTyp)
                    .HasColumnName("MATL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MesSendSkip)
                    .HasColumnName("MES_SEND_SKIP")
                    .HasMaxLength(10);

                entity.Property(e => e.MsgTip)
                    .HasColumnName("MSG_TIP")
                    .HasMaxLength(150);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.OutTyp)
                    .HasColumnName("OUT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer)
                    .HasColumnName("PROD_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.SampLotId)
                    .HasColumnName("SAMP_LOT_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpPredcoldataitemInf>(entity =>
            {
                entity.HasKey(e => new { e.DcolDataId, e.DcolItemCd })
                    .HasName("DCP_PREDCOLDATAITEM_INF_PK");

                entity.ToTable("DCP_PREDCOLDATAITEM_INF");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxLimitVal)
                    .HasColumnName("MAX_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.MinLimitVal)
                    .HasColumnName("MIN_LIMIT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.TgtVal)
                    .HasColumnName("TGT_VAL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpPredcoldatarsltInf>(entity =>
            {
                entity.HasKey(e => new { e.DcolDataId, e.SampMatlId, e.DcolItemCd, e.DcsiteId, e.DervItemNm })
                    .HasName("DCP_PREDCOLDATARSLT_INF_PK");

                entity.ToTable("DCP_PREDCOLDATARSLT_INF");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SampMatlId)
                    .HasColumnName("SAMP_MATL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolItemCd)
                    .HasColumnName("DCOL_ITEM_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DcsiteId)
                    .HasColumnName("DCSITE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DervItemNm)
                    .HasColumnName("DERV_ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.DataTyp)
                    .HasColumnName("DATA_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.Desc)
                    .HasColumnName("DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.ItemTyp)
                    .HasColumnName("ITEM_TYP")
                    .HasMaxLength(80);

                entity.Property(e => e.RsltVal)
                    .HasColumnName("RSLT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.UnitId)
                    .HasColumnName("UNIT_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpPredcoldatasampInf>(entity =>
            {
                entity.HasKey(e => new { e.DcolDataId, e.SampMatlId })
                    .HasName("DCP_PREDCOLDATASAMP_INF_PK");

                entity.ToTable("DCP_PREDCOLDATASAMP_INF");

                entity.HasIndex(e => new { e.DcolDataId, e.SampMatlId })
                    .HasName("DCP_PREDCOLDATASAMP_INF_IX1");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SampMatlId)
                    .HasColumnName("SAMP_MATL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtDesc)
                    .HasColumnName("CRT_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SampMatlTyp)
                    .HasColumnName("SAMP_MATL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.SampNo)
                    .HasColumnName("SAMP_NO")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DcpProcessMas>(entity =>
            {
                entity.HasKey(e => new { e.Fab, e.ProcId, e.Ip, e.Port })
                    .HasName("DCP_PROCESS_MAS_IX1");

                entity.ToTable("DCP_PROCESS_MAS");

                entity.Property(e => e.Fab)
                    .HasColumnName("FAB")
                    .HasMaxLength(10);

                entity.Property(e => e.ProcId)
                    .HasColumnName("PROC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(40);

                entity.Property(e => e.Port)
                    .HasColumnName("PORT")
                    .HasMaxLength(10);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUser)
                    .HasColumnName("CHG_USER")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUser)
                    .HasColumnName("CRT_USER")
                    .HasMaxLength(40);

                entity.Property(e => e.LogPath)
                    .HasColumnName("LOG_PATH")
                    .HasMaxLength(1024);

                entity.Property(e => e.SysVerp)
                    .HasColumnName("SYS_VERP")
                    .HasMaxLength(40);

                entity.Property(e => e.UserTyp)
                    .HasColumnName("USER_TYP")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpProdMas>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.ProdId })
                    .HasName("DCP_PROD_MAS_PK");

                entity.ToTable("DCP_PROD_MAS");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ActiveStatCd)
                    .HasColumnName("ACTIVE_STAT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.ChkStatCd)
                    .HasColumnName("CHK_STAT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.Cmt)
                    .HasColumnName("CMT")
                    .HasMaxLength(2000);

                entity.Property(e => e.DenTyp)
                    .HasColumnName("DEN_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyCd)
                    .HasColumnName("FAMILY_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.FrFabId)
                    .HasColumnName("FR_FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.GenCd)
                    .HasColumnName("GEN_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.OrganizVal)
                    .HasColumnName("ORGANIZ_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdTyp)
                    .HasColumnName("PROD_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.ProduceTyp)
                    .HasColumnName("PRODUCE_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.RetrunFlowId)
                    .HasColumnName("RETRUN_FLOW_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReturnOperId)
                    .HasColumnName("RETURN_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReturnProdId)
                    .HasColumnName("RETURN_PROD_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.TechCd)
                    .HasColumnName("TECH_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.Typ1)
                    .HasColumnName("TYP_1")
                    .HasMaxLength(50);

                entity.Property(e => e.Typ2)
                    .HasColumnName("TYP_2")
                    .HasMaxLength(50);

                entity.Property(e => e.WfQty)
                    .HasColumnName("WF_QTY")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DcpRecoveryexecHis>(entity =>
            {
                entity.HasKey(e => new { e.EventTm, e.MsgCmd, e.MsgProcTyp, e.CrtTm })
                    .HasName("DCP_RECOVERYEXEC_HIS_PK");

                entity.ToTable("DCP_RECOVERYEXEC_HIS");

                entity.Property(e => e.EventTm)
                    .HasColumnName("EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.MsgCmd)
                    .HasColumnName("MSG_CMD")
                    .HasMaxLength(40);

                entity.Property(e => e.MsgProcTyp)
                    .HasColumnName("MSG_PROC_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ExecRslt)
                    .HasColumnName("EXEC_RSLT")
                    .HasMaxLength(1024);

                entity.Property(e => e.ExecTyp)
                    .HasColumnName("EXEC_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MenuId)
                    .HasColumnName("MENU_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpRecoveryprocMas>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.MsgCmd, e.MsgProcTyp })
                    .HasName("DCP_RECOVERYPROC_MAS_IX01");

                entity.ToTable("DCP_RECOVERYPROC_MAS");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.MsgCmd)
                    .HasColumnName("MSG_CMD")
                    .HasMaxLength(40);

                entity.Property(e => e.MsgProcTyp)
                    .HasColumnName("MSG_PROC_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUser)
                    .HasColumnName("CHG_USER")
                    .HasMaxLength(40);

                entity.Property(e => e.ClassPath)
                    .HasColumnName("CLASS_PATH")
                    .HasMaxLength(1024);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUser)
                    .HasColumnName("CRT_USER")
                    .HasMaxLength(40);

                entity.Property(e => e.GrpId)
                    .HasColumnName("GRP_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ListenProc)
                    .HasColumnName("LISTEN_PROC")
                    .HasMaxLength(40);

                entity.Property(e => e.MsgFormat)
                    .HasColumnName("MSG_FORMAT")
                    .HasMaxLength(40);

                entity.Property(e => e.SendNode)
                    .HasColumnName("SEND_NODE")
                    .HasMaxLength(40);

                entity.Property(e => e.SendProc)
                    .HasColumnName("SEND_PROC")
                    .HasMaxLength(40);

                entity.Property(e => e.SendTyp)
                    .HasColumnName("SEND_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.SubjCmd)
                    .HasColumnName("SUBJ_CMD")
                    .HasMaxLength(40);

                entity.Property(e => e.TimeoutSec)
                    .HasColumnName("TIMEOUT_SEC")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DcpScanrlotHis>(entity =>
            {
                entity.HasKey(e => new { e.FabId, e.Timekey, e.EqpId })
                    .HasName("DCP_SCANRLOT_HIS_PK");

                entity.ToTable("DCP_SCANRLOT_HIS");

                entity.HasIndex(e => new { e.FabId, e.OrgWfId, e.OperId })
                    .HasName("DCP_SCANRLOT_HIS_IX1");

                entity.HasIndex(e => new { e.FabId, e.WfId, e.OperId })
                    .HasName("DCP_SCANRLOT_HIS_IX2");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Timekey)
                    .HasColumnName("TIMEKEY")
                    .HasMaxLength(50);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.BatchCnt)
                    .HasColumnName("BATCH_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BatchId)
                    .HasColumnName("BATCH_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CarrierId)
                    .HasColumnName("CARRIER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ChuckId)
                    .HasColumnName("CHUCK_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtrlJobId)
                    .HasColumnName("CTRL_JOB_ID")
                    .HasMaxLength(150);

                entity.Property(e => e.DataSeq)
                    .HasColumnName("DATA_SEQ")
                    .HasMaxLength(50);

                entity.Property(e => e.DestId)
                    .HasColumnName("DEST_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.EqpIpAddr)
                    .HasColumnName("EQP_IP_ADDR")
                    .HasMaxLength(200);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MsgAlias)
                    .HasColumnName("MSG_ALIAS")
                    .HasMaxLength(100);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrgTyp)
                    .HasColumnName("ORG_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.OrgWfId)
                    .HasColumnName("ORG_WF_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.PortNo)
                    .HasColumnName("PORT_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcJobId)
                    .HasColumnName("PROC_JOB_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ProcSeq)
                    .HasColumnName("PROC_SEQ")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RECIPE_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReticleId)
                    .HasColumnName("RETICLE_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.SlotId)
                    .HasColumnName("SLOT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.SubRecipeId)
                    .HasColumnName("SUB_RECIPE_ID")
                    .HasMaxLength(250);

                entity.Property(e => e.WfId)
                    .HasColumnName("WF_ID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DcpSyslogHis>(entity =>
            {
                entity.HasKey(e => new { e.LogLevel, e.HostIpAddr, e.HostNm, e.CrtTm })
                    .HasName("DCP_SYSLOG_HIS_PK");

                entity.ToTable("DCP_SYSLOG_HIS");

                entity.Property(e => e.LogLevel)
                    .HasColumnName("LOG_LEVEL")
                    .HasMaxLength(50);

                entity.Property(e => e.HostIpAddr)
                    .HasColumnName("HOST_IP_ADDR")
                    .HasMaxLength(50);

                entity.Property(e => e.HostNm)
                    .HasColumnName("HOST_NM")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClassNm)
                    .HasColumnName("CLASS_NM")
                    .HasMaxLength(256);

                entity.Property(e => e.Cmt)
                    .HasColumnName("CMT")
                    .HasMaxLength(2000);

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ExptCauseCtn)
                    .HasColumnName("EXPT_CAUSE_CTN")
                    .HasMaxLength(4000);

                entity.Property(e => e.LogMsgCtn)
                    .HasColumnName("LOG_MSG_CTN")
                    .HasMaxLength(4000);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MethodNm)
                    .HasColumnName("METHOD_NM")
                    .HasMaxLength(256);

                entity.Property(e => e.MsgTid)
                    .HasColumnName("MSG_TID")
                    .HasMaxLength(80);

                entity.Property(e => e.ProcId)
                    .HasColumnName("PROC_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.SvcNm)
                    .HasColumnName("SVC_NM")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DcpSysqueryMas>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.SysId, e.QueryId })
                    .HasName("DCP_SYSQUERY_MAS_IX01");

                entity.ToTable("DCP_SYSQUERY_MAS");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SysId)
                    .HasColumnName("SYS_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.QueryId)
                    .HasColumnName("QUERY_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.QuerySql).HasColumnName("QUERY_SQL");
            });

            modelBuilder.Entity<DcpTableActionHis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DCP_TABLE_ACTION_HIS");

                entity.HasIndex(e => new { e.CrtTm, e.ProgId })
                    .HasName("DCP_TABLE_ACTION_HIS_IX1")
                    .IsUnique();

                entity.Property(e => e.ActionComment)
                    .HasColumnName("ACTION_COMMENT")
                    .HasMaxLength(200);

                entity.Property(e => e.AfterVal)
                    .HasColumnName("AFTER_VAL")
                    .HasMaxLength(200);

                entity.Property(e => e.BeforeVal)
                    .HasColumnName("BEFORE_VAL")
                    .HasMaxLength(200);

                entity.Property(e => e.ColumnNm)
                    .HasColumnName("COLUMN_NM")
                    .HasMaxLength(30);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.KeyVal)
                    .HasColumnName("KEY_VAL")
                    .HasMaxLength(2048);

                entity.Property(e => e.ProgId)
                    .HasColumnName("PROG_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.TableNm)
                    .HasColumnName("TABLE_NM")
                    .HasMaxLength(30);

                entity.Property(e => e.TranTyp)
                    .HasColumnName("TRAN_TYP")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpTfomodelDef>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.FlowId, e.FlowVer, e.OperId, e.OperVer })
                    .HasName("DCP_TFOMODEL_DEF_IX1");

                entity.ToTable("DCP_TFOMODEL_DEF");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpId)
                    .HasColumnName("EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkFlowId)
                    .HasColumnName("RWK_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkLimitCnt)
                    .HasColumnName("RWK_LIMIT_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkOperId)
                    .HasColumnName("RWK_OPER_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpTpfomodelDef>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.ProdId, e.ProdVer, e.FlowId, e.FlowVer, e.OperId, e.OperVer })
                    .HasName("DCP_TPFOMODEL_DEF_IX1");

                entity.ToTable("DCP_TPFOMODEL_DEF");

                entity.HasIndex(e => e.CrtTm)
                    .HasName("DCP_TPFOMODEL_DEF_IX2");

                entity.HasIndex(e => new { e.DcolId, e.DcolVer })
                    .HasName("DCP_TPFOMODEL_DEF_IX5");

                entity.HasIndex(e => new { e.FacId, e.OperId })
                    .HasName("DCP_TPFOMODEL_DEF_IX4");

                entity.HasIndex(e => new { e.FacId, e.FlowId, e.FlowVer, e.OperId, e.OperVer })
                    .HasName("DCP_TPFOMODEL_DEF_IX3");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer)
                    .HasColumnName("PROD_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DcolVer)
                    .HasColumnName("DCOL_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpId)
                    .HasColumnName("EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpRecipeId)
                    .HasColumnName("EQP_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.IdleToleranceTime)
                    .HasColumnName("IDLE_TOLERANCE_TIME")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LotBatchSize)
                    .HasColumnName("LOT_BATCH_SIZE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProduceTyp)
                    .HasColumnName("PRODUCE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkFlowId)
                    .HasColumnName("RWK_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkLimitCnt)
                    .HasColumnName("RWK_LIMIT_CNT")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkOperId)
                    .HasColumnName("RWK_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.WfLevelR2rYn)
                    .HasColumnName("WF_LEVEL_R2R_YN")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpWaferHis>(entity =>
            {
                entity.HasKey(e => new { e.WfId, e.EventNm, e.StartTm })
                    .HasName("DCP_WAFER_HIS_PK");

                entity.ToTable("DCP_WAFER_HIS");

                entity.HasIndex(e => e.CrtTm)
                    .HasName("DCP_WAFER_HIS_IX4");

                entity.HasIndex(e => new { e.EqpId, e.CrtTm })
                    .HasName("DCP_WAFER_HIS_IX2");

                entity.HasIndex(e => new { e.ModuleNm, e.StartTm })
                    .HasName("DCP_WAFER_HIS_IX1");

                entity.HasIndex(e => new { e.LotId, e.EndTm, e.OperId, e.Product, e.EventNm })
                    .HasName("DCP_WAFER_HIS_IX3");

                entity.Property(e => e.WfId)
                    .HasColumnName("WF_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EventNm)
                    .HasColumnName("EVENT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.StartTm)
                    .HasColumnName("START_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CassetteId)
                    .HasColumnName("CASSETTE_ID")
                    .HasMaxLength(64);

                entity.Property(e => e.CassetteSlot)
                    .HasColumnName("CASSETTE_SLOT")
                    .HasMaxLength(8);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EndTm)
                    .HasColumnName("END_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ModuleId)
                    .HasColumnName("MODULE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ModuleNm)
                    .HasColumnName("MODULE_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.OnlineMode)
                    .HasColumnName("ONLINE_MODE")
                    .HasMaxLength(64);

                entity.Property(e => e.OperDesc)
                    .HasColumnName("OPER_DESC")
                    .HasMaxLength(128);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(128);

                entity.Property(e => e.ProcessFlow)
                    .HasColumnName("PROCESS_FLOW")
                    .HasMaxLength(128);

                entity.Property(e => e.Prod)
                    .HasColumnName("PROD")
                    .HasMaxLength(128);

                entity.Property(e => e.Product)
                    .HasColumnName("PRODUCT")
                    .HasMaxLength(128);

                entity.Property(e => e.RcvEndTm)
                    .HasColumnName("RCV_END_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.RcvStartTm)
                    .HasColumnName("RCV_START_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RECIPE_ID")
                    .HasMaxLength(128);

                entity.Property(e => e.ResourceGroup)
                    .HasColumnName("RESOURCE_GROUP")
                    .HasMaxLength(32);

                entity.Property(e => e.ResourceTyp)
                    .HasColumnName("RESOURCE_TYP")
                    .HasMaxLength(32);

                entity.Property(e => e.SeqRecipeId)
                    .HasColumnName("SEQ_RECIPE_ID")
                    .HasMaxLength(128);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<DcpWaferInf>(entity =>
            {
                entity.HasKey(e => e.WfId)
                    .HasName("DCP_WAFER_INF_IX1");

                entity.ToTable("DCP_WAFER_INF");

                entity.Property(e => e.WfId)
                    .HasColumnName("WF_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CassetteId)
                    .HasColumnName("CASSETTE_ID")
                    .HasMaxLength(64);

                entity.Property(e => e.CassetteSlot)
                    .HasColumnName("CASSETTE_SLOT")
                    .HasMaxLength(8);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ModuleId)
                    .HasColumnName("MODULE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OnlineMode)
                    .HasColumnName("ONLINE_MODE")
                    .HasMaxLength(64);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(128);

                entity.Property(e => e.ProcFlow)
                    .HasColumnName("PROC_FLOW")
                    .HasMaxLength(128);

                entity.Property(e => e.Prod)
                    .HasColumnName("PROD")
                    .HasMaxLength(128);

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RECIPE_ID")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<DcpWaferMainInf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DCP_WAFER_MAIN_INF");

                entity.HasIndex(e => new { e.LotId, e.MeasOperId, e.Prod, e.ProcFlow })
                    .HasName("DCP_WAFER_MAIN_INF_IDX01");

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTm)
                    .HasColumnName("END_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainChamberId)
                    .HasColumnName("MAIN_CHAMBER_ID")
                    .HasMaxLength(80);

                entity.Property(e => e.MainChuckId)
                    .HasColumnName("MAIN_CHUCK_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEqpId)
                    .HasColumnName("MAIN_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainHead)
                    .HasColumnName("MAIN_HEAD")
                    .HasMaxLength(40);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(128);

                entity.Property(e => e.MainProcRecipeId)
                    .HasColumnName("MAIN_PROC_RECIPE_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.MainSeqRecipeId)
                    .HasColumnName("MAIN_SEQ_RECIPE_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.MainStepperRecipeId)
                    .HasColumnName("MAIN_STEPPER_RECIPE_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.MainZone)
                    .HasColumnName("MAIN_ZONE")
                    .HasMaxLength(40);

                entity.Property(e => e.MeasEqpId)
                    .HasColumnName("MEAS_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MeasOperId)
                    .HasColumnName("MEAS_OPER_ID")
                    .HasMaxLength(128);

                entity.Property(e => e.ProcFlow)
                    .HasColumnName("PROC_FLOW")
                    .HasMaxLength(128);

                entity.Property(e => e.ProcYn)
                    .HasColumnName("PROC_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Prod)
                    .HasColumnName("PROD")
                    .HasMaxLength(128);

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RECIPE_ID")
                    .HasMaxLength(128);

                entity.Property(e => e.StartTm)
                    .HasColumnName("START_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.WfId)
                    .HasColumnName("WF_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DcpWaferModuleInf>(entity =>
            {
                entity.HasKey(e => new { e.EqpId, e.ModuleId })
                    .HasName("DCP_WAFER_MODULE_INF_IX1");

                entity.ToTable("DCP_WAFER_MODULE_INF");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ModuleId)
                    .HasColumnName("MODULE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MesModuleId)
                    .HasColumnName("MES_MODULE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ModuleDesc)
                    .HasColumnName("MODULE_DESC")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<DcpWafertidHis>(entity =>
            {
                entity.HasKey(e => new { e.Tid, e.TidLink, e.WfId, e.CrtTm, e.DcolDataId })
                    .HasName("DCP_WAFERTID_HIS_PK");

                entity.ToTable("DCP_WAFERTID_HIS");

                entity.HasIndex(e => new { e.Tid, e.TidLink, e.WfId })
                    .HasName("DCP_WAFERTID_HIS_IX01");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasMaxLength(80);

                entity.Property(e => e.TidLink)
                    .HasColumnName("TID_LINK")
                    .HasMaxLength(80);

                entity.Property(e => e.WfId)
                    .HasColumnName("WF_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DcpWfinterlockHis>(entity =>
            {
                entity.HasKey(e => e.Rawid)
                    .HasName("DCP_WFINTERLOCK_HIS_PK");

                entity.ToTable("DCP_WFINTERLOCK_HIS");

                entity.Property(e => e.Rawid)
                    .HasColumnName("RAWID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.EventNm)
                    .HasColumnName("EVENT_NM")
                    .HasMaxLength(50);

                entity.Property(e => e.HoldCnt)
                    .HasColumnName("HOLD_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InWfCnt)
                    .HasColumnName("IN_WF_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IntlockStatVal)
                    .HasColumnName("INTLOCK_STAT_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MaxCnt)
                    .HasColumnName("MAX_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReleaseCnt)
                    .HasColumnName("RELEASE_CNT")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DcpWfinterlockMas>(entity =>
            {
                entity.HasKey(e => e.EqpId)
                    .HasName("DCP_WFINTERLOCK_MAS_PK");

                entity.ToTable("DCP_WFINTERLOCK_MAS");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.HoldCnt)
                    .HasColumnName("HOLD_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReleaseCnt)
                    .HasColumnName("RELEASE_CNT")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<EventHistory>(entity =>
            {
                entity.HasKey(e => new { e.TimeKey, e.EquipmentId, e.EventId })
                    .HasName("EventHistory_PK");

                entity.Property(e => e.TimeKey)
                    .HasMaxLength(21)
                    .IsFixedLength();

                entity.Property(e => e.EquipmentId)
                    .HasColumnName("EquipmentID")
                    .HasMaxLength(50);

                entity.Property(e => e.EventId)
                    .HasColumnName("EventID")
                    .HasMaxLength(50);

                entity.Property(e => e.AliasName).HasMaxLength(50);

                entity.Property(e => e.CarrierId)
                    .HasColumnName("CarrierID")
                    .HasMaxLength(50);

                entity.Property(e => e.ChamberId)
                    .HasColumnName("ChamberID")
                    .HasMaxLength(50);

                entity.Property(e => e.ChamberRecipeId)
                    .HasColumnName("ChamberRecipeID")
                    .HasMaxLength(100);

                entity.Property(e => e.ControlJobId)
                    .HasColumnName("ControlJobID")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasColumnName("CreateUserID")
                    .HasMaxLength(50);

                entity.Property(e => e.LotCode).HasMaxLength(50);

                entity.Property(e => e.LotId)
                    .HasColumnName("LotID")
                    .HasMaxLength(50);

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .HasMaxLength(100);

                entity.Property(e => e.PortId).HasColumnName("PortID");

                entity.Property(e => e.ProcessFlowId)
                    .HasColumnName("ProcessFlowID")
                    .HasMaxLength(100);

                entity.Property(e => e.ProcessJobId)
                    .HasColumnName("ProcessJobID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasMaxLength(100);

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RecipeID")
                    .HasMaxLength(100);

                entity.Property(e => e.SlotId).HasColumnName("SlotID");

                entity.Property(e => e.WaferId)
                    .HasColumnName("WaferID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FxusrProgMas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FXUSR_PROG_MAS");

                entity.Property(e => e.ExecUiPath)
                    .HasColumnName("EXEC_UI_PATH")
                    .HasMaxLength(40);

                entity.Property(e => e.ProgId)
                    .HasColumnName("PROG_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SysId)
                    .HasColumnName("SYS_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<FxusrUserMas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FXUSR_USER_MAS");

                entity.Property(e => e.Deptno)
                    .HasColumnName("DEPTNO")
                    .HasMaxLength(40);

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(40);

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(40);

                entity.Property(e => e.Pw)
                    .HasColumnName("PW")
                    .HasMaxLength(40);

                entity.Property(e => e.Rank).HasMaxLength(40);

                entity.Property(e => e.SysId)
                    .HasColumnName("SYS_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.UserNm)
                    .HasColumnName("USER_NM")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<HesproCopyIoilink>(entity =>
            {
                entity.HasKey(e => e.CreateSeq)
                    .HasName("PK__HESPRO_C__D325C5BA75026003");

                entity.ToTable("HESPRO_COPY_IOILINK");

                entity.HasIndex(e => e.CreateSeq)
                    .HasName("HESPRO_COPY_IOILINK_PK")
                    .IsUnique();

                entity.Property(e => e.CreateSeq)
                    .HasColumnName("CREATE_SEQ_")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME_")
                    .HasColumnType("datetime");

                entity.Property(e => e.Factoryname)
                    .IsRequired()
                    .HasColumnName("FACTORYNAME")
                    .HasMaxLength(40);

                entity.Property(e => e.Ioiactionflag)
                    .HasColumnName("IOIACTIONFLAG_")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lock)
                    .HasColumnName("LOCK_")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Processflowname)
                    .IsRequired()
                    .HasColumnName("PROCESSFLOWNAME")
                    .HasMaxLength(40);

                entity.Property(e => e.Productspecname)
                    .IsRequired()
                    .HasColumnName("PRODUCTSPECNAME")
                    .HasMaxLength(40);

                entity.Property(e => e.Targetprocessflowname)
                    .IsRequired()
                    .HasColumnName("TARGETPROCESSFLOWNAME")
                    .HasMaxLength(40);

                entity.Property(e => e.Targetproductspecname)
                    .IsRequired()
                    .HasColumnName("TARGETPRODUCTSPECNAME")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<HespscIoilink>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HESPSC_IOILINK");

                entity.HasIndex(e => e.CrtSeq)
                    .HasName("HESPSC_IOILINK_IX1")
                    .IsUnique();

                entity.Property(e => e.CrtSeq)
                    .HasColumnName("CRT_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DcspecDesc)
                    .HasColumnName("DCSPEC_DESC")
                    .HasMaxLength(150);

                entity.Property(e => e.DcspecNm)
                    .IsRequired()
                    .HasColumnName("DCSPEC_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.FacNm)
                    .IsRequired()
                    .HasColumnName("FAC_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.Ioiactionflag)
                    .HasColumnName("IOIACTIONFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemDesc)
                    .HasColumnName("ITEM_DESC")
                    .HasMaxLength(150);

                entity.Property(e => e.ItemNm)
                    .IsRequired()
                    .HasColumnName("ITEM_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ItemSeq)
                    .HasColumnName("ITEM_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Lock)
                    .HasColumnName("LOCK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SampCnt)
                    .HasColumnName("SAMP_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SiteCnt)
                    .HasColumnName("SITE_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SpcruleChk)
                    .HasColumnName("SPCRULE_CHK")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<HespscyIoilink>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HESPSCY_IOILINK");

                entity.HasIndex(e => e.CrtSeq)
                    .HasName("HESPSCY_IOILINK_IX1")
                    .IsUnique();

                entity.Property(e => e.CrtSeq)
                    .HasColumnName("CRT_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DrivenFlag)
                    .IsRequired()
                    .HasColumnName("DRIVEN_FLAG")
                    .HasMaxLength(40);

                entity.Property(e => e.Fab)
                    .IsRequired()
                    .HasColumnName("FAB")
                    .HasMaxLength(40);

                entity.Property(e => e.IoiactionFlag)
                    .HasColumnName("IOIACTION_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lcl1)
                    .HasColumnName("LCL1")
                    .HasMaxLength(40);

                entity.Property(e => e.Lcl2)
                    .HasColumnName("LCL2")
                    .HasMaxLength(40);

                entity.Property(e => e.Lcl3)
                    .HasColumnName("LCL3")
                    .HasMaxLength(40);

                entity.Property(e => e.Lcl4)
                    .HasColumnName("LCL4")
                    .HasMaxLength(40);

                entity.Property(e => e.Lcl5)
                    .HasColumnName("LCL5")
                    .HasMaxLength(40);

                entity.Property(e => e.Lock)
                    .HasColumnName("LOCK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lsl)
                    .HasColumnName("LSL")
                    .HasMaxLength(40);

                entity.Property(e => e.ParaId)
                    .IsRequired()
                    .HasColumnName("PARA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ParaSeq)
                    .HasColumnName("PARA_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ParasetId)
                    .IsRequired()
                    .HasColumnName("PARASET_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Tgt)
                    .HasColumnName("TGT")
                    .HasMaxLength(40);

                entity.Property(e => e.Ucl1)
                    .HasColumnName("UCL1")
                    .HasMaxLength(40);

                entity.Property(e => e.Ucl2)
                    .HasColumnName("UCL2")
                    .HasMaxLength(40);

                entity.Property(e => e.Ucl3)
                    .HasColumnName("UCL3")
                    .HasMaxLength(40);

                entity.Property(e => e.Ucl4)
                    .HasColumnName("UCL4")
                    .HasMaxLength(40);

                entity.Property(e => e.Ucl5)
                    .HasColumnName("UCL5")
                    .HasMaxLength(40);

                entity.Property(e => e.Usl)
                    .HasColumnName("USL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<LmsAreaDataMas>(entity =>
            {
                entity.HasKey(e => new { e.Area, e.ColumnNm })
                    .HasName("LMS_AREA_DATA_MAS_PK");

                entity.ToTable("LMS_AREA_DATA_MAS");

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasMaxLength(80);

                entity.Property(e => e.ColumnNm)
                    .HasColumnName("COLUMN_NM")
                    .HasMaxLength(80);

                entity.Property(e => e.BeforeMeas)
                    .HasColumnName("BEFORE_MEAS")
                    .HasMaxLength(1);

                entity.Property(e => e.ColumnOrder)
                    .HasColumnName("COLUMN_ORDER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ColumnTitle1)
                    .HasColumnName("COLUMN_TITLE1")
                    .HasMaxLength(80);

                entity.Property(e => e.ColumnTitle2)
                    .HasColumnName("COLUMN_TITLE2")
                    .HasMaxLength(80);

                entity.Property(e => e.ColumnTitle3)
                    .HasColumnName("COLUMN_TITLE3")
                    .HasMaxLength(80);

                entity.Property(e => e.IsRowSpanYn)
                    .HasColumnName("IS_ROW_SPAN_YN")
                    .HasMaxLength(5);

                entity.Property(e => e.IsVisibleYn)
                    .HasColumnName("IS_VISIBLE_YN")
                    .HasMaxLength(6);

                entity.Property(e => e.Width)
                    .HasColumnName("WIDTH")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<LmsDcoldatarefInf>(entity =>
            {
                entity.HasKey(e => e.DcolDataId)
                    .HasName("LMS_DCOLDATAREF_INF_PK");

                entity.ToTable("LMS_DCOLDATAREF_INF");

                entity.HasIndex(e => new { e.FacId, e.MainEqpId, e.LotId, e.MainFlowId, e.MainOperId, e.ProdId, e.DcolTyp, e.DcolDataId })
                    .HasName("LMS_DCOLDATAREF_INF_IX1");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DcolTyp)
                    .HasColumnName("DCOL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEqpId)
                    .HasColumnName("MAIN_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainFlowId)
                    .HasColumnName("MAIN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<LmsEngrNoteTrx>(entity =>
            {
                entity.HasKey(e => new { e.EqpId, e.CrtDtts })
                    .HasName("LMS_ENGR_NOTE_TRX_IX1");

                entity.ToTable("LMS_ENGR_NOTE_TRX");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtDtts)
                    .HasColumnName("CRT_DTTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ctn).HasColumnName("CTN");
            });

            modelBuilder.Entity<LmsEqpMas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LMS_EQP_MAS");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastJobEndTm)
                    .HasColumnName("LAST_JOB_END_TM")
                    .HasMaxLength(17);

                entity.Property(e => e.LogsheetId)
                    .HasColumnName("LOGSHEET_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MeasPeriod)
                    .HasColumnName("MEAS_PERIOD")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<LmsInformDataTrx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LMS_INFORM_DATA_TRX");

                entity.HasIndex(e => new { e.InformId, e.EqpId, e.CrtTm })
                    .HasName("IX_LMS_INFORM_DATA_TRX_IX1");

                entity.Property(e => e.AreaId)
                    .HasColumnName("AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ctn).HasColumnName("CTN");

                entity.Property(e => e.EqpId)
                    .IsRequired()
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(80);

                entity.Property(e => e.InformId)
                    .HasColumnName("INFORM_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(400);

                entity.Property(e => e.UserNm)
                    .HasColumnName("USER_NM")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<LmsLotInformDataHis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LMS_LOT_INFORM_DATA_HIS");

                entity.HasIndex(e => new { e.DcolDataId, e.CrtTm })
                    .HasName("IX_LMS_LOT_INFORM_DATA_HIS_IX2");

                entity.HasIndex(e => new { e.LotInformId, e.DcolDataId, e.CrtTm })
                    .HasName("IX_LMS_LOT_INFORM_DATA_HIS_IX1");

                entity.Property(e => e.AbnormalMeasYn)
                    .HasColumnName("ABNORMAL_MEAS_YN")
                    .HasMaxLength(4);

                entity.Property(e => e.BatchCnt)
                    .HasColumnName("BATCH_CNT")
                    .HasMaxLength(80);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DcolDataId)
                    .HasColumnName("DCOL_DATA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LotInformId)
                    .HasColumnName("LOT_INFORM_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MeasCnt1)
                    .HasColumnName("MEAS_CNT1")
                    .HasMaxLength(32);

                entity.Property(e => e.MeasCnt2)
                    .HasColumnName("MEAS_CNT2")
                    .HasMaxLength(32);

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<LmsLotTrx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LMS_LOT_TRX");

                entity.HasIndex(e => new { e.EqpId, e.CrtDtts })
                    .HasName("IX_LMS_LOT_TRX_IX2");

                entity.HasIndex(e => new { e.EqpId, e.LatestEventNm, e.JobEndDtts })
                    .HasName("IX_LMS_LOT_TRX_IX5");

                entity.HasIndex(e => new { e.Rawid, e.EqpId, e.CrtDtts })
                    .HasName("IX_LMS_LOT_TRX_IX1");

                entity.HasIndex(e => new { e.LotId, e.EqpId, e.Oper, e.Prod })
                    .HasName("IX_LMS_LOT_TRX_IX3");

                entity.HasIndex(e => new { e.Rawid, e.EqpId, e.LotId, e.CrtDtts })
                    .HasName("IX_LMS_LOT_TRX_IX4");

                entity.Property(e => e.AutoMove)
                    .HasColumnName("AUTO_MOVE")
                    .HasMaxLength(4);

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasMaxLength(32);

                entity.Property(e => e.BatchZone)
                    .HasColumnName("BATCH_ZONE")
                    .HasMaxLength(4);

                entity.Property(e => e.ChId)
                    .HasColumnName("CH_ID")
                    .HasMaxLength(320);

                entity.Property(e => e.CrtDtts)
                    .HasColumnName("CRT_DTTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.EqpId)
                    .IsRequired()
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpIdTemp)
                    .HasColumnName("EQP_ID_TEMP")
                    .HasMaxLength(64);

                entity.Property(e => e.FoupId)
                    .HasColumnName("FOUP_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.IdleTm)
                    .HasColumnName("IDLE_TM")
                    .HasMaxLength(8);

                entity.Property(e => e.InMoveTm)
                    .HasColumnName("IN_MOVE_TM")
                    .HasMaxLength(8);

                entity.Property(e => e.InQty)
                    .HasColumnName("IN_QTY")
                    .HasMaxLength(4);

                entity.Property(e => e.JobEndDtts)
                    .HasColumnName("JOB_END_DTTS")
                    .HasMaxLength(17);

                entity.Property(e => e.JobStartDtts)
                    .HasColumnName("JOB_START_DTTS")
                    .HasMaxLength(17);

                entity.Property(e => e.LatestEventNm)
                    .HasColumnName("LATEST_EVENT_NM")
                    .HasMaxLength(32);

                entity.Property(e => e.LoadDtts)
                    .HasColumnName("LOAD_DTTS")
                    .HasMaxLength(17);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotTyp)
                    .HasColumnName("LOT_TYP")
                    .HasMaxLength(16);

                entity.Property(e => e.MoveInUser)
                    .HasColumnName("MOVE_IN_USER")
                    .HasMaxLength(16);

                entity.Property(e => e.MoveOutUser)
                    .HasColumnName("MOVE_OUT_USER")
                    .HasMaxLength(16);

                entity.Property(e => e.OhtMode)
                    .HasColumnName("OHT_MODE")
                    .HasMaxLength(4);

                entity.Property(e => e.Oper)
                    .HasColumnName("OPER")
                    .HasMaxLength(16);

                entity.Property(e => e.OperDesc)
                    .HasColumnName("OPER_DESC")
                    .HasMaxLength(80);

                entity.Property(e => e.OutMoveTm)
                    .HasColumnName("OUT_MOVE_TM")
                    .HasMaxLength(8);

                entity.Property(e => e.OutQty)
                    .HasColumnName("OUT_QTY")
                    .HasMaxLength(4);

                entity.Property(e => e.PitchTm)
                    .HasColumnName("PITCH_TM")
                    .HasMaxLength(8);

                entity.Property(e => e.PortNm)
                    .HasColumnName("PORT_NM")
                    .HasMaxLength(10);

                entity.Property(e => e.ProcFlow)
                    .HasColumnName("PROC_FLOW")
                    .HasMaxLength(80);

                entity.Property(e => e.ProcR2r)
                    .HasColumnName("PROC_R2R")
                    .HasMaxLength(4);

                entity.Property(e => e.ProcTm)
                    .HasColumnName("PROC_TM")
                    .HasMaxLength(8);

                entity.Property(e => e.Prod)
                    .HasColumnName("PROD")
                    .HasMaxLength(80);

                entity.Property(e => e.Rawid)
                    .HasColumnName("RAWID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Recipe)
                    .HasColumnName("RECIPE")
                    .HasMaxLength(160);

                entity.Property(e => e.ReticleNm)
                    .HasColumnName("RETICLE_NM")
                    .HasMaxLength(160);

                entity.Property(e => e.StepperRecipe)
                    .HasColumnName("STEPPER_RECIPE")
                    .HasMaxLength(160);

                entity.Property(e => e.UnloadDtts)
                    .HasColumnName("UNLOAD_DTTS")
                    .HasMaxLength(17);
            });

            modelBuilder.Entity<LmsMachineTrx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LMS_MACHINE_TRX");

                entity.HasIndex(e => new { e.EqpId, e.StartDtts, e.EndDtts })
                    .HasName("IX_LMS_MACHINE_TRX_IX1");

                entity.HasIndex(e => new { e.Rawid, e.EqpId, e.CrtDtts })
                    .HasName("IU_LMS_MACHINE_TRX_IX1")
                    .IsUnique();

                entity.Property(e => e.ChId)
                    .HasColumnName("CH_ID")
                    .HasMaxLength(80);

                entity.Property(e => e.CrtDtts)
                    .HasColumnName("CRT_DTTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDtts)
                    .HasColumnName("END_DTTS")
                    .HasMaxLength(17);

                entity.Property(e => e.EndEvent)
                    .HasColumnName("END_EVENT")
                    .HasMaxLength(32);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpStat)
                    .HasColumnName("EQP_STAT")
                    .HasMaxLength(32);

                entity.Property(e => e.EventNm)
                    .HasColumnName("EVENT_NM")
                    .HasMaxLength(32);

                entity.Property(e => e.EventText)
                    .HasColumnName("EVENT_TEXT")
                    .HasMaxLength(400);

                entity.Property(e => e.Rawid)
                    .HasColumnName("RAWID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StartDtts)
                    .HasColumnName("START_DTTS")
                    .HasMaxLength(17);

                entity.Property(e => e.StartEvent)
                    .HasColumnName("START_EVENT")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<LmsNoticeMas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LMS_NOTICE_MAS");

                entity.HasIndex(e => new { e.EqpId, e.FromTm, e.ToTm })
                    .HasName("IX_LMS_NOTICE_MAS_IX1");

                entity.Property(e => e.AreaId)
                    .HasColumnName("AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Contents)
                    .HasColumnName("CONTENTS")
                    .HasMaxLength(400);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EqpId)
                    .IsRequired()
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FromTm)
                    .IsRequired()
                    .HasColumnName("FROM_TM")
                    .HasMaxLength(17);

                entity.Property(e => e.NoticeId)
                    .HasColumnName("NOTICE_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ToTm)
                    .IsRequired()
                    .HasColumnName("TO_TM")
                    .HasMaxLength(17);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<LmsParamMas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LMS_PARAM_MAS");

                entity.HasIndex(e => new { e.ParaId, e.CrtTm })
                    .HasName("IX_LMS_PARAM_MAS_IX1");

                entity.Property(e => e.ColumnOrder)
                    .HasColumnName("COLUMN_ORDER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataCatg)
                    .HasColumnName("DATA_CATG")
                    .HasMaxLength(8);

                entity.Property(e => e.DataFormat)
                    .HasColumnName("DATA_FORMAT")
                    .HasMaxLength(16);

                entity.Property(e => e.DecimalPoint)
                    .HasColumnName("DECIMAL_POINT")
                    .HasMaxLength(32);

                entity.Property(e => e.LogsheetId)
                    .HasColumnName("LOGSHEET_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MeasureCheck1)
                    .HasColumnName("MEASURE_CHECK1")
                    .HasMaxLength(4);

                entity.Property(e => e.MeasureCheck2)
                    .HasColumnName("MEASURE_CHECK2")
                    .HasMaxLength(5);

                entity.Property(e => e.MeasureCheck3)
                    .HasColumnName("MEASURE_CHECK3")
                    .HasMaxLength(6);

                entity.Property(e => e.Nm1st)
                    .HasColumnName("NM_1ST")
                    .HasMaxLength(160);

                entity.Property(e => e.Nm2nd)
                    .HasColumnName("NM_2ND")
                    .HasMaxLength(160);

                entity.Property(e => e.Nm3rd)
                    .HasColumnName("NM_3RD")
                    .HasMaxLength(160);

                entity.Property(e => e.ParaId)
                    .HasColumnName("PARA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ParaNm)
                    .HasColumnName("PARA_NM")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<LmsPreMeasMas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LMS_PRE_MEAS_MAS");

                entity.HasIndex(e => new { e.PreMeasId, e.MainOper, e.PreOper })
                    .HasName("IX_LMS_PRE_MEAS_MAS_IX1");

                entity.Property(e => e.MainOper)
                    .HasColumnName("MAIN_OPER")
                    .HasMaxLength(80);

                entity.Property(e => e.MainOperDesc)
                    .HasColumnName("MAIN_OPER_DESC")
                    .HasMaxLength(160);

                entity.Property(e => e.PreMeasId)
                    .HasColumnName("PRE_MEAS_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PreOper)
                    .HasColumnName("PRE_OPER")
                    .HasMaxLength(80);

                entity.Property(e => e.PreOperDesc)
                    .HasColumnName("PRE_OPER_DESC")
                    .HasMaxLength(160);
            });

            modelBuilder.Entity<LmsProcessMas>(entity =>
            {
                entity.HasKey(e => new { e.Fab, e.SysId, e.ProcessId, e.Ip, e.Port })
                    .HasName("LMS_PROCESS_MAS_IX01");

                entity.ToTable("LMS_PROCESS_MAS");

                entity.Property(e => e.Fab)
                    .HasColumnName("FAB")
                    .HasMaxLength(10);

                entity.Property(e => e.SysId)
                    .HasColumnName("SYS_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.ProcessId)
                    .HasColumnName("PROCESS_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(40);

                entity.Property(e => e.Port)
                    .HasColumnName("PORT")
                    .HasMaxLength(10);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUser)
                    .HasColumnName("CHG_USER")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUser)
                    .HasColumnName("CRT_USER")
                    .HasMaxLength(40);

                entity.Property(e => e.LogPath)
                    .HasColumnName("LOG_PATH")
                    .HasMaxLength(1024);

                entity.Property(e => e.SysVerp)
                    .HasColumnName("SYS_VERP")
                    .HasMaxLength(40);

                entity.Property(e => e.UiPort)
                    .HasColumnName("UI_PORT")
                    .HasMaxLength(40);

                entity.Property(e => e.UseTyp)
                    .HasColumnName("USE_TYP")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<LmsRecipeParamMas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LMS_RECIPE_PARAM_MAS");

                entity.HasIndex(e => new { e.EqpId, e.Recipe, e.LogsheetId })
                    .HasName("IX_LMS_RECIPE_PARAM_MAS_IX");

                entity.Property(e => e.AreaId)
                    .HasColumnName("AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LogsheetId)
                    .HasColumnName("LOGSHEET_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ParaNm)
                    .HasColumnName("PARA_NM")
                    .HasMaxLength(80);

                entity.Property(e => e.Recipe)
                    .HasColumnName("RECIPE")
                    .HasMaxLength(160);

                entity.Property(e => e.RecipeParaId)
                    .HasColumnName("RECIPE_PARA_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(80);

                entity.Property(e => e.VirtualParaNm)
                    .HasColumnName("VIRTUAL_PARA_NM")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<LmsSheetMas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LMS_SHEET_MAS");

                entity.HasIndex(e => e.LogsheetId)
                    .HasName("IX_LMS_SHEET_MAS_IX1");

                entity.Property(e => e.LogsheetDesc)
                    .HasColumnName("LOGSHEET_DESC")
                    .HasMaxLength(1024);

                entity.Property(e => e.LogsheetId)
                    .HasColumnName("LOGSHEET_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LogsheetNm)
                    .IsRequired()
                    .HasColumnName("LOGSHEET_NM")
                    .HasMaxLength(160);
            });

            modelBuilder.Entity<MesCommontypDetMv>(entity =>
            {
                entity.HasKey(e => new { e.CommonTyp, e.TypVal })
                    .HasName("MES_COMMONTYP_DET_PK");

                entity.ToTable("MES_COMMONTYP_DET_MV");

                entity.Property(e => e.CommonTyp)
                    .HasColumnName("COMMON_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.TypVal)
                    .HasColumnName("TYP_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DefaultYn)
                    .HasColumnName("DEFAULT_YN")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<MesCommontypMasMv>(entity =>
            {
                entity.HasKey(e => e.CommonTyp)
                    .HasName("MES_COMMONTYP_MAS_PK");

                entity.ToTable("MES_COMMONTYP_MAS_MV");

                entity.Property(e => e.CommonTyp)
                    .HasColumnName("COMMON_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.AcssType)
                    .HasColumnName("ACSS_TYPE")
                    .HasMaxLength(40);

                entity.Property(e => e.ConstYn)
                    .HasColumnName("CONST_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.UsageCd)
                    .HasColumnName("USAGE_CD")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<MesDurableMasMv>(entity =>
            {
                entity.HasKey(e => e.DurableId)
                    .HasName("MES_DURABLE_MAS_PK");

                entity.ToTable("MES_DURABLE_MAS_MV");

                entity.Property(e => e.DurableId)
                    .HasColumnName("DURABLE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AftCleanUseDur).HasColumnName("AFT_CLEAN_USE_DUR");

                entity.Property(e => e.AftCleanUseDurLimitVal)
                    .HasColumnName("AFT_CLEAN_USE_DUR_LIMIT_VAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.AftCleanUseNumcnt).HasColumnName("AFT_CLEAN_USE_NUMCNT");

                entity.Property(e => e.AftCleanUseNumcntLimitVal).HasColumnName("AFT_CLEAN_USE_NUMCNT_LIMIT_VAL");

                entity.Property(e => e.AreaId)
                    .HasColumnName("AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.BatchSeq)
                    .HasColumnName("BATCH_SEQ")
                    .HasMaxLength(40);

                entity.Property(e => e.Capa)
                    .HasColumnName("CAPA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CarrierCatgCd)
                    .HasColumnName("CARRIER_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CarrierColorCd)
                    .HasColumnName("CARRIER_COLOR_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CarrierId)
                    .HasColumnName("CARRIER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CidVerifyRsltVal)
                    .HasColumnName("CID_VERIFY_RSLT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.CleanNumcnt).HasColumnName("CLEAN_NUMCNT");

                entity.Property(e => e.CleanNumcntLimitVal).HasColumnName("CLEAN_NUMCNT_LIMIT_VAL");

                entity.Property(e => e.CleanTyp)
                    .HasColumnName("CLEAN_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ConfDesc1)
                    .HasColumnName("CONF_DESC_1")
                    .HasMaxLength(512);

                entity.Property(e => e.ConfDesc2)
                    .HasColumnName("CONF_DESC_2")
                    .HasMaxLength(512);

                entity.Property(e => e.ConfDesc3)
                    .HasColumnName("CONF_DESC_3")
                    .HasMaxLength(512);

                entity.Property(e => e.ConfDesc4)
                    .HasColumnName("CONF_DESC_4")
                    .HasMaxLength(512);

                entity.Property(e => e.ConfEngrUserId1)
                    .HasColumnName("CONF_ENGR_USER_ID_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ConfEngrUserId2)
                    .HasColumnName("CONF_ENGR_USER_ID_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ConfEngrUserId3)
                    .HasColumnName("CONF_ENGR_USER_ID_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ConfEngrUserId4)
                    .HasColumnName("CONF_ENGR_USER_ID_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ConfYn)
                    .HasColumnName("CONF_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DiscardTm)
                    .HasColumnName("DISCARD_TM")
                    .HasMaxLength(40);

                entity.Property(e => e.DoorId)
                    .HasColumnName("DOOR_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DurableCatgCd)
                    .HasColumnName("DURABLE_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DurableCleanStatCd)
                    .HasColumnName("DURABLE_CLEAN_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DurableEventDesc)
                    .HasColumnName("DURABLE_EVENT_DESC")
                    .HasMaxLength(255);

                entity.Property(e => e.DurableGrpId)
                    .HasColumnName("DURABLE_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DurableGrpVer)
                    .HasColumnName("DURABLE_GRP_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.DurableStatCd)
                    .HasColumnName("DURABLE_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DurableTyp)
                    .HasColumnName("DURABLE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EmcBayNm)
                    .HasColumnName("EMC_BAY_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.EmcEqpGrpId)
                    .HasColumnName("EMC_EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EmcEqpId)
                    .HasColumnName("EMC_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FamilyCd)
                    .HasColumnName("FAMILY_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FrFabId)
                    .HasColumnName("FR_FAB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.GoalEqpId)
                    .HasColumnName("GOAL_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.GoalPortNm)
                    .HasColumnName("GOAL_PORT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.GoalStkId)
                    .HasColumnName("GOAL_STK_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.InspNumcnt)
                    .HasColumnName("INSP_NUMCNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IrisStatTyp)
                    .HasColumnName("IRIS_STAT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.LastCleanTm)
                    .HasColumnName("LAST_CLEAN_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastEventCd)
                    .HasColumnName("LAST_EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventDesc)
                    .HasColumnName("LAST_EVENT_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.LastEventTimekey)
                    .HasColumnName("LAST_EVENT_TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventTm)
                    .HasColumnName("LAST_EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastEventTyp)
                    .HasColumnName("LAST_EVENT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventUserId)
                    .HasColumnName("LAST_EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastIrisActivaTm)
                    .HasColumnName("LAST_IRIS_ACTIVA_TM")
                    .HasMaxLength(40);

                entity.Property(e => e.LastLotBatchId)
                    .HasColumnName("LAST_LOT_BATCH_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LocNm)
                    .HasColumnName("LOC_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LotQty)
                    .HasColumnName("LOT_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MatlLocCd)
                    .HasColumnName("MATL_LOC_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MatlTyp)
                    .HasColumnName("MATL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MesProcStatCd)
                    .HasColumnName("MES_PROC_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MesStatTyp)
                    .HasColumnName("MES_STAT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MonMoveoutTimekey)
                    .HasColumnName("MON_MOVEOUT_TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveStatCd)
                    .HasColumnName("MOVE_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ObjId)
                    .HasColumnName("OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OrgFabId)
                    .HasColumnName("ORG_FAB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PortNm)
                    .HasColumnName("PORT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonCatgCd)
                    .HasColumnName("REASON_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonCd)
                    .HasColumnName("REASON_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.RecycNumcnt)
                    .HasColumnName("RECYC_NUMCNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RecycNumcntLimitVal)
                    .HasColumnName("RECYC_NUMCNT_LIMIT_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RefLotId)
                    .HasColumnName("REF_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RepairNumcnt)
                    .HasColumnName("REPAIR_NUMCNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ResvFieldVal1)
                    .HasColumnName("RESV_FIELD_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal2)
                    .HasColumnName("RESV_FIELD_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal3)
                    .HasColumnName("RESV_FIELD_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal4)
                    .HasColumnName("RESV_FIELD_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal5)
                    .HasColumnName("RESV_FIELD_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleParticleCnt1)
                    .HasColumnName("RETICLE_PARTICLE_CNT_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleParticleCnt2)
                    .HasColumnName("RETICLE_PARTICLE_CNT_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleTyp)
                    .HasColumnName("RETICLE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.Rfid)
                    .HasColumnName("RFID")
                    .HasMaxLength(40);

                entity.Property(e => e.SlotMapEqpId)
                    .HasColumnName("SLOT_MAP_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SorterId)
                    .HasColumnName("SORTER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SorterJobId)
                    .HasColumnName("SORTER_JOB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.StampId)
                    .HasColumnName("STAMP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.StkKeepTm)
                    .HasColumnName("STK_KEEP_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubCatgCd)
                    .HasColumnName("SUB_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.TransGrpId)
                    .HasColumnName("TRANS_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.UnloadPortNm)
                    .HasColumnName("UNLOAD_PORT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.UseCnt)
                    .HasColumnName("USE_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UseDur).HasColumnName("USE_DUR");

                entity.Property(e => e.UseDurLimitVal).HasColumnName("USE_DUR_LIMIT_VAL");

                entity.Property(e => e.UseLimitVal)
                    .HasColumnName("USE_LIMIT_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UseNumcnt).HasColumnName("USE_NUMCNT");

                entity.Property(e => e.UseNumcntLimitVal).HasColumnName("USE_NUMCNT_LIMIT_VAL");

                entity.Property(e => e.VendorId)
                    .HasColumnName("VENDOR_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.WfLoadStatCd)
                    .HasColumnName("WF_LOAD_STAT_CD")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<MesEqpMasMv>(entity =>
            {
                entity.HasKey(e => e.EqpId)
                    .HasName("MES_EQP_MAS_MV_PK");

                entity.ToTable("MES_EQP_MAS_MV");

                entity.HasIndex(e => e.UpperEqpId)
                    .HasName("MES_EQP_MAS_IX1")
                    .IsUnique();

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AreaId)
                    .HasColumnName("AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoR2rYn)
                    .HasColumnName("AUTO_R2R_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.BatchLoadRuleTyp)
                    .HasColumnName("BATCH_LOAD_RULE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.BatchSeqRuleTyp)
                    .HasColumnName("BATCH_SEQ_RULE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.BayNm)
                    .HasColumnName("BAY_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.BuildingNm)
                    .HasColumnName("BUILDING_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.CertTyp)
                    .HasColumnName("CERT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkRecipeYn)
                    .HasColumnName("CHK_RECIPE_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.ChuckDedicYn)
                    .HasColumnName("CHUCK_DEDIC_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.ContamYn)
                    .HasColumnName("CONTAM_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtMonLotYn)
                    .HasColumnName("CRT_MON_LOT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.CuYn)
                    .HasColumnName("CU_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.DailyMaxCapa)
                    .HasColumnName("DAILY_MAX_CAPA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DcolIntlockYn)
                    .HasColumnName("DCOL_INTLOCK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.DefaultEapNm)
                    .HasColumnName("DEFAULT_EAP_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.DefaultRecipeNspaceCd)
                    .HasColumnName("DEFAULT_RECIPE_NSPACE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DefaultStkId)
                    .HasColumnName("DEFAULT_STK_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DefaultStkPortNm)
                    .HasColumnName("DEFAULT_STK_PORT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.DefaultUtsNm)
                    .HasColumnName("DEFAULT_UTS_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.DetEqpTyp)
                    .HasColumnName("DET_EQP_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DspRuleTyp)
                    .HasColumnName("DSP_RULE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EapEqpModelCd)
                    .HasColumnName("EAP_EQP_MODEL_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EnableBuffMinSize)
                    .HasColumnName("ENABLE_BUFF_MIN_SIZE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EnableBuffSize)
                    .HasColumnName("ENABLE_BUFF_SIZE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EnablePrcsYn)
                    .HasColumnName("ENABLE_PRCS_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpId)
                    .HasColumnName("EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpModelCd)
                    .HasColumnName("EQP_MODEL_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpOperGrpCd)
                    .HasColumnName("EQP_OPER_GRP_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpStatModelCd)
                    .HasColumnName("EQP_STAT_MODEL_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpTyp)
                    .HasColumnName("EQP_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpVer)
                    .HasColumnName("EQP_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.EqvMstCd)
                    .HasColumnName("EQV_MST_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FdcEqpGrpId)
                    .HasColumnName("FDC_EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FdcIngotYn)
                    .HasColumnName("FDC_INGOT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.FdcMainGrpNm)
                    .HasColumnName("FDC_MAIN_GRP_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.FdcTgtYn)
                    .HasColumnName("FDC_TGT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.FloorNm)
                    .HasColumnName("FLOOR_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.JobPrepCapa)
                    .HasColumnName("JOB_PREP_CAPA")
                    .HasMaxLength(40);

                entity.Property(e => e.JobPrepEesMsgTyp)
                    .HasColumnName("JOB_PREP_EES_MSG_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.JobPrepTyp)
                    .HasColumnName("JOB_PREP_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.LoadCapa)
                    .HasColumnName("LOAD_CAPA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LogicalChambId)
                    .HasColumnName("LOGICAL_CHAMB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotBatchMaxSize)
                    .HasColumnName("LOT_BATCH_MAX_SIZE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LotBatchMinSize)
                    .HasColumnName("LOT_BATCH_MIN_SIZE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.McsItgYn)
                    .HasColumnName("MCS_ITG_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.MetalTyp)
                    .HasColumnName("METAL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MetalYn)
                    .HasColumnName("METAL_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.MgmtAreaId)
                    .HasColumnName("MGMT_AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ModelTyp)
                    .HasColumnName("MODEL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MsResvAttrVal1)
                    .HasColumnName("MS_RESV_ATTR_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.MsResvAttrVal10)
                    .HasColumnName("MS_RESV_ATTR_VAL_10")
                    .HasMaxLength(40);

                entity.Property(e => e.MsResvAttrVal2)
                    .HasColumnName("MS_RESV_ATTR_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.MsResvAttrVal3)
                    .HasColumnName("MS_RESV_ATTR_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.MsResvAttrVal4)
                    .HasColumnName("MS_RESV_ATTR_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.MsResvAttrVal5)
                    .HasColumnName("MS_RESV_ATTR_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.MsResvAttrVal6)
                    .HasColumnName("MS_RESV_ATTR_VAL_6")
                    .HasMaxLength(40);

                entity.Property(e => e.MsResvAttrVal7)
                    .HasColumnName("MS_RESV_ATTR_VAL_7")
                    .HasMaxLength(40);

                entity.Property(e => e.MsResvAttrVal8)
                    .HasColumnName("MS_RESV_ATTR_VAL_8")
                    .HasMaxLength(40);

                entity.Property(e => e.MsResvAttrVal9)
                    .HasColumnName("MS_RESV_ATTR_VAL_9")
                    .HasMaxLength(40);

                entity.Property(e => e.MtjYn)
                    .HasColumnName("MTJ_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.MultiRackYn)
                    .HasColumnName("MULTI_RACK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.MultiRecipeYn)
                    .HasColumnName("MULTI_RECIPE_YN")
                    .HasMaxLength(6);

                entity.Property(e => e.NextRuleWhereCd1)
                    .HasColumnName("NEXT_RULE_WHERE_CD_1")
                    .HasMaxLength(40);

                entity.Property(e => e.NextRuleWhereCd2)
                    .HasColumnName("NEXT_RULE_WHERE_CD_2")
                    .HasMaxLength(40);

                entity.Property(e => e.NextRuleWhereCd3)
                    .HasColumnName("NEXT_RULE_WHERE_CD_3")
                    .HasMaxLength(40);

                entity.Property(e => e.NonClickYn)
                    .HasColumnName("NON_CLICK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.NonNoResvYn)
                    .HasColumnName("NON_NO_RESV_YN")
                    .HasMaxLength(6);

                entity.Property(e => e.ObjId)
                    .HasColumnName("OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OnlineTgtTyp)
                    .HasColumnName("ONLINE_TGT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.OperRuleDesc)
                    .HasColumnName("OPER_RULE_DESC")
                    .HasMaxLength(125);

                entity.Property(e => e.OwnerNm)
                    .HasColumnName("OWNER_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.PadBreakInIntlockCd)
                    .HasColumnName("PAD_BREAK_IN_INTLOCK_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.Photo1ClickYn)
                    .HasColumnName("PHOTO_1_CLICK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.PjRuleVal)
                    .HasColumnName("PJ_RULE_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.PpmIngotYn)
                    .HasColumnName("PPM_INGOT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.PreArranSupplyOptVal)
                    .HasColumnName("PRE_ARRAN_SUPPLY_OPT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.ProcCapa)
                    .HasColumnName("PROC_CAPA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProcUnitCd)
                    .HasColumnName("PROC_UNIT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.QTmChkYn)
                    .HasColumnName("Q_TM_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.QTmIntval)
                    .HasColumnName("Q_TM_INTVAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.R2rItgYn)
                    .HasColumnName("R2R_ITG_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.RecipeParaChkYn)
                    .HasColumnName("RECIPE_PARA_CHK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcDedicTyp)
                    .HasColumnName("RESRC_DEDIC_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcGrpNm)
                    .HasColumnName("RESRC_GRP_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcTyp)
                    .HasColumnName("RESRC_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal1)
                    .HasColumnName("RESV_FIELD_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleChgIntlockCd)
                    .HasColumnName("RETICLE_CHG_INTLOCK_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.RetransmitPortNm)
                    .HasColumnName("RETRANSMIT_PORT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.RmsItgYn)
                    .HasColumnName("RMS_ITG_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.RootAreaId)
                    .HasColumnName("ROOT_AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RootEqpId)
                    .HasColumnName("ROOT_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RootObjId)
                    .HasColumnName("ROOT_OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RtdItgYn)
                    .HasColumnName("RTD_ITG_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.SdptNm)
                    .HasColumnName("SDPT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.SerialNo)
                    .HasColumnName("SERIAL_NO")
                    .HasMaxLength(40);

                entity.Property(e => e.ShiftIntlockRuleCd)
                    .HasColumnName("SHIFT_INTLOCK_RULE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SiteCd)
                    .HasColumnName("SITE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SopItgYn)
                    .HasColumnName("SOP_ITG_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.SorterItgYn)
                    .HasColumnName("SORTER_ITG_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcTgtYn)
                    .HasColumnName("SPC_TGT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.SpcYn)
                    .HasColumnName("SPC_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.SpecialEqpTyp)
                    .HasColumnName("SPECIAL_EQP_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.StartQueueTyp)
                    .HasColumnName("START_QUEUE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.StructTyp)
                    .HasColumnName("STRUCT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.SubEqpTyp)
                    .HasColumnName("SUB_EQP_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.TibSubjNm)
                    .HasColumnName("TIB_SUBJ_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.TrackTyp)
                    .HasColumnName("TRACK_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.TransferTyp)
                    .HasColumnName("TRANSFER_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.UpperEqpId)
                    .HasColumnName("UPPER_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.UseWhereNextYn1)
                    .HasColumnName("USE_WHERE_NEXT_YN_1")
                    .HasMaxLength(40);

                entity.Property(e => e.UseWhereNextYn2)
                    .HasColumnName("USE_WHERE_NEXT_YN_2")
                    .HasMaxLength(40);

                entity.Property(e => e.UseWhereNextYn3)
                    .HasColumnName("USE_WHERE_NEXT_YN_3")
                    .HasMaxLength(40);

                entity.Property(e => e.VendorNm)
                    .HasColumnName("VENDOR_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ZoneNm)
                    .HasColumnName("ZONE_NM")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<MesEqpmasExtMv>(entity =>
            {
                entity.HasKey(e => e.EqpId)
                    .HasName("MES_EQPMAS_EXT_PK");

                entity.ToTable("MES_EQPMAS_EXT_MV");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AreaId)
                    .HasColumnName("AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CarrierQty)
                    .HasColumnName("CARRIER_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ChambEndTm)
                    .HasColumnName("CHAMB_END_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CommStatTyp)
                    .HasColumnName("COMM_STAT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DetEventCd)
                    .HasColumnName("DET_EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DeviceStatCtn)
                    .HasColumnName("DEVICE_STAT_CTN")
                    .HasMaxLength(40);

                entity.Property(e => e.DownCd)
                    .HasColumnName("DOWN_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.DownStatTyp)
                    .HasColumnName("DOWN_STAT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.E10StatTyp)
                    .HasColumnName("E_10_STAT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EmptyLocCnt)
                    .HasColumnName("EMPTY_LOC_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EqpAddDesc)
                    .HasColumnName("EQP_ADD_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpAutoTyp)
                    .HasColumnName("EQP_AUTO_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpEventId)
                    .HasColumnName("EQP_EVENT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpId)
                    .HasColumnName("EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpStatCd)
                    .HasColumnName("EQP_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FdcAlarmYn)
                    .HasColumnName("FDC_ALARM_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.FdcChambId)
                    .HasColumnName("FDC_CHAMB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.IdleStartTm)
                    .HasColumnName("IDLE_START_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntlockShiftCd)
                    .HasColumnName("INTLOCK_SHIFT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventCd)
                    .HasColumnName("LAST_EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventDesc)
                    .HasColumnName("LAST_EVENT_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.LastEventTimekey)
                    .HasColumnName("LAST_EVENT_TIMEKEY")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastEventTm)
                    .HasColumnName("LAST_EVENT_TM")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventTyp)
                    .HasColumnName("LAST_EVENT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventUserId)
                    .HasColumnName("LAST_EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastFlowId)
                    .HasColumnName("LAST_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastMoveoutLotId)
                    .HasColumnName("LAST_MOVEOUT_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastOperId)
                    .HasColumnName("LAST_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastProdId)
                    .HasColumnName("LAST_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastProdRecipeId)
                    .HasColumnName("LAST_PROD_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastRecipeId)
                    .HasColumnName("LAST_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastStartTm)
                    .HasColumnName("LAST_START_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxCapa)
                    .HasColumnName("MAX_CAPA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.McsItgYn)
                    .HasColumnName("MCS_ITG_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.MesEqpStatCd)
                    .HasColumnName("MES_EQP_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MesEventCd)
                    .HasColumnName("MES_EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MesStatTyp)
                    .HasColumnName("MES_STAT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.NonClickYn)
                    .HasColumnName("NON_CLICK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.ObjId)
                    .HasColumnName("OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PadBreakInNpwLotId)
                    .HasColumnName("PAD_BREAK_IN_NPW_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PmsYn)
                    .HasColumnName("PMS_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.PortAcssTyp)
                    .HasColumnName("PORT_ACSS_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.PpmAlarmYn)
                    .HasColumnName("PPM_ALARM_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.ProcChgCumCnt)
                    .HasColumnName("PROC_CHG_CUM_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProcChgLotCnt)
                    .HasColumnName("PROC_CHG_LOT_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProcCnt)
                    .HasColumnName("PROC_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReasonCatgCd)
                    .HasColumnName("REASON_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonCd)
                    .HasColumnName("REASON_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ResrcStatTyp)
                    .HasColumnName("RESRC_STAT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvAttrVal1)
                    .HasColumnName("RESV_ATTR_VAL_1")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal10)
                    .HasColumnName("RESV_ATTR_VAL_10")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal2)
                    .HasColumnName("RESV_ATTR_VAL_2")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal3)
                    .HasColumnName("RESV_ATTR_VAL_3")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal4)
                    .HasColumnName("RESV_ATTR_VAL_4")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal5)
                    .HasColumnName("RESV_ATTR_VAL_5")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal6)
                    .HasColumnName("RESV_ATTR_VAL_6")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal7)
                    .HasColumnName("RESV_ATTR_VAL_7")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal8)
                    .HasColumnName("RESV_ATTR_VAL_8")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal9)
                    .HasColumnName("RESV_ATTR_VAL_9")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvEventCd)
                    .HasColumnName("RESV_EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvEventDesc)
                    .HasColumnName("RESV_EVENT_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvEventStatCd)
                    .HasColumnName("RESV_EVENT_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvEventTm)
                    .HasColumnName("RESV_EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResvEventUserId)
                    .HasColumnName("RESV_EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal2)
                    .HasColumnName("RESV_FIELD_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal3)
                    .HasColumnName("RESV_FIELD_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal4)
                    .HasColumnName("RESV_FIELD_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal5)
                    .HasColumnName("RESV_FIELD_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvLocCnt)
                    .HasColumnName("RESV_LOC_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReticleId)
                    .HasColumnName("RETICLE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.UpdownStartTm)
                    .HasColumnName("UPDOWN_START_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpperEqpId)
                    .HasColumnName("UPPER_EQP_ID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<MesFlowMasMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.FlowId, e.FlowVer })
                    .HasName("MES_FLOW_MAS_PK");

                entity.ToTable("MES_FLOW_MAS_MV");

                entity.HasIndex(e => new { e.FacId, e.MainProdId })
                    .HasName("MES_FLOW_MAS_MV_IX1");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ActiveStatCd)
                    .HasColumnName("ACTIVE_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.BasePlanId)
                    .HasColumnName("BASE_PLAN_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.BasePlanYn)
                    .HasColumnName("BASE_PLAN_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.BuildingId)
                    .HasColumnName("BUILDING_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkStatCd)
                    .HasColumnName("CHK_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkoutTm)
                    .HasColumnName("CHKOUT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChkoutUserId)
                    .HasColumnName("CHKOUT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.CuBasePlanYn)
                    .HasColumnName("CU_BASE_PLAN_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.CuLotYn)
                    .HasColumnName("CU_LOT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.DervProdId)
                    .HasColumnName("DERV_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EmcEqpId)
                    .HasColumnName("EMC_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpAbbrNm)
                    .HasColumnName("EQP_GRP_ABBR_NM")
                    .HasMaxLength(50);

                entity.Property(e => e.EventUseTyp)
                    .HasColumnName("EVENT_USE_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.FlowCatgCd)
                    .HasColumnName("FLOW_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowTyp)
                    .HasColumnName("FLOW_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MainLotCd)
                    .HasColumnName("MAIN_LOT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MainProdId)
                    .HasColumnName("MAIN_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MetalTyp)
                    .HasColumnName("METAL_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.MetrTyp)
                    .HasColumnName("METR_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.MtjBasePlanYn)
                    .HasColumnName("MTJ_BASE_PLAN_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.MtjLotYn)
                    .HasColumnName("MTJ_LOT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.NpwReturnOperId)
                    .HasColumnName("NPW_RETURN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.NpwTyp)
                    .HasColumnName("NPW_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.PlanCrtYn)
                    .HasColumnName("PLAN_CRT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.PlanId)
                    .HasColumnName("PLAN_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PlanOwnerId)
                    .HasColumnName("PLAN_OWNER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdGrpNm)
                    .HasColumnName("PROD_GRP_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RECIPE_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefFlowId)
                    .HasColumnName("REF_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnFlowId)
                    .HasColumnName("RETURN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnOperId)
                    .HasColumnName("RETURN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkAreaId)
                    .HasColumnName("RWK_AREA_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.RwkTyp)
                    .HasColumnName("RWK_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.SubActiveStatCd)
                    .HasColumnName("SUB_ACTIVE_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SubOperId)
                    .HasColumnName("SUB_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.TechNm)
                    .HasColumnName("TECH_NM")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkTyp)
                    .HasColumnName("WORK_TYP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MesLotMasMv>(entity =>
            {
                entity.HasKey(e => e.LotId)
                    .HasName("MES_LOT_MAS_PK");

                entity.ToTable("MES_LOT_MAS_MV");

                entity.HasIndex(e => e.CarrierId)
                    .HasName("MES_LOT_MAS_IX1");

                entity.HasIndex(e => e.LotBatchId)
                    .HasName("MES_LOT_MAS_IX3");

                entity.HasIndex(e => e.ObjId)
                    .HasName("MES_LOT_MAS_IX2");

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AlarmHoldYn)
                    .HasColumnName("ALARM_HOLD_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.AreaId)
                    .HasColumnName("AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ArrvVal)
                    .HasColumnName("ARRV_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.AutoR2rYn)
                    .HasColumnName("AUTO_R2R_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.BatchIntlockOperId)
                    .HasColumnName("BATCH_INTLOCK_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.BatchZoneNm)
                    .HasColumnName("BATCH_ZONE_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.BatchZoneSeq)
                    .HasColumnName("BATCH_ZONE_SEQ")
                    .HasMaxLength(40);

                entity.Property(e => e.CancelCd)
                    .HasColumnName("CANCEL_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CapaCd)
                    .HasColumnName("CAPA_CD")
                    .HasMaxLength(1000);

                entity.Property(e => e.CarrierId)
                    .HasColumnName("CARRIER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CautCtn)
                    .HasColumnName("CAUT_CTN")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkListTyp)
                    .HasColumnName("CHK_LIST_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtCd)
                    .HasColumnName("CRT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtSubProdQty)
                    .HasColumnName("CRT_SUB_PROD_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtSubProdQty1)
                    .HasColumnName("CRT_SUB_PROD_QTY_1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtSubProdQty2)
                    .HasColumnName("CRT_SUB_PROD_QTY_2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtWfQty)
                    .HasColumnName("CRT_WF_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustNm)
                    .HasColumnName("CUST_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.CycleTime)
                    .HasColumnName("CYCLE_TIME")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DedicId)
                    .HasColumnName("DEDIC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DelHistYn)
                    .HasColumnName("DEL_HIST_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.DervReturnFlowId)
                    .HasColumnName("DERV_RETURN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DervReturnOperId)
                    .HasColumnName("DERV_RETURN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DueTm)
                    .HasColumnName("DUE_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DummyQty)
                    .HasColumnName("DUMMY_QTY")
                    .HasMaxLength(40);

                entity.Property(e => e.EngrUserId)
                    .HasColumnName("ENGR_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpId)
                    .HasColumnName("EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpJobEventTyp)
                    .HasColumnName("EQP_JOB_EVENT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpRecipeId)
                    .HasColumnName("EQP_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FabId)
                    .HasColumnName("FAB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FabOutDueTm)
                    .HasColumnName("FAB_OUT_DUE_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FirstFlowPrintVal)
                    .HasColumnName("FIRST_FLOW_PRINT_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.FrFabId)
                    .HasColumnName("FR_FAB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FrOutFabInTm)
                    .HasColumnName("FR_OUT_FAB_IN_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.GoalEqpId)
                    .HasColumnName("GOAL_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.GoalLotId)
                    .HasColumnName("GOAL_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.GoalPortNm)
                    .HasColumnName("GOAL_PORT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.GoalStkId)
                    .HasColumnName("GOAL_STK_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.HotLotReleaseOperId)
                    .HasColumnName("HOT_LOT_RELEASE_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.HotTyp)
                    .HasColumnName("HOT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.HotTypFrOperId)
                    .HasColumnName("HOT_TYP_FR_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.InQueueTimeTyp)
                    .HasColumnName("IN_QUEUE_TIME_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.InTm)
                    .HasColumnName("IN_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobSlotInfoVal)
                    .HasColumnName("JOB_SLOT_INFO_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEqpId)
                    .HasColumnName("LAST_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEqpRecipeId)
                    .HasColumnName("LAST_EQP_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventCd)
                    .HasColumnName("LAST_EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventDesc)
                    .HasColumnName("LAST_EVENT_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.LastEventTimekey)
                    .HasColumnName("LAST_EVENT_TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventTm)
                    .HasColumnName("LAST_EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastEventTyp)
                    .HasColumnName("LAST_EVENT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventUserId)
                    .HasColumnName("LAST_EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastJobPrepTm)
                    .HasColumnName("LAST_JOB_PREP_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastLocEqpId)
                    .HasColumnName("LAST_LOC_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastMoveinTm)
                    .HasColumnName("LAST_MOVEIN_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastMoveinUserId)
                    .HasColumnName("LAST_MOVEIN_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastMoveoutTm)
                    .HasColumnName("LAST_MOVEOUT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastMoveoutUserId)
                    .HasColumnName("LAST_MOVEOUT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastPortNm)
                    .HasColumnName("LAST_PORT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.LastReticleId)
                    .HasColumnName("LAST_RETICLE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastSampCarrierId)
                    .HasColumnName("LAST_SAMP_CARRIER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastSampLotId)
                    .HasColumnName("LAST_SAMP_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastSampSlotNo)
                    .HasColumnName("LAST_SAMP_SLOT_NO")
                    .HasMaxLength(250);

                entity.Property(e => e.LastStepperNm)
                    .HasColumnName("LAST_STEPPER_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.LastStepperRecipeId)
                    .HasColumnName("LAST_STEPPER_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastTrackNm)
                    .HasColumnName("LAST_TRACK_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.LoadTm)
                    .HasColumnName("LOAD_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotBatchId)
                    .HasColumnName("LOT_BATCH_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotEventDesc)
                    .HasColumnName("LOT_EVENT_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.LotGradeTyp)
                    .HasColumnName("LOT_GRADE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.LotHoldStatCd)
                    .HasColumnName("LOT_HOLD_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LotProcStatCd)
                    .HasColumnName("LOT_PROC_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LotStatTyp)
                    .HasColumnName("LOT_STAT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEqpId)
                    .HasColumnName("MAIN_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEqpRecipeId)
                    .HasColumnName("MAIN_EQP_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainEventTm)
                    .HasColumnName("MAIN_EVENT_TM")
                    .HasMaxLength(40);

                entity.Property(e => e.MainFlowId)
                    .HasColumnName("MAIN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainLotId)
                    .HasColumnName("MAIN_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainMoveinTm)
                    .HasColumnName("MAIN_MOVEIN_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.MainMoveoutTm)
                    .HasColumnName("MAIN_MOVEOUT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MeasCompltTyp)
                    .HasColumnName("MEAS_COMPLT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MeasMainEqpId)
                    .HasColumnName("MEAS_MAIN_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MeasMainFlowId)
                    .HasColumnName("MEAS_MAIN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MeasMainOperId)
                    .HasColumnName("MEAS_MAIN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MergeFlowId)
                    .HasColumnName("MERGE_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MergeId)
                    .HasColumnName("MERGE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MergeOperId)
                    .HasColumnName("MERGE_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MesProcStatCd)
                    .HasColumnName("MES_PROC_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MfgCompnyNm)
                    .HasColumnName("MFG_COMPNY_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.MfgNationNm)
                    .HasColumnName("MFG_NATION_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.MonJobId)
                    .HasColumnName("MON_JOB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MonRecycNumcnt)
                    .HasColumnName("MON_RECYC_NUMCNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MonStatTyp)
                    .HasColumnName("MON_STAT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveFabId)
                    .HasColumnName("MOVE_FAB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveFlowYn)
                    .HasColumnName("MOVE_FLOW_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveProdYn)
                    .HasColumnName("MOVE_PROD_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.NextResvEqpId)
                    .HasColumnName("NEXT_RESV_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.NextResvRecipeId)
                    .HasColumnName("NEXT_RESV_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.NodeStackVal)
                    .HasColumnName("NODE_STACK_VAL")
                    .HasMaxLength(400);

                entity.Property(e => e.NpwBayNm)
                    .HasColumnName("NPW_BAY_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.NpwEqpGrpId)
                    .HasColumnName("NPW_EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ObjId)
                    .HasColumnName("OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.OrgLotId)
                    .HasColumnName("ORG_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OwnerCd)
                    .HasColumnName("OWNER_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ParentLotId)
                    .HasColumnName("PARENT_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PcbankYn)
                    .HasColumnName("PCBANK_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.PhotoSampLotId)
                    .HasColumnName("PHOTO_SAMP_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PhotoStatTyp)
                    .HasColumnName("PHOTO_STAT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.PmsYn)
                    .HasColumnName("PMS_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.PortNm)
                    .HasColumnName("PORT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.PrbTestYn)
                    .HasColumnName("PRB_TEST_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.Priority)
                    .HasColumnName("PRIORITY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProcChgLotId)
                    .HasColumnName("PROC_CHG_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProcSubEqpId)
                    .HasColumnName("PROC_SUB_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId2)
                    .HasColumnName("PROD_ID_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdRecipeYn)
                    .HasColumnName("PROD_RECIPE_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdReqId)
                    .HasColumnName("PROD_REQ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdTyp)
                    .HasColumnName("PROD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer)
                    .HasColumnName("PROD_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer2)
                    .HasColumnName("PROD_VER_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ProduceTyp)
                    .HasColumnName("PRODUCE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.QueueStartTm)
                    .HasColumnName("QUEUE_START_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReasonCatgCd)
                    .HasColumnName("REASON_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonCd)
                    .HasColumnName("REASON_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.RecipeNspaceCd)
                    .HasColumnName("RECIPE_NSPACE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ReleaseTm)
                    .HasColumnName("RELEASE_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReleaseUserId)
                    .HasColumnName("RELEASE_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvAlarmYn)
                    .HasColumnName("RESV_ALARM_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvAttrVal1)
                    .HasColumnName("RESV_ATTR_VAL_1")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal10)
                    .HasColumnName("RESV_ATTR_VAL_10")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal2)
                    .HasColumnName("RESV_ATTR_VAL_2")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal3)
                    .HasColumnName("RESV_ATTR_VAL_3")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal4)
                    .HasColumnName("RESV_ATTR_VAL_4")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal5)
                    .HasColumnName("RESV_ATTR_VAL_5")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal6)
                    .HasColumnName("RESV_ATTR_VAL_6")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal7)
                    .HasColumnName("RESV_ATTR_VAL_7")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal8)
                    .HasColumnName("RESV_ATTR_VAL_8")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvAttrVal9)
                    .HasColumnName("RESV_ATTR_VAL_9")
                    .HasMaxLength(100);

                entity.Property(e => e.ResvEqpId)
                    .HasColumnName("RESV_EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvEqpTm)
                    .HasColumnName("RESV_EQP_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResvFieldVal1)
                    .HasColumnName("RESV_FIELD_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal10)
                    .HasColumnName("RESV_FIELD_VAL_10")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal2)
                    .HasColumnName("RESV_FIELD_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal3)
                    .HasColumnName("RESV_FIELD_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal4)
                    .HasColumnName("RESV_FIELD_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal5)
                    .HasColumnName("RESV_FIELD_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal6)
                    .HasColumnName("RESV_FIELD_VAL_6")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal7)
                    .HasColumnName("RESV_FIELD_VAL_7")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal8)
                    .HasColumnName("RESV_FIELD_VAL_8")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal9)
                    .HasColumnName("RESV_FIELD_VAL_9")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvRecipeId)
                    .HasColumnName("RESV_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvSeq)
                    .HasColumnName("RESV_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ResvStepperNm)
                    .HasColumnName("RESV_STEPPER_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvTrackNm)
                    .HasColumnName("RESV_TRACK_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleFamilyCd)
                    .HasColumnName("RETICLE_FAMILY_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleFlowId)
                    .HasColumnName("RETICLE_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleId)
                    .HasColumnName("RETICLE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleOperId)
                    .HasColumnName("RETICLE_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleProdId)
                    .HasColumnName("RETICLE_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleVer)
                    .HasColumnName("RETICLE_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnReasonTyp)
                    .HasColumnName("RETURN_REASON_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.RootLotId)
                    .HasColumnName("ROOT_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkCnt)
                    .HasColumnName("RWK_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RwkMainFlowId)
                    .HasColumnName("RWK_MAIN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkMainOperId)
                    .HasColumnName("RWK_MAIN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkNodeId)
                    .HasColumnName("RWK_NODE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkReturnFlowId)
                    .HasColumnName("RWK_RETURN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkReturnOperId)
                    .HasColumnName("RWK_RETURN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkReturnOperYn)
                    .HasColumnName("RWK_RETURN_OPER_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkReturnYn)
                    .HasColumnName("RWK_RETURN_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkStatCd)
                    .HasColumnName("RWK_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SampLotYn)
                    .HasColumnName("SAMP_LOT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.SampSeq)
                    .HasColumnName("SAMP_SEQ")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.SapCd)
                    .HasColumnName("SAP_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SendCmdTm)
                    .HasColumnName("SEND_CMD_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipApproveUserId)
                    .HasColumnName("SHIP_APPROVE_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ShipCancelPartNm)
                    .HasColumnName("SHIP_CANCEL_PART_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ShipCancelReasonTyp)
                    .HasColumnName("SHIP_CANCEL_REASON_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ShipCancelTyp)
                    .HasColumnName("SHIP_CANCEL_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ShipCancelUserId)
                    .HasColumnName("SHIP_CANCEL_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ShipCd)
                    .HasColumnName("SHIP_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ShipGradeCd)
                    .HasColumnName("SHIP_GRADE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ShipPrintYn)
                    .HasColumnName("SHIP_PRINT_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.ShipSwrNm)
                    .HasColumnName("SHIP_SWR_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.SrcLotId)
                    .HasColumnName("SRC_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SrcMonUseTyp)
                    .HasColumnName("SRC_MON_USE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.StepperRecipeId)
                    .HasColumnName("STEPPER_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.StepperStartYn)
                    .HasColumnName("STEPPER_START_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.StkId)
                    .HasColumnName("STK_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SubAreaId)
                    .HasColumnName("SUB_AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SubProdQty)
                    .HasColumnName("SUB_PROD_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubProdQty1)
                    .HasColumnName("SUB_PROD_QTY_1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubProdQty2)
                    .HasColumnName("SUB_PROD_QTY_2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubProdTyp)
                    .HasColumnName("SUB_PROD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.SubProdUnitQty1)
                    .HasColumnName("SUB_PROD_UNIT_QTY_1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubProdUnitQty2)
                    .HasColumnName("SUB_PROD_UNIT_QTY_2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubQty1)
                    .HasColumnName("SUB_QTY_1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubQty2)
                    .HasColumnName("SUB_QTY_2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubQty3)
                    .HasColumnName("SUB_QTY_3")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubQty4)
                    .HasColumnName("SUB_QTY_4")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubTotQty)
                    .HasColumnName("SUB_TOT_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TgtFacId)
                    .HasColumnName("TGT_FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.TransferPauseYn)
                    .HasColumnName("TRANSFER_PAUSE_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.UseWfCnt)
                    .HasColumnName("USE_WF_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WfQty)
                    .HasColumnName("WF_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WfQty2)
                    .HasColumnName("WF_QTY_2")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<MesNodeMasMv>(entity =>
            {
                entity.HasKey(e => e.NodeId)
                    .HasName("MES_NODE_MAS_IX1");

                entity.ToTable("MES_NODE_MAS_MV");

                entity.HasIndex(e => new { e.FacId, e.FlowId })
                    .HasName("MES_NODE_MAS_IX2");

                entity.Property(e => e.NodeId)
                    .HasColumnName("NODE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.NodeAttrVal1)
                    .HasColumnName("NODE_ATTR_VAL_1")
                    .HasMaxLength(250);

                entity.Property(e => e.NodeAttrVal2)
                    .HasColumnName("NODE_ATTR_VAL_2")
                    .HasMaxLength(250);

                entity.Property(e => e.NodeTyp)
                    .HasColumnName("NODE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.OperSeq)
                    .HasColumnName("OPER_SEQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.XCoordVal)
                    .HasColumnName("X_COORD_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.YCoordVal)
                    .HasColumnName("Y_COORD_VAL")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<MesNodeRelMv>(entity =>
            {
                entity.HasKey(e => new { e.FrNodeId, e.ToNodeId })
                    .HasName("MES_NODE_REL_PK");

                entity.ToTable("MES_NODE_REL_MV");

                entity.Property(e => e.FrNodeId)
                    .HasColumnName("FR_NODE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ToNodeId)
                    .HasColumnName("TO_NODE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.RelAttrVal)
                    .HasColumnName("REL_ATTR_VAL")
                    .HasMaxLength(250);

                entity.Property(e => e.RelTyp)
                    .HasColumnName("REL_TYP")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<MesOperMasMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.OperId, e.OperVer })
                    .HasName("MES_OPER_MAS_PK");

                entity.ToTable("MES_OPER_MAS_MV");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ActiveStatCd)
                    .HasColumnName("ACTIVE_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.AddDetOperTyp)
                    .HasColumnName("ADD_DET_OPER_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.AddOperTyp)
                    .HasColumnName("ADD_OPER_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.BatchSize).HasColumnName("BATCH_SIZE");

                entity.Property(e => e.CarrierGrpId)
                    .HasColumnName("CARRIER_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgOperId)
                    .HasColumnName("CHG_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkItemCd)
                    .HasColumnName("CHK_ITEM_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.ChkStatCd)
                    .HasColumnName("CHK_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkoutTm)
                    .HasColumnName("CHKOUT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChkoutUserId)
                    .HasColumnName("CHKOUT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.CycleTime).HasColumnName("CYCLE_TIME");

                entity.Property(e => e.DcolId)
                    .HasColumnName("DCOL_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DefaultAreaId)
                    .HasColumnName("DEFAULT_AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DefaultStkId)
                    .HasColumnName("DEFAULT_STK_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DefaultZoneNm)
                    .HasColumnName("DEFAULT_ZONE_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.DetAreaId)
                    .HasColumnName("DET_AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DetOperTyp)
                    .HasColumnName("DET_OPER_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpId)
                    .HasColumnName("EQP_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EventUseTyp)
                    .HasColumnName("EVENT_USE_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyCd)
                    .HasColumnName("FAMILY_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FutureHoldYn)
                    .HasColumnName("FUTURE_HOLD_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.GasTyp)
                    .HasColumnName("GAS_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.IdleTime).HasColumnName("IDLE_TIME");

                entity.Property(e => e.JumpPermitOperId)
                    .HasColumnName("JUMP_PERMIT_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LogonReqYn)
                    .HasColumnName("LOGON_REQ_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MeasTyp)
                    .HasColumnName("MEAS_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MetalYn)
                    .HasColumnName("METAL_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.MidOperTyp)
                    .HasColumnName("MID_OPER_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveReplaceOperYn)
                    .HasColumnName("MOVE_REPLACE_OPER_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.NpwAreaId)
                    .HasColumnName("NPW_AREA_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.NpwReturnFlowId)
                    .HasColumnName("NPW_RETURN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.NpwReturnOperId)
                    .HasColumnName("NPW_RETURN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.NpwTyp)
                    .HasColumnName("NPW_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.OperGrpCd)
                    .HasColumnName("OPER_GRP_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.OperTyp)
                    .HasColumnName("OPER_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.OperUnitCd)
                    .HasColumnName("OPER_UNIT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ProcTime).HasColumnName("PROC_TIME");

                entity.Property(e => e.PwYn)
                    .HasColumnName("PW_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.R3BakAllowYn)
                    .HasColumnName("R3_BAK_ALLOW_YN")
                    .HasMaxLength(10);

                entity.Property(e => e.SampMeasTyp)
                    .HasColumnName("SAMP_MEAS_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.SdptNm)
                    .HasColumnName("SDPT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.SkipAllowYn)
                    .HasColumnName("SKIP_ALLOW_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.SplitRwkSkipYn)
                    .HasColumnName("SPLIT_RWK_SKIP_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.StdAreaId)
                    .HasColumnName("STD_AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.StepSeqVal)
                    .HasColumnName("STEP_SEQ_VAL")
                    .HasMaxLength(50);

                entity.Property(e => e.SubOperId)
                    .HasColumnName("SUB_OPER_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.SumryDesc)
                    .HasColumnName("SUMRY_DESC")
                    .HasMaxLength(40);

                entity.Property(e => e.UniqueInlineTrackYn)
                    .HasColumnName("UNIQUE_INLINE_TRACK_YN")
                    .HasMaxLength(10);

                entity.Property(e => e.WorkTyp)
                    .HasColumnName("WORK_TYP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MesProdMasMv>(entity =>
            {
                entity.HasKey(e => new { e.FacId, e.ProdId, e.ProdVer })
                    .HasName("MES_PROD_MAS_PK");

                entity.ToTable("MES_PROD_MAS_MV");

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer)
                    .HasColumnName("PROD_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ActiveStatCd)
                    .HasColumnName("ACTIVE_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.BasePlanId)
                    .HasColumnName("BASE_PLAN_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkStatCd)
                    .HasColumnName("CHK_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ChkoutTm)
                    .HasColumnName("CHKOUT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChkoutUserId)
                    .HasColumnName("CHKOUT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtProdYn)
                    .HasColumnName("CRT_PROD_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CtnDesc)
                    .HasColumnName("CTN_DESC")
                    .HasMaxLength(250);

                entity.Property(e => e.DenTyp)
                    .HasColumnName("DEN_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.DeptNm)
                    .HasColumnName("DEPT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpGrpAbbrNm)
                    .HasColumnName("EQP_GRP_ABBR_NM")
                    .HasMaxLength(200);

                entity.Property(e => e.EstCycleTime).HasColumnName("EST_CYCLE_TIME");

                entity.Property(e => e.FamilyCd)
                    .HasColumnName("FAMILY_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.FdTyp)
                    .HasColumnName("FD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.FrFabId)
                    .HasColumnName("FR_FAB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.GenTyp)
                    .HasColumnName("GEN_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.GradeTyp)
                    .HasColumnName("GRADE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.LotCd)
                    .HasColumnName("LOT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MainCd)
                    .HasColumnName("MAIN_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MainOperId)
                    .HasColumnName("MAIN_OPER_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MainProdId)
                    .HasColumnName("MAIN_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MonUseLimitVal)
                    .HasColumnName("MON_USE_LIMIT_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MoveProdId)
                    .HasColumnName("MOVE_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MultiProdTyp)
                    .HasColumnName("MULTI_PROD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.NpwTyp)
                    .HasColumnName("NPW_TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.ObjId)
                    .HasColumnName("OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperOptTyp)
                    .HasColumnName("OPER_OPT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.OrganizVal)
                    .HasColumnName("ORGANIZ_VAL")
                    .HasMaxLength(40);

                entity.Property(e => e.PlanCatgTyp)
                    .HasColumnName("PLAN_CATG_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.PlanYn)
                    .HasColumnName("PLAN_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.PrbTyp)
                    .HasColumnName("PRB_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId2)
                    .HasColumnName("PROD_ID_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdStatCd)
                    .HasColumnName("PROD_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdTyp)
                    .HasColumnName("PROD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer2)
                    .HasColumnName("PROD_VER_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ProduceTyp)
                    .HasColumnName("PRODUCE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ProjectNm)
                    .HasColumnName("PROJECT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.RecycFlowId)
                    .HasColumnName("RECYC_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RecycTimeLimitVal).HasColumnName("RECYC_TIME_LIMIT_VAL");

                entity.Property(e => e.ResvFieldVal1)
                    .HasColumnName("RESV_FIELD_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal2)
                    .HasColumnName("RESV_FIELD_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal3)
                    .HasColumnName("RESV_FIELD_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal4)
                    .HasColumnName("RESV_FIELD_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal5)
                    .HasColumnName("RESV_FIELD_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.ReticleOperCnt)
                    .HasColumnName("RETICLE_OPER_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReturnFlowId)
                    .HasColumnName("RETURN_FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnOperId)
                    .HasColumnName("RETURN_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ReturnProdId)
                    .HasColumnName("RETURN_PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SdTyp)
                    .HasColumnName("SD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ShipYn)
                    .HasColumnName("SHIP_YN")
                    .HasMaxLength(40);

                entity.Property(e => e.SubProdTyp)
                    .HasColumnName("SUB_PROD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.SubProdUnitQty1)
                    .HasColumnName("SUB_PROD_UNIT_QTY_1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubProdUnitQty2)
                    .HasColumnName("SUB_PROD_UNIT_QTY_2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TechNm)
                    .HasColumnName("TECH_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.ToFabId)
                    .HasColumnName("TO_FAB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.TotOperCnt)
                    .HasColumnName("TOT_OPER_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Typ1)
                    .HasColumnName("TYP_1")
                    .HasMaxLength(40);

                entity.Property(e => e.Typ2)
                    .HasColumnName("TYP_2")
                    .HasMaxLength(40);

                entity.Property(e => e.WfQty)
                    .HasColumnName("WF_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WipCnt)
                    .HasColumnName("WIP_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WorkTyp)
                    .HasColumnName("WORK_TYP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MesWfMasMv>(entity =>
            {
                entity.HasKey(e => e.WfId)
                    .HasName("MES_WF_MAS_PK");

                entity.ToTable("MES_WF_MAS_MV");

                entity.HasIndex(e => new { e.LotId, e.PositionVal })
                    .HasName("MES_WF_MAS_IX1");

                entity.Property(e => e.WfId)
                    .HasColumnName("WF_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.AreaId)
                    .HasColumnName("AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CarrierId)
                    .HasColumnName("CARRIER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ChgCondition)
                    .HasColumnName("CHG_CONDITION")
                    .HasMaxLength(50);

                entity.Property(e => e.ChkItemCd)
                    .HasColumnName("CHK_ITEM_CD")
                    .HasMaxLength(50);

                entity.Property(e => e.CrtSubProdQty)
                    .HasColumnName("CRT_SUB_PROD_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtSubProdQty1)
                    .HasColumnName("CRT_SUB_PROD_QTY_1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtSubProdQty2)
                    .HasColumnName("CRT_SUB_PROD_QTY_2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.DueTm)
                    .HasColumnName("DUE_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpRecipeId)
                    .HasColumnName("EQP_RECIPE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FacId)
                    .HasColumnName("FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowId)
                    .HasColumnName("FLOW_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.FlowVer)
                    .HasColumnName("FLOW_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.FrFabId)
                    .HasColumnName("FR_FAB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.GoalWfId)
                    .HasColumnName("GOAL_WF_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.InProduceTm)
                    .HasColumnName("IN_PRODUCE_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.InProduceUserId)
                    .HasColumnName("IN_PRODUCE_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.IngotId1)
                    .HasColumnName("INGOT_ID_1")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventCd)
                    .HasColumnName("LAST_EVENT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventDesc)
                    .HasColumnName("LAST_EVENT_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.LastEventTimekey)
                    .HasColumnName("LAST_EVENT_TIMEKEY")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventTm)
                    .HasColumnName("LAST_EVENT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastEventTyp)
                    .HasColumnName("LAST_EVENT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.LastEventUserId)
                    .HasColumnName("LAST_EVENT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastIdleTm)
                    .HasColumnName("LAST_IDLE_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastIdleUserId)
                    .HasColumnName("LAST_IDLE_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LastPrcsTm)
                    .HasColumnName("LAST_PRCS_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastPrcsUserId)
                    .HasColumnName("LAST_PRCS_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotBatchId)
                    .HasColumnName("LOT_BATCH_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MainLotId)
                    .HasColumnName("MAIN_LOT_ID")
                    .HasMaxLength(165);

                entity.Property(e => e.MatlLocCd)
                    .HasColumnName("MATL_LOC_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MesProcStatCd)
                    .HasColumnName("MES_PROC_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.MonJobId)
                    .HasColumnName("MON_JOB_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MonOperId)
                    .HasColumnName("MON_OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MonRecycNumcnt)
                    .HasColumnName("MON_RECYC_NUMCNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MonStatTyp)
                    .HasColumnName("MON_STAT_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.MonUseCnt)
                    .HasColumnName("MON_USE_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MonUseLimitVal)
                    .HasColumnName("MON_USE_LIMIT_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NodeStackVal)
                    .HasColumnName("NODE_STACK_VAL")
                    .HasMaxLength(400);

                entity.Property(e => e.NpwTotUseCnt)
                    .HasColumnName("NPW_TOT_USE_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ObjId)
                    .HasColumnName("OBJ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.OperVer)
                    .HasColumnName("OPER_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.OrgWfId)
                    .HasColumnName("ORG_WF_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.PositionVal)
                    .HasColumnName("POSITION_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Priority)
                    .HasColumnName("PRIORITY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProdGradeCd)
                    .HasColumnName("PROD_GRADE_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdHoldStatCd)
                    .HasColumnName("PROD_HOLD_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId)
                    .HasColumnName("PROD_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdId2)
                    .HasColumnName("PROD_ID_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdReqId)
                    .HasColumnName("PROD_REQ_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdStatCd)
                    .HasColumnName("PROD_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdTyp)
                    .HasColumnName("PROD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer)
                    .HasColumnName("PROD_VER")
                    .HasMaxLength(40);

                entity.Property(e => e.ProdVer2)
                    .HasColumnName("PROD_VER_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ProduceTyp)
                    .HasColumnName("PRODUCE_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonCatgCd)
                    .HasColumnName("REASON_CATG_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ReasonCd)
                    .HasColumnName("REASON_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal1)
                    .HasColumnName("RESV_FIELD_VAL_1")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal2)
                    .HasColumnName("RESV_FIELD_VAL_2")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal3)
                    .HasColumnName("RESV_FIELD_VAL_3")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal4)
                    .HasColumnName("RESV_FIELD_VAL_4")
                    .HasMaxLength(40);

                entity.Property(e => e.ResvFieldVal5)
                    .HasColumnName("RESV_FIELD_VAL_5")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkCnt)
                    .HasColumnName("RWK_CNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RwkNodeId)
                    .HasColumnName("RWK_NODE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.RwkStatCd)
                    .HasColumnName("RWK_STAT_CD")
                    .HasMaxLength(40);

                entity.Property(e => e.SerialNo)
                    .HasColumnName("SERIAL_NO")
                    .HasMaxLength(40);

                entity.Property(e => e.SpecFlag)
                    .HasColumnName("SPEC_FLAG")
                    .HasMaxLength(50);

                entity.Property(e => e.SrcCarrierId)
                    .HasColumnName("SRC_CARRIER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SrcFlag)
                    .HasColumnName("SRC_FLAG")
                    .HasMaxLength(50);

                entity.Property(e => e.SrcLotId)
                    .HasColumnName("SRC_LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SrcSlotNo)
                    .HasColumnName("SRC_SLOT_NO")
                    .HasMaxLength(40);

                entity.Property(e => e.SrcWfId)
                    .HasColumnName("SRC_WF_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.SubProdGradeCd1)
                    .HasColumnName("SUB_PROD_GRADE_CD_1")
                    .HasMaxLength(40);

                entity.Property(e => e.SubProdGradeCd2)
                    .HasColumnName("SUB_PROD_GRADE_CD_2")
                    .HasMaxLength(40);

                entity.Property(e => e.SubProdQty)
                    .HasColumnName("SUB_PROD_QTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubProdQty1)
                    .HasColumnName("SUB_PROD_QTY_1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubProdQty2)
                    .HasColumnName("SUB_PROD_QTY_2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubProdTyp)
                    .HasColumnName("SUB_PROD_TYP")
                    .HasMaxLength(40);

                entity.Property(e => e.SubProdUnitQty1)
                    .HasColumnName("SUB_PROD_UNIT_QTY_1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubProdUnitQty2)
                    .HasColumnName("SUB_PROD_UNIT_QTY_2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TgtFacId)
                    .HasColumnName("TGT_FAC_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.TotUseLastNpwVal)
                    .HasColumnName("TOT_USE_LAST_NPW_VAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransGrpId)
                    .HasColumnName("TRANS_GRP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.TransferTm)
                    .HasColumnName("TRANSFER_TM")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<SystemCode>(entity =>
            {
                entity.HasKey(e => new { e.Category, e.Code, e.DisplayName })
                    .HasName("SystemCode_PK");

                entity.Property(e => e.Category).HasMaxLength(20);

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasColumnName("CreateUserID")
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("UpdateUserID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TestProcessMas>(entity =>
            {
                entity.HasKey(e => new { e.Fab, e.SysId, e.ProcessId, e.Ip, e.Port })
                    .HasName("TEST_PROCESS_MAS_IX01");

                entity.ToTable("TEST_PROCESS_MAS");

                entity.Property(e => e.Fab)
                    .HasColumnName("FAB")
                    .HasMaxLength(10);

                entity.Property(e => e.SysId)
                    .HasColumnName("SYS_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.ProcessId)
                    .HasColumnName("PROCESS_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(40);

                entity.Property(e => e.Port)
                    .HasColumnName("PORT")
                    .HasMaxLength(10);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUser)
                    .HasColumnName("CHG_USER")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUser)
                    .HasColumnName("CRT_USER")
                    .HasMaxLength(40);

                entity.Property(e => e.LogPath)
                    .HasColumnName("LOG_PATH")
                    .HasMaxLength(1024);

                entity.Property(e => e.SysVerp)
                    .HasColumnName("SYS_VERP")
                    .HasMaxLength(40);

                entity.Property(e => e.UiPort)
                    .HasColumnName("UI_PORT")
                    .HasMaxLength(40);

                entity.Property(e => e.UseTyp)
                    .HasColumnName("USE_TYP")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TestRecipeParamMas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEST_RECIPE_PARAM_MAS");

                entity.Property(e => e.AreaId)
                    .HasColumnName("AREA_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LogsheetId)
                    .HasColumnName("LOGSHEET_ID")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.ParaNm)
                    .HasColumnName("PARA_NM")
                    .HasMaxLength(80);

                entity.Property(e => e.Recipe)
                    .HasColumnName("RECIPE")
                    .HasMaxLength(160);

                entity.Property(e => e.RecipeParaId)
                    .HasColumnName("RECIPE_PARA_ID")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(80);

                entity.Property(e => e.VirtualParaNm)
                    .HasColumnName("VIRTUAL_PARA_NM")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<VfdpWaferHistory>(entity =>
            {
                entity.HasKey(e => new { e.WaferId, e.EventNm, e.StartTm })
                    .HasName("VFDP_WAFER_HIS_PK");

                entity.ToTable("VFDP_WAFER_HISTORY");

                entity.Property(e => e.WaferId)
                    .HasColumnName("WAFER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EventNm)
                    .HasColumnName("EVENT_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.StartTm)
                    .HasColumnName("START_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CassetteId)
                    .HasColumnName("CASSETTE_ID")
                    .HasMaxLength(64);

                entity.Property(e => e.CassetteSlot)
                    .HasColumnName("CASSETTE_SLOT")
                    .HasMaxLength(8);

                entity.Property(e => e.ChgTm)
                    .HasColumnName("CHG_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChgUserId)
                    .HasColumnName("CHG_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.CrtTm)
                    .HasColumnName("CRT_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("CRT_USER_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.EndTm)
                    .HasColumnName("END_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.EqpId)
                    .HasColumnName("EQP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LotId)
                    .HasColumnName("LOT_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ModuleId)
                    .HasColumnName("MODULE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.ModuleNm)
                    .HasColumnName("MODULE_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.OnlineMode)
                    .HasColumnName("ONLINE_MODE")
                    .HasMaxLength(64);

                entity.Property(e => e.OperDesc)
                    .HasColumnName("OPER_DESC")
                    .HasMaxLength(128);

                entity.Property(e => e.OperId)
                    .HasColumnName("OPER_ID")
                    .HasMaxLength(128);

                entity.Property(e => e.ProcessFlow)
                    .HasColumnName("PROCESS_FLOW")
                    .HasMaxLength(128);

                entity.Property(e => e.Product)
                    .HasColumnName("PRODUCT")
                    .HasMaxLength(128);

                entity.Property(e => e.RcvEndTm)
                    .HasColumnName("RCV_END_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.RcvStartTm)
                    .HasColumnName("RCV_START_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RECIPE_ID")
                    .HasMaxLength(128);

                entity.Property(e => e.ResourceGroup)
                    .HasColumnName("RESOURCE_GROUP")
                    .HasMaxLength(32);

                entity.Property(e => e.ResourceTyp)
                    .HasColumnName("RESOURCE_TYP")
                    .HasMaxLength(32);

                entity.Property(e => e.SeqRecipeId)
                    .HasColumnName("SEQ_RECIPE_ID")
                    .HasMaxLength(128);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(64);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
