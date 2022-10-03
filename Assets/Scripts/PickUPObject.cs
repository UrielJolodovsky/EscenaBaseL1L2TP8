using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUPObject : MonoBehaviour
{
    public GameObject elementoAgarrado;
    public bool Agarrado = false;
    public GameObject Jugador;
    [SerializeField] bool[] ComponentesComputadora = new bool[] {false, false, false, false, false, false, false, false, false, false};
    public GameObject Monitor1;
    public GameObject Raton1;
    public GameObject Teclado1;
    public GameObject Monitor2;
    public GameObject Raton2;
    public GameObject Teclado2;
    public GameObject Monitor3;
    public GameObject Raton3;
    public GameObject Teclado3;
    [SerializeField] bool[] ComputadorasHechas = new bool[] { false, false, false};
    public Transform Mouse1Empty;
    public Transform Monitor1Empty;
    public Transform Teclado1Empty;
    public Transform Mouse2Empty;
    public Transform Monitor2Empty;
    public Transform Teclado2Empty;
    public Transform Mouse3Empty;
    public Transform Monitor3Empty;
    public Transform Teclado3Empty;
    public Text agarrarComponentes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Soltar objeto
        if (Agarrado == true && Input.GetKeyDown(KeyCode.P))
        {
            Agarrado = false;
            elementoAgarrado.transform.position = Jugador.transform.position;
            elementoAgarrado.SetActive(true);
            elementoAgarrado = null;
        }
        if (Monitor1.transform.position == Monitor1Empty.position && Raton1.transform.position == Mouse1Empty.position && Teclado1.transform.position == Teclado1Empty.position && ComponentesComputadora[0] && ComponentesComputadora[1] && ComponentesComputadora[2])
        {
            ComputadorasHechas[0] = true;
        }
        else
        {
            ComputadorasHechas[0] = false;
        }
        if (Monitor2.transform.position == Monitor2Empty.position && Raton2.transform.position == Mouse2Empty.position && Teclado2.transform.position == Teclado2Empty.position && ComponentesComputadora[3] && ComponentesComputadora[4] && ComponentesComputadora[5])
        {
            ComputadorasHechas[1] = true;
        }
        else
        {
            ComputadorasHechas[1] = false;
        }
        if (Monitor3.transform.position == Monitor3Empty.position && Raton3.transform.position == Mouse3Empty.position && Teclado3.transform.position == Teclado3Empty.position && ComponentesComputadora[6] && ComponentesComputadora[7] && ComponentesComputadora[8])
        {
            ComputadorasHechas[2] = true;
        }
        else
        {
            ComputadorasHechas[2] = false;
        }
        if (ComputadorasHechas[0] && ComputadorasHechas[1] && ComputadorasHechas[2])
        {

        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && Agarrado == false && other.gameObject.tag != "NPC" && other.gameObject.tag != "MesaEspecial" && other.transform.position != Monitor1Empty.position && other.transform.position != Monitor2Empty.position && other.transform.position != Monitor3Empty.position && other.transform.position != Teclado1Empty.position && other.transform.position != Teclado2Empty.position && other.transform.position != Teclado3Empty.position && other.transform.position != Mouse1Empty.position && other.transform.position != Mouse2Empty.position && other.transform.position != Mouse3Empty.position)
        {
            elementoAgarrado = other.gameObject;
            elementoAgarrado.SetActive(false);
            elementoAgarrado.transform.position = new Vector3(-9999999f, -99999999f, -9999999f);
            Agarrado = true;
            agarrarComponentes.enabled = false;
        }
        if (other.gameObject.tag == "MesaEspecial" && Agarrado == true)
        {
            if (Input.GetKeyDown(KeyCode.T) && other.gameObject.layer == 9)
            {
                Debug.Log("hehco");
                if (elementoAgarrado.gameObject.tag == "Monitor" && ComponentesComputadora[0] == false)
                {
                    ComponentesComputadora[0] = true;
                    elementoAgarrado.transform.position = Monitor1Empty.position;
                    elementoAgarrado.SetActive(true);
                    elementoAgarrado = null;
                    Agarrado = false;
                }
                else if (elementoAgarrado.gameObject.tag == "Mouse" && ComponentesComputadora[1] == false)
                {
                    ComponentesComputadora[1] = true;
                    elementoAgarrado.transform.position = Mouse1Empty.position;
                    elementoAgarrado.SetActive(true);
                    elementoAgarrado = null;
                    Agarrado = false;
                }
                else if (elementoAgarrado.gameObject.tag == "Teclado" && ComponentesComputadora[2] == false)
                {
                    ComponentesComputadora[2] = true;
                    elementoAgarrado.transform.position = Teclado1Empty.position;
                    elementoAgarrado.SetActive(true);
                    elementoAgarrado = null;
                    Agarrado = false;
                }
            }
            else if (Input.GetKeyDown(KeyCode.T) && other.gameObject.layer == 10)
            {
                if (elementoAgarrado.gameObject.tag == "Monitor" && ComponentesComputadora[3] == false)
                {
                    ComponentesComputadora[3] = true;
                    elementoAgarrado.transform.position = Monitor2Empty.position;
                    elementoAgarrado.SetActive(true);
                    elementoAgarrado = null;
                    Agarrado = false;
                }
                else if (elementoAgarrado.gameObject.tag == "Mouse" && ComponentesComputadora[4] == false)
                {
                    ComponentesComputadora[4] = true;
                    elementoAgarrado.transform.position = Mouse2Empty.position;
                    elementoAgarrado.SetActive(true);
                    elementoAgarrado = null;
                    Agarrado = false;
                }
                else if (elementoAgarrado.gameObject.tag == "Teclado" && ComponentesComputadora[5] == false)
                {
                    ComponentesComputadora[5] = true;
                    elementoAgarrado.transform.position = Teclado2Empty.position;
                    elementoAgarrado.SetActive(true);
                    elementoAgarrado = null;
                    Agarrado = false;
                }
            }
            else if (Input.GetKeyDown(KeyCode.T) && other.gameObject.layer == 11)
            {
                if (elementoAgarrado.gameObject.tag == "Monitor" && ComponentesComputadora[6] == false)
                {
                    ComponentesComputadora[6] = true;
                    elementoAgarrado.transform.position = Monitor3Empty.position;
                    elementoAgarrado.SetActive(true);
                    elementoAgarrado = null;
                    Agarrado = false;
                }
                else if (elementoAgarrado.gameObject.tag == "Mouse" && ComponentesComputadora[7] == false)
                {
                    ComponentesComputadora[7] = true;
                    elementoAgarrado.transform.position = Mouse3Empty.position;
                    elementoAgarrado.SetActive(true);
                    elementoAgarrado = null;
                    Agarrado = false;
                }
                else if (elementoAgarrado.gameObject.tag == "Teclado" && ComponentesComputadora[8] == false)
                {
                    ComponentesComputadora[8] = true;
                    elementoAgarrado.transform.position = Teclado3Empty.position;
                    elementoAgarrado.SetActive(true);
                    elementoAgarrado = null;
                    Agarrado = false;
                }
            }
        }
        if (other.gameObject.tag == "MesaEspecial" && Agarrado == false)
        {
            if (other.gameObject.layer == 9)
            {
                if (Input.GetKeyDown(KeyCode.M) && ComponentesComputadora[0])
                {
                    Agarrado = true;
                    Monitor1.SetActive(false);
                    elementoAgarrado = Monitor1.gameObject;
                    ComponentesComputadora[0] = false;
                }
                if (Input.GetKeyDown(KeyCode.R) && ComponentesComputadora[1])
                {
                    Agarrado = true;
                    Raton1.SetActive(false);
                    elementoAgarrado = Raton1.gameObject;
                    ComponentesComputadora[1] = false;
                }
                if (Input.GetKeyDown(KeyCode.Q) && ComponentesComputadora[2])
                {
                    Agarrado = true;
                    Teclado1.SetActive(false);
                    elementoAgarrado = Teclado1.gameObject;
                    ComponentesComputadora[2] = false;
                }
            }
            else if (other.gameObject.layer == 10)
            {
                if (Input.GetKeyDown(KeyCode.M) && ComponentesComputadora[3])
                {
                    Agarrado = true;
                    Monitor2.SetActive(false);
                    elementoAgarrado = Monitor2.gameObject;
                    ComponentesComputadora[3] = false;
                }
                if (Input.GetKeyDown(KeyCode.R) && ComponentesComputadora[4])
                {
                    Agarrado = true;
                    Raton2.SetActive(false);
                    elementoAgarrado = Raton2.gameObject;
                    ComponentesComputadora[4] = false;
                }
                if (Input.GetKeyDown(KeyCode.Q) && ComponentesComputadora[5])
                {
                    Agarrado = true;
                    Teclado2.SetActive(false);
                    elementoAgarrado = Teclado2.gameObject;
                    ComponentesComputadora[5] = false;
                }

            }
            else if (other.gameObject.layer == 11)
            {
                if (Input.GetKeyDown(KeyCode.M) && ComponentesComputadora[6])
                {
                    Agarrado = true;
                    Monitor3.SetActive(false);
                    elementoAgarrado = Monitor3.gameObject;
                    ComponentesComputadora[6] = false;
                }
                if (Input.GetKeyDown(KeyCode.R) && ComponentesComputadora[7])
                {
                    Agarrado = true;
                    Raton3.SetActive(false);
                    elementoAgarrado = Raton3.gameObject;
                    ComponentesComputadora[7] = false;
                }
                if (Input.GetKeyDown(KeyCode.Q) && ComponentesComputadora[8])
                {
                    Agarrado = true;
                    Teclado3.SetActive(false);
                    elementoAgarrado = Teclado3.gameObject;
                    ComponentesComputadora[8] = false;
                }

            }
        }
        if (other.gameObject.tag == "Mouse" || other.gameObject.tag == "Teclado" || other.gameObject.tag == "Monitor" && Agarrado == false)
        {
            agarrarComponentes.enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Mouse" || other.gameObject.tag == "Teclado" || other.gameObject.tag == "Monitor")
        {
            agarrarComponentes.enabled = false;
        }
    }
}
