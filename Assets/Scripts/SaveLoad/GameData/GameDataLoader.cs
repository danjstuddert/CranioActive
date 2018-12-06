using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public class GameDataLoader {
    public GameData LoadData(BinaryFormatter binaryFormatter, string dataPath)
    {
        if (File.Exists(dataPath) == false)
            return null;

        GameData data;

        using (FileStream file = File.Open(dataPath, FileMode.Open))
        {
            data = (GameData)binaryFormatter.Deserialize(file);
        }

        return data;
    }

    public bool DeleteData(string dataPath)
    {
        if (File.Exists(dataPath))
        {
            File.Delete(dataPath);
            return true;
        }

        Debug.LogWarning(string.Format("Tried to delete file {0}, but it doesn't exist.", dataPath));
        return false;
    }
}
