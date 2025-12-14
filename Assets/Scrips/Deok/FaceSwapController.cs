using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceSwapController : MonoBehaviour
{
    public static FaceSwapController Instance;
    public List<GameObject> accessories;

    private void Awake()
    {
        Instance = this;
    }

    public void SwitchAccessory(int index)   //0 ~ 6 : ¸Ó¸® | 7,8 : ¾ó±¼
    {
        bool isHat = index <= 6;
        for (int i = 0; i < accessories.Count; i++)
        {
            if (accessories[i] != null)
            {
                if (isHat) if (i >= 7) return;
                else
                if (i <= 6) return;

                accessories[i].SetActive(false);
            }
        }
        if (index >= 0 && index < accessories.Count && accessories[index] != null)
        {
            accessories[index].SetActive(true);
        }
    }
}
