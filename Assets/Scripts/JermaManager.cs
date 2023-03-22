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

        for (var i = 0; i < JermaList.Count; i++)
        {
            JermaList[i].SetActive(false);
        }

        Jerma1p1.SetActive(true);
    }

    void Update()
    {
        
    }
}
