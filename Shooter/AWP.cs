using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    public class AWP : P92,IGun
    {
        public int TotalBulletCount { get; set; }
        public int CurrentBulletCount { get; set; }
        public override void Soot()
        {
           
            if (CurrentBulletCount > 0)
            {
                CurrentBulletCount--;
                Console.WriteLine("Current Bullet Count: " + CurrentBulletCount);
                return;

            }
            else if (CurrentBulletCount == null)
           
            CurrentBulletCount++;
            Console.WriteLine("Total Bullet Count: " + CurrentBulletCount);

        }
        public override void Reload()
        {
            if (CurrentBulletCount == 0)
            {

                TotalBulletCount = TotalBulletCount + CurrentBulletCount;
                Console.WriteLine("Reload: " + TotalBulletCount);
                return;

            }
            else Console.WriteLine("Reload: " + TotalBulletCount);
            Console.WriteLine("AK47 Reloading...");
        }
        public void Zoom(int a)
        {
            if (a == 1 || a<10)
            {
                a++;
                Console.WriteLine("Zoom: " + a);
            }
            else if (a >= 10)
            {
                a--;
            }

            else if (a == 0)
            {
                Console.WriteLine("Error...");
            }
           

        }

        public AWP(int totalbulletcount, int currentbulletcount) : base(totalbulletcount, currentbulletcount)
        {
            TotalBulletCount = totalbulletcount;
            CurrentBulletCount = currentbulletcount;

        }


    }
}
