using UnityEngine;
using System.Collections;

public class BaseEvent {
	GameObject m_targetObject;

	public GameObject EventObject
	{
		get{return m_targetObject;}
	}

	public BaseEvent(GameObject target)
	{
		m_targetObject = target;
	}

	public void PerformEvent()
	{
		
	}
}

public class TextEvent : BaseEvent {
	private string m_strGUIText = "";

	public string strGUIText
	{
		get{return m_strGUIText;}
	}

	public TextEvent(GameObject target, string text) : base(target)
	{
		m_strGUIText = text;
	}

	public new void PerformEvent()
	{
	}
}
