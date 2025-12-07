using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Watermelon.AI;

namespace Watermelon
{
    public class ResetMissionController : MonoBehaviour
    {
        public static ResetMissionController instance;

        void Awake()
        {
            instance = this;
            LoadAll();
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start() { }

        // Update is called once per frame
        void Update() { }

        [System.Serializable]
        public class SaveData
        {
            public int FirstTime;

            public string CurrentPlayer;
            public string CurrentPlayerId;

            public int PlayerTotal;
            public int CurrentPlayerNo;

            public List<string> Player_ = new List<string>();
            public List<string> PlayerId_ = new List<string>();
            public List<string> StarsCollected_ = new List<string>();
        }

        public void LoadAll()
        {
            string path = Application.persistentDataPath + "/save.json";

            SaveData data;

            // Check if file exists
            if (File.Exists(path))
            {
                // File exists → load normally
                string json = File.ReadAllText(path);
                data = JsonUtility.FromJson<SaveData>(json);
                Debug.Log("Save file loaded.");

                PlayerPrefs.SetInt("FirstTime", data.FirstTime);
                PlayerPrefs.SetString("CurrentPlayer_", data.CurrentPlayer);
                PlayerPrefs.SetString("CurrentPlayerid_", data.CurrentPlayerId);
                PlayerPrefs.SetInt("PlayerTotal", data.PlayerTotal);
                PlayerPrefs.SetInt("CurrentPlayerNo_", data.CurrentPlayerNo);

                // Restore list data
                for (int i = 0; i < data.Player_.Count; i++)
                {
                    PlayerPrefs.SetString($"Player_{i}", data.Player_[i]);
                }

                for (int i = 0; i < data.PlayerId_.Count; i++)
                {
                    PlayerPrefs.SetString($"Playerid_{i}", data.PlayerId_[i]);
                }

                for (int i = 0; i < data.StarsCollected_.Count; i++)
                {
                    PlayerPrefs.SetString($"StarsCollected_{i}", data.StarsCollected_[i]);
                }

                PlayerPrefs.Save();
            }
            else
            {
                // File not found → create default data
                data = new SaveData();
                data.FirstTime = 1;
                data.PlayerTotal = 0;

                Debug.Log("No save file found. Creating new save data.");
            }
        }

        public static class SaveSystem
        {
            private static string path = Application.persistentDataPath + "/save.json";

            public static void Save(SaveData data)
            {
                string json = JsonUtility.ToJson(data, true);
                File.WriteAllText(path, json);
                Debug.Log("Saved to: " + path);
            }

            public static SaveData Load()
            {
                if (!File.Exists(path))
                {
                    Debug.Log("Save file not found, creating new.");
                    return new SaveData();
                }

                string json = File.ReadAllText(path);
                SaveData data = JsonUtility.FromJson<SaveData>(json);

                return data;
            }
        }

        public void SaveAll()
        {
            SaveData data = new SaveData();

            data.FirstTime = PlayerPrefs.GetInt("FirstTime");
            data.CurrentPlayer = PlayerPrefs.GetString("CurrentPlayer_");
            data.CurrentPlayerId = PlayerPrefs.GetString("CurrentPlayerid_");
            data.PlayerTotal = PlayerPrefs.GetInt("PlayerTotal");
            data.CurrentPlayerNo = PlayerPrefs.GetInt("CurrentPlayerNo_");

            // Save list data
            for (int i = 0; i < data.PlayerTotal; i++)
            {
                data.Player_.Add(PlayerPrefs.GetString($"Player_{i}", ""));
                data.PlayerId_.Add(PlayerPrefs.GetString($"Playerid_{i}", ""));
                data.StarsCollected_.Add(PlayerPrefs.GetString($"StarsCollected_{i}", "0"));
            }

            SaveSystem.Save(data);
        }

        public void DeleteSaveFile()
        {
            string path = Path.Combine(Application.persistentDataPath, "save");
            string path2 = Path.Combine(Application.persistentDataPath, "SavePresets");
            if (File.Exists(path))
            {
                File.Delete(path);
                Debug.Log("Save file deleted: " + path);
            }
            else
            {
                Debug.Log("Save file not found: " + path);
            }
            if (Directory.Exists(path2))
            {
                try
                {
                    // The 'true' parameter ensures the folder and all its contents are deleted (recursive deletion)
                    Directory.Delete(path2, true);

                    Debug.Log($"Successfully deleted folder: {path2}");
                }
                catch (IOException ex)
                {
                    // Handle potential errors like permissions issues or files being in use
                    Debug.LogError(
                        $"Error deleting persistent data folder at {path2}: {ex.Message}"
                    );
                }
            }
            else
            {
                Debug.LogWarning($"Persistent data folder not found at: {path2}");
            }
        }

        IEnumerator resetting()
        {
            SaveAll();

            DeleteSaveFile();
            //delete all saved files
            //  PlayerPrefs.DeleteAll();
            //  SaveController.DeleteSaveFile();

            yield return new WaitForSeconds(1.2f);
            //reinit again

            yield return new WaitForSeconds(0.2f);
        }

        public void ResetLevel()
        {
            StartCoroutine(resetting());
        }
    }
}
