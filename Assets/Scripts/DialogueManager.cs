using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioClip dialogTypingClip;
    private AudioSource audioSouce;

    public TextMeshProUGUI dialogueText;

    public Animator animator;
    public Animator receiptAnim;

    public VideoController videoController;

    private Queue<string> sentences;

    // Start is called before the first frame update
    private void Awake() {
        audioSouce = this.gameObject.AddComponent<AudioSource>();
        videoController = GameObject.Find("VideoPlayer").GetComponent<VideoController>();

        receiptAnim = GameObject.Find("receipt-UI").GetComponent<Animator>();
    }
    void Start()
    {
        sentences = new Queue<string>();
        
    }
    public void StartDialogue(Dialogue dialogue) {
        Debug.Log("Dialogue Triggered");

        animator.SetBool("IsOpen", true);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence () {
        if (sentences.Count == 0) {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }

    private void PlayDialogueSound(int currentCharCount) {
        if (currentCharCount % 2 == 0) {
            audioSouce.PlayOneShot(dialogTypingClip);
        }
    }

    IEnumerator TypeSentence (string sentence) {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()) {
            PlayDialogueSound(dialogueText.textInfo.characterCount);
            dialogueText.text += letter;
            
            //audioSouce.PlayOneShot(dialogTypingClip);
            yield return new WaitForSeconds(0.05f);
        } 
        yield return new WaitForSeconds(2.0f);
        DisplayNextSentence();
    }


    void EndDialogue() {
        Debug.Log("Ended");
        animator.SetBool("IsOpen", false);
        receiptAnim.SetBool("IsOpen", false);
        videoController.SetNextClip(0);
    }
}
