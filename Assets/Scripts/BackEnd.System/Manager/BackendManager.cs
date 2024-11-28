using BackEnd;
using UnityEngine;

public class BackendManager : MonoBehaviour
{
    /// <summary>
    /// 게임 시작 시 호출되어 초기 설정을 수행합니다.
    /// Called at the start of the game to perform initial settings.
    /// </summary>
    private void Awake()
    {
        // 이 게임 오브젝트는 다른 씬으로 전환되어도 파괴되지 않음
        // This game object will not be destroyed when switching scenes.
        DontDestroyOnLoad(gameObject);

        // 백엔드 초기화 호출
        // Initialize the backend.
        InitializeBackend();
    }

    /// <summary>
    /// 백엔드 초기화를 처리하는 함수
    /// Handles the backend initialization.
    /// </summary>
    private void InitializeBackend()
    {
        // 백엔드 비동기 초기화 호출
        // Calls the backend initialization asynchronously.
        Backend.InitializeAsync(OnBackendInitialized);
    }

    /// <summary>
    /// 백엔드 초기화 완료 후 호출되는 콜백 메서드
    /// Callback method invoked when the backend initialization is complete.
    /// </summary>
    /// <param name="callback">
    /// 초기화 결과를 포함하는 BackendReturnObject
    /// The BackendReturnObject containing the initialization result.
    /// </param>
    private void OnBackendInitialized(BackendReturnObject callback)
    {
        if (callback.IsSuccess())
        {
            // 초기화가 성공했을 때
            // When initialization is successful.
            Debug.Log("백엔드 초기화 성공\nThe server initialization was successful.\nStatus Code: 204");
        }
        else
        {
            // 초기화가 실패했을 때
            // When initialization fails.
            Debug.LogError($"백엔드 초기화 실패\nServer initialization failed.\nMessage: {callback.Message}");
        }
    }
}