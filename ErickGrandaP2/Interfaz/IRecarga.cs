using ErickGrandaP2.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErickGrandaP2.Interfaz
{
    public interface IRecarga
    {
        IEnumerable<Recarga> DevuelveRecarga();
        Recarga DevuelveRecarga(int telefono);
        bool ActualizarRecarga(Recarga recarga);
        bool CrearRecarga(Recarga recarga);
    }
}
