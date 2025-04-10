using UnityEngine;
using UnityEngine.SceneManagement;

public class ArenaGuard : MonoBehaviour {
    public string arenaSceneName = "ArenaScene";

    public void EnterArena() {
        Debug.Log("Entering the Arena...");
        SceneManager.LoadScene(arenaSceneName);
    }
}
