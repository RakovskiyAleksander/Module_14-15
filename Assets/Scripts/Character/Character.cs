using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] Transform _hand;

    private float _movementSpeed;
    private float _rotationSpeed;
    private MoverController _moverController;

    public float Speed => _movementSpeed;

    public void Initialize(float movementSpeed, float rotationSpeed, float health)
    {
        _movementSpeed = movementSpeed;
        _rotationSpeed = rotationSpeed;




        gameObject.AddComponent<ItemCollector>().Initialize(_hand);
        gameObject.AddComponent<HealthController>().Initialize(health);
        gameObject.AddComponent<SpeedController>().Initialize(movementSpeed);

        _moverController = gameObject.AddComponent<MoverController>();
        MoverControllerInitialize();
        gameObject.AddComponent<CharacterAnimationController>().Initialize(_moverController);
    }

    public void AddSpeeed(float addition)
    {
        _movementSpeed += addition;
        MoverControllerInitialize();
    }

    private void MoverControllerInitialize()
    {
        _moverController.Initialize(_movementSpeed, _rotationSpeed);
    }


}
