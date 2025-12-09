using UnityEngine;

public class ItemVelosityBoost : Item
{
    [SerializeField] float _speedAddition;

    public override bool CanUse(Character character)
    {
        return TryGetSpeedController(character, out SpeedController speedController); ;
    }

    public override void Use(Character character)
    {
        if (TryGetSpeedController(character, out SpeedController speedController))
        {
            speedController.AddSpeed(_speedAddition);

            _useItemParticleSystem.Play();
            _useItemParticleSystem.transform.SetParent(null);

            DestroyItem();
        }
    }

    protected override void DestroyItem()
    {
        Destroy(gameObject);
    }

    private bool TryGetSpeedController(Character character, out SpeedController speedController)
    {
        bool isGet = character.TryGetComponent<SpeedController>(out SpeedController characterSpeedController);
        speedController = characterSpeedController;

        return isGet;
    }
}
