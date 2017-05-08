using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyaleServer
{
    class Player
    {
        // Giving each player a m_Username property. If no name is provided, default to "AnonymousPlayer".
        private string m_Username { get; set; } = "AnonymousPlayer";
        private float m_Health { get; set; } = 100.0f;
        private float m_Speed { get; set; } = 5.0f; // Run speed
        private PlayerPosition m_Position { get; set; } = new PlayerPosition();

        private float m_JumpHeight { get; set; } = 1.0f;
        private bool m_FreeFall { get; set; } = false;
        private DateTime m_LastJumped { get; set; } = DateTime.Now;


        public Player(
            string username,
            float health,
            float speed,
            PlayerPosition position)
        {
            Debug.LogInfo("Constructed new Player object");

            // Setting initial values for Player
            m_Username = username;
            m_Health = health;
            m_Speed = speed;
            m_Position = position;
        }

        private void Jump()
        {
            if (CanJump())
            {
                m_Position.m_PlayerY += m_JumpHeight;
                m_FreeFall = true;
                m_LastJumped = DateTime.Now;
            }
        }

        /// <summary>
        /// Compares current time to player's lastJumped timestamp. (1 second between each jump)
        /// </summary>
        /// <returns>True/false depending on whether or not the player should be able jump.</returns>
        private bool CanJump()
        {
            TimeSpan difference = DateTime.Now - m_LastJumped;
            if (difference.Seconds >= 1 && !m_FreeFall)
                return true;
            return false;
        }

        private bool isInRedZone(float y, float x, float z)
        {
            // TODO: Implement
            return false;
        }
    }
}
