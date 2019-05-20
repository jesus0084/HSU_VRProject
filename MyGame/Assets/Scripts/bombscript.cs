using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombscript : MonoBehaviour
{
    public GameObject killEffect;
    public GameObject lastEffect;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    //private void OnCollisionEnter(Collision collision)
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag != "Player")
        {

            //Destroy(collision.gameObject);
            Instantiate(killEffect, gameObject.transform.position, gameObject.transform.rotation);
            Instantiate(lastEffect, gameObject.transform.position, gameObject.transform.rotation);
            //gameObject.SetActive(false);


        }
        if (collision.transform.tag == "Respawn")
        {
            Destroy(collision.gameObject);
            Instantiate(killEffect, gameObject.transform.position, gameObject.transform.rotation);
            Instantiate(lastEffect, gameObject.transform.position, gameObject.transform.rotation);
            gameObject.SetActive(false);
        }
    }


}
