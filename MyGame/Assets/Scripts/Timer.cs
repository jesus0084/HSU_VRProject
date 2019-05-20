using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = "You survived " + string.Format("{0:N2}",time) + "seconds!";
    }
}
