using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void ClickButton1()
    {
        if (FaceSwapController.Instance != null)
            FaceSwapController.Instance.SwitchAccessory(0);
    }

    public void ClickButton2()
    {
        if (FaceSwapController.Instance != null)
            FaceSwapController.Instance.SwitchAccessory(1);
    }

    public void ClickButton3()
    {
        if (FaceSwapController.Instance != null)
            FaceSwapController.Instance.SwitchAccessory(2);
    }
    public void ClickButton4()
    {
        if (FaceSwapController.Instance != null)
            FaceSwapController.Instance.SwitchAccessory(3);
    }
    public void ClickButton5()
    {
        if (FaceSwapController.Instance != null)
            FaceSwapController.Instance.SwitchAccessory(4);
    }
    public void ClickButton6()
    {
        if (FaceSwapController.Instance != null)
            FaceSwapController.Instance.SwitchAccessory(5);
    }
    public void ClickButton7()
    {
        if (FaceSwapController.Instance != null)
            FaceSwapController.Instance.SwitchAccessory(6);
    }
}
