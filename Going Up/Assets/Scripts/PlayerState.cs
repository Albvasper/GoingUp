using UnityEngine;

public class PlayerState : MonoBehaviour {   

    [field: SerializeField] public PlayerMovementState currentPlayerMovementState { get; private set;} = PlayerMovementState.idling;
    public enum PlayerMovementState {
        idling = 0,
        walk = 1,
        running = 2,
        spriting = 3,
        jumping = 4,
        falling = 5,
        strafing = 6,

    }
}
