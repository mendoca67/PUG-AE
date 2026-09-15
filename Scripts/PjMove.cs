using Unity.VisualScripting;
using UnityEngine;

public class PjMore : MonoBehaviour
{
    private float velocidade = 5.0f;
    public Rigidbody2D rb;
    Vector2 forçaPulo;
    bool podePular = true;

    void Start()
    {
        forçaPulo = new Vector2(0.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxisRaw("Horizontal");
        rb.linearVelocityX = mx * velocidade;
        if (Input.GetKeyDown(KeyCode.Space) && podePular)
        {
            podePular = false;
            rb.AddForce(forçaPulo, ForceMode2D.Impulse);
        }
    }

   private void OnCollisionEnter2D(Collision2D other)
    {
        //Dentro dele nós verificaremos com o que colidimos.
        //Se for um chão,então é hora de pular de novo. Ok?
        if (other.gameObject.CompareTag("Ground"))
        {
            podePular = true;
        }
    }
}

