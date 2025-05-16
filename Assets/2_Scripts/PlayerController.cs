using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float torqueForce = 3f; //����� ũ��
    private Rigidbody2D rb;

    private enum InputKey
    {
        None, Left, Right
    }

    private InputKey currentKey = InputKey.None;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        currentKey = Input.GetKey(KeyCode.LeftArrow) ?
            InputKey.Left :
            Input.GetKey(KeyCode.RightArrow) ? InputKey.Right : InputKey.None;
    }

    void FixedUpdate()
    {
        switch(currentKey)
        {
            case InputKey.Left:
                rb.AddTorque(torqueForce);
                break;
            case InputKey.Right:
                rb.AddTorque(-torqueForce);
                break;
            default:
                // Do nothing
                break;
        }
    }
}
