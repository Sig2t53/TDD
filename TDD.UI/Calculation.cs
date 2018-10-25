using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    public static class Calculation
    {
        public static int Sum(int a,int b)
        {
            if (a < 0 || b < 0)
            {
                throw new InputException("マイナス値は入力できません");
            }

            return a + b;
        }

        public static int Ave(List<int> list)
        {
            int values = 0;
            foreach (var val in list)
            {
                values += val;
            }

            return values / list.Count;
        }
    }
}
