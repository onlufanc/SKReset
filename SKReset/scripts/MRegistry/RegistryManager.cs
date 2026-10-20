using Microsoft.Win32;

namespace SKTool.scripts.MRegistry;

public class RegistryManager
{
    public bool ClearRegistry()
    {
        Console.WriteLine("Trying to clear Registry...");
        
        try
        {
            Registry.CurrentUser.DeleteSubKeyTree(RegistryConfig.PathToNeShurick, false);
            Console.WriteLine($"Section '{RegistryConfig.PathToNeShurick}' successfully deleted from CurrentUser.");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error on deleting section: {e.Message}");
            return false;
        }
    }
}