using UnityEngine;

public class DroneController : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _health = 100f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveX, moveY, 0f) * (_speed * Time.deltaTime);
        
        transform.Translate(movement);
    }

    public void TakeDamage(float amount)
    {
        _health -= amount;
        Debug.Log($"Dron ha recibido daño. Batería restante: {_health}");
        
        if (_health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("¡Dron destruido!");
        }
    }
}