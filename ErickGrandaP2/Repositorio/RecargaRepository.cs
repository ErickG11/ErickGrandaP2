using ErickGrandaP2.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErickGrandaP2.Modelos;
using Newtonsoft.Json;

namespace ErickGrandaP2.Repositorio
{
    public class RecargaRepository : IRecarga
    {
        private string _filename = Path.Combine(FileSystem.AppDataDirectory, "erecargas.txt");

        public bool ActualizarRecarga(Recarga recarga)
        {
            throw new NotImplementedException();
        }

        public bool CrearRecarga(Recarga recarga)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(recarga);
                File.WriteAllText(_filename, json_data);
                return true;
            }
            catch (Exception)
            { 
                throw;
            }
            
            
        }

        public IEnumerable<Recarga> DevuelveRecarga()
        {
            throw new NotImplementedException();
        }

        public Recarga DevuelveRecarga(int telefono)
        {
            Recarga recarga = new Recarga();

            if (File.Exists(_filename))
            {
                string json_data = File.ReadAllText(_filename);
                recarga = JsonConvert.DeserializeObject<Recarga>(json_data);
            }
            return recarga;
        }
    }
}
