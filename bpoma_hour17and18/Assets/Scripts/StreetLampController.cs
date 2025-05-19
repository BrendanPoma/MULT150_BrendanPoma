using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetLampController : MonoBehaviour
{
    private Animator animator;

    private const string COLOR_PARAM = "ColorChange";
    private const string SCALE_PARAM = "ScaleAnimation";
    private const string SPIN_PARAM = "Spin";
    private const string HOVER_PARAM = "Hover";

    void Start()
    {
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            Debug.LogError("Animator component not found on this object");
            animator = gameObject.AddComponent<Animator>();
        }

        Debug.Log("Street Lamp Controller initialized. Press A, D, S, or W to trigger animations.");
    }

    void Update()
    {
        ResetParameters();

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool(COLOR_PARAM, true);
            Debug.Log("Color change animation triggered");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool(SCALE_PARAM, true);
            Debug.Log("Scale animation triggered");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool(SPIN_PARAM, true);
            Debug.Log("Spin animation triggered");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool(HOVER_PARAM, true);
            Debug.Log("Hover animation triggered");
        }
    }

    private void ResetParameters()
    {
        if (animator == null) return;

        animator.SetBool(COLOR_PARAM, false);
        animator.SetBool(SCALE_PARAM, false);
        animator.SetBool(SPIN_PARAM, false);
        animator.SetBool(HOVER_PARAM, false);
    }
}