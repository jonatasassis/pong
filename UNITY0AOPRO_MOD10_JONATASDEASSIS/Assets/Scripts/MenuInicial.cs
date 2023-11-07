using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuInicial : MonoBehaviour
{
    public TMP_Text totalVitoriasPlayer1Text, totalVitoriasPlayer2Text;
    // Start is called before the first frame update
    void Start()
    {
        totalVitoriasPlayer1Text.text = "Total de vitórias: " + PlayerPrefs.GetInt("totalVitoriasPlayer1");
        totalVitoriasPlayer2Text.text = "Total de vitórias: " + PlayerPrefs.GetInt("totalVitoriasPlayer2");
    }
}