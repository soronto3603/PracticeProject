using UnityEngine;

public static class Inputs
{
    public static bool MouseLock
    {
        get
        {
            return Cursor.lockState == CursorLockMode.Locked;
        }
        set
        {
            Cursor.lockState = value ? CursorLockMode.Locked : CursorLockMode.None;
        }
    }

    public static Vector2 GetMouseMovement()
    {
        return new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
    }

    private static bool _keylock;

    public static bool KeyboardLock
    {
        set
        {
            _keylock = value;
        }
    }

    public static Vector3 GetKeyboardMovement(float speed)
    {
        if (_keylock)
        {
            return new Vector3(0, 0, 0);
        }
        else
        {
            float horizontal = Input.GetAxis("Horizontal") * speed;
            float verital = Input.GetAxis("Vertical") * speed;

            // TODO: Implement jump.

            horizontal *= Time.deltaTime;
            verital *= Time.deltaTime;

            return new Vector3(x: horizontal, y: 0, z: verital);
        }
    }
}
