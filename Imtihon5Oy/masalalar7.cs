using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon5Oy
{
    public class masalalar7
    {
        public void m7_1()
        {
            List<int> list = new List<int>() {12, 1,2,4,6,8};
            List<int> list_ = new List<int>() {12, 1,2,4,6,3,87,};
            var d = list.Intersect(list_).OrderBy(x=>x);
            foreach (int i in d)
            {
                Console.WriteLine(i);
            }
        }
        public void m7_2() 
        {
            List<int> list = new List<int>() { 12, 1, 2, 4, 6, 8 };
            List<int> list_ = new List<int>() { 12, 1, 2, 4, 6, 3, 87, };
            var d = list.Union(list_).OrderBy(x => x);
            foreach (int i in d)
            {
                Console.WriteLine(i);
            }

        }
        public void m7_3()
        {
            List<int> list = new List<int>() { 12, 1, 2, 4, 6, 8 };
            List<int> list_ = new List<int>() { 12, 1, 2, 4, 6, 3, 87, };
            var d = list.Except(list_).OrderBy(x => x);
            foreach (int i in d)
            {
                Console.WriteLine(i);
            }

        }
        public void m7_4()
        {
            List<string> s = new List<string>() { "Avror", "Saridor", "Azamat", "sdaew", "asd" };
            List<string> d = s.Where(x=>x.StartsWith('A')).OrderBy(x => x).ToList();
            foreach (var  i in d)
            {
                Console.WriteLine(i);
            }

        }
        public void m7_5()
        {
            List<int> list = new List<int>() { 12, 1, 2, 4, 6, 8 };
            List<int> list_ = new List<int>() { 12, 1, 2, 4, 6, 3, 87, };
            List<int> d = list.Except(list_).ToList();
            List<int> x = list_.Except(list).ToList();

            foreach (int i in x) d.Add(i);
            foreach (int i in d)
            {
                Console.WriteLine(i);
            }

        }
        public void m7_6()
        {
            List<string> s = new List<string>() { "Avror", "Maridor", "Azamat", "sdaew", "asd" };
            List<string> s1 = new List<string>() { "Mafar", "Xashar", "Mgz", "sdaew", "Msd" };
            List<string> d = s.Union(s1).Where(x => x.StartsWith('M')).OrderBy(x => x).ToList();
            foreach (var i in d)
            {
                Console.WriteLine(i);
            }

        }
    }
}
