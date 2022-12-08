using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSequencerWithPlayer : MonoBehaviour
{
    public GameObject matchThis;
   // private Vector3 offset;
    //private float initialX;
    private float initialY;
   // private float initialZ;
    private float offsetX;
    private float offsetY;
    private float offsetZ;


    //private Vector3 newvec = new Vector3(0.0f, 1.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
        initialY = gameObject.transform.position.y;
        offsetX = gameObject.transform.position.x - matchThis.transform.position.x;
        offsetY = gameObject.transform.position.y - matchThis.transform.position.y;
        offsetZ = gameObject.transform.position.z - matchThis.transform.position.z;

      //  offset = gameObject.transform.position - matchThis.transform.position;

        //Debug.Log("BEGINNING");
        //Debug.Log("OFFSET"+ offset);
        //Debug.Log("GAMEPOS" + gameObject.transform.position);
        //Debug.Log("MATCH" + matchThis.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        matchThis.transform.position = new Vector3(gameObject.transform.position.x - offsetX, initialY - offsetY, gameObject.transform.position.z - offsetZ); ;
        //matchThis.transform.eulerAngles = new Vector3(
        //    matchThis.transform.eulerAngles.x,
        //    gameObject.transform.eulerAngles.y,
        //    matchThis.transform.eulerAngles.z);


        // matchThis.transform.position = gameObject.transform.position - offset;
        //Debug.Log("END");
        // Debug.Log("OFFSET" + offset);
        // Debug.Log("GAMEPOS" + gameObject.transform.position);
        // Debug.Log("MATCH" + matchThis.transform.position);
    }
}
// https://answers.unity.com/questions/1521689/how-to-make-an-object-attach-to-or-follow-the-play.html 