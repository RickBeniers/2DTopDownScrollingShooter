using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randEnemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }
    //call routine to spawn objects over and over again.
    IEnumerator WaitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (!stop)
        {
            //choose randomly which enemy is going to be picked for spawning.
            randEnemy = Random.Range(0, 6);
            //choose a random position for the enemy.
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), -10);
            //instantiate the enemy.
            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            //wait for the timer to completed to spawn again.
            yield return new WaitForSeconds(spawnWait);
        }

    }
}
