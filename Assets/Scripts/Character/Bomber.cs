using UnityEngine;

public class Bomber : MonoBehaviour
{
    public void DropBomb(Bomb bomb)
    {
        Mover mover = new Mover();
        Rigidbody rigidbody = bomb.GetComponent<Rigidbody>();
        mover.DropItem(rigidbody, Vector3.up, 10);
    }
}
