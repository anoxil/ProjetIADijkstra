using System;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionnaireCours
{
    public partial class ProfBypassForm : Form
    {
        DijkstraAForm parentForm;

        public ProfBypassForm(DijkstraAForm form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private int ToNumber(string lettre)
        {
            char c = Convert.ToChar(lettre);
            int n = char.ToUpper(c) - 65;
            return n;
        }

        private bool TextboxInputWorkable()
        {
            string txtI = this.tb_numi.Text;
            string txtF = this.tb_numf.Text;

            //Textbox vide ?
            if (txtI.Length == 0) { return false; }
            if (txtF.Length == 0) { return false; }

            //node length <= 0, >=2 ? Not maj or in alphabet ?
            if ((txtI.Length < 1) || (txtI.Length > 1)) { return false; }
            if ((txtI.ToCharArray()[0] < 'A') || (txtI.ToCharArray()[0] > 'Z')) { return false; }

            if ((txtF.Length < 1) || (txtF.Length > 1)) { return false; }
            if ((txtF.ToCharArray()[0] < 'A') || (txtF.ToCharArray()[0] > 'Z')) { return false; }

            return true;
        }

        private void bt_Valider_Click(object sender, EventArgs e)
        {
            if (!this.tb_location.Text.EndsWith(".txt"))
            {
                MessageBox.Show("Nous n'avons pas pu trouver votre fichier .txt, veuillez réessayer.");
                return;
            }
            try
            {
                StreamReader sr = new StreamReader(this.tb_location.Text);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Nous n'avons pas pu trouver votre fichier .txt, veuillez réessayer.");
                return;
            }
            parentForm.SetProfGraphPath(this.tb_location.Text);

            if (TextboxInputWorkable())
            {
                parentForm.SetProfNumInitial(ToNumber(this.tb_numi.Text));
                parentForm.SetProfNumFinal(ToNumber(this.tb_numf.Text));
            }
            else
            {
                MessageBox.Show("Vous semblez avoir mal rempli les noeuds, veuillez réessayer (une seule lettre, en majuscule).");
                return;
            }
            this.Close();
        }
    }
}
