using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.DAL
{
    public class SurveySQLDao : ISurveyDao
    {



        private readonly string connectionString;

        public SurveySQLDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all parks
        /// </summary>
        /// <returns></returns>
        public IList<SurveyResult> GetAllSurveys()
        {
            IList<SurveyResult> surveys = new List<SurveyResult>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) as 'count', survey_result.parkCode, parkName from survey_result join park on park.parkcode = survey_result.parkCode group by survey_result.parkCode, parkName order by 'count' desc  ", conn);

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var survey = new SurveyResult()
                        {

                            //EmailAddress = Convert.ToString(reader["emailAddress"]),
                            //State = Convert.ToString(reader["state"]),
                            //ActivityLevel = Convert.ToString(reader["activityLevel"]),
                            ParkCode = Convert.ToString(reader["parkCode"]),
                            Count = Convert.ToInt32(reader["count"]),
                            ParkName = Convert.ToString(reader["parkName"])

                        };

                        surveys.Add(survey);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return surveys;

        }
        public SurveyViewModel AddSurvey(SurveyViewModel newSurvey)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("insert into survey_result VALUES(@parkCode, @emailAddress, @state, @activityLevel)", connection);
                    sqlCommand.Parameters.AddWithValue("@parkCode", newSurvey.ParkCode);
                    sqlCommand.Parameters.AddWithValue("@emailAddress", newSurvey.EmailAddress);
                    sqlCommand.Parameters.AddWithValue("@state", newSurvey.State);
                    sqlCommand.Parameters.AddWithValue("@activityLevel", newSurvey.ActivityLevel);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {

                throw;
            }
            return newSurvey;
        }
        

    }
}

