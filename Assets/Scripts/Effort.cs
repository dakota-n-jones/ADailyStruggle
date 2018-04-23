using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Effort : MonoBehaviour {

    [SerializeField] TextMeshProUGUI m_textValue = null;

    public float Total { get; set; }

    public void BuildEffort()
    {
        Total += 10.0f;
        m_textValue.text = "" + Total;
    }
    public bool SpendEffort(float cost)
    {
        bool succeeded = false;
        if(Total >= cost)
        {
            succeeded = true;
            Total -= cost;
            Total = Mathf.Clamp(Total, 0, Mathf.Infinity);
            m_textValue.text = "" + Total;
        }
        return succeeded;
    }
}
