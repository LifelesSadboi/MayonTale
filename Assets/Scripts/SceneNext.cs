using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNext : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(NextScene());
    }


    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(12f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
