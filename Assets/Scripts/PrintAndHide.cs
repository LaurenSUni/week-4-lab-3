using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i;
    public Renderer rend;
    public int randomInt;

    // Start is called before the first frame update
    void Start()
    {
      i = 3;
      randomInt = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if ((gameObject.tag == "Red") && (i == 100)) {
          gameObject.SetActive(false);
        }
        else if ((gameObject.tag == "Blue") && (i == randomInt)) {
          rend.enabled = false;
        }
    }
}
