using UnityEditor.PackageManager.UI;
using UnityEngine;
using Random = UnityEngine.Random;

public class Barrel : MonoBehaviour
{
    private int hitCount = 0;
    public GameObject expEffect;

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

        Vector3 pos = Random.insideUnitSphere; //단위 구체의 랜덤값 리턴
        rb.AddExplosionForce(1500.0f, transform.position + pos, 10.0f, 1800.0f);
        Destroy(this.gameObject, 3.0f);

        var obj = Instantiate(expEffect, transform.position, Quaternion.identity);
        Destroy(obj, 5.0f);
    }
}
