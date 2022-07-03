using System;

namespace ProjetoCinemaCSharp.Classes
{
    public abstract class AMolde
    {
        public abstract void Data(string mesInicio, int diaInicioMes1, int diaFimMes1, string mesFim, int diaInicioMes2, int diaFimMes2);
        public abstract void TresD();
        public abstract void Horario();
        public abstract void ValorIngresso();
        public abstract void Pagamento();
    }
}