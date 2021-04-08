using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public PlayerMovement movement;
  public Transform height;

  void OnCollisionEnter(Collision collisionInfo)
  {
    if (collisionInfo.collider.tag == "Obstacle")
    {
      movement.enabled = false;
      FindObjectOfType<GameManager>().EndGame();
    }
  }

  void Update()
  {
    if (height.position.y < 0)
    {
      movement.enabled = false;
      FindObjectOfType<GameManager>().EndGame();
    }
  }
}
