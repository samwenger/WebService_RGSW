using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TypesDB : ITypesDB
    {
        private string connectionString = null;

        public TypesDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["RemoteDB"].ConnectionString;
        }
        public DTO.Type GetType(int id)
        {
            DTO.Type result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Types where idType = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new DTO.Type();

                            result.idType = (int)dr["idType"];
                            result.type = (string)dr["type"];
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
