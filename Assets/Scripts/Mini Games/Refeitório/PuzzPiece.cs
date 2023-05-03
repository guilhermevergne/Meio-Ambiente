using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzPiece : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip pickupclip, dropclip;

    private bool Isdrag;

    private Vector2 offset, originalPos;

    private void Awake()
    {
        originalPos = transform.position;
    }

    private void Update()
    {
        if(!Isdrag) return;

        var mousePosition = getMousePos();

        transform.position = mousePosition - offset;
    }

    private void OnMouseDown()
    {
        Isdrag = true;
        source.PlayOneShot(pickupclip);
        offset = getMousePos() - (Vector2)transform.position;

    }

    private void OnMouseUp()
    {
        transform.position = originalPos;
        Isdrag = false;
        source.PlayOneShot(dropclip);
    }

    Vector2 getMousePos()
    {
        return (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

	}
}
