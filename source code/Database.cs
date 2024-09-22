using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading.Tasks;

using Firebase.Database;
using Firebase.Database.Query;


namespace ProjetBorneCinema
{
    internal class Database
    {
        public static async Task CreateurTableaux(string nomtableau, int largeur, int hauteur)
        {
            FirebaseClient firebaseClient = new FirebaseClient(stockageinit.adresse_firebase_database);

            // Stocker le tableau dans la base de données

            bool[,] tableauObjet = new bool[largeur, hauteur];
            await firebaseClient.Child(nomtableau).PutAsync(tableauObjet);//on Put le tableau dans la base de donnée
        }


        public static bool[,] RecuperationTableau(string tableauAdresse)
        {
            var firebaseClient = new FirebaseClient(stockageinit.adresse_firebase_database);

            var dataSnapshot = firebaseClient
                .Child(tableauAdresse)
                .OnceSingleAsync<bool[,]>()
                .Result;

            return dataSnapshot;
        }


        public static void ModifierValeur(string adresse, bool nouvelleValeur)
        {
            var firebaseClient = new FirebaseClient(stockageinit.adresse_firebase_database);

            firebaseClient
                .Child(adresse)
                .PutAsync(nouvelleValeur)
                .Wait();
        }

        public static bool RecuperationValeur(string chemin)
        {
            var firebase = new FirebaseClient(stockageinit.adresse_firebase_database);            // On récupère la référence de la base de données Firebase


            var task = firebase.Child(chemin).OnceSingleAsync<bool>();                    
            bool data = task.Result;       // La valeur à la fin de la tâche

            return data;
        }

        public static bool Verificateurexistence(string chemin) //renvoie true si il y a quelque chose et false si on a 'catch' une erreur disant
            //que l'objet retourné était nul
        {
            var firebase = new FirebaseClient(stockageinit.adresse_firebase_database);

            bool reussite;
            try
            {
                var task = firebase.Child(chemin).OnceSingleAsync<bool>().Result;
                reussite = true;
            }
            catch (System.AggregateException)
            {
                reussite = false;
            }
            return reussite;
        }

        public static async Task DestructeurTableaux(string adresse)
        {
            FirebaseClient firebaseClient = new FirebaseClient(stockageinit.adresse_firebase_database);
            await firebaseClient.Child(adresse).DeleteAsync();//On utilise la méthode fournie par firebase database pour supprimer
        }

    }
}
