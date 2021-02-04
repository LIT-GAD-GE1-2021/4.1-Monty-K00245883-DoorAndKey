using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public bool switchOn;
    public bool switchEnabled;
    public Animator switchAnimator;
    // Start is called before the first frame update
    void Start()
    {
        switchOn = false;
    }

    // Update is called once per frame
     void Update()
    {
       if (Input.GetKeyDown("o") == true)
        {
            ActivateSwitch();
        }

    }
    public bool ActivateSwitch()
    {
        if(switchEnabled == true)
        {
            if (switchOn == false)
            {
                turnOn();
                LevelManager.instance.OpeningDoor();
            }
            else
            {
                turnOff();
            }

            return true;
        }
        else
        {
            return false;
        }
    }
    public void turnOn()
    {
        switchOn = true;
        switchAnimator.SetBool("SwitchOn", switchOn);
    }

    public void turnOff()
    {
        switchOn = false;
        switchAnimator.SetBool("SwitchOn", switchOn);
    }
    public void enableSwitch()
    {
        switchEnabled = true;
    }

    public void disableSwitch()
    {
        switchEnabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You're in the switch trigger.");
        enableSwitch();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("You left the switch trigger.");
        disableSwitch();
    }
}
