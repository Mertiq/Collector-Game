using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Yonetici : MonoBehaviour
{
    public GameObject gelenler;
    public GameObject audi;

    public static int skor = 0;
    public static int highskor = 0;

    public static int yan = 0;

    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        skor = 0;
        InvokeRepeating("gelsinler", 0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = skor.ToString();
        if(yan == 1)
        {
            yan = 0;
            SceneManager.LoadScene(2);
        }
        if(SceneKontrol.sesKontrol == 1)
        {
            audi.transform.GetComponent<AudioSource>().volume = 1;
        }
        else
        {
            audi.transform.GetComponent<AudioSource>().volume = 0;
        }
    }

    public void gelsinler()
    {
        GameObject geliyolar = Instantiate(gelenler);
        
    }


   
}
