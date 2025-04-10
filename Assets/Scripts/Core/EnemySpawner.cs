using UnityEngine;
using System.Collections;
//Waves and scaling
public class EnemySpawner : MonoBehaviour {
    public GameObject enemyPrefab;
    public int enemiesPerWave = 3;
    public float spawnRadius = 6f;
    public float timeBetweenWaves = 5f;
    public int totalWaves = 10;

    private int currentWave = 0;
    private float difficultyMultiplier = 1.0f;

    void Start() {
        StartCoroutine(SpawnWaveRoutine());
    }

    IEnumerator SpawnWaveRoutine() {
        while (currentWave < totalWaves) {
            SpawnWave();
            yield return new WaitForSeconds(timeBetweenWaves);
            currentWave++;

            // Increase difficulty every 2 waves
            if (currentWave % 2 == 0) {
                difficultyMultiplier += 1.3f;
            }
        }
    }

    void SpawnWave() {
        Debug.Log($"Spawning Wave {currentWave + 1} (x{difficultyMultiplier:F2})");

        for (int i = 0; i < enemiesPerWave; i++) {
            Vector2 spawnPos = (Vector2)transform.position + Random.insideUnitCircle * spawnRadius;
            GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

            // Scale enemy stats
            EnemyStats stats = enemy.GetComponent<EnemyStats>();
            if (stats != null) {
                stats.health *= difficultyMultiplier;
                stats.poisonTickDamage *= difficultyMultiplier;
            }
        }
    }
}
