using UnityEngine;

public class Collectible : MonoBehaviour
{
    public static int total = 0;

    [SerializeField] private int value = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            total += value;
            Debug.Log("Collecté : +" + value + " / total : " + total);
            Destroy(gameObject);
        }
    }
}