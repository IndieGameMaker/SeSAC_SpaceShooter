using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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

    // 점수 저장 변수 선언
    private int score = 0;

    // 점수 프로퍼티 선언
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            // 점수를 저장
            score += value;
            PlayerPrefs.SetInt("SCORE", score);
            // 점수를 출력
            scoreText.text = $"SCORE : {score:0000000}";
        }
    }
    public TMP_Text scoreText;

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
        // 점수 로드 및 출력
        score = PlayerPrefs.GetInt("SCORE", 0);
        scoreText.text = $"SCORE : {score:0000000}";

        var spawnPointGroup = GameObject.Find("SpawnPointGroup");
        spawnPointGroup.GetComponentsInChildren<Transform>(points);

        CreateMonsterPool();

        StartCoroutine(CreateMonster());
    }

    private void CreateMonsterPool()
    {
        for (int i = 0; i < maxPool; i++)
        {
            GameObject monster = Instantiate(monsterPrefab);
            monster.name = $"Monster_{i:00}";
            monster.SetActive(false);
            // 오브젝트 풀에 추가
            monsterPool.Add(monster);
        }
    }

    IEnumerator CreateMonster()
    {
        yield return new WaitForSeconds(2.0f);

        while (!isGameOver)
        {
            // 난수 발생
            int index = UnityEngine.Random.Range(1, points.Count);

            // 오브젝트 풀에서 비활성화 된 몬스처를 추출
            foreach (var monster in monsterPool)
            {
                if (monster.activeSelf == false)
                {
                    monster.transform.position = points[index].position;
                    monster.SetActive(true);
                    break;
                }
            }

            //Instantiate(monsterPrefab, points[index].position, Quaternion.identity);

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
/*
    Lightmap , Lightmapping

    베이킹 (Bake, Baking)

    조명의 종류
    1. 직접 광원 (Direct Light)
    2. 간접 광원 (Indirect Light)


    1. 실시간 조명 (Realtime Light)
    2. 베이크 조명 (Baked Light)
*/