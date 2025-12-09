using UnityEngine;

public class ItemBomb : Item
{
    [SerializeField] private float _explosionDelay;
    [SerializeField] private float _pullForse;

    public override bool CanUse(Character character)
    {
        return TryGetBomber(character, out Bomber bomber);
    }

    public override void Use(Character character)
    {
        if (TryGetBomber(character, out Bomber bomber))
        {
            bomber.DropBomb(PrepareBomb());
        }
    }

    protected override void DestroyItem()
    {
        
    }    

    private bool TryGetBomber(Character character, out Bomber bomber)
    {
        bool isGet = character.TryGetComponent<Bomber>(out Bomber characterBomber);
        bomber = characterBomber;

        return isGet;
    }

    private Bomb PrepareBomb()
    {
        transform.SetParent(null);
        GetComponent<SphereCollider>().isTrigger = false;
        Bomb bomb = gameObject.AddComponent<Bomb>();

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.isKinematic = false;
        rigidbody.useGravity = true;
        rigidbody.interpolation = RigidbodyInterpolation.Interpolate;

        return bomb;
    }
}
