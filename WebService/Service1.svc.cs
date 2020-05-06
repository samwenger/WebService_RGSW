using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Web.Services.Description;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    public class Service1 : IService1
    {
        private ITransactionsManager TransactionManager { get; }

        public Service1()
        {
            IUsersDB UsersDB = new UsersDB();
            IUsersManager UsersManager = new UsersManager(UsersDB);
            ITransactionsDB TransactionDB = new TransactionsDB();
            TransactionManager = new TransactionsManager(TransactionDB, UsersManager);        
        }

        public int GetNbOfCopies(string username)
        {
            return TransactionManager.GetNbOfCopies(username);
        }

        public List<Transaction> GetTransactions(int idUtilisateur)
        {
            return TransactionManager.GetTransactionsByUser(idUtilisateur);
        }

        public double TransferAmountFromFaculties(string username, double amount)
        {
            var transaction = TransactionManager.TransferAmountFromFaculties(username, amount);
            return transaction.montant;
        }

        public double TransferAmountFromMachine(int uid, double amount)
        { 
            var transaction = TransactionManager.TransferAmount(uid, amount);
            return transaction.montant;
        }

        public double TransferAmountFromOnline(string username, double amount)
        {
            var transaction = TransactionManager.TransferAmountFromOnline(username, amount);
            return transaction.montant;
        }
    }
}
