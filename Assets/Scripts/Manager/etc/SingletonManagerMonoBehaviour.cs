using UnityEngine;

public enum DestroyType
{
    None,
    Destroy
}

/// <summary>
/// 제네릭 싱글톤 매니저 클래스.
/// 특정 MonoBehaviour 타입 T의 싱글톤 인스턴스를 제공합니다.
/// Generic Singleton Manager class.
/// Provides a singleton instance for a specific MonoBehaviour type T.
/// </summary>
/// <typeparam name="T">MonoBehaviour 타입 / MonoBehaviour type</typeparam>
public class SingletonManagerMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    // Singleton 인스턴스를 저장하는 변수
    // Variable to store the singleton instance
    private static T _instance;

    /// <summary>
    /// 싱글톤 인스턴스를 반환합니다. 
    /// 만약 인스턴스가 존재하지 않으면 자동으로 생성됩니다.
    /// Returns the singleton instance. 
    /// If the instance does not exist, it will be automatically created.
    /// </summary>
    public static T Instance
    {
        get
        {
            // 인스턴스가 없는 경우 생성하거나 기존 인스턴스를 찾음
            // Create or find the instance if it does not exist
            if (_instance == null)
            {
                // 이미 존재하는 T 타입의 오브젝트를 검색
                // Find an existing object of type T
                _instance = (T)FindAnyObjectByType<T>();

                // 검색 결과가 없는 경우 새 오브젝트를 생성
                // If none is found, create a new one
                if (_instance == null)
                {
                    GameObject _tempObject = new GameObject(typeof(T).Name, typeof(T));
                    _instance = _tempObject.AddComponent<T>();
                }
            }

            return _instance;
        }
    }

    /// <summary>
    /// Unity의 Awake 메서드로, 싱글톤 오브젝트가 씬 전환 시 삭제되지 않도록 설정합니다.
    /// Unity's Awake method to ensure the singleton object is not destroyed on scene transition.
    /// </summary>
    private void Awake()
    {
        // 최상위(parent 없는) 오브젝트에 대해 DontDestroyOnLoad 설정
        // Set the top-level object (without a parent) to DontDestroyOnLoad
        if (transform.parent != null && transform.root != null)
        {
            DontDestroyOnLoad(this.transform.root.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
