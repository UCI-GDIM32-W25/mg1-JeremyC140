using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        _playerTransform.position += Vector3.up * vertical * _speed * Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal");
        _playerTransform.position += Vector3.right * horizontal * _speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
            PlantSeed();
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft > 0)
        {
            _numSeedsLeft -= 1;
            _numSeedsPlanted += 1;
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
        }
    }
}
