using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public BoxCollider2D hitBox;  // 공격 판정 박스
    public float attackDuration = 0.3f;

    private bool isAttacking = false;

    void Start()
    {
        hitBox.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& !isAttacking)
        {
            StartCoroutine(Attack());
        }
    }

    private System.Collections.IEnumerator Attack()
    {
        Debug.Log("공격 시작");
        isAttacking = true;
        hitBox.enabled = true;

        // 공격 이펙트나 애니메이션 트리거 넣어도 좋음

        yield return new WaitForSeconds(attackDuration);

        hitBox.enabled = false;
        isAttacking = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("적 공격 성공!");
            // 적 체력 감소 처리 등 추가
        }
    }
}
