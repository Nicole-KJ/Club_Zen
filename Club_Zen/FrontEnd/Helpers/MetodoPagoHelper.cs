using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class MetodoPagoHelper
    {
        private ServiceRepository ServiceRepository;


        public MetodoPagoHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<MetodoPagoViewModel> GetAll()
        {
            List<MetodoPagoViewModel> lista = new List<MetodoPagoViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/metodoPago");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<MetodoPagoViewModel>>(content);
            }

            return lista;

        }




        public MetodoPagoViewModel Get(int id)
        {
            MetodoPagoViewModel MetodoPagoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/metodoPago/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            MetodoPagoViewModel = JsonConvert.DeserializeObject<MetodoPagoViewModel>(content);



            return MetodoPagoViewModel;
        }


        public MetodoPagoViewModel Create(MetodoPagoViewModel metodoPago)
        {


            MetodoPagoViewModel MetodoPagoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/metodoPago/", metodoPago);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            MetodoPagoViewModel = JsonConvert.DeserializeObject<MetodoPagoViewModel>(content);



            return MetodoPagoViewModel;
        }

    }
}