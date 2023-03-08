using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntermissionScript : MonoBehaviour
{
    public int scene;

    void Start()
    {
        StartCoroutine(nextScene());
    }

    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
        SceneManager.LoadSceneAsync(scene);
    }
}
