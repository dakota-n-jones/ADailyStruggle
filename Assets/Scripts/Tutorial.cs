using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {

    [SerializeField] GameObject[] m_pages = null;
    [SerializeField] Button m_struggle = null;
    [SerializeField] GameObject m_nextButton = null;
    [SerializeField] GameObject m_image = null;
    public static bool Done = false;
    int currentPage = 0;

    private void Awake()
    {
        Time.timeScale = 0.0f;
        Done = false;
    }

    private void Start()
    {
        m_struggle.interactable = false;
    }

    public void NextPage()
    {
        m_pages[currentPage].SetActive(false);
        currentPage++;
        if(currentPage < m_pages.Length)
        {
            m_pages[currentPage].SetActive(true);
        }
        if(currentPage == m_pages.Length)
        {
            Time.timeScale = 1.0f;
            m_struggle.interactable = true;
            m_nextButton.SetActive(false);
            m_image.SetActive(false);
            DisplayItem.CanDisplay = true;
            Done = true;
        }
    }
}
