using UnityEngine;
using UnityEngine.SceneManagement;

namespace Watermelon
{
    [DefaultExecutionOrder(-10)]
    public class GameController : MonoBehaviour
    {
        private static GameController instance;

        [SerializeField]
        GameData gameData;
        public static GameData Data => instance.gameData;

        [Space]
        [SerializeField]
        UIController uiController;

        [SerializeField]
        public static QuestionController questionController;

        [SerializeField]
        DefaultMusicController defaultMusicController;

        [SerializeField]
        CameraController cameraController;

        [SerializeField]
        public static CanvasGroup uigameCanvas;

        private static WorldController worldController;
        private static GlobalUpgradesController globalUpgradesController;
        private static MissionsController missionsController;
        private static ParticlesController particlesController;
        private static NavigationHelper navigationHelper;
        private static FloatingTextController floatingTextController;
        private static UnlockableToolsController unlockableToolsController;
        private static FishingController fishingController;
        private static DiggingController diggingController;
        private static SkinController skinController;
        private static EnergyController energyController;
        private static EnvironmentController environmentController;

        private void Awake()
        {
            instance = this;

            CacheComponent(out worldController);
            CacheComponent(out globalUpgradesController);
            CacheComponent(out missionsController);
            CacheComponent(out particlesController);
            CacheComponent(out navigationHelper);
            CacheComponent(out floatingTextController);
            CacheComponent(out unlockableToolsController);
            CacheComponent(out fishingController);
            CacheComponent(out diggingController);
            CacheComponent(out skinController);
            CacheComponent(out energyController);
            CacheComponent(out environmentController);

            Data.Init();

            defaultMusicController.Initialise();

            uiController.Init();

            cameraController.Initialise();
            PreviewCamera.Initialise();

            skinController.Init();

            unlockableToolsController.Initialise();

            energyController.Initialise();

            environmentController.Initialise();

            fishingController.Initialise();

            diggingController.Initialise();

            globalUpgradesController.Initialise();

            floatingTextController.Init();

            worldController.Initialise();

            uiController.InitPages();

            particlesController.Init();

            navigationHelper.Initialise();

            uigameCanvas = GameObject.Find("UI Game").GetComponent<CanvasGroup>();
            questionController = GameObject
                .Find("QuestionController")
                .GetComponent<QuestionController>();
        }

        private void Start()
        {
            if (gameData.UseMainMenu)
            {
                DefaultMusicController.ActivateMusic();

                UIController.ShowPage<UIMainMenu>();
                Control.DisableMovementControl();
                uigameCanvas.alpha = 0f;
                //load background scene
                //SceneManager.LoadScene("World 0", LoadSceneMode.Additive);
                questionController.GetComponent<Transform>().gameObject.SetActive(false);
            }
            else
            {
                worldController.LoadCurrentWorld();
            }

            // Move this method to the point when the game is fully loaded
            GameLoading.MarkAsReadyToHide();
        }

        private void OnDestroy()
        {
            Data.Unload();

            NavigationHelper.Unload();

            DistanceToggle.Unload();

            FishingController.Unload();

            diggingController.Disable();
            diggingController.Unload();

            NavMeshController.Reset();

            Tween.RemoveAll();
        }

        public static void LoadLevel1()
        {
            Control.EnableMovementControl();
            uigameCanvas.alpha = 1f;
            worldController.LoadWorld("64237034-5379-4daf-b152-be8359ced037");
        }

        public static void LoadLevel2()
        {
            Control.EnableMovementControl();
            uigameCanvas.alpha = 1f;
            worldController.LoadWorld("6658372b-e731-4539-a2aa-3bce2e7e0dd2");
        }

        public static void LoadLevel3()
        {
            Control.EnableMovementControl();
            uigameCanvas.alpha = 1f;
            worldController.LoadWorld("b22c70f1-a827-4dca-a75b-3914dcf2b0c5");
        }

        public static void LoadLevel4()
        {
            Control.EnableMovementControl();
            uigameCanvas.alpha = 1f;
            worldController.LoadWorld("0bdd3d6f-e8e1-49d3-b22f-bf0099d78bdd");
        }

        public static void LoadCurrentWorld()
        {
            worldController.LoadCurrentWorld();
        }

        public static void OpenMainMenu()
        {
            // Show fullscreen black overlay
            Overlay.Show(
                0.3f,
                () =>
                {
                    // Save the current state of the game
                    SaveController.Save(true);

                    // Show main menu
                    UIController.ShowPage<UIMainMenu>();

                    // Unload the current world and all the dependencies
                    GameController.UnloadWorld(() =>
                    {
                        DefaultMusicController.ActivateMusic();

                        UIGamepadButton.DisableAllTags();
                        UIGamepadButton.EnableTag(UIGamepadButtonTag.MainMenu);

                        // Disable fullscreen black overlay
                        Overlay.Hide(0.3f);
                    });
                },
                true
            );
        }

        public static void OnWorldLoaded(WorldBehavior worldBehavior)
        {
            UIController.ShowPage<UIGame>();

            fishingController.SpawnFishingPlaces();

            missionsController.Initialise(worldBehavior.MissionsHolder?.Missions);

            diggingController.Activate(worldBehavior.DiggingSpawnSettings);
        }

        public static void UnloadWorld(SimpleCallback onUnloaded)
        {
            Tween.RemoveAll();

            NavigationHelper.Unload();

            DistanceToggle.Unload();

            FishingController.Unload();

            diggingController.Disable();
            diggingController.Unload();

            worldController.UnloadWorld(onUnloaded);
        }

        public static void LoadWorld(
            string worldID,
            SimpleCallback onWorldUnloaded = null,
            SimpleCallback onNewWorldLoaded = null
        )
        {
            UIController.HidePage<UIGame>();

            // Show fullscreen black overlay
            Overlay.Show(
                0.3f,
                () =>
                {
                    // Save the current state of the game
                    SaveController.Save(true);

                    // Unload the current world and all the dependencies
                    GameController.UnloadWorld(() =>
                    {
                        onWorldUnloaded?.Invoke();

                        // Load next world
                        worldController.LoadWorld(worldID);

                        // Disable fullscreen black overlay
                        Overlay.Hide(
                            0.3f,
                            () =>
                            {
                                UIController.ShowPage<UIGame>();

                                onNewWorldLoaded?.Invoke();
                            }
                        );
                    });
                },
                true
            );
        }

        #region Extensions
        public bool CacheComponent<T>(out T component)
            where T : Component
        {
            Component unboxedComponent = gameObject.GetComponent(typeof(T));

            if (unboxedComponent != null)
            {
                component = (T)unboxedComponent;

                return true;
            }

            Debug.LogError(
                string.Format("Scripts Holder doesn't have {0} script added to it", typeof(T))
            );

            component = null;

            return false;
        }
        #endregion
    }
}
