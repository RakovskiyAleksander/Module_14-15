using UnityEngine;

public class MovementSettings
{
    public Rigidbody CharacterRigidbody;
    public float Speed;
    public float RotationSpeed;
    public float VInput;
    public float HInput;
    
    public MovementSettings(Rigidbody characterRigidbody, float speed, float rotationSpeed, float vInput, float hInput)
    {
        CharacterRigidbody = characterRigidbody;
        Speed = speed;
        RotationSpeed = rotationSpeed;
        VInput = vInput;
        HInput = hInput;       
    }
}
