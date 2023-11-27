using System.Collections;
using System.Collections.Generic;
public class PlanetRotationScript : MonoBehaviour
{
    private float rotationSpeed;
    private float rotationAngle;

    
    public void Start()
    {
        rotationSpeed = 1.0f;
        rotationAngle = 90.0f;
    }

    
    public void Update()
    {
     
        Vector3 handPosition = Input.GetTouch(0).position;
        if (handPosition.x > 0 && handPosition.z > 0)
        {
        
            rotationSpeed += 0.01f;

           
            rotationAngle += 10.0f;
        }

        
        transform.Rotate(0, rotationSpeed, rotationAngle);
    }
}