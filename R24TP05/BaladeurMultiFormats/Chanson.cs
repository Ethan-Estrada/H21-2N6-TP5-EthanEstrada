using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaladeurMultiFormats
{
    public abstract class Chanson : IChanson
    {
        #region Proprietes
        protected int m_annee;
        /// <summary>
        /// Obtient l’année de création de la chanson 
        /// </summary>
        public int Annee
        {
            get { return m_annee; }
        }

        protected string m_artiste;
        /// <summary>
        /// Obtient le nom de l’artiste
        /// </summary>
        public string Artiste
        {
            get { return m_artiste; }
        }

        protected string m_titre;
        /// <summary>
        /// Obtient le titre de la chanson
        /// </summary>
        public string Titre
        {
            get { return m_titre; }
        }

        /// <summary>
        /// Obtient le format audio de la chanson par exemple AAC, MP3 ou WMA
        /// </summary>
        public abstract string Format { get; }

        protected string m_nomFichier;
        /// <summary>
        /// Obtient le nom de fichier de la chanson
        /// </summary>
        public string NomFichier
        {
            get { return m_nomFichier; }
        }
        public string Paroles
        {
            get {
                string paroles = "lol";
                return paroles;
            }
                

                //if( File.Exists(NomFichier) == true)
                //{
                //    string objParoles;
                //   string[] Fichier = Directory.GetFiles(NomFichier);

                //    for (int index = 1; index < Fichier.Length; index++)
                //    {
                //        objParoles = Fichier[index];
                //    }

                //    return objParoles;
                //}

               
            
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Initialise une instance, elle appelle la méthode LireEntete
        /// </summary>
        /// <param name="pNomFichier"></param>
        public Chanson(string pNomFichier)
        {
            m_nomFichier = pNomFichier;
            LireEntete();
        }

        /// <summary>
        /// Le nom de fichier doit contenir le nom de répertoire , le nom de fichier et son format.
        /// </summary>
        /// <param name="pRepertoire"></param>
        /// <param name="pArtiste"></param>
        /// <param name="pTitre"></param>
        /// <param name="pAnnee"></param>
        public Chanson(string pRepertoire,string pArtiste, string pTitre,int pAnnee)
        {
            m_artiste = pArtiste;
            m_titre = pTitre;
            m_annee = pAnnee;
            m_nomFichier = pRepertoire + m_titre + "." + Format; 
        }

        public abstract void LireEntete();
        public abstract string LireParoles(StreamReader pobjFichier);

        /// <summary>
        /// Lit une ligne à partir du fichier passé en paramètre.
        /// </summary>
        /// <param name="pobjFichier"></param>
        public void SauterEntete(StreamReader pobjFichier)
        {
            pobjFichier.ReadLine();
            pobjFichier.Close();

        }
        public abstract void EcrireEntete(StreamReader pobjFichier);
  
        public abstract void EcrireParoles(StreamWriter pobjFichier, string pParoles);

        /// <summary>
        /// Écrit les paroles passées en paramètre dans le fichier de la chanson. 
        /// Elle doit d’abord écrire l’en-tête ensuite écrire les paroles.
        /// </summary>
        /// <param name="pParoles"></param>
        public void Ecrire(string pParoles)
        {
            //Chanson objChanson = new Chanson(pParoles);

            //EcrireEntete(objChanson);
            //EcrireParoles(objChanson);
        }








        #endregion
    }
}
