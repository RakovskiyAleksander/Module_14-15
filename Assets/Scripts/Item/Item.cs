using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public void Collected(Transform hand)
    {
        gameObject.GetComponent<ItemSwing>().enabled = false;
        gameObject.transform.SetParent(hand, worldPositionStays: true);
        gameObject.transform.localPosition = Vector3.zero;
        gameObject.transform.localRotation = Quaternion.identity;
    }
}
