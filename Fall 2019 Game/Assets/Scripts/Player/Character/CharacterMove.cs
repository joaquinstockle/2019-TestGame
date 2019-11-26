using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.UI;


public class CharacterMove : MonoBehaviour
{
    public CharacterController characterController;

    public float walk = 10f, jumpSpeed = 10f, sprint = 16f;
    public float speeds;
    public float gravity = -1f;
    private Vector3 velocity;

    public Image staminaBar;
    public static float stamina;
    public bool fatigue;
    public float stamRes;
    public bool full;
    public GameObject fullBar;


    private void Start()
    {
        stamina = 1f;
        fatigue = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && !fatigue)
        {
            speeds = sprint;
            stamRes = -1;
            fullBar.SetActive(true);

        }
        else
        {
            speeds = walk;
            fullBar.SetActive(true);
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speeds * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity);

        if (characterController.isGrounded)
        {
            velocity.y = 0f;

            if (Input.GetButton("Jump"))
            {
                velocity.y = jumpSpeed * Time.deltaTime;
            }

        }

        staminaBar.fillAmount = stamina;
        stamina += stamRes * Time.deltaTime;

        if (!fatigue)
            stamRes = .3f;
        if (fatigue)
            stamRes = .15f;

        if (stamina < 0)
            stamina = 0;
        if (stamina > 1)
            stamina = 1;

        if (stamina <= 0)
            fatigue = true;
        if (stamina >= 1)
        {
            fatigue = false;
            full = true;
        }

        if (stamina < 1)
            full = false;

        if (full)
            fullBar.SetActive(false);



    }
}