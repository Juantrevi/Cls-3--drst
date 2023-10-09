using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3.lottery
{
    public abstract class LotteryClass
    {
        public int value {  get; set; }

        public abstract int random();
    }


}
