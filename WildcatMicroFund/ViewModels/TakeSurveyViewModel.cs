using WildcatMicroFund.Data.Models;
using System.Collections.Generic;

namespace WildcatMicroFund.ViewModels
{
    public class TakeSurveyViewModel
    {
        public int ID { get; set; }
        public SurveyCode SurveyCode { get; set; }
        public int SurveyCodeID { get; set; }
        public List<Application>? Applications { get; set; }
        public List<Response> Responses { get; set; }
        public int UserID { get; set; }
        public string SurveyName { get; set; }
        public List<Question> Questions { get; set; }


    }
}