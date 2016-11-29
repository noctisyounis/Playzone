using UnityEngine;

public enum e_XY
{
    INVALID = -1,
    X,
    Y,
    XY
}

public class Uv : MonoBehaviour
{

    public float m_scrollSpeed = 0.5F;
    public Renderer m_rend;
    public e_XY m_choice;

    void Start()
    {
        m_rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * m_scrollSpeed;
        Vector2 vector2Offset = m_rend.material.GetTextureOffset( "_MainTex" );
        switch (m_choice)
        {
            case e_XY.X:
                vector2Offset.x = offset;
                break;
            case e_XY.Y:
                vector2Offset.y = offset;
                break;
            case e_XY.XY:
                vector2Offset.x = offset;
                vector2Offset.y = offset;
                break;
            default:
                break;
        }
        m_rend.material.SetTextureOffset( "_MainTex", vector2Offset );
    }
}