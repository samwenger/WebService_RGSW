using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ITransactionsManager
    {
        Transaction TransferAmount(int UID, double amount);
        Transaction TransferAmountFromFaculties(string username, double amount);
        Transaction TransferAmountFromOnline(string username, double amount);
        Transaction TransferAmount(string username, double amount, int idType);


        List<Transaction> GetTransactionsByUser(int idUtilisateur);
        double GetSubtotal(int idUtilisateur);


        int GetNbOfCopies(string username);


    }
}
