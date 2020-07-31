using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFading : MonoBehaviour
{
    public float FS;
    Light light;
    public bool MainLight;
    public RectTransform LooseScreen;
    public float FS2;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        while(light.range > 0)
        {
            light.range -= FS;
            light.intensity -= FS2;
            yield return new WaitForSeconds(0.01f);
        }
        if (MainLight == true) 
        {
            LooseScreen.gameObject.SetActive(true);
        }
    }
}
