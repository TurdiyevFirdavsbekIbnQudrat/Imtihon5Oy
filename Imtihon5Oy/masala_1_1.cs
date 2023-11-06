using Imtihon5Oy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon5Oy
{
    public class masala_1_1
    {
        public void m1_1()
        {
            List<mahsulot> list = new List<mahsulot>()
            {
                new mahsulot() {name="Olma",narxi=5},
                new mahsulot() {name="yalpiz",narxi=215},
                new mahsulot() {name="lavlagi",narxi=45},
                new mahsulot() {name="sabzi",narxi=115},
            };

            var Katta50dan = from i in list where i.narxi > 50 select (i.narxi, i.name);
            foreach (var k in Katta50dan)
            {
                Console.WriteLine(k.narxi + " " + k.name);
            }

        }
        public void m1_2()
        {
            List<mahsulot> list = new List<mahsulot>()
            {
                new mahsulot() {name="Olma",narxi=5},
                new mahsulot() {name="yalpiz",narxi=215},
                new mahsulot() {name="lavlagi",narxi=45},
                new mahsulot() {name="sabzi",narxi=115},
            };

            var Katta50dan = from i in list orderby i.narxi descending select (i.narxi, i.name);
            foreach (var k in Katta50dan.Take(1))
            {
                Console.WriteLine(k.narxi + " " + k.name);
            }

        }

        public void m1_3()
        {
            List<mijozlar> mijozlars = new List<mijozlar>()
            {
                new mijozlar() {id=1,name="Firdavs"},
                new mijozlar() {id=2,name="Fayzulloh"},
            };
            List<buyurtma> buyurtmas = new List<buyurtma>()
            {
                new buyurtma() {id=1,mahsulot_nomi="Olma"},
                new buyurtma() {id=2,mahsulot_nomi="Mevalar"},
            };
    
            //var boglangan = buyurtmas.GroupJoin(mijozlars, z => z.id, x => x.id, x => x.mahsulot_nomi);
            //foreach (var i in boglangan)
            //{
            //    Console.WriteLine(i);
            //}
        }
        public void m1_4()
        {

        }
    }
}
