using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    bool Used;
    bool InProximityTorch;
    GameObject MainLight;
    // Start is called before the first frame update
    void Start()
    {
        MainLight = GameObject.FindGameObjectWithTag("MainLight");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& InProximityTorch == true && Used == false) 
        {
            MainLight.GetComponent<Light>().range += 5;
            MainLight.GetComponent<Light>().intensity += 0.5f;
            transform.GetChild(0).gameObject.SetActive(false);
            Used = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        InProximityTorch = true;
    }
    private void OnTriggerExit(Collider other)
    {
        InProximityTorch = false;
    }
}
