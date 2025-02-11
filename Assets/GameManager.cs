using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;
    public void EndGame()
    {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);  // Restart the scene

        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
