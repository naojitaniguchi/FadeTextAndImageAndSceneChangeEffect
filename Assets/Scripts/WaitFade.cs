using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitFade : MonoBehaviour
{
    public float waitTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WaitAndActiveOff");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitAndActiveOff()
    {
        yield return new WaitForSeconds(waitTime);

        gameObject.SetActive(false);
    }
}
