using UnityEngine;
using System.Collections;

public class MouseSelect
{
    // Most likely use a courotine
    public delegate void ClickEvent(GameObject go);
    public ClickEvent OnClick;

    void Update()
    {
        // create the ray
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // Ray hit
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.Log(hit.transform.name);
            // if we click on ze mouse
            if (Input.GetMouseButtonUp(0))
            {
                // notify the event
                Debug.Log("Event Trigger on " + hit.transform.name);
                if (OnClick != null)
                    OnClick(hit.transform.gameObject);
            }
        }
    }
}
