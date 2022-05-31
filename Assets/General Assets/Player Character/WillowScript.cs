using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WillowScript : MonoBehaviour
{
   [System.Serializable]
   public struct Stats
   {
        [Tooltip("How much health the player has.")]
        public int maxHealth;

        [Tooltip("How much health the player has.")]
        public int currentHealth;
        
        [Tooltip("How fast the player runs.")]
        public float speed;

        [Tooltip("How high the player jumps.")]
        public float jumpForce;

        [Tooltip("Whether the player is allowed to move or not.")]
        public bool canMove;

        [Tooltip("When the player is allowed to jump or not.")]
        public bool canJump;
   }
   
   public Stats playerStats;
   
   private float movementX;
   private Rigidbody rb;
   
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        movementX = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movementX * playerStats.speed, rb.velocity.y);
    }
}
