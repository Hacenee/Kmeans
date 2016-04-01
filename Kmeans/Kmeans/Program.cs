using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Globalization;

namespace KMeans
{
    class Program
    {

        static void Main(string[] args)
        {
            #region LectureFichier

            // Lire le fichier csv
            string[] allLines = File.ReadAllLines(@"iris.csv");

            // Chaque ligne est un individu
            Iris[] data = new Iris[allLines.Count()];

            // Pour chaque ligne, convertir les données
            for (int i = 0; i < allLines.Count(); i++)
            {
                // couper suivant le séparateur ,
                string[] tmp = allLines[i].Split(',');
                double v1 = Convert.ToDouble(tmp[0], CultureInfo.InvariantCulture);
                double v2 = Convert.ToDouble(tmp[1], CultureInfo.InvariantCulture);
                double v3 = Convert.ToDouble(tmp[2], CultureInfo.InvariantCulture);
                double v4 = Convert.ToDouble(tmp[3], CultureInfo.InvariantCulture);
                data[i] = new Iris(v1, v2, v3, v4, tmp[4]);
            }

            #endregion

            int[] cluster = new int[allLines.Count()]; // cluster[i] sera l'index du cluster de l'individu i
            int k = 3; // Nombre de clusters 
            Iris[] seeds = new Iris[k]; // Les clusters

            for (int i = 0; i < k; i++)
            {
                seeds[i] = new Iris(0, 0, 0, 0, "seed"); // A tirer aléatoirement
            }

            // Ici la méthode K-Means 
            // ...


            // Affichage
            for (int i = 0; i < allLines.Count(); i++)
            {
                Console.WriteLine(data[i] + " dans le cluster : " + cluster[i]);
            }
        }
    }
}