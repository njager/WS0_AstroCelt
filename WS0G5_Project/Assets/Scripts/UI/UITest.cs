using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UITest : MonoBehaviour
{
    //public variables


    //private variables
    [Header("Variables")]
    [SerializeField] int enemyCount;
    [SerializeField] float timer;
    [SerializeField] int ceCount;
    [SerializeField] int playerHealth;
    [SerializeField] int enemyHealth;

    //UI variables
    [Header("UI Element Slots")]
    [SerializeField] TextMeshProUGUI ceCountText;
    [SerializeField] TextMeshProUGUI enemyCountText;
    [SerializeField] TextMeshProUGUI playerHealthText;
    [SerializeField] TextMeshProUGUI enemyHealthText;
    [SerializeField] TextMeshProUGUI timerText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
