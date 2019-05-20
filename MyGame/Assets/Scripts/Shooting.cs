using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{

    float bulletSpeed = 1100.0f;
    float BombSpeed = 1000.0f;
    public GameObject bullet;
    public GameObject Bomb;
    AudioSource bulletAudio;
    public int bombcount;
    public Text Bombcounter;

    // Use this for initialization
    void Start()
    {
        bombcount = 10;
        bulletAudio = GetComponent<AudioSource>();
        Bombcounter.text = "Bombs : " + bombcount;
    }

    void FireGun()
    {
        //Shoot
        GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidBodyBullet = tempBullet.GetComponent<Rigidbody>();
        tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * bulletSpeed);
        Destroy(tempBullet, 10.0f);

        //Play Audio
        bulletAudio.Play();

    }
    void FireBomb()
    {
        //Shoot
        GameObject tempBumb = Instantiate(Bomb, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidBodyBullet = tempBumb.GetComponent<Rigidbody>();
        tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * BombSpeed);
        Destroy(tempBumb, 10.0f);
        bombcount--;
        Bombcounter.text = "Bombs : " + bombcount;
        //Play Audio
        //bulletAudio.Play();

    }


    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)||Input.GetButtonDown("Fire1"))
        {
            FireGun();
        }
        if ((Input.GetMouseButtonDown(1) || Input.GetButtonDown("Fire2")) && bombcount>0)
        {
            FireBomb();
        }
    }
}
