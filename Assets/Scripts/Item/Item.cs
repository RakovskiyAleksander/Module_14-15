using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] protected ParticleSystem _useItemParticleSystem;
    public void Collected(Transform hand)
    {
        gameObject.GetComponent<ItemSwing>().enabled = false;
        gameObject.transform.SetParent(hand, worldPositionStays: true);
        gameObject.transform.localPosition = Vector3.zero;
        gameObject.transform.localRotation = Quaternion.identity;
    }

    public abstract bool CanUse(Character character);

    public abstract void Use(Character character);

    protected abstract void DestroyItem();
}
