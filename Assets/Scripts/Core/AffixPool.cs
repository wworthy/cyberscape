public static class AffixPool {
    static List<string> affixList = new List<string> {
        "+5% Crit Chance", "+20 Poison Damage", "+30 Fire Resist", "+10% Move Speed",
        "+12% Magic Find", "+40 Health", "+15% Attack Speed", "+8% Mana Regen"
    };

    public static string GetRandomAffix() {
        return affixList[Random.Range(0, affixList.Count)];
    }
}
'''
}

# Write the files to disk
for path, content in blacksmith_support_scripts.items():
    full_path = base_path / path
    full_path.parent.mkdir(parents=True, exist_ok=True)
    full_path.write_text(content.strip())
