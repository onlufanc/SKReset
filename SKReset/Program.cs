using SKTool.scripts.App;

namespace SKTool
{
    internal class Program
    {
        private static void Main()
        {
            var am = new AppManager();
            
            Console.WriteLine("===[ SKReset ]===");
            
            am.ResetData();
        }
    }
}