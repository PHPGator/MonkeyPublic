using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpells 
{
    string spellTitle { get; set; }
    string spellDescription { get; set; }
    string spellFlavorText { get; set; }
    Sprite spellImage { get; set; }
    int magicCost { get; set; }
    string magicCostText { get; set; }
}
