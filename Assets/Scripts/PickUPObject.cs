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
            if (Input.GetKeyDown(KeyCode.T) && other.gameObject.layer == 9)
            {
                if (elementoAgarrado.gameObject.tag == "Monitor" && ComponentesComputadora[0] == false)
                {
                    ComponentesComputadora[0] = true;
                    elementoAgarrado.transform.position = new Vector3 (-2.828f, -0.09f, -6.8f);
                    elementoAgarrado = null;
                }
                else if (elementoAgarrado.gameObject.tag == "Mouse" && ComponentesComputadora[1] == false)
                {
                    ComponentesComputadora[1] = true;
                    elementoAgarrado.transform.position = new Vector3(-2.457f, -0.29f, -6.49f);
                    elementoAgarrado = null;
                }
                else if (elementoAgarrado.gameObject.tag == "Teclado" && ComponentesComputadora[2] == false)
                {
                    ComponentesComputadora[2] = true;
                    elementoAgarrado.transform.position = new Vector3(-2.484f, -0.3f, -6.776f);
                    elementoAgarrado = null;
                }
            }
            else if (Input.GetKeyDown(KeyCode.T) && other.gameObject.layer == 10)
            {
                if (elementoAgarrado.gameObject.tag == "Monitor" && ComponentesComputadora[3] == false)
                {
                    ComponentesComputadora[3] = true;
                    elementoAgarrado.transform.position = new Vector3(-2.828f, -0.09f, -5.075f);
                    elementoAgarrado = null;
                }
                else if (elementoAgarrado.gameObject.tag == "Mouse" && ComponentesComputadora[4] == false)
                {
                    ComponentesComputadora[4] = true;
                    elementoAgarrado.transform.position = new Vector3(-2.457f, -0.29f, -4.759f);
                    elementoAgarrado = null;
                }
                else if (elementoAgarrado.gameObject.tag == "Teclado" && ComponentesComputadora[5] == false)
                {
                    ComponentesComputadora[5] = true;
                    elementoAgarrado.transform.position = new Vector3(-2.484f, -0.3f, -5.111f);
                    elementoAgarrado = null;
                }
            }
            else if (Input.GetKeyDown(KeyCode.T) && other.gameObject.layer == 11)
            {
                if (elementoAgarrado.gameObject.tag == "Monitor" && ComponentesComputadora[6] == false)
                {
                    ComponentesComputadora[6] = true;
                    elementoAgarrado.transform.position = new Vector3(-2.828f, -0.09f, -3.358f);
                    elementoAgarrado = null;
                }
                else if (elementoAgarrado.gameObject.tag == "Mouse" && ComponentesComputadora[7] == false)
                {
                    ComponentesComputadora[7] = true;
                    elementoAgarrado.transform.position = new Vector3(-2.457f, -0.29f, -3.156f);
                    elementoAgarrado = null;
                }
                else if (elementoAgarrado.gameObject.tag == "Teclado" && ComponentesComputadora[8] == false)
                {
                    ComponentesComputadora[8] = true;
                    elementoAgarrado.transform.position = new Vector3(-2.484f, -0.3f, -3.492f);
                    elementoAgarrado = null;
                }
            }
        }
    }
}
