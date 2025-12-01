using UnityEngine;

public class Game : MonoBehaviour
{
    [Header("Player settings")]
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private Vector3 _playerStartPosition;
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _playerRotationSpeed;

    private GameObject _player;

    private void Awake()
    {
        _player = AddGameObjectToScene(_playerPrefab, _playerStartPosition);
        _player.GetComponent<Character>().Initialize(_playerSpeed, _playerRotationSpeed);
    }

    private GameObject AddGameObjectToScene(GameObject gameObject, Vector3 startPosition)
    {
        GameObject newGameObject  = Instantiate(gameObject, startPosition, Quaternion.identity);
        return newGameObject;
    }
}
