using System;
using UnityEngine;

public class TriggerComponent : MonoBehaviour
{
    private int count;
    private GameObject target;
    private Action onChange;

    public bool IsFind => count > 0;
    public GameObject Target => target;


    public void AddAction(Action action)
    {
        onChange += action;
    }

    public void RemoveAction(Action action)
    {
        onChange -= action;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.CompareTag(Tags.enemy) == false) return;

        count++;
        target = collision.gameObject;
        onChange?.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //if (collision.CompareTag(Tags.enemy) == false) return;
        if(count == 0) return;
        
        count--;
        onChange?.Invoke();
    }
}
