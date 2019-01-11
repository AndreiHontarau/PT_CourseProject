using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Records
{
    class RentRecord : Record
    {
        public DateTime DateOfIssue { get; private set; }
        public int CustomerID { get; private set; }
        public int MovieID { get; private set; }

        public RentRecord(DateTime dateOfIssue, int customerID, int movieID)
        {
            DateOfIssue = dateOfIssue;
            CustomerID = customerID;
            MovieID = movieID;
        }
    }
}
