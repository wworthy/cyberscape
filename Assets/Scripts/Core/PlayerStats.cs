using UnityEngine;

public class PlayerStats : MonoBehaviour {
    public float maxHealth = 100f;
    public float currentHealth;

    public float maxMana = 50f;
    public float currentMana;

    public float maxStamina = 50f;
    public float currentStamina;

    public StatusEffect currentStatus = StatusEffect.Normal;

    void Start() {
        currentHealth = maxHealth;
        currentMana = maxMana;
        currentStamina = maxStamina;
    }

    public void TakeDamage(float amount) {
        currentHealth -= amount;
        if (currentHealth <= 0) Die();
    }

    public void ConsumeMana(float amount) {
        if (currentMana >= amount) currentMana -= amount;
    }

    public void ConsumeStamina(float amount) {
        if (currentStamina >= amount) currentStamina -= amount;
    }

    public void ApplyStatus(StatusEffect newStatus) {
        currentStatus = newStatus;
    }

    void Die() {
        Debug.Log("Player has died.");
    }
}
