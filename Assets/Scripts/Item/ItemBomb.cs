using UnityEngine;

public class ItemBomb : Item
{
    [SerializeField] private float _explosionDelay;
    [SerializeField] private float _pullForse;

    private bool _BombIsActive = false;
    private CountdownTimer _countdownTimer;

    public override void Use(Character character)
    {
        transform.SetParent(null);
        GetComponent<SphereCollider>().isTrigger = false;

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.isKinematic = false;
        rigidbody.useGravity = true;
        rigidbody.interpolation = RigidbodyInterpolation.Interpolate;

        Vector3 pullDirection = (character.transform.forward + character.transform.up).normalized * _pullForse;
        rigidbody.AddForce(pullDirection, ForceMode.Impulse);

        DestroyItem();
    }

    protected override void DestroyItem()
    {
        _countdownTimer = new CountdownTimer(_explosionDelay);
        _BombIsActive = true;
    }

    private void Update()
    {
        if (_BombIsActive)
        {
            _countdownTimer.Update();

            if (_countdownTimer.TimeIsOver)
            {
                ExplodeBomb();
            }
        }
    }

    private void ExplodeBomb()
    {
        _useItemParticleSystem.transform.SetParent(null);
        _useItemParticleSystem.transform.rotation = Quaternion.Euler(-90, 0, 0);
        _useItemParticleSystem.Play();

        Destroy(gameObject);
    }

    public override bool CanUse(Character character)
    {
        return true;
    }
}
