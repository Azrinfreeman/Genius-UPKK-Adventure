#pragma warning disable 0649

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Watermelon
{
    [DefaultExecutionOrder(-999)]
    public class Initializer : MonoBehaviour
    {
        public static Initializer initializer;

        [SerializeField]
        ProjectInitSettings initSettings;

        [SerializeField]
        EventSystem eventSystem;

        public static GameObject GameObject { get; private set; }
        public static Transform Transform { get; private set; }

        public static ProjectInitSettings InitSettings { get; private set; }

        private bool manualActivation;

        public void RemoveAllDDOL()
        {
            Destroy(GameObject.Find("[POOL OBJECTS]"));
            Destroy(GameObject.Find("[AUDIO LISTENER]"));
            Destroy(GameObject.Find("AUDIO SOURCE OBJECT"));
            Destroy(GameObject.Find("[Debug Updater]"));
            Destroy(GameObject.Find("Initializer"));
        }

        public void Awake()
        {
            if (initializer != null)
                return;

            initializer = this;

            manualActivation = false;

            InitSettings = initSettings;

            GameObject = gameObject;
            Transform = transform;

#if MODULE_INPUT_SYSTEM
            eventSystem.gameObject.GetOrSetComponent<UnityEngine.InputSystem.UI.InputSystemUIInputModule>();
#else
            eventSystem.gameObject.GetOrSetComponent<StandaloneInputModule>();
#endif

            DontDestroyOnLoad(gameObject);

            initSettings.Init(this);
            //DDOLCleaner.Instance.RegisterDDOLObject(gameObject);
        }

        public void Start()
        {
            if (!manualActivation)
                LoadGame(true);
        }

        public void LoadGame(bool loadingScene)
        {
            if (loadingScene)
            {
                GameLoading.LoadGameScene();
            }
            else
            {
                GameLoading.SimpleLoad();
            }
        }

        public void EnableManualActivation()
        {
            manualActivation = true;
        }
    }
}
