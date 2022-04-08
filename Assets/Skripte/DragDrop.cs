using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool isDragging = false;
    private bool isOverDropZone;
    private GameObject dropZone;
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
        if(collision.gameObject.tag=="DropZona"){
            isOverDropZone = true;
            dropZone = collision.gameObject;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        dropZone = null;
    }

    public void StartDrag()
    {
        startPosition = transform.position;
        isDragging = true;
    }
 
    public void EndDrag()
    {
        isDragging = false;
        if (isOverDropZone)
        {
            transform.SetParent(dropZone.transform, false); //setParent omogucava transformaciji koja ce da se desi u unity da zadrzi svoju orijentaciju.
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
