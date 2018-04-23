using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextFader : MonoBehaviour {

    [SerializeField] [Range(0.0f, 10.0f)] float m_time = 2.0f;
    [SerializeField] TextMeshProUGUI m_text = null;
    

    private void Awake()
    {
        m_text.color = new Color(m_text.color.r, m_text.color.g, m_text.color.b, 0);
    }

    private void Update()
    {
    }

    public void FadeIn()
    {
        StartCoroutine(FadeTextToFullAlpha(m_time));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeTextToZeroAlpha(m_time));
    }

    public IEnumerator FadeTextToFullAlpha(float t)
    {
        m_text.color = new Color(m_text.color.r, m_text.color.g, m_text.color.b, 0);
        while (m_text.color.a < 1.0f)
        {
            m_text.color = new Color(m_text.color.r, m_text.color.g, m_text.color.b, m_text.color.a + (Time.deltaTime / t));
            yield return null;
        }
        StartCoroutine(FadeTextToZeroAlpha(t));
    }

    public IEnumerator FadeTextToZeroAlpha(float t)
    {
        m_text.color = new Color(m_text.color.r, m_text.color.g, m_text.color.b, 1);
        while (m_text.color.a > 0.0f)
        {
            m_text.color = new Color(m_text.color.r, m_text.color.g, m_text.color.b, m_text.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
