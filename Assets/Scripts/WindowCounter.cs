using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowCounter : MonoBehaviour
{
    private int counter = 0;
    private DialogueTrigger dialogue;
    void Start()
    {
        dialogue = gameObject.GetComponent<DialogueTrigger>();
    }
    

    public void AnnoyDriver() {
        counter ++;
        if (counter == 3) {
            dialogue.TriggerDialogue();
            counter = 0;
        }
    }
}
