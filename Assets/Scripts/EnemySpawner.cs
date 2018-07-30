using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public GameObject zombiePrefab;
    public float timetoSpawn = 0.5f;
    public float rangetpSawn = 4;
    public float timer ;

    // Use this for initialization
    void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if (timer < timetoSpawn) return;

        timer = 0;

        GameObject enemy = Instantiate(zombiePrefab);
        Vector3 pos = transform.position;
        pos.x = Random.Range(-rangetpSawn, rangetpSawn);
        //pos. = Random.Range(-rangetpSawn, rangetpSawn);
        pos.x += transform.position.x;
        pos.y += transform.position.y;
        pos.z += transform.position.z;

        enemy.transform.position = pos;
       
		
	}
}
