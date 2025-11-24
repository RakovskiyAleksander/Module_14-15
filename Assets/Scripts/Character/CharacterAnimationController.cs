using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator _animator;
    private MoverController _moverController;
    private bool _isMove = false;

    public void Initialize(MoverController moverController)
    {
        _animator = GetComponentInChildren<Animator>();
        _moverController = moverController;
    }

    private void Update()
    {
        if (_isMove == false && _moverController.IsMove == true)
        {
            _isMove = true;
            _animator.SetTrigger("StartMove");
        }
        
        if (_isMove == true && _moverController.IsMove == false)
        {
            _isMove = false;
            _animator.SetTrigger("StopMove");
        }
    }
}
