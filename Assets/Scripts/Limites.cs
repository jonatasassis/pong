using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Limites : MonoBehaviour
{
    public Player player;
    public Bola bola;
    public Text pontuacaoText;
    
    // Start is called before the first frame update
    void Start()
    {
        pontuacaoText.text = ""+player.pontos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bola")
        {
            player.AddPontos();
            bola.transform.position=bola.posInicialBola;
            pontuacaoText.text = "" +player.pontos;
            LogicaJogo.timer = 60;
        }
    }

    
}
