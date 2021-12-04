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
        global.popup.Create(new Vector3(0, 0, 0), 20, 1, false);
        
    }
}
