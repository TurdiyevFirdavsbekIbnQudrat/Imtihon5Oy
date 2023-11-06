using Imtihon5Oy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon5Oy
{
    public class masalalar5
    {
        public void m5_1()
        {
            List<oquvchiVadescription> ds = new List<oquvchiVadescription>() {
             new oquvchiVadescription() {description="4-kurs",name="Firdavs"},
             new oquvchiVadescription() {description="3-kurs",name="Abbos"}
            };

            var d = (from i in ds select i.name).ToList();
            var f = (from i in ds select i.description).ToList();
            List<matn> mat = new List<matn>();
            List<oquvchhi> oquvh = new List<oquvchhi>();
            foreach(var matn in f)
            {
                Console.WriteLine(matn);
                mat.Add(new matn { s= matn });
            }

            foreach (var ism in d)
            {
                Console.WriteLine(ism);
                oquvh.Add(new oquvchhi { s= ism });
            }
        }

        public void m5_2()
        {
            string ds = "fwfewrnofo2134356ydsnfwbuidbwei324325terfrigerjf";
            var d = from i in ds where i<='9'  select i;
            var g = from i in d where i >= '0' select i;
            foreach(var i in g)
            {
                Console.WriteLine(i);
            }
        }
        public void m5_3() 
        {
            string sd = "ordav fdgno weuirh ortrfds";
            string[] fd = sd.Split(' ');
            var d = fd.Where(x=>x.StartsWith("or"));
            
            foreach (var i in d)
            {
                Console.WriteLine(i);
            }
        }


        public void m5_4()
        {
            string sd = "ordav fdgno weuirh ortrfds";
            string[] fd = sd.Split(' ');
            var d = fd.Where(x => x.Contains('a'));

            foreach (var i in d)
            {
                Console.WriteLine(i);
            }
        }

    }
}
