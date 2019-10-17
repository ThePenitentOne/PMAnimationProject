using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform player;
    public float bulletSpeed = 5.0f;
    public float bulletLifetime = 2.0f;
    public float bulletFrequency = 2.0f;
    public float shootDelay = 1.0f;
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {
        //player.position.x;
        //player.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        bulletFrequency += Time.deltaTime;
        if (Input.GetButton("Fire1") && bulletFrequency > shootDelay)
        {
            bulletFrequency = 0;
            GameObject bullet = Instantiate(Prefab, transform.position, Quaternion.identity);
            Vector2 shootDir = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
            Destroy(bullet, bulletLifetime);
        }
    }
}
