using TMPro;
using UnityEngine;

public class SelectedUnitPanelController : MonoBehaviour
{
    [SerializeField] private MouseResolver m_mouseResolver;
    [SerializeField] private TMP_Text m_unitNameText;
    [SerializeField] private GameObject m_selectedUnitPanel;

    [Header("Slide Anim Pos")]

    [SerializeField] private Vector2 m_shownPosition;
    [SerializeField] private Vector2 m_hiddenPosition;
    [SerializeField] private float m_animDuration = 0.5f;

    private RectTransform m_rectTransform;

    private void Awake()
    {
        m_rectTransform = m_selectedUnitPanel.GetComponent<RectTransform>();
    }

    private void OnEnable()
    {
        m_mouseResolver.OnHoverEnter += ShowPanel;
        m_mouseResolver.OnHoverExit += HidePanel;
    }

    private void ShowPanel(ISelectable selectable)
    {
        MonoBehaviour s = selectable as MonoBehaviour;
        m_unitNameText.text = s.gameObject.name;
        SlideInOut.SlideIn(m_rectTransform, m_shownPosition, m_animDuration);
        //m_selectedUnitPanel.SetActive(true);
    }
    private void HidePanel(ISelectable selectable)
    {
        SlideInOut.SlideOut(m_rectTransform, m_hiddenPosition, m_animDuration);
        //m_selectedUnitPanel.SetActive(false);
    }
}
