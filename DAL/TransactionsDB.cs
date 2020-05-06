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
    public class TransactionsDB : ITransactionsDB
    {
        private string connectionString = null;

        public TransactionsDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["RemoteDB"].ConnectionString;
        }

        public Transaction AddTransaction(Transaction transaction)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Transactions (idUtilisateur, montant, idType, date)" +
                        "VALUES (@idUtilisateur, @montant, @idType, @date); SELECT SCOPE_IDENTITY()";

                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@idUtilisateur", transaction.idUtilisateur);
                    cmd.Parameters.AddWithValue("@montant", transaction.montant);
                    cmd.Parameters.AddWithValue("@idType", transaction.idType);
                    cmd.Parameters.AddWithValue("@date", transaction.date);

                    cn.Open();

                    transaction.idTransaction = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return transaction;
        }

        public List<Transaction> GetTransactionsByUser(int idUtilisateur)
        {
            List<Transaction> results = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Transactions INNER JOIN Types ON Transactions.idType = Types.idType WHERE idUtilisateur=@idUtilisateur";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (results == null)
                                results = new List<Transaction>();

                            Transaction result = new Transaction();

                            result.idTransaction = (int)dr["idTransaction"];

                            result.idUtilisateur = (int)dr["idUtilisateur"];

                            result.montant = (double)dr["montant"];

                            result.date = (DateTime)dr["date"];

                            result.idType = (int)dr["idType"];

                            result.type = (string)dr["type"];


                            results.Add(result);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return results;
        }
    }
}
