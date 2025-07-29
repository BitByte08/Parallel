using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    private string[] weapons = { "Sword", "Scythe", "Bow", "Hook" };
    private int currentWeaponIndex = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentWeaponIndex = (currentWeaponIndex + 1) % weapons.Length;
            Debug.Log("Current Weapon: " + weapons[currentWeaponIndex]);
            // TODO: 무기 변경 관련 시각/효과 처리
        }
    }

    public string GetCurrentWeapon()
    {
        return weapons[currentWeaponIndex];
    }
}
