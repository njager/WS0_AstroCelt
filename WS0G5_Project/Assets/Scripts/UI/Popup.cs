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
    public static Popup Create(Vector3 position, int outputAmount, int colorIndex)
    {
        Transform instantiatePopupTransform = GrabPopupTransform();
        Transform popupTransform = Instantiate(instantiatePopupTransform, position, Quaternion.identity);
        Popup popup = popupTransform.GetComponent<Popup>();
        popup.Setup(outputAmount, colorIndex);

        return popup;
    }
    
    //get the transform component of the text
    private void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
    }

    //make the output amount into the text for the popup
    public void Setup(int outputAmount, int colorIndex)
    {
        textMesh.SetText(outputAmount.ToString());
        if (colorIndex == 0)
        {
            //textMesh.fontSize = 36;
            textColor = UtilsClass.GetColorFromString("5ECC71");
            isRed = false;
            isGreen = true;
            isBlue = false;
        }
        else if (colorIndex == 1)
        {
            textColor = UtilsClass.GetColorFromString("DD6666");
            //textMesh.fontSize = 36;
            isRed = true;
            isGreen = false;
            isBlue = false;
        }
        textMesh.color = textColor;
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

        
        //delay disappear for popup
        disappearTimer -= Time.deltaTime;
        if(disappearTimer < 0)
        {
            //float disappearSpeed = 3f;
            //textColor.a -= disappearSpeed * Time.deltaTime;
            //textMesh.color = textColor;
            textMesh.DOFade(0f, 1f);
            destroyTimer -= Time.deltaTime;
            if (destroyTimer < 0)
            {
                Destroy(gameObject);
            }


            /*if (textColor.a < 0)
            {
                Destroy(gameObject);
            }*/
        }
    }

    /* //this is an obsolete function replaced by coroutine
    public void MoveToBar()
    {
        gameObject.transform.DOMove(enemyHealthPos, 2f);
    }*/

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

        if (isGreen)
        {
            textMesh.DOColor(UtilsClass.GetColorFromString("5ECC71"), 0.2f);
        }
        else if (isRed)
        {
            textMesh.DOColor(UtilsClass.GetColorFromString("DD6666"), 0.2f);
        }


        yield return new WaitForSeconds(1);

        if (isRed)
        {
            gameObject.transform.DOMove(enemyHealthPos, 2f);
        }
        else if (isGreen)
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
