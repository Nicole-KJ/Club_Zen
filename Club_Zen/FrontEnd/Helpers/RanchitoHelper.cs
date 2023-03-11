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

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/ranchito");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<RanchitoViewModel>>(content);
            }

            return lista;

        }




        public RanchitoViewModel Get(int id)
        {
            RanchitoViewModel RanchitoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/ranchito/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            RanchitoViewModel = JsonConvert.DeserializeObject<RanchitoViewModel>(content);



            return RanchitoViewModel;
        }


        public RanchitoViewModel Create(RanchitoViewModel ranchito)
        {


            RanchitoViewModel RanchitoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/ranchito/", ranchito);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            RanchitoViewModel = JsonConvert.DeserializeObject<RanchitoViewModel>(content);



            return RanchitoViewModel;
        }

        public RanchitoViewModel Edit(RanchitoViewModel ranchito)
        {


            RanchitoViewModel Ranchito;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/ranchito/", ranchito);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Ranchito = JsonConvert.DeserializeObject<RanchitoViewModel>(content);



            return Ranchito;
        }



        public RanchitoViewModel Delete(int id)
        {


            RanchitoViewModel Ranchito;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/ranchito/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Ranchito = JsonConvert.DeserializeObject<RanchitoViewModel>(content);



            return Ranchito;
        }

    }
}
