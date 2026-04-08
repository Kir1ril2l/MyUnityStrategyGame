using TMPro;
using UnityEngine;

public class HoverUnitNameController : MonoBehaviour
{
    [SerializeField] private MouseResolver m_mouseResolver;
    [SerializeField] private TMP_Text m_unitNameText;
    [SerializeField] private GameObject m_selectedUnitHover;
    [SerializeField] protected GameObject m_parentUnit;

    private void OnEnable()
    {
      //  m_mouseResolver.OnHoverEnter += ShowPanel;
        //m_mouseResolver.OnHoverExit += HidePanel;
    }

    private void Awake()
    {
        m_unitNameText.text = m_parentUnit.name;
    }

    private void ShowPanel(ISelectable selectable)
    {   
        m_selectedUnitHover.SetActive(true);
    }
    private void HidePanel(ISelectable selectable)
    {
        m_selectedUnitHover.SetActive(false);
    }
}

