using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class KD_Spells
{
    public virtual string spellTitle { get; set; }
    public virtual string spellText { get; set; }
    public virtual string spellFlavorText { get; set; }
    public virtual Sprite spellImage { get; set; }
    public virtual int magicCost { get; set; }

    public virtual void Cast(GameObject target)
    {
    }
}
