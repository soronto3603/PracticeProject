using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class ModalDialog : MonoBehaviour
{
    public Text CurrentPositionLabel;
    public Text NextPositionLabel;

    public GameObject ButtonPanel;
    public GameObject CheckPoints;

    private Dictionary<string, Vector3> checkpoints = new Dictionary<string, Vector3>();

    private Button[] buttons;
    private Vector3 currentSelected;

    void Start()
    {
        buttons = ButtonPanel.GetComponentsInChildren<Button>();

        Debug.Log(string.Format("Buttons: {0}", buttons.Length));

        foreach (var button in buttons)
        {
            button.onClick.AddListener(() => OnClickButton(button.name));
        }

        foreach (Transform child in CheckPoints.transform)
        {
            checkpoints.Add(child.name, child.position);
        }
    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        transform.SetAsLastSibling();
    }

    /// <summary>
    /// LateUpdate is called every frame, if the Behaviour is enabled.
    /// It is called after all Update functions have been called.
    /// </summary>
    void LateUpdate()
    {
        GameObject player = GameObject.FindWithTag("Player");

        if (player)
        {
            CurrentPositionLabel.text = string.Format("Current: {0}", player.transform.position.ToString());
        }
    }

    private void OnClickButton(string tag)
    {
        Debug.Log(string.Format("Click Event From Tag : {0}", tag));

        Vector3 position;
        if (checkpoints.TryGetValue(tag, out position))
        {
            currentSelected = position;
            NextPositionLabel.text = string.Format("Move To: {0}", position.ToString());
        }
        else
        {
            currentSelected = Vector3.zero;
        }
    }

    public void OnMoveButtonClick()
    {
        GameObject player = GameObject.FindWithTag("Player");

        if (player && currentSelected.sqrMagnitude != 0)
        {
            player.transform.position = currentSelected;
        }
    }
}