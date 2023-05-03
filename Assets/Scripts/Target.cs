using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Target : MonoBehaviour
{
    public int StoryIndex;
    private Outline boxOutline;
    VideoController videoController; 
    DialogueManager dialogueManager;

    void Awake() {
        videoController = GameObject.Find("VideoPlayer").GetComponent<VideoController>();
        dialogueManager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();

    }

    // Start is called before the first frame update
    void Start()
    {
        boxOutline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && boxOutline.enabled == true ) {
            Debug.Log("1");
            
            //videoController.PlayPause();
            videoController.SetNextClip(StoryIndex);

        }
        
    }

    private void OnMouseEnter() {
        boxOutline.enabled = !boxOutline.enabled;
    }

    private void OnMouseExit() {
        boxOutline.enabled = ! boxOutline.enabled;
    }
}
