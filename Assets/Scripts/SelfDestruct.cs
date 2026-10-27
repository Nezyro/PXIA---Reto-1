using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField] private float _lifetime = 4f;

    void Start()
    {
        Destroy(gameObject, _lifetime);
    }
}