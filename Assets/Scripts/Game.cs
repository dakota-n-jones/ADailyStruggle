using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

    [SerializeField] GameObject m_winScreen = null;
    [SerializeField] GameObject m_pauseMenu = null;
    [SerializeField] GameObject m_lossScreen = null;
    [SerializeField] DecreasableSlider m_willToLive = null;
    RecoverySteps[] m_upgrades = null;
    private bool m_won = false;
    private bool loadPause = true;

    private void Start()
    {
        m_upgrades = FindObjectsOfType<RecoverySteps>();
    }

    // Update is called once per frame
    void Update () {

        if(m_willToLive.Total <= 0)
        {
            m_lossScreen.SetActive(true);
            Time.timeScale = 0.0f;
        } else
        {
            m_won = true;
            for (int i = 0; i < m_upgrades.Length; i++)
            {
                if(!m_upgrades[i].m_activated)
                {
                    m_won = false;
                }
            }

            if(m_won)
            {
                m_winScreen.SetActive(true);
                Time.timeScale = 0.0f;
            }

            if(Input.GetButtonDown("Cancel") && !m_won && loadPause)
            {
                m_pauseMenu.SetActive(true);
                loadPause = false;
                Time.timeScale = 0.0f;
            }
            else if (Input.GetButtonDown("Cancel") && !loadPause && !m_won)
            {
                Unpause();
            }
        }

    }

    public void Unpause()
    {
        m_pauseMenu.SetActive(false);
        if(Tutorial.Done)
        {
            Time.timeScale = 1.0f;
        }
        loadPause = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
