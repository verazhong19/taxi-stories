using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleUI : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    public void OpenUI () {
        if (!animator.GetBool("IsOpen")) {
            animator.SetBool("IsOpen", true);
        } 
    }
}
