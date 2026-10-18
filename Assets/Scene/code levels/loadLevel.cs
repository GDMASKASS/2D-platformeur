using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void Go()
    {
        SceneManager.LoadScene("Level 1");
    }
}