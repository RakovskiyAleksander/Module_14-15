using UnityEngine;

public class ItemSwing : MonoBehaviour
{
    [SerializeField] AnimationCurve _verticalSwingCurve;
    [SerializeField] AnimationCurve _rotationCurve;

    private float _startHeight;
    private float _fullTurnAngel = 360f;
    private float _randomTimeOffsetHeight;
    private float _randomTimeOffsetAngle;

    private void Awake()
    {
        _startHeight = transform.position.y;
        _randomTimeOffsetHeight = Random.Range(0f, _verticalSwingCurve.length);
        _randomTimeOffsetAngle = Random.Range(0f, _rotationCurve.length);
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, _startHeight + _verticalSwingCurve.Evaluate(Time.time + _randomTimeOffsetHeight), transform.position.z);
        transform.rotation = Quaternion.Euler(0, _rotationCurve.Evaluate(Time.time + _randomTimeOffsetAngle) * _fullTurnAngel, 0);
    }
}
