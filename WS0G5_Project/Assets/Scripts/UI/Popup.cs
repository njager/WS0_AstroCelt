using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    public static Popup Create()
    {
        Transform popupTransform = Instantiate(pfPopup, Vector3.zero, Quaternion.identity);
        Popup popup = popupTransform.GetComponent<Popup>();
    }
    private TextMeshPro textMesh;

    private void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
    }
    public void Setup(int amount)
    {
        textMesh.SetText(amount.ToString());
    }
}
