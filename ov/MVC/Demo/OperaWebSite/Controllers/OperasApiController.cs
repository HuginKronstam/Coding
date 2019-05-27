using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OperaWebSite.Models;

namespace OperaWebSite.Controllers
{
    public class OperasApiController : ApiController
    {
        private OperasDB _context = new OperasDB();

        public IEnumerable<Opera> GetOperas()
        {
            return _context.Operas.AsEnumerable();
        }

        public Opera getOperas(int id)
        {
            Opera opera = _context.Operas.Find(id);

            if (opera == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return opera;
            }
        }
    }
}
