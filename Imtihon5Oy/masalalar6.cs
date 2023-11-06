using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon5Oy
{
    public class masalalar6
    {
        public void m6_1()
        {
            List<int> list = new List<int>() { 1,2,4,-2,5,7,8,1,2};
            List<int> list2 = new List<int>() { 1,2,5,7,2};
            var d= list.All(x => x > 0);
            var x=list2.All(x => x > 0);
            Console.WriteLine(d);
            Console.WriteLine(x);
        }
        public void m6_2()
        {
            List<string> soz1 = new List<string>() { "fnsdjkf", "fwdsu", "dwi", "dwiuegdw", "fweiufhw" };
            var d = soz1.Where(x => x.Length > 5);
            var d1=soz1.Where(x => x.Length < 5);
            foreach(var x in d)
            {
                Console.WriteLine(x);
            }
            foreach (var x in d1)
            {
                Console.WriteLine(x);
            }

        }
        public void m6_3()
        {
            //qaytaman
            string sd = "ordav fdgnoo weuiorh oroootrfds";
            string[] fd = sd.Split(' ');
            

            //foreach (var i in d)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
