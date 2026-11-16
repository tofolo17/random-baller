using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalColliderController : MonoBehaviour
{
    public Text text;

    // Static so the score survives the scene reload that restarts each round.
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

            // Reload the scene: new random players and a new ball for the next round.
            SceneManager.LoadScene(0);
        }
    }
}