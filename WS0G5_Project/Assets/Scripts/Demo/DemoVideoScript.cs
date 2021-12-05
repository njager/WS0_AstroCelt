using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class DemoVideoScript : MonoBehaviour
{
    //[SerializeField] GameObject attackPulse;
    //[SerializeField] GameObject selectIcon;
    private GlobalController global;
    [SerializeField] GameObject bigDipper;

    private void Awake()
    {
        global = GlobalController.instance; 
    }

    private void Start()
    {
        bigDipper.SetActive(false);
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
        bigDipper.SetActive(true);
        Vector3 _popupVector3 = new Vector3(0, 0, 0);
        global.enemy1.EnemyDamaged(20);
        global.popup.Create(_popupVector3, 20, 1, false);
        StartCoroutine("FlashDipper");
        global.particleSystemScript.DemoParticleEffect();
    }

    IEnumerator FlashDipper()
    {
        //punch the position for shake and scale
        bigDipper.transform.DOShakePosition(1f, 0.3f, 10, 10f);
        bigDipper.transform.DOScale(new Vector3(1.5f, 1.5f, 0), 0.2f);

        yield return new WaitForSeconds(0.25f);

        bigDipper.transform.DOScale(new Vector3(1, 1, 0), .2f);

        yield return new WaitForSeconds(2f);

        bigDipper.SetActive(false);
    }
}
