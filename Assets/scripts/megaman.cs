using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class megaman : MonoBehaviour
{
    [SerializeField] float speed;
    Animator Myanimator;


    // Start is called before the first frame update
    void Start()
    {
        Myanimator = GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {
        float mov = Input.GetAxis("Horizontal");

        if (mov != 0)

        {
            Myanimator.SetBool("estar corriendo", true);

            transform.Translate(new Vector2(mov * Time.deltaTime * speed, 0));
        }

        else
        {
            Myanimator.SetBool("estar corriendo", false);
        }



    }
}
