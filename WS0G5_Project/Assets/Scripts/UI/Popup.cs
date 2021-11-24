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
    private float destroyTimer = 1f;
    private Color textColor;
    private const float DISAPPEAR_TIMER_MAX = 3f;
    private static int sortingOrder;
    [SerializeField] Vector3 enemyHealthPos;
    [SerializeField] Vector3 playerHealthPos;
    private bool isRed;
    private bool isGreen;
    private bool isBlue;
    private bool sendToPlayer;

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
        enemyHealthPos = new Vector3(21, 5, 0);
        playerHealthPos = new Vector3(-21, 5, 0);
    }

    //create the popup at position with certain #
    public static Popup Create(Vector3 position, int outputAmount, int colorIndex, bool toPlayer)
    {
        Transform instantiatePopupTransform = GrabPopupTransform();
        Transform popupTransform = Instantiate(instantiatePopupTransform, position, Quaternion.identity);
        Popup popup = popupTransform.GetComponent<Popup>();
        popup.Setup(outputAmount, colorIndex, toPlayer);

        return popup;
    }
    
    //get the transform component of the text
    private void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
    }

    //make the output amount into the text for the popup
    public void Setup(int outputAmount, int colorIndex, bool toPlayer)
    {
        textMesh.SetText(outputAmount.ToString());

        //check and set color
        if (colorIndex == 0)
        {
            textColor = UtilsClass.GetColorFromString("5ECC71");
            isRed = false;
            isGreen = true;
            isBlue = false;
        }
        else if (colorIndex == 1)
        {
            textColor = UtilsClass.GetColorFromString("DD6666");
            isRed = true;
            isGreen = false;
            isBlue = false;
        }
        else if (colorIndex == 2)
        {
            textColor = UtilsClass.GetColorFromString("7598D1");
            isRed = false;
            isGreen = false;
            isBlue = true;
        }
        textMesh.color = textColor;

        //check and set bool for to player or to enemy
        if (toPlayer)
        {
            sendToPlayer = true;
        }
        else
        {
            sendToPlayer = false;
        }

        disappearTimer = DISAPPEAR_TIMER_MAX;

        //put newer popups on top
        sortingOrder++;
        textMesh.sortingOrder = sortingOrder;

        //add a box collider because it auto deletes when spawned
        gameObject.AddComponent<BoxCollider>();

        //reset the scale after tweening it in spawn
        gameObject.transform.DOScale(new Vector3(1, 1, 0), 0.01f);
    }

    private void Update()
    {
        //float moveYSpeed = 20f;
        if (transform.parent != null && transform.parent.tag != "Reference")
        {
            Debug.Log("Has a parent is not reference");
        }
        if (transform.parent != null && transform.parent.tag == "Reference")
        {
            Debug.Log("Has a parent is reference");
        }
        
        //delay disappear for popup
        disappearTimer -= Time.deltaTime;
        if(disappearTimer < 0)
        {
            textMesh.DOFade(0f, 1f);
            destroyTimer -= Time.deltaTime;
            if (destroyTimer < 0)
            {
                Destroy(gameObject);
            }
        }
    }

    //wait then move popup to enemy health bar, with other punchy effects
    IEnumerator MovePopup()
    {
        //punch the position for shake and scale
        gameObject.transform.DOShakePosition(1f, 0.3f, 10, 10f);
        gameObject.transform.DOScale(new Vector3(1.5f, 1.5f, 0), 0.2f);

        //flash color then reset
        textMesh.DOColor(UtilsClass.GetColorFromString("FFFFFF"), 0.2f);

        yield return new WaitForSeconds(0.25f);

        gameObject.transform.DOScale(new Vector3(1, 1, 0), .2f);

        //check what color to return it to after flashing white
        if (isGreen)
        {
            textMesh.DOColor(UtilsClass.GetColorFromString("5ECC71"), 0.2f);
        }
        if (isRed)
        {
            textMesh.DOColor(UtilsClass.GetColorFromString("DD6666"), 0.2f);
        }
        if (isBlue)
        {
            textMesh.DOColor(UtilsClass.GetColorFromString("7598D1"), 0.2f);
        }

        yield return new WaitForSeconds(1);

        //move to enemy if if red and move to player if green or blue
        if (!sendToPlayer)
        {
            gameObject.transform.DOMove(enemyHealthPos, 2f);
        }
        else if (sendToPlayer)
        {
            gameObject.transform.DOMove(playerHealthPos, 2f);
        }
        
    }

    //if the popup enters the screen, move it
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Popup entered the screen!");
        StartCoroutine("MovePopup");
    }
}
