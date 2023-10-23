using System;

namespace Day7__Tanks_
{
    public class Tank
    {
        private string tankName;
        private int ammoLvl;
        private int armorLvl;
        private int speedLvl;

        // Конструктор для инициализации параметров танка
        public Tank(string name, Random random)
        {
            tankName = name;
            random = random;
            ammoLvl = random.Next(0, 100);
            armorLvl = random.Next(0, 100);
            speedLvl = random.Next(0, 100);
        }

        // Метод для получения параметров танка в виде строки
        public string GetTankParameters()
        {
            return $"{tankName}: Ammo - {ammoLvl}%, Armor - {armorLvl}%, Maneuverability - {speedLvl}%";
        }
        // Перегрузка оператора '*' (произведение) для определения победы в бою
        public static bool operator *(Tank tank1, Tank tank2)
        {
            int winCriteria = 0;

            // Проверка параметров танков и определение победителя
            if (tank1.ammoLvl > tank2.ammoLvl)
            {
                winCriteria++;
            }
            if (tank1.armorLvl > tank2.armorLvl)
            {
                winCriteria++;
            }
            if (tank1.speedLvl > tank2.speedLvl)
            {
                winCriteria++;
            }

            //Победитель должен превосходить проигравшего по не менее чем двум параметрам
            return winCriteria >= 2;

        }
    }
}
