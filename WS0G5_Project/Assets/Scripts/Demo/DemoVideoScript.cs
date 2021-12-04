using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DemoVideoScript : MonoBehaviour
{
    //[SerializeField] GameObject attackPulse;
    //[SerializeField] GameObject selectIcon;
    [SerializeField] GlobalController global;
    [SerializeField] GameObject bigDipper;
    Vector3 dipperPos;  

    private void Start()
    {
        bigDipper.SetActive(false);
        dipperPos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.R))
        {
            attackPulse.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            attackPulse.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            selectIcon.SetActive(true);
        }*/

        if (Input.GetKeyDown(KeyCode.M))
        {
            bigDipper.SetActive(true);
        }

    }

    public void AbilityButton()
    {
        global.enemy1.EnemyDamaged(20);
        global.popup.Create(dipperPos, 20, 1, false);
        
    }
}
