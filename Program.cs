using Backup.classes;

namespace Backup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                    FlashCard fc = new FlashCard("FLASH CARD", "Model-1", 2000);
                    fc.Copy(1);

                    Thread.Sleep(500);
                    fc.PrintDeviceInfo();
                    Thread.Sleep(500);


                    DVD dvd = new DVD("DVD -I2", "Model-2", 10000);
                    dvd.Copy(5);

                    Thread.Sleep(1000);
                    dvd.PrintDeviceInfo();
                    Thread.Sleep(1000);


                    HDD hdd = new HDD("HDD V1", "Model-3", 100000);
                    hdd.Copy(45);
                    Thread.Sleep(1000);
                    hdd.PrintDeviceInfo();
                    Thread.Sleep(1000);


                    Console.ReadKey();
                    Console.WriteLine("FINISHED ! ");
                    break;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
        }
    }
}