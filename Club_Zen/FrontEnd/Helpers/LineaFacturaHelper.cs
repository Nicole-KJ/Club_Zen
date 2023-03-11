using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class LineaFacturaHelper
    {
        private ServiceRepository ServiceRepository;


        public LineaFacturaHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<LineaFacturaViewModel> GetAll()
        {
            List<LineaFacturaViewModel> lista = new List<LineaFacturaViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/lineaFactura");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<LineaFacturaViewModel>>(content);
            }

            return lista;

        }




        public LineaFacturaViewModel Get(int id)
        {
            LineaFacturaViewModel LineaFacturaViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/lineaFactura/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            LineaFacturaViewModel = JsonConvert.DeserializeObject<LineaFacturaViewModel>(content);



            return LineaFacturaViewModel;
        }


        public LineaFacturaViewModel Create(LineaFacturaViewModel lineaFactura)
        {


            LineaFacturaViewModel LineaFacturaViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/lineaFactura/", lineaFactura);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            LineaFacturaViewModel = JsonConvert.DeserializeObject<LineaFacturaViewModel>(content);



            return lineaFactura;
        }

        public LineaFacturaViewModel Edit(LineaFacturaViewModel lineaFactura)
        {


            LineaFacturaViewModel LineaFactura;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/category/", lineaFactura);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            LineaFactura = JsonConvert.DeserializeObject<LineaFacturaViewModel>(content);



            return LineaFactura;
        }



        public LineaFacturaViewModel Delete(int id)
        {


            LineaFacturaViewModel lineaFactura;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/category/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            lineaFactura = JsonConvert.DeserializeObject<LineaFacturaViewModel>(content);



            return lineaFactura;
        }

    }
}
