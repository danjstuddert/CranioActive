using UnityEngine;

[System.Serializable]
public struct GameSpeedSetting {
    public GameSpeed speed;
    [Range(0f, 2f)] public float speedModifier; 
}
