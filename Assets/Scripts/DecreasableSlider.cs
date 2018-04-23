using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DecreasableSlider : MonoBehaviour {

    [SerializeField] Slider m_slider = null;
    [SerializeField] TextMeshProUGUI m_textTotal = null;
    [SerializeField] [Range(1.0f, 50.0f)] float m_value = 5.0f;
    public bool m_naturalDecrease = false;
    public bool m_naturalIncrease = false;

    public float Total { get; set; }

    private void Start()
    {
        m_slider.maxValue = 100.0f;
        m_slider.minValue = 0.0f;
        m_slider.value = 100.0f;
        m_textTotal.text = "" + 100.0f;
        Total = 100.0f;
    }

    private void Update()
    {
        if (m_naturalDecrease)
        {
            Total -= m_value * Time.deltaTime;
        }
        if(m_naturalIncrease)
        {
            Total += m_value * Time.deltaTime;
        }
        UpdateValue();
    }

    public void UpdateValue()
    {
        Total = Mathf.Clamp(Total, 0, 100);
        m_slider.value = Total;
        int total = (int)Total;
        m_textTotal.text = "" + total;
    }

    public void DecreaseValue()
    {
        Total -= m_value;
        UpdateValue();
    }
}
