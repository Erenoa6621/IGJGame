using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public int type;
    public GameObject ScoreText;
    public int BeterScore;
    public GameObject HitUI;
    private Transform tra;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        tra = this.gameObject.transform;
        Vector3 A = tra.position; 
        if (other.gameObject.tag == "Enemy")
        {
            if (type == 0)
            {
                Cont(KeyCode.D,other);
                Instantiate(HitUI,A,Quaternion.Euler(0f,-90f,0f));

            }
            else if (type == 1)
            {
                Cont(KeyCode.A,other);
                Instantiate(HitUI, A, Quaternion.Euler(0f, -90f, 0f));
            }
            else if (type == 2)
            {
                Cont(KeyCode.S,other);
                Instantiate(HitUI, A, Quaternion.Euler(0f, -90f, 0f));
            }
            else if (type == 3)
            {
                Cont(KeyCode.W,other);
                Instantiate(HitUI, A, Quaternion.Euler(0f, -90f, 0f));
            }
            //ScoreText.GetComponent<ScoreManager>().Score += BeterScore;
            
        }
        Debug.Log("あたった");
    }

    private void Cont(KeyCode AA,Collider A)
    {
        if (Input.GetKey(AA))
        {
            ScoreText.GetComponent<ScoreManager>().Score += BeterScore;
            Destroy(A.gameObject);
        }
    }
}
