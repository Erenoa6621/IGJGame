using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private int A;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"Score : {PlayerPrefs.GetInt("SCORE", 0)}";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Endtitle();
        }
    }
    public void Endtitle()
    {
        SceneManager.LoadScene("TiTle");
    }
}
