# Set up Unity C# scripts for ItemData, ItemRarity (with "Ascended"), and AffixPool

from pathlib import Path

base_path = Path("/mnt/data/EtherscapeUnity")

blacksmith_support_scripts = {
    "Assets/Scripts/Core/ItemRarity.cs": '''
public enum ItemRarity {
    Common = 0,
    Rare = 1,
    Epic = 2,
    Legendary = 3,
    Ascended = 4
}
