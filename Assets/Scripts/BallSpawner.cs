using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    
    private Rigidbody2D m_RigidBody2D;

    private void Start()
    { 
        var instantiatedObject = Instantiate(ball, gameObject.transform.position, Quaternion.identity);
        m_RigidBody2D = instantiatedObject.gameObject.GetComponent<Rigidbody2D>();
        
        StartCoroutine(nameof(Sleep));
    }

    private IEnumerator Sleep()
    {
        // The ball stays frozen for 1 s before physics kicks in.
        yield return new WaitForSeconds(1);

        m_RigidBody2D.simulated = true;
    }
}
