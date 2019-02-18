namespace QuestionnaireCours
{
    partial class ProfBypassForm
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
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_numi = new System.Windows.Forms.Label();
            this.lbl_numf = new System.Windows.Forms.Label();
            this.tb_numi = new System.Windows.Forms.TextBox();
            this.tb_numf = new System.Windows.Forms.TextBox();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.bt_Valider = new System.Windows.Forms.Button();
            this.lbl_locationWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Location = new System.Drawing.Point(46, 175);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(273, 20);
            this.lbl_location.TabIndex = 0;
            this.lbl_location.Text = "Chemin d\'accès relatif du graphe .txt :";
            // 
            // lbl_numi
            // 
            this.lbl_numi.AutoSize = true;
            this.lbl_numi.Location = new System.Drawing.Point(46, 43);
            this.lbl_numi.Name = "lbl_numi";
            this.lbl_numi.Size = new System.Drawing.Size(185, 20);
            this.lbl_numi.TabIndex = 1;
            this.lbl_numi.Text = "Lettre de la node initiale :";
            // 
            // lbl_numf
            // 
            this.lbl_numf.AutoSize = true;
            this.lbl_numf.Location = new System.Drawing.Point(46, 112);
            this.lbl_numf.Name = "lbl_numf";
            this.lbl_numf.Size = new System.Drawing.Size(179, 20);
            this.lbl_numf.TabIndex = 2;
            this.lbl_numf.Text = "Lettre de la node finale :";
            // 
            // tb_numi
            // 
            this.tb_numi.Location = new System.Drawing.Point(251, 36);
            this.tb_numi.Name = "tb_numi";
            this.tb_numi.Size = new System.Drawing.Size(100, 26);
            this.tb_numi.TabIndex = 3;
            // 
            // tb_numf
            // 
            this.tb_numf.Location = new System.Drawing.Point(251, 106);
            this.tb_numf.Name = "tb_numf";
            this.tb_numf.Size = new System.Drawing.Size(100, 26);
            this.tb_numf.TabIndex = 4;
            // 
            // tb_location
            // 
            this.tb_location.Location = new System.Drawing.Point(335, 169);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(202, 26);
            this.tb_location.TabIndex = 5;
            // 
            // bt_Valider
            // 
            this.bt_Valider.Location = new System.Drawing.Point(230, 305);
            this.bt_Valider.Name = "bt_Valider";
            this.bt_Valider.Size = new System.Drawing.Size(96, 33);
            this.bt_Valider.TabIndex = 6;
            this.bt_Valider.Text = "Envoyer";
            this.bt_Valider.UseVisualStyleBackColor = true;
            this.bt_Valider.Click += new System.EventHandler(this.bt_Valider_Click);
            // 
            // lbl_locationWarning
            // 
            this.lbl_locationWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_locationWarning.Location = new System.Drawing.Point(50, 210);
            this.lbl_locationWarning.Name = "lbl_locationWarning";
            this.lbl_locationWarning.Size = new System.Drawing.Size(487, 65);
            this.lbl_locationWarning.TabIndex = 7;
            this.lbl_locationWarning.Text = "Le point de départ de votre chemin relatif est le bin/Debug/ du projet TEST. Par " +
    "exemple, si votre graphe est dans le dossier principal du projet, vous devrez re" +
    "nseigner \"../../nomdugraphe.txt\".";
            // 
            // ProfBypassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 359);
            this.Controls.Add(this.lbl_locationWarning);
            this.Controls.Add(this.bt_Valider);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.tb_numf);
            this.Controls.Add(this.tb_numi);
            this.Controls.Add(this.lbl_numf);
            this.Controls.Add(this.lbl_numi);
            this.Controls.Add(this.lbl_location);
            this.Name = "ProfBypassForm";
            this.Text = "Récupération des données";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_numi;
        private System.Windows.Forms.Label lbl_numf;
        private System.Windows.Forms.TextBox tb_numi;
        private System.Windows.Forms.TextBox tb_numf;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.Button bt_Valider;
        private System.Windows.Forms.Label lbl_locationWarning;
    }
}