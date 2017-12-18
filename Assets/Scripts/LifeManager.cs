using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class LifeManager : MonoBehaviour 
{
    [Range(0, 1f)]
    [SerializeField]
    [Header("Life")]
    [Tooltip("Life of the target between 0-1 percent")]
    /// Life of the target between 0-1 percent.
                
    private float m_life;

    public UnityEvent m_onDeath;

    public float Life         
    {
        get { return m_life; }
        set
        {
            value = Mathf.Clamp01(value);
            m_life = value;
        }
    }

    [Header("Debug")]
    public bool m_useDebugLog;

    #region System

    private void OnValidate()
    {
        
    }

    private void Reset()
    {
        m_life = 0f;
    }

    #endregion

}
