using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //attributes
    private int maxHealth;
    private int health;
    public int Health
    {
        get { return health; }
        set { health = (value < 0) ? 0 : value; }
    }

    protected Animator anim;
    protected Rigidbody2D rb;
    [SerializeField] HealthBar healthBar;

    //initialize variable

    public void Initialize(int startHealth)
    {
        maxHealth = startHealth;
        Health = startHealth;
        Debug.Log($"{this.name} is initialed Health : {Health}");

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        healthBar = GetComponentInChildren<HealthBar>();
    }
          
    public void TakeDamage(int damage)
    {
        Health -= damage;
        healthBar.UpdateHealthBar(Health, maxHealth);
        Debug.Log($"{this.name} took damage {damage} current health {Health}");

        IsDead();
    }

    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        return false;
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
