using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{//observer
    public UnityEvent<Vector2> onMoveInput;

    void Update()
    {
        float moveInputX = Input.GetAxis("Horizontal");
        float moveInputY = Input.GetAxis("Vertical");

        Vector2 moveInput = new Vector2(moveInputX, moveInputY);
        onMoveInput.Invoke(moveInput);
    }
}
