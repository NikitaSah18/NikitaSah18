using System;
using EfCoreTest1;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;

using (ApplicationContext db = new ApplicationContext())
{
    var Lendings = db.Lendings.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Lending u in Lendings)
    {

        Console.WriteLine(u.LendingId + " " + u.ContractDate + " " + u.ClientID + " "
            + u.EmployeeID + " " + u.Currency + " " + u.Sum + " " + u.InterestRate + " " + u.NumberOftheSuretyAgreement + " "
            + u.PaymentScheduleNumber);
    }
}
/* using (ApplicationContext db = new ApplicationContext())
{
 Lending test = new Lending {LendingId = 1235091, ContractDate = new DateTime(2022, 3, 2), };
 db.Lendings.Add(test);
 db.SaveChanges();
 var Lendings = db.Lendings.ToArray();
 Console.WriteLine("Список объектов");
 foreach (Lending u in Lendings)
 {
     Console.WriteLine(u.LendingId + " - " + u.ContractDate);
 }
}*/
/*using (ApplicationContext db = new ApplicationContext())
{
   Lending? upduser = (from Lending in db.Lendings where Lending.LendingId == 1235 select Lending ).First();
   if (upduser != null)
   {
       upduser.Sum = upduser.Sum * 3;
       db.SaveChanges();
   }
   var lendings = db.Lendings.ToArray();
   Console.WriteLine("Список объектов");
   foreach (Lending u in lendings)
   {
       Console.WriteLine(u.LendingId + " - " + u.Sum);
   }

}*/

/*using (ApplicationContext db = new ApplicationContext())
{
    Lending? deluser = (from Lending in db.Lendings where Lending.LendingId == 1234 select Lending).First();
    if (deluser != null)
    {
        db.Lendings.Remove(deluser);
        db.SaveChanges();
    }
    var lendings = db.Lendings.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Lending u in lendings)
    {
        Console.WriteLine(u.LendingId + " - " + u.ClientID);
    }

}*/



