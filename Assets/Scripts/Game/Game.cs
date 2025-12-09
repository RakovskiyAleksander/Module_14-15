using UnityEngine;

public class Game : MonoBehaviour
{
    [Header("Player settings")]
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private Vector3 _playerStartPosition;
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _playerRotationSpeed;
    [SerializeField] private float _playerStartHealth;

    private GameObject _player;
    private Character _characterByPlayer;

    private HealthController _playerHealthController;
    private SpeedController _playerSpeedController;

    private void Awake()
    {
        _player = AddGameObjectToScene(_playerPrefab, _playerStartPosition);
        _characterByPlayer = _player.GetComponent<Character>();
        _characterByPlayer.Initialize(_playerSpeed, _playerRotationSpeed, _playerStartHealth);
        
        _playerHealthController = _characterByPlayer.GetComponent<HealthController>();
        _playerSpeedController = _characterByPlayer.GetComponent<SpeedController>();
    }

    private GameObject AddGameObjectToScene(GameObject gameObject, Vector3 startPosition)
    {
        GameObject newGameObject = Instantiate(gameObject, startPosition, Quaternion.identity);
        return newGameObject;
    }

    void OnGUI()
    {
        GUI.Box(new Rect(40, 40, 250, 25), "Здоровье: " + _playerHealthController.Health);
        GUI.Box(new Rect(40, 80, 250, 25), "Скорость: " + _playerSpeedController.Speed);
    }
}
