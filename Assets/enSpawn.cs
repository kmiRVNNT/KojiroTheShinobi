using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enSpawn : MonoBehaviour

[SerializeField]
private GameObject _enemyPrefab;

[SerializeField]

private float _minimumSpawnTime;

[SerializeField]

private float _maximumSpawnTime;


private float _timeUntilSpawn;

public class enSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        SetTimeUntilSPawn();
    }

    // Update is called once per frame
    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;

        if (_timeUntilSpawn <= 0)
        {
            Instantiate(_enemyPrefab, transform.position, Quaternion.identity)
            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSPawn() 
    {
        _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}
