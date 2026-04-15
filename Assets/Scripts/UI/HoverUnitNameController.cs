using TMPro;
using UnityEngine;

public class HoverUnitNameController : MonoBehaviour
{
    [SerializeField] private Camera m_camera;
    [SerializeField] private MouseResolver m_mouseResolver;
    [SerializeField] private TMP_Text m_unitNameText;
    [SerializeField] private GameObject m_selectedUnitHover;
    [SerializeField] protected GameObject m_parentUnit;

    private void OnEnable()
    {
        m_mouseResolver.OnHoverEnter += ShowPanel;
        m_mouseResolver.OnHoverExit += HidePanel;
    }

    private void Awake()
    {
        m_unitNameText.text = m_parentUnit.name;

        if (m_camera == null)
        { 
            m_camera = Camera.main;
        }
    }

    private void LateUpdate()
    {
        Vector3 cameraPos = m_camera.transform.position;
        Vector3 lookPos = new Vector3(cameraPos.x, cameraPos.y, cameraPos.z);
        m_selectedUnitHover.transform.LookAt(lookPos);
    }

    public void ShowPanel(ISelectable selectable)
    {   
        m_selectedUnitHover.SetActive(true);
    }
    public void HidePanel(ISelectable selectable)
    {
        m_selectedUnitHover.SetActive(false);
    }
}

