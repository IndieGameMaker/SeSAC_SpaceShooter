using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public enum State
    {
        IDLE, TRACE, ATTACK, DIE
    }

    // 현재 몬스터의 상태
    public State state = State.IDLE;
    // 추적 사정거리
    [SerializeField] private float traceDist = 10.0f;
    // 공격 사정거리
    [SerializeField] private float attackDist = 2.0f;

    private Transform playerTr;
    private Transform monsterTr;

    void Start()
    {
        GameObject playerObj = GameObject.Find("Player");
        playerTr = playerObj.GetComponent<Transform>();

        monsterTr = transform; //monsterTr = GetComponent<Transform>();
    }

    void Update()
    {

    }
}
