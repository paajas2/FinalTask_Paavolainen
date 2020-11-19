using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator myAnimator;

    public AudioSource jumpBark;

    [SerializeField] private LayerMask platformsLayerMask;

    private BoxCollider2D boxCollider2D;

    private Rigidbody2D rigidbody2d;

    public int jumpHeight;

    public float speed = 1;

    Rigidbody2D rb = null;

    float scaleX = 1;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        scaleX = transform.localScale.x;

    }

    private void Awake()
    {
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = Vector2.right * Input.GetAxis("Horizontal") * speed + Vector2.up * rb.velocity.y;

        //flip the character
        if (Input.GetAxis("Horizontal") != 0)
        {
            myAnimator.SetBool("Walking", true);
            int direction = 1;
            if (Input.GetAxis("Horizontal") < 0)
            {

                direction = -1;

            }

            transform.localScale = new Vector3(scaleX * direction, transform.localScale.y, transform.localScale.z);



        }

        else
        {

            myAnimator.SetBool("Walking", false);

        }


        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
            {
            myAnimator.SetTrigger("Jumping");
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpHeight;
            jumpBark.Play();

            }

            
    }

    private bool IsGrounded()
    {

        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, .1f, platformsLayerMask);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }
}

