using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable {
    // Start is called before the first frame update\
    public Transform chestLid;//�_�ۻ\�l
    public List<GameObject> ChestVFX;// �����S�Ī� prefab
    public bool isOpened = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    public void Interact() {
        if (isOpened) return;
        isOpened = true;
        Debug.Log("�_�c���}");
        if (chestLid != null) {
            chestLid.localRotation = Quaternion.Euler(-120f, 0f, 0f);
            foreach (var vfxPrefab in ChestVFX) {
                if (vfxPrefab != null) {
                    Instantiate(vfxPrefab, chestLid.position + Vector3.up * 0.5f, Quaternion.identity);
                    //�����S�ķ|�ͦ��bChestLid��position�W��
                }
            }
        }
        FirestoreManager.Instance.GetChestGold();

    }

    public string GetPromptMessage() {
        return isOpened ? "" : "�� F �}���_�c";
    }
}
