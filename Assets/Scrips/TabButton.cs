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
    Color btnColor;
    TabController parent;


    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(SwitchTap);
        parent = gameObject.transform.parent.GetComponent<TabController>();
        btnImage = btn.GetComponent<Image>();

        if (btnImage != null)
        {
            Debug.Log("색상 설정");
            btnColor = btnImage.color;
        }
    }

    void SwitchTap()  //탭 변경
    {
        parent.SwitchTap(this);
    }

    public void ChangeButtonImageAlpa(float value)  //버튼 투명도 변경
    {
        if (btnColor == null) return;

        Color color = btnColor;
        color.a = value;
        btnColor = color;
    }
}
