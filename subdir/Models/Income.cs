using System;
using System.Collections.Generic;

namespace SeniorProjectWebsite.Models
{
    public partial class Income
    {
        public int? Statefips { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public int? NumReturns { get; set; }
        public int? NumSingleReturns { get; set; }
        public int? NumJointReturns { get; set; }
        public int? NumOfHeadHouseReturns { get; set; }
        public int? NumExemptions { get; set; }
        public int? NumDep { get; set; }
        public int? Agi { get; set; }
        public int? NumReturnTotalIncome { get; set; }
        public int? ToalIncomeAmount { get; set; }
        public int? NumReturnsSalaryWages { get; set; }
        public int? SallariesWagesAmount { get; set; }
        public int? NumStateLocal { get; set; }
        public int? StateLocalAmount { get; set; }
        public int? NumBusinessProfessional { get; set; }
        public int? BusinessProfessionalAmount { get; set; }
        public int? NumReturnsUnemployeement { get; set; }
        public int? UnemployeementAmount { get; set; }
        public int? NumEducatorExpenses { get; set; }
        public int? EducationExpenseAmount { get; set; }
        public int? NumReturnStateLocalGeneral { get; set; }
        public int? StateLocalGeneralAmount { get; set; }
        public int? NumberReturnsPersonalProperty { get; set; }
        public int? PersonalPropertyAmounts { get; set; }
        public int? NumberReturnsTaxable { get; set; }
        public int? TaxableAmount { get; set; }
        public int? NumReturnsBeforeCredits { get; set; }
        public int? BeforeCreditsAmount { get; set; }
        public int? NumReturnsNonRefundEdu { get; set; }
        public int? NonRefundEduAmount { get; set; }
        public int? NumReturnsExcessIncomeCredit { get; set; }
        public int? ExcessIncomeCreditAmount { get; set; }
        public int? NumberOfRefundableEdu { get; set; }
        public int? RefundableEduAmount { get; set; }
        public int? NumberReturnsNetPremiumCredits { get; set; }
        public int? NetPremiumCreditsAmount { get; set; }
    }
}
