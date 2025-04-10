using UnityEngine;

public class BlacksmithNPC : MonoBehaviour {
    public int baseUpgradeCost = 1000;

    public bool UpgradeItem(ItemData item) {
        if (item.upgradeLevel >= 5) {
            Debug.Log("This item is fully upgraded.");
            return false;
        }

        int cost = GetUpgradeCost(item.rarity, item.upgradeLevel);
        if (GameManager.instance.SpendZeny(cost)) {
            item.baseStat *= 1.1f;
            item.upgradeLevel += 1;
            Debug.Log($"Upgraded {item.name} to +{item.upgradeLevel}. New base stat: {item.baseStat}");
            return true;
        } else {
            Debug.Log("Not enough Zeny.");
            return false;
        }
    }

    public bool ReforgeAffix(ItemData item) {
        if (item.rerolledOnce) {
            Debug.Log("This item has already been reforged.");
            return false;
        }

        int cost = GetReforgeCost(item.rarity);
        if (GameManager.instance.SpendZeny(cost)) {
            int index = Random.Range(0, item.affixes.Length);
            item.affixes[index] = AffixPool.GetRandomAffix();
            item.rerolledOnce = true;
            Debug.Log($"Reforged affix on {item.name}. New affix: {item.affixes[index]}");
            return true;
        } else {
            Debug.Log("Not enough Zeny.");
            return false;
        }
    }

    int GetUpgradeCost(ItemRarity rarity, int currentLevel) {
        return baseUpgradeCost * (currentLevel + 1) * ((int)rarity + 1);
    }

    int GetReforgeCost(ItemRarity rarity) {
        return baseUpgradeCost * 2 * ((int)rarity + 1);
    }
}
