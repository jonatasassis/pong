using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float velocidade;

    [Header("Teclas")]
    public KeyCode teclaCima ;
    public KeyCode teclaBaixo;
    public Rigidbody2D meuRB;

    public  int pontos;
    public RawImage imgPlayer1,imgPlayer2;
    public RawImage[] cores;




    private void Start()
    {
        imgPlayer1.color = cores[PlayerPrefs.GetInt("corPlayer1")].color;
        imgPlayer2.color = cores[PlayerPrefs.GetInt("corPlayer2")].color;


    }
    // Update is called once per frame
    void Update()
    {
        if (LogicaJogo.comecar == true)
        {

            if (Input.GetKey(teclaCima))
            {
                transform.GetComponent<Rigidbody2D>().MovePosition(transform.position + transform.up * velocidade);
            }
            if (Input.GetKey(teclaBaixo))
            {
                transform.GetComponent<Rigidbody2D>().MovePosition(transform.position + transform.up * -velocidade);
            }
        }

    }

    public void AddPontos()
    {
        pontos++;
    }
    
}
