using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clicker : MonoBehaviour {

    [SerializeField] Slider m_slider = null;
    [SerializeField] TextMeshProUGUI m_textTotal = null;
    [SerializeField] [Range(1.0f, 50.0f)] float m_value = 5.0f;
    [SerializeField] [Range(1.0f, 50.0f)] float m_valueToDecrease = 6.0f;
    [SerializeField] DecreasableSlider m_energy = null;
    [SerializeField] DecreasableSlider m_will = null;

    public float Total { get; set; }

    private void Start()
    {
        m_slider.maxValue = 100.0f;
        m_slider.minValue = 0.0f;
        m_slider.value = 100.0f;
        m_textTotal.text = "" + 100.0f;
        Total = 100.0f;
    }

    public void AddClick()
    {
        if (m_energy && m_energy.Total > 1)
        {
            Total += m_value;
            UpdateTotal();
        }
    }

    private void Update()
    {
        if(Time.timeScale != 0.0f)
        {
            Total -= m_valueToDecrease * Time.deltaTime;
            UpdateTotal();
            if(Total < 20)
            {
                m_will.m_naturalDecrease = true;
            } else if (m_will.m_naturalDecrease && Total >= 10)
            {
                m_will.m_naturalDecrease = false;
            }
            if(Total >= 90)
            {
                m_will.m_naturalIncrease = true;
            } else if(m_will.m_naturalIncrease && Total < 90)
            {
                m_will.m_naturalIncrease = false;
            }
        }
    }

    private void UpdateTotal()
    {
        Total = Mathf.Clamp(Total, 0, 100);
        m_slider.value = Total;
        int total = (int)Total;
        m_textTotal.text = "" + total;
    }
}
