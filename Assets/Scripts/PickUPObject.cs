using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUPObject : MonoBehaviour
{
    public GameObject elementoAgarrado;
    public bool Agarrado = false;
    public GameObject Jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Agarrado == true && Input.GetKeyDown(KeyCode.P))
        {
            Agarrado = false;
            elementoAgarrado.transform.position = Jugador.transform.position;
            elementoAgarrado.SetActive(true);
            elementoAgarrado = null;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && Agarrado == false && other.gameObject.tag != "NPC")
        {
            elementoAgarrado = other.gameObject;
            elementoAgarrado.SetActive(false);
            Agarrado = true;
        }
        if (other.gameObject.tag == "mesa" && Agarrado == true)
        {
            if (Input.GetKeyDown(KeyCode.T) && other.gameObject.layer == 7)
            {
                if (elementoAgarrado.gameObject.tag == "Monitor")
                {

                }
                else if (elementoAgarrado.gameObject.tag == "Mouse")
                {

                }
                else if (elementoAgarrado.gameObject.tag == "Teclado")
                {

                }
            }
            else if (Input.GetKeyDown(KeyCode.T) && other.gameObject.layer == 8)
            {
                if (elementoAgarrado.gameObject.tag == "Monitor")
                {

                }
                else if (elementoAgarrado.gameObject.tag == "Mouse")
                {

                }
                else if (elementoAgarrado.gameObject.tag == "Teclado")
                {

                }
            }
            else if (Input.GetKeyDown(KeyCode.T) && other.gameObject.layer == 9)
            {
                if (elementoAgarrado.gameObject.tag == "Monitor")
                {

                }
                else if (elementoAgarrado.gameObject.tag == "Mouse")
                {

                }
                else if (elementoAgarrado.gameObject.tag == "Teclado")
                {

                }
            }
        }
    }
}
