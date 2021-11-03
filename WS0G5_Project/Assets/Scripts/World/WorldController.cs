using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class WorldController : MonoBehaviour
{
    public static WorldController instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Somehow more than one WorldController in scene!");
        }

        instance = this;

        DontDestroyOnLoad(this.gameObject);
        StartingValues();
    }

    [Header("Overworld UI")]
    public int overWorldCEAmount;
    public int overWorldTreeHealth;
    public int overWorldAltarCurrency; 

    [Header("Public Stats")]
    public int overWorldVitality;
    public int constellationLimitModifier;
    public int altarSiphonUpgrade;
    public int altarHorizonShiftUpgrade;

    public int levelsCleared = 0;

    void StartingValues()
    {
       overWorldVitality = 0;
       constellationLimitModifier = 0;
       altarSiphonUpgrade = 0;
       altarHorizonShiftUpgrade = 0;
}

    public void changeToLevelScene(string _sceneName)
    {
        {
            SceneManager.LoadSceneAsync(_sceneName);
        }
    }
}
