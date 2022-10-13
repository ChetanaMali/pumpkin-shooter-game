using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(MultipleSpwan());
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.instance.SetDestForEnemy();
        transform.LookAt(GameManager.instance.enemy.transform);
        
    }
    


    /*IEnumerator MultipleSpwan()
    {
        //GameManager.instance.SpwanEnemy();
        //yield return new WaitForSeconds(5);
        //GameManager.instance.SpwanEnemy();
        for (int i = 0; i < 10; i++)
        {
            GameManager.instance.SpwanEnemy();
            //Instantiate(enemy, new Vector3(Random.Range(100, 190), 0, Random.Range(190, 110)), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }*/
}
