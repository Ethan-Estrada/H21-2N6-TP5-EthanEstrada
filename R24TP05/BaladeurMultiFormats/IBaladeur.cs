using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaladeurMultiFormats
{
    interface IBaladeur
    {
        /// <summary>
        /// Obtient le nombre de chansons.
        /// </summary>
        int NbChansons { get; }

        /// <summary>
        /// Affiche la liste des chansons dans la pListView passée en paramètre.
        /// </summary>
        /// <param name="pListView"></param>
        void AfficherLesChansons(ListView pListView);

        /// <summary>
        /// Obtient la chanson à l’index pIndex passé en paramètre.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        Chanson ChansonAt(int index);

        /// <summary>
        /// Récupère la liste des fichiers dans le dossier Chansons, instancie selon le cas des objets des classes dérivées de la classe Chanson.
        /// </summary>
        void ConstruireLaListeDesChansons();

        /// <summary>
        /// Instancie une ChansonAAC à partir de la chanson à l’index pIndex, enregistre les paroles et supprime le fichier du format précédent.
        ///Elle utilise la méthode Ecrire pour enregistrer les paroles et la méthode File.Delete pour supprimer un fichier.
        /// </summary>
        /// <param name="pIndex"></param>
        void ConvertirVersAAC(int pIndex);

        /// <summary>
        /// Instancie une ChansonMP3 à partir de la chanson à l’index pIndex, enregistre les paroles et supprime le fichier du format précédent.
        ///Elle utilise la méthode Ecrire pour enregistrer les paroles et la méthode File.Delete pour supprimer un fichier.
        /// </summary>
        /// <param name="pIndex"></param>
        void ConvertirVersMP3(int pIndex);


        /// <summary>
        /// Instancie une ChansonWMA à partir de la chanson à l’index pIndex, enregistre les paroles et supprime le fichier du format précédent.
        ///Elle utilise la méthode Ecrire pour enregistrer les paroles et la méthode File.Delete pour supprimer un fichier.
        /// </summary>
        /// <param name="pIndex"></param>
        void ConvertirVersWMA(int pIndex);

    }
}
