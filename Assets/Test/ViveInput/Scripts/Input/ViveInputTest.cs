using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;

public class ViveInputTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateListen();
    }

    #region update监听
    void UpdateListen()
    {
        if (ViveInput.GetPressDown(HandRole.LeftHand, ControllerButton.Menu))
        {
            Debug.Log("按下");
        }
        if (ViveInput.GetPress(HandRole.LeftHand, ControllerButton.Menu))
        {
            Debug.Log("接触");
        }

        if (ViveInput.GetPressUp(HandRole.LeftHand, ControllerButton.Menu))
        {
            Debug.Log("抬起");
        }
    }
    #endregion

    #region 事件监听
    /// <summary>
    /// 事件监听
    /// </summary>
    void AddListen()
    {
        ViveInput.AddPressDown(HandRole.LeftHand, ControllerButton.Menu, MenuPressDown);
        ViveInput.AddPress(HandRole.LeftHand, ControllerButton.Menu, MenuPress);
        ViveInput.AddPressUp(HandRole.LeftHand, ControllerButton.Menu, MenuPressUp);
    }

    void MenuPressDown()
    {
        Debug.Log("menu 按下");
    }
    void MenuPress()
    {
        Debug.Log("menu 按住");
    }
    void MenuPressUp()
    {
        Debug.Log("menu 按住");
    }
    void RemoveListen()
    {
        ViveInput.RemovePressDown(HandRole.LeftHand, ControllerButton.Menu, MenuPressDown);
        ViveInput.RemovePressDown(HandRole.LeftHand, ControllerButton.Menu, MenuPress);
        ViveInput.RemovePressDown(HandRole.LeftHand, ControllerButton.Menu, MenuPressUp);
    }
    #endregion

    #region trigger 值类型

    void TriggerValue()
    {
        float val= ViveInput.GetTriggerValue(HandRole.LeftHand, false);
        //val >= 0 && val <= 1;
    }

    #endregion


    #region Pad
    /// <summary>
    /// pad value 值类型开发
    /// </summary>
    void PadValue()
    {
        Vector2 vector2= ViveInput.GetPadTouchAxis(HandRole.LeftHand);
    }
    

    #endregion
}
