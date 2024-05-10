using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectButton : MonoBehaviour
{
    [SerializeField] private Sprite[] profileImages;
    [SerializeField] private Image profile;

    private void Awake()
    {
        UpdateProfileImage(0);
    }

    public void UpdateProfileImage(int idx)
    {
        profile.sprite = profileImages[idx];
    }
}
