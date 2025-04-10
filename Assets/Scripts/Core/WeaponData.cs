using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Items/Weapon")]
public class WeaponData : ScriptableObject {
    public string weaponName;
    public GameObject projectilePrefab;
    public float damage;
    public float attackSpeed;
    public float range;
    public AttackPattern attackPattern;
    public StatusEffect statusEffect;
}
