using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LeadSatisfaction
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string LeadId { get; set; }
        public string ItemId { get; set; }
        public DateTime SurveyDate { get; set; }
        public string QuestionOne { get; set; }
        public int? QuestionOneMetric { get; set; }
        public string QuestionTwo { get; set; }
        public int? QuestionTwoMetric { get; set; }
        public string QuestionThree { get; set; }
        public int? QuestionThreeMetric { get; set; }
        public string QuestionFour { get; set; }
        public int? QuestionFourMetric { get; set; }
        public string QuestionFive { get; set; }
        public int? QuestionFiveMetric { get; set; }
        public string QuestionSix { get; set; }
        public int? QuestionSixMetric { get; set; }
        public string QuestionSeven { get; set; }
        public int? QuestionSevenMetric { get; set; }
        public string QuestionEight { get; set; }
        public int? QuestionEightMetric { get; set; }
        public string QuestionNine { get; set; }
        public int? QuestionNineMetric { get; set; }
        public string QuestionTen { get; set; }
        public int? QuestionTenMetric { get; set; }
        public string QuestionEleven { get; set; }
        public int? QuestionElevenMetric { get; set; }
        public string QuestionTwelve { get; set; }
        public int? QuestionTwelveMetric { get; set; }
        public string QuestionThirteen { get; set; }
        public int? QuestionThirteenMetric { get; set; }
        public string QuestionFourteen { get; set; }
        public int? QuestionFourteenMetric { get; set; }
        public string QuestionFifteen { get; set; }
        public int? QuestionFifteenMetric { get; set; }
        public string FreeForm { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
