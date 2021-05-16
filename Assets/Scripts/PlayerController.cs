using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forceMultiplier;
    public float maxLinearSpeed;
    public string side;

    private Rigidbody2D m_RigidBody2D;
    private Vector2 m_PositionMovement;

    private bool m_CanMove;
    private float m_HorizontalInput;

    private void Awake()
    {
        m_RigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        StartCoroutine(nameof(InitialSleep));
    }

    private void Update()
    {
        if (m_CanMove)
        {
            if (side == "right")
            {
                m_HorizontalInput = Input.GetAxis("Horizontal 2");
            }
            else
            {
                m_HorizontalInput = Input.GetAxis("Horizontal 1");
            }
            var intHorizontalInput = (int) m_HorizontalInput;
            
            m_PositionMovement = new Vector2(m_HorizontalInput * forceMultiplier, 0f);
            if (m_RigidBody2D.velocity.x > maxLinearSpeed)
            {
                if (intHorizontalInput == -1)
                {
                    GameMovement(m_RigidBody2D, m_PositionMovement, intHorizontalInput);
                }
            }
            else if (m_RigidBody2D.velocity.x < -maxLinearSpeed)
            {
                if (intHorizontalInput == 1)
                {
                    GameMovement(m_RigidBody2D, m_PositionMovement, intHorizontalInput);
                }
            }
            else
            {
                GameMovement(m_RigidBody2D, m_PositionMovement, intHorizontalInput);
            }
        }
    }

    private IEnumerator InitialSleep()
    {
        yield return new WaitForSeconds(2);
        m_CanMove = true;
    }

    private static void GameMovement(Rigidbody2D rigidbody2Dl, Vector2 vector2, float input)
    {
        rigidbody2Dl.AddForce(vector2);
        rigidbody2Dl.AddTorque(-input);
    }
}