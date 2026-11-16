using System.Collections;
using UnityEngine;

public class GoalkeeperController : MonoBehaviour
{
    public float speed = 1f;
    public float minY;
    public float maxY;

    private GameObject m_Target;

    private void Start()
    {
        UpdateTarget();
        StartCoroutine(nameof(GoToTarget));
    }

    // Patrols up and down between minY and maxY, using an empty GameObject as the target.
    private void UpdateTarget()
    {
        if (m_Target == null) {
            m_Target = new GameObject("Target");
            m_Target.transform.position = new Vector2(transform.position.x, minY);
            return;
        }
        
        if ((int)minY == (int)m_Target.transform.position.y) {
            m_Target.transform.position = new Vector2(transform.position.x, maxY);
        }
        
        else if ((int)maxY == (int)m_Target.transform.position.y) {
            m_Target.transform.position = new Vector2(transform.position.x, minY);
        }
    }

    private IEnumerator GoToTarget()
    {
        while(Vector2.Distance(transform.position, m_Target.transform.position) > 0.005f) {
            Vector2 direction = m_Target.transform.position - transform.position;

            transform.Translate(direction.normalized * speed * Time.deltaTime);

            yield return null;
        }
        yield return new WaitForSeconds(0.1f);

        UpdateTarget();
        StartCoroutine(nameof(GoToTarget));
    }
}
