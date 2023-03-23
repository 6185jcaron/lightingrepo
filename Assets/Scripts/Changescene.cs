using UnityEngine.SceneManagement;
using UnityEngine;

public class Changescene : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}