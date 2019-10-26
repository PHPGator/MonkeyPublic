using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KD_UIManager : MonoBehaviour
{
    public Canvas SpellBook;
    public Canvas MainUI;

    private void Awake()
    {
        SpellBook.gameObject.SetActive(false);
    }

    public void OnSpellBookButtonClick()
    {
        if(SpellBook.gameObject.activeSelf == true)
        {
            SpellBook.gameObject.SetActive(false);

        }
        else SpellBook.gameObject.SetActive(true);
    }
}
