using UnityEngine;

public class move : MonoBehaviour
{
    private GameObject thisObj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisObj = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            thisObj.transform.Rotate(0, 360 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            thisObj.transform.Rotate(0, -360 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            thisObj.transform.Rotate(360 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            thisObj.transform.Rotate(-360 * Time.deltaTime,0, 0);
        }
        if (Input.GetKey(KeyCode.W)) {
            thisObj.transform.localScale = new Vector3(thisObj.transform.localScale.x + 40 * Time.deltaTime, thisObj.transform.localScale.y, thisObj.transform.localScale.z);
        }
        if (Input.GetKey(KeyCode.S)) {
            thisObj.transform.localScale = new Vector3(thisObj.transform.localScale.x - 40 * Time.deltaTime, thisObj.transform.localScale.y, thisObj.transform.localScale.z);
        }
    }
}
