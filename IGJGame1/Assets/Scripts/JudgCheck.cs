using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public int type;
    public GameObject ScoreText;
    public int BeterScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (type == 0)
            {
                Cont(KeyCode.RightArrow);
                Destroy(other);
            }
            else if (type == 1)
            {
                Cont(KeyCode.LeftArrow);
                Destroy(other);
            }
            else if (type == 2)
            {
                Cont(KeyCode.DownArrow);
                Destroy(other);
            }
            else if (type == 3)
            {
                Cont(KeyCode.UpArrow);
                Destroy(other);
            }
            //ScoreText.GetComponent<ScoreManager>().Score += BeterScore;
            
        }
        Debug.Log("あたった");
    }

    private void Cont(KeyCode AA)
    {
        if (Input.GetKey(AA))
        {
            ScoreText.GetComponent<ScoreManager>().Score += BeterScore; 
        }
    }
}
