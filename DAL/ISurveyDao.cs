using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.DAL
{
    public interface ISurveyDao
    {
        IList<SurveyResult> GetAllSurveys();


        SurveyViewModel AddSurvey(SurveyViewModel newSurvey);
    }
  
}
