using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemiesPrefab;
    private Vector3 spawnPos = new Vector3(9, -3, 0);
    private float startDelay = 2;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnObstacle" , startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
}

    void SpawnObstacle()
    {
        int enemyIndex = Random.Range(0, enemiesPrefab.Length);
        Instantiate(enemiesPrefab[enemyIndex], spawnPos, enemiesPrefab[enemyIndex].transform.rotation);
    }
}
