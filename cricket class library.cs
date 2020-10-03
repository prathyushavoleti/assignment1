using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclass
{
    public abstract class cricket
    {
        private int maxOvers;
        private int targetScore;
        private int currentOver;
        private int currentScore;

        public int getMaxOvers()
        {
            return maxOvers;
        }
        public int getTargetScore()
        {
            return targetScore;
        }
        public int CurrentOver
        {
            get { return currentOver; }
            set { currentOver = value; }
        }
        public int CurrentScore
        {
            get { return currentScore; }
            set { currentScore = value; }
        }
        public cricket(int maxOvers, int targetScore)
        {
            this.maxOvers = maxOvers;
            this.targetScore = targetScore;
        }
        public abstract double calcurrentrunrate();
        public abstract double requiredrunrate();

        public class OneDaycricket : cricket
        {
             
            double currentRunrate, Reqrunrate;
            public OneDaycricket(int cur_over, int cur_score, int target_score):base(cur_score,cur_over)
            { 
                this.currentScore = cur_score;
                this.currentOver = cur_over;
                this.targetScore = target_score;
                this.maxOvers = 50;

            }

            public override double calcurrentrunrate()
            {
                currentRunrate = currentScore / currentOver;
                return currentRunrate;
            }

            public override double requiredrunrate()
            {
                int remainingruns = targetScore - currentScore;
                int remainingover = maxOvers - currentOver;
                Reqrunrate = remainingruns / remainingover;
                return Reqrunrate;

            }



        }


    }
}
    


                







        