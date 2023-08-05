using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeA
{
    public class StatisticsForSupervisor : Statistics
    {
        public override char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average > 90:
                        return '6';
                    case var average when average > 70:
                        return '5';
                    case var average when average > 50:
                        return '4';
                    case var average when average > 30:
                        return '3';
                    case var average when average > 10:
                        return '2';
                    default:
                        return '1';
                }

            }
        }
    }
}
