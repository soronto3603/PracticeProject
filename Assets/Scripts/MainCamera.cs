using UnityEngine;

public class MainCamera : MonoBehaviour
{
    private Vector2 mouseLook;
    private Vector2 smooth;
    private GameObject character;

    public float Sensitivity = 5.0f;
    public float Smoothing = 2.0f;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        character = transform.parent.gameObject; // Capsule
    }
    
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (Inputs.MouseLock)
        {
            var delta = Inputs.GetMouseMovement();

            delta *= (Sensitivity * Smoothing);

            smooth.x = Mathf.Lerp(smooth.x, delta.x, 1.0f / Smoothing);
            smooth.y = Mathf.Lerp(smooth.y, delta.y, 1.0f / Smoothing);

            mouseLook += smooth;
            mouseLook.y = Mathf.Clamp(mouseLook.y, -90.0f, 90.0f);
        }

        // X축을 기준으로 
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, Vector3.up);
    }
}
