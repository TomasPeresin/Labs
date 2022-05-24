using System;

namespace Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio
        {
            get { return m_radio; }
            set
            {
                m_radio = value;
            }
        }

        public double CalcularPerimetro()
        {
            return (6.28 * Radio);
        }

        public double CalcularSuperficie()
        {
            return (3.14 * (Radio * Radio));
        }
    }
}
