using Imtihon5Oy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon5Oy
{
    public class masalalar3
    {
        public void m3_1()
        {
            List<int> list = new List<int>() { 1,2,4,6,7,9,0,12};
            List<int> lst2 = new List<int>();
            var d = from i in list where i%2==0 select i;
            foreach( var i in d)
            {
                lst2.Add(i);
            }
            foreach( var i in lst2)
            {
                Console.WriteLine(i);
            }
        }
        public void m3_2()
        {
            List<mijozlarRoyxati> mijozlars = new List<mijozlarRoyxati>()
            {
                new mijozlarRoyxati() {firstName="Turdiyev",Name="Firdavs",Description="4-kurs"},
                new mijozlarRoyxati() {firstName="Usmonov",Name="Fayzulloh",Description= "3-kurs"},
            };
            var i = from z in mijozlars select (z.Name,z.firstName);
            foreach( var z in i)
            {
                Console.WriteLine(z.Name + " " + z.firstName);
            }
        }
        public void m3_3()
        {//davomi bor
            List<Oquvchi> oquvchis = new List<Oquvchi>()
            {
                new Oquvchi () {name="Firdavs" , darslik = "matematika"},
                new Oquvchi () {name="Firdavs" , darslik = "Fizika"},
                new Oquvchi () {name="Fayzulloh" , darslik = "matematika"},
                new Oquvchi () {name="Fayzulloh" , darslik = "Tarix"},
            };
            var d = from i in oquvchis group i by i.name ;
           
            foreach(var d2 in d)
            {
                Console.WriteLine(d2.Key);
            }
        }
    }
}
