using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private bool isTabPressed = false;

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {   // KeyDown
            isTabPressed = true;
            Inputs.MouseLock = false;
            ModalManager.Instance.OpenModal();
        }
        else
        {   // KeyUp
            isTabPressed = false;
            Inputs.MouseLock = true;
            ModalManager.Instance.CloseModal();
        }

        if (!isTabPressed && !Inputs.MouseLock && Input.GetMouseButtonDown(0)) {
            Inputs.MouseLock = true;
        }
    }
}
