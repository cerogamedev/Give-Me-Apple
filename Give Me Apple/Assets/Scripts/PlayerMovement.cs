using UnityEngine;

public class PlayerMovement : MonoBehaviour
{//subject
    public float moveSpeed = 5.0f;

    private void OnEnable()
    {
        FindObjectOfType<InputHandler>().onMoveInput.AddListener(Move);
    }

    private void OnDisable()
    {
        FindObjectOfType<InputHandler>().onMoveInput.RemoveListener(Move);
    }

    void Move(Vector2 moveInput)
    {
        Vector3 movement = new Vector3(moveInput.x, moveInput.y, 0.0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);

    }
}
