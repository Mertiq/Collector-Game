using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorKontrol : MonoBehaviour
{

    public Text txt;
    public Text hightxt;

    public int skor;
    public int highskor = Yonetici.highskor;

    // Start is called before the first frame update
    void Start()
    {
        skor = Yonetici.skor;
         highskor = PlayerPrefs.GetInt("puan");

        if (skor > highskor)
        {
            PlayerPrefs.SetInt("puan", skor);
            hightxt.text = "HIGHSCORE\n" + skor.ToString();
            txt.text = "SCORE\n" + skor.ToString();
        }
        else
        {
           
            hightxt.text = "HIGHSCORE\n" + highskor.ToString();
            txt.text = "SCORE\n" + skor.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
