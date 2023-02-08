using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _coinRotationSpeed;
    void Update()
    {
        transform.Rotate(0, _coinRotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().AddOneCoin();
        Destroy(gameObject);
    }
}
