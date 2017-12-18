using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LifeManager))]
public class LifeEditor : Editor 
{
    GUIStyle m_labelStyle = new GUIStyle();
    GUIStyle m_rezButtonStyle = new GUIStyle();
    GUIStyle m_dieButtonStyle = new GUIStyle();

    public override void OnInspectorGUI()
    {
        m_labelStyle.alignment              = TextAnchor.MiddleCenter;
        m_labelStyle.fontStyle              = FontStyle.Bold;
        m_labelStyle.normal.textColor       = Color.blue;

        m_dieButtonStyle.normal.textColor   = Color.red;
        m_rezButtonStyle.normal.textColor   = Color.green;
        m_dieButtonStyle.alignment          = TextAnchor.MiddleLeft;
        m_rezButtonStyle.alignment          = TextAnchor.MiddleRight;
        m_dieButtonStyle.padding.left       = 170;
        m_rezButtonStyle.padding.right      = 170;

        LifeManager m_myLifeManager = (LifeManager)target;

        DrawDefaultInspector();

        GUILayout.Label("");
        GUILayout.Label("Interact with life", m_labelStyle);

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Kill it", m_dieButtonStyle))
        {
            Debug.Log("Kill it");
            m_myLifeManager.Life = 0f;
        }
        if (GUILayout.Button("Resurection", m_rezButtonStyle))
        {
            Debug.Log("Resurection");
            m_myLifeManager.Life = 1f;
        }
        GUILayout.EndHorizontal();
        GUILayout.Label("");

    }
}
