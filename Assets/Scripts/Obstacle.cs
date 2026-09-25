using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float minSize = 0.5f;
    public float maxSine = 2.0f;
    Rigidbody2D rb;
    public float minSpeed = 50f;
    public float maxSpeed = 150f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(0.5f, 2.0f);
        transform.localScale = new Vector3(randomSize, randomSize, 1);
        rb = GetComponent<Rigidbody2D>();

        float randmSpeed = Random.Range(minSpeed, maxSpeed);
        Vector2 randimDirection = Random.insideUnitCircle;
        rb.AddForce(randimDirection * randmSpeed);

    }

    void Update()
    {
        
    }
}
