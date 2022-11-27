using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC_ShopKeeper : MonoBehaviour
{

    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI dialogueName;
    public GameObject dialogue;
    DialogueTrigger dialogueTrigger;
    // public string dialogue;
    // public string dialogue2;
    int visited;

    int index;
    float speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        dialoguePanel.SetActive(false);
        dialogueTrigger = dialogue.GetComponent<DialogueTrigger>();
        visited = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerStay2D(Collider2D other)
    {   

       // Debug.Log(dialogueTrigger.dialogues.dialogue[1]);
        if(other.tag == "Player")
        {
            dialoguePanel.SetActive(true);
            dialogueName.text = dialogueTrigger.dialogues.name;
            
            if (visited == 1)
            {
                dialogueText.text = dialogueTrigger.dialogues.dialogue[0];
            }
            else if (visited == 2)
            {
                dialogueText.text = dialogueTrigger.dialogues.dialogue[1];
            }
            else
            {
                dialogueText.text = dialogueTrigger.dialogues.dialogue[2];
            }

        }

    }

    void OnTriggerExit2D(Collider2D other)
    {   
        if(other.tag == "Player")
        {
            dialoguePanel.SetActive(false);
            visited++;

        }

    }

}
