using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnButton : MonoBehaviour
{
    [SerializeField] private string levelSceneName = "level1";

    public void Respawn()
    {
        SceneManager.LoadScene(levelSceneName);
    }
}