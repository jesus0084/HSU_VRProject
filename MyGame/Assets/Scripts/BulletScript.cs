using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
    public GameObject killEffect;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //private void OnCollisionEnter(Collision collision)
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Respawn")
        {
            
            Destroy(collision.gameObject);
            Instantiate(killEffect, gameObject.transform.position, gameObject.transform.rotation);
            gameObject.SetActive(false);
            

        }
    }


}
