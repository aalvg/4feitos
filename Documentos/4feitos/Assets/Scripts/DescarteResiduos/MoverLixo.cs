using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoverLixo : MonoBehaviour
{
    
    Vector3 posicInicial;
    Vector3 posicDestino;
    Vector3 vetorDirecao;
    Rigidbody2D _rigidbody2D;
    bool estaArrastando;
    float distancia;
    [HideInInspector]
    public bool estaConectado;
    [Range(1,15)]
    public float velocidadeDeMovimento = 10;
    [Space(10)]
    public Transform conector;
    [Range(0.1f,2.0f)]
    public float distanciaMinimaConector = 0.5f;
    public int minimumX = -9;
    public int maximumX = 9;
    public int minimumY = 5;
    public int maximumY = -5;
    GameController controller;
    bool isGrounded;

    void Start()
    {
        _rigidbody2D = transform.root.GetComponent<Rigidbody2D>();
        _rigidbody2D.gravityScale = 0.2f;
        controller = FindObjectOfType<GameController>();
        isGrounded = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        posicInicial = transform.root.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _rigidbody2D.gravityScale = 0;
        estaArrastando = true;
        estaConectado = false;
    }
    void OnMouseDrag(){
        posicDestino = posicInicial + Camera.main.ScreenToWorldPoint(Input.mousePosition);
        vetorDirecao = posicDestino - transform.root.position;
        _rigidbody2D.velocity = vetorDirecao * velocidadeDeMovimento;
    }
    void OnMouseUp(){
        _rigidbody2D.gravityScale = 1;
        estaArrastando = false;
    }
    public void FixedUpdate(){
        if(!estaArrastando && !estaConectado){
            distancia = Vector2.Distance(transform.root.position, conector.position);
            if(distancia < distanciaMinimaConector){
                _rigidbody2D.gravityScale = 0;
                _rigidbody2D.velocity = Vector2.zero;
                transform.root.position = Vector2.MoveTowards(transform.root.position, conector.position, 0.2f);
            }
            if(distancia < 0.01f){
                estaConectado = true;
                transform.root.position = conector.position;
                if(estaConectado == true){
                    Destroy(gameObject);
                    controller.Score = controller.Score + 10;
                    controller.scoreText.text = controller.Score.ToString();
                }
            }  
        }
    }
    void OnCollisionEnter2D(Collision2D colisor){
        if (colisor.gameObject.tag == "isGrounded")
        {
            isGrounded = true;
            Destroy(gameObject);
        }
    }
}

