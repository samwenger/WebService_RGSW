using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TransactionsManager : ITransactionsManager
    {
        private ITransactionsDB TransactionsDb { get; }
        private IUsersManager UsersManager { get; }

        public TransactionsManager(ITransactionsDB transactionsDb, IUsersManager usersManager)
        {
            TransactionsDb = transactionsDb;
            UsersManager = usersManager;
        }
        public Transaction TransferAmount(int UID, double amount)
        {
            Transaction transaction = new Transaction
            {
                idUtilisateur = UID,
                montant = amount,
                idType = 1,
                date = DateTime.Now
            };
            
            return TransactionsDb.AddTransaction(transaction);
        }

        public Transaction TransferAmountFromOnline(string username, double amount) {
            int idType = 2;
            return TransferAmount(username, amount, idType);
        }

        public Transaction TransferAmountFromFaculties(string username, double amount)
        {
            int idType = 3;
            return TransferAmount(username, amount, idType);
        }

        public Transaction TransferAmount(string username, double amount, int idType)
        {
            int idUtilisateur = UsersManager.GetUserByUsername(username).UID;

            Transaction transaction = new Transaction
            {
                idUtilisateur = idUtilisateur,
                montant = amount,
                idType = idType,
                date = DateTime.Now
            };

            return TransactionsDb.AddTransaction(transaction);
        }

        public List<Transaction> GetTransactionsByUser(int idUtilisateur)
        {
            return TransactionsDb.GetTransactionsByUser(idUtilisateur);
        }

        public double GetSubtotal(int idUtilisateur)
        {
            List<Transaction> transactions = GetTransactionsByUser(idUtilisateur);

            double subtotal = 0;

            foreach (Transaction transaction in transactions)
            {
                subtotal += transaction.montant;
            }

            return subtotal;
        }

        public int GetNbOfCopies(string username)
        {
            int idUtilisateur = UsersManager.GetUserByUsername(username).UID;
            double subtotal = GetSubtotal(idUtilisateur);

            return (int)(subtotal / 0.08);
        }
    }
}
