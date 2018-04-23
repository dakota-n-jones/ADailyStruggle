using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfCare : MonoBehaviour {

    [SerializeField] DecreasableSlider m_energy = null;
    [SerializeField] Effort m_effort = null;

	public void UseASelfCareItem(float gain)
    {
        if(m_effort.SpendEffort(gain))
        {
            m_energy.Total += gain / 2;
        }
    }
}
