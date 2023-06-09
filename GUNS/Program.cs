using GUNS;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            M4 m4 = new M4(30);
            m4.Reload();
            m4.Shoot();
            m4.Shoot();
            m4.Shoot();


            if (m4.CurrentBulletCount <= 0)
            {
                throw new InSufficientBulletCountException("Gulle sayi sifirdan kicik ola bilmez");
            }
            Console.WriteLine("M4 silahinda qalan gulle sayi : " + m4.CurrentBulletCount);
        }
        catch (InSufficientBulletCountException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            AK47 AK47 = new AK47(32);
            AK47.Reload();
            AK47.Shoot();
            AK47.Shoot();
            AK47.Shoot();

            if (AK47.CurrentBulletCount <= 0)
            {
                throw new InSufficientBulletCountException("Gulle sayi sifirdan kicik ola bilmez");
            }
            Console.WriteLine("AK-47 de qalan gulle sayi: " + AK47.CurrentBulletCount);
        }
        catch (InSufficientBulletCountException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            P92 P92 = new P92(60);
            P92.Reload();
            P92.Zoom();
            P92.Shoot();
            P92.Shoot();
            P92.Shoot();

            if (P92.CurrentBulletCount <= 0)
            {
                throw new InSufficientBulletCountException("Gulle sayi sifirdan kicik ola bilmez");
            }

            Console.WriteLine("P-92 de qalan gulle sayi: " + P92.CurrentBulletCount);
        }
        catch (InSufficientBulletCountException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            AWP AWP = new AWP(10);
            AWP.Reload();
            AWP.Zoom();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            AWP.Shoot();
            if (AWP.CurrentBulletCount <= 0)
            {
                throw new InSufficientBulletCountException("Gulle sayi sifirdan kicik ola bilmez");
            }
            Console.WriteLine("AWP de qalan gulle sayi: " + AWP.CurrentBulletCount);
        }
        catch (InSufficientBulletCountException ex)
        {
            Console.WriteLine(ex.Message);
        }



        Console.ReadLine();

    }
}
