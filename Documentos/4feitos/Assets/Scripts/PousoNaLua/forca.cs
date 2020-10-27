using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forca : MonoBehaviour
{
    public Vector3 direcao;
    Vector3 eixos;
    public float valor;
    public float valorZero;
    public float valorDescida;
    ConstantForce2D impulso;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        impulso = gameObject.GetComponent<ConstantForce2D> ();
        anim = GetComponent<Animator>();
        eixos = direcao;
    }

    void Update(){
 
        if (valor >= 20f) {
            valor += .025f;
            valorZero--;
        }

        if (valorDescida >= 20f) {
            valorDescida += .025f;
            valorZero--;
        }

        if (Input.GetKey (KeyCode.Space)) {
            impulso.force = direcao * valor;
            direcao = eixos;
            anim.Play("rocketmove");
            }

        if (Input.GetKeyUp (KeyCode.Space)) {
            impulso.force = direcao * valorZero;
            direcao = Vector3.zero;
            anim.Play("rocketmove");
        }

        if (Input.GetKey (KeyCode.Z)) {
            impulso.force = direcao * valorDescida;
            direcao = eixos;
            anim.Play("rocketmove");
            }

        if (Input.GetKeyUp (KeyCode.Z)) {
            impulso.force = direcao * valorZero;
            direcao = Vector3.zero;
            anim.Play("rocketmove");
        }

    }
}
