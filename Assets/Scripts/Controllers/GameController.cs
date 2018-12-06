using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Game Settings")]
    [Header("Speed Settings")]
    [SerializeField] private GameSpeed startingSpeed;
    [SerializeField] private List<GameSpeedSetting> speedSettings;

    [Header("Level Settings")]
    [SerializeField] private List<LevelData> levelData;

    private SpeedController speedController;
    private LevelController levelController;
    private PlayerController playerController;

    private void Start()
    {
        speedController = GetComponentInChildren<SpeedController>();
        if (speedController != null)
            speedController.Init(startingSpeed, speedSettings);
#if UNITY_EDITOR
        else
        {
            MissingControllerMessage(typeof(SpeedController).Name);
            return;
        }
#endif

        levelController = GetComponentInChildren<LevelController>();
        if (levelController != null)
            levelController.Init(levelData);
#if UNITY_EDITOR
        else
        {
            MissingControllerMessage(typeof(LevelController).Name);
            return;
        }
#endif

    }

    private void MissingControllerMessage(string controllerName)
    {
        Debug.LogError(string.Format("{0} missing! Breaking out of startup.", controllerName));
    }

}
