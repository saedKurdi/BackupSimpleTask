namespace Backup.classes
{
    internal abstract class Storage
    {
        public string ? MediaName { get; set; }

        public string ? ModelName { get; set; }

        public Storage(string? mediaName, string? modelName)
        {
            try
            {
                if (mediaName == null || modelName == null) throw new ArgumentNullException("Model Name Or Media Name Can Not Be Null !");
                else if (mediaName.Length < 3 || modelName.Length < 3) throw new Exception("Model Name Or Media Name's Length Can Not Be Little Than 3 !");
                MediaName = mediaName;
                ModelName = modelName;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                throw new Exception("");
            }
        }
        public virtual void PrintDeviceInfo()
        {
            Console.WriteLine($"Media Name : {MediaName}");
            Console.WriteLine($"Model Name : {ModelName}");
        }
    }
}
