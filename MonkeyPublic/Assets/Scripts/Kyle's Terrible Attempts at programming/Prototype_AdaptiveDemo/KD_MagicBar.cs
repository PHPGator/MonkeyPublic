using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KD_MagicBar : MonoBehaviour
{
    public GameObject PlayerCharacter;
    private Stats pcStats;
    [SerializeField]
    private Slider magicSlider;
    [SerializeField]
    private TMP_Text magicDisplayText;


    public int currentMagic;

    void Start()
    {
        pcStats = PlayerCharacter.GetComponent<Stats>();
        currentMagic = pcStats.MagicResource;
    }

    void Update()
    {
        SetMagic();
    }

    private void SetMagic()
    {
        magicSlider.value = currentMagic;
        magicDisplayText.SetText(currentMagic.ToString());
    }

    public void MagicPlusButton()
    {
        if (currentMagic <= 95)
        {
            currentMagic += 5;
        }
        if (currentMagic == 100)
        {
            return;
        }
    }
    public void MagicMinusButton()
    {
        if (currentMagic >= 5)
        {
            currentMagic -= 5; 
        }
        if (currentMagic == 0)
        {
            return;
        }
    }
}
