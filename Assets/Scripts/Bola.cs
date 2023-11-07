using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bola : MonoBehaviour
{
    public Vector3 velBola = new Vector3(1,1,0);
    public int randX, randY;
    public GameObject bola;
    public int velInicialBola;
    public Vector2 posInicialBola;
    


    // Start is called before the first frame update
    private void Awake()
    {
        posInicialBola=transform.position;
        ComecarPartida();

    }

    // Update is called once per frame
    void Update()
    {
        if (LogicaJogo.comecar == true)
        {

            
            transform.Translate(velBola);
        }
        else
        {
            posInicialBola = transform.position;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {

            RandomizarVelocidadeX();
        }

        else

            RandomizarVelocidadeY();

      

    }

   

    public void RandomizarVelocidadeX()
    {
        randX = Random.Range(7,14);
        if (velBola.x > 0)
        {
            randX = -randX;
            randY = -randY;
        }
        velBola.x = randX;
    }

    public void RandomizarVelocidadeY()
    {
        randY = Random.Range(7, 14);
        if (velBola.y > 0)
        {
            randY = -randY;
        }
        velBola.y = randY;
    }

    public void ComecarPartida()
    {
        RandomizarVelocidadeX();
        RandomizarVelocidadeY();
    }
}
