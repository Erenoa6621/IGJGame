using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text ScoreText;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = $"Score : {Score}";
    }
}
