namespace SKTool.scripts.AppData;

public class AppDataManager
{
    public bool ClearAppData()
    {
        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string folderPath = Path.Combine(appDataPath, AppDataConfig.NeShurickPath);
        
        Console.WriteLine("Trying to clear AppData...");
        
        try
        {
            if (Directory.Exists(folderPath))
            {
                Directory.Delete(folderPath, true);
                Console.WriteLine($"Folder successfully deleted! Path: {folderPath}");
                return true;
            }

            Console.WriteLine("Folder already cleared.");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error on deleting folder: {e.Message}");
            return false;
        }
    }
}