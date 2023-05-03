using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneAnimation : MonoBehaviour
{
    private Floater floater;

    void Awake(){
        floater = GetComponent<Floater>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // private void OnMouseEnter() {
    //         Debug.Log('1');
    //         floater.degreesPerSecond = 360f;
    //     }

    // private void OnMouseExit() {
    //         Debug.Log('2');
    //         floater.degreesPerSecond = 0f;
    // }
}
