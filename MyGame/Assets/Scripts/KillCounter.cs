using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    private GameObject target;
    //public ParticleSystem hitEffect;
    public GameObject killEffect;
    public int score;

    

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        //hitEffect.enableEmission = false;
        target = GameObject.FindWithTag("Respawn");

    }

    // Update is called once per frame
    void Update()
    {
        Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward);
        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 100.0f);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && (hit.collider.gameObject == GameObject.FindWithTag("Respawn")))
        {
            if (Input.GetButton("Fire1"))
            {
                Instantiate(killEffect, target.transform.position, target.transform.rotation);
                score++;
            }
        }
    }
}
