using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int FrustrationResource;
    public int MagicResource;

    private int startingFrustration = 0;
    private int startingMagic = 0;

    private void Start()
    {
        FrustrationResource = startingFrustration;
        MagicResource = startingMagic;
    }
}
