using UnityEngine;

public class ItemHealthBoost : Item
{
    [SerializeField] float _healthAddition;

    public override bool CanUse(Character character)
    {
        return TryGetHealthController(character, out HealthController healthController);
    }

    public override void Use(Character character)
    {
        if (TryGetHealthController(character, out HealthController healthController))
        {
            healthController.AddHealth(_healthAddition);

            _useItemParticleSystem.Play();
            _useItemParticleSystem.transform.SetParent(null);

            DestroyItem();
        }
    }

    protected override void DestroyItem()
    {
        Destroy(gameObject);
    }

    private bool TryGetHealthController(Character character, out HealthController healthController)
    {
        bool isGet = character.TryGetComponent<HealthController>(out HealthController characterHealthController);
        healthController = characterHealthController;

        return isGet;
    }
}
