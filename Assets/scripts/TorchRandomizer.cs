using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchRandomizer : MonoBehaviour
{
    public GameObject spawnObject;

    void Start()
    {
        var number = Random.Range(1, 10);
        if(number == 1)
        {
           Instantiate(spawnObject,transform.position + transform.right * -1.5f,Quaternion.AngleAxis(45f, transform.forward));
        }
        else if(number == 2)
        {
           Instantiate(spawnObject,transform.position + transform.right * 1.5f,Quaternion.AngleAxis(-45f, transform.forward));
        }
    }    
}
