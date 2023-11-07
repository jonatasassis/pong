using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RegistrarNick : MonoBehaviour
{
    public string nomePlayer1,nomePlayer2;
    public TMP_InputField espacoTextoPlayer1,espacoTextoPlayer2;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("nomeJogador1", "Player 1");
        PlayerPrefs.SetString("nomeJogador2", "Player 2");
    }

    // Update is called once per frame
    void Update()
    {
        nomePlayer1 = espacoTextoPlayer1.text;
        nomePlayer2 = espacoTextoPlayer2.text;
    }

    public void GravarNick()
    {
        
        PlayerPrefs.SetString("nomeJogador1", nomePlayer1);
        PlayerPrefs.SetString("nomeJogador2", nomePlayer2);

        
        print("nome P1: " + PlayerPrefs.GetString("nomeJogador1") + " gravado. nome P2: "+ PlayerPrefs.GetString("nomeJogador2") +" gravado." );
    }
}
