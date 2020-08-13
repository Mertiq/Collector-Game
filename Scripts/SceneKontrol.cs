using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneKontrol : MonoBehaviour
{
    public Button buton;

    public GameObject imgsessiz;
    public GameObject imgsesli;

    int sayac = 0;

    public static int sesKontrol = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sahne()
    {
        SceneManager.LoadScene(1);
    }

    public void ses()
    {
        
        if(sayac % 2 == 0)
        {
            buton.image.sprite = imgsessiz.transform.GetComponent<SpriteRenderer>().sprite;
            sesKontrol = 0;
        }
        else
        {
            buton.image.sprite = imgsesli.transform.GetComponent<SpriteRenderer>().sprite;
            sesKontrol = 1;
        }

        sayac++;
    }
}
