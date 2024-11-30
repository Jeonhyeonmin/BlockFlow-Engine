using System;
using UnityEngine;

namespace Windows.Setting
{
    public enum ScreenMode
    {
        ExclusiveFullScreen,
        FullScreenWindow,
        MaximizedWindow,
        Windowed
    }
    
    public class ResolutionController : MonoBehaviour
    {
        [Header("현재 장면의 스크린 속성")]
        
        [SerializeField, Tooltip("스크린 모드를 지정하는 변수")]
        private ScreenMode screenMode;

        [SerializeField, Tooltip("스크린 사이즈를 지정하는 변수")]
        private Vector2 resolutionSize = new Vector2(1920, 1080);
        
        private void Awake()
        {
            SetScreenMode();
        }

        private void SetScreenMode()
        {
            FullScreenMode unityScreenMode;

            switch (screenMode)
            {
                case ScreenMode.ExclusiveFullScreen:
                    unityScreenMode = FullScreenMode.ExclusiveFullScreen;
                    break;
                case ScreenMode.FullScreenWindow:
                    unityScreenMode = FullScreenMode.FullScreenWindow;
                    break;
                case ScreenMode.MaximizedWindow:
                    unityScreenMode = FullScreenMode.MaximizedWindow;
                    break;
                case ScreenMode.Windowed:
                    unityScreenMode = FullScreenMode.Windowed;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Screen.SetResolution((int)resolutionSize.x, (int)resolutionSize.y, unityScreenMode);
        }
    }
}