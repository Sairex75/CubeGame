using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyScript : MonoBehaviour
{
    [SerializeField] InputField distanceInInputField;
    public void NumbersFromDistanceInputField()
    {
        int number = int.Parse(distanceInInputField.text);
        transform.position = (new Vector3(34.2f, 0.0f, 0.0f) * number);
    }


   
    private void Update()
    {
        NumbersFromDistanceInputField();
    }
    private void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);


    }

}
