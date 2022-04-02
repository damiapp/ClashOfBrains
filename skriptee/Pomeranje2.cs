using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
	private bool isDragging = false;
	private bool isOverDropZone = false;
	private GameObject dropZone;
	private Vector2 startPosition;

	void Update()
	{
		if (isDragging)
		{
			transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		}
		//ova funkcija radi to i to
		private void OnCollisionExit2D(Collision2D collision)
		{
			isOverDropZone = true;
			dropeZone = collision.gameObject;
		}
		
		private void OnCollisionExit2D(Collision2D collision)
		{
			isOverDropZone = false;
			dropZone = null;
		}

		public void StartDrag()
		{
			startPosition = transform.position;
			isDraging = true;
		}
		public void EndDrag()
		{
			isDraging = false;
			if (isDragingZone)
			{
				transform.SetParent(dropZone.transform, false);
			}
			else
			{
				transform.position = startPosition;
			}
		}
		
	}
}