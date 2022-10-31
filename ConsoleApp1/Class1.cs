using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTest1
{
    public class Lending
    {
    public int LendingId { get; set; }
    public DateTime ContractDate { get; set; }
    public int? ClientID { get; set; }

    public int? EmployeeID { get; set; }

    public string? Currency { get; set; }

    public float? Sum { get; set; }

    public float? InterestRate { get; set; }

    public int? NumberOftheSuretyAgreement { get; set; }

    public int? PaymentScheduleNumber { get; set; }



    }
}