using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedMovement : MonoBehaviour
{
    public GameObject player;
    public float speed = 2.5f;
    public float max_left = 0;
    public float max_right = 2.3f;
    public Vector3 vector = new Vector3(0,0,1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(player.transform.position.z > max_right || player.transform.position.z < max_left){
            vector = - vector;
        }
        player.transform.position  += vector * speed * Time.deltaTime;
        
    }
}
