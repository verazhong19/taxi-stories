using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class meterButton : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text _title;

    public void OnButtonClick()
    {
        _title.text = "Jay Street!";
    }
}
