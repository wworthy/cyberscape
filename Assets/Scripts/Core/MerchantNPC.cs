using UnityEngine;

public class MerchantNPC : MonoBehaviour {
    public int potionCost = 500;
    public int maxPotions = 9;
    public int currentPotions = 3;

    public void BuyPotion() {
        if (currentPotions >= maxPotions) {
            Debug.Log("You can't carry more potions.");
            return;
        }

        if (GameManager.instance.SpendZeny(potionCost)) {
            currentPotions++;
            Debug.Log("Potion purchased! Total: " + currentPotions);
        } else {
            Debug.Log("Not enough Zeny.");
        }
    }
}