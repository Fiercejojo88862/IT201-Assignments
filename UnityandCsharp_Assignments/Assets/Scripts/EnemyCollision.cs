using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyCollision : MonoBehaviour
{
    public GameObject winTextObject;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Show Game Over text
            if (winTextObject != null)
            {
                winTextObject.SetActive(true);
                TextMeshProUGUI textComp = winTextObject.GetComponent<TextMeshProUGUI>();
                if (textComp != null)
                {
                    textComp.text = "You Lose Dude! SUPER COOKED";
                }
            }

            // Destroy the player
            Destroy(collision.gameObject);
        }
    }
}