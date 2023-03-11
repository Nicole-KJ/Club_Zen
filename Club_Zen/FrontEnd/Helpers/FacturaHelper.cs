using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class FacturaHelper
    {
        private ServiceRepository ServiceRepository;


        public FacturaHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<FacturaViewModel> GetAll()
        {
            List<FacturaViewModel> lista = new List<FacturaViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/factura");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<FacturaViewModel>>(content);
            }

            return lista;

        }




        public FacturaViewModel Get(int id)
        {
            FacturaViewModel FacturaViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/factura/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            FacturaViewModel = JsonConvert.DeserializeObject<FacturaViewModel>(content);



            return FacturaViewModel;
        }


        public FacturaViewModel Create(FacturaViewModel factura)
        {


            FacturaViewModel FacturaViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/factura/", factura);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            FacturaViewModel = JsonConvert.DeserializeObject<FacturaViewModel>(content);



            return FacturaViewModel;
        }

        public FacturaViewModel Edit(FacturaViewModel factura)
        {


            FacturaViewModel Factura;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/factura/", factura);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Factura = JsonConvert.DeserializeObject<FacturaViewModel>(content);



            return Factura;
        }



        public FacturaViewModel Delete(int id)
        {


            FacturaViewModel Factura;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/factura/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Factura = JsonConvert.DeserializeObject<FacturaViewModel>(content);



            return Factura;
        }

    }
}