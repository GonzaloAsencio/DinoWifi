using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int poolSize = 10;
    [SerializeField] private List<GameObject> enemyList = new List<GameObject>();

    private static PoolObject instance;
    public static PoolObject poolObject { get { return instance; } }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        AddEnemyToPool(poolSize);
    }

    private void AddEnemyToPool(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject Enemy = Instantiate(enemyPrefab);
            Enemy.SetActive(false);
            enemyList.Add(Enemy);
            Enemy.transform.parent = transform;
        }
    }

    public GameObject RequestPrefab()
    {
        for (int i = 0; i < enemyList.Count; i++)
        {
            
            if (!enemyList[i].activeSelf)
            {
                enemyList[i].SetActive(true);
                return enemyList[i];
            }
        }
        return null;




        /*AddEnemyToPool(1);
        enemyList[enemyList.Count - 1].SetActive(true);
        return enemyList[enemyList.Count - 1];*/
    }
}
