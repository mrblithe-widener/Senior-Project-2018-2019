# This is an auto-generated Django model module.
# You'll have to do the following manually to clean this up:
#   * Rearrange models' order
#   * Make sure each model has one field with primary_key=True
#   * Make sure each ForeignKey has `on_delete` set to the desired behavior.
#   * Remove `managed = False` lines if you wish to allow Django to create, modify, and delete the table
# Feel free to rename the models, but don't rename db_table values or field names.
from django.db import models


class Bussines(models.Model):
    geo_id = models.TextField(blank=True, null=True)
    geo_id2 = models.IntegerField(blank=True, null=True)
    naics_id = models.IntegerField(blank=True, null=True)
    naics_meaning = models.TextField(blank=True, null=True)
    zip_code = models.FloatField(blank=True, null=True)
    location = models.TextField(blank=True, null=True)
    year = models.IntegerField(blank=True, null=True)
    num_establishments = models.IntegerField(blank=True, null=True)
    num_paid_employees = models.TextField(blank=True, null=True)
    first_quarter_payroll = models.TextField(blank=True, null=True)
    annual_payroll = models.TextField(blank=True, null=True)

    class Meta:
        managed = False
        db_table = 'BUSSINES'


class Funding(models.Model):
    idcensus = models.FloatField(blank=True, null=True)
    name = models.TextField(blank=True, null=True)
    conum = models.IntegerField(blank=True, null=True)
    csa = models.FloatField(blank=True, null=True)
    cbsa = models.FloatField(blank=True, null=True)
    ncesid = models.IntegerField(blank=True, null=True)
    enroll = models.IntegerField(blank=True, null=True)
    totalrev = models.IntegerField(blank=True, null=True)
    tfedrev = models.IntegerField(blank=True, null=True)
    fed_title1 = models.IntegerField(blank=True, null=True)
    fed_dis = models.IntegerField(blank=True, null=True)
    fedr_nutr = models.IntegerField(blank=True, null=True)
    fedr_othr = models.IntegerField(blank=True, null=True)
    tstrev = models.IntegerField(blank=True, null=True)
    str_gen_formula_ass = models.IntegerField(blank=True, null=True)
    str_spec_ed = models.IntegerField(blank=True, null=True)
    str_trans = models.IntegerField(blank=True, null=True)
    str_othr = models.IntegerField(blank=True, null=True)
    tlocrev = models.IntegerField(blank=True, null=True)
    locr_tax = models.IntegerField(blank=True, null=True)
    locr_prop_tax = models.IntegerField(blank=True, null=True)
    locr_par_gov_cont = models.IntegerField(blank=True, null=True)
    locr_cities_counties = models.IntegerField(blank=True, null=True)
    locr_other_schools = models.IntegerField(blank=True, null=True)
    locr_charges = models.IntegerField(blank=True, null=True)
    locr_othr = models.IntegerField(blank=True, null=True)
    total_expenditure = models.IntegerField(blank=True, null=True)
    t_curr_spnd = models.IntegerField(blank=True, null=True)
    t_sal_wage = models.IntegerField(blank=True, null=True)
    t_employee_ben = models.IntegerField(blank=True, null=True)
    t_cur_instruction = models.IntegerField(blank=True, null=True)
    t_cur_instruction_sal_wag = models.IntegerField(blank=True, null=True)
    t_cur_instruction_bene = models.IntegerField(blank=True, null=True)
    t_cur_support_services = models.IntegerField(blank=True, null=True)
    t_curs_pupil = models.IntegerField(blank=True, null=True)
    t_curs_staff_support = models.IntegerField(blank=True, null=True)
    t_curs_gen_admin = models.IntegerField(blank=True, null=True)
    t_curs_sch_admin = models.IntegerField(blank=True, null=True)
    t_curs_oth = models.IntegerField(blank=True, null=True)
    t_cur_other = models.IntegerField(blank=True, null=True)
    t_capital = models.IntegerField(blank=True, null=True)
    t_pay_govt = models.IntegerField(blank=True, null=True)
    t_intrst = models.IntegerField(blank=True, null=True)
    outstanding_debt = models.IntegerField(blank=True, null=True)
    long_debt_issued = models.IntegerField(blank=True, null=True)
    long_debt_retired = models.IntegerField(blank=True, null=True)
    pct_total_rev = models.IntegerField(blank=True, null=True)
    pct_tot_fed = models.FloatField(blank=True, null=True)
    pct_title1 = models.FloatField(blank=True, null=True)
    pct_tot_state = models.FloatField(blank=True, null=True)
    pcts_gen_form = models.FloatField(blank=True, null=True)
    pct_rev_locale = models.FloatField(blank=True, null=True)
    pct_parent_gov_cont = models.FloatField(blank=True, null=True)
    pct_other_local_gov = models.FloatField(blank=True, null=True)
    pct_charges = models.FloatField(blank=True, null=True)
    per_pupil_tot_spending = models.IntegerField(blank=True, null=True)
    per_pupil_salary_wages = models.IntegerField(blank=True, null=True)
    per_pupil_employee_ben = models.IntegerField(blank=True, null=True)
    per_pupil_inst_tot = models.IntegerField(blank=True, null=True)
    per_pupil_inst_sal_wag = models.IntegerField(blank=True, null=True)
    per_pupil_inst_bene = models.IntegerField(blank=True, null=True)
    per_pupil_tot_supp_serv = models.IntegerField(blank=True, null=True)
    per_pupil_support_staff = models.IntegerField(blank=True, null=True)
    per_pupil_inst_support_staff = models.IntegerField(blank=True, null=True)
    per_pupil_gen_admin = models.IntegerField(blank=True, null=True)
    per_pupil_school_admin = models.IntegerField(blank=True, null=True)

    class Meta:
        managed = False
        db_table = 'FUNDING'


