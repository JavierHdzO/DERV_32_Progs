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
        enemyCount = 0;
        PlayerPrefs.SetInt("zombies", 0);
        StartCoroutine(EnemyDrop());
    }

    public void FixedUpdate()
    {
        enemyCount = PlayerPrefs.GetInt("zombies");
    }



    IEnumerator EnemyDrop()
    {
        while (enemyCount <= 4)
        {


            xPos = (int)Random.Range(transform.position.x + 10, transform.position.x + 15);
            zPos = (int)Random.Range(transform.position.z + 10, transform.position.z + 15);
            Instantiate(theEnemy, new Vector3(xPos, 40, zPos), theEnemy.transform.rotation);
            enemyCount = PlayerPrefs.GetInt("zombies");
            enemyCount++;
            PlayerPrefs.SetInt("zombies", enemyCount);
            yield return new WaitForSeconds(10f);

        }
    }
}
