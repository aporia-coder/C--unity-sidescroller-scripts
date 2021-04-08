using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  public Transform player;
  public PlayerMovement movement;
  public Text score;
  void Update()
  {
    if (movement.enabled)
    {
      score.text = player.position.z.ToString("0");
    }
    else
    {
      score.text = $"Game Over: Score {player.position.z.ToString("0")}";
    }
  }
}
