using UnityEngine;

public class MoverController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _movementSpeed;
    private float _rotationSpeed;

    private float _vInput;
    private float _hInput;

    private Mover _mover;

    public bool IsMove { get; private set; }

    public void Initialize(float movementSpeed, float rotationSpeed)
    {
        _rigidbody = GetComponent<Rigidbody>();
        _movementSpeed = movementSpeed;
        _rotationSpeed = rotationSpeed;

        _mover = new Mover();
    }

    private void Update()
    {
        _vInput = Input.GetAxisRaw("Vertical");
        _hInput = Input.GetAxisRaw("Horizontal");

        if (_vInput != 0) IsMove = true;
        else IsMove = false;
    }

    private void FixedUpdate()
    {
        MovementSettings movementSetting = new MovementSettings(_rigidbody, _movementSpeed, _rotationSpeed, _vInput, _hInput);
        _mover.MoveObject(movementSetting);
    }
}
