using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _delay;

    private float _lastSpawnTime;

    private void Update()
    {
        if (_lastSpawnTime <= 0)
        {
            InstantiateEnemy();
            _lastSpawnTime = _delay;
        }

        _lastSpawnTime -= Time.deltaTime;
    }

    private void InstantiateEnemy()
    {
        Enemy enemy = Instantiate(_enemy, _spawnPoints[Random.Range(0, _spawnPoints.Count)].transform.position, Quaternion.identity);
        enemy.Init(_endPosition);
    }
}
