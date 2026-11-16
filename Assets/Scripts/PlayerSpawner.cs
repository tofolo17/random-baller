using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject[] prefabs;

    private PlayerController m_PlayerController;
    private SpriteRenderer m_SpriteRenderer;
    private Transform m_PlayerTransform;
    private Rigidbody2D m_Rigidbody2D;

    public void Start()
    {
        // Each round, pick a random shape and randomize its force, speed, size, color and bounciness.
        var prefabNumber = Random.Range(0, prefabs.Length);

        var instantiatedObject = Instantiate(prefabs[prefabNumber], gameObject.transform.position, Quaternion.identity);

        m_PlayerController = instantiatedObject.GetComponent<PlayerController>();
        m_PlayerController.forceMultiplier = Random.Range(20, 40) / 10f;
        m_PlayerController.maxLinearSpeed = Random.Range(500, 1000) / 100f;

        var randomX = Random.Range(80, 150) / 100f;
        var randomY = Random.Range(80, 150) / 100f;

        m_PlayerTransform = instantiatedObject.GetComponent<Transform>();
        m_PlayerTransform.localScale = new Vector3(randomX, randomY, 1);

        if (gameObject.name.Contains("Left"))
        {
            m_PlayerController.side = "left";
        }
        else
        {
            m_PlayerController.side = "right";
        }

        m_SpriteRenderer = instantiatedObject.GetComponent<SpriteRenderer>();
        var color = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));
        m_SpriteRenderer.color = color;

        m_Rigidbody2D = instantiatedObject.GetComponent<Rigidbody2D>();
        var material = new PhysicsMaterial2D() {bounciness = Random.Range(40, 90) / 100f};
        m_Rigidbody2D.sharedMaterial = material;
    }
}