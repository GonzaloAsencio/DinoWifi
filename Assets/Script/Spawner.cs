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
            int randomEnemy = Random.Range(0, enemies.Length);
            Instantiate(enemies[randomEnemy], transform.position, Quaternion.identity);

            yield return new WaitForSeconds(SpawnTime);

        }


    }

}
