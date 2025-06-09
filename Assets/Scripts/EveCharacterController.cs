using UnityEngine;


[RequireComponent(typeof(Animator))]
public class EveCharacterController : MonoBehaviour
{
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _animator.SetBool("Run", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            _animator.SetBool("Run", false);
        }

        _animator.SetFloat("Running", Input.GetAxis("Vertical"));
    }
}
