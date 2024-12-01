using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Scrollbar_Scale : MonoBehaviour
{
    [FormerlySerializedAs("m_Scrollbar")] [SerializeField, Tooltip("스크롤 바 크기 강제 조절")]
    private Scrollbar mScrollbar;

    [SerializeField] private float mScale;

    private void Update()
    {
        mScrollbar.size = mScale;
    }
}
