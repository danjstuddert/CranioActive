using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameDataSaver
{
    public bool SaveData(BinaryFormatter binaryFormatter, string filePath, GameData data)
    {
        using (FileStream file = File.Create(filePath))
        {
            binaryFormatter.Serialize(file, data);
        }

        return File.Exists(filePath);
    }
}
