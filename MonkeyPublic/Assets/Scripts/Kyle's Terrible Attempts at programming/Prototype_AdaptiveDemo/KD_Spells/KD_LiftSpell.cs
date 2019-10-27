using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KD_LiftSpell : MonoBehaviour, ISpells
{
    public string spellTitle { get ; set ; }
    public string spellDescription { get; set; }
    public string spellFlavorText { get; set; }
    public Sprite spellImage { get; set; }
    public int magicCost { get; set; }
    public string magicCostText { get; set; }

    public Canvas SpellBookUI;
    public Canvas UI;
    public KD_MagicBar MainMagic;
    public int currentMagic;

    private void Awake()
    {
        MainMagic = UI.GetComponent<KD_MagicBar>();
        spellTitle = "Lift";
        spellDescription = "Lift the object into the sky";
        spellFlavorText = "Bye, bye!";
        magicCost = 5;
        magicCostText = "Magic Cost: 5";
    }
    private void Update()
    {
        currentMagic = UI.GetComponent<KD_MagicBar>().currentMagic;

    }

    public void Cast(GameObject target)
    {
        if (target == null)
        {
            return;
        }
        else if(currentMagic >= magicCost)
        {
            MainMagic.currentMagic -= magicCost;
            target.GetComponent<Rigidbody>().AddForce(Vector3.up * 500f * Time.deltaTime, ForceMode.VelocityChange);
            SpellBookUI.gameObject.SetActive(false);

        }
        else if (currentMagic < 5)
        {
            SpellBookUI.gameObject.SetActive(false);
            return;
        }
    }
}
