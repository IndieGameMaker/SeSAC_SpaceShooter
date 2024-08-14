using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        // 충동한 물체를 파악
        if (coll.collider.tag == "BULLET")
        {
            Destroy(coll.gameObject);
        }
    }

    // 충돌 콜백 함수
    /*
        1. 양쪽 다 Collider 갖고 있다.
        2. 이동하는 게임오브젝트에 Rigidbody 있어야 함.

        # IsTrigger 언체크 경우
            OnCollisionEnter
            OnCollisionStay
            OnCollisionExit

        # IsTrigger 체크 경우
            OnTriggerEnter
            OnTriggerStay
            OnTriggerExit
    */
}
