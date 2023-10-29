using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawnerController : MonoBehaviour
{
    public GameObject Enemy;
    public int numberOfTanksToSpawn = 10; 

    void Start()
    {
        SpawnTanks();
    }

    void SpawnTanks()
    {
        for (int i = 0; i < numberOfTanksToSpawn; i++)
        {

            Vector3 spawnPosition = new Vector3(Random.Range(-30f, 30f), Random.Range(-30f, 30f), 0);


            GameObject newTank = Instantiate(Enemy, spawnPosition, Quaternion.identity);

        
        }
    }
}
