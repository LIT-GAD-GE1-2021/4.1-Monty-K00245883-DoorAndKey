using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public static LevelManager instance;
    public KeyController keyControl;
    public SwitchController switchControl;
    public DoorController doorControl;
    public bool key;
    public bool doorOpen;
    private void Awake()
    {
        instance = this;
        key = false;
        doorOpen = false;
    }

    private void Update()
    {

    }
    public void OpeningDoor()
    {
        if(key == true)
        {
            doorOpen = true;
            doorControl.OpenDoor();
        }
    }

}
