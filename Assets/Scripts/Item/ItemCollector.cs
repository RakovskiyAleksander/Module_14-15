using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private Transform _hand;
    private bool _isFull;
    private Item _itemInHand;

    public void Initialize(Transform hand)
    {
        _hand = hand;
        _isFull = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Item item;

        if (_isFull == false)
        {
            if (other.TryGetComponent<Item>(out item))
            {
                _isFull = true;
                _itemInHand = item;
                _itemInHand.Collected(_hand);
            }
        }

    }
}
