using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giftcard
{
    public class GiftCard
    {
        private long cardno;
        private bool active;
        private double balance;

        public long CardNo
        {
            get { return cardno; }
            set { cardno = value; }
        }
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public GiftCard(long Cardno, double balance, bool active)

        {
            this.cardno = Cardno;
            this.balance = balance;
            this.active = Active;
        }
        public GiftCard()
        {
            this.balance = 0;
            this.active = true;
        }
        public void rechargeCard(int amount)
        {
            if (active == true)
            {
                balance = balance + amount;
                Console.WriteLine(balance);
            }
            else
                Console.WriteLine("no amount is added");
        }
        public void swipeCard(int amt)
        {
            if (active == true && balance > amt)
            {
                Console.WriteLine("access granted to swipe the card");
                balance = balance - amt;
                Console.WriteLine(balance);
                
            }
            else
                Console.WriteLine("no access to swipe the card due to insufficient balance");
        }
    }
}