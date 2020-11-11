using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitIn : MonoBehaviour
{
    public float waitTime = 2.0f;

    public GameObject[] fadeObjects;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WaitAndActiveOn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitAndActiveOn()
    {
        yield return new WaitForSeconds(waitTime);

        for ( int i = 0; i < fadeObjects.Length; i++)
        {
            fadeObjects[i].SetActive(true);
        }
    }
}
