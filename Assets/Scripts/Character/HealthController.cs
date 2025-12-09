using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float Health { get; private set; }

    public void Initialize(float health) => Health = health;

    public void AddHealth(float addition) => Health += addition;
}
