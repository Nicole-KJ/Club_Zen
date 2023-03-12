using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class RanchitoHelper
    {
        private ServiceRepository ServiceRepository;


        public RanchitoHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<RanchitoViewModel> GetAll()
        {
            List<RanchitoViewModel> lista = new List<RanchitoViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/Ranchito");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<RanchitoViewModel>>(content);
            }

            return lista;

        }




        public RanchitoViewModel Get(int id)
        {
            RanchitoViewModel Ranchito;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/Ranchito/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Ranchito = JsonConvert.DeserializeObject<RanchitoViewModel>(content);



            return Ranchito;
        }


        public RanchitoViewModel Create(RanchitoViewModel ranchito)
        {


            RanchitoViewModel Ranchito;

            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/Ranchito/", ranchito);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Ranchito = JsonConvert.DeserializeObject<RanchitoViewModel>(content);


            return Ranchito;
        }

        public RanchitoViewModel Edit(RanchitoViewModel ranchito)
        {


            RanchitoViewModel Ranchito;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/Ranchito/", ranchito);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Ranchito = JsonConvert.DeserializeObject<RanchitoViewModel>(content);



            return Ranchito;
        }



        public RanchitoViewModel Delete(int id)
        {


            RanchitoViewModel Ranchito;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/Ranchito/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Ranchito = JsonConvert.DeserializeObject<RanchitoViewModel>(content);



            return Ranchito;
        }

    }
}
