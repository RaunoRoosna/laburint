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
            MainLight.GetComponent<Light>().range += 1;
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
