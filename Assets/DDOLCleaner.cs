using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Watermelon
{
    public class DDOLCleaner : MonoBehaviour
    {
        public static DDOLCleaner Instance { get; private set; }

        [Header("DDOL Objects to be Cleaned")]
        [Tooltip("List of objects that were manually marked DDOL and need destruction.")]
        public List<GameObject> objectsToDestroy = new List<GameObject>();
        public Transform Initializer;

        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                // If another instance exists, destroy this duplicate
                Destroy(this.gameObject);
            }
            else
            {
                Instance = this;
                // Mark the cleaner itself as DDOL so it persists across all scenes
                // and can perform the cleanup whenever needed.
                DontDestroyOnLoad(this.gameObject);
            }

            // Attach a listener to the SceneManager event. This is a common pattern:
            // when a new scene is loaded, we can check if a cleanup is necessary.
            SceneManager.sceneLoaded += OnSceneLoadedCleanup;
        }

        void OnDestroy()
        {
            // Important: Always remove event listeners when the object is destroyed.
            SceneManager.sceneLoaded -= OnSceneLoadedCleanup;
        }

        /// <summary>
        /// Call this method from any script that applies DontDestroyOnLoad to register
        /// the object for future cleanup.
        /// </summary>
        /// <param name="obj">The GameObject that was marked as DDOL.</param>
        public void RegisterDDOLObject(GameObject obj)
        {
            if (obj != null && !objectsToDestroy.Contains(obj))
            {
                objectsToDestroy.Add(obj);
                Debug.Log($"Registered DDOL Object for Cleanup: {obj.name}");
            }
        }

        /// <summary>
        /// This is the core logic. It iterates through the list and destroys every registered object.
        /// </summary>
        public void DestroyRegisteredDDOLObjects()
        {
            Debug.Log($"--- Starting DDOL Cleanup: {objectsToDestroy.Count} objects found. ---");

            // Iterate backward in case any objects try to register/unregister themselves during destruction
            for (int i = objectsToDestroy.Count - 1; i >= 0; i--)
            {
                GameObject obj = objectsToDestroy[i];
                if (obj != null)
                {
                    Debug.Log($"Destroying persistent object: {obj.name}");
                    Destroy(obj);
                }
            }

            objectsToDestroy.Clear(); // Clear the list after destruction
            Debug.Log("--- DDOL Cleanup Complete. ---");
        }

        // Triggered automatically after a scene load completes
        private void OnSceneLoadedCleanup(Scene scene, LoadSceneMode mode)
        {
            // Example logic: Only destroy persistent objects when we return to the Main Menu (Scene 0)
            // If you want cleanup on ALL scene loads, remove the 'if' statement.
            if (scene.buildIndex == 0)
            {
                DestroyRegisteredDDOLObjects();
            }
        }

        // Example public method to start a scene transition and ensure cleanup happens
        public void LoadNewScene(int sceneIndex)
        {
            // RECOMMENDED CLEANUP POINT: Execute the destruction of old DDOL objects
            // right before loading the new scene to ensure a clean slate.
            DestroyRegisteredDDOLObjects();

            // Now load the new scene
            SceneManager.LoadScene(sceneIndex);
        }

        void Start()
        {
            Debug.Log("Happened");
        }

        public void Reinit() { }
    }
}
