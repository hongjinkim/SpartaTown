using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]private TMP_Text playerName;

    private void Awake()
    { 
       
    }

    void Start()
    {
        playerName.text = PlayerPrefs.GetString("player_name");
    }

}
