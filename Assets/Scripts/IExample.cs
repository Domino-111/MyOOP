using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

//Interface Example

interface IClick
{
    void Click();

    void Press();
}

public class MyTV : MonoBehaviour, IClick
{
    public void Click()
    {
        Debug.Log("Turn on TV");
    }

    public void Press()
    {
        Debug.Log("Turn up volume");
    }
}

public class LightSwitch : MonoBehaviour, IClick
{
    public void Click()
    {
        Debug.Log("Turn on light");
    }

    public void Press()
    {
        Debug.Log("Turn up the brightness");
    }
}

public class Player : MonoBehaviour
{
    void PlayerInput()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 2f))
            {
                IClick clicked = hit.transform.gameObject.GetComponent<IClick>();
                if (clicked != null)
                {
                    clicked.Click();
                }
            }
        }
    }
}