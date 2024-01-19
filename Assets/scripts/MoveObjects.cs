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

    //MoverObjeto
    public Transform objetoParaMover;
    float x;
    float y;
    public Vector3 moveDirection;

    //Escolher a tecla para subir e descer
    public KeyCode cima = KeyCode.U;
    public KeyCode baixo = KeyCode.J;

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
        if (Input.GetKey(cima))
        {
            y += 1 * Time.deltaTime;
        }
        if (Input.GetKey(baixo))
        {
            y -= 1 * Time.deltaTime;
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
                    moveDirection = new Vector3(x, y,0.0f );
                    objetoParaMover.transform.Translate(moveDirection * Time.deltaTime);
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
