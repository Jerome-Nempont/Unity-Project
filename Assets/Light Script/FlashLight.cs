using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour
{
    private Light myLight;


    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}