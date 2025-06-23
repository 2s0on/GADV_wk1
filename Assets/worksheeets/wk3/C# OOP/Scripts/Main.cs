using JetBrains.Annotations;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // pt 1, making a class; controling projectile firing speed
    public class Projectile
    {
        private float speed;

        public Projectile(float startSpeed)
        {
            speed = startSpeed;
        }

        // encapsulation: Fire() method controls how the projectile is fired
        public void Fire()
        {
            if (speed > 0)
            {
                Debug.Log("Firing projectiles at speed: " + speed);
            }
            else
            {
                Debug.Log("Cannot fire: speed too low");
                AutoFire(); //called when speed is 0
            }
        }

        private void AutoFire()
        {
            speed = 100;
            Debug.Log("Speed was zero. AutoFire set speed to 100 and launched!");
        }

    }

    // pt 2, encalpsulation: using player's health
    public class Player
    {
        private int health; //makes health private to control access

        public Player(int startingHealth)
        {
            health = startingHealth;
        }

        public void TakeDamage(int damage)
        {
            if (health <= 0)
            {
                Debug.Log("Player is already dead. Cannot take more damage.");
            }
            else if (health - damage < 0)
            {
                Debug.Log("Player took fatal damage. Health is now 0.");
                health = 0; // Player dies
            }
            else
            {
                health -= damage;
                Debug.Log("Player took damage. Current health: " + health);
            }
        }

        // just set health back to max (also because you're returning something, it cannot be void)
        public int GetHealth()
        {
            return health;

        }

    }

    public class ScoreTracker
    {
        private int score;

        public void ResetScore()
        {
            score = 0;
        }

        public void AddScore(int points)
        {
            if (points < 0)
            {
                Debug.Log("Cannot add negative points.");
            }
            else
            {
                score += points;
                Debug.Log("Score added. Current score: " + score);
            }
        }

    }

    // pt 3, inheritance and overriding: chests
    public class TreasureChest
    {
        // overriding is only possible with virtual methods
        public virtual void Unlock()
        {
            Debug.Log("You unlock the treasure chest.");
        }

        // method overloading: same method name, different parameters
        public void Unlock(bool hasToken)
        {
            if (hasToken)
            {
                Debug.Log("You unlocked the treasure chest with a token and recieved bonus treasure!");
            }
            else
            {
                Debug.Log("You unlocked the chest normally.");
            }
        }

        public void Shake()
        {
            Debug.Log("You hear something rattle inside the chest.");
        }

    }

    // AncientChest is a child class of TreasureChest - it inherits the unlock and shake methods
    // but it overrides the Unlock method with the new implementation
    public class AncientChest : TreasureChest
     {
        public override void Unlock()
        {
            Debug.Log("You unlock the ancient chest with an ancient key.");
        }
     }

     public class MagicChest : TreasureChest
     {
        public override void Unlock()
        {
            Debug.Log("You cast a spell to unlock the magic chest.");
        }
     }
}
