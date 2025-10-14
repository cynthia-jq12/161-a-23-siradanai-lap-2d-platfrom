using UnityEngine;

public abstract class Character : MonoBehaviour
{
    // attribute
    private int health;
    public int Health { get => health; set => health = (value < 0) ? 0 : value ; }

    protected Animator anim;
    protected Rigidbody2D rb;

    // methods
    public void TakeDamage(int damage) 
    {
        Health -= damage;
        Debug.Log($"{this.name} took damage {damage}. Current Health : {Health}");
    }

    public void IsDead()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log($"{this.name} is dead and destroy !");
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
