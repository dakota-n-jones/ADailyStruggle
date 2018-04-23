using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayItemInfo : MonoBehaviour {

	[HideInInspector] public string m_displayName = "";
	[HideInInspector] public string m_displayDesc = "";

	private const string m_name = "";
	private const string m_desc = "\n";
	[SerializeField] TextMeshProUGUI m_text = null;

	void Start () {
		//m_text = GetComponentInChildren<TextMeshProUGUI>();
		TextUpdate();
	}
	
	public void TextUpdate()
	{
		m_text.SetText(m_name + m_displayName + m_desc + m_displayDesc);
	}
}
