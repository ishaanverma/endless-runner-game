using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject completeScoreUI;

    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
        completeScoreUI.SetActive(false);
    }

    public void endGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;

            //Restart Game
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
