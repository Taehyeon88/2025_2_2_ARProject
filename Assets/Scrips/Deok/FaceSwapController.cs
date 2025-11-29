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

    public void SwitchAccessory(int index)
    {
        foreach (var item in accessories)
        {
            if (item != null) item.SetActive(false);
        }
        if (index >= 0 && index < accessories.Count && accessories[index] != null)
        {
            accessories[index].SetActive(true);
        }
    }
}
