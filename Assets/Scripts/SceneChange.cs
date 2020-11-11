using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string nestScene;
    public GameObject outMovie;
    public GameObject loadingMovie;
    public float outWaitTime = 1.0f;
    public float loadingWaitTime = 1.0f;
    public bool showLoading = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine("playOutMovieAndLoadNextScene");
        }
    }

    IEnumerator playOutMovieAndLoadNextScene()
    {
        outMovie.GetComponent<VideoPlayer>().Play();

        yield return new WaitForSeconds(outWaitTime);

        if (showLoading)
        {
            loadingMovie.GetComponent<VideoPlayer>().Play();
            yield return new WaitForSeconds(loadingWaitTime);
        }

        SceneManager.LoadScene(nestScene);
    }

    public void startChangeScene()
    {
        StartCoroutine("playOutMovieAndLoadNextScene");
    }
}
