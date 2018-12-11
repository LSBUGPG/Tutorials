using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationscript : MonoBehaviour {

    public GameObject moveDoor; 
    bool whatever = false;
    
    private void Update()
    {
        if (whatever == true)
        {
            StartCoroutine(Wait());
        }
    }
    public void OnTriggerStay(Collider Other)
    {
        if (Other.gameObject.CompareTag("Player")) 
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                whatever = true;
            }
        }
    }
    IEnumerator Wait()
    {
        moveDoor.transform.Rotate(0.0f ,0.0f ,90 * Time.deltaTime);
        yield return new WaitForSeconds(3f);
        whatever = false;
    }
}
