using System;
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
    public partial class DijkstraAFormAnswers : Form
    {
        public DijkstraAFormAnswers()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) { e.Cancel = true; this.Hide(); }
            base.OnFormClosing(e);
        }

        public void AddLbDijkstraSolvedItem(string item) { lb_DijkstraSolved.Items.Add(item); }
        public void AddLbFermesGrapheItem(string item) { lb_FermesGraphe.Items.Add(item); }
        public void AddLbOuvertsGrapheItem(string item) { lb_OuvertsGraphe.Items.Add(item); }
        public TreeView GetTv() { return tv_DijkstraSolved; }

    }
}
