using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] public InputField SpawnTime;

    public Vector3 center;

    public GameObject Obj;
    public GameObject NewObj;
    
  

    void Awake()
    {
      
        int numberSpawn = int.Parse(SpawnTime.text);
      
        StartCoroutine(TimerGreateObject(numberSpawn));
        
    }

    private IEnumerator TimerGreateObject(float numberSpawn)
    {
        yield return new WaitForSeconds(numberSpawn);
        CreateObject();
    }
   
    private void CreateObject()
    {
        
        int numberSpawn = int.Parse(SpawnTime.text);
        NewObj = Instantiate(Obj, transform.position,  Quaternion.Euler(0, 0, 0));
          StartCoroutine(TimerGreateObject(numberSpawn));
      
    }

   
}
