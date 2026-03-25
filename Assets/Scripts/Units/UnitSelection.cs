using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    [SerializeField] private LayerMask m_layerMask;
    [SerializeField] private Outline m_outline;

    [Header("On hover")]
    [SerializeField][Range(0f, 10f)] private float m_hoverLineWidth;
    [SerializeField] private Color m_hoverLineColor;

    public void OnHoverEnter()
    { 
        m_outline.OutlineWidth = m_hoverLineWidth;
        m_outline.OutlineColor = m_hoverLineColor;
    }
}
