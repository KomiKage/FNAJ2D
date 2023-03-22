using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public Camera office;
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public Camera cam5;
    public Camera cam6;
    public Camera cam7;
    public GameObject camUp;
    public GameObject camDown;

    private bool canFlip = true;
    private float cameraCooldown = 0.1f;

    void Start()
    {
        office.gameObject.SetActive(true);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
        cam7.gameObject.SetActive(false);

        camUp.SetActive(true);
        camDown.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CamUp()
    {
        if(canFlip == true)
        {
            office.gameObject.SetActive(false);
            cam1.gameObject.SetActive(true);
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(false);
            cam4.gameObject.SetActive(false);
            cam5.gameObject.SetActive(false);
            cam6.gameObject.SetActive(false);
            cam7.gameObject.SetActive(false);

            camUp.SetActive(false);
            camDown.SetActive(true);

            StartCoroutine(CamCD());
        }
    }

    public void CamDown()
    {
        if(canFlip == true)
        {
            office.gameObject.SetActive(true);
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(false);
            cam4.gameObject.SetActive(false);
            cam5.gameObject.SetActive(false);
            cam6.gameObject.SetActive(false);
            cam7.gameObject.SetActive(false);

            camUp.SetActive(true);
            camDown.SetActive(false);

            StartCoroutine(CamCD());
        }
    }

    public void Cam1()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
        cam7.gameObject.SetActive(false);
    }

    public void Cam2()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(true);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
        cam7.gameObject.SetActive(false);
    }

    public void Cam3()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(true);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
        cam7.gameObject.SetActive(false);
    }

    public void Cam4()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(true);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
        cam7.gameObject.SetActive(false);
    }

    public void Cam5()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(true);
        cam6.gameObject.SetActive(false);
        cam7.gameObject.SetActive(false);
    }

    public void Cam6()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(true);
        cam7.gameObject.SetActive(false);
    }

    public void Cam7()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
        cam7.gameObject.SetActive(true);
    }

    IEnumerator CamCD()
    {
        canFlip = false;
        yield return new WaitForSeconds(cameraCooldown);
        canFlip = true;
    }
}
