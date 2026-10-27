using UnityEngine;

[RequireComponent(typeof(SelfDestruct))]
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float _damage = 25f;
    [SerializeField] private float _speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.left * (_speed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        DroneController drone = other.GetComponent<DroneController>();
        
        if (drone != null)
        {
            drone.TakeDamage(_damage);
            Destroy(gameObject); 
        }
    }
}