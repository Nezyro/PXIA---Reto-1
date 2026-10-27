using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;
    [SerializeField] private float _spawnInterval = 2f;
    [SerializeField] private float _spawnRangeY = 4f;

    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;
        
        if (_timer >= _spawnInterval)
        {
            SpawnObstacle();
            _timer = 0f;
        }
    }

    private void SpawnObstacle()
    {
        float randomY = transform.position.y + Random.Range(-_spawnRangeY, _spawnRangeY);
        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0f);
        
        Instantiate(_obstaclePrefab, spawnPos, Quaternion.identity);
    }
}