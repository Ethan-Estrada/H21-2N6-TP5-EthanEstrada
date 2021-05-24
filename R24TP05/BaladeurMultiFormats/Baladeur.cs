using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaladeurMultiFormats
{
    public class Baladeur : IBaladeur
    {
        #region Champs
        private const string NOM_RÉPERTOIRE = "Chansons";
        private List<Chanson> m_colChansons;

        #endregion
        #region Proprietes
        /// <summary>
        /// Obtient le nombre de chansons.
        /// </summary>
        public int NbChansons { get; }
        #endregion
        #region Methodes

        /// <summary>
        /// Initialise une instance de la classe Baladeur. Elle instancie la collection des chansons.
        /// </summary>
        Baladeur()
        {
            m_colChansons = new List<Chanson>();
        }

        /// <summary>
        /// Charge la liste des chansons dans m_colChansons. Elle doit vérifier l’existence du répertoire des chansons, ensuite lit chaque fichier et instancie une classe de chanson selon le format et l’ajoute dans la collection des chansons m_colChansons 
        /// </summary>
        public void ConstruireLaListeDesChansons()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Affiche la liste des chansons dans la pListView passée en paramètre.
        /// </summary>
        /// <param name="pListView"></param>
        public void AfficherLesChansons(ListView pListView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtient la chanson à l’index pIndex passé en paramètre
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Chanson ChansonAt(int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Instancie une ChansonAAC à partir de la chanson à l’index pIndex, enregistre les paroles et supprime le fichier du format précédent.
        /// Elle utilise la méthode Ecrire pour enregistrer les paroles et la méthode File.Delete pour supprimer un fichier.
        /// </summary>
        /// <param name="pIndex"></param>
        public void ConvertirVersAAC(int pIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Instancie une ChansonMP3 à partir de la chanson à l’index pIndex, enregistre les paroles et supprime le fichier du format précédent.
        /// Elle utilise la méthode Ecrire pour enregistrer les paroles et la méthode File.Delete pour supprimer un fichier.
        /// </summary>
        /// <param name="pIndex"></param>
        public void ConvertirVersMP3(int pIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Instancie une ChansonWMA à partir de la chanson à l’index pIndex, enregistre les paroles et supprime le fichier du format précédent.
        ///Elle utilise la méthode Ecrire pour enregistrer les paroles et la méthode File.Delete pour supprimer un fichier.
        /// </summary>
        /// <param name="pIndex"></param>
        public void ConvertirVersWMA(int pIndex)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
