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
		private Vector2 resolutionSize;

		private void Update()
		{
			ApplyScreenSettingMethod();
		}
		
		private void ApplyScreenSettingMethod()
		{
			switch (screenMode)
			{
				case ScreenMode.ExclusiveFullScreen:
					if (Screen.fullScreenMode != FullScreenMode.ExclusiveFullScreen)
					{
						Screen.SetResolution((int) resolutionSize.x, (int) resolutionSize.y, FullScreenMode.ExclusiveFullScreen);
					}
					break;
				case ScreenMode.FullScreenWindow:
					if (Screen.fullScreenMode != FullScreenMode.FullScreenWindow)
					{
						Screen.SetResolution((int) resolutionSize.x, (int) resolutionSize.y, FullScreenMode.FullScreenWindow);
					}
					break;
				case ScreenMode.MaximizedWindow:
					if (Screen.fullScreenMode != FullScreenMode.MaximizedWindow)
					{
						Screen.SetResolution((int) resolutionSize.x, (int) resolutionSize.y, FullScreenMode.MaximizedWindow);
						
					}
					break;
				case ScreenMode.Windowed:
					if (Screen.fullScreenMode != FullScreenMode.Windowed)
					{
						Screen.SetResolution((int)resolutionSize.x, (int)resolutionSize.y, FullScreenMode.Windowed);
					}
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
    }
}