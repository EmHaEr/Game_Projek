using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject gameOver;

    public static int p1life;
    public static int p2life;

    public GameObject[] p1darah;
    public GameObject[] p2darah;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HurtP1()
    {
        for(int i = 0; i < p1darah.Length; i++)
        {
            if(p1life > i)
            {
                p1darah[i].SetActive(true);
            }
            else
            {
                p1darah[i].SetActive(false);
            }
        }
    }

    public void HurtP2()
    {
        for (int j = 0; j < p2darah.Length; j++)
        {
            if (p2life > j)
            {
                p2darah[j].SetActive(true);
            }
            else
            {
                p2darah[j].SetActive(false);
            }
        }
    }
}
