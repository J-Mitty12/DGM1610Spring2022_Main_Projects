using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powewrup;
    public bool spawn = true;
    public float spawntime = 1f;
    private float zEnemySpawn = 12.0f;
    private float xSpawnRange = 16.0f;
    private float zPowerupRange = 5.0f;
    private float ySpawn = 0.75f;
    // Start is called before the first frame update
    private WaitForSeconds wfs = new WaitForSeconds(1);
    void Start()
    {
        //StartCoroutine(Spawner());
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
        //yield StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        while (spawn)
        {
            //SpawnEnemy();
            //Debug.Log("wait");
            yield return new WaitForSeconds(spawntime);

            SpawnEnemy();
        }
    }
    void SpawnEnemy()
    {
        if (enemies == null)
        {
            Debug.Log("no enemies");
        }
        else
        {
            float randomX = Random.Range(-xSpawnRange, xSpawnRange);
            int randomIndex = Random.Range(0, (enemies.Length -1));

            Vector3 spawnPos = new Vector3(randomX, 0.75f, zEnemySpawn);

            Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);

        }
    }
}
