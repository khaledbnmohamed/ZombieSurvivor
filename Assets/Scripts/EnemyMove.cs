using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    Transform camTrans;
    public float speed = 40;

	// Use this for initialization
	void Start () {

        camTrans = Camera.main.transform;

	}
	
	// Update is called once per frame
	void Update () {

        var direction = camTrans.position - transform.position;
        direction.Normalize();
        Vector3 vel = speed * direction * Time.deltaTime; 
        transform.position += vel;
		
	}
}
