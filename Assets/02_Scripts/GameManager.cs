using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 게임 개발 디자인 패턴 
    // 싱글턴 디자인 패턴 (Singlton Desing Pattern)
    public static GameManager Instance = null;

    public List<Transform> points = new List<Transform>();
    public GameObject monsterPrefab;

    private bool isGameOver = false;

    // 오브젝트 풀 정의(선언)
    public List<GameObject> monsterPool = new List<GameObject>();
    // 오브젝트 풀 갯수
    public int maxPool = 10;

    // 프로퍼티 선언
    public bool IsGameOver
    {
        get
        {
            return isGameOver;
        }
        set
        {
            isGameOver = value;
            // if (isGameOver)
            // {
            //     Debug.Log("게임 종료");
            //     // 엔딩 타이틀 UI 표현
            //     CancelInvoke(nameof(CreateMonster));
            // }
        }
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // 다른 씬이 오픈되어도 지속하도록하는 메소드
            DontDestroyOnLoad(this.gameObject);
        }
        else if (Instance != this)
        {
            // 중복해서 생성된 GameManager 삭제
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        var spawnPointGroup = GameObject.Find("SpawnPointGroup");
        spawnPointGroup.GetComponentsInChildren<Transform>(points);

        // InvokeRepeating(nameof(CreateMonster), 2.0f, 3.0f);
        StartCoroutine(CreateMonster());
    }

    IEnumerator CreateMonster()
    {
        yield return new WaitForSeconds(2.0f);

        while (!isGameOver)
        {
            // 난수 발생
            int index = UnityEngine.Random.Range(1, points.Count);
            Instantiate(monsterPrefab, points[index].position, Quaternion.identity);

            yield return new WaitForSeconds(3.0f);
        }
    }
    // Pseudo 코드
    // void 추적()
    // {
    //     //1. 주인공 케릭터를 찾는다.

    //     //2. 이동 명령을 내린다.
    //     //3. 근접 하면 공격 애니메이션 실행
    //     //4. 사운드 재생
    // }
}
