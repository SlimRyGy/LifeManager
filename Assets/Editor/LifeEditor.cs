using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LifeManager))]
public class LifeEditor : Editor 
{
    GUIStyle m_labelStyle       = new GUIStyle();
    GUIStyle m_rezButtonStyle   = new GUIStyle();
    GUIStyle m_dieButtonStyle   = new GUIStyle();
   
    public override void OnInspectorGUI()
    {
        m_labelStyle.fontStyle              = FontStyle.Bold;
        m_labelStyle.normal.textColor       = Color.blue;
        m_labelStyle.padding.left           = 25;

        m_dieButtonStyle.normal.textColor   = Color.red;
        m_rezButtonStyle.normal.textColor   = Color.green;
        m_dieButtonStyle.padding.left       = 10;
        m_rezButtonStyle.padding.left       = 10;

        LifeManager m_myLifeManager = (LifeManager)target;

        DrawDefaultInspector();

        GUILayout.Label("");
       
        GUILayout.BeginHorizontal();

        GUILayout.Label("Interact with life :", m_labelStyle);

        if (GUILayout.Button("Kill it", m_dieButtonStyle))
        {
            if (m_myLifeManager.m_useDebugLog)
            {
                Debug.Log("Kill it");
            } 
            m_myLifeManager.Life = 0f;
        }
        if (GUILayout.Button("Resurection", m_rezButtonStyle))
        {
            if (m_myLifeManager.m_useDebugLog)
            {
                Debug.Log("Resurection");
            }     
            m_myLifeManager.Life = 1f;
            m_myLifeManager.m_onRez.Invoke();
        }
        GUILayout.EndHorizontal();
        GUILayout.Label("");

    }
}
