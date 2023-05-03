using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoClip[] videoClips;
    
    private VideoPlayer videoPlayer;
    public int videoIndex;
    
    

    void Awake() {
        videoPlayer = GetComponent<VideoPlayer> ();
    }

    // Start is called before the first frame update
    void Start()
    {
        string objectName = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPause() {
        if (videoPlayer.isPlaying) {
            videoPlayer.Pause();
        } else {
            videoPlayer.Play();
        }
    }

    public void SetNextClip(int i) {
        videoIndex = i;
        videoPlayer.clip = videoClips[videoIndex];
        videoPlayer.Play();
    }
}
