using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioClasses5
{
    class Aluno
    {
        public double PrimeiroTrimestre;
        public double SegundoTrimestre;
        public double TerceiroTrimestre;
        public string Nome;


        public double NotaFinal()
        {
            return PrimeiroTrimestre + SegundoTrimestre + TerceiroTrimestre;
        }
        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
