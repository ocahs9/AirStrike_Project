using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UISelect : MonoBehaviour
{
    public string descriptionKey;
    public UnityEvent onSelectEvent;
    
    public string DescriptionKey
    {
        get { return descriptionKey; }
    }

    public UnityEvent OnSelectEvent
    {
        get { return onSelectEvent; }
    }
}
