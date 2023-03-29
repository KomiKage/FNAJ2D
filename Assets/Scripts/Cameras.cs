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
    public GameObject Mask;

    private int lastActive = 1;

    private List<Camera> CameraList = new List<Camera>();

    private bool canFlip = true;
    private bool canEquip = true;
    private float cameraCooldown = 0.1f;

    public static bool maskUp = false;

    void Start()
    {
        CameraList.Add(office);
        CameraList.Add(cam1);
        CameraList.Add(cam2);
        CameraList.Add(cam3);
        CameraList.Add(cam4);
        CameraList.Add(cam5);
        CameraList.Add(cam6);
        CameraList.Add(cam7);

        office.gameObject.SetActive(true);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
        cam7.gameObject.SetActive(false);

        for (var i = 0; i < CameraList.Count; i++)
        {
            if(i == 0)
            {
                CameraList[i].gameObject.SetActive(true);
            }
            else
            {
                CameraList[i].gameObject.SetActive(false);
            }
        }

        camUp.SetActive(true);
        camDown.SetActive(false);
    }

    private void Update()
    {
        if(JermaManager.isScaring == true && maskUp == false)
        {
            JermaManager.gotScared = true;
            canEquip = false;
            canFlip = false;
        }
    }

    public void MaskSwitch()
    {
        if(maskUp == false)
        {
            if (canEquip == true)
            {
                maskUp = true;
                Mask.gameObject.SetActive(true);
                canFlip = false;
                StartCoroutine(MaskCD());
            }
        }
        
        if(maskUp == true)
        {
            if (canEquip == true)
            {
                maskUp = false;
                Mask.gameObject.SetActive(false);
                canFlip = true;
                StartCoroutine(MaskCD());
            }
        }
    }


    public void CamUp()
    {
        if(canFlip == true)
        {
            canEquip = false;

            for (var i = 0; i < CameraList.Count; i++)
            {
                if (i == lastActive)
                {
                    CameraList[i].gameObject.SetActive(true);
                }
                else
                {
                    CameraList[i].gameObject.SetActive(false);
                }
            }

            camUp.SetActive(false);
            camDown.SetActive(true);

            StartCoroutine(CamCD());
        }
    }

    public void CamDown()
    {
        if(canFlip == true)
        {
            canEquip = true;

            for (var i = 0; i < CameraList.Count; i++)
            {
                if (i == 0)
                {
                    CameraList[i].gameObject.SetActive(true);
                }
                else
                {
                    CameraList[i].gameObject.SetActive(false);
                }
            }

            camUp.SetActive(true);
            camDown.SetActive(false);

            StartCoroutine(CamCD());
        }
    }

    public void Cam1()
    {
        for (var i = 0; i < CameraList.Count; i++)
        {
            if (i == 1)
            {
                CameraList[i].gameObject.SetActive(true);
                lastActive = i;
            }
            else
            {
                CameraList[i].gameObject.SetActive(false);
            }
        }
    }

    public void Cam2()
    {
        for (var i = 0; i < CameraList.Count; i++)
        {
            if (i == 2)
            {
                CameraList[i].gameObject.SetActive(true);
                lastActive = i;
            }
            else
            {
                CameraList[i].gameObject.SetActive(false);
            }
        }
    }

    public void Cam3()
    {
        for (var i = 0; i < CameraList.Count; i++)
        {
            if (i == 3)
            {
                CameraList[i].gameObject.SetActive(true);
                lastActive = i;
            }
            else
            {
                CameraList[i].gameObject.SetActive(false);
            }
        }
    }

    public void Cam4()
    {
        for (var i = 0; i < CameraList.Count; i++)
        {
            if (i == 4)
            {
                CameraList[i].gameObject.SetActive(true);
                lastActive = i;
            }
            else
            {
                CameraList[i].gameObject.SetActive(false);
            }
        }
    }

    public void Cam5()
    {
        for (var i = 0; i < CameraList.Count; i++)
        {
            if (i == 5)
            {
                CameraList[i].gameObject.SetActive(true);
                lastActive = i;
            }
            else
            {
                CameraList[i].gameObject.SetActive(false);
            }
        }
    }

    public void Cam6()
    {
        for (var i = 0; i < CameraList.Count; i++)
        {
            if (i == 6)
            {
                CameraList[i].gameObject.SetActive(true);
                lastActive = i;
            }
            else
            {
                CameraList[i].gameObject.SetActive(false);
            }
        }
    }

    public void Cam7()
    {
        for (var i = 0; i < CameraList.Count; i++)
        {
            if (i == 7)
            {
                CameraList[i].gameObject.SetActive(true);
                lastActive = i;
            }
            else
            {
                CameraList[i].gameObject.SetActive(false);
            }
        }
    }

    IEnumerator CamCD()
    {
        canFlip = false;
        yield return new WaitForSeconds(cameraCooldown);
        canFlip = true;
    }

    IEnumerator MaskCD()
    {
        canEquip = false;
        yield return new WaitForSeconds(cameraCooldown);
        canEquip = true;
    }
}
