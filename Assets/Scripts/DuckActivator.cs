using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckActivator : MonoBehaviour
{
    private GameObject duck;
    // Start is called before the first frame update
    void Start()
    {
        duck = GameObject.Find("Duck");
    }

    public void MoveDuck () {
        duck.transform.Translate(0, 50, 0);
    }
}
