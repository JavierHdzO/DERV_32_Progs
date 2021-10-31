using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateHealth : MonoBehaviour
{
    public GameObject Health;
    private int xPos;
    private int zPos;
    private int yPos;
    public int enemyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 1)
        {
            xPos = (int)Random.Range(transform.position.x + 35, transform.position.x + 100);
            zPos = (int)Random.Range(transform.position.z + 35, transform.position.z + 120);
            yPos = (int)Random.Range(transform.position.y +10, transform.position.z + 12);
            Instantiate(Health, new Vector3(xPos, yPos, zPos), Health.transform.rotation);
            enemyCount += 1;
            yield return new WaitForSeconds(10f);
            
        }
    }
}
