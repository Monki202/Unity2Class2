using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Image healthbar;
    public float playerHealth;
    public float currentHealth;

    [Header("Ragdoll stuff")]
    public GameObject ragdoll;
    public GameObject playerModel;
    public PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = playerHealth;
    }

    public void TakeDamage(float damage)
    {
        if(currentHealth > 0)
        {
            currentHealth -= damage;
            healthbar.fillAmount = currentHealth / playerHealth;
            if (currentHealth <= 0)
            {
                ActivateRagdoll();
                Debug.Log("Player is dead");
            }
        }
    }

    public void ActivateRagdoll()
    {
        playerController.enabled = false;
        playerModel.SetActive(false);
        ragdoll.SetActive(true);
    }
}
