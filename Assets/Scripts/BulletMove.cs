using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMove : MonoBehaviour {
    Rigidbody m_Rigidbody;
    Vector3 m_NewForce;

    public float speed = 40f;
    	// Use this for initialization
	void Start () {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_NewForce = new Vector3(-0.5f, 0.0f, 0.0f);

        Destroy(this.gameObject, 10f);
        m_Rigidbody.AddForce(m_NewForce, ForceMode.Impulse);

    }
	
	// Update is called once per frame
	void Update () {

        //transform.position += transform.forward * speed * Time.deltaTime;
    }
}
