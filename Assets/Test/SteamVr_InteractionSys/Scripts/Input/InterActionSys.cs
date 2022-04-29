using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  Valve.VR;
using Valve.VR.InteractionSystem;

public class InterActionSys : MonoBehaviour
{
    private Player player;
    // Start is called before the first frame update
    void Start()
    {
        player= Player.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateListen()
    {
        if (player.leftController!=null) 
        {
            if (player.leftController.GetPressDown(EVRButtonId.k_EButton_SteamVR_Trigger))
            {
                Debug.Log("left trigger down");
            }
        }
    }
}
