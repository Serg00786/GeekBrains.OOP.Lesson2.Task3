using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson2.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankBill bankBill = new BankBill();
            Console.WriteLine(bankBill.SetBalance(1111));
            Console.WriteLine(bankBill.SetBillNumber());
            Console.WriteLine(bankBill.SetBillTypes(BankBill.BillTypes.CompanyBill));
            Console.ReadKey();
        }
    }
}
