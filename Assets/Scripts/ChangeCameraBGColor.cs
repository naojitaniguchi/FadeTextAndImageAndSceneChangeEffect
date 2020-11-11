using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChangeCameraBGColor : MonoBehaviour
{
    public float waitTime = 0.2f;
    public GameObject mainCamera;
    public GameObject inVideo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("switchToMainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator switchToMainCamera()
    {
        yield return new WaitForSeconds(waitTime);
        mainCamera.SetActive(true);
        inVideo.GetComponent<VideoPlayer>().targetCamera = mainCamera.GetComponent<Camera>();
        gameObject.SetActive(false);
    }
}
