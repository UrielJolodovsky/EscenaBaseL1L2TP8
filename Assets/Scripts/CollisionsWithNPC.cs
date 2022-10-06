using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollisionsWithNPC : MonoBehaviour
{
    [SerializeField] GameObject UIElements;
    [SerializeField] TextMeshProUGUI dialogueTxt;
    [SerializeField] string[] NPCDialogue;
    [SerializeField] NPCDialogue NPCDialogueScripts;
    int dialogueIndex = 0;
    public Text continuar;
    bool entrar;
    [SerializeField] string tagTrigger;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueIndex < NPCDialogue.Length)
        {
            continuar.enabled = true;
        }
        else
        {
            continuar.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.E) && entrar && tagTrigger == "NPC")
        {
            ShowNextDialogueLine();
        }
    }
    void OnTriggerEnter(Collider other)
    {

        entrar = true;
        tagTrigger = other.gameObject.tag;
        NPCDialogueScripts = other.gameObject.GetComponent<NPCDialogue>();
        if (NPCDialogueScripts)
        {
            UIElements.SetActive(true);
            NPCDialogue = NPCDialogueScripts.data.dialogueLines;
            ShowNextDialogueLine();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            UIElements.SetActive(false);
            dialogueIndex = 0;
        }
        entrar = false;
        tagTrigger = "";
    }
    public void ShowNextDialogueLine()
    {
        if (dialogueIndex < NPCDialogue.Length)
        {
            dialogueTxt.text = NPCDialogue[dialogueIndex];
            dialogueIndex++;
        }
        else
        {

        }
    }
}
