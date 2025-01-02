using UnityEngine;
using Unity.VisualScripting;

public class SimpleMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Geschwindigkeit des Charakters    
    

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(moveInput * moveSpeed * Time.deltaTime, 0, 0);
        if (moveInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1); // Blick nach rechts
        }
        else if (moveInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1); // Blick nach links
        }




    }

}