using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 전역변수 선언
    private float v;


    // 1 호출, 제일 먼저 호출 
    void Start()
    {
    }

    // 매 프레임 마다 호출, 60 FPS, 불규칙한 주기, 랜더링 주기와 동일
    void Update()
    {
        // 축(Axis) 값을 받아옴. -1.0f ~ 0.0 ~ +1.0f
        v = Input.GetAxis("Vertical");
        // 콘솔 뷰에 메시지를 출력하는 메소드 Debug.Log("메시지");
        Debug.Log(v);


        // transform.position += new Vector3(0, 0, 0.1f);
        // transform.position += Vector3.forward * 0.1f;
        transform.Translate(Vector3.forward * 0.1f);
    }

}

/*
    Vector3.forward = Vector3(0, 0, 1)
    Vector3.up      = Vector3(0, 1, 0)
    Vector3.right   = Vector3(1, 0, 0)

    Vector3.one     = Vector3(1, 1, 1)
    Vector3.zero    = Vector3(0, 0, 0)
*/
