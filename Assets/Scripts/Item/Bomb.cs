using UnityEngine;

public class Bomb : MonoBehaviour
{
    private bool _BombIsActive = false;
    private CountdownTimer _countdownTimer;

    public void Activate(float explosionDelay) 
    {
        _countdownTimer = new CountdownTimer(explosionDelay);
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
        ParticleSystem useItemParticleSystem = GetComponent<ItemBomb>().GetUseItemParticleSystem();

        useItemParticleSystem.transform.SetParent(null);
        useItemParticleSystem.transform.rotation = Quaternion.Euler(-90, 0, 0);
        useItemParticleSystem.Play();

        Destroy(gameObject);
    }
}
