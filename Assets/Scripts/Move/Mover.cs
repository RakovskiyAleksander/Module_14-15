using UnityEngine;

public class Mover
{
    public void MoveObject(MovementSettings movementSettings)
    {
        movementSettings.CharacterRigidbody.velocity = movementSettings.CharacterRigidbody.transform.forward * movementSettings.VInput * movementSettings.Speed;
        movementSettings.CharacterRigidbody.angularVelocity = Vector3.up * movementSettings.HInput * movementSettings.RotationSpeed;
    }
}
