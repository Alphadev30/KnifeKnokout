using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knife : MonoBehaviour
{
    public int speed = 3;
    private Rigidbody myBody;
    private bool onWood;

    private KnifeSpawnner knifespawn;

    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
        knifespawn = GameObject.Find("KnifeSpawn").GetComponent<KnifeSpawnner>();
    }
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !onWood)
        {
            myBody.velocity = new Vector3(0f, speed, 0f);
        }
    }

    void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Wood")
        {
            gameObject.transform.SetParent(target.transform);
            myBody.velocity = Vector3.zero;
            onWood = true;
            myBody.detectCollisions = false;

            knifespawn.SpawnKnife();
            knifespawn.IncrementScore();

        }

        if(target.tag == "Knife")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);

        }
    }
}
