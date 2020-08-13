using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Gelenler : MonoBehaviour
{

    public Color renk1;
    public Color renk2;
    public Color renk3;
    public Color renk4;

    public int control = 0;

    public int birCont = 0;
    public int ikiCont = 0;
    public int ucCont = 0;
    public int dortCont = 0;

    public GameObject coin;
    public GameObject colorball;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, 6.6f, transform.position.z);

        Transform bir =  transform.GetChild(0);
        Transform iki = transform.GetChild(1);
        Transform uc = transform.GetChild(2);
        Transform dort = transform.GetChild(3);

        


        for (int i = 0; i < 100; i++)
        {
            /*
            if (birCont == 1 && ikiCont == 1 && ucCont == 1 && dortCont == 1)
            {
                if(control == 1)
                {
                    break;
                }
                else
                {
                    i = 0;
                    continue;
                }
                
            }
            
            */


            int a = Random.Range(0, 4);
            int b = bilmiyorum(a);
            Color x = metot();
            

            
            if (b == 4)
            {
                if(x == Color.magenta)
                {
                    dort.GetComponent<SpriteRenderer>().sprite = coin.transform.GetComponent<SpriteRenderer>().sprite;
                    dort.localScale = new Vector3(0.08f, 0.08f, 1f);
                }
                else if (x == Color.white)
                {
                    dort.GetComponent<SpriteRenderer>().sprite = colorball.transform.GetComponent<SpriteRenderer>().sprite;
                    dort.localScale = new Vector3(0.13f, 0.13f, 1f);
                }
                else if (x == Color.black)
                {
                    bir.GetComponent<SpriteRenderer>().sprite = null;
                }
                else
                {
                    dort.GetComponent<SpriteRenderer>().color = x;
                }
                
                continue;

            }
            else if (b == 3)
            {
                if (x == Color.magenta)
                {
                    uc.GetComponent<SpriteRenderer>().sprite = coin.transform.GetComponent<SpriteRenderer>().sprite;
                    uc.localScale = new Vector3(0.08f, 0.08f, 1f);
                }
                else if (x == Color.white)
                {
                    uc.GetComponent<SpriteRenderer>().sprite = colorball.transform.GetComponent<SpriteRenderer>().sprite;
                    uc.localScale = new Vector3(0.13f, 0.13f, 1f);
                }
                else if (x == Color.black)
                {
                    bir.GetComponent<SpriteRenderer>().sprite = null;
                }
                else
                {
                    uc.GetComponent<SpriteRenderer>().color = x;
                }
                
                continue;
            }
            else if(b == 2)
            {
                if (x == Color.magenta)
                {
                    iki.GetComponent<SpriteRenderer>().sprite = coin.transform.GetComponent<SpriteRenderer>().sprite;
                    iki.localScale = new Vector3(0.08f, 0.08f, 1f);
                }
                else if (x == Color.white)
                {
                    iki.GetComponent<SpriteRenderer>().sprite = colorball.transform.GetComponent<SpriteRenderer>().sprite;
                    iki.localScale = new Vector3(0.13f, 0.13f, 1f);
                }
                else if (x == Color.black)
                {
                    bir.GetComponent<SpriteRenderer>().sprite = null;
                }
                else
                {
                    iki.GetComponent<SpriteRenderer>().color = x;
                }
                continue;

            }
            else if(b == 1)
            {
                if (x == Color.magenta)
                {
                    bir.GetComponent<SpriteRenderer>().sprite = coin.transform.GetComponent<SpriteRenderer>().sprite;
                    bir.localScale = new Vector3(0.08f, 0.08f, 1f);
                }
                else if(x == Color.white)
                {
                    bir.GetComponent<SpriteRenderer>().sprite = colorball.transform.GetComponent<SpriteRenderer>().sprite;
                    bir.localScale = new Vector3(0.13f, 0.13f, 1f);
                }
                else if(x == Color.black)
                {
                    bir.GetComponent<SpriteRenderer>().sprite = null;
                }
                else
                {
                    bir.GetComponent<SpriteRenderer>().color = x;
                }
                continue;
            }
            
            

        }
        

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -5.5f)
        {
            
            Destroy(gameObject);

        }
        transform.Translate(0, -2.5f * Time.deltaTime, 0);

    }

    public Color metot()
    {
        
        int rast = Random.Range(0, 7);
        
        if(rast == 0 )
        {
            return Color.blue;

        }else if(rast == 1 )
        {
            return Color.yellow;

        }else if(rast == 2 )
        {
            return Color.red;

        }else if (rast == 3 )
        {
            return Color.green;

        }else if(rast == 4)
        {
            //control = 1;
            return Color.white;

        }else if (rast == 5)
        {
            //control = 1;
            return Color.magenta;
        }
        else
        {
           // control = 1;
            return Color.black;
        }

        
    }
    public int bilmiyorum(int a)
    {
        
        if (a == 3 && dortCont != 1)
        {
            dortCont = 1;
            return 4;
        } else if (a == 2 && ucCont != 1)
        {
            ucCont = 1;
            return 3;
        } else if (a == 1 && ikiCont != 1)
        {
            ikiCont = 1;
            return 2;
        }
        else if (a == 0 && birCont != 1)
        {
            birCont = 1;
            return 1;
        }else
        {
            return 0;
        }
        
    }


}
