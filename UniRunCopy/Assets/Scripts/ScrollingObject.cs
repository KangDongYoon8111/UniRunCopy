using UnityEngine;

// ���� ������Ʈ�� ��� �������� �����̴� ��ũ��Ʈ
public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; // �̵� �ӵ�

    float timeCheck = 0f;

    void Update()
    {
        // ���� ������Ʈ�� ���� �ӵ��� ��������
        // �����̵��ϴ� ó��

        // �ʴ� speed�� �ӵ��� �������� �����̵�
        transform.Translate(Vector3.left * 
            speed * Time.deltaTime);
    }
}
