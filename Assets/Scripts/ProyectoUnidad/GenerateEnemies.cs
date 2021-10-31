using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    private int xPos;
    private int zPos;
    public int enemyCount = 3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
        PlayerPrefs.SetInt("Zombies",enemyCount);
    }

    IEnumerator EnemyDrop()
    {
        while (true)
        {
            if (enemyCount < 10)
            {
                xPos = (int)Random.Range(transform.position.x + 10, transform.position.x + 20);
                zPos = (int)Random.Range(transform.position.z + 10, transform.position.z + 25);
                Instantiate(theEnemy, new Vector3(xPos, 40, zPos), theEnemy.transform.rotation);
                enemyCount += 1;
                enemyCount = PlayerPrefs.GetInt("Zombies");
                enemyCount += 1;
                PlayerPrefs.SetInt("Zombies",enemyCount);
                yield return new WaitForSeconds(10f);
            }
            
        }
    }
}
