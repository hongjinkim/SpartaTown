using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;

public class PlayerUI : MonoBehaviour
{
    private TMP_Text playerName;

    private void Awake()
    {
        playerName = GetComponentInChildren<TMP_Text>();
    }

    void Start()
    {
        playerName.text = PlayerPrefs.GetString("player_name");
    }

}
