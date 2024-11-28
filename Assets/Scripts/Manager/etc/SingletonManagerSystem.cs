namespace Manager.etc
{
    /// <summary>
    /// 제네릭 싱글톤 매니저 클래스.
    /// 특정 타입 T의 싱글톤 인스턴스를 제공합니다.
    /// Generic Singleton Manager class.
    /// Provides a singleton instance for a specific type T.
    /// </summary>
    /// <typeparam name="T">싱글톤 인스턴스로 관리할 타입 / Type of the singleton instance to manage</typeparam>
    public class SingletonManagerSystem<T> where T : class, new()
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
                if (_instance == null)
                {
                    // 인스턴스가 존재하지 않으면 새로 생성합니다.
                    // If the instance does not exist, create a new one.
                    _instance = new T();
                }

                // 생성된 인스턴스를 반환합니다.
                // Return the created instance.
                return _instance;
            }
        }
    }
}