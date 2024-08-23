using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // 버튼을 할당할 변수 선언
    public Button startButton;

    void OnEnable()
    {
        // 이벤트 연결
        startButton.onClick.AddListener(() => OnStartButtonClick());
    }

    public void OnStartButtonClick()
    {
        // 씬 로딩 (Logic)
        SceneManager.LoadScene("Level01");
        SceneManager.LoadScene("Logic", LoadSceneMode.Additive);
    }
}

/*
    Team member #1 : Lead Programmer
    Team member #2 : Level Designer
    Team member #3 : UI Designer
*/