using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] Transform _hand;

    public void Initialize(float movementSpeed, float rotationSpeed, float health)
    {
        gameObject.AddComponent<ItemCollector>().Initialize(_hand);
        gameObject.AddComponent<HealthController>().Initialize(health);

        SpeedController speedController = gameObject.AddComponent<SpeedController>();
        speedController.Initialize(movementSpeed);

        MoverController moverController = gameObject.AddComponent<MoverController>();
        moverController.Initialize(speedController, rotationSpeed);

        gameObject.AddComponent<CharacterAnimationController>().Initialize(moverController);

        gameObject.AddComponent<Bomber>();
    }
}
