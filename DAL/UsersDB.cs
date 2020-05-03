using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsersDB : IUsersDB
    {
        private string connectionString = null;

        public UsersDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["RemoteDB"].ConnectionString;
        }

        public User GetUserByUID(int id)
        {
            User result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Users where UID = @uid";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@uid", id);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new User();

                            result.UID = (int)dr["UID"];
                            result.CardID = (int)dr["cardID"];
                            result.Username = (string)dr["username"];

                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public User GetUserByUsername(string username)
        {
            User result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Users where username = @username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new User();

                            result.UID = (int)dr["UID"];
                            result.CardID = (int)dr["cardID"];
                            result.Username = (string)dr["username"];

                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }
    }
}
