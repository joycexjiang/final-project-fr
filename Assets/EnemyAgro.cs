using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgro : MonoBehaviour
{
    [SerializeField] Transform player; 
    [SerializeField] float agroRange; 
    [SerializeField] float moveSpeed; 
    Rigidbody2D rb2d; 

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if(distToPlayer < agroRange)
        {
            // code to chase player
            ChasePlayer(); 
        }
        else{
            // stop chasing player
            StopChasingPlayer();
        }
    }

    private void ChasePlayer()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        rb2d.velocity = direction * moveSpeed;
    }

    private void StopChasingPlayer()
    {
        rb2d.velocity = Vector2.zero;
    }
}
