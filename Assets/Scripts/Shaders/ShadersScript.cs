using UnityEngine;

public class ShadersScript : MonoBehaviour
{
    [SerializeField] private float m_frequency = 1f;
    [SerializeField] private float m_phaseOffset = 0f;
    [SerializeField] private string m_alpha = "_Alpha";

    private Renderer m_render;
    private MaterialPropertyBlock m_propBlock;
    private int m_propID;

    void Start()
    {
        m_render = GetComponent<Renderer>();
        m_propBlock = new MaterialPropertyBlock();
        m_propID = Shader.PropertyToID(m_alpha);
    }

 
    void Update()
    {
        float alpha = (Mathf.Sin(Time.time * m_frequency + m_phaseOffset) + 0.5f + 0.5f);
        //float currAlpha = m_propBlock.GetFloat(m_propID);
        m_propBlock.SetFloat(m_propID, alpha);
        m_render.SetPropertyBlock(m_propBlock);
    }
}