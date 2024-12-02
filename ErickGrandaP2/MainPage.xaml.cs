using ErickGrandaP2.Interfaz;
using ErickGrandaP2.Modelos;
using ErickGrandaP2.Repositorio;

namespace ErickGrandaP2
{
    public partial class MainPage : ContentPage
    {
        RecargaRepository _recargaRepository;
        Recarga recarga = new Recarga();

        public MainPage()
        {
            _recargaRepository = new RecargaRepository();
            InitializeComponent();

            recarga = _recargaRepository.DevuelveRecarga(1);
            BindingContext = recarga;



        }

        private void OnclickedRecarga(object sender, EventArgs e) 
        {
            Recarga recarga = new Recarga
            {
                Nombre = "Erick",
                Telefono = 0994731960
            };
            bool guardar_recarga = _recargaRepository.CrearRecarga(recarga);
        
        }

    }
}
