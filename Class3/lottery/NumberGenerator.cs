using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3.lottery
{
    public class NumberGenerator : LotteryClass
    {
        public override int random()
        {
            Random random = new Random();
            value = random.Next(0, 41);
            return value;
        }

    }


}
