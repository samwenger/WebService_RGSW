using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Transaction
    {
        public int idTransaction { get; set; }
        public int idUtilisateur { get; set; }
        public double montant { get; set; }
        public DateTime date { get; set; }
        public int idType { get; set; }

    }
}
