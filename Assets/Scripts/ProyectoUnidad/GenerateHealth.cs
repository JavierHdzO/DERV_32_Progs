using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateHealth : MonoBehaviour
{
    public GameObject Health;
    private int xPos;
    private int zPos;
    private int yPos;
    public int healths = 0;
    GameObject Botiquin;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        healths = 0;
        PlayerPrefs.SetInt("health", 0);
        StartCoroutine(EnemyDrop());
    }

    private void FixedUpdate()
    {
        healths = PlayerPrefs.GetInt("health");
        if (Botiquin != null)
        {   
            distance = Vector3.Distance(gameObject.transform.position, Botiquin.transform.position);
            Debug.Log(distance.ToString());
            if (distance > 50)
            {
                healths--;
                PlayerPrefs.SetInt("health", healths);
                Destroy(Botiquin);
            }
        }
    }

    IEnumerator EnemyDrop()
    {
        while (healths < 3)
        {
            xPos = (int)Random.Range(transform.position.x + 15, transform.position.x + 50);
            zPos = (int)Random.Range(transform.position.z + 15, transform.position.z + 50);
            yPos = (int) transform.position.y + 30;
            Botiquin = Instantiate(Health, new Vector3(xPos, yPos, zPos), Health.transform.rotation);
            healths = PlayerPrefs.GetInt("health");
            healths++;
            PlayerPrefs.SetInt("health", healths);
            Debug.Log("Botiquines "+ healths);
            yield return new WaitForSeconds(45f);
            
        }
    }
}
