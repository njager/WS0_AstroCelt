using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoVideoScript : MonoBehaviour
{
    [SerializeField] GameObject attackPulse;
    [SerializeField] GameObject selectIcon;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
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
        }
    }
}
