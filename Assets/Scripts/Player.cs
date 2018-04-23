using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Player : MonoBehaviour {

    [SerializeField] Clicker m_motivation = null;
    [SerializeField] Sprite m_one = null;
    [SerializeField] Sprite m_two = null;
    [SerializeField] Sprite m_three = null;
    [SerializeField] Sprite m_four = null;

    SpriteRenderer m_renderer = null;

    private void Start()
    {
        m_renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update () {
        int total = (int)m_motivation.Total;

        if(total >= 75)
        {
            m_renderer.sprite = m_one;
        } else if(total >= 50)
        {
            m_renderer.sprite = m_two;
        } else if(total >= 25)
        {
            m_renderer.sprite = m_three;
        } else if(total >= 0)
        {
            m_renderer.sprite = m_four;
        }
	}
}