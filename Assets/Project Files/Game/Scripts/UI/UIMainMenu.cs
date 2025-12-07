using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Watermelon
{
    public class UIMainMenu : UIPage
    {
        [SerializeField]
        RectTransform safeAreaRectTransform;

        [Space]
        [SerializeField]
        Button current;

        [SerializeField]
        Button level1;

        [Space]
        [SerializeField]
        Button level2;

        [SerializeField]
        Button level3;

        [SerializeField]
        Button level4;

        [SerializeField]
        Button quitButton;

        public void ResetData()
        {
            StartCoroutine(Reset());
        }

        public void RestartApp()
        {
            AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>(
                "currentActivity"
            );

            activity.Call("finish"); // close Unity activity

            AndroidJavaObject pm = activity.Call<AndroidJavaObject>("getPackageManager");
            AndroidJavaObject intent = pm.Call<AndroidJavaObject>(
                "getLaunchIntentForPackage",
                activity.Call<string>("getPackageName")
            );
            intent.Call<AndroidJavaObject>("addFlags", 0x10000000); // FLAG_ACTIVITY_NEW_TASK
            activity.Call("startActivity", intent);
        }

        IEnumerator Reset()
        {
            ResetMissionController.instance.ResetLevel();
            PlayerPrefs.DeleteAll();
            SaveController.DeleteSaveFile();

            // DDOLCleaner.Instance.DestroyRegisteredDDOLObjects();
            Debug.Log("Save files are removed!");
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene(0);
            yield return new WaitForSeconds(1f);
            //DDOLCleaner.Instance.Reinit();
            yield return !Application.isPlaying;
        }

        public override void Init()
        {
            NotchSaveArea.RegisterRectTransform(safeAreaRectTransform);

            current.onClick.AddListener(OnPlayButtonClicked1);
            level1.onClick.AddListener(OnPlayButtonClicked1);
            level2.onClick.AddListener(OnPlayButtonClicked2);
            level3.onClick.AddListener(OnPlayButtonClicked3);
            level4.onClick.AddListener(OnPlayButtonClicked4);
#if (UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR
            Destroy(quitButton.gameObject);
#else
            quitButton.onClick.AddListener(OnQuitButtonClicked);
#endif
        }

        #region Show/Hide

        public override void PlayShowAnimation()
        {
            UIController.OnPageOpened(this);
        }

        public override void PlayHideAnimation()
        {
            UIController.OnPageClosed(this);
        }

        #endregion

        #region Buttons

        public void OnPlayButtonClick0()
        {
#if MODULE_HAPTIC
            Haptic.Play(Haptic.HAPTIC_LIGHT);
#endif

            AudioController.PlaySound(AudioController.AudioClips.buttonSound);

            Overlay.Show(
                0.3f,
                () =>
                {
                    UIController.HidePage<UIMainMenu>();

                    GameController.LoadCurrentWorld();

                    Overlay.Hide(0.3f, null);
                }
            );
        }

        public void OnPlayButtonClicked1()
        {
#if MODULE_HAPTIC
            Haptic.Play(Haptic.HAPTIC_LIGHT);
#endif

            AudioController.PlaySound(AudioController.AudioClips.buttonSound);

            Overlay.Show(
                0.3f,
                () =>
                {
                    UIController.HidePage<UIMainMenu>();

                    GameController.LoadLevel1();

                    Overlay.Hide(0.3f, null);
                }
            );
        }

        public void OnPlayButtonClicked2()
        {
#if MODULE_HAPTIC
            Haptic.Play(Haptic.HAPTIC_LIGHT);
#endif

            AudioController.PlaySound(AudioController.AudioClips.buttonSound);

            Overlay.Show(
                0.3f,
                () =>
                {
                    UIController.HidePage<UIMainMenu>();

                    GameController.LoadLevel2();

                    Overlay.Hide(0.3f, null);
                }
            );
        }

        public void OnPlayButtonClicked3()
        {
#if MODULE_HAPTIC
            Haptic.Play(Haptic.HAPTIC_LIGHT);
#endif

            AudioController.PlaySound(AudioController.AudioClips.buttonSound);

            Overlay.Show(
                0.3f,
                () =>
                {
                    UIController.HidePage<UIMainMenu>();

                    GameController.LoadLevel3();

                    Overlay.Hide(0.3f, null);
                }
            );
        }

        public void OnPlayButtonClicked4()
        {
#if MODULE_HAPTIC
            Haptic.Play(Haptic.HAPTIC_LIGHT);
#endif

            AudioController.PlaySound(AudioController.AudioClips.buttonSound);

            Overlay.Show(
                0.3f,
                () =>
                {
                    UIController.HidePage<UIMainMenu>();

                    GameController.LoadLevel4();

                    Overlay.Hide(0.3f, null);
                }
            );
        }

        public void OnQuitButtonClicked()
        {
#if MODULE_HAPTIC
            Haptic.Play(Haptic.HAPTIC_LIGHT);
#endif

            AudioController.PlaySound(AudioController.AudioClips.buttonSound);

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
        #endregion
    }
}
