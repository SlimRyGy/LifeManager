using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LifeManager))]
public class LifeEditor : Editor 
{
    GUIStyle m_labelStyle           = new GUIStyle();
    GUIStyle m_rezButtonStyle       = new GUIStyle();
    GUIStyle m_dieButtonStyle       = new GUIStyle();
    GUIStyle m_damageButtonStyle    = new GUIStyle(); 
   
    

    public override void OnInspectorGUI()
    {
        Style();

        LifeManager m_myLifeManager = (LifeManager)target;

        DrawDefaultInspector();

        m_myLifeManager.Life = (int) EditorGUILayout.Slider(m_myLifeManager.Life, 0, m_myLifeManager.MaxLife);

        GUILayout.Label("");
        GUILayout.BeginHorizontal();

        GUILayout.Label("Interact with life :", m_labelStyle);
        if (GUILayout.Button("Damage it", m_damageButtonStyle))
        {
            if (m_myLifeManager.Life > 0)
            {
                m_myLifeManager.Life -= 20;
            }
        }
        if (GUILayout.Button("Kill it", m_dieButtonStyle))
        {
            m_myLifeManager.Life = 0;
        }
        if (GUILayout.Button("Resurect it", m_rezButtonStyle))
        {     
            m_myLifeManager.Life = m_myLifeManager.m_maxLife;
        }
        GUILayout.EndHorizontal();
        GUILayout.Label("");
    }
    #region Class Methods

    private void Style()
    {
        m_labelStyle.fontStyle          = FontStyle.Bold;
        m_labelStyle.normal.textColor   = Color.blue;
        m_labelStyle.padding.left       = 25;

        m_damageButtonStyle.normal.textColor    = Color.grey;
        m_dieButtonStyle.normal.textColor       = Color.red;
        m_rezButtonStyle.normal.textColor       = Color.green;

        m_damageButtonStyle.padding.left    = 10;
        m_dieButtonStyle.padding.left       = 10;
        m_rezButtonStyle.padding.left       = 10;
    }

    #endregion

}