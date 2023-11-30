using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
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
            var waitForSeconds = new WaitForSeconds(_spawnDelay);

            var positionIndex = Random.Range(0, _spawnPositions.Count);

            Instantiate(_template, _spawnPositions[positionIndex].transform.position, Quaternion.identity);

            yield return waitForSeconds;
        }
    }
}
