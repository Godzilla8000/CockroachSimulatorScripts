using UnityEngine;

public class Player : MonoBehaviour
{
    private const int GRAVITY = 9;
    private const int LEGS_PER_SIDE = 3;
    private const int SPEED = 10;
    private const int TURN = 3;
    private const int JUMP_FORCE = 30;
    private int leftLegs = 3;
    private int rightLegs = 3;

    private enum states {standing, walking, jumping, falling};
    private states current_state = states.standing;

     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
