using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private List<Transform> _spawnPositions;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            var positionIndex = Random.Range(0, _spawnPositions.Count);

            Instantiate(_enemy, _spawnPositions[positionIndex].transform.position, Quaternion.identity);

            yield return new WaitForSeconds(_spawnDelay);
        }
    }
}
