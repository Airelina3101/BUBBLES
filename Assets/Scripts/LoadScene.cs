using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public int IDscene;
    void Start()
    {
        StartCoroutine(LoadScen());
    }

    // Update is called once per frame
    IEnumerator LoadScen()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(IDscene);
        while (!operation.isDone)
        {
            yield return null;
        }
        
    }
}
