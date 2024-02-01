using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObjects : MonoBehaviour
{
    //Texto que aparece quando o jogador tiver no trigger
    public Text textoObj;
    public GameObject textGm;
    public string texto;

    public float speed;

    //MoverObjeto
    public Transform objetoParaMover;
    float x;
    float y;
    public Vector3 moveDirection;

    //Escolher a tecla para subir e descer
    public KeyCode cima = KeyCode.U;
    public KeyCode baixo = KeyCode.J;
    bool isKeyPressedUP;
    bool isKeyPressedDOWN;
    bool isKeyPressed;

    //Enumerador para escolher o tipo de Movimento
    public TipodeMovimento tipoMovimento;

    public enum TipodeMovimento
    {
        CimaBaixo,
        Reto
    }

    private void Start()
    {
        //Color o texto = a string e por o obj texto invisivel
        textoObj.text = texto;
        textGm.SetActive(false);
    }

    private void Update()
    {

        if(isKeyPressedDOWN || isKeyPressedUP)
        {
            isKeyPressed = true;
        }
        else if(isKeyPressedDOWN == false || isKeyPressedUP == false)
        {
            isKeyPressed = false;
        }
        if(Input.GetKey(cima))
       {
            y += speed * Time.deltaTime;
            isKeyPressedUP = true;
       } 
       else
       {
           isKeyPressedUP = false; 
       }
       if (Input.GetKey(baixo))
       {
            y -= speed * Time.deltaTime;
            isKeyPressedDOWN = true;
       }
       else 
       {
            isKeyPressedDOWN = false;
       }
       
    }

    private void OnTriggerStay(Collider other)
    {
        //Por o obj texto visivel quando entrar no trigger
        textGm.SetActive(true);

        //Se a Tag do Objeto a entrar no trigger for == Player fazer o seguinte:
        if (other.CompareTag("Player"))
        {
            //Switch case para fazer o loop correto
            switch (tipoMovimento)
            {
                case TipodeMovimento.CimaBaixo:
                    if(isKeyPressed)
                    {
                        moveDirection = new Vector3(0.0f, y,0.0f );
                        objetoParaMover.transform.Translate(moveDirection * Time.deltaTime);
                    }
                    else
                    {
                        objetoParaMover.Translate(Vector3.zero);
                    }
                    
                    break;
                case TipodeMovimento.Reto:
                    objetoParaMover.transform.Translate(moveDirection * Time.deltaTime);
                    break;
                default:
                    break;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Por o obj de texto Invisivel quando sair do trigger
        textGm.SetActive(false);
        objetoParaMover.Translate(Vector3.zero);
        
    }
}
