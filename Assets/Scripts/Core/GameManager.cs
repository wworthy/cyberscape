using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public int zeny;

    void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void AddZeny(int amount) {
        zeny += amount;
    }

    public bool SpendZeny(int cost) {
        if (zeny >= cost) {
            zeny -= cost;
            return true;
        }
        return false;
    }
}
