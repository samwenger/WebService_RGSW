using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsersManager : IUsersManager
    {
        private IUsersDB UsersDb { get; }
        private ITransactionsManager TransactionsManager { get; }

        public UsersManager(IUsersDB usersDb, ITransactionsManager transactionsManager)
        {
            UsersDb = usersDb;
            TransactionsManager = transactionsManager;
        }
        public User GetUserByUsername(string username)
        {
            return UsersDb.GetUserByUsername(username);
        }

    }
}
