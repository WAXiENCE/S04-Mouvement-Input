using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTranslateExercise1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        

            transform.Translate(Random.Range(0.5f, 5f) * Time.deltaTime, 0, 0 , Space.World);

      


    }
  private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Poisson"))
            {
                Debug.Log("Le poisson 1 est arrivé en premier");
            }
        }

}
