using UnityEngine;

public class MoverController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private SpeedController _speedController;
    private float _rotationSpeed;

    private float _vInput;
    private float _hInput;

    private Mover _mover;

    public bool IsMove { get; private set; }

    public void Initialize(SpeedController speedController, float rotationSpeed)
    {
        _rigidbody = GetComponent<Rigidbody>();
        _speedController = speedController;
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
        MovementSettings movementSetting = new MovementSettings(_rigidbody, _speedController.Speed, _rotationSpeed, _vInput, _hInput);
        _mover.MoveCharacter(movementSetting);
    }
}
