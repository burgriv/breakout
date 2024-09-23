using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    public AudioClip bounceClip;
    private void OnCollisionEnter2D(Collision2D collision){
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null){
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
            SoundFXManager.instance.PlaySoundFXClip(bounceClip, transform, 1.0f);
        }
    }
}
