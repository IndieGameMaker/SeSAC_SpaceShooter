using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        // 씬 로딩 (Logic)
        SceneManager.LoadScene("Logic");
    }
}
