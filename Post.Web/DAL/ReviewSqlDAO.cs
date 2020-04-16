using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDAO : IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        public IList<Review> GetAllReviews()
        {
            IList<Review> reviews = new List<Review>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM reviews order by review_date desc", conn);                 
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var review = new Review()
                        {
                            ReviewId = Convert.ToInt32(reader["review_id"]),
                            UserName = Convert.ToString(reader["username"]),
                            Rating = Convert.ToInt32(reader["rating"]),
                            Title = Convert.ToString(reader["review_title"]),
                            Text = Convert.ToString(reader["review_text"]),
                            ReviewDate = Convert.ToDateTime(reader["review_date"])
                        };

                        reviews.Add(review);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return reviews;
        }

        public void SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("insert into reviews VALUES(@Username, @Rating, @Title, @Text, GETDATE())", connection);
                    sqlCommand.Parameters.AddWithValue("@Username", newReview.UserName);
                    sqlCommand.Parameters.AddWithValue("@Rating", newReview.Rating);
                    sqlCommand.Parameters.AddWithValue("@Title", newReview.Title);
                    sqlCommand.Parameters.AddWithValue("@Text", newReview.Text);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {

               throw;
            }
        }
    }
}

