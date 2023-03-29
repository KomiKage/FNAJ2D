using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntermissionScript : MonoBehaviour
{
    public int scene;

    /*void Start()
    {
        StartCoroutine(nextScene());
    }

    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
        SceneManager.LoadSceneAsync(scene);
    }*/

    void Start()
    {
        StartCoroutine(nextScene());
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            sceneLoader.StartGame();
        }
    }

    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(10f);
        sceneLoader.StartGame();
    }
}
