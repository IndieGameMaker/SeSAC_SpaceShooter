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
        // transform.position += new Vector3(0, 0, 0.1f);
        transform.position += Vector3.forward * 0.1f;
    }

}

/*
    Vector3.forward = Vector3(0, 0, 1)
    Vector3.up      = Vector3(0, 1, 0)
    Vector3.right   = Vector3(1, 0, 0)

    Vector3.one     = Vector3(1, 1, 1)
    Vector3.zero    = Vector3(0, 0, 0)
*/
