using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text CurrentPositionLabel;

    /// <summary>
    /// LateUpdate is called every frame, if the Behaviour is enabled.
    /// It is called after all Update functions have been called.
    /// </summary>
    void LateUpdate()
    {
       GameObject player = GameObject.FindWithTag("Player");

       if (player)
       {
           CurrentPositionLabel.text = string.Format("Current Position: {0}", player.transform.position.ToString());
       }
    }
}
