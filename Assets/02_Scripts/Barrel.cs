using UnityEngine;
using Random = UnityEngine.Random;

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
                ExpBarrel();
            }
        }
    }

    /*
        Random.Range(min, max) 

        # 정수 Integer
        Random.Range(0, 10) => 0, 1, 2, ..., 9

        # 실수 Float
        Random.Range(0.0f , 10.0f) => 0.0f ~ 10.0f    
    */


    private void ExpBarrel()
    {
        var rb = this.gameObject.AddComponent<Rigidbody>();


        rb.AddExplosionForce(1500.0f, transform.position, 10.0f, 1800.0f);
    }
}
