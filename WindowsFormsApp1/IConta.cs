using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IConta
    {
        void Sacar(double valor);
        double Calcular();
    }
}
