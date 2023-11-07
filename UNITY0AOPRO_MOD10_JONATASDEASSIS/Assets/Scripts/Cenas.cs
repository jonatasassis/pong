using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cenas : MonoBehaviour
{
    public int proximaCena,cenaAtual;
    // Start is called before the first frame update

    public void AbrirCena()
    {
        SceneManager.LoadScene(proximaCena);
    }



    public void ResetDados()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetString("nomeJogador1", "Player 1");
        PlayerPrefs.SetString("nomeJogador2"," Player 2");
        print("Dados resetados! "+ "nome P1: " + PlayerPrefs.GetString("nomeJogador1") + ". nome P2: " + PlayerPrefs.GetString("nomeJogador2") + ".");
        SceneManager.LoadScene(cenaAtual);
    }
}
