using UnityEngine.SceneManagement;
using UnityEngine;

public class Backlevel : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}