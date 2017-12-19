using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour 
{
    public Info[] _eleves;

    [System.Serializable]
    public class Info {
        
        public string _name;
        [Range(0,99)]
        public int _age=13;
        public enum Sex { M,F}
        public Sex _sex;
    }


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

    #region Private and Protected Members

    #endregion

}
