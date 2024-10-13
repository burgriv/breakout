using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private int hitsToDestroy = 1;
    [SerializeField] private bool isDestructible = true;
    [SerializeField] private int score = 100;

    private GameManager gameManager;

    public void Start(){
        gameManager = FindObjectOfType<GameManager>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision2D){
        if (isDestructible){
            hitsToDestroy--;

            if (hitsToDestroy == 0){
                gameManager.BlockDestroyed(this.score);
                gameObject.SetActive(false);
            }
        }
    }
}
