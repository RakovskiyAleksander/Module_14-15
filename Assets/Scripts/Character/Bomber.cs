using UnityEngine;

public class Bomber : MonoBehaviour
{
    public void DropBomb(Bomb bomb, float explosionDelay, float pullForse)
    {
        bomb.Activate(explosionDelay);

        Mover mover = new Mover();
        Rigidbody rigidbody = bomb.GetComponent<Rigidbody>();
        Vector3 pullDirection = (Vector3.up + gameObject.transform.forward).normalized;
        mover.DropItem(rigidbody, pullDirection , pullForse);
    }
}
