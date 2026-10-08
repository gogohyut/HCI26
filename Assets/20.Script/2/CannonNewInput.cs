using UnityEngine;
using UnityEngine.InputSystem;

public class CannonNewInput : MonoBehaviour
{
   public GameObject shellPrefab;
   public Transform fireTrans;
   GameObject bulletPrefab;
    void Update()
    {
     if(Input.GetButtonDown("Fire1"))
     {
         shell = Instantiate(shellPrefab, fireTrans.position, fireTrans.rotation);
         shell.GetComponent<shellcontroller>().shoot(fireTrans.up);
     }
    }
}
