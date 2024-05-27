using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TipUIController : MonoBehaviour
{
    public float visibleTime = 4.5f;
    public TextMeshProUGUI inputtext;

    public void ShowTip(string tipKey) {
        inputtext.text = GameManager.ScriptManager.GetSubtitleText(tipKey);
        Invoke("HideTip", visibleTime);
    }

    void HideTip() {
        inputtext.text = "";
    }

    void Start() {
        HideTip();
    }
}
