using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InformationPanelScript : MonoBehaviour
{
    private TextMesh textMesh;

    
    public void Start()
    {
      
        textMesh = GetComponent<TextMesh>();
    }

    
    public void Update()
    {
      
        string text = Input.GetKeyDown(KeyCode.Return) ? "O planeta é vermelhol." : "";

       
        textMesh.text = text;
    }
}