using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;
    public int defense = 10;

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int rawDamage)
    {
        int finalDamage = Mathf.Max(1, rawDamage - defense); // 최소 1 데미지
        currentHP -= finalDamage;

        Debug.Log($"적이 {finalDamage} 만큼의 데미지를 입었습니다. 남은 체력: {currentHP}");

        if (currentHP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("적이 죽었습니다.");
        Destroy(gameObject);
    }
}
