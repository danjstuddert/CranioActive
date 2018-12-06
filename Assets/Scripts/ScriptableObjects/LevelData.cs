using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Will probably have to remove this going forward when we get the level building done properly
[CreateAssetMenu(fileName ="New Level Data", menuName = "Level Data")]
public class LevelData : ScriptableObject {
    // This will need to change when we can save level ids and set them automatically
    [SerializeField] private int levelID;

    public int LevelID { get { return levelID; } }
}
