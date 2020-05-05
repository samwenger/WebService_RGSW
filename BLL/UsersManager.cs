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

        public UsersManager(IUsersDB usersDb)
        {
            UsersDb = usersDb;
        }

        public User GetUserByUsername(string username)
        {
            return UsersDb.GetUserByUsername(username);
        }

    }
}
