using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using giftcard;

namespace Giftcard1
{
    class Program
    {
        static void Main(string[] args)
        {
            GiftCard g = new GiftCard(12345,20000,false);
            g.rechargeCard(2000);
            g.swipeCard(400);
            g.swipeCard(500);

            GiftCard gc = new GiftCard();
            gc.rechargeCard(3000);
            gc.swipeCard(500);
            gc.swipeCard(2600);
            Console.ReadLine();
        }
    }
}
