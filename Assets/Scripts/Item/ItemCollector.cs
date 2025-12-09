using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private Transform _hand;
    private bool _handIsFull;
    private Item _itemInHand;
    private Character _character;

    public void Initialize(Transform hand)
    {
        _hand = hand;
        _handIsFull = false;
        _character = GetComponent<Character>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Item item;

        if (_handIsFull == false)
        {
            if (other.TryGetComponent<Item>(out item) && item.CanUse(_character))
            {
                _handIsFull = true;
                _itemInHand = item;
                _itemInHand.Collected(_hand);
            }
        }
    }

    private void Update()
    {
        if (_handIsFull == false && (Input.GetKeyDown(KeyCode.F)))
        {
            Debug.Log("В руках ничего нет!");
        }

        if (_handIsFull == true && (Input.GetKeyDown(KeyCode.F)))
        {
            _itemInHand.Use(_character);
            _handIsFull = false;
            _itemInHand = null;
        }
    }
}
