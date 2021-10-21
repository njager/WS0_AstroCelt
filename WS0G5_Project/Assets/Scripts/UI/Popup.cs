using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using CodeMonkey.Utils;
using DG.Tweening;

public class Popup : MonoBehaviour
{
    //private variables
    private GlobalController global;
    private TextMeshPro textMesh;
    private float disappearTimer;
    private Color textColor;
    private const float DISAPPEAR_TIMER_MAX = 1f;
    private static int sortingOrder;

    //public variables
    public static GameObject pfPopupStatic;
    public GameObject pfPopup;

    //grab the transform of the OG popup
    static Transform GrabPopupTransform()
    {
        Transform pfPopupTransform = pfPopupStatic.GetComponent<Transform>();

        return pfPopupTransform;
    }

    //setup the popup
    private void Start()
    {
        pfPopupStatic = pfPopup;
        global = GlobalController.instance;
        DOTween.Init();
    }

    //create the popup at position with certain #
    public static Popup Create(Vector3 position, int outputAmount, bool isDamage)
    {
        Transform instantiatePopupTransform = GrabPopupTransform();
        Transform popupTransform = Instantiate(instantiatePopupTransform, position, Quaternion.identity);
        Popup popup = popupTransform.GetComponent<Popup>();
        popup.Setup(outputAmount, isDamage);

        return popup;
    }
    
    //get the transform component of the text
    private void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
    }

    //make the output amount into the text for the popup
    public void Setup(int outputAmount, bool isDamage)
    {
        textMesh.SetText(outputAmount.ToString());
        if (!isDamage)
        {
            //textMesh.fontSize = 36;
            textColor = UtilsClass.GetColorFromString("5ECC71");
        }
        else
        {
            textColor = UtilsClass.GetColorFromString("DD6666");
            //textMesh.fontSize = 36;
        }
        textMesh.color = textColor;
        disappearTimer = DISAPPEAR_TIMER_MAX;

        sortingOrder++;
        textMesh.sortingOrder = sortingOrder;
    }

    private void Update()
    {
        //float moveYSpeed = 20f;
        //transform.position += new Vector3(0, moveYSpeed) * Time.deltaTime;
        if (transform.parent != null && transform.parent.tag != "Reference")
        {
            Debug.Log("Has a parent is not reference");
        }
        if (transform.parent != null && transform.parent.tag == "Reference")
        {
            Debug.Log("Has a parent is reference");
        }

        /*if (disappearTimer > DISAPPEAR_TIMER_MAX * .5f)
        {
            //first half of popup lifetime
            float increaseScaleAmount = 1f;
            transform.localScale += Vector3.one * increaseScaleAmount * Time.deltaTime;
        }
        else
        {
            float decreaseScaleAmount = 1f;
            transform.localScale -= Vector3.one * decreaseScaleAmount * Time.deltaTime;
        }*/

        disappearTimer -= Time.deltaTime;
        if(disappearTimer < 0)
        {
            float disappearSpeed = 3f;
            textColor.a -= disappearSpeed * Time.deltaTime;
            //textMesh.color = textColor;
            textMesh.DOFade(0f, 2f);
            
            if (textColor.a < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
