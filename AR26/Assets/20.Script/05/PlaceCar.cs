using UnityEngine;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;
using UnityEngine.XR.ARSubsystems;
public class PlaceCar : MonoBehaviour
{
    public GameObject marker;
    public GameObject myCar;
    ARRaycastManager arRayManager;
    List<GameObject> carlist = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        arRayManager = GetComponent<ARRaycastManager>();
        marker.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        DetectGround();
    }
    void DetectGround()
    {
        Vector2 screenCenter = new Vector2(Screen.width/2, Screen.height/2);
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        if(arRayManager.Raycast(screenCenter, hits, TrackableType.Planes))
        {
            marker.SetActive(true);
            marker.transform.position = hits[0].pose.position;
        }
        else
        {
            marker.SetActive(false);
        }
    }

    public void PlaceMyCar()
    {
        if(!marker.activeSelf) return;
        GameObject go = Instantiate(myCar, marker.transform.position, marker.transform.rotation);
        carlist.Add(go);
    }
    public void RemoveLastCar()
    {
        int count = carlist.Count;
        if(count == 0) return;
        GameObject go = carlist[count-1];
        Destroy(go);
        carlist.RemoveAt(count-1);
    }
}
