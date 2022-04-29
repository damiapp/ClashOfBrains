using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool draggable = true;
    private bool isDragging = false;
    private bool isOverDropZone;
    private DropZone dropZone;
    private Vector2 startPosition;

    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var dropZoneComponent = collision.gameObject.GetComponent<DropZone>();

        if (dropZoneComponent != null) {
            isOverDropZone = true;
            dropZone = dropZoneComponent;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        dropZone = null;
    }

    public void StartDrag()
    {
        if (!draggable) {
            return;
        }

        startPosition = transform.position;
        isDragging = true;
    }
 
    public void EndDrag()
    {
        if (!isDragging) {
            return;
        }

        isDragging = false;
        if (isOverDropZone)
        {
            draggable = false;
            transform.SetParent(dropZone.transform, false); //setParent omogucava transformaciji koja ce da se desi u unity da zadrzi svoju orijentaciju.
            var gameManager = FindObjectOfType<GameManager>();
            //transform.GetComponent<CardView>().GetCard().Apply(gameManager, dropZone.BelongingToPlayer);
            transform.gameObject.SetActive(false);
        }
        else
        {
            transform.position = startPosition;
        }
    }
    //public void  promeniBroj(){
    //promeniBroj();
    //}
}
