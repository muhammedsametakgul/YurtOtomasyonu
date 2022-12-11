using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yurt
{
    internal class RandomKod
    {
        public static string RandomKodOlustur()
        {
            Random rnd = new Random();
            int i = 0;
            string kod="";
            while (i < 6)
            {
                kod += rnd.Next(0, 10).ToString();
                i++;
            }
            return kod;
        }
    }
}
