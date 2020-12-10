using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Seen : MonoBehaviour
{
    // Start is called before the first frame update
    // Use this for initialization
    
    void Start()
    {
        Invoke("ChangeScene", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainSceneGo()
    {
        SceneManager.LoadScene("KentoMatsunaga");
    }
    public void ENd()
    {
        Application.Quit();
    }
}
