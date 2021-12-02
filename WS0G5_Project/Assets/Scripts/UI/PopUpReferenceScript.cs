using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using CodeMonkey.Utils;
using DG.Tweening;

public class PopUpReferenceScript : MonoBehaviour
{
    public Transform popUpHolder;
    public GameObject popUpPrefab;
    private GlobalController global;
    [SerializeField] Vector3 enemyHealthPos;
    [SerializeField] Vector3 playerHealthPos;

    private void Start()
    {
        global = GlobalController.instance;
        DOTween.Init();
        enemyHealthPos = new Vector3(14, -0.35f, 0);
        playerHealthPos = new Vector3(-14, 2.35f, 0);
    }

    //grab the transform of the OG popup
    public Transform GrabPopupTransform()
    {
        Transform pfPopupTransform = popUpHolder;
        return pfPopupTransform;
    }

    //create the popup at position with certain #
    public void Create(Vector3 position, int outputAmount, int colorIndex, bool toPlayer)
    {
        Transform instantiatePopupTransform = GrabPopupTransform();
        GameObject popupTransform = Instantiate(popUpPrefab, instantiatePopupTransform.position, Quaternion.identity);
        Popup popup = popupTransform.GetComponent<Popup>();
        Setup(outputAmount, colorIndex, toPlayer, popup);

        return;
    }

    public void Setup(int outputAmount, int colorIndex, bool toPlayer, Popup _pop)
    {
        _pop.textMesh.SetText(outputAmount.ToString());

        //check and set color
        if (colorIndex == 0)
        {
            _pop.textColor = UtilsClass.GetColorFromString("5ECC71");
            _pop.isRed = false;
            _pop.isGreen = true;
            _pop.isBlue = false;
        }
        else if (colorIndex == 1)
        {
            _pop.textColor = UtilsClass.GetColorFromString("DD6666");
            _pop.isRed = true;
            _pop.isGreen = false;
            _pop.isBlue = false;
        }
        else if (colorIndex == 2)
        {
            _pop.textColor = UtilsClass.GetColorFromString("7598D1");
            _pop.isRed = false;
            _pop.isGreen = false;
            _pop.isBlue = true;
        }
        _pop.textMesh.color = _pop.textColor;

        //check and set bool for to player or to enemy
        if (toPlayer)
        {
            _pop.sendToPlayer = true;
        }
        else
        {
            _pop.sendToPlayer = false;
        }

        _pop.disappearTimer = _pop.DISAPPEAR_TIMER_MAX;

        //put newer popups on top
        _pop.sortingOrder++;
        _pop.textMesh.sortingOrder = _pop.sortingOrder;

        //reset the scale after tweening it in spawn
        _pop.transform.DOScale(new Vector3(1, 1, 0), 0.01f);
    }

}
