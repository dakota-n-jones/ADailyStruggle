using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Static : MonoBehaviour
{

    [SerializeField] Clicker m_motivation = null;

    AudioSource m_audioSource = null;

    private void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float total = Mathf.Clamp(1.0f - (m_motivation.Total/100.0f) - 0.2f, 0.0f, 1.0f);
        m_audioSource.volume = total;
    }
}
