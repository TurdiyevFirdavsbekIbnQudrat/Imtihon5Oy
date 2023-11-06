using Imtihon5Oy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon5Oy
{
    public class masalalar2_2
    {
        // Bu aslida 4-topshiriq uchun ekan , adashib 2 deb yozib qo'yibman
        public void m2_1()
        {
            List<int> list = new List<int>() { 1,546,87,132,456,765,12};
            var i = from z in list orderby z select z;
            foreach ( var z in i)
            {
                Console.WriteLine(z);
            }
        }
        public void m2_2()
        {

            List<string> strings = new List<string>() { "fsda", "asd", "fdws" };
            var i = from z in strings orderby z select z;
            foreach (var z in i)
            {
                Console.WriteLine(z);
            }

        }
        public void m2_3()
        {
            List<mahsulot> list = new List<mahsulot>()
            {
                new mahsulot() {name="Olma",narxi=5},
                new mahsulot() {name="yalpiz",narxi=215},
                new mahsulot() {name="lavlagi",narxi=45},
                new mahsulot() {name="sabzi",narxi=115},
            };

            var Katta50dan = from i in list orderby i.narxi descending select (i.narxi, i.name);
            foreach (var k in Katta50dan)
            {
                Console.WriteLine(k.narxi + " " + k.name);
            }

        }
    }
}
