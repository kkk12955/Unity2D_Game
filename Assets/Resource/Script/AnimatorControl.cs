using UnityEngine;
public class AnimatorControl : MonoBehaviour
{
    private Animator animator;
    private float speed;
    public float minSpeed;
    public float maxSpeed;
    public float addSpeed;
    void Start()
    {
        animator = GetComponent<Animator>();
        speed = 0;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            speed = Mathf.MoveTowards(speed, maxSpeed, addSpeed * Time.deltaTime);
        else
            speed = Mathf.MoveTowards(speed, minSpeed, addSpeed * Time.deltaTime * 2);
        animator.SetFloat("speed", speed);
    }
}