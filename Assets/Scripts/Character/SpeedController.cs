using UnityEngine;

public class SpeedController : MonoBehaviour
{
    public float Speed { get; private set; }

    public void Initialize(float speed) => Speed = speed;

    public void AddSpeed(float addition) => Speed += addition;
}
