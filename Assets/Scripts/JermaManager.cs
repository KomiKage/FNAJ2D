    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JermaManager : MonoBehaviour
{
    public GameObject JermaMask;
    public GameObject JermaLeft;
    public GameObject JermaMiddle;
    public GameObject JermaRight;
    public GameObject Jerma1p1;
    public GameObject Jerma1p2;
    public GameObject Jerma1p3;
    public GameObject Jerma1p4;
    public GameObject Jerma2;
    public GameObject Jerma3;
    public GameObject Jerma4p1;
    public GameObject Jerma4p2;
    public GameObject Jerma5;
    public GameObject Jerma6;
    public GameObject Jerma7;

    private List<GameObject> JermaList = new List<GameObject>();

    private int currentJerma = 4;
    private float random;

    public static bool isScaring = false;

    void Start()
    {
        JermaList.Add(JermaMask);
        JermaList.Add(JermaLeft);
        JermaList.Add(JermaMiddle);
        JermaList.Add(JermaRight);
        JermaList.Add(Jerma1p1);
        JermaList.Add(Jerma1p2);
        JermaList.Add(Jerma1p3);
        JermaList.Add(Jerma1p4);
        JermaList.Add(Jerma2);
        JermaList.Add(Jerma3);
        JermaList.Add(Jerma4p1);
        JermaList.Add(Jerma4p2);
        JermaList.Add(Jerma5);
        JermaList.Add(Jerma6);
        JermaList.Add(Jerma7);

        StartCoroutine(JermaWake());
    }

    private void LoadJerma()
    {
        for (var i = 0; i < JermaList.Count; i++)
        {
            if (i == currentJerma)
            {
                JermaList[i].SetActive(true);
            }
            else
            {
                JermaList[i].SetActive(false);
            }
        }
    }

    IEnumerator JermaWake()
    {
        currentJerma = 4;
        LoadJerma();

        yield return new WaitForSeconds(10f);

        currentJerma = 5;
        LoadJerma();

        yield return new WaitForSeconds(Random.Range(3f, 6f));

        currentJerma = 6;
        LoadJerma();

        yield return new WaitForSeconds(Random.Range(3f, 6f));

        currentJerma = 7;
        LoadJerma();

        yield return new WaitForSeconds(Random.Range(3f, 6f));

        random = Random.Range(1, 3);

        if(random == 1)
        {
            StartCoroutine(JermaLeftRoute());
        }
        if (random == 2)
        {
            StartCoroutine(JermaRightRoute());
        }
        if (random == 3)
        {
            StartCoroutine(JermaMiddleRoute());
        }
    }

    IEnumerator JermaLeftRoute()
    {
        currentJerma = 12;
        LoadJerma();

        yield return new WaitForSeconds(Random.Range(6f, 8f));

        currentJerma = 13;
        LoadJerma();

        yield return new WaitForSeconds(Random.Range(6f, 8f));

        currentJerma = 14;
        LoadJerma();

        yield return new WaitForSeconds(Random.Range(6f, 8f));

        currentJerma = 1;
        LoadJerma();

        yield return new WaitForSeconds(4f);
        isScaring = true;
        currentJerma = 0;
        LoadJerma();

        yield return new WaitForSeconds(3f);
        isScaring = false;
        currentJerma = 4;
        LoadJerma();
    }

    IEnumerator JermaRightRoute()
    {
        currentJerma = 8;
        LoadJerma();

        yield return new WaitForSeconds(Random.Range(6f, 8f));

        currentJerma = 9;
        LoadJerma();

        yield return new WaitForSeconds(Random.Range(8f, 12f));

        currentJerma = 4;
        LoadJerma();

        yield return new WaitForSeconds(4f);
        isScaring = true;
        currentJerma = 0;
        LoadJerma();

        yield return new WaitForSeconds(3f);
        isScaring = false;
        currentJerma = 4;
        LoadJerma();
    }

    IEnumerator JermaMiddleRoute()
    {
        currentJerma = 10;
        LoadJerma();

        yield return new WaitForSeconds(Random.Range(4f, 7f));

        currentJerma = 11;
        LoadJerma();

        yield return new WaitForSeconds(Random.Range(4f, 7f));

        currentJerma = 3;
        LoadJerma();

        yield return new WaitForSeconds(4f);
        isScaring = true;
        currentJerma = 0;
        LoadJerma();

        yield return new WaitForSeconds(3f);
        isScaring = false;
        currentJerma = 4;
        LoadJerma();
    }
}
