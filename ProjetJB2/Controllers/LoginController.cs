using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetJB2.Controllers
{
	public class LoginController : Controller
	{
		// GET: Login
		public ActionResult Index()
		{
			return View();
		}

		/*Méthode de Connexion*/
		[HttpPost]
		public ActionResult SignIn(string login, string password, string stat)
		{
			Console.WriteLine(login, password, stat);

			//string motDePasseEncode = EncodeMD5(motDePasse);
			//return .Utilisateurs.FirstOrDefault(u => u.Prenom == nom && u.MotDePasse == motDePasseEncode);
			/*if(login != "" && password != "")	//Vérification que les variables ne soient pas vides
			{
				if (stat == "Student") {	//Contrôle du statut (Etudiant/Enseignant)

				}
				else {	//Statut == "Teacher"

				}

				foreach()	//Parcours des données
				{
					if() {	//Comparaison entre les données et les informations saisies
					}
					else {
						//Message d'Erreur
					}
				}

			}*/
			return RedirectToAction("Index");
		}

		/*Méthode de Déconnexion*/
		public ActionResult SignOut()
		{
			return RedirectToAction("Index");
		}
	}
}