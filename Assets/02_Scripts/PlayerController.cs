using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 1 호출, 제일 먼저 호출 
    void Start()
    {
    }

    // 매 프레임 마다 호출, 60 FPS, 불규칙한 주기, 랜더링 주기와 동일
    void Update()
    {
        transform.position += new Vector3(0, 0, 0.1f);
    }

}
