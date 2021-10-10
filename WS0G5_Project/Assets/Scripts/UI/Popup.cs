using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    private GlobalController global;
    private TextMeshPro textMesh;
    public static GameObject pfPopupStatic;
    public GameObject pfPopup;

    static Transform GrabPopupTransform()
    {
        Transform pfPopupTransform = pfPopupStatic.GetComponent<Transform>();

        return pfPopupTransform;
    }

    private void Start()
    {
        pfPopupStatic = pfPopup;
        global = GlobalController.instance;
    }

    public static Popup Create(Vector3 position, int outputAmount)
    {
        Transform instantiatePopupTransform = GrabPopupTransform();
        Transform popupTransform = Instantiate(instantiatePopupTransform, Vector3.zero, Quaternion.identity);
        Popup popup = popupTransform.GetComponent<Popup>();
        popup.Setup(outputAmount);

        return popup;
    }
    

    private void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
    }
    public void Setup(int outputAmount)
    {
        textMesh.SetText(outputAmount.ToString());
    }
}
