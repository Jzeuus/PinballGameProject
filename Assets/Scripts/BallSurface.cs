using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSurface : MonoBehaviour
{
    public GameObject floor;
    public GameObject pinBall;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0.1f, 0, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position.Set(0,
            floor.transform.position.y + 0.17501f
            , 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bumper")){
            //right now everytime the ball touches the bumper, the score will be update by 10
            //later could change the value to random
            GameManager.Instance.score += 10;
            //update the score


        }
    }

}