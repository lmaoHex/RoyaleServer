using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyaleServer
{
    class PlayerPosition
    {
        public float m_Pitch { get; set; } = 0.0f;
        public float m_Yaw { get; set; } = 0.0f;

        public float m_PlayerX { get; set; } = 0.0f;
        public float m_PlayerY { get; set; } = 0.0f;
        public float m_PlayerZ { get; set; } = 0.0f;

        public PlayerPosition(float x = 0.0f, float y = 0.0f, float z = 0.0f)
        {
            Debug.LogInfo("Constructed new PlayerPosition object");

            // Setting initial location for Player's position
            m_PlayerX = x;
            m_PlayerY = y;
            m_PlayerZ = z;
        }

        public void ChangePitch(float newPitch)
        {
            // TODO: Implement
        }

        public void ChangeYaw(float newYaw)
        {
            // TODO: Implement
        }
    }
}
