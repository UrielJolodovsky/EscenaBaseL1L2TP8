using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUPObject : MonoBehaviour
{
    public GameObject elementoAgarrado;
    public bool Agarrado = false;
    public GameObject Jugador;
    [SerializeField] bool[] ComponentesComputadora;
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
        if (Input.GetKeyDown(KeyCode.E) && Agarrado == false && other.gameObject.tag != "NPC" && other.gameObject.tag != "mesa")
        {
            elementoAgarrado = other.gameObject;
            elementoAgarrado.SetActive(false);
            Agarrado = true;
        }
        if (other.gameObject.tag == "mesa" && Agarrado == true)
        {
            if (Input.GetKeyDown(KeyCode.T) && other.gameObject.layer == 7)
            {
                if (elementoAgarrado.gameObject.tag == "Monitor" && ComponentesComputadora[0] == false)
                {
                    ComponentesComputadora[0] = true;
                    elementoAgarrado.transform.position = new Vector3 (40,40,40);
                    elementoAgarrado = null;
                }
                else if (elementoAgarrado.gameObject.tag == "Mouse" && ComponentesComputadora[1] == false)
                {
                    ComponentesComputadora[1] = true;
                    elementoAgarrado = null;
                }
                else if (elementoAgarrado.gameObject.tag == "Teclado" && ComponentesComputadora[2] == false)
                {
                    ComponentesComputadora[2] = true;
                    elementoAgarrado = null;
                }
            }
            else if (Input.GetKeyDown(KeyCode.T) && other.gameObject.layer == 8)
            {
                if (elementoAgarrado.gameObject.tag == "Monitor" && ComponentesComputadora[3] == false)
                {
                    ComponentesComputadora[3] = true;
                    elementoAgarrado = null;
                }
                else if (elementoAgarrado.gameObject.tag == "Mouse" && ComponentesComputadora[4] == false)
                {
                    ComponentesComputadora[4] = true;
                    elementoAgarrado = null;
                }
                else if (elementoAgarrado.gameObject.tag == "Teclado" && ComponentesComputadora[5] == false)
                {
                    ComponentesComputadora[5] = true;
                    elementoAgarrado = null;
                }
            }
            else if (Input.GetKeyDown(KeyCode.T) && other.gameObject.layer == 9)
            {
                if (elementoAgarrado.gameObject.tag == "Monitor" && ComponentesComputadora[6] == false)
                {
                    ComponentesComputadora[6] = true;
                    elementoAgarrado = null;
                }
                else if (elementoAgarrado.gameObject.tag == "Mouse" && ComponentesComputadora[7] == false)
                {
                    ComponentesComputadora[7] = true;
                    elementoAgarrado = null;
                }
                else if (elementoAgarrado.gameObject.tag == "Teclado" && ComponentesComputadora[8] == false)
                {
                    ComponentesComputadora[8] = true;
                    elementoAgarrado = null;
                }
            }
        }
    }
}
