using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyaleServer
{
    class PlayerPosition
    {
        private float m_Pitch { get; set; } = 0.0f;
        private float m_Yaw { get; set; } = 0.0f;

        private float m_PlayerX { get; set; } = 0.0f;
        private float m_PlayerY { get; set; } = 0.0f;
        private float m_PlayerZ { get; set; } = 0.0f;

        public PlayerPosition()
        {
            Debug.LogInfo("Constructed new PlayerPosition object");
        }

        public static bool isInRedZone(float y, float x, float z)
        {
            // TODO: Implement
            return false;
        }
    }
}
