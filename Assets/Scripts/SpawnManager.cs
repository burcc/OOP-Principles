using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float zRangeMax = 40.0f;
    public float zRangeMin = 0.0f;
    public float xRangeMax = 165.0f;
    public float xRangeMin = 154.0f;

    public GameObject[] enemyArray;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateSpawnPosition", 2, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }
    private void GenerateSpawnPosition()
    {
        float spawnPosZ = Random.Range(zRangeMin, zRangeMax);
        float spawnPosX = Random.Range(xRangeMin, xRangeMax);
        Vector3 randomPos = new Vector3(spawnPosX,18.0f, spawnPosZ);
        int enemyIndex = Random.Range(0, enemyArray.Length);
        Instantiate(enemyArray[enemyIndex], randomPos, enemyArray[enemyIndex].transform.rotation);
        
        
       
    }

    /*private void SpawnEnemy(int enemiesToSpawn)
    {
        int enemyIndex = Random.Range(0, enemyArray.Length);
        for (int i =0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyArray[enemyIndex], GenerateSpawnPosition(), enemyArray[enemyIndex].transform.rotation);
        }

    }*/
}
