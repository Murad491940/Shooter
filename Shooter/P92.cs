using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    public abstract class P92 : IGun
    {
        public int TotalBulletCount { get; set; }
        public int CurrentBulletCount { get; set; }
        public abstract void Soot();

        public abstract void Reload();
        
        public void Zoom(int a)
        {

            if (a == 1 || a<10)
            {
                a++;
                Console.WriteLine("Zoom: " + a);
            }
            else if (a == 10)
            {
                a--;
            }

            else if (a == 0)
            {
                Console.WriteLine("Error...");
            }
           

        }

        public P92(int totalbulletcount, int currentbulletcount)
        {
            TotalBulletCount = totalbulletcount;
            CurrentBulletCount = currentbulletcount;

        }
    }
}
