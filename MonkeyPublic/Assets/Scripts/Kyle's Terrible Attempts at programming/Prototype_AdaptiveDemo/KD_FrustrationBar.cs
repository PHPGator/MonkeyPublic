using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KD_FrustrationBar : MonoBehaviour
{
    public GameObject PlayerCharacter;
    private Stats pcStats;
    [SerializeField]
    private Slider frustrationSlider;
    [SerializeField]
    private TMP_Text frustrationDisplayText;

    public int currentFrustration;

    void Start()
    {
        pcStats = PlayerCharacter.GetComponent<Stats>();
        currentFrustration = pcStats.FrustrationResource;
    }

    void Update()
    {
        SetFrustration();
    }

    private void SetFrustration()
    {
        frustrationSlider.value = currentFrustration;
        frustrationDisplayText.SetText(currentFrustration.ToString());
    }

    public void FrustrationPlusButton()
    {
        if (currentFrustration <= 95)
        {
            currentFrustration += 5;
        }
        if (currentFrustration == 100)
        {
            return;
        }
    }
    public void FrustrationMinusButton()
    {
        if (currentFrustration >= 5)
        {
            currentFrustration -= 5;
        }
        if (currentFrustration == 0)
        {
            return;
        }
    }
}
