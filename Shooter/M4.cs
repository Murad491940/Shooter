using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
        public class M4
        {
        public int TotalBulletCount { get; set; }
        public int CurrentBulletCount { get; set; }
        public void Soot()
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
        public void Reload()
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

        public M4(int totalbulletcount, int currentbulletcount) 
        {
            TotalBulletCount = totalbulletcount;
            CurrentBulletCount = currentbulletcount;

        }
    }
}