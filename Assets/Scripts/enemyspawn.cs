using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    public GameObject enemy;
    public int xpos;
    public int zpos;
    public int waittime;
    public int enemycount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemycount < 10)
        {
            xpos = Random.Range(100, 190);
            zpos = Random.Range(190, 110);
            Instantiate(enemy, new Vector3(xpos, 0.6f, zpos), Quaternion.identity);
            yield return new WaitForSeconds(waittime);
            enemycount += 1;
        }
    }
}