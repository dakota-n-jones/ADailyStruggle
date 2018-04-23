using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayItem : MonoBehaviour {

	[SerializeField] GameObject m_infoDisplayPrefab = null;
	[SerializeField] GameObject m_displaysParent = null;
	[SerializeField] DisplayItemInfo m_infoDisplay;
    [SerializeField] GameObject m_infoDisplayObject = null;
    [SerializeField] string m_desc = "";
	public int xOffset = 150;
	public int yOffset = -140;
    public static bool CanDisplay = false;
	public DisplayItemInfo infoDisplay { get { return m_infoDisplay; } }

	private void Awake()
	{
        m_infoDisplayObject = Instantiate(m_infoDisplayPrefab, m_displaysParent.transform, false);
        m_infoDisplay = m_infoDisplayObject.GetComponent<DisplayItemInfo>();

        UpdateItem();
		m_infoDisplayObject.SetActive(false);
	}

    private void Start()
    {
        m_infoDisplayObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        m_infoDisplayObject.transform.localPosition = new Vector3(xOffset, yOffset, 0); 
    }

    public void UpdateItem()
	{
        m_infoDisplay.m_displayDesc = m_desc;
        m_infoDisplay.m_displayName = gameObject.name;
		m_infoDisplay.TextUpdate();
	}

	public void DisplayInfo()
	{
        if(CanDisplay)
        {
		    //print("mouse enter");
		    m_infoDisplayObject.SetActive(true);
            Time.timeScale = 0.0f;
        }
	}

	public void CloseInfo()
	{
        if(CanDisplay)
        {
		    //print("mouse exit");
		    if(m_infoDisplay.isActiveAndEnabled)
		    {
			    m_infoDisplayObject.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }
	}


}
