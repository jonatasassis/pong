using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MudarCor : MonoBehaviour
{
    public RawImage player1Img,player2Img;

    public bool Player1;
    public Button[] cores;
    public int idCorPlayer1=0,idCorPlayer2=0;
    // Start is called before the first frame update
    private void Start()
    {
        PlayerPrefs.SetInt("corPlayer1", idCorPlayer1);
        print("cor p1 " + PlayerPrefs.GetInt("corPlayer1") + " salva");

        PlayerPrefs.SetInt("corPlayer2", idCorPlayer2);
        print("cor p2 " + PlayerPrefs.GetInt("corPlayer1") + " salva");
    }
    private void Update()
    {
        if (Player1)
        {
            player1Img.color = cores[idCorPlayer1].colors.normalColor;
        }
        else
        {
            player2Img.color = cores[idCorPlayer2].colors.normalColor;
        }
    }
            
    

    public void Direita()
    {
        if (Player1)
        {
            if (idCorPlayer1 >4)
            {
                idCorPlayer1 = -1;

            }
            idCorPlayer1++;
            PlayerPrefs.SetInt("corPlayer1", idCorPlayer1);
            print("cor p1 " + PlayerPrefs.GetInt("corPlayer1") + " salva");
            
        }
        else
        {
            if (idCorPlayer2 > 4)
            {
                idCorPlayer2 = -1;

            }
            idCorPlayer2++;
            PlayerPrefs.SetInt("corPlayer2", idCorPlayer2);
            print("cor p2 " + PlayerPrefs.GetInt("corPlayer2") + " salva");

            
        }
    }

    public void Esquerda()
    {
        if (Player1)
        {
            if (idCorPlayer1 <= 0)
            {
                idCorPlayer1 = 6;

            }
            idCorPlayer1--;
            PlayerPrefs.SetInt("corPlayer1", idCorPlayer1);
            print("cor p1 " + PlayerPrefs.GetInt("corPlayer1") + " salva");
            
        }

        else
        {
            if (idCorPlayer2 <= 0)
            {
                idCorPlayer2 = 6;

            }
            idCorPlayer2--;
            PlayerPrefs.SetInt("corPlayer2", idCorPlayer2);
            print("cor p2 " + PlayerPrefs.GetInt("corPlayer2") + " salva");
            
        }
    }


}
