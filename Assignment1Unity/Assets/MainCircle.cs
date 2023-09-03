using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCircle : MonoBehaviour
{
    [SerializeField] private GameObject circlePrefab;
    [SerializeField] private float speed = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Get the mouse position in world coordinates
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        // Create a new circle instance
        GameObject circleInstance = Instantiate(circlePrefab, transform.position, Quaternion.identity);

        // Calculate the direction to shoot the circle
        Vector3 direction = (mousePosition - transform.position).normalized;

        // Set the velocity of the circle
        circleInstance.GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
