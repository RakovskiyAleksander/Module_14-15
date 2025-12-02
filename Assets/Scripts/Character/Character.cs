using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] Transform _hand;

    private float _movementSpeed;
    private float _rotationSpeed;
    private MoverController _moverController;

    private float _health;

    public float Health => _health;
    public float Speed => _movementSpeed;

    public void Initialize(float movementSpeed, float rotationSpeed, float health)
    {
        _movementSpeed = movementSpeed;
        _rotationSpeed = rotationSpeed;

        _health = health;

        _moverController = gameObject.AddComponent<MoverController>();
        MoverControllerInitialize();

        gameObject.AddComponent<CharacterAnimationController>().Initialize(_moverController);
        gameObject.AddComponent<ItemCollector>().Initialize(_hand);
    }

    public void AddSpeeed(float addition)
    {
        _movementSpeed += addition;
        MoverControllerInitialize();
    }

    public void AddHealth(float addition)
    {
        _health += addition;
    }

    private void MoverControllerInitialize()
    {
        _moverController.Initialize(_movementSpeed, _rotationSpeed);
    }


}
