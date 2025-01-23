//There are four errors in this package

using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerCharacter), typeof(PlayerInput))]
public class PlayerCharacter : MonoBehaviour
{
    //Character controller
    private CharacterController Cc => this.GetComponent<CharacterController>();
    //Player input actions
    private PlayerInput playerInput => this.GetComponent<PlayerInput>();
    //Current direction input
    private Vector3 currentDirectionInput;

	private void Update()
	{
        Vector2 moveDirection = new Vector3 (currentDirectionInput.x, 0, currentDirectionInput.z);
        Cc.Move(moveDirection * Time.fixedDeltaTime);
	}

	public void OnMovement(InputAction.CallbackContext context)
    {
        currentDirectionInput = context.ReadValue<Vector2>();
    }
}
