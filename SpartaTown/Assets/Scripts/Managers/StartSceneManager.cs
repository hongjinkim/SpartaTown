using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;

public class StartSceneManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject characterSelectWindow;
    public CharacterSelectButton characterSelectButton;

    [SerializeField] private string playerName;

    private void Awake()
    {
        characterSelectWindow.SetActive(false);
        PlayerPrefs.SetInt("character_index", 0);
    }

    public void OnJoinButtonClicked()
    {
        if(SetName())
        {
            SceneManager.LoadScene("MainScene");
        }
            
    }
    public void OnCharacterSelectButtonClicked()
    {
        characterSelectWindow.SetActive(true);
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
    public void SetCharacter(int idx)
    {
        PlayerPrefs.SetInt("character_index", idx);
        characterSelectWindow.SetActive(false);

        characterSelectButton.UpdateProfileImage(idx);
    }

}
