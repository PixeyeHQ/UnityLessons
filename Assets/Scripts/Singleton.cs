using UnityEngine;


namespace Homebrew
{
    
   
    
    public class Singleton<T> : MonoBehaviour where T: MonoBehaviour
    {

        
        private static T _instance;
        private static object _lock = new object();
        public static bool applicationQuit;
        
        
        public static T Instance
        {

            get
            {

                if (applicationQuit) return null;
               
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = FindObjectOfType<T>();

                        if (_instance == null)
                        {
                            var go = new GameObject("Singleton: " + typeof(T));
                            _instance = go.AddComponent<T>();
                            DontDestroyOnLoad(go);

                        }

                    }

                    return _instance;

                }
                
            }

        }


        void OnDestroy()
        {
            applicationQuit = true;
        }

    }

}
 
