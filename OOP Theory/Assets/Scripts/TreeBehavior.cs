using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TreeBehavior : MonoBehaviour
{
    public float treeHealth = 100.0f;
    public int woodQuantity = 10;
    protected bool isHarvestable = false; // ENCAPSULATION
    public TextMeshProUGUI woodText;
    public GameManager gameManager;

    void Awake() {
        woodText = GameObject.Find("WoodCount").GetComponent<TextMeshProUGUI>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if(treeHealth <= 0) {
            isHarvestable = true;
        }
    }

    public void Harvest() { // ToDo: Pass in a tool type to alter the factor speed and quantities.
        // Decrement the Tree Health
        treeHealth -= 0.05f;

        if(isHarvestable) {
            Destroy(gameObject);
            DataManager.Instance.wood += woodQuantity;
            gameManager.UpdateUI(DataManager.Instance.wood);
        }
    }
}

