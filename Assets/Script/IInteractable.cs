using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable {
    void Interact(); // �Ҧ��i���ʪ��󳣻ݹ�@�o�Ӥ�k
    string GetPromptMessage(); // ����UI�n��ܪ���r
}
