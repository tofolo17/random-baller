using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalColliderController : MonoBehaviour
{
    public Text text;

    private static int _playerOneScore;
    private static int _playerTwoScore;

    private void Start()
    {
        if (gameObject.name.Contains("Left"))
        {
            text.text = "" + _playerOneScore;
        }
        else
        {
            text.text = "" + _playerTwoScore;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Ball"))
        {
            if (gameObject.name.Contains("Right"))
            {
                _playerOneScore++;
            }
            else
            {
                _playerTwoScore++;
            }

            SceneManager.LoadScene(0);
        }
    }
}