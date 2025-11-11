using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class TabButton : MonoBehaviour
{
    [SerializeField] GameObject panel;
    public GameObject GetPanel => panel;

    Image btnImage;
    TabController parent;


    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(SwitchTap);
        parent = gameObject.transform.parent.GetComponent<TabController>();
        btnImage = GetComponent<Image>();

    }

    void SwitchTap()  //탭 변경
    {
        parent.SwitchTap(this);
    }

    public void ChangeButtonImageAlpa(float value)  //버튼 투명도 변경
    {
        if (btnImage == null) return;
        Debug.Log(btnImage.color);

        Color color = btnImage.color;
        color.a = value;
        btnImage.color = color;
    }
}
