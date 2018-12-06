using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour
{
    public GameSpeed CurrentGameSpeed { get; private set; }
    public float CurrentSpeedModifier { get; private set; }

    private List<GameSpeedSetting> speedSettings;

    public void Init(GameSpeed startingSpeed, List<GameSpeedSetting> speedSettings)
    {
        this.speedSettings = speedSettings;
        AdjustSpeed(startingSpeed);
    }

    public void AdjustSpeed(int speed)
    {
        if (speed >= System.Enum.GetValues(typeof(GameSpeed)).Length)
        {
            Debug.LogWarning("Tried to adjust speed to a value over fastest. Defaulting to fastest.");
            speed = System.Enum.GetValues(typeof(GameSpeed)).Length - 1;
        }
        else if (speed < 0)
        {
            Debug.LogWarning("Tried to adjust speed to a value slower than paused. Defaulting to paused.");
            speed = 0;
        }

        AdjustSpeed((GameSpeed)speed);
    }

    public void AdjustSpeed(GameSpeed speed)
    {
        CurrentGameSpeed = speed;
        CurrentSpeedModifier = speedSettings.Find(s => s.speed == CurrentGameSpeed).speedModifier;
    }
}
