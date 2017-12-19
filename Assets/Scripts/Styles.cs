using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Styles : DualBehaviour
{
    #region Public Members

    #endregion
    #region Public void
    #endregion
    #region System

    void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}

    #endregion
    #region Tools Debug and Utility

    #endregion
    #region Class Methods
    public static GUIStyle DesignTitle()
    {
        GUIStyle m_titleStyle = new GUIStyle();
        m_titleStyle.fontStyle = FontStyle.Bold;
        m_titleStyle.normal.textColor = Color.blue;
        m_titleStyle.alignment = TextAnchor.MiddleCenter;
        return m_titleStyle;
    }
    #endregion
    #region Private and Protected Members
    #endregion
}
