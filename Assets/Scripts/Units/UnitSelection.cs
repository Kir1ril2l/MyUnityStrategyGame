using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    [SerializeField] private LayerMask m_layerMask;
    [SerializeField] private Outline m_outline;

    [Header("On hover")]
    [SerializeField][Range(0f, 10f)] private float m_hoverLineWidth;
    [SerializeField] private Color m_hoverLineColor;

    [Header("On select")]
    [SerializeField][Range(0f, 10f)] private float m_selectLineWidth;
    [SerializeField] private Color m_selectLineColor;

    public void OnHoverEnter()
    { 
        m_outline.OutlineWidth = m_hoverLineWidth;
        m_outline.OutlineColor = m_hoverLineColor;
    }

    public void OnHoverExit()
    {
        m_outline.OutlineWidth = 0f;
    }

    public void OnSelect()
    {
        m_outline.OutlineColor = m_selectLineColor;
        m_outline.OutlineWidth = m_selectLineWidth;
    }

    public void OnDeselect()
    {
        m_outline.OutlineWidth = 0f;
    }
}
