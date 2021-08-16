using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Operations
    {
        public static List<Teacher> calculate(List<Teacher> list, int operation)
        {
            List<Teacher> res_list = new List<Teacher>();
            switch(operation)
            {
                case 1:
                    {
                        var query = list.OrderBy(t => t.salary);
                        foreach(Teacher k in query)
                        {
                            res_list.Add(k);
                        }
                        break;
                    }
                case 2:
                    {
                        var query = list.OrderByDescending(t => t.experience);
                        foreach (Teacher k in query)
                        {
                            res_list.Add(k);
                        }
                        break;
                    }
                case 3:
                    {
                        var query = list.OrderByDescending(t => t.surname);
                        foreach (Teacher k in query)
                        {
                            res_list.Add(k);
                        }
                        break;
                    }
                case 4:
                    {
                        var query = list.Where(t => t.birth_date.Year < 1970);
                        foreach (Teacher k in query)
                        {
                            res_list.Add(k);
                        }
                        break;
                    }
                case 5:
                    {
                        var query = list.Where(t => t.salary > 12000);
                        foreach (Teacher k in query)
                        {
                            res_list.Add(k);
                        }
                        break;
                    }
                case 6:
                    {
                        var query = list.Where(t => t.experience > 20);
                        foreach (Teacher k in query)
                        {
                            res_list.Add(k);
                        }
                        break;
                    }
                case 7:
                    {
                        var query = list.Where(t => t.name.Length > 6 );
                        foreach (Teacher k in query)
                        {
                            res_list.Add(k);
                        }
                        break;
                    }
                case 8:
                    {
                        var query = list.GroupBy(t => t.cathedra);
                        foreach (var re in query)
                        {
                            foreach (var k in re)
                            {
                                res_list.Add(k);
                            }
                        }
                        break;
                    }
                case 9:
                    {
                        var query = list.GroupBy(t => t.position);
                        foreach(var re in query)
                        {
                            foreach(var k in re)
                            {
                                res_list.Add(k);
                            }
                        }
                        break;
                    }
                case 10:
                    {
                        var query = list.GroupBy(t => t.surname);
                        foreach (var re in query)
                        {
                            foreach (var k in re)
                            {
                                res_list.Add(k);
                            }
                        }
                        break;
                    }
            }
            return res_list;
        }
        public static List<string> linq_sort(List<string> list, ref Stopwatch sw)
        {
            sw = Stopwatch.StartNew();
            List<string> res_list;
            res_list = list.OrderBy(x => x.Length).ToList();
            sw.Stop();
            return res_list;
        }
        public static List<string> paralel_linq_sort(List<string> list, ref Stopwatch sw)
        {
            sw = Stopwatch.StartNew();
            List<string> res_list = new List<string>();
            res_list = list.AsParallel().AsOrdered().OrderBy(x => x.Length).ToList();
            sw.Stop();
            return res_list;
        }
        public static List<string> custom_sort(List<string> list, ref Stopwatch sw)
        {
            sw = Stopwatch.StartNew();
            List<string> res_list = new List<string>(list);
            string tmp;
            for(int i = 0; i < list.Count - 1; i++)
            {
                for(int j = i + 1; j < list.Count; j++)
                {
                    if(res_list[j].Length < res_list[i].Length)
                    {
                        tmp = res_list[j];
                        res_list[j] = res_list[i];
                        res_list[i] = tmp; 
                    }
                }
            }
            sw.Stop();
            return res_list;
        }
    }
}
