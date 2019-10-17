using UnityEngine;

public class EnemyAnimationControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.Normalize();
        GetComponent<Animator>().SetFloat("x", velocity.x);
        GetComponent<Animator>().SetFloat("y", velocity.y);
    }
}
