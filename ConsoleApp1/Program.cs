using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ConsoleApp1.TestEntities context = new TestEntities())
            {
                //var list = context.Droide;

                ////var query = from item in context.Droide
                //            where item.ID == 1
                //            select item;

                //var list = query.Where(item => item.ID == 1).ToList();
                //var list2 = query.ToList().Where(item => item.ID == 1);

                //Droide dd = context.Droide.First();
                //Droide ddd = context.Droide.First(item => item.ID == 1);

                foreach (var item in context.Droide.ToList())
                {
                    Console.WriteLine(item.Matricule);
                }

                Droide newDroide = new Droide()
                {
                    DateDeF = DateTime.Now,
                    Matricule = Guid.NewGuid().ToString(),
                    ModeleID = 1
                };

                context.Droide.Add(newDroide);

                


                Droide dd = context.Droide.First();
                dd.Matricule = "youpi tralalalal " + DateTime.Now.Ticks;

                Droide dd2 = context.Droide.Last();
                context.Droide.Remove(dd2);

                context.SaveChanges();

                foreach (var item in context.Droide.ToList())
                {
                    Console.WriteLine(item.Matricule);
                }
            }


        }
    }
}
