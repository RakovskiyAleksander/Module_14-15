using UnityEngine;

public class Character : MonoBehaviour
{
    private float _movementSpeed;
    private float _rotationSpeed;
    

    public void Initialize(float movementSpeed, float rotationSpeed)
    {
        _movementSpeed = movementSpeed;
        _rotationSpeed = rotationSpeed;

        MoverController moverController = gameObject.AddComponent<MoverController>();
        moverController.Initialize(_movementSpeed, _rotationSpeed);

        gameObject.AddComponent<CharacterAnimationController>().Initialize(moverController);
    }
}
