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
        static public int numFinal;
        private int numInitial;
        private string[] sep = { " " };
        private int iteInput = 1;
        private int iteInputGoal = -1;
        private int note = 0;
        private SearchTree g;
        private DijkstraAFormAnswers answersForm;

        public DijkstraAForm()
        {
            InitializeComponent();
        }

        /* Fonction exécutée après l'initialisation du form.
         * Prépare le graphe qui sera étudié et le résout,
         * avant même la récupération de l'input de l'utilisateur
        */
        private void DijkstraAForm_Load(object sender, EventArgs e)
        {
            //Form contenant toutes les réponses nécessaires à la résolution de l'algo à la main. Accessible aux correcteurs du projet.
            this.answersForm = new DijkstraAFormAnswers();
            //Lecture du graphe à modéliser
            ReadGraphFile();
            //Algorithme de résolution Dijkstra A* du graphe avec la classe SearchTree. Récupération possible des réponses dans la variable SearchTree g.
            DijkstraASolverIterationDefiner();
            //Initialisation des string à afficher sur le form
            lbl_Instructions.Text = "Remplissez à la main l'algorithme de Dijkstra pour aller du point " + ((char)(this.numInitial + 65)).ToString() + " au point " + ((char)(numFinal + 65)).ToString() + ".";
            tb_OpenedPrevious.Text = g.L_OuvertsEvolution[0][0];
            lbl_IndicationsInput.Text = "Veuillez remplir l'étape " + (this.iteInput + 1) + " de l'algorithme :";
            this.ActiveControl = tb_ClosedRead;
        }

        private void ReadGraphFile ()
        {
            // Randomisation du choix du fichier et des nodes départ-arrivée
            /*
            Random r = new Random();
            int fileNumber = r.Next(1, 3);

            string graphLocation = "../../graph" + fileNumber + ".txt";
            string picLocation = "../../graph" + fileNumber + ".png";
            StreamReader monStreamReader = new StreamReader(graphLocation);
            this.pb_graph.ImageLocation = picLocation;
            */
            /////////////////////////////////////////////////////////////////
            
            // Lecture du fichier
            StreamReader monStreamReader = new StreamReader("../../SujetGraph.txt");
            pb_graph.ImageLocation = "../../SujetGraph.png";
            numInitial = 0; numFinal = 1; //SUPPRIMER POUR RANDOMISER//
            //////////////////////////
            /*
            numInitial = r.Next(nbNodes);
            do { numFinal = r.Next(nbNodes); } while (numFinal == numInitial)
            */
            //////////////////////////

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

                ligne = monStreamReader.ReadLine();
            }



            monStreamReader.Close();
        }
        
        /* Fontion de vérification de l'input de l'utilisateur à l'étape iteInput. */
        private void bt_ClosedOpenRead_Click(object sender, EventArgs e)
        {
            //On vérifie que l'input est étudiable
            if (!TextboxInputWorkable())
            {
                MessageBox.Show("Vous semblez avoir mal rempli vos cases.\n\nRappel :\n - La case \"Fermés\" ne sera jamais vide !\n - Les lettres doivent être en majuscule.\n - Si vous avez plusieurs lettres à rentrer, vous devez les séparer par \" \".");
                return;
            }
            //On vérifie que l'input est juste
            if (TextboxInputCorrect())
            {
                //On refresh les informations pour l'étape suivante
                lbl_Correctness.Text = ""; System.Threading.Thread.Sleep(200);
                lbl_Correctness.Text = "Étape " + (this.iteInput+1) + " correcte !";
                lbl_IndicationsInput.Text = "Veuillez remplir l'étape " + (this.iteInput+2) + " de l'algorithme :";
                iteInput++;
                tb_ClosedPrevious.Text = tb_ClosedRead.Text;
                tb_OpenedPrevious.Text = tb_OpenedRead.Text;
                //Si l'utilisateur a terminé l'algorithme sans faute
                if (iteInput == iteInputGoal)
                {
                    lbl_IndicationsInput.Text = "Fin de l'algorithme.";
                    this.note = 3;
                    MessageBox.Show("Dijkstra réussi !");
                    Application.Exit();
                }
            }
            else { MessageBox.Show("Erreur dans votre proposition !"); }
        }

        private bool TextboxInputWorkable ()
        {
            string txtF = tb_ClosedRead.Text;
            string txtO = tb_OpenedRead.Text;

            //Textbox Fermes vide ?
            if (txtF.Length == 0) { return false; }

            //Mauvaise séparations ?
            string[] txtFElements = txtF.Split(this.sep, StringSplitOptions.None);
            string[] txtOElements = txtO.Split(this.sep, StringSplitOptions.None);

            //Element length <= 0, >=2 ? Not maj or in alphabet ?
            foreach (string element in txtFElements)
            {
                if ((element.Length < 1) || (element.Length > 1)) { return false; }
                if ((element.ToCharArray()[0] < 'A') || (element.ToCharArray()[0] > 'Z')) { return false; }
            }
            if (txtO.Length != 0)
            {
                foreach (string element in txtOElements)
                {
                    if ((element.Length < 1) || (element.Length > 1)) { return false; }
                    if ((element.ToCharArray()[0] < 'A') || (element.ToCharArray()[0] > 'Z')) { return false; }
                }
            }

            return true;
        }

        private bool TextboxInputCorrect ()
        {
            List<string> txtFElements = tb_ClosedRead.Text.Split(this.sep, StringSplitOptions.None).ToList<string>();
            List<string> txtOElements = tb_OpenedRead.Text.Split(this.sep, StringSplitOptions.None).ToList<string>();

            //On parcourt toutes les nodes de l'étape iteInput dans l'ensemble fermés, pour vérifier l'input de l'utilisateur.
            foreach (string node in g.L_FermesEvolution[iteInput])
            {
                if (txtFElements.Contains(node))
                {
                    txtFElements.Remove(node);
                }
            }
            if (txtFElements.Count > 0) { return false; }

            //On parcourt toutes les nodes de l'étape iteInput dans l'ensemble ouverts, pour vérifier l'input de l'utilisateur.
            foreach (string node in g.L_OuvertsEvolution[iteInput])
            {
                if (txtOElements.Contains(node))
                {
                    txtOElements.Remove(node);
                }
            }
            if (txtOElements.Count > 0) { return false; }

            return true;
        }

        private void DijkstraASolverIterationDefiner()
        {
            this.g = new SearchTree();
            SpecificNode N0 = new SpecificNode();
            N0.numero = numInitial;
            //Algorithme de Dijkstra A* dans la classe SearchTree
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0, this);

            //Enregistrement de la solution finale à l'algorithme du chemin le plus court dans le Form de réponses
            SpecificNode N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                SpecificNode N2 = (SpecificNode)solution[i];
                answersForm.AddLbDijkstraSolvedItem(((char)(N1.numero + 65)).ToString() + " ---> " + ((char)(N2.numero + 65)).ToString() + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }

            //Enregistrement de l'arbre final de l'algorithme dans le Form de réponses
            this.g.GetSearchTree(answersForm.GetTv());

            //Enregistrement des réponses (fermés et ouverts) à chaque étape de l'algorithme à la main de Dijkstra dans le Form de réponses
            string txt;
            for (int i = 0; i < this.g.L_FermesEvolution.Count; i++)
            {
                txt = "(" + (i+1).ToString() + ") : { ";
                foreach (string el in this.g.L_FermesEvolution[i]) { txt += (el + " "); } txt += "}";
                answersForm.AddLbFermesGrapheItem(txt);
            }
            for (int i = 0; i < this.g.L_OuvertsEvolution.Count; i++)
            {
                txt = "(" + (i + 1).ToString() + ") : { ";
                foreach (string el in this.g.L_OuvertsEvolution[i]) { txt += (el + " "); }
                txt += "}";
                answersForm.AddLbOuvertsGrapheItem(txt);
            }
        }

        public void SetIterationInputGoal(int ite) { this.iteInputGoal = ite; }

        public int GetNote() { return this.note; }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.bt_ClosedOpenRead_Click(sender, new EventArgs());
                this.tb_ClosedRead.Focus();
            }
        }

        /* Accès au Form contenant les réponses au graphe. Pour faciliter la correction. */
        private void bt_Answers_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Cette fonctionnalité n'est accessible qu'aux correcteurs du projets.\n\nÊtes vous un correcteur ?", "Vérification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
            this.answersForm.Show();
            }
        }

        /*
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MessageBox.Show(e.CloseReason.ToString());
            if (e.CloseReason == CloseReason.ApplicationExitCall) { e.Cancel = true; answersForm.Hide(); this.Hide(); }
            base.OnFormClosing(e);
        }
        */

    }
}
