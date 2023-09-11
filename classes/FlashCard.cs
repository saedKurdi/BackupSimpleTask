using Backup.interfaces;

namespace Backup.classes
{
    internal class FlashCard : Storage, IStorage
    {
        public double UsbSpeed
        {
            get => 3;
        }

        public double Memory { get; set; }
        public void CalculateStorage()
        {
            Console.WriteLine($"{Memory/1000}-GB of Memory");
        }

        public void Copy(double dataSize)
        {
            try
            {
                if (dataSize * 1000 > Memory ) throw new Exception("Size of Data To Copy To Flash Card is Greater Than Memory !");
                if (dataSize < 0) throw new Exception("Data Size To Copy Must Be Minimum 1GB !");
                Memory -= dataSize * 1000;
                double size = 0;
                for (int i = 0; i < dataSize ; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Write("DATA ------->");
                    Console.Write("FLASH-CARD : ");
                    Console.Write($"{size +=1000 }-MB");
                    Thread.Sleep(50);

                }
                Console.WriteLine();

                
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                throw new Exception("");
            }
        }

        public void FreeMemory()
        {
            Console.WriteLine($"Free Memory : {Memory}-MB of Free Memory");
        }

        public override void PrintDeviceInfo()
        {
            base.PrintDeviceInfo();
            Console.WriteLine($"USB Speed : {UsbSpeed}");
            FreeMemory();
            CalculateStorage();
        }

        public FlashCard(string ? mediaName,string ? modelName,double memory):base(mediaName,modelName)
        {
            try
            {
                if ( memory == 0) throw new ArgumentNullException("Memory Can Not Be 0 !");
                Memory = memory;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                throw new Exception("");
            }
        }
    }
}
