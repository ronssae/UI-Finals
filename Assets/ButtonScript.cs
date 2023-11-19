using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject Model, MainMenu, TransformMenu, CustomizeMenu, AnimateMenu, ChangeMenu;

    public float RotateSpeed = 50f;
    public float Scale = 0.001f;

    bool RotateStatus = false;
    bool BigScale, SmallScale;

    public void Start()
    {
        MainMenu.SetActive(true);
        TransformMenu.SetActive(false);
        CustomizeMenu.SetActive(false);
        AnimateMenu.SetActive(false);
        ChangeMenu.SetActive(false);
    }
    public void Transform()
    {
        MainMenu.SetActive(false);
        TransformMenu.SetActive(true);

    }

    public void Customize()
    {
        MainMenu.SetActive(false);
        CustomizeMenu.SetActive(true);
    }
    public void Animate()
    {
        MainMenu.SetActive(false);
        AnimateMenu.SetActive(true);
    }
    public void Change()
    {
        MainMenu.SetActive(false);
        CustomizeMenu.SetActive(true);
    }

    public void Back()
    {
        Start();
    }

    public void Rotate()
    {
        if (RotateStatus == false)
        {
            RotateStatus = true;
        }
        else
        {
            RotateStatus = false;
        }
    }
    public void OnPressBigScale()
    {
        BigScale = true;
    }
    public void OnReleaseBigScale()
    {
        BigScale = false;
    }
    public void OnPressSmallScale()
    {
        SmallScale = true;
    }
    public void OnReleaseSmallScale()
    {
        SmallScale = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (RotateStatus == true)
        {
            Model.transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime);
        }

        if (BigScale)
        {
            Model.transform.localScale += new Vector3(Scale, Scale, Scale) * Time.deltaTime;
        }

        if (SmallScale)
        {
            Model.transform.localScale -= new Vector3(Scale, Scale, Scale) * Time.deltaTime;
        }
    }
}
