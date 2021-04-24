using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

 
    [SerializeField] private Transform levelPart1;
    [SerializeField] private Transform levelPart2;
    [SerializeField] private Transform levelPart3;
    [SerializeField] private Transform levelPart4;
    private void Awake() {

        //level 1
        int xPosition = 16;
        for (int i = 0; i < 10; i++)
        {
            SpawnLevelPart(levelPart1, new Vector3(xPosition, 1));
            xPosition += 16;
        }

        //level 2
        xPosition -= 35;
        for (int i = 0; i < 10; i++)
        {
            SpawnLevelPart(levelPart2, new Vector3(xPosition, 0));
            xPosition += 30;
        }

        //level 3
        xPosition += 30;
        for (int i = 0; i < 10; i++)
        {
            SpawnLevelPart(levelPart3, new Vector3(xPosition, -3));
            xPosition += 16;
        }

        //level 4
        xPosition -= 2;
        for (int i = 0; i < 10; i++)
        {
            SpawnLevelPart(levelPart4, new Vector3(xPosition, -4));
            xPosition += 20;
        }

    }
    private void SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Instantiate(levelPart, spawnPosition, Quaternion.identity);

    }
}
