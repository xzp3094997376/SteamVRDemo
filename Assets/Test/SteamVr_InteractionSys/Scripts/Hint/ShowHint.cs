using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class ShowHint : MonoBehaviour
{
    private Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = Player.instance;
        Invoke("ShowAll",5);
    }

    /// <summary>
    /// 
    /// </summary>
    void ShowAll()
    {
        if (player.leftController!=null)
        {
            player.leftController.TriggerHapticPulse(500);
        }

       ControllerButtonHints.ShowTextHint(player.leftHand,EVRButtonId.k_EButton_Grip,"Grip");//标签显示

       ControllerButtonHints.ShowButtonHint(player.leftHand,EVRButtonId.k_EButton_ApplicationMenu);//按钮显示高亮

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
