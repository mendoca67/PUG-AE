using UnityEngine;

public class Moedas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            print("Você pegou uma moeda");
        }
    }
}

            
