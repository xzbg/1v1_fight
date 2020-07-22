using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soma : MonoBehaviour
{
    public Role role;
    public string motion;
    public Animator animator;
    public Controller controller;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play(string ani)
    {
        motion = ani;
        if (animator != null)
            animator.Play(ani, 0, 0);
    }
}
