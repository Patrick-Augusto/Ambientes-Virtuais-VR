using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlanetCollisionScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.GetComponent<HandController>().handType == HandType.Left)
        {
            
            ShowInformationPanel();
        }
    }

    private void ShowInformationPanel()
    {
        
        GameObject informationPanel = GameObject.CreatePrimitive(PrimitiveType.Quad);
        informationPanel.transform.localScale = new Vector3(1, 1, 0.1f);
        informationPanel.transform.position = transform.position;

        
        GameObject.DontDestroyOnLoad(informationPanel);

      
        TextMesh textMesh = informationPanel.GetComponent<TextMesh>();
        textMesh.text = "Venus e um planeta vermelho ";
    }
}