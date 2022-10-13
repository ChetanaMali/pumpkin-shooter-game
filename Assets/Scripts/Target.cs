using UnityEngine;

public class Target : MonoBehaviour
{
    Score score;
    public float health = 50f;
    public GameObject enemy;
    
    public void TakeDamage(float amount)
    {
        health -= amount;
        
        if (health <= 0f)
        {
            updscore();
            Die();
            
        }
    }
    public void updscore()
    {
        Score score = FindObjectOfType<Score>();
        score.scoreupd();
    }
    void Die()
    {
        Destroy(enemy);
    }

}