using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        double TransferAmountFromOnline(string username, double amount);

        [OperationContract]
        double TransferAmountFromFaculties(string username, double amount);

        [OperationContract]
        double TransferAmountFromMachine(int uid, double amount);

        [OperationContract]
        int GetNbOfCopies(string username);

        [OperationContract]
        List<Transaction> GetTransactions(int idUtilisateur);

    }
}
