using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D platerRB;
    public float fuerzaSalto = 5f;
    private bool tocandoPiso;

    [SerializeField] GameOver deathMenu;


    void Start()
    {
        platerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && tocandoPiso)
        {
            platerRB.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            tocandoPiso = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        tocandoPiso = true;
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            deathMenu.ActiveScreenLose();
        }
    }
}
