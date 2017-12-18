using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class LifeManager : MonoBehaviour 
{
    #region Public Member

    public UnityEvent m_onDeath;
    public UnityEvent m_onRez;
    public UnityEvent m_onAlive;

    [Header("Debug")]
    public bool m_useDebugLog;

    [Range(0, 1f)]
    [SerializeField]
    [Header("Life")]
    [Tooltip("Life of the target between 0-1 percent")]
    /// Life of the target between 0-1 percent.          
    private float m_life;

    public float Life
    {
        get { return m_life; }
        set
        {
            float oldValue = m_life;
            float newValue = value;

            if (oldValue != newValue)
            {
                m_life = value;

                value = Mathf.Clamp01(value);
                if (oldValue == 0 && newValue > 0)
                {
                    m_onRez.Invoke();
                    if (m_useDebugLog) Debug.Log("REZ");
                }
                else if (m_life == 0)
                {
                    m_onDeath.Invoke();
                    if (m_useDebugLog) Debug.Log("DEATH");
                }
                else
                {
                    m_onAlive.Invoke();
                    if (m_useDebugLog) Debug.Log("ALIVE");
                }
            }
        }
    }
    #endregion

    #region System

    private void OnValidate()
    {
        Life = m_life;
    }

    private void Reset()
    {
        m_life = 0f;
    }

    #endregion

}
