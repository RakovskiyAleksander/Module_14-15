using UnityEngine;

public class ItemHealthBoost : Item
{
    [SerializeField] float _healthAddition;

    public override void Use(Character character)
    {
        character.AddHealth(_healthAddition);

        _useItemParticleSystem.Play();
        _useItemParticleSystem.transform.SetParent(null);

        DestroyItem();
    }

    protected override void DestroyItem()
    {
        Destroy(gameObject);
    }
}
