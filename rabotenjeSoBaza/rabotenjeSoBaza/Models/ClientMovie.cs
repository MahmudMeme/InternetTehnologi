using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rabotenjeSoBaza.Models
{
    public class ClientMovie
    {
        public int MoveiId { get; set; }
        public int ClientId { get; set; }

        public Movie movie { get; set; }

        public List<Clint> ClientList { get; set; }

        public ClientMovie()
        {
            ClientList = new List<Clint>();
        }
    }
}