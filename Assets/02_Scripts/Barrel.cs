using Unity.VisualScripting;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    private int hitCount = 0;

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("BULLET"))
        {
            ++hitCount; // hitCount += 1;
            if (hitCount >= 3)
            {
                // 폭발효과
            }
        }
    }
}
