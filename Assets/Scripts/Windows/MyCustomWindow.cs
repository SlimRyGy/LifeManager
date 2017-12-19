using UnityEditor;
using UnityEngine;

public class MyCustomWindow : EditorWindow
{
    #region Public Members
    public GameObject[] m_rer = GameObject.FindGameObjectsWithTag("Enemy");
    #endregion
    #region Public Void
    // Add menu item named "My Window" to the Window menu
    [MenuItem("Window/My Custom Window")]
    public static void ShowWindow()
    {
        //Show existing window instance. If one doesn't exist, make one.
        EditorWindow.GetWindow(typeof(MyCustomWindow));
    }
    #endregion
    #region System
    #endregion
    #region GUI
    void OnGUI()
    {
        GUILayout.Label(m_title, Styles.DesignTitle());
    }
    #endregion
    #region Debug Tool & Utility
    #endregion
    #region Class Methods
    #endregion
    #region Private Members
    private string m_title = "My Custom Window";

    private GameObject[] m_enemies  = GameObject.FindGameObjectsWithTag("Enemy");
    private GameObject[] m_allies   = GameObject.FindGameObjectsWithTag("Ally");
    private GameObject   m_player   = GameObject.FindGameObjectWithTag("Player");
    #endregion
}