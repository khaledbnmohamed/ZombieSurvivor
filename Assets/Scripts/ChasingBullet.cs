using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingBullet : MonoBehaviour
{

    Rigidbody rb;
    Transform Enem;
    public float speed = 40f;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Enem
        Destroy(this.gameObject, 70f);
        //Enem = EnemySpawner.zombiePrefab.transform;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float max = 10000;
        int order = 0;
        var enemyArray = GameObject.FindGameObjectsWithTag("enemy");
        for (int i = 0; i < enemyArray.Length; i++)
        {
            var x = enemyArray[i].transform.position - this.transform.position;

            float y = Vector3.Magnitude(x);
            //var z = Vector3.Distance(enemyArray[i].transform.position, this.transform.position);

            if (max > y)
            {
                max = y;
                order = i;
            }

        }
        Enem = enemyArray[order].transform;

        var direction = Enem.position - transform.position;
        direction.Normalize();

        rb.AddForce(direction * speed);
    }
}
