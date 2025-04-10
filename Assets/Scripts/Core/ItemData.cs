[System.Serializable]
public class ItemData {
    public string name;
    public float baseStat;
    public string[] affixes;
    public ItemRarity rarity;
    public int upgradeLevel;
    public bool rerolledOnce;

    public ItemData(string name, float baseStat, string[] affixes, ItemRarity rarity) {
        this.name = name;
        this.baseStat = baseStat;
        this.affixes = affixes;
        this.rarity = rarity;
        this.upgradeLevel = 0;
        this.rerolledOnce = false;
    }
}