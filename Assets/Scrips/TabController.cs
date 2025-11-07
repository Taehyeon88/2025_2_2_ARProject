using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabController : MonoBehaviour
{
    TabButton[] taps;

    void Start()
    {
        taps = GetComponentsInChildren<TabButton>();
        SwitchTap(taps[0]);      //탭 초기로 설정
    }

    public void SwitchTap(TabButton tapButton)
    {
        foreach (var tap in taps)
        {
            bool _isActiveTap = tapButton == tap;               //현재 탭이 변경될 탭인지 확인
            tap.GetPanel.SetActive(_isActiveTap);               //현재 탭의 활성화 설정
            tap.ChangeButtonImageAlpa(_isActiveTap ? 1 : 0.25f); //탭 버튼의 투명도 설정
        }
    }
}
