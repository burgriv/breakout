using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;
    public AudioClip bounceClip;

    private void OnCollisionEnter2D(Collision2D collision){
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null){
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
            SoundFXManager.instance.PlaySoundFXClip(bounceClip, transform, 1.0f);
        }
    }
}
