using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyuncuKontrol : MonoBehaviour
{
    Color benimrenk;

    int yani = 0;
    int skor = Yonetici.skor;

    public GameObject coin;
    public GameObject colorball;

    private Vector2 baslangic, bitis;

    AudioSource seskaynak;

    public AudioClip coinSound;

    int solkontrol = 0;
    int sagkontrol = 0;

    int arkaplansayaci = 0;

    int hareketkontrol = 0;


    // Start is called before the first frame update
    void Start()
    {
        seskaynak = GetComponent<AudioSource>();
        renkBelirle();
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if(hareketkontrol == 0)
        {

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                baslangic = Input.GetTouch(0).position;
            }
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                bitis = Input.GetTouch(0).position;

                if (bitis.x < baslangic.x)
                {
                    if (transform.position.x == 2.0f)
                    {
                        transform.position = new Vector3(0.8f, transform.position.y, transform.position.z);
                    }
                    else if (transform.position.x == 0.8f)
                    {
                        transform.position = new Vector3(-0.8f, transform.position.y, transform.position.z);
                    }
                    else if (transform.position.x == -0.8f)
                    {
                        transform.position = new Vector3(-2.0f, transform.position.y, transform.position.z);

                    }

                }
                if (bitis.x > baslangic.x)
                {
                    if (transform.position.x == -2.0f)
                    {
                        transform.position = new Vector3(-0.8f, transform.position.y, transform.position.z);
                    }
                    else if (transform.position.x == -0.8f)
                    {
                        transform.position = new Vector3(0.8f, transform.position.y, transform.position.z);
                    }
                    else if (transform.position.x == 0.8f)
                    {
                        transform.position = new Vector3(2.0f, transform.position.y, transform.position.z);
                    }

                }
            }
        }
        
        

    }

    public void renkBelirle()
    {
        int rastgeleSayi = Random.Range(0, 4);

        switch (rastgeleSayi)
        {
            case 0:
                GetComponent<SpriteRenderer>().color = Color.blue;
                break;
            case 1:
                GetComponent<SpriteRenderer>().color = Color.yellow;
                break;
            case 2:
                GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case 3:
                GetComponent<SpriteRenderer>().color = Color.green;
                break;

        }
        benimrenk = transform.GetComponent<SpriteRenderer>().color;
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        hareketkontrol = 1;
        Destroy(collision.transform.gameObject);

        if (collision.transform.GetComponent<SpriteRenderer>().sprite == null)
        {
            
        }
        else if (collision.transform.GetComponent<SpriteRenderer>().color == Color.blue)
        {
            if (benimrenk != Color.blue)
            {
                yani = 1;
            }
            else
            {
                Yonetici.skor++;
            }


        }
        else if (collision.transform.GetComponent<SpriteRenderer>().color == Color.yellow)
        {
            if (benimrenk != Color.yellow)
            {
                yani = 1;
            }
            else
            {
                Yonetici.skor++;
            }

        }
        else if (collision.transform.GetComponent<SpriteRenderer>().color == Color.red)
        {
            if (benimrenk != Color.red)
            {
                yani = 1;
            }
            else
            {
                Yonetici.skor++;
            }

        }
        else if (collision.transform.GetComponent<SpriteRenderer>().color == Color.green)
        {
            if (benimrenk != Color.green)
            {
                yani = 1;
            }
            else
            {
                Yonetici.skor++;
            }
            
        }
        else if (collision.transform.GetComponent<SpriteRenderer>().sprite == colorball.transform.GetComponent<SpriteRenderer>().sprite)
        {
            int rastgeleSayi = Random.Range(0, 4);

            switch (rastgeleSayi)
            {
                case 0:
                    GetComponent<SpriteRenderer>().color = Color.blue;
                    break;
                case 1:
                    GetComponent<SpriteRenderer>().color = Color.yellow;
                    break;
                case 2:
                    GetComponent<SpriteRenderer>().color = Color.red;
                    break;
                case 3:
                    GetComponent<SpriteRenderer>().color = Color.green;
                    break;

            }
            
            benimrenk = GetComponent<SpriteRenderer>().color;
        }
        else if (collision.transform.GetComponent<SpriteRenderer>().sprite == coin.transform.GetComponent<SpriteRenderer>().sprite)
        {
            Yonetici.skor += 10;
            playcoinsound();
        }
        Yonetici.yan = yani;

       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hareketkontrol = 0;
    }

    public void playcoinsound()
    {
        seskaynak.PlayOneShot(coinSound);
    }

}
