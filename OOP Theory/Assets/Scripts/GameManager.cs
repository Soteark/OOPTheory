using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerName;
    public TextMeshProUGUI woodCount;

    void Start() {
        UpdateUI(DataManager.Instance.wood);
    }

    public void Exit() {
        DataManager.Instance.SaveGame();

        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }

    public void StartGame() {
        DataManager.Instance.playerName = playerName.text;
        SceneManager.LoadScene(1);
        DataManager.Instance.LoadGame(playerName.text);
    }

    public void UpdateUI(int woodAmt) {
        if(woodCount != null)
            woodCount.text = "Wood: " + woodAmt;
        else
            Debug.Log("WoodCount is null");
    }
}
