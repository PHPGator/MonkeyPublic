using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class KD_InputManager : MonoBehaviour
{
    public bool rightClick;
    public bool leftClick;
    public GameObject RightClickMenuGameObject;
    public KD_SpellBook FairyGameSpellBook;
    public GameObject SpellBookUI;
    public GameObject NextTarget;
    public GameObject CurrentTarget;
    public GameObject LastTarget;

    private void Awake()
    {
        FairyGameSpellBook = SpellBookUI.GetComponent<KD_SpellBook>();
    }

    void Update()
    {
        rightClick = Input.GetMouseButtonDown(1);

        leftClick = Input.GetMouseButtonDown(0);

        if (rightClick == true)
        {
            RightClickMenu();
        }

        if (leftClick == true ^ rightClick == true)
        {
            if (OverUICheck() == false)
            {
                Targeting();
            }
        }

        if (leftClick == true && RightClickMenuGameObject.gameObject.activeSelf != false) 
        {
            
            if (OverUICheck() == false)
            {
                DisableRightClickMenu();
            }
        }
    }

    
    private void Targeting()
    {
        SetTarget();

        if (NextTarget == null)
        {
            CurrentTarget = NextTarget;
            NextTarget = null;
        }

        if (NextTarget != CurrentTarget)
        {
            LastTarget = CurrentTarget;
            CurrentTarget = NextTarget;
            NextTarget = null;
        }
    }

    private void SetTarget()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100f))
        {
            if (hit.collider.gameObject.tag != "UnTargetable")
            {
                NextTarget = hit.collider.gameObject;
            }
            else NextTarget = null;
        }
    }

    private bool OverUICheck()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }

    private void RightClickMenu()
    {
        RightClickMenuGameObject.SetActive(true);
        //Vector3 location = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        Vector3 location = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        RightClickMenuGameObject.transform.position = location;
    }

    public void Inspect()
    {
        //Null Check
        //target game object to inspect point (Closer to Camera)
        //change dim lighting
        //fade backgroud
        //Close RightClickMenu On Click

        DisableRightClickMenu();
    }

    public void Interact()
    {
        //Null Check
        //Call interact on target object 
        DisableRightClickMenu();

    }

    public void TriggerSpell()
    {
        //get target
        //Null Check
        //environment spell
        //Send Chosen spell to SpellCastManager
        //Close RightClickMenu On Click

        SpellBookUI.SetActive(true);
        DisableRightClickMenu();
    }
    

    private void DisableRightClickMenu()
    {
        RightClickMenuGameObject.SetActive(false);
    }
}
