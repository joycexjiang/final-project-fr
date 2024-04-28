using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed;
    private bool isMoving;
    private UnityEngine.Vector2 inputDirection;


    // Update is called once per frame
    private void Update()
    {
        if (!isMoving)
        {
            inputDirection.x = Input.GetAxisRaw("Horizontal");
            inputDirection.y = Input.GetAxisRaw("Vertical");

            if (inputDirection != UnityEngine.Vector2.zero)
            {
                var targetPosition = transform.position;
                targetPosition.x += inputDirection.x;
                targetPosition.y += inputDirection.y;

                StartCoroutine(Move(targetPosition));
            }
        }
    }

    IEnumerator Move(UnityEngine.Vector2 targetPosition)
    {
        UnityEngine.Vector3 targetPosition3D = new UnityEngine.Vector3(targetPosition.x, targetPosition.y, 0);

        isMoving = true;

        while ((targetPosition3D - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition3D, movementSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPosition3D;

        isMoving = false;
    }

}
