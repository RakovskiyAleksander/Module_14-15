using UnityEngine;

public class Mover
{
    public void MoveCharacter(MovementSettings movementSettings)
    {
        movementSettings.CharacterRigidbody.velocity = movementSettings.CharacterRigidbody.transform.forward * movementSettings.VInput * movementSettings.Speed;
        movementSettings.CharacterRigidbody.angularVelocity = Vector3.up * movementSettings.HInput * movementSettings.RotationSpeed;
    }

    public void DropItem(Rigidbody rigidbody, Vector3 direction, float force)
    {
        rigidbody.AddForce(direction * force, ForceMode.Impulse);
    }

}

