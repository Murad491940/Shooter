namespace Shooter
{
    public class Program
    {
        static void Main(string[] args)
        {
            AK47 aK47 = new AK47(32, 20);
            AWP aWP = new AWP(10, 5);
            P92 p92=new AWP(60,30);
            M4 m4 = new M4(30, 10);

            Console.WriteLine("Total Bullent Count for AK47: "+ aK47.TotalBulletCount);
            Console.WriteLine("Current Bullet Count for AK47: "+ aK47.CurrentBulletCount);
            aK47.Soot();
            aK47.Reload();

            Console.WriteLine("Total Bullent Count for AWP: " + aWP.TotalBulletCount);
            Console.WriteLine("Current Bullet Count for AWP: " + aWP.CurrentBulletCount);
            aWP.Soot();
            aWP.Reload();
            aWP.Zoom(9);

            Console.WriteLine("Total Bullent Count for P92: " + p92.TotalBulletCount);
            Console.WriteLine("Current Bullet Count for P92: " + p92.CurrentBulletCount);
            p92.Soot();
            p92.Reload();
            p92.Zoom(9);

            Console.WriteLine("Total Bullent Count for M4: " + m4.TotalBulletCount);
            Console.WriteLine("Current Bullet Count for M4: " + m4.CurrentBulletCount);
            m4.Soot();
            m4.Reload();
            

            




        }
    }
}