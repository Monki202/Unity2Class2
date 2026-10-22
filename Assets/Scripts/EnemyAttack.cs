using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Transform attackTransform;
    public float attackRadius;
    public float attackDamage;

    public void AttackPlayer()
    {
        Collider[] hitColliders = Physics.OverlapSphere(attackTransform.position, attackRadius);

        foreach(var player in hitColliders)
        {
            if(player.CompareTag("Player"))
            {
                Debug.Log("beating the player up");
                player.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(attackTransform.position, attackRadius);
    }
}
