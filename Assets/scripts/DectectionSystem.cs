using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DectectionSystem : MonoBehaviour
{
    public RectTransform WinScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        Debug.Log("enter");
        WinScreen.gameObject.SetActive(true);
    }
}
