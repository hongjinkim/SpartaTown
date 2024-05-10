using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;

public class InputWindow : MonoBehaviour
{
    private TMP_InputField inputField;

    [SerializeField] private string playerName;

    private void Awake()
    {
        inputField = transform.Find("InputField").GetComponent<TMP_InputField>();
    }

    public void OnJoinButtonClicked()
    {
        if(SetName())
            SceneManager.LoadScene("MainScene");
    }

    public bool SetName()
    {
        playerName = inputField.text;
        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            PlayerPrefs.SetString("player_name", inputField.text);
            return true;
        }
        else
            return false;
    }

}
