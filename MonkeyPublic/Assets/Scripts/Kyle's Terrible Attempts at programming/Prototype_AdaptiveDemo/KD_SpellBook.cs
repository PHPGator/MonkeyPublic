using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class KD_SpellBook : MonoBehaviour
{
    public List<GameObject> SpellContainer;
    public GameObject MainUI;
    public Canvas SpellBookUI;
    public TMP_Text SpellTitle;
    public TMP_Text SpellDescription;
    public TMP_Text SpellFlavorText;
    public TMP_Text SpellCost;
    public int selectSpell;

    public void Start()
    {
        var currentSpell = SpellContainer[selectSpell].gameObject.GetComponent<KD_LiftSpell>();
        SpellTitle.text = currentSpell.spellTitle;
        SpellDescription.text = currentSpell.spellDescription;
        SpellFlavorText.text = currentSpell.spellFlavorText;
        SpellCost.text = currentSpell.magicCostText;
    }

    public void CallCast()
    {
        var currentSpell = SpellContainer[selectSpell].gameObject.GetComponent<KD_LiftSpell>();
        currentSpell.Cast(MainUI.GetComponent<KD_InputManager>().CurrentTarget);
    }

    public void SpellBookLeft()
    {
        if (selectSpell <= 0)
        {
            return;
        }
        else --selectSpell;
    }
    
    public void SpellBookRight()
    {
        if (selectSpell == SpellContainer.Count)
        {
            return;
        }
        else ++selectSpell; 
    }


}
