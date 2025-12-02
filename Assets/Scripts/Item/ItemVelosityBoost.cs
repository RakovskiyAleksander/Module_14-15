using UnityEngine;

public class ItemVelosityBoost : Item
{
    [SerializeField] float _speedAddition;

    public override void Use(Character character)
    {
        character.AddSpeeed(_speedAddition); 

        _useItemParticleSystem.Play();
        _useItemParticleSystem.transform.SetParent(null);

        DestroyItem();
    }

    protected override void DestroyItem()
    {
        Destroy(gameObject);
    }
}
