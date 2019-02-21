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
