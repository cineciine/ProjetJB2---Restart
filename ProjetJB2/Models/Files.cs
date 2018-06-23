using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetJB2.Models
{
    public class Files : Controller
    {
		public int Id { get; set; }
		public String Name { get; set; }
		public String path { get; set; }
		public String id_Step { get; set; }
	}
}