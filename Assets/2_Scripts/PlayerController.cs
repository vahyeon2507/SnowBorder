using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float torqueForce = 3f;
    [SerializeField] float baseSpeed = 20f;
    [SerializeField] float boostSpeed = 150f;

    private Rigidbody2D rb;
    SurfaceEffector2D surfaceEffector2D;
    private bool isBoosting = false;


    private enum InputKey
    {
        None, Left, Right
    }

    private InputKey currentKey = InputKey.None;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = Object.FindFirstObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        currentKey = Input.GetKey(KeyCode.LeftArrow) ?
            InputKey.Left :
            Input.GetKey(KeyCode.RightArrow) ? InputKey.Right : InputKey.None;

        isBoosting = Input.GetKey(KeyCode.UpArrow);
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
        surfaceEffector2D.speed = isBoosting ? boostSpeed : baseSpeed;
    }
}
