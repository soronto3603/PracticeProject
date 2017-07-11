using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalManager : MonoBehaviour
{
    public GameObject ModalPanel;

    private static ModalManager instance;
    public static ModalManager Instance
    {
        get
        {
            if (!instance)
            {
                instance = FindObjectOfType<ModalManager>();

                if (!instance)
                {
                    Debug.LogError("Please add ModalManager in a GameObject.");
                }
            }

            return instance;
        }
    }

    public void OpenModal()
    {
        ModalPanel.SetActive(true);
    }

    public void CloseModal()
    {
        ModalPanel.SetActive(false);
    }
}
