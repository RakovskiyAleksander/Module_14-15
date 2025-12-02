using UnityEngine;

public class Game : MonoBehaviour
{
    [Header("Player settings")]
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private Vector3 _playerStartPosition;
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _playerRotationSpeed;
    [SerializeField] private float _playerHealth;

    private GameObject _player;
    private Character _characterByPlayer;

    private void Awake()
    {
        _player = AddGameObjectToScene(_playerPrefab, _playerStartPosition);
        _characterByPlayer = _player.GetComponent<Character>();
        _characterByPlayer.Initialize(_playerSpeed, _playerRotationSpeed, _playerHealth);
    }

    private GameObject AddGameObjectToScene(GameObject gameObject, Vector3 startPosition)
    {
        GameObject newGameObject = Instantiate(gameObject, startPosition, Quaternion.identity);
        return newGameObject;
    }

    void OnGUI()
    {
        GUI.Box(new Rect(40, 40, 250, 25), "Здоровье: " + _characterByPlayer.Health);
        GUI.Box(new Rect(40, 80, 250, 25), "Скорость: " + _characterByPlayer.Speed);
    }
}
