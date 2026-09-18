using UnityEngine;
using UnityEngine.InputSystem; //[cite: 1]

public class asteiroide : MonoBehaviour
{
    void Update()
    {
        // Verifica o clique do mouse[cite: 1]
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            // Pega a posição do clique e converte para coordenadas 2D do mundo[cite: 1]
            Vector2 mousePos = Mouse.current.position.value; //[cite: 1]
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos); //[cite: 1]

            // Direção do objeto até o clique do mouse[cite: 1]
            Vector2 direction = (worldPos - (Vector2)transform.position).normalized; //[cite: 1]

            // Lança o Raycast em 2D[cite: 1]
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction); //[cite: 1]

            // Desenha a linha amarela de teste no painel Scene[cite: 1]
            Debug.DrawRay(transform.position, direction * 5f, Color.yellow); //[cite: 1]

            if (hit.collider != null)
            {
                Debug.Log("Acertou o objeto 2D: " + hit.collider.name);
            }
        }
    }
}