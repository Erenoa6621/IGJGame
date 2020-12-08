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

    private void OnCollisionEnter(Collision other)  
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (type == 0)
            {
                Cont(KeyCode.RightArrow, other);
               
            }
            else if (type == 1)
            {
                Cont(KeyCode.LeftArrow, other);
           
            }
            else if (type == 2)
            {
                Cont(KeyCode.DownArrow, other);
    
            }
            else if (type == 3)
            {
                Cont(KeyCode.UpArrow, other);
              
            }
            //ScoreText.GetComponent<ScoreManager>().Score += BeterScore;
            
        }
        Debug.Log("あたった");
    }

    private void Cont(KeyCode AA, Collision other)
    {
        if (Input.GetKeyDown(AA))
        {
            ScoreText.GetComponent<ScoreManager>().Score += BeterScore; 
            Destroy(other.gameObject);
        }
    }
}
