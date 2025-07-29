using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject hitboxObject;
    public float hitDuration = 0.2f;

    private bool isAttacking = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isAttacking)
        {
            StartCoroutine(Attack());
        }
    }

    private System.Collections.IEnumerator Attack()
    {
        isAttacking = true;
        hitboxObject.SetActive(true);
        yield return new WaitForSeconds(hitDuration);
        hitboxObject.SetActive(false);
        isAttacking = false;
    }
}
