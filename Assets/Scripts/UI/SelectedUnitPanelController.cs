using TMPro;
using UnityEngine;

public class SelectedUnitPanelController : MonoBehaviour
{
    [SerializeField] private MouseResolver m_mouseResolver;
    [SerializeField] private TMP_Text m_unitNameText;
    [SerializeField] private GameObject m_selectedUnitPanel;

    private void OnEnable()
    {
        m_mouseResolver.OnHoverEnter += ShowPanel;
        m_mouseResolver.OnHoverExit += HidePanel;
    }

    private void ShowPanel(ISelectable selectable)
    {
        MonoBehaviour s = selectable as MonoBehaviour;
        m_unitNameText.text = s.gameObject.name;
        m_selectedUnitPanel.SetActive(true);
    }
    private void HidePanel(ISelectable selectable)
    {
        m_selectedUnitPanel.SetActive(false);
    }
}
