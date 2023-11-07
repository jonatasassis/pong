using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.VisualScripting;

public class LogicaJogo : MonoBehaviour
{
    
    public static int timer=20, totalVitoriasPlayer1, totalVitoriasPlayer2;
    public static bool comecar=false;
    public GameObject cenaGameOver;
    public Player player1,player2;
    public TMP_Text texto;
    public Text nomeJogador1,nomeJogador2;
    // Start is called before the first frame update
    void Start()
    {

        cenaGameOver.SetActive(false);
        nomeJogador1.text = "" + PlayerPrefs.GetString("nomeJogador1");
        nomeJogador2.text = "" + PlayerPrefs.GetString("nomeJogador2");
        totalVitoriasPlayer1=PlayerPrefs.GetInt("totalVitoriasPlayer1");
        totalVitoriasPlayer2=PlayerPrefs.GetInt("totalVitoriasPlayer2");
    }

    // Update is called once per frame
    void Update()
    {

        if (timer <= 0)
        {
            IniciarJogo();
        }
        else
        {
            comecar = false;
            timer--;
           
        }

        FinalizarJogo();
    }

    public void IniciarJogo()
    {

        comecar= true;
        
    }

    public void FinalizarJogo()
    {
        if (player1.pontos > 1)
        {
            
            PlayerPrefs.SetInt("totalVitoriasPlayer1",totalVitoriasPlayer1+1);
            cenaGameOver.SetActive(true);
            texto.text = PlayerPrefs.GetString("nomeJogador1") + " ganhou!";

        }

        else if (player2.pontos > 1)
        {
            
            PlayerPrefs.SetInt("totalVitoriasPlayer2", totalVitoriasPlayer2+1);
            cenaGameOver.SetActive(true);
            texto.text = PlayerPrefs.GetString("nomeJogador2") + " ganhou!";

        }


    }

        
}
