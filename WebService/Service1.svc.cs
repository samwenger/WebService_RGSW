using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    public class Service1 : IService1
    {
        public int GetNbOfCopies(string username)
        {
            IUsersDB usersDB = new UsersDB();
            IUsersManager usersManager = new UsersManager(usersDB);
            
            ITransactionsDB transactionDB = new TransactionsDB();
            ITransactionsManager transactionManager = new TransactionsManager(transactionDB, usersManager);

            return transactionManager.GetNbOfCopies(username);
        }

        public List<Transaction> GetTransactions(int idUtilisateur)
        {
            IUsersDB usersDB = new UsersDB();
            IUsersManager usersManager = new UsersManager(usersDB);

            ITransactionsDB transactionDB = new TransactionsDB();
            ITransactionsManager transactionManager = new TransactionsManager(transactionDB, usersManager);

            return transactionManager.GetTransactionsByUser(idUtilisateur);
            // Get type de transaction
        }

        public double TransferAmountFromFaculties(string username, double amount)
        {
            IUsersDB usersDB = new UsersDB();
            IUsersManager usersManager = new UsersManager(usersDB);

            ITransactionsDB transactionDB = new TransactionsDB();
            ITransactionsManager transactionManager = new TransactionsManager(transactionDB, usersManager);

            var transaction = transactionManager.TransferAmountFromFaculties(username, amount);
            return transaction.montant;
        }

        public double TransferAmountFromMachine(int uid, double amount)
        {
            IUsersDB usersDB = new UsersDB();
            IUsersManager usersManager = new UsersManager(usersDB);

            ITransactionsDB transactionDB = new TransactionsDB();
            ITransactionsManager transactionManager = new TransactionsManager(transactionDB, usersManager);

            var transaction = transactionManager.TransferAmount(uid, amount);
            return transaction.montant;
        }

        public double TransferAmountFromOnline(string username, double amount)
        {
            IUsersDB usersDB = new UsersDB();
            IUsersManager usersManager = new UsersManager(usersDB);

            ITransactionsDB transactionDB = new TransactionsDB();
            ITransactionsManager transactionManager = new TransactionsManager(transactionDB, usersManager);

            var transaction = transactionManager.TransferAmountFromOnline(username, amount);
            return transaction.montant;
        }
    }
}
