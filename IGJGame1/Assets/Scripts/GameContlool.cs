using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContlool : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MusicItem;
    public bool GameFlag = false;
    private AudioSource Audio;
    private float saveTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Audio = MusicItem.GetComponent<AudioSource>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GameFlag == false)
            {
                GameFlag = true;
                Audio.time = saveTime;
                Audio.Play();
            }
            else if (GameFlag == true)
            {
                GameFlag = false;
                saveTime = Audio.time;
                Audio.Stop();
            }
        }
         

    }
}
