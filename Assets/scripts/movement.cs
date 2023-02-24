using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour

{
    public GameObject obs;
    public GameObject won;
    public GameObject rot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        float moveSpeed = 10;
        //Define the speed at which the object moves.

        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        float verticalInput = Input.GetAxis("Vertical");
        //Get the value of the Vertical input axis.

        transform.Translate(new Vector3(horizontalInput, 0, verticalInput*-1) * moveSpeed * Time.deltaTime);
        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.

        rot.transform.Rotate(new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime);

        if (Input.GetKey("space")){
            transform.Translate(new Vector3(0, 1, 0) * 30 * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "obstacle")
        {

            Destroy(this.gameObject);

        }
        if (collision.gameObject.tag == "collect")
        {

            Destroy(obs);
            won.SetActive(true);
        }
    }
    }
