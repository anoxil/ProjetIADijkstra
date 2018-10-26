using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionnaireCours
{
    public partial class DijkstraAForm : Form
    {
        static public int[,] matrice;
        static public int nbNodes;
        static public int numInitial;
        static public int numFinal;
        private string[] sep = { ", ", " " };
        private int iteInput = 1;
        private int iteInputGoal = -1;

        public DijkstraAForm()
        {
            InitializeComponent();
            ReadGraphFile();
            DijkstraASolverIterationDefiner();
            tb_OpenedPrevious.Text = "A";
        }

        private void ReadGraphFile ()
        {
            // Lecture du fichier
            StreamReader monStreamReader = new StreamReader("../../SujetGraph.txt");

            // 1ère ligne : nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = ligne.IndexOf(':') + 1;
            string nbNodesString = "";
            while (i < ligne.Length)
            {
                nbNodesString = nbNodesString + ligne[i]; i++;
            }
            nbNodes = Convert.ToInt32(nbNodesString);

            matrice = new int[nbNodes, nbNodes];
            for (i = 0; i < nbNodes; i++)
                for (int j = 0; j < nbNodes; j++)
                    matrice[i, j] = -1;

            // Autres lignes : nodedépart nodearrivée valeur
            ligne = monStreamReader.ReadLine();
            int N1, N2, val; string strN1, strN2, strVal;
            while (ligne != null)
            {
                i = ligne.IndexOf(':') + 1;

                //nodedépart
                strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i]; i++;
                }
                N1 = Convert.ToInt32(strN1);

                //nodearrivée
                strN2 = ""; i++;
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i]; i++;
                }
                N2 = Convert.ToInt32(strN2);

                //valeur
                strVal = ""; i++;
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i]; i++;
                }
                val = Convert.ToInt32(strVal);

                //on enregistre les données dans la matrice
                matrice[N1, N2] = val;
                matrice[N2, N1] = val;

                lb_MatriceGraphe.Items.Add( ((char)(N1+65)).ToString() + " ---> " + ((char)(N2+65)).ToString() + "   : " + Convert.ToString(matrice[N1, N2]));

                ligne = monStreamReader.ReadLine();
            }
            
            monStreamReader.Close();
        }

        private void bt_ClosedOpenRead_Click(object sender, EventArgs e)
        {
            //On vérifie que l'input est étudiable
            if (!TextboxInputWorkable())
            {
                MessageBox.Show("Vous semblez avoir mal rempli vos cases.\n\nRappel :\n - Une case ne sera jamais vide !\n - Les lettres doivent être en majuscule.\n - Si vous avez plusieurs lettres à rentrer, vous devez les séparer par \", \" ou \" \".");
                return;
            }
            //On vérifie que l'input est juste
            if (TextboxInputCorrect()) //il faudra lancer le DijkstraASolver() ici.
            {
                tb_ClosedPrevious.Text = tb_ClosedRead.Text;
                tb_OpenedPrevious.Text = tb_OpenedRead.Text;
                if (iteInput == iteInputGoal) { MessageBox.Show("Dijkstra terminé !"); }
            }
            else { MessageBox.Show("Erreur dans votre proposition !"); }
        }

        private bool TextboxInputWorkable ()
        {
            string txtF = tb_ClosedRead.Text;
            string txtO = tb_OpenedRead.Text;

            //Cases vides ?
            if ( (txtF.Length == 0) || (txtO.Length == 0) ) { return false; }

            //Mauvaise séparations ? Element length <= 0, >=2 ? Not maj or in alphabet ?
            string[] txtFElements = txtF.Split(this.sep, StringSplitOptions.None);
            string[] txtOElements = txtO.Split(this.sep, StringSplitOptions.None);

            foreach (string element in txtFElements)
            {
                if ((element.Length < 1) || (element.Length > 1)) { return false; }
                if ((element.ToCharArray()[0] < 'A') || (element.ToCharArray()[0] > 'Z')) { return false; }
            }
            foreach (string element in txtOElements)
            {
                if ((element.Length < 1) || (element.Length > 1)) { return false; }
                if ((element.ToCharArray()[0] < 'A') || (element.ToCharArray()[0] > 'Z')) { return false; }
            }

            return true;
        }

        private bool TextboxInputCorrect ()
        {
            //dikjstra solver comparé à l'input
            string[] txtFElements = tb_ClosedRead.Text.Split(this.sep, StringSplitOptions.None);
            string[] txtOElements = tb_OpenedRead.Text.Split(this.sep, StringSplitOptions.None);

            numInitial = 0; numFinal = 4;
            SearchTree g = new SearchTree();
            SpecificNode N0 = new SpecificNode();
            N0.numero = numInitial;

            return g.RechercheSolutionAEtoileUserInput(N0, this); //CHECK INPUT ICI
        }

        private void DijkstraASolverIterationDefiner()
        {
            numInitial = 0; numFinal = 4;
            SearchTree g = new SearchTree();
            SpecificNode N0 = new SpecificNode();
            N0.numero = numInitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0, this);

            SpecificNode N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                SpecificNode N2 = (SpecificNode)solution[i];
                lb_DijkstraSolved.Items.Add(((char)(N1.numero + 65)).ToString() + " ---> " + ((char)(N2.numero + 65)).ToString() + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }

            g.GetSearchTree(tv_DijkstraSolved);
        }

        public void SetTbOpenedPreviousText(string txt) { this.tb_OpenedPrevious.Text = txt; }
        public void SetTbClosedPreviousText(string txt) { this.tb_OpenedPrevious.Text = txt; }
        public string GetTbOpenedReadText() { return this.tb_OpenedRead.Text; }
        public string GetTbClosedReadText() { return this.tb_ClosedRead.Text; }
        public int GetIterationInput() { return this.iteInput; }
        public void IncrementIterationInput() { this.iteInput++; }
        public int GetIterationInputGoal() { return this.iteInputGoal; }
        public void SetIterationInputGoal(int ite) { this.iteInputGoal = ite;}
    }
}
