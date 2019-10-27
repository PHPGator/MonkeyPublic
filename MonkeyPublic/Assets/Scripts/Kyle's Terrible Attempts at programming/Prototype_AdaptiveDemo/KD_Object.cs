using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KD_Object : MonoBehaviour, ITargetable
{
    public GameObject MainInputManager;
    public GameObject MainInputManagerTarget;
    public Light light;
    private float hopForce = .5f;

    private void Awake()
    {
        light = gameObject.GetComponentInChildren<Light>();
        light.gameObject.SetActive(false);

    }

    private void Update()
    {
        MainInputManagerTarget = MainInputManager.GetComponent<KD_InputManager>().CurrentTarget;
        Targeted();
        RemoveTarget();

    }

    public void RemoveTarget()
    {
        if (MainInputManagerTarget == null)
        {
            light.gameObject.SetActive(false);
            return;
        }
        else if (MainInputManagerTarget.gameObject.name.ToString() != gameObject.name.ToString())
        {
            light.gameObject.SetActive(false);
        }

    }

    public void Targeted()
    {
        if (MainInputManagerTarget == null)
        {
            return;

        }
        else if (MainInputManagerTarget.gameObject.name.ToString() == gameObject.name.ToString())
        {
            light.gameObject.SetActive(true);
            //GetComponent<Rigidbody>().AddForce(Vector3.up * hopForce, ForceMode.VelocityChange); 
        }
    }
}
