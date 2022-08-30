using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;

    public float SpawnTime;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());

    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            GameObject Enemy = PoolObject.poolObject.RequestPrefab();
            Enemy.transform.position = this.transform.position;
            yield return new WaitForSeconds(SpawnTime);

        }


    }

}
