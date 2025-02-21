using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("WalkJune");
    }
}
