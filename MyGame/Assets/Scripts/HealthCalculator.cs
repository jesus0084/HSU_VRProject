using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCalculator : MonoBehaviour
{
    public int HP;
    public Text HealthText;
    public Text PresentScore;
    public Text TotalScore;
    [SerializeField] private AudioClip hurtSound;
    public Camera FirstPersonCam;
    public Camera ThirdPersonCam;

    AudioSource eventAudio;

    // Start is called before the first frame update
    void Start()
    {
        eventAudio = GetComponent<AudioSource>();
        ThirdPersonCam.gameObject.SetActive(false);
        FirstPersonCam.gameObject.SetActive(true);
        HP = 10;
        HealthText.text = "HP : ■■■■■■■■■■";
    }

    // Update is called once per frame
    void Update()
    {

        switch (HP){
            case 10: HealthText.text = "HP : ■■■■■■■■■■"; break;
            case 9: HealthText.text = "HP : ■■■■■■■■■"; break;
            case 8: HealthText.text = "HP : ■■■■■■■■"; break;
            case 7: HealthText.text = "HP : ■■■■■■■";  break;
            case 6: HealthText.text = "HP : ■■■■■■"; break;
            case 5: HealthText.text = "HP : ■■■■■"; break;
            case 4: HealthText.text = "HP : ■■■■"; break;
            case 3: HealthText.text = "HP : ■■■"; break;
            case 2: HealthText.text = "HP : ■■"; break;
            case 1: HealthText.text = "HP : ■"; break;
            case 0:
                {
                    ThirdPersonCam.gameObject.SetActive(true);
                    gameObject.SetActive(false);
                    TotalScore.text = PresentScore.text;
                    break;
                }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Respawn")
        {
            eventAudio.clip = hurtSound;
            eventAudio.Play();
            HP--;
            
        }
    }
}