class Math(models.Model):
    math_stnam = models.TextField(db_column='MATH_STNAM', blank=True, null=True)  # Field name made lowercase.
    math_fipst = models.IntegerField(db_column='MATH_FIPST', blank=True, null=True)  # Field name made lowercase.
    math_leaid = models.IntegerField(db_column='MATH_LEAID', blank=True, null=True)  # Field name made lowercase.
    math_st_leaid = models.TextField(db_column='MATH_ST_LEAID', blank=True, null=True)  # Field name made lowercase.
    math_leanm = models.TextField(db_column='MATH_LEANM', blank=True, null=True)  # Field name made lowercase.
    math_ncessch = models.BigIntegerField(db_column='MATH_NCESSCH', blank=True, null=True)  # Field name made lowercase.
    math_st_schid = models.TextField(db_column='MATH_ST_SCHID', blank=True, null=True)  # Field name made lowercase.
    math_schnam = models.TextField(db_column='MATH_SCHNAM', blank=True, null=True)  # Field name made lowercase.
    math_all_grades_numvalid = models.IntegerField(db_column='MATH_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_native_american_all_grades_numvalid = models.IntegerField(db_column='MATH_NATIVE_AMERICAN_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_all_grades_numvalid = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_black_all_grades_numvalid = models.IntegerField(db_column='MATH_BLACK_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_hispanic_all_grades_numvalid = models.IntegerField(db_column='MATH_HISPANIC_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_more_than_two_races_all_grades_numvalid = models.IntegerField(db_column='MATH_MORE_THAN_TWO_RACES_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_white_all_grades_numvalid = models.IntegerField(db_column='MATH_WHITE_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_f_all_grades_numvalid = models.IntegerField(db_column='MATH_F_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_m_all_grades_numvalid = models.IntegerField(db_column='MATH_M_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites_all_grades_numvalid = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_poor_all_grades_numvalid = models.IntegerField(db_column='MATH_POOR_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_limited_english_all_grades_numvalid = models.IntegerField(db_column='MATH_LIMITED_ENGLISH_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_homeless_all_grades_numvalid = models.IntegerField(db_column='MATH_HOMELESS_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_migrant_all_grades_numvalid = models.IntegerField(db_column='MATH_MIGRANT_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_all03numvalid = models.IntegerField(db_column='MATH_ALL03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_all04numvalid = models.IntegerField(db_column='MATH_ALL04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_all05numvalid = models.IntegerField(db_column='MATH_ALL05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_all06numvalid = models.IntegerField(db_column='MATH_ALL06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_all07numvalid = models.IntegerField(db_column='MATH_ALL07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_all08numvalid = models.IntegerField(db_column='MATH_ALL08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_allhsnumvalid = models.IntegerField(db_column='MATH_ALLHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_native_american03numvalid = models.IntegerField(db_column='MATH_NATIVE_AMERICAN03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_native_american04numvalid = models.IntegerField(db_column='MATH_NATIVE_AMERICAN04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_native_american05numvalid = models.IntegerField(db_column='MATH_NATIVE_AMERICAN05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_native_american06numvalid = models.IntegerField(db_column='MATH_NATIVE_AMERICAN06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_native_american07numvalid = models.IntegerField(db_column='MATH_NATIVE_AMERICAN07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_native_american08numvalid = models.IntegerField(db_column='MATH_NATIVE_AMERICAN08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_native_americanhsnumvalid = models.IntegerField(db_column='MATH_NATIVE_AMERICANHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_03numvalid = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_04numvalid = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_05numvalid = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_06numvalid = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_07numvalid = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_08numvalid = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_hsnumvalid = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_HSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_black03numvalid = models.IntegerField(db_column='MATH_BLACK03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_black04numvalid = models.IntegerField(db_column='MATH_BLACK04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_black05numvalid = models.IntegerField(db_column='MATH_BLACK05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_black06numvalid = models.IntegerField(db_column='MATH_BLACK06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_black07numvalid = models.IntegerField(db_column='MATH_BLACK07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_black08numvalid = models.IntegerField(db_column='MATH_BLACK08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_blackhsnumvalid = models.IntegerField(db_column='MATH_BLACKHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_hispanic03numvalid = models.IntegerField(db_column='MATH_HISPANIC03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_hispanic04numvalid = models.IntegerField(db_column='MATH_HISPANIC04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_hispanic05numvalid = models.IntegerField(db_column='MATH_HISPANIC05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_hispanic06numvalid = models.IntegerField(db_column='MATH_HISPANIC06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_hispanic07numvalid = models.IntegerField(db_column='MATH_HISPANIC07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_hispanic08numvalid = models.IntegerField(db_column='MATH_HISPANIC08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_hispanichsnumvalid = models.IntegerField(db_column='MATH_HISPANICHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_more_than_two_races03numvalid = models.IntegerField(db_column='MATH_MORE_THAN_TWO_RACES03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_more_than_two_races04numvalid = models.IntegerField(db_column='MATH_MORE_THAN_TWO_RACES04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_more_than_two_races05numvalid = models.IntegerField(db_column='MATH_MORE_THAN_TWO_RACES05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_more_than_two_races06numvalid = models.IntegerField(db_column='MATH_MORE_THAN_TWO_RACES06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_more_than_two_races07numvalid = models.IntegerField(db_column='MATH_MORE_THAN_TWO_RACES07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_more_than_two_races08numvalid = models.IntegerField(db_column='MATH_MORE_THAN_TWO_RACES08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_more_than_two_raceshsnumvalid = models.IntegerField(db_column='MATH_MORE_THAN_TWO_RACESHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_white03numvalid = models.IntegerField(db_column='MATH_WHITE03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_white04numvalid = models.IntegerField(db_column='MATH_WHITE04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_white05numvalid = models.IntegerField(db_column='MATH_WHITE05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_white06numvalid = models.IntegerField(db_column='MATH_WHITE06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_white07numvalid = models.IntegerField(db_column='MATH_WHITE07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_white08numvalid = models.IntegerField(db_column='MATH_WHITE08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_whitehsnumvalid = models.IntegerField(db_column='MATH_WHITEHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_f03numvalid = models.IntegerField(db_column='MATH_F03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_f04numvalid = models.IntegerField(db_column='MATH_F04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_f05numvalid = models.IntegerField(db_column='MATH_F05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_f06numvalid = models.IntegerField(db_column='MATH_F06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_f07numvalid = models.IntegerField(db_column='MATH_F07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_f08numvalid = models.IntegerField(db_column='MATH_F08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_fhsnumvalid = models.IntegerField(db_column='MATH_FHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_m03numvalid = models.IntegerField(db_column='MATH_M03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_m04numvalid = models.IntegerField(db_column='MATH_M04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_m05numvalid = models.IntegerField(db_column='MATH_M05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_m06numvalid = models.IntegerField(db_column='MATH_M06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_m07numvalid = models.IntegerField(db_column='MATH_M07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_m08numvalid = models.IntegerField(db_column='MATH_M08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_mhsnumvalid = models.IntegerField(db_column='MATH_MHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites03numvalid = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites04numvalid = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites05numvalid = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites06numvalid = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites07numvalid = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites08numvalid = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabiliteshsnumvalid = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITESHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_poor03numvalid = models.IntegerField(db_column='MATH_POOR03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_poor04numvalid = models.IntegerField(db_column='MATH_POOR04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_poor05numvalid = models.IntegerField(db_column='MATH_POOR05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_poor06numvalid = models.IntegerField(db_column='MATH_POOR06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_poor07numvalid = models.IntegerField(db_column='MATH_POOR07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_poor08numvalid = models.IntegerField(db_column='MATH_POOR08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_poorhsnumvalid = models.IntegerField(db_column='MATH_POORHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_limited_english03numvalid = models.IntegerField(db_column='MATH_LIMITED_ENGLISH03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_limited_english04numvalid = models.IntegerField(db_column='MATH_LIMITED_ENGLISH04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_limited_english05numvalid = models.IntegerField(db_column='MATH_LIMITED_ENGLISH05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_limited_english06numvalid = models.IntegerField(db_column='MATH_LIMITED_ENGLISH06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_limited_english07numvalid = models.IntegerField(db_column='MATH_LIMITED_ENGLISH07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_limited_english08numvalid = models.IntegerField(db_column='MATH_LIMITED_ENGLISH08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_limited_englishhsnumvalid = models.IntegerField(db_column='MATH_LIMITED_ENGLISHHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_homeless03numvalid = models.IntegerField(db_column='MATH_HOMELESS03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_homeless04numvalid = models.IntegerField(db_column='MATH_HOMELESS04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_homeless05numvalid = models.IntegerField(db_column='MATH_HOMELESS05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_homeless06numvalid = models.IntegerField(db_column='MATH_HOMELESS06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_homeless07numvalid = models.IntegerField(db_column='MATH_HOMELESS07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_homeless08numvalid = models.IntegerField(db_column='MATH_HOMELESS08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_homelesshsnumvalid = models.IntegerField(db_column='MATH_HOMELESSHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_migrant03numvalid = models.IntegerField(db_column='MATH_MIGRANT03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_migrant04numvalid = models.IntegerField(db_column='MATH_MIGRANT04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_migrant05numvalid = models.IntegerField(db_column='MATH_MIGRANT05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_migrant06numvalid = models.IntegerField(db_column='MATH_MIGRANT06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_migrant07numvalid = models.IntegerField(db_column='MATH_MIGRANT07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_migrant08numvalid = models.IntegerField(db_column='MATH_MIGRANT08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_migranthsnumvalid = models.IntegerField(db_column='MATH_MIGRANTHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    math_all03pctprof_low = models.IntegerField(db_column='MATH_ALL03PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_all03pctprof_high = models.IntegerField(db_column='MATH_ALL03PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_all04pctprof_low = models.IntegerField(db_column='MATH_ALL04PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_all04pctprof_high = models.IntegerField(db_column='MATH_ALL04PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_all05pctprof_low = models.IntegerField(db_column='MATH_ALL05PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_all05pctprof_high = models.IntegerField(db_column='MATH_ALL05PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_all06pctprof_low = models.IntegerField(db_column='MATH_ALL06PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_all06pctprof_high = models.IntegerField(db_column='MATH_ALL06PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_all07pctprof_low = models.IntegerField(db_column='MATH_ALL07PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_all07pctprof_high = models.IntegerField(db_column='MATH_ALL07PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_all08pctprof_low = models.IntegerField(db_column='MATH_ALL08PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_all08pctprof_high = models.IntegerField(db_column='MATH_ALL08PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_all_grades_pctprof_low = models.IntegerField(db_column='MATH_ALL_GRADES_PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_all_grades_pctprof_high = models.IntegerField(db_column='MATH_ALL_GRADES_PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_allhspctprof_low = models.IntegerField(db_column='MATH_ALLHSPCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_allhspctprof_high = models.IntegerField(db_column='MATH_ALLHSPCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_03pctprof_low = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_03PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_03pctprof_high = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_03PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_04pctprof_low = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_04PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_04pctprof_high = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_04PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_05pctprof_low = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_05PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_05pctprof_high = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_05PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_06pctprof_low = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_06PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_06pctprof_high = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_06PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_07pctprof_low = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_07PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_07pctprof_high = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_07PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_08pctprof_low = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_08PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_08pctprof_high = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_08PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_all_grades_pctprof_low = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_ALL_GRADES_PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_all_grades_pctprof_high = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_ALL_GRADES_PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_hspctprof_low = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_HSPCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_asian_pacific_islander_hspctprof_high = models.IntegerField(db_column='MATH_ASIAN_PACIFIC_ISLANDER_HSPCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_black03pctprof_low = models.IntegerField(db_column='MATH_BLACK03PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_black03pctprof_high = models.IntegerField(db_column='MATH_BLACK03PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_black04pctprof_low = models.IntegerField(db_column='MATH_BLACK04PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_black04pctprof_high = models.IntegerField(db_column='MATH_BLACK04PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_black05pctprof_low = models.IntegerField(db_column='MATH_BLACK05PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_black05pctprof_high = models.IntegerField(db_column='MATH_BLACK05PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_black06pctprof_low = models.IntegerField(db_column='MATH_BLACK06PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_black06pctprof_high = models.IntegerField(db_column='MATH_BLACK06PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_black07pctprof_low = models.IntegerField(db_column='MATH_BLACK07PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_black07pctprof_high = models.IntegerField(db_column='MATH_BLACK07PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_black08pctprof_low = models.IntegerField(db_column='MATH_BLACK08PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_black08pctprof_high = models.IntegerField(db_column='MATH_BLACK08PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_black_all_grades_pctprof_low = models.IntegerField(db_column='MATH_BLACK_ALL_GRADES_PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_black_all_grades_pctprof_high = models.IntegerField(db_column='MATH_BLACK_ALL_GRADES_PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_blackhspctprof_low = models.IntegerField(db_column='MATH_BLACKHSPCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_blackhspctprof_high = models.IntegerField(db_column='MATH_BLACKHSPCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites03pctprof_low = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES03PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites03pctprof_high = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES03PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites04pctprof_low = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES04PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites04pctprof_high = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES04PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites05pctprof_low = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES05PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites05pctprof_high = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES05PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites06pctprof_low = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES06PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites06pctprof_high = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES06PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites07pctprof_low = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES07PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites07pctprof_high = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES07PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites08pctprof_low = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES08PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites08pctprof_high = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES08PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites_all_grades_pctprof_low = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES_ALL_GRADES_PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabilites_all_grades_pctprof_high = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITES_ALL_GRADES_PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabiliteshspctprof_low = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITESHSPCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_children_with_disabiliteshspctprof_high = models.IntegerField(db_column='MATH_CHILDREN_WITH_DISABILITESHSPCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_f03pctprof_low = models.IntegerField(db_column='MATH_F03PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_f03pctprof_high = models.IntegerField(db_column='MATH_F03PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_f04pctprof_low = models.IntegerField(db_column='MATH_F04PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_f04pctprof_high = models.IntegerField(db_column='MATH_F04PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_f05pctprof_low = models.IntegerField(db_column='MATH_F05PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_f05pctprof_high = models.IntegerField(db_column='MATH_F05PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_f06pctprof_low = models.IntegerField(db_column='MATH_F06PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_f06pctprof_high = models.IntegerField(db_column='MATH_F06PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_f07pctprof_low = models.IntegerField(db_column='MATH_F07PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_f07pctprof_high = models.IntegerField(db_column='MATH_F07PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_f08pctprof_low = models.IntegerField(db_column='MATH_F08PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_f08pctprof_high = models.IntegerField(db_column='MATH_F08PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_f_all_grades_pctprof_low = models.IntegerField(db_column='MATH_F_ALL_GRADES_PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_f_all_grades_pctprof_high = models.IntegerField(db_column='MATH_F_ALL_GRADES_PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_fhspctprof_low = models.IntegerField(db_column='MATH_FHSPCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_fhspctprof_high = models.IntegerField(db_column='MATH_FHSPCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_hispanic03pctprof_low = models.IntegerField(db_column='MATH_HISPANIC03PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_hispanic03pctprof_high = models.IntegerField(db_column='MATH_HISPANIC03PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_hispanic04pctprof_low = models.IntegerField(db_column='MATH_HISPANIC04PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_hispanic04pctprof_high = models.IntegerField(db_column='MATH_HISPANIC04PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_hispanic05pctprof_low = models.IntegerField(db_column='MATH_HISPANIC05PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_hispanic05pctprof_high = models.IntegerField(db_column='MATH_HISPANIC05PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_hispanic06pctprof_low = models.IntegerField(db_column='MATH_HISPANIC06PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_hispanic06pctprof_high = models.IntegerField(db_column='MATH_HISPANIC06PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_hispanic07pctprof_low = models.IntegerField(db_column='MATH_HISPANIC07PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_hispanic07pctprof_high = models.IntegerField(db_column='MATH_HISPANIC07PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_hispanic08pctprof_low = models.IntegerField(db_column='MATH_HISPANIC08PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    math_hispanic08pctprof_high = models.IntegerField(db_column='MATH_HISPANIC08PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    math_hispanic_all_grades_pctprof_low = models.IntegerField(db_column='MATH_HISPANIC_ALL_GRADES_PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.

    class Meta:
        managed = False
        db_table = 'MATH'


class Read(models.Model):
    read_stnam = models.TextField(db_column='READ_STNAM', blank=True, null=True)  # Field name made lowercase.
    read_fipst = models.IntegerField(db_column='READ_FIPST', blank=True, null=True)  # Field name made lowercase.
    read_leaid = models.IntegerField(db_column='READ_LEAID', blank=True, null=True)  # Field name made lowercase.
    read_st_leaid = models.TextField(db_column='READ_ST_LEAID', blank=True, null=True)  # Field name made lowercase.
    read_leanm = models.TextField(db_column='READ_LEANM', blank=True, null=True)  # Field name made lowercase.
    read_ncessch = models.BigIntegerField(db_column='READ_NCESSCH', blank=True, null=True)  # Field name made lowercase.
    read_st_schid = models.TextField(db_column='READ_ST_SCHID', blank=True, null=True)  # Field name made lowercase.
    read_schnam = models.TextField(db_column='READ_SCHNAM', blank=True, null=True)  # Field name made lowercase.
    read_all_grades_numvalid = models.IntegerField(db_column='READ_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_native_american_all_grades_numvalid = models.IntegerField(db_column='READ_NATIVE_AMERICAN_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_all_grades_numvalid = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_black_all_grades_numvalid = models.IntegerField(db_column='READ_BLACK_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_hispanic_all_grades_numvalid = models.IntegerField(db_column='READ_HISPANIC_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_more_than_two_races_all_grades_numvalid = models.IntegerField(db_column='READ_MORE_THAN_TWO_RACES_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_white_all_grades_numvalid = models.IntegerField(db_column='READ_WHITE_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_f_all_grades_numvalid = models.IntegerField(db_column='READ_F_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_m_all_grades_numvalid = models.IntegerField(db_column='READ_M_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites_all_grades_numvalid = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_poor_all_grades_numvalid = models.IntegerField(db_column='READ_POOR_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_limited_english_all_grades_numvalid = models.IntegerField(db_column='READ_LIMITED_ENGLISH_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_homeless_all_grades_numvalid = models.IntegerField(db_column='READ_HOMELESS_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_migrant_all_grades_numvalid = models.IntegerField(db_column='READ_MIGRANT_ALL_GRADES_NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_all03numvalid = models.IntegerField(db_column='READ_ALL03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_all04numvalid = models.IntegerField(db_column='READ_ALL04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_all05numvalid = models.IntegerField(db_column='READ_ALL05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_all06numvalid = models.IntegerField(db_column='READ_ALL06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_all07numvalid = models.IntegerField(db_column='READ_ALL07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_all08numvalid = models.IntegerField(db_column='READ_ALL08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_allhsnumvalid = models.IntegerField(db_column='READ_ALLHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_native_american03numvalid = models.IntegerField(db_column='READ_NATIVE_AMERICAN03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_native_american04numvalid = models.IntegerField(db_column='READ_NATIVE_AMERICAN04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_native_american05numvalid = models.IntegerField(db_column='READ_NATIVE_AMERICAN05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_native_american06numvalid = models.IntegerField(db_column='READ_NATIVE_AMERICAN06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_native_american07numvalid = models.IntegerField(db_column='READ_NATIVE_AMERICAN07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_native_american08numvalid = models.IntegerField(db_column='READ_NATIVE_AMERICAN08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_native_americanhsnumvalid = models.IntegerField(db_column='READ_NATIVE_AMERICANHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_03numvalid = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_04numvalid = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_05numvalid = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_06numvalid = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_07numvalid = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_08numvalid = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_hsnumvalid = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_HSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_black03numvalid = models.IntegerField(db_column='READ_BLACK03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_black04numvalid = models.IntegerField(db_column='READ_BLACK04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_black05numvalid = models.IntegerField(db_column='READ_BLACK05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_black06numvalid = models.IntegerField(db_column='READ_BLACK06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_black07numvalid = models.IntegerField(db_column='READ_BLACK07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_black08numvalid = models.IntegerField(db_column='READ_BLACK08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_blackhsnumvalid = models.IntegerField(db_column='READ_BLACKHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_hispanic03numvalid = models.IntegerField(db_column='READ_HISPANIC03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_hispanic04numvalid = models.IntegerField(db_column='READ_HISPANIC04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_hispanic05numvalid = models.IntegerField(db_column='READ_HISPANIC05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_hispanic06numvalid = models.IntegerField(db_column='READ_HISPANIC06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_hispanic07numvalid = models.IntegerField(db_column='READ_HISPANIC07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_hispanic08numvalid = models.IntegerField(db_column='READ_HISPANIC08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_hispanichsnumvalid = models.IntegerField(db_column='READ_HISPANICHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_more_than_two_races03numvalid = models.IntegerField(db_column='READ_MORE_THAN_TWO_RACES03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_more_than_two_races04numvalid = models.IntegerField(db_column='READ_MORE_THAN_TWO_RACES04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_more_than_two_races05numvalid = models.IntegerField(db_column='READ_MORE_THAN_TWO_RACES05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_more_than_two_races06numvalid = models.IntegerField(db_column='READ_MORE_THAN_TWO_RACES06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_more_than_two_races07numvalid = models.IntegerField(db_column='READ_MORE_THAN_TWO_RACES07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_more_than_two_races08numvalid = models.IntegerField(db_column='READ_MORE_THAN_TWO_RACES08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_more_than_two_raceshsnumvalid = models.IntegerField(db_column='READ_MORE_THAN_TWO_RACESHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_white03numvalid = models.IntegerField(db_column='READ_WHITE03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_white04numvalid = models.IntegerField(db_column='READ_WHITE04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_white05numvalid = models.IntegerField(db_column='READ_WHITE05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_white06numvalid = models.IntegerField(db_column='READ_WHITE06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_white07numvalid = models.IntegerField(db_column='READ_WHITE07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_white08numvalid = models.IntegerField(db_column='READ_WHITE08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_whitehsnumvalid = models.IntegerField(db_column='READ_WHITEHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_f03numvalid = models.IntegerField(db_column='READ_F03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_f04numvalid = models.IntegerField(db_column='READ_F04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_f05numvalid = models.IntegerField(db_column='READ_F05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_f06numvalid = models.IntegerField(db_column='READ_F06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_f07numvalid = models.IntegerField(db_column='READ_F07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_f08numvalid = models.IntegerField(db_column='READ_F08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_fhsnumvalid = models.IntegerField(db_column='READ_FHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_m03numvalid = models.IntegerField(db_column='READ_M03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_m04numvalid = models.IntegerField(db_column='READ_M04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_m05numvalid = models.IntegerField(db_column='READ_M05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_m06numvalid = models.IntegerField(db_column='READ_M06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_m07numvalid = models.IntegerField(db_column='READ_M07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_m08numvalid = models.IntegerField(db_column='READ_M08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_mhsnumvalid = models.IntegerField(db_column='READ_MHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites03numvalid = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites04numvalid = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites05numvalid = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites06numvalid = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites07numvalid = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites08numvalid = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabiliteshsnumvalid = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITESHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_poor03numvalid = models.IntegerField(db_column='READ_POOR03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_poor04numvalid = models.IntegerField(db_column='READ_POOR04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_poor05numvalid = models.IntegerField(db_column='READ_POOR05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_poor06numvalid = models.IntegerField(db_column='READ_POOR06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_poor07numvalid = models.IntegerField(db_column='READ_POOR07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_poor08numvalid = models.IntegerField(db_column='READ_POOR08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_poorhsnumvalid = models.IntegerField(db_column='READ_POORHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_limited_english03numvalid = models.IntegerField(db_column='READ_LIMITED_ENGLISH03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_limited_english04numvalid = models.IntegerField(db_column='READ_LIMITED_ENGLISH04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_limited_english05numvalid = models.IntegerField(db_column='READ_LIMITED_ENGLISH05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_limited_english06numvalid = models.IntegerField(db_column='READ_LIMITED_ENGLISH06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_limited_english07numvalid = models.IntegerField(db_column='READ_LIMITED_ENGLISH07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_limited_english08numvalid = models.IntegerField(db_column='READ_LIMITED_ENGLISH08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_limited_englishhsnumvalid = models.IntegerField(db_column='READ_LIMITED_ENGLISHHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_homeless03numvalid = models.IntegerField(db_column='READ_HOMELESS03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_homeless04numvalid = models.IntegerField(db_column='READ_HOMELESS04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_homeless05numvalid = models.IntegerField(db_column='READ_HOMELESS05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_homeless06numvalid = models.IntegerField(db_column='READ_HOMELESS06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_homeless07numvalid = models.IntegerField(db_column='READ_HOMELESS07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_homeless08numvalid = models.IntegerField(db_column='READ_HOMELESS08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_homelesshsnumvalid = models.IntegerField(db_column='READ_HOMELESSHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_migrant03numvalid = models.IntegerField(db_column='READ_MIGRANT03NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_migrant04numvalid = models.IntegerField(db_column='READ_MIGRANT04NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_migrant05numvalid = models.IntegerField(db_column='READ_MIGRANT05NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_migrant06numvalid = models.IntegerField(db_column='READ_MIGRANT06NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_migrant07numvalid = models.IntegerField(db_column='READ_MIGRANT07NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_migrant08numvalid = models.IntegerField(db_column='READ_MIGRANT08NUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_migranthsnumvalid = models.IntegerField(db_column='READ_MIGRANTHSNUMVALID', blank=True, null=True)  # Field name made lowercase.
    read_all03pctprof_low = models.IntegerField(db_column='READ_ALL03PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_all03pctprof_high = models.IntegerField(db_column='READ_ALL03PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_all04pctprof_low = models.IntegerField(db_column='READ_ALL04PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_all04pctprof_high = models.IntegerField(db_column='READ_ALL04PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_all05pctprof_low = models.IntegerField(db_column='READ_ALL05PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_all05pctprof_high = models.IntegerField(db_column='READ_ALL05PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_all06pctprof_low = models.IntegerField(db_column='READ_ALL06PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_all06pctprof_high = models.IntegerField(db_column='READ_ALL06PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_all07pctprof_low = models.IntegerField(db_column='READ_ALL07PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_all07pctprof_high = models.IntegerField(db_column='READ_ALL07PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_all08pctprof_low = models.IntegerField(db_column='READ_ALL08PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_all08pctprof_high = models.IntegerField(db_column='READ_ALL08PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_all_grades_pctprof_low = models.IntegerField(db_column='READ_ALL_GRADES_PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_all_grades_pctprof_high = models.IntegerField(db_column='READ_ALL_GRADES_PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_allhspctprof_low = models.IntegerField(db_column='READ_ALLHSPCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_allhspctprof_high = models.IntegerField(db_column='READ_ALLHSPCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_03pctprof_low = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_03PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_03pctprof_high = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_03PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_04pctprof_low = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_04PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_04pctprof_high = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_04PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_05pctprof_low = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_05PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_05pctprof_high = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_05PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_06pctprof_low = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_06PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_06pctprof_high = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_06PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_07pctprof_low = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_07PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_07pctprof_high = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_07PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_08pctprof_low = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_08PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_08pctprof_high = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_08PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_all_grades_pctprof_low = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_ALL_GRADES_PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_all_grades_pctprof_high = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_ALL_GRADES_PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_hspctprof_low = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_HSPCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_asian_pacific_islander_hspctprof_high = models.IntegerField(db_column='READ_ASIAN_PACIFIC_ISLANDER_HSPCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_black03pctprof_low = models.IntegerField(db_column='READ_BLACK03PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_black03pctprof_high = models.IntegerField(db_column='READ_BLACK03PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_black04pctprof_low = models.IntegerField(db_column='READ_BLACK04PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_black04pctprof_high = models.IntegerField(db_column='READ_BLACK04PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_black05pctprof_low = models.IntegerField(db_column='READ_BLACK05PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_black05pctprof_high = models.IntegerField(db_column='READ_BLACK05PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_black06pctprof_low = models.IntegerField(db_column='READ_BLACK06PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_black06pctprof_high = models.IntegerField(db_column='READ_BLACK06PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_black07pctprof_low = models.IntegerField(db_column='READ_BLACK07PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_black07pctprof_high = models.IntegerField(db_column='READ_BLACK07PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_black08pctprof_low = models.IntegerField(db_column='READ_BLACK08PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_black08pctprof_high = models.IntegerField(db_column='READ_BLACK08PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_black_all_grades_pctprof_low = models.IntegerField(db_column='READ_BLACK_ALL_GRADES_PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_black_all_grades_pctprof_high = models.IntegerField(db_column='READ_BLACK_ALL_GRADES_PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_blackhspctprof_low = models.IntegerField(db_column='READ_BLACKHSPCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_blackhspctprof_high = models.IntegerField(db_column='READ_BLACKHSPCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites03pctprof_low = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES03PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites03pctprof_high = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES03PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites04pctprof_low = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES04PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites04pctprof_high = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES04PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites05pctprof_low = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES05PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites05pctprof_high = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES05PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites06pctprof_low = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES06PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites06pctprof_high = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES06PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites07pctprof_low = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES07PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites07pctprof_high = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES07PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites08pctprof_low = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES08PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites08pctprof_high = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES08PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites_all_grades_pctprof_low = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES_ALL_GRADES_PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabilites_all_grades_pctprof_high = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITES_ALL_GRADES_PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabiliteshspctprof_low = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITESHSPCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_children_with_disabiliteshspctprof_high = models.IntegerField(db_column='READ_CHILDREN_WITH_DISABILITESHSPCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_f03pctprof_low = models.IntegerField(db_column='READ_F03PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_f03pctprof_high = models.IntegerField(db_column='READ_F03PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_f04pctprof_low = models.IntegerField(db_column='READ_F04PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_f04pctprof_high = models.IntegerField(db_column='READ_F04PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_f05pctprof_low = models.IntegerField(db_column='READ_F05PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_f05pctprof_high = models.IntegerField(db_column='READ_F05PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_f06pctprof_low = models.IntegerField(db_column='READ_F06PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_f06pctprof_high = models.IntegerField(db_column='READ_F06PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_f07pctprof_low = models.IntegerField(db_column='READ_F07PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_f07pctprof_high = models.IntegerField(db_column='READ_F07PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_f08pctprof_low = models.IntegerField(db_column='READ_F08PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_f08pctprof_high = models.IntegerField(db_column='READ_F08PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_f_all_grades_pctprof_low = models.IntegerField(db_column='READ_F_ALL_GRADES_PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_f_all_grades_pctprof_high = models.IntegerField(db_column='READ_F_ALL_GRADES_PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_fhspctprof_low = models.IntegerField(db_column='READ_FHSPCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_fhspctprof_high = models.IntegerField(db_column='READ_FHSPCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_hispanic03pctprof_low = models.IntegerField(db_column='READ_HISPANIC03PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_hispanic03pctprof_high = models.IntegerField(db_column='READ_HISPANIC03PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_hispanic04pctprof_low = models.IntegerField(db_column='READ_HISPANIC04PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_hispanic04pctprof_high = models.IntegerField(db_column='READ_HISPANIC04PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_hispanic05pctprof_low = models.IntegerField(db_column='READ_HISPANIC05PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_hispanic05pctprof_high = models.IntegerField(db_column='READ_HISPANIC05PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_hispanic06pctprof_low = models.IntegerField(db_column='READ_HISPANIC06PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_hispanic06pctprof_high = models.IntegerField(db_column='READ_HISPANIC06PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_hispanic07pctprof_low = models.IntegerField(db_column='READ_HISPANIC07PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_hispanic07pctprof_high = models.IntegerField(db_column='READ_HISPANIC07PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_hispanic08pctprof_low = models.IntegerField(db_column='READ_HISPANIC08PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.
    read_hispanic08pctprof_high = models.IntegerField(db_column='READ_HISPANIC08PCTPROF_HIGH', blank=True, null=True)  # Field name made lowercase.
    read_hispanic_all_grades_pctprof_low = models.IntegerField(db_column='READ_HISPANIC_ALL_GRADES_PCTPROF_LOW', blank=True, null=True)  # Field name made lowercase.

    class Meta:
        managed = False
        db_table = 'READ'


class TeacherRatios(models.Model):
    survey_year = models.TextField(blank=True, null=True)
    fipst = models.IntegerField(blank=True, null=True)
    postal_state_abbreviation = models.TextField(blank=True, null=True)
    state_name = models.TextField(blank=True, null=True)
    state_edu_agency_name = models.TextField(blank=True, null=True)
    leaid = models.IntegerField(blank=True, null=True)
    st_leaid = models.TextField(blank=True, null=True)
    edu_agency_name = models.TextField(blank=True, null=True)
    schid = models.TextField(blank=True, null=True)
    st_schid = models.TextField(blank=True, null=True)
    ncessch = models.FloatField(blank=True, null=True)
    sch_name = models.TextField(blank=True, null=True)
    num_full_time = models.FloatField(blank=True, null=True)

    class Meta:
        managed = False
        db_table = 'Teacher Ratios'


class Geo(models.Model):
    ncessch = models.FloatField(blank=True, null=True)
    name = models.TextField(blank=True, null=True)
    opstfips = models.IntegerField(blank=True, null=True)
    street = models.TextField(blank=True, null=True)
    city = models.TextField(blank=True, null=True)
    state = models.TextField(blank=True, null=True)
    zip = models.IntegerField(blank=True, null=True)
    stfips = models.FloatField(blank=True, null=True)
    cfips = models.FloatField(blank=True, null=True)
    county_name = models.TextField(blank=True, null=True)
    locale = models.FloatField(blank=True, null=True)
    lat = models.FloatField(blank=True, null=True)
    lon = models.FloatField(blank=True, null=True)
    core_based_statistical_area = models.FloatField(blank=True, null=True)
    name_cbsa = models.TextField(blank=True, null=True)
    cbsatype = models.IntegerField(blank=True, null=True)
    combined_statistical_area = models.FloatField(blank=True, null=True)
    csa_name = models.TextField(blank=True, null=True)
    necta = models.TextField(blank=True, null=True)
    necta_name = models.TextField(blank=True, null=True)
    congressional_district = models.FloatField(blank=True, null=True)
    sld_lower = models.TextField(blank=True, null=True)
    sld_upper = models.TextField(blank=True, null=True)
    survyear = models.IntegerField(blank=True, null=True)

    class Meta:
        managed = False
        db_table = 'geo'


class Income(models.Model):
    statefips = models.IntegerField(blank=True, null=True)
    state = models.TextField(blank=True, null=True)
    zipcode = models.IntegerField(blank=True, null=True)
    num_returns = models.IntegerField(blank=True, null=True)
    num_single_returns = models.IntegerField(blank=True, null=True)
    num_joint_returns = models.IntegerField(blank=True, null=True)
    num_of_head_house_returns = models.IntegerField(blank=True, null=True)
    num_exemptions = models.IntegerField(blank=True, null=True)
    num_dep = models.IntegerField(blank=True, null=True)
    agi = models.IntegerField(blank=True, null=True)
    num_return_total_income = models.IntegerField(blank=True, null=True)
    toal_income_amount = models.IntegerField(blank=True, null=True)
    num_returns_salary_wages = models.IntegerField(blank=True, null=True)
    sallaries_wages_amount = models.IntegerField(blank=True, null=True)
    num_state_local = models.IntegerField(blank=True, null=True)
    state_local_amount = models.IntegerField(blank=True, null=True)
    num_business_professional = models.IntegerField(blank=True, null=True)
    business_professional_amount = models.IntegerField(blank=True, null=True)
    num_returns_unemployeement = models.IntegerField(blank=True, null=True)
    unemployeement_amount = models.IntegerField(blank=True, null=True)
    num_educator_expenses = models.IntegerField(blank=True, null=True)
    education_expense_amount = models.IntegerField(blank=True, null=True)
    num_return_state_local_general = models.IntegerField(blank=True, null=True)
    state_local_general_amount = models.IntegerField(blank=True, null=True)
    number_returns_personal_property = models.IntegerField(blank=True, null=True)
    personal_property_amounts = models.IntegerField(blank=True, null=True)
    number_returns_taxable = models.IntegerField(blank=True, null=True)
    taxable_amount = models.IntegerField(blank=True, null=True)
    num_returns_before_credits = models.IntegerField(blank=True, null=True)
    before_credits_amount = models.IntegerField(blank=True, null=True)
    num_returns_non_refund_edu = models.IntegerField(blank=True, null=True)
    non_refund_edu_amount = models.IntegerField(blank=True, null=True)
    num_returns_excess_income_credit = models.IntegerField(blank=True, null=True)
    excess_income_credit_amount = models.IntegerField(blank=True, null=True)
    number_of_refundable_edu = models.IntegerField(blank=True, null=True)
    refundable_edu_amount = models.IntegerField(blank=True, null=True)
    number_returns_net_premium_credits = models.IntegerField(blank=True, null=True)
    net_premium_credits_amount = models.IntegerField(blank=True, null=True)

    class Meta:
        managed = False
        db_table = 'income'
