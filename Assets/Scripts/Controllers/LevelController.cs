using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {
    private List<LevelData> levelData;
    private LevelData currentLevel;

    public void Init(List<LevelData> levelData)
    {
        this.levelData = levelData;

        // For now just set current level to the
        // 1st item in the level data list
        StartLevel(0);
    }

    public void StartLevel(int levelID)
    {
        currentLevel = GetLevelByID(levelID);

        // Do the load level stuff here
    }

    private LevelData GetLevelByID(int id)
    {
        return levelData.Find(l => l.LevelID == id);
    }
}
