using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    static int _nextLevelIndex = 1;
    Enemy[] _enemies;

    private void OnEnable() {
        _enemies = FindObjectsOfType<Enemy>();
    }

    void Update()
    {
        foreach(Enemy enemy in _enemies){
            if (enemy != null)
                return;
        }

        Debug.Log("you killed all enemies");

        _nextLevelIndex++;
        string nextLevelName = "Level" + _nextLevelIndex;
        SceneManager.LoadScene(nextLevelName);
    }
}
