 using System.Collections; 
 using System.Collections.Generic; 
 using UnityEngine;
 
 public class keyPlaySound : MonoBehaviour {
 
  public AudioSource mySound;
  // Use this for initialization
  void Start () {
      
  }
  
  // Update is called once per frame
  void Update () {
         if (Input.GetKeyDown(KeyCode.W)) {
             if(!mySound.isPlaying) {
                 mySound.Play();
             }
         }
      
         if (Input.GetKeyDown(KeyCode.E)) {
             if(mySound.isPlaying) {
                 mySound.Stop();
             }
         }
     }
 }