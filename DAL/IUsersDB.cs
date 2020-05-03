using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUsersDB
    {
        User GetUserByUID(int id);
        User GetUserByUsername(string username);

    }
}
