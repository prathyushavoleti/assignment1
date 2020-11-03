using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment order = new CardPayment();
            order._iPaymentSystem = new ICICIPaymentSystem();
            order.MakePayment();
            order._iPaymentSystem = new HDFCPaymentSystem();
            order.MakePayment();
            Payment order1 = new NetBankingPayment();
            order1._iPaymentSystem = new ICICIPaymentSystem();
            order1.MakePayment();
            order1._iPaymentSystem = new HDFCPaymentSystem();
            order1.MakePayment();
            Console.ReadLine();
        }
    }
}
