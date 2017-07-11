using UnityEngine;

public class Character : MonoBehaviour
{
    private const int MOUSE_LEFT_KEY = 0;

    public float Speed = 10.0f;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        Inputs.MouseLock = true;
    }
    
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        var delta = Inputs.GetKeyboardMovement(Speed);
        transform.Translate(delta);

        if (transform.position.y <= -30)
        {
            // Reset position
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
