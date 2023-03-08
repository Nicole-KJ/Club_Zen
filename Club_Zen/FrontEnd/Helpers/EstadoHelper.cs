using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class EstadoHelper
    {
        private ServiceRepository ServiceRepository;


        public EstadoHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<EstadoViewModel> GetAll()
        {
            List<EstadoViewModel> lista = new List<EstadoViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/estado");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<EstadoViewModel>>(content);
            }

            return lista;

        }




        public EstadoViewModel Get(int id)
        {
            EstadoViewModel EstadoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/estado/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            EstadoViewModel = JsonConvert.DeserializeObject<EstadoViewModel>(content);



            return EstadoViewModel;
        }


        public EstadoViewModel Create(EstadoViewModel estado)
        {


            EstadoViewModel EstadoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/estado/", estado);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            EstadoViewModel = JsonConvert.DeserializeObject<EstadoViewModel>(content);



            return EstadoViewModel;
        }

    }
}