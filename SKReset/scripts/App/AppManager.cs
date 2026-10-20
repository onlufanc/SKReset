using SKTool.scripts.AppData;
using SKTool.scripts.MRegistry;

namespace SKTool.scripts.App;

public class AppManager
{
    public void ResetData()
    {
        var rm = new RegistryManager();
        var adm = new AppDataManager();

        bool registryResult = rm.ClearRegistry();
        Check(registryResult);
        
        bool appDataResult = adm.ClearAppData();
        Check(appDataResult);
        
        Console.Write("Data cleared.");
    }

    private void Check(bool result)
    {
        if (!result)
        {
            throw new InvalidOperationException("Failed to clear data.");
        }
    }
}