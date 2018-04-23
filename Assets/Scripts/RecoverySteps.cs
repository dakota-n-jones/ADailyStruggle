using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class RecoverySteps : MonoBehaviour {

    [SerializeField] DecreasableSlider m_energy = null;
    [SerializeField] Clicker m_motivation = null;
    [SerializeField] Effort m_effort = null;
    [SerializeField] [Range(0.0f, 10.0f)] float m_motivationGain = 1.0f;
    [SerializeField] [Range(0.0f, 10.0f)] float m_energyGain = 1.0f;
    public float m_cost = 20.0f;
    public bool m_activated = false;

    private void Update()
    {
        if(m_activated)
        {
            m_energy.Total += m_energyGain * Time.deltaTime;
            m_motivation.Total += m_motivationGain * Time.deltaTime;
        }
    }

    public void Buy()
    {
        if(m_effort.SpendEffort(m_cost))
        {
            m_activated = true;
            GetComponent<Button>().interactable = false;
        }
    }
}
