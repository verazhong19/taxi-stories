using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowAnim : MonoBehaviour
{
    public Animator myWindow;
    public Animator myHandle;
    // Start is called before the first frame update
    void Start()
    {
        myWindow = GameObject.Find("largeWindow").GetComponent<Animator>();
        myHandle = GameObject.Find("null-windowHandle").GetComponent<Animator>();
    }

    // Update is called once per frame
    public void PlayAnim()
    {
        myHandle.Play("handleRotate");
        myWindow.Play("window-down");
    }
}
