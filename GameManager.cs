using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public bool gameHasEnded = false;
  public void EndGame()
  {
    if (gameHasEnded == false)
    {
      UnityEngine.Debug.Log("GAME OVER");
      gameHasEnded = true;
      Invoke("Restart", 3f);
    }
  }

  void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
