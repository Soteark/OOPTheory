using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{ 
    public static DataManager Instance;
    public int wood = 0;
    public string playerName;
    GameManager gameManager;

    void Awake() {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    [System.Serializable]
    class SaveData {
        public string playerName;
        public int wood;
    }

    public void SaveGame() {
        SaveData data = new SaveData();
        data.playerName = playerName;
        data.wood = wood;

        string json = JsonUtility.ToJson(data);

        System.IO.File.WriteAllText(Application.persistentDataPath + "/savefile_" + playerName + ".json", json);
    }

    public void LoadGame(string playerName) {
        string path = Application.persistentDataPath + "/savefile_" + playerName + ".json";
        if(File.Exists(path)) {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            wood = data.wood;
            playerName = data.playerName;
        }
    }
}
