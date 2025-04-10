using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    public GameObject slashPrefab;
    public GameObject bulletPrefab;
    public GameObject spellPrefab;
    public Transform firePoint;

    public PlayerStats stats;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Slash();
        if (Input.GetKeyDown(KeyCode.Alpha2)) Shoot();
        if (Input.GetKeyDown(KeyCode.Alpha3)) CastSpell();
    }

    void Slash() {
        if (stats.currentStamina >= 10) {
            stats.ConsumeStamina(10);
            Instantiate(slashPrefab, firePoint.position, firePoint.rotation);
        }
    }

    void Shoot() {
        if (stats.currentStamina >= 5) {
            stats.ConsumeStamina(5);
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }

    void CastSpell() {
        if (stats.currentMana >= 20 && stats.currentStatus != StatusEffect.Silenced) {
            stats.ConsumeMana(20);
            Instantiate(spellPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
