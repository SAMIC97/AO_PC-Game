using UnityEngine;

public class InputManager : MonoBehaviour
{
    private CharacterMotor motor;
    private CameraHandler cameraHandler;

    private PlayerHandler pHandler;

    static Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Awake()
    {
        //Get a reference to the character motor component.
        motor = GetComponent<CharacterMotor>();

        //Get a reference to the camera handler component.
        cameraHandler = GetComponentInChildren<CameraHandler>();

        //Get a reference to the player handler.
        pHandler = Manager.Instance.PlayerHandler;
    }

    private void Update()
    {
        pHandler.Horizontal = Input.GetAxisRaw("Horizontal");
        pHandler.Vertical = Input.GetAxisRaw("Vertical");

        //Toggle third person mode when pressing the key.
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            anim.SetTrigger("Attack");

            //Toggle the value.
            //pHandler.ThirdPerson = !pHandler.ThirdPerson;

            //Event for view change.
            //cameraHandler.OnViewChange();
        }

        //Toggle crouching when pressing the key.
        if (Input.GetKeyDown(KeyCode.C))
        {
            //Check if we can stop crouching if we need to, or just crouch.
            if (pHandler.IsCrouched && motor.CanUncrouch() || pHandler.IsCrouched == false)
            {
                //Toggle the value.
                pHandler.IsCrouched = !pHandler.IsCrouched;

                //Let the character motor know we changed the state.
                motor.OnToggleCrouch();

                //Change the camera view.
                cameraHandler.OnViewChange();
            }
        }

        //If the player is standing.
        if (pHandler.IsCrouched == false)
        {
            //Jump & Run Inputs.
            pHandler.Jump = Input.GetKeyDown(KeyCode.Space);
            pHandler.IsRunning = Input.GetKey(KeyCode.LeftShift);
        }

        pHandler.MouseX = Input.GetAxisRaw("Mouse X");
        pHandler.MouseY = Input.GetAxisRaw("Mouse Y");
    }
}