using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SeniorProjectWebsite
{
    public partial class seniorprojectContext : DbContext
    {
        public seniorprojectContext()
        {
        }

        public seniorprojectContext(DbContextOptions<seniorprojectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bussines> Bussines { get; set; }
        public virtual DbSet<Funding> Funding { get; set; }
        public virtual DbSet<Geo> Geo { get; set; }
        public virtual DbSet<Income> Income { get; set; }
        public virtual DbSet<Math> Math { get; set; }
        public virtual DbSet<Read> Read { get; set; }
        public virtual DbSet<TeacherRatios> TeacherRatios { get; set; }
        public virtual DbSet<Title1> Title1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Bussines>(entity =>
            {
                entity.HasKey(e => e.ZipCode)
                    .HasName("BUSSINES_pkey");

                entity.ToTable("BUSSINES");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zip_code")
                    .HasColumnType("numeric");

                entity.Property(e => e.AnnualPayroll).HasColumnName("annual_payroll");

                entity.Property(e => e.FirstQuarterPayroll).HasColumnName("first_quarter_payroll");

                entity.Property(e => e.GeoId).HasColumnName("geo_id");

                entity.Property(e => e.GeoId2).HasColumnName("geo_id2");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.NaicsId).HasColumnName("naics_id");

                entity.Property(e => e.NaicsMeaning).HasColumnName("naics_meaning");

                entity.Property(e => e.NumEstablishments).HasColumnName("num_establishments");

                entity.Property(e => e.NumPaidEmployees).HasColumnName("num_paid_employees");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Funding>(entity =>
            {
                entity.HasKey(e => e.Ncesid)
                    .HasName("FUNDING_pkey");

                entity.ToTable("FUNDING");

                entity.Property(e => e.Ncesid)
                    .HasColumnName("ncesid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cbsa).HasColumnName("cbsa");

                entity.Property(e => e.Conum).HasColumnName("conum");

                entity.Property(e => e.Csa).HasColumnName("csa");

                entity.Property(e => e.Enroll).HasColumnName("enroll");

                entity.Property(e => e.FedDis).HasColumnName("fed_dis");

                entity.Property(e => e.FedTitle1).HasColumnName("fed_title1");

                entity.Property(e => e.FedrNutr).HasColumnName("fedr_nutr");

                entity.Property(e => e.FedrOthr).HasColumnName("fedr_othr");

                entity.Property(e => e.Idcensus)
                    .HasColumnName("idcensus")
                    .HasColumnType("numeric");

                entity.Property(e => e.LocrCharges).HasColumnName("locr_charges");

                entity.Property(e => e.LocrCitiesCounties).HasColumnName("locr_cities_counties");

                entity.Property(e => e.LocrOtherSchools).HasColumnName("locr_other_schools");

                entity.Property(e => e.LocrOthr).HasColumnName("locr_othr");

                entity.Property(e => e.LocrParGovCont).HasColumnName("locr_par_gov_cont");

                entity.Property(e => e.LocrPropTax).HasColumnName("locr_prop_tax");

                entity.Property(e => e.LocrTax).HasColumnName("locr_tax");

                entity.Property(e => e.LongDebtIssued).HasColumnName("long_debt_issued");

                entity.Property(e => e.LongDebtRetired).HasColumnName("long_debt_retired");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OutstandingDebt).HasColumnName("outstanding_debt");

                entity.Property(e => e.PctCharges)
                    .HasColumnName("pct_charges")
                    .HasColumnType("numeric");

                entity.Property(e => e.PctOtherLocalGov)
                    .HasColumnName("pct_other_local_gov")
                    .HasColumnType("numeric");

                entity.Property(e => e.PctParentGovCont)
                    .HasColumnName("pct_parent_gov_cont")
                    .HasColumnType("numeric");

                entity.Property(e => e.PctRevLocale)
                    .HasColumnName("pct_rev_locale")
                    .HasColumnType("numeric");

                entity.Property(e => e.PctTitle1)
                    .HasColumnName("pct_title1")
                    .HasColumnType("numeric");

                entity.Property(e => e.PctTotFed)
                    .HasColumnName("pct_tot_fed")
                    .HasColumnType("numeric");

                entity.Property(e => e.PctTotState)
                    .HasColumnName("pct_tot_state")
                    .HasColumnType("numeric");

                entity.Property(e => e.PctTotalRev).HasColumnName("pct_total_rev");

                entity.Property(e => e.PctsGenForm)
                    .HasColumnName("pcts_gen_form")
                    .HasColumnType("numeric");

                entity.Property(e => e.PerPupilEmployeeBen).HasColumnName("per_pupil_employee_ben");

                entity.Property(e => e.PerPupilGenAdmin).HasColumnName("per_pupil_gen_admin");

                entity.Property(e => e.PerPupilInstBene).HasColumnName("per_pupil_inst_bene");

                entity.Property(e => e.PerPupilInstSalWag).HasColumnName("per_pupil_inst_sal_wag");

                entity.Property(e => e.PerPupilInstSupportStaff).HasColumnName("per_pupil_inst_support_staff");

                entity.Property(e => e.PerPupilInstTot).HasColumnName("per_pupil_inst_tot");

                entity.Property(e => e.PerPupilSalaryWages).HasColumnName("per_pupil_salary_wages");

                entity.Property(e => e.PerPupilSchoolAdmin).HasColumnName("per_pupil_school_admin");

                entity.Property(e => e.PerPupilSupportStaff).HasColumnName("per_pupil_support_staff");

                entity.Property(e => e.PerPupilTotSpending).HasColumnName("per_pupil_tot_spending");

                entity.Property(e => e.PerPupilTotSuppServ).HasColumnName("per_pupil_tot_supp_serv");

                entity.Property(e => e.StrGenFormulaAss).HasColumnName("str_gen_formula_ass");

                entity.Property(e => e.StrOthr).HasColumnName("str_othr");

                entity.Property(e => e.StrSpecEd).HasColumnName("str_spec_ed");

                entity.Property(e => e.StrTrans).HasColumnName("str_trans");

                entity.Property(e => e.TCapital).HasColumnName("t_capital");

                entity.Property(e => e.TCurInstruction).HasColumnName("t_cur_instruction");

                entity.Property(e => e.TCurInstructionBene).HasColumnName("t_cur_instruction_bene");

                entity.Property(e => e.TCurInstructionSalWag).HasColumnName("t_cur_instruction_sal_wag");

                entity.Property(e => e.TCurOther).HasColumnName("t_cur_other");

                entity.Property(e => e.TCurSupportServices).HasColumnName("t_cur_support_services");

                entity.Property(e => e.TCurrSpnd).HasColumnName("t_curr_spnd");

                entity.Property(e => e.TCursGenAdmin).HasColumnName("t_curs_gen_admin");

                entity.Property(e => e.TCursOth).HasColumnName("t_curs_oth");

                entity.Property(e => e.TCursPupil).HasColumnName("t_curs_pupil");

                entity.Property(e => e.TCursSchAdmin).HasColumnName("t_curs_sch_admin");

                entity.Property(e => e.TCursStaffSupport).HasColumnName("t_curs_staff_support");

                entity.Property(e => e.TEmployeeBen).HasColumnName("t_employee_ben");

                entity.Property(e => e.TIntrst).HasColumnName("t_intrst");

                entity.Property(e => e.TPayGovt).HasColumnName("t_pay_govt");

                entity.Property(e => e.TSalWage).HasColumnName("t_sal_wage");

                entity.Property(e => e.Tfedrev).HasColumnName("tfedrev");

                entity.Property(e => e.Tlocrev).HasColumnName("tlocrev");

                entity.Property(e => e.TotalExpenditure).HasColumnName("total_expenditure");

                entity.Property(e => e.Totalrev).HasColumnName("totalrev");

                entity.Property(e => e.Tstrev).HasColumnName("tstrev");
            });

            modelBuilder.Entity<Geo>(entity =>
            {
                entity.HasKey(e => e.Ncessch)
                    .HasName("geo_pkey");

                entity.ToTable("geo");

                entity.Property(e => e.Ncessch)
                    .HasColumnName("ncessch")
                    .HasColumnType("numeric");

                entity.Property(e => e.Cbsatype).HasColumnName("cbsatype");

                entity.Property(e => e.Cfips).HasColumnName("cfips");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.CombinedStatisticalArea).HasColumnName("combined_statistical_area");

                entity.Property(e => e.CongressionalDistrict).HasColumnName("congressional_district");

                entity.Property(e => e.CoreBasedStatisticalArea).HasColumnName("core_based_statistical_area");

                entity.Property(e => e.CountyName).HasColumnName("county_name");

                entity.Property(e => e.CsaName).HasColumnName("csa_name");

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasColumnType("numeric");

                entity.Property(e => e.Locale).HasColumnName("locale");

                entity.Property(e => e.Lon)
                    .HasColumnName("lon")
                    .HasColumnType("numeric");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NameCbsa).HasColumnName("name_cbsa");

                entity.Property(e => e.Necta).HasColumnName("necta");

                entity.Property(e => e.NectaName).HasColumnName("necta_name");

                entity.Property(e => e.Opstfips).HasColumnName("opstfips");

                entity.Property(e => e.SldLower).HasColumnName("sld_lower");

                entity.Property(e => e.SldUpper).HasColumnName("sld_upper");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Stfips).HasColumnName("stfips");

                entity.Property(e => e.Street).HasColumnName("street");

                entity.Property(e => e.Survyear).HasColumnName("survyear");

                entity.Property(e => e.Zip).HasColumnName("zip");
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.HasKey(e => e.Zipcode)
                    .HasName("income_pkey");

                entity.ToTable("income");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .ValueGeneratedNever();

                entity.Property(e => e.Agi).HasColumnName("agi");

                entity.Property(e => e.BeforeCreditsAmount).HasColumnName("before_credits_amount");

                entity.Property(e => e.BusinessProfessionalAmount).HasColumnName("business_professional_amount");

                entity.Property(e => e.EducationExpenseAmount).HasColumnName("education_expense_amount");

                entity.Property(e => e.ExcessIncomeCreditAmount).HasColumnName("excess_income_credit_amount");

                entity.Property(e => e.NetPremiumCreditsAmount).HasColumnName("net_premium_credits_amount");

                entity.Property(e => e.NonRefundEduAmount).HasColumnName("non_refund_edu_amount");

                entity.Property(e => e.NumBusinessProfessional).HasColumnName("num_business_professional");

                entity.Property(e => e.NumDep).HasColumnName("num_dep");

                entity.Property(e => e.NumEducatorExpenses).HasColumnName("num_educator_expenses");

                entity.Property(e => e.NumExemptions).HasColumnName("num_exemptions");

                entity.Property(e => e.NumJointReturns).HasColumnName("num_joint_returns");

                entity.Property(e => e.NumOfHeadHouseReturns).HasColumnName("num_of_head_house_returns");

                entity.Property(e => e.NumReturnStateLocalGeneral).HasColumnName("num_return_state_local_general");

                entity.Property(e => e.NumReturnTotalIncome).HasColumnName("num_return_total_income");

                entity.Property(e => e.NumReturns).HasColumnName("num_returns");

                entity.Property(e => e.NumReturnsBeforeCredits).HasColumnName("num_returns_before_credits");

                entity.Property(e => e.NumReturnsExcessIncomeCredit).HasColumnName("num_returns_excess_income_credit");

                entity.Property(e => e.NumReturnsNonRefundEdu).HasColumnName("num_returns_non_refund_edu");

                entity.Property(e => e.NumReturnsSalaryWages).HasColumnName("num_returns_salary_wages");

                entity.Property(e => e.NumReturnsUnemployeement).HasColumnName("num_returns_unemployeement");

                entity.Property(e => e.NumSingleReturns).HasColumnName("num_single_returns");

                entity.Property(e => e.NumStateLocal).HasColumnName("num_state_local");

                entity.Property(e => e.NumberOfRefundableEdu).HasColumnName("number_of_refundable_edu");

                entity.Property(e => e.NumberReturnsNetPremiumCredits).HasColumnName("number_returns_net_premium_credits");

                entity.Property(e => e.NumberReturnsPersonalProperty).HasColumnName("number_returns_personal_property");

                entity.Property(e => e.NumberReturnsTaxable).HasColumnName("number_returns_taxable");

                entity.Property(e => e.PersonalPropertyAmounts).HasColumnName("personal_property_amounts");

                entity.Property(e => e.RefundableEduAmount).HasColumnName("refundable_edu_amount");

                entity.Property(e => e.SallariesWagesAmount).HasColumnName("sallaries_wages_amount");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.StateLocalAmount).HasColumnName("state_local_amount");

                entity.Property(e => e.StateLocalGeneralAmount).HasColumnName("state_local_general_amount");

                entity.Property(e => e.Statefips).HasColumnName("statefips");

                entity.Property(e => e.TaxableAmount).HasColumnName("taxable_amount");

                entity.Property(e => e.ToalIncomeAmount).HasColumnName("toal_income_amount");

                entity.Property(e => e.UnemployeementAmount).HasColumnName("unemployeement_amount");
            });

            modelBuilder.Entity<Math>(entity =>
            {
                entity.HasKey(e => e.MathNcessch)
                    .HasName("math_pkey");

                entity.ToTable("math");

                entity.Property(e => e.MathNcessch)
                    .HasColumnName("math_ncessch")
                    .ValueGeneratedNever();

                entity.Property(e => e.MathAll03numvalid).HasColumnName("math_all03numvalid");

                entity.Property(e => e.MathAll03pctprofHigh).HasColumnName("math_all03pctprof_high");

                entity.Property(e => e.MathAll03pctprofLow).HasColumnName("math_all03pctprof_low");

                entity.Property(e => e.MathAll04numvalid).HasColumnName("math_all04numvalid");

                entity.Property(e => e.MathAll04pctprofHigh).HasColumnName("math_all04pctprof_high");

                entity.Property(e => e.MathAll04pctprofLow).HasColumnName("math_all04pctprof_low");

                entity.Property(e => e.MathAll05numvalid).HasColumnName("math_all05numvalid");

                entity.Property(e => e.MathAll05pctprofHigh).HasColumnName("math_all05pctprof_high");

                entity.Property(e => e.MathAll05pctprofLow).HasColumnName("math_all05pctprof_low");

                entity.Property(e => e.MathAll06numvalid).HasColumnName("math_all06numvalid");

                entity.Property(e => e.MathAll06pctprofHigh).HasColumnName("math_all06pctprof_high");

                entity.Property(e => e.MathAll06pctprofLow).HasColumnName("math_all06pctprof_low");

                entity.Property(e => e.MathAll07numvalid).HasColumnName("math_all07numvalid");

                entity.Property(e => e.MathAll07pctprofHigh).HasColumnName("math_all07pctprof_high");

                entity.Property(e => e.MathAll07pctprofLow).HasColumnName("math_all07pctprof_low");

                entity.Property(e => e.MathAll08numvalid).HasColumnName("math_all08numvalid");

                entity.Property(e => e.MathAll08pctprofHigh).HasColumnName("math_all08pctprof_high");

                entity.Property(e => e.MathAll08pctprofLow).HasColumnName("math_all08pctprof_low");

                entity.Property(e => e.MathAllGradesNumvalid).HasColumnName("math_all_grades_numvalid");

                entity.Property(e => e.MathAllGradesPctprofHigh).HasColumnName("math_all_grades_pctprof_high");

                entity.Property(e => e.MathAllGradesPctprofLow).HasColumnName("math_all_grades_pctprof_low");

                entity.Property(e => e.MathAllhsnumvalid).HasColumnName("math_allhsnumvalid");

                entity.Property(e => e.MathAllhspctprofHigh).HasColumnName("math_allhspctprof_high");

                entity.Property(e => e.MathAllhspctprofLow).HasColumnName("math_allhspctprof_low");

                entity.Property(e => e.MathAsianPacificIslander03numvalid).HasColumnName("math_asian_pacific_islander_03numvalid");

                entity.Property(e => e.MathAsianPacificIslander03pctprofHigh).HasColumnName("math_asian_pacific_islander_03pctprof_high");

                entity.Property(e => e.MathAsianPacificIslander03pctprofLow).HasColumnName("math_asian_pacific_islander_03pctprof_low");

                entity.Property(e => e.MathAsianPacificIslander04numvalid).HasColumnName("math_asian_pacific_islander_04numvalid");

                entity.Property(e => e.MathAsianPacificIslander04pctprofHigh).HasColumnName("math_asian_pacific_islander_04pctprof_high");

                entity.Property(e => e.MathAsianPacificIslander04pctprofLow).HasColumnName("math_asian_pacific_islander_04pctprof_low");

                entity.Property(e => e.MathAsianPacificIslander05numvalid).HasColumnName("math_asian_pacific_islander_05numvalid");

                entity.Property(e => e.MathAsianPacificIslander05pctprofHigh).HasColumnName("math_asian_pacific_islander_05pctprof_high");

                entity.Property(e => e.MathAsianPacificIslander05pctprofLow).HasColumnName("math_asian_pacific_islander_05pctprof_low");

                entity.Property(e => e.MathAsianPacificIslander06numvalid).HasColumnName("math_asian_pacific_islander_06numvalid");

                entity.Property(e => e.MathAsianPacificIslander06pctprofHigh).HasColumnName("math_asian_pacific_islander_06pctprof_high");

                entity.Property(e => e.MathAsianPacificIslander06pctprofLow).HasColumnName("math_asian_pacific_islander_06pctprof_low");

                entity.Property(e => e.MathAsianPacificIslander07numvalid).HasColumnName("math_asian_pacific_islander_07numvalid");

                entity.Property(e => e.MathAsianPacificIslander07pctprofHigh).HasColumnName("math_asian_pacific_islander_07pctprof_high");

                entity.Property(e => e.MathAsianPacificIslander07pctprofLow).HasColumnName("math_asian_pacific_islander_07pctprof_low");

                entity.Property(e => e.MathAsianPacificIslander08numvalid).HasColumnName("math_asian_pacific_islander_08numvalid");

                entity.Property(e => e.MathAsianPacificIslander08pctprofHigh).HasColumnName("math_asian_pacific_islander_08pctprof_high");

                entity.Property(e => e.MathAsianPacificIslander08pctprofLow).HasColumnName("math_asian_pacific_islander_08pctprof_low");

                entity.Property(e => e.MathAsianPacificIslanderAllGradesNumvalid).HasColumnName("math_asian_pacific_islander_all_grades_numvalid");

                entity.Property(e => e.MathAsianPacificIslanderAllGradesPctprofHigh).HasColumnName("math_asian_pacific_islander_all_grades_pctprof_high");

                entity.Property(e => e.MathAsianPacificIslanderAllGradesPctprofLow).HasColumnName("math_asian_pacific_islander_all_grades_pctprof_low");

                entity.Property(e => e.MathAsianPacificIslanderHsnumvalid).HasColumnName("math_asian_pacific_islander_hsnumvalid");

                entity.Property(e => e.MathAsianPacificIslanderHspctprofHigh).HasColumnName("math_asian_pacific_islander_hspctprof_high");

                entity.Property(e => e.MathAsianPacificIslanderHspctprofLow).HasColumnName("math_asian_pacific_islander_hspctprof_low");

                entity.Property(e => e.MathBlack03numvalid).HasColumnName("math_black03numvalid");

                entity.Property(e => e.MathBlack03pctprofHigh).HasColumnName("math_black03pctprof_high");

                entity.Property(e => e.MathBlack03pctprofLow).HasColumnName("math_black03pctprof_low");

                entity.Property(e => e.MathBlack04numvalid).HasColumnName("math_black04numvalid");

                entity.Property(e => e.MathBlack04pctprofHigh).HasColumnName("math_black04pctprof_high");

                entity.Property(e => e.MathBlack04pctprofLow).HasColumnName("math_black04pctprof_low");

                entity.Property(e => e.MathBlack05numvalid).HasColumnName("math_black05numvalid");

                entity.Property(e => e.MathBlack05pctprofHigh).HasColumnName("math_black05pctprof_high");

                entity.Property(e => e.MathBlack05pctprofLow).HasColumnName("math_black05pctprof_low");

                entity.Property(e => e.MathBlack06numvalid).HasColumnName("math_black06numvalid");

                entity.Property(e => e.MathBlack06pctprofHigh).HasColumnName("math_black06pctprof_high");

                entity.Property(e => e.MathBlack06pctprofLow).HasColumnName("math_black06pctprof_low");

                entity.Property(e => e.MathBlack07numvalid).HasColumnName("math_black07numvalid");

                entity.Property(e => e.MathBlack07pctprofHigh).HasColumnName("math_black07pctprof_high");

                entity.Property(e => e.MathBlack07pctprofLow).HasColumnName("math_black07pctprof_low");

                entity.Property(e => e.MathBlack08numvalid).HasColumnName("math_black08numvalid");

                entity.Property(e => e.MathBlack08pctprofHigh).HasColumnName("math_black08pctprof_high");

                entity.Property(e => e.MathBlack08pctprofLow).HasColumnName("math_black08pctprof_low");

                entity.Property(e => e.MathBlackAllGradesNumvalid).HasColumnName("math_black_all_grades_numvalid");

                entity.Property(e => e.MathBlackAllGradesPctprofHigh).HasColumnName("math_black_all_grades_pctprof_high");

                entity.Property(e => e.MathBlackAllGradesPctprofLow).HasColumnName("math_black_all_grades_pctprof_low");

                entity.Property(e => e.MathBlackhsnumvalid).HasColumnName("math_blackhsnumvalid");

                entity.Property(e => e.MathBlackhspctprofHigh).HasColumnName("math_blackhspctprof_high");

                entity.Property(e => e.MathBlackhspctprofLow).HasColumnName("math_blackhspctprof_low");

                entity.Property(e => e.MathChildrenWithDisabilites03numvalid).HasColumnName("math_children_with_disabilites03numvalid");

                entity.Property(e => e.MathChildrenWithDisabilites03pctprofHigh).HasColumnName("math_children_with_disabilites03pctprof_high");

                entity.Property(e => e.MathChildrenWithDisabilites03pctprofLow).HasColumnName("math_children_with_disabilites03pctprof_low");

                entity.Property(e => e.MathChildrenWithDisabilites04numvalid).HasColumnName("math_children_with_disabilites04numvalid");

                entity.Property(e => e.MathChildrenWithDisabilites04pctprofHigh).HasColumnName("math_children_with_disabilites04pctprof_high");

                entity.Property(e => e.MathChildrenWithDisabilites04pctprofLow).HasColumnName("math_children_with_disabilites04pctprof_low");

                entity.Property(e => e.MathChildrenWithDisabilites05numvalid).HasColumnName("math_children_with_disabilites05numvalid");

                entity.Property(e => e.MathChildrenWithDisabilites05pctprofHigh).HasColumnName("math_children_with_disabilites05pctprof_high");

                entity.Property(e => e.MathChildrenWithDisabilites05pctprofLow).HasColumnName("math_children_with_disabilites05pctprof_low");

                entity.Property(e => e.MathChildrenWithDisabilites06numvalid).HasColumnName("math_children_with_disabilites06numvalid");

                entity.Property(e => e.MathChildrenWithDisabilites06pctprofHigh).HasColumnName("math_children_with_disabilites06pctprof_high");

                entity.Property(e => e.MathChildrenWithDisabilites06pctprofLow).HasColumnName("math_children_with_disabilites06pctprof_low");

                entity.Property(e => e.MathChildrenWithDisabilites07numvalid).HasColumnName("math_children_with_disabilites07numvalid");

                entity.Property(e => e.MathChildrenWithDisabilites07pctprofHigh).HasColumnName("math_children_with_disabilites07pctprof_high");

                entity.Property(e => e.MathChildrenWithDisabilites07pctprofLow).HasColumnName("math_children_with_disabilites07pctprof_low");

                entity.Property(e => e.MathChildrenWithDisabilites08numvalid).HasColumnName("math_children_with_disabilites08numvalid");

                entity.Property(e => e.MathChildrenWithDisabilites08pctprofHigh).HasColumnName("math_children_with_disabilites08pctprof_high");

                entity.Property(e => e.MathChildrenWithDisabilites08pctprofLow).HasColumnName("math_children_with_disabilites08pctprof_low");

                entity.Property(e => e.MathChildrenWithDisabilitesAllGradesNumvalid).HasColumnName("math_children_with_disabilites_all_grades_numvalid");

                entity.Property(e => e.MathChildrenWithDisabilitesAllGradesPctprofHigh).HasColumnName("math_children_with_disabilites_all_grades_pctprof_high");

                entity.Property(e => e.MathChildrenWithDisabilitesAllGradesPctprofLow).HasColumnName("math_children_with_disabilites_all_grades_pctprof_low");

                entity.Property(e => e.MathChildrenWithDisabiliteshsnumvalid).HasColumnName("math_children_with_disabiliteshsnumvalid");

                entity.Property(e => e.MathChildrenWithDisabiliteshspctprofHigh).HasColumnName("math_children_with_disabiliteshspctprof_high");

                entity.Property(e => e.MathChildrenWithDisabiliteshspctprofLow).HasColumnName("math_children_with_disabiliteshspctprof_low");

                entity.Property(e => e.MathF03numvalid).HasColumnName("math_f03numvalid");

                entity.Property(e => e.MathF03pctprofHigh).HasColumnName("math_f03pctprof_high");

                entity.Property(e => e.MathF03pctprofLow).HasColumnName("math_f03pctprof_low");

                entity.Property(e => e.MathF04numvalid).HasColumnName("math_f04numvalid");

                entity.Property(e => e.MathF04pctprofHigh).HasColumnName("math_f04pctprof_high");

                entity.Property(e => e.MathF04pctprofLow).HasColumnName("math_f04pctprof_low");

                entity.Property(e => e.MathF05numvalid).HasColumnName("math_f05numvalid");

                entity.Property(e => e.MathF05pctprofHigh).HasColumnName("math_f05pctprof_high");

                entity.Property(e => e.MathF05pctprofLow).HasColumnName("math_f05pctprof_low");

                entity.Property(e => e.MathF06numvalid).HasColumnName("math_f06numvalid");

                entity.Property(e => e.MathF06pctprofHigh).HasColumnName("math_f06pctprof_high");

                entity.Property(e => e.MathF06pctprofLow).HasColumnName("math_f06pctprof_low");

                entity.Property(e => e.MathF07numvalid).HasColumnName("math_f07numvalid");

                entity.Property(e => e.MathF07pctprofHigh).HasColumnName("math_f07pctprof_high");

                entity.Property(e => e.MathF07pctprofLow).HasColumnName("math_f07pctprof_low");

                entity.Property(e => e.MathF08numvalid).HasColumnName("math_f08numvalid");

                entity.Property(e => e.MathF08pctprofHigh).HasColumnName("math_f08pctprof_high");

                entity.Property(e => e.MathF08pctprofLow).HasColumnName("math_f08pctprof_low");

                entity.Property(e => e.MathFAllGradesNumvalid).HasColumnName("math_f_all_grades_numvalid");

                entity.Property(e => e.MathFAllGradesPctprofHigh).HasColumnName("math_f_all_grades_pctprof_high");

                entity.Property(e => e.MathFAllGradesPctprofLow).HasColumnName("math_f_all_grades_pctprof_low");

                entity.Property(e => e.MathFhsnumvalid).HasColumnName("math_fhsnumvalid");

                entity.Property(e => e.MathFhspctprofHigh).HasColumnName("math_fhspctprof_high");

                entity.Property(e => e.MathFhspctprofLow).HasColumnName("math_fhspctprof_low");

                entity.Property(e => e.MathFipst).HasColumnName("math_fipst");

                entity.Property(e => e.MathHispanic03numvalid).HasColumnName("math_hispanic03numvalid");

                entity.Property(e => e.MathHispanic03pctprofHigh).HasColumnName("math_hispanic03pctprof_high");

                entity.Property(e => e.MathHispanic03pctprofLow).HasColumnName("math_hispanic03pctprof_low");

                entity.Property(e => e.MathHispanic04numvalid).HasColumnName("math_hispanic04numvalid");

                entity.Property(e => e.MathHispanic04pctprofHigh).HasColumnName("math_hispanic04pctprof_high");

                entity.Property(e => e.MathHispanic04pctprofLow).HasColumnName("math_hispanic04pctprof_low");

                entity.Property(e => e.MathHispanic05numvalid).HasColumnName("math_hispanic05numvalid");

                entity.Property(e => e.MathHispanic05pctprofHigh).HasColumnName("math_hispanic05pctprof_high");

                entity.Property(e => e.MathHispanic05pctprofLow).HasColumnName("math_hispanic05pctprof_low");

                entity.Property(e => e.MathHispanic06numvalid).HasColumnName("math_hispanic06numvalid");

                entity.Property(e => e.MathHispanic06pctprofHigh).HasColumnName("math_hispanic06pctprof_high");

                entity.Property(e => e.MathHispanic06pctprofLow).HasColumnName("math_hispanic06pctprof_low");

                entity.Property(e => e.MathHispanic07numvalid).HasColumnName("math_hispanic07numvalid");

                entity.Property(e => e.MathHispanic07pctprofHigh).HasColumnName("math_hispanic07pctprof_high");

                entity.Property(e => e.MathHispanic07pctprofLow).HasColumnName("math_hispanic07pctprof_low");

                entity.Property(e => e.MathHispanic08numvalid).HasColumnName("math_hispanic08numvalid");

                entity.Property(e => e.MathHispanic08pctprofHigh).HasColumnName("math_hispanic08pctprof_high");

                entity.Property(e => e.MathHispanic08pctprofLow).HasColumnName("math_hispanic08pctprof_low");

                entity.Property(e => e.MathHispanicAllGradesNumvalid).HasColumnName("math_hispanic_all_grades_numvalid");

                entity.Property(e => e.MathHispanicAllGradesPctprofLow).HasColumnName("math_hispanic_all_grades_pctprof_low");

                entity.Property(e => e.MathHispanichsnumvalid).HasColumnName("math_hispanichsnumvalid");

                entity.Property(e => e.MathHomeless03numvalid).HasColumnName("math_homeless03numvalid");

                entity.Property(e => e.MathHomeless04numvalid).HasColumnName("math_homeless04numvalid");

                entity.Property(e => e.MathHomeless05numvalid).HasColumnName("math_homeless05numvalid");

                entity.Property(e => e.MathHomeless06numvalid).HasColumnName("math_homeless06numvalid");

                entity.Property(e => e.MathHomeless07numvalid).HasColumnName("math_homeless07numvalid");

                entity.Property(e => e.MathHomeless08numvalid).HasColumnName("math_homeless08numvalid");

                entity.Property(e => e.MathHomelessAllGradesNumvalid).HasColumnName("math_homeless_all_grades_numvalid");

                entity.Property(e => e.MathHomelesshsnumvalid).HasColumnName("math_homelesshsnumvalid");

                entity.Property(e => e.MathLeaid).HasColumnName("math_leaid");

                entity.Property(e => e.MathLeanm).HasColumnName("math_leanm");

                entity.Property(e => e.MathLimitedEnglish03numvalid).HasColumnName("math_limited_english03numvalid");

                entity.Property(e => e.MathLimitedEnglish04numvalid).HasColumnName("math_limited_english04numvalid");

                entity.Property(e => e.MathLimitedEnglish05numvalid).HasColumnName("math_limited_english05numvalid");

                entity.Property(e => e.MathLimitedEnglish06numvalid).HasColumnName("math_limited_english06numvalid");

                entity.Property(e => e.MathLimitedEnglish07numvalid).HasColumnName("math_limited_english07numvalid");

                entity.Property(e => e.MathLimitedEnglish08numvalid).HasColumnName("math_limited_english08numvalid");

                entity.Property(e => e.MathLimitedEnglishAllGradesNumvalid).HasColumnName("math_limited_english_all_grades_numvalid");

                entity.Property(e => e.MathLimitedEnglishhsnumvalid).HasColumnName("math_limited_englishhsnumvalid");

                entity.Property(e => e.MathM03numvalid).HasColumnName("math_m03numvalid");

                entity.Property(e => e.MathM04numvalid).HasColumnName("math_m04numvalid");

                entity.Property(e => e.MathM05numvalid).HasColumnName("math_m05numvalid");

                entity.Property(e => e.MathM06numvalid).HasColumnName("math_m06numvalid");

                entity.Property(e => e.MathM07numvalid).HasColumnName("math_m07numvalid");

                entity.Property(e => e.MathM08numvalid).HasColumnName("math_m08numvalid");

                entity.Property(e => e.MathMAllGradesNumvalid).HasColumnName("math_m_all_grades_numvalid");

                entity.Property(e => e.MathMhsnumvalid).HasColumnName("math_mhsnumvalid");

                entity.Property(e => e.MathMigrant03numvalid).HasColumnName("math_migrant03numvalid");

                entity.Property(e => e.MathMigrant04numvalid).HasColumnName("math_migrant04numvalid");

                entity.Property(e => e.MathMigrant05numvalid).HasColumnName("math_migrant05numvalid");

                entity.Property(e => e.MathMigrant06numvalid).HasColumnName("math_migrant06numvalid");

                entity.Property(e => e.MathMigrant07numvalid).HasColumnName("math_migrant07numvalid");

                entity.Property(e => e.MathMigrant08numvalid).HasColumnName("math_migrant08numvalid");

                entity.Property(e => e.MathMigrantAllGradesNumvalid).HasColumnName("math_migrant_all_grades_numvalid");

                entity.Property(e => e.MathMigranthsnumvalid).HasColumnName("math_migranthsnumvalid");

                entity.Property(e => e.MathMoreThanTwoRaces03numvalid).HasColumnName("math_more_than_two_races03numvalid");

                entity.Property(e => e.MathMoreThanTwoRaces04numvalid).HasColumnName("math_more_than_two_races04numvalid");

                entity.Property(e => e.MathMoreThanTwoRaces05numvalid).HasColumnName("math_more_than_two_races05numvalid");

                entity.Property(e => e.MathMoreThanTwoRaces06numvalid).HasColumnName("math_more_than_two_races06numvalid");

                entity.Property(e => e.MathMoreThanTwoRaces07numvalid).HasColumnName("math_more_than_two_races07numvalid");

                entity.Property(e => e.MathMoreThanTwoRaces08numvalid).HasColumnName("math_more_than_two_races08numvalid");

                entity.Property(e => e.MathMoreThanTwoRacesAllGradesNumvalid).HasColumnName("math_more_than_two_races_all_grades_numvalid");

                entity.Property(e => e.MathMoreThanTwoRaceshsnumvalid).HasColumnName("math_more_than_two_raceshsnumvalid");

                entity.Property(e => e.MathNativeAmerican03numvalid).HasColumnName("math_native_american03numvalid");

                entity.Property(e => e.MathNativeAmerican04numvalid).HasColumnName("math_native_american04numvalid");

                entity.Property(e => e.MathNativeAmerican05numvalid).HasColumnName("math_native_american05numvalid");

                entity.Property(e => e.MathNativeAmerican06numvalid).HasColumnName("math_native_american06numvalid");

                entity.Property(e => e.MathNativeAmerican07numvalid).HasColumnName("math_native_american07numvalid");

                entity.Property(e => e.MathNativeAmerican08numvalid).HasColumnName("math_native_american08numvalid");

                entity.Property(e => e.MathNativeAmericanAllGradesNumvalid).HasColumnName("math_native_american_all_grades_numvalid");

                entity.Property(e => e.MathNativeAmericanhsnumvalid).HasColumnName("math_native_americanhsnumvalid");

                entity.Property(e => e.MathPoor03numvalid).HasColumnName("math_poor03numvalid");

                entity.Property(e => e.MathPoor04numvalid).HasColumnName("math_poor04numvalid");

                entity.Property(e => e.MathPoor05numvalid).HasColumnName("math_poor05numvalid");

                entity.Property(e => e.MathPoor06numvalid).HasColumnName("math_poor06numvalid");

                entity.Property(e => e.MathPoor07numvalid).HasColumnName("math_poor07numvalid");

                entity.Property(e => e.MathPoor08numvalid).HasColumnName("math_poor08numvalid");

                entity.Property(e => e.MathPoorAllGradesNumvalid).HasColumnName("math_poor_all_grades_numvalid");

                entity.Property(e => e.MathPoorhsnumvalid).HasColumnName("math_poorhsnumvalid");

                entity.Property(e => e.MathSchnam).HasColumnName("math_schnam");

                entity.Property(e => e.MathStLeaid).HasColumnName("math_st_leaid");

                entity.Property(e => e.MathStSchid).HasColumnName("math_st_schid");

                entity.Property(e => e.MathStnam).HasColumnName("math_stnam");

                entity.Property(e => e.MathWhite03numvalid).HasColumnName("math_white03numvalid");

                entity.Property(e => e.MathWhite04numvalid).HasColumnName("math_white04numvalid");

                entity.Property(e => e.MathWhite05numvalid).HasColumnName("math_white05numvalid");

                entity.Property(e => e.MathWhite06numvalid).HasColumnName("math_white06numvalid");

                entity.Property(e => e.MathWhite07numvalid).HasColumnName("math_white07numvalid");

                entity.Property(e => e.MathWhite08numvalid).HasColumnName("math_white08numvalid");

                entity.Property(e => e.MathWhiteAllGradesNumvalid).HasColumnName("math_white_all_grades_numvalid");

                entity.Property(e => e.MathWhitehsnumvalid).HasColumnName("math_whitehsnumvalid");
            });

            modelBuilder.Entity<Read>(entity =>
            {
                entity.HasKey(e => e.ReadNcessch)
                    .HasName("read_pkey");

                entity.ToTable("read");

                entity.Property(e => e.ReadNcessch)
                    .HasColumnName("read_ncessch")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReadAll03numvalid).HasColumnName("read_all03numvalid");

                entity.Property(e => e.ReadAll03pctprofHigh).HasColumnName("read_all03pctprof_high");

                entity.Property(e => e.ReadAll03pctprofLow).HasColumnName("read_all03pctprof_low");

                entity.Property(e => e.ReadAll04numvalid).HasColumnName("read_all04numvalid");

                entity.Property(e => e.ReadAll04pctprofHigh).HasColumnName("read_all04pctprof_high");

                entity.Property(e => e.ReadAll04pctprofLow).HasColumnName("read_all04pctprof_low");

                entity.Property(e => e.ReadAll05numvalid).HasColumnName("read_all05numvalid");

                entity.Property(e => e.ReadAll05pctprofHigh).HasColumnName("read_all05pctprof_high");

                entity.Property(e => e.ReadAll05pctprofLow).HasColumnName("read_all05pctprof_low");

                entity.Property(e => e.ReadAll06numvalid).HasColumnName("read_all06numvalid");

                entity.Property(e => e.ReadAll06pctprofHigh).HasColumnName("read_all06pctprof_high");

                entity.Property(e => e.ReadAll06pctprofLow).HasColumnName("read_all06pctprof_low");

                entity.Property(e => e.ReadAll07numvalid).HasColumnName("read_all07numvalid");

                entity.Property(e => e.ReadAll07pctprofHigh).HasColumnName("read_all07pctprof_high");

                entity.Property(e => e.ReadAll07pctprofLow).HasColumnName("read_all07pctprof_low");

                entity.Property(e => e.ReadAll08numvalid).HasColumnName("read_all08numvalid");

                entity.Property(e => e.ReadAll08pctprofHigh).HasColumnName("read_all08pctprof_high");

                entity.Property(e => e.ReadAll08pctprofLow).HasColumnName("read_all08pctprof_low");

                entity.Property(e => e.ReadAllGradesNumvalid).HasColumnName("read_all_grades_numvalid");

                entity.Property(e => e.ReadAllGradesPctprofHigh).HasColumnName("read_all_grades_pctprof_high");

                entity.Property(e => e.ReadAllGradesPctprofLow).HasColumnName("read_all_grades_pctprof_low");

                entity.Property(e => e.ReadAllhsnumvalid).HasColumnName("read_allhsnumvalid");

                entity.Property(e => e.ReadAllhspctprofHigh).HasColumnName("read_allhspctprof_high");

                entity.Property(e => e.ReadAllhspctprofLow).HasColumnName("read_allhspctprof_low");

                entity.Property(e => e.ReadAsianPacificIslander03numvalid).HasColumnName("read_asian_pacific_islander_03numvalid");

                entity.Property(e => e.ReadAsianPacificIslander03pctprofHigh).HasColumnName("read_asian_pacific_islander_03pctprof_high");

                entity.Property(e => e.ReadAsianPacificIslander03pctprofLow).HasColumnName("read_asian_pacific_islander_03pctprof_low");

                entity.Property(e => e.ReadAsianPacificIslander04numvalid).HasColumnName("read_asian_pacific_islander_04numvalid");

                entity.Property(e => e.ReadAsianPacificIslander04pctprofHigh).HasColumnName("read_asian_pacific_islander_04pctprof_high");

                entity.Property(e => e.ReadAsianPacificIslander04pctprofLow).HasColumnName("read_asian_pacific_islander_04pctprof_low");

                entity.Property(e => e.ReadAsianPacificIslander05numvalid).HasColumnName("read_asian_pacific_islander_05numvalid");

                entity.Property(e => e.ReadAsianPacificIslander05pctprofHigh).HasColumnName("read_asian_pacific_islander_05pctprof_high");

                entity.Property(e => e.ReadAsianPacificIslander05pctprofLow).HasColumnName("read_asian_pacific_islander_05pctprof_low");

                entity.Property(e => e.ReadAsianPacificIslander06numvalid).HasColumnName("read_asian_pacific_islander_06numvalid");

                entity.Property(e => e.ReadAsianPacificIslander06pctprofHigh).HasColumnName("read_asian_pacific_islander_06pctprof_high");

                entity.Property(e => e.ReadAsianPacificIslander06pctprofLow).HasColumnName("read_asian_pacific_islander_06pctprof_low");

                entity.Property(e => e.ReadAsianPacificIslander07numvalid).HasColumnName("read_asian_pacific_islander_07numvalid");

                entity.Property(e => e.ReadAsianPacificIslander07pctprofHigh).HasColumnName("read_asian_pacific_islander_07pctprof_high");

                entity.Property(e => e.ReadAsianPacificIslander07pctprofLow).HasColumnName("read_asian_pacific_islander_07pctprof_low");

                entity.Property(e => e.ReadAsianPacificIslander08numvalid).HasColumnName("read_asian_pacific_islander_08numvalid");

                entity.Property(e => e.ReadAsianPacificIslander08pctprofHigh).HasColumnName("read_asian_pacific_islander_08pctprof_high");

                entity.Property(e => e.ReadAsianPacificIslander08pctprofLow).HasColumnName("read_asian_pacific_islander_08pctprof_low");

                entity.Property(e => e.ReadAsianPacificIslanderAllGradesNumvalid).HasColumnName("read_asian_pacific_islander_all_grades_numvalid");

                entity.Property(e => e.ReadAsianPacificIslanderAllGradesPctprofHigh).HasColumnName("read_asian_pacific_islander_all_grades_pctprof_high");

                entity.Property(e => e.ReadAsianPacificIslanderAllGradesPctprofLow).HasColumnName("read_asian_pacific_islander_all_grades_pctprof_low");

                entity.Property(e => e.ReadAsianPacificIslanderHsnumvalid).HasColumnName("read_asian_pacific_islander_hsnumvalid");

                entity.Property(e => e.ReadAsianPacificIslanderHspctprofHigh).HasColumnName("read_asian_pacific_islander_hspctprof_high");

                entity.Property(e => e.ReadAsianPacificIslanderHspctprofLow).HasColumnName("read_asian_pacific_islander_hspctprof_low");

                entity.Property(e => e.ReadBlack03numvalid).HasColumnName("read_black03numvalid");

                entity.Property(e => e.ReadBlack03pctprofHigh).HasColumnName("read_black03pctprof_high");

                entity.Property(e => e.ReadBlack03pctprofLow).HasColumnName("read_black03pctprof_low");

                entity.Property(e => e.ReadBlack04numvalid).HasColumnName("read_black04numvalid");

                entity.Property(e => e.ReadBlack04pctprofHigh).HasColumnName("read_black04pctprof_high");

                entity.Property(e => e.ReadBlack04pctprofLow).HasColumnName("read_black04pctprof_low");

                entity.Property(e => e.ReadBlack05numvalid).HasColumnName("read_black05numvalid");

                entity.Property(e => e.ReadBlack05pctprofHigh).HasColumnName("read_black05pctprof_high");

                entity.Property(e => e.ReadBlack05pctprofLow).HasColumnName("read_black05pctprof_low");

                entity.Property(e => e.ReadBlack06numvalid).HasColumnName("read_black06numvalid");

                entity.Property(e => e.ReadBlack06pctprofHigh).HasColumnName("read_black06pctprof_high");

                entity.Property(e => e.ReadBlack06pctprofLow).HasColumnName("read_black06pctprof_low");

                entity.Property(e => e.ReadBlack07numvalid).HasColumnName("read_black07numvalid");

                entity.Property(e => e.ReadBlack07pctprofHigh).HasColumnName("read_black07pctprof_high");

                entity.Property(e => e.ReadBlack07pctprofLow).HasColumnName("read_black07pctprof_low");

                entity.Property(e => e.ReadBlack08numvalid).HasColumnName("read_black08numvalid");

                entity.Property(e => e.ReadBlack08pctprofHigh).HasColumnName("read_black08pctprof_high");

                entity.Property(e => e.ReadBlack08pctprofLow).HasColumnName("read_black08pctprof_low");

                entity.Property(e => e.ReadBlackAllGradesNumvalid).HasColumnName("read_black_all_grades_numvalid");

                entity.Property(e => e.ReadBlackAllGradesPctprofHigh).HasColumnName("read_black_all_grades_pctprof_high");

                entity.Property(e => e.ReadBlackAllGradesPctprofLow).HasColumnName("read_black_all_grades_pctprof_low");

                entity.Property(e => e.ReadBlackhsnumvalid).HasColumnName("read_blackhsnumvalid");

                entity.Property(e => e.ReadBlackhspctprofHigh).HasColumnName("read_blackhspctprof_high");

                entity.Property(e => e.ReadBlackhspctprofLow).HasColumnName("read_blackhspctprof_low");

                entity.Property(e => e.ReadChildrenWithDisabilites03numvalid).HasColumnName("read_children_with_disabilites03numvalid");

                entity.Property(e => e.ReadChildrenWithDisabilites03pctprofHigh).HasColumnName("read_children_with_disabilites03pctprof_high");

                entity.Property(e => e.ReadChildrenWithDisabilites03pctprofLow).HasColumnName("read_children_with_disabilites03pctprof_low");

                entity.Property(e => e.ReadChildrenWithDisabilites04numvalid).HasColumnName("read_children_with_disabilites04numvalid");

                entity.Property(e => e.ReadChildrenWithDisabilites04pctprofHigh).HasColumnName("read_children_with_disabilites04pctprof_high");

                entity.Property(e => e.ReadChildrenWithDisabilites04pctprofLow).HasColumnName("read_children_with_disabilites04pctprof_low");

                entity.Property(e => e.ReadChildrenWithDisabilites05numvalid).HasColumnName("read_children_with_disabilites05numvalid");

                entity.Property(e => e.ReadChildrenWithDisabilites05pctprofHigh).HasColumnName("read_children_with_disabilites05pctprof_high");

                entity.Property(e => e.ReadChildrenWithDisabilites05pctprofLow).HasColumnName("read_children_with_disabilites05pctprof_low");

                entity.Property(e => e.ReadChildrenWithDisabilites06numvalid).HasColumnName("read_children_with_disabilites06numvalid");

                entity.Property(e => e.ReadChildrenWithDisabilites06pctprofHigh).HasColumnName("read_children_with_disabilites06pctprof_high");

                entity.Property(e => e.ReadChildrenWithDisabilites06pctprofLow).HasColumnName("read_children_with_disabilites06pctprof_low");

                entity.Property(e => e.ReadChildrenWithDisabilites07numvalid).HasColumnName("read_children_with_disabilites07numvalid");

                entity.Property(e => e.ReadChildrenWithDisabilites07pctprofHigh).HasColumnName("read_children_with_disabilites07pctprof_high");

                entity.Property(e => e.ReadChildrenWithDisabilites07pctprofLow).HasColumnName("read_children_with_disabilites07pctprof_low");

                entity.Property(e => e.ReadChildrenWithDisabilites08numvalid).HasColumnName("read_children_with_disabilites08numvalid");

                entity.Property(e => e.ReadChildrenWithDisabilites08pctprofHigh).HasColumnName("read_children_with_disabilites08pctprof_high");

                entity.Property(e => e.ReadChildrenWithDisabilites08pctprofLow).HasColumnName("read_children_with_disabilites08pctprof_low");

                entity.Property(e => e.ReadChildrenWithDisabilitesAllGradesNumvalid).HasColumnName("read_children_with_disabilites_all_grades_numvalid");

                entity.Property(e => e.ReadChildrenWithDisabilitesAllGradesPctprofHigh).HasColumnName("read_children_with_disabilites_all_grades_pctprof_high");

                entity.Property(e => e.ReadChildrenWithDisabilitesAllGradesPctprofLow).HasColumnName("read_children_with_disabilites_all_grades_pctprof_low");

                entity.Property(e => e.ReadChildrenWithDisabiliteshsnumvalid).HasColumnName("read_children_with_disabiliteshsnumvalid");

                entity.Property(e => e.ReadChildrenWithDisabiliteshspctprofHigh).HasColumnName("read_children_with_disabiliteshspctprof_high");

                entity.Property(e => e.ReadChildrenWithDisabiliteshspctprofLow).HasColumnName("read_children_with_disabiliteshspctprof_low");

                entity.Property(e => e.ReadF03numvalid).HasColumnName("read_f03numvalid");

                entity.Property(e => e.ReadF03pctprofHigh).HasColumnName("read_f03pctprof_high");

                entity.Property(e => e.ReadF03pctprofLow).HasColumnName("read_f03pctprof_low");

                entity.Property(e => e.ReadF04numvalid).HasColumnName("read_f04numvalid");

                entity.Property(e => e.ReadF04pctprofHigh).HasColumnName("read_f04pctprof_high");

                entity.Property(e => e.ReadF04pctprofLow).HasColumnName("read_f04pctprof_low");

                entity.Property(e => e.ReadF05numvalid).HasColumnName("read_f05numvalid");

                entity.Property(e => e.ReadF05pctprofHigh).HasColumnName("read_f05pctprof_high");

                entity.Property(e => e.ReadF05pctprofLow).HasColumnName("read_f05pctprof_low");

                entity.Property(e => e.ReadF06numvalid).HasColumnName("read_f06numvalid");

                entity.Property(e => e.ReadF06pctprofHigh).HasColumnName("read_f06pctprof_high");

                entity.Property(e => e.ReadF06pctprofLow).HasColumnName("read_f06pctprof_low");

                entity.Property(e => e.ReadF07numvalid).HasColumnName("read_f07numvalid");

                entity.Property(e => e.ReadF07pctprofHigh).HasColumnName("read_f07pctprof_high");

                entity.Property(e => e.ReadF07pctprofLow).HasColumnName("read_f07pctprof_low");

                entity.Property(e => e.ReadF08numvalid).HasColumnName("read_f08numvalid");

                entity.Property(e => e.ReadF08pctprofHigh).HasColumnName("read_f08pctprof_high");

                entity.Property(e => e.ReadF08pctprofLow).HasColumnName("read_f08pctprof_low");

                entity.Property(e => e.ReadFAllGradesNumvalid).HasColumnName("read_f_all_grades_numvalid");

                entity.Property(e => e.ReadFAllGradesPctprofHigh).HasColumnName("read_f_all_grades_pctprof_high");

                entity.Property(e => e.ReadFAllGradesPctprofLow).HasColumnName("read_f_all_grades_pctprof_low");

                entity.Property(e => e.ReadFhsnumvalid).HasColumnName("read_fhsnumvalid");

                entity.Property(e => e.ReadFhspctprofHigh).HasColumnName("read_fhspctprof_high");

                entity.Property(e => e.ReadFhspctprofLow).HasColumnName("read_fhspctprof_low");

                entity.Property(e => e.ReadFipst).HasColumnName("read_fipst");

                entity.Property(e => e.ReadHispanic03numvalid).HasColumnName("read_hispanic03numvalid");

                entity.Property(e => e.ReadHispanic03pctprofHigh).HasColumnName("read_hispanic03pctprof_high");

                entity.Property(e => e.ReadHispanic03pctprofLow).HasColumnName("read_hispanic03pctprof_low");

                entity.Property(e => e.ReadHispanic04numvalid).HasColumnName("read_hispanic04numvalid");

                entity.Property(e => e.ReadHispanic04pctprofHigh).HasColumnName("read_hispanic04pctprof_high");

                entity.Property(e => e.ReadHispanic04pctprofLow).HasColumnName("read_hispanic04pctprof_low");

                entity.Property(e => e.ReadHispanic05numvalid).HasColumnName("read_hispanic05numvalid");

                entity.Property(e => e.ReadHispanic05pctprofHigh).HasColumnName("read_hispanic05pctprof_high");

                entity.Property(e => e.ReadHispanic05pctprofLow).HasColumnName("read_hispanic05pctprof_low");

                entity.Property(e => e.ReadHispanic06numvalid).HasColumnName("read_hispanic06numvalid");

                entity.Property(e => e.ReadHispanic06pctprofHigh).HasColumnName("read_hispanic06pctprof_high");

                entity.Property(e => e.ReadHispanic06pctprofLow).HasColumnName("read_hispanic06pctprof_low");

                entity.Property(e => e.ReadHispanic07numvalid).HasColumnName("read_hispanic07numvalid");

                entity.Property(e => e.ReadHispanic07pctprofHigh).HasColumnName("read_hispanic07pctprof_high");

                entity.Property(e => e.ReadHispanic07pctprofLow).HasColumnName("read_hispanic07pctprof_low");

                entity.Property(e => e.ReadHispanic08numvalid).HasColumnName("read_hispanic08numvalid");

                entity.Property(e => e.ReadHispanic08pctprofHigh).HasColumnName("read_hispanic08pctprof_high");

                entity.Property(e => e.ReadHispanic08pctprofLow).HasColumnName("read_hispanic08pctprof_low");

                entity.Property(e => e.ReadHispanicAllGradesNumvalid).HasColumnName("read_hispanic_all_grades_numvalid");

                entity.Property(e => e.ReadHispanicAllGradesPctprofLow).HasColumnName("read_hispanic_all_grades_pctprof_low");

                entity.Property(e => e.ReadHispanichsnumvalid).HasColumnName("read_hispanichsnumvalid");

                entity.Property(e => e.ReadHomeless03numvalid).HasColumnName("read_homeless03numvalid");

                entity.Property(e => e.ReadHomeless04numvalid).HasColumnName("read_homeless04numvalid");

                entity.Property(e => e.ReadHomeless05numvalid).HasColumnName("read_homeless05numvalid");

                entity.Property(e => e.ReadHomeless06numvalid).HasColumnName("read_homeless06numvalid");

                entity.Property(e => e.ReadHomeless07numvalid).HasColumnName("read_homeless07numvalid");

                entity.Property(e => e.ReadHomeless08numvalid).HasColumnName("read_homeless08numvalid");

                entity.Property(e => e.ReadHomelessAllGradesNumvalid).HasColumnName("read_homeless_all_grades_numvalid");

                entity.Property(e => e.ReadHomelesshsnumvalid).HasColumnName("read_homelesshsnumvalid");

                entity.Property(e => e.ReadLeaid).HasColumnName("read_leaid");

                entity.Property(e => e.ReadLeanm).HasColumnName("read_leanm");

                entity.Property(e => e.ReadLimitedEnglish03numvalid).HasColumnName("read_limited_english03numvalid");

                entity.Property(e => e.ReadLimitedEnglish04numvalid).HasColumnName("read_limited_english04numvalid");

                entity.Property(e => e.ReadLimitedEnglish05numvalid).HasColumnName("read_limited_english05numvalid");

                entity.Property(e => e.ReadLimitedEnglish06numvalid).HasColumnName("read_limited_english06numvalid");

                entity.Property(e => e.ReadLimitedEnglish07numvalid).HasColumnName("read_limited_english07numvalid");

                entity.Property(e => e.ReadLimitedEnglish08numvalid).HasColumnName("read_limited_english08numvalid");

                entity.Property(e => e.ReadLimitedEnglishAllGradesNumvalid).HasColumnName("read_limited_english_all_grades_numvalid");

                entity.Property(e => e.ReadLimitedEnglishhsnumvalid).HasColumnName("read_limited_englishhsnumvalid");

                entity.Property(e => e.ReadM03numvalid).HasColumnName("read_m03numvalid");

                entity.Property(e => e.ReadM04numvalid).HasColumnName("read_m04numvalid");

                entity.Property(e => e.ReadM05numvalid).HasColumnName("read_m05numvalid");

                entity.Property(e => e.ReadM06numvalid).HasColumnName("read_m06numvalid");

                entity.Property(e => e.ReadM07numvalid).HasColumnName("read_m07numvalid");

                entity.Property(e => e.ReadM08numvalid).HasColumnName("read_m08numvalid");

                entity.Property(e => e.ReadMAllGradesNumvalid).HasColumnName("read_m_all_grades_numvalid");

                entity.Property(e => e.ReadMhsnumvalid).HasColumnName("read_mhsnumvalid");

                entity.Property(e => e.ReadMigrant03numvalid).HasColumnName("read_migrant03numvalid");

                entity.Property(e => e.ReadMigrant04numvalid).HasColumnName("read_migrant04numvalid");

                entity.Property(e => e.ReadMigrant05numvalid).HasColumnName("read_migrant05numvalid");

                entity.Property(e => e.ReadMigrant06numvalid).HasColumnName("read_migrant06numvalid");

                entity.Property(e => e.ReadMigrant07numvalid).HasColumnName("read_migrant07numvalid");

                entity.Property(e => e.ReadMigrant08numvalid).HasColumnName("read_migrant08numvalid");

                entity.Property(e => e.ReadMigrantAllGradesNumvalid).HasColumnName("read_migrant_all_grades_numvalid");

                entity.Property(e => e.ReadMigranthsnumvalid).HasColumnName("read_migranthsnumvalid");

                entity.Property(e => e.ReadMoreThanTwoRaces03numvalid).HasColumnName("read_more_than_two_races03numvalid");

                entity.Property(e => e.ReadMoreThanTwoRaces04numvalid).HasColumnName("read_more_than_two_races04numvalid");

                entity.Property(e => e.ReadMoreThanTwoRaces05numvalid).HasColumnName("read_more_than_two_races05numvalid");

                entity.Property(e => e.ReadMoreThanTwoRaces06numvalid).HasColumnName("read_more_than_two_races06numvalid");

                entity.Property(e => e.ReadMoreThanTwoRaces07numvalid).HasColumnName("read_more_than_two_races07numvalid");

                entity.Property(e => e.ReadMoreThanTwoRaces08numvalid).HasColumnName("read_more_than_two_races08numvalid");

                entity.Property(e => e.ReadMoreThanTwoRacesAllGradesNumvalid).HasColumnName("read_more_than_two_races_all_grades_numvalid");

                entity.Property(e => e.ReadMoreThanTwoRaceshsnumvalid).HasColumnName("read_more_than_two_raceshsnumvalid");

                entity.Property(e => e.ReadNativeAmerican03numvalid).HasColumnName("read_native_american03numvalid");

                entity.Property(e => e.ReadNativeAmerican04numvalid).HasColumnName("read_native_american04numvalid");

                entity.Property(e => e.ReadNativeAmerican05numvalid).HasColumnName("read_native_american05numvalid");

                entity.Property(e => e.ReadNativeAmerican06numvalid).HasColumnName("read_native_american06numvalid");

                entity.Property(e => e.ReadNativeAmerican07numvalid).HasColumnName("read_native_american07numvalid");

                entity.Property(e => e.ReadNativeAmerican08numvalid).HasColumnName("read_native_american08numvalid");

                entity.Property(e => e.ReadNativeAmericanAllGradesNumvalid).HasColumnName("read_native_american_all_grades_numvalid");

                entity.Property(e => e.ReadNativeAmericanhsnumvalid).HasColumnName("read_native_americanhsnumvalid");

                entity.Property(e => e.ReadPoor03numvalid).HasColumnName("read_poor03numvalid");

                entity.Property(e => e.ReadPoor04numvalid).HasColumnName("read_poor04numvalid");

                entity.Property(e => e.ReadPoor05numvalid).HasColumnName("read_poor05numvalid");

                entity.Property(e => e.ReadPoor06numvalid).HasColumnName("read_poor06numvalid");

                entity.Property(e => e.ReadPoor07numvalid).HasColumnName("read_poor07numvalid");

                entity.Property(e => e.ReadPoor08numvalid).HasColumnName("read_poor08numvalid");

                entity.Property(e => e.ReadPoorAllGradesNumvalid).HasColumnName("read_poor_all_grades_numvalid");

                entity.Property(e => e.ReadPoorhsnumvalid).HasColumnName("read_poorhsnumvalid");

                entity.Property(e => e.ReadSchnam).HasColumnName("read_schnam");

                entity.Property(e => e.ReadStLeaid).HasColumnName("read_st_leaid");

                entity.Property(e => e.ReadStSchid).HasColumnName("read_st_schid");

                entity.Property(e => e.ReadStnam).HasColumnName("read_stnam");

                entity.Property(e => e.ReadWhite03numvalid).HasColumnName("read_white03numvalid");

                entity.Property(e => e.ReadWhite04numvalid).HasColumnName("read_white04numvalid");

                entity.Property(e => e.ReadWhite05numvalid).HasColumnName("read_white05numvalid");

                entity.Property(e => e.ReadWhite06numvalid).HasColumnName("read_white06numvalid");

                entity.Property(e => e.ReadWhite07numvalid).HasColumnName("read_white07numvalid");

                entity.Property(e => e.ReadWhite08numvalid).HasColumnName("read_white08numvalid");

                entity.Property(e => e.ReadWhiteAllGradesNumvalid).HasColumnName("read_white_all_grades_numvalid");

                entity.Property(e => e.ReadWhitehsnumvalid).HasColumnName("read_whitehsnumvalid");
            });

            modelBuilder.Entity<TeacherRatios>(entity =>
            {
                entity.HasKey(e => e.Ncessch)
                    .HasName("Teacher Ratios_pkey");

                entity.ToTable("Teacher Ratios");

                entity.Property(e => e.Ncessch)
                    .HasColumnName("ncessch")
                    .HasColumnType("numeric");

                entity.Property(e => e.EduAgencyName).HasColumnName("edu_agency_name");

                entity.Property(e => e.Fipst).HasColumnName("fipst");

                entity.Property(e => e.Leaid).HasColumnName("leaid");

                entity.Property(e => e.NumFullTime)
                    .HasColumnName("num_full_time")
                    .HasColumnType("numeric");

                entity.Property(e => e.PostalStateAbbreviation).HasColumnName("postal_state_abbreviation");

                entity.Property(e => e.SchName).HasColumnName("sch_name");

                entity.Property(e => e.Schid).HasColumnName("schid");

                entity.Property(e => e.StLeaid).HasColumnName("st_leaid");

                entity.Property(e => e.StSchid).HasColumnName("st_schid");

                entity.Property(e => e.StateEduAgencyName).HasColumnName("state_edu_agency_name");

                entity.Property(e => e.StateName).HasColumnName("state_name");

                entity.Property(e => e.SurveyYear).HasColumnName("survey_year");
            });

            modelBuilder.Entity<Title1>(entity =>
            {
                entity.HasKey(e => e.Ncessch)
                    .HasName("title1_pkey");

                entity.ToTable("title1");

                entity.Property(e => e.Ncessch)
                    .HasColumnName("ncessch")
                    .HasColumnType("numeric");

                entity.Property(e => e.Fipst).HasColumnName("fipst");

                entity.Property(e => e.LeaName).HasColumnName("lea_name");

                entity.Property(e => e.Leaid).HasColumnName("leaid");

                entity.Property(e => e.MagnetText).HasColumnName("magnet_text");

                entity.Property(e => e.NtnlSchoolLunchProgramStatus).HasColumnName("ntnl_school_lunch_program_status");

                entity.Property(e => e.NtnlSchoolLunchProgramStatusCode).HasColumnName("ntnl_school_lunch_program_status_code");

                entity.Property(e => e.PostalStateAbbreviation).HasColumnName("postal_state_abbreviation");

                entity.Property(e => e.SchName).HasColumnName("sch_name");

                entity.Property(e => e.Schid).HasColumnName("schid");

                entity.Property(e => e.SchoolWideTitleIEligibility).HasColumnName("school_wide_title_i_eligibility");

                entity.Property(e => e.SharedTime).HasColumnName("shared_time");

                entity.Property(e => e.StLeaid).HasColumnName("st_leaid");

                entity.Property(e => e.StSchid).HasColumnName("st_schid");

                entity.Property(e => e.StateAbbreviation).HasColumnName("state_abbreviation");

                entity.Property(e => e.StateEduAgencyName).HasColumnName("state_edu_agency_name");

                entity.Property(e => e.SurveyYear).HasColumnName("survey_year");

                entity.Property(e => e.TitleIEligibility).HasColumnName("title_i_eligibility");

                entity.Property(e => e.TitleIStatus).HasColumnName("title_i_status");

                entity.Property(e => e.TitleIStatusDescription).HasColumnName("title_i_status_description");
            });
        }
    }
}
