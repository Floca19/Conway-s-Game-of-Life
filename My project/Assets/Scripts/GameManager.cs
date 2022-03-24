using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class GameManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonUp(0)&&UIManager.current.IsDragging)
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                if (raycastHit.transform != null)
                {
                    switch (UIManager.current.predefinedShape)
                    {
                        case DrawPredefined.stable:
                            raycastHit.transform.gameObject.GetComponent<Cell>().DrawStable();
                            break;

                        case DrawPredefined.Oscillator:
                            raycastHit.transform.gameObject.GetComponent<Cell>().DrawOscillator();
                            break;

                        case DrawPredefined.spaceship:
                            raycastHit.transform.gameObject.GetComponent<Cell>().DrawGlider();
                            break;
                        default:
                            return;
                            break;
                    }
                }
            }
        }
    }
}
