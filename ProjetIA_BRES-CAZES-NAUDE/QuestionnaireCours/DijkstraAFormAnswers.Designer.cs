namespace QuestionnaireCours
{
    partial class DijkstraAFormAnswers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_OuvertsGraphe = new System.Windows.Forms.ListBox();
            this.tv_DijkstraSolved = new System.Windows.Forms.TreeView();
            this.lb_FermesGraphe = new System.Windows.Forms.ListBox();
            this.lbl_FermesGraphe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_DijkstraSolved = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_OuvertsGraphe
            // 
            this.lb_OuvertsGraphe.FormattingEnabled = true;
            this.lb_OuvertsGraphe.ItemHeight = 20;
            this.lb_OuvertsGraphe.Location = new System.Drawing.Point(269, 83);
            this.lb_OuvertsGraphe.Margin = new System.Windows.Forms.Padding(30, 5, 10, 30);
            this.lb_OuvertsGraphe.Name = "lb_OuvertsGraphe";
            this.lb_OuvertsGraphe.Size = new System.Drawing.Size(210, 224);
            this.lb_OuvertsGraphe.TabIndex = 20;
            // 
            // tv_DijkstraSolved
            // 
            this.tv_DijkstraSolved.Location = new System.Drawing.Point(499, 83);
            this.tv_DijkstraSolved.Margin = new System.Windows.Forms.Padding(30, 5, 10, 5);
            this.tv_DijkstraSolved.Name = "tv_DijkstraSolved";
            this.tv_DijkstraSolved.Size = new System.Drawing.Size(288, 224);
            this.tv_DijkstraSolved.TabIndex = 19;
            // 
            // lb_FermesGraphe
            // 
            this.lb_FermesGraphe.FormattingEnabled = true;
            this.lb_FermesGraphe.ItemHeight = 20;
            this.lb_FermesGraphe.Location = new System.Drawing.Point(39, 83);
            this.lb_FermesGraphe.Margin = new System.Windows.Forms.Padding(30, 5, 10, 5);
            this.lb_FermesGraphe.Name = "lb_FermesGraphe";
            this.lb_FermesGraphe.Size = new System.Drawing.Size(210, 224);
            this.lb_FermesGraphe.TabIndex = 18;
            // 
            // lbl_FermesGraphe
            // 
            this.lbl_FermesGraphe.AutoSize = true;
            this.lbl_FermesGraphe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FermesGraphe.Location = new System.Drawing.Point(40, 49);
            this.lbl_FermesGraphe.Name = "lbl_FermesGraphe";
            this.lbl_FermesGraphe.Size = new System.Drawing.Size(209, 20);
            this.lbl_FermesGraphe.TabIndex = 21;
            this.lbl_FermesGraphe.Text = "Étapes nodes \"Fermées\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Étapes nodes \"Ouvertes\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "TreeView";
            // 
            // lb_DijkstraSolved
            // 
            this.lb_DijkstraSolved.FormattingEnabled = true;
            this.lb_DijkstraSolved.ItemHeight = 20;
            this.lb_DijkstraSolved.Location = new System.Drawing.Point(806, 83);
            this.lb_DijkstraSolved.Margin = new System.Windows.Forms.Padding(4, 5, 30, 29);
            this.lb_DijkstraSolved.Name = "lb_DijkstraSolved";
            this.lb_DijkstraSolved.Size = new System.Drawing.Size(196, 224);
            this.lb_DijkstraSolved.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(847, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Chemin Final";
            // 
            // DijkstraAFormAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1041, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_DijkstraSolved);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_FermesGraphe);
            this.Controls.Add(this.lb_OuvertsGraphe);
            this.Controls.Add(this.tv_DijkstraSolved);
            this.Controls.Add(this.lb_FermesGraphe);
            this.Name = "DijkstraAFormAnswers";
            this.Text = "DijkstraAFormAnswers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_OuvertsGraphe;
        private System.Windows.Forms.TreeView tv_DijkstraSolved;
        private System.Windows.Forms.ListBox lb_FermesGraphe;
        private System.Windows.Forms.Label lbl_FermesGraphe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_DijkstraSolved;
        private System.Windows.Forms.Label label3;
    }
}