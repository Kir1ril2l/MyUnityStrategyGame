using System;
using UnityEngine;
using UnityEngine.UI;

public class MouseResolver : MonoBehaviour
{
    public event Action<ISelectable> OnHoverEnter;
    public event Action<ISelectable> OnHoverExit;
    public event Action<ISelectable> OnSelect;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        /*if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.transform.TryGetComponent(out ISelectable selectable))
            {
                OnHoverEnter?.Invoke(selectable);
            }
        }
        else
        {
      
        }*/

        ISelectable selectable = GetComponentInParent<ISelectable>();
    }
}
