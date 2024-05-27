using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningSignController : MonoBehaviour
{
    [SerializeField] GameObject warningSign;
    public float repeatTime = 0.3f;

    void OnBlink() {
        warningSign.SetActive(!warningSign.activeInHierarchy);
    }

    // Turn on Warning Msg
    void OnEnable() {
        warningSign.SetActive(true);
        InvokeRepeating("OnBlink", repeatTime, repeatTime);
    }

    // Turn off Warning Msg
    void OnDisable() {
        warningSign.SetActive(false);
        CancelInvoke("OnBlink");
    }

    
}
