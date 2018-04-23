using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSpawner : MonoBehaviour
{
    [SerializeField] TextFader[] m_messages;
    [SerializeField] Clicker m_motivation = null;

    private float m_spawnRate = 0.0f;
    private float m_spawnIncrement = 1.0f;

    // Update is called once per frame
    void Update()
    {
        float spawn = 10 - (int)(m_motivation.Total / 10) - 4;

        m_spawnRate = 0.0f;
        for (int i = 0; i < spawn; i++)
        {
            m_spawnRate += m_spawnIncrement;
        }

        for (int i = 0; i < m_spawnRate; i++)
        {
            int rnd = Random.Range(0, m_messages.Length);
            m_messages[rnd].FadeIn();
        }
    }
}
