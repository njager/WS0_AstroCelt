using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    //private variables
    private GlobalController global;
    private TextMeshPro textMesh;
    private float disappearTimer;
    private Color textColor;

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
    }

    //create the popup at position with certain #
    public static Popup Create(Vector3 position, int outputAmount)
    {
        Transform instantiatePopupTransform = GrabPopupTransform();
        Transform popupTransform = Instantiate(instantiatePopupTransform, position, Quaternion.identity);
        Popup popup = popupTransform.GetComponent<Popup>();
        popup.Setup(outputAmount);

        return popup;
    }
    
    //get the transform component of the text
    private void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
    }

    //make the output amount into the text for the popup
    public void Setup(int outputAmount)
    {
        textMesh.SetText(outputAmount.ToString());
        textColor = textMesh.color;
        disappearTimer = 1f;
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

        disappearTimer -= Time.deltaTime;
        if(disappearTimer < 0)
        {
            float disappearSpeed = 3f;
            textColor.a -= disappearSpeed * Time.deltaTime;
            //textMesh.color = textColor;
            
            if (textColor.a < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
