namespace QuestionnaireCours
{
    partial class DijkstraAForm
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
            this.lb_MatriceGraphe = new System.Windows.Forms.ListBox();
            this.lb_DijkstraSolved = new System.Windows.Forms.ListBox();
            this.tv_DijkstraSolved = new System.Windows.Forms.TreeView();
            this.tb_ClosedRead = new System.Windows.Forms.TextBox();
            this.tb_OpenedRead = new System.Windows.Forms.TextBox();
            this.tb_ClosedPrevious = new System.Windows.Forms.TextBox();
            this.tb_OpenedPrevious = new System.Windows.Forms.TextBox();
            this.lbl_ClosedPrevious = new System.Windows.Forms.Label();
            this.lbl_ClosedRead = new System.Windows.Forms.Label();
            this.lbl_OpenedPrevious = new System.Windows.Forms.Label();
            this.lbl_OpenedRead = new System.Windows.Forms.Label();
            this.bt_ClosedOpenRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_MatriceGraphe
            // 
            this.lb_MatriceGraphe.FormattingEnabled = true;
            this.lb_MatriceGraphe.Location = new System.Drawing.Point(44, 267);
            this.lb_MatriceGraphe.Name = "lb_MatriceGraphe";
            this.lb_MatriceGraphe.Size = new System.Drawing.Size(154, 316);
            this.lb_MatriceGraphe.TabIndex = 0;
            // 
            // lb_DijkstraSolved
            // 
            this.lb_DijkstraSolved.FormattingEnabled = true;
            this.lb_DijkstraSolved.Location = new System.Drawing.Point(239, 267);
            this.lb_DijkstraSolved.Name = "lb_DijkstraSolved";
            this.lb_DijkstraSolved.Size = new System.Drawing.Size(154, 316);
            this.lb_DijkstraSolved.TabIndex = 1;
            // 
            // tv_DijkstraSolved
            // 
            this.tv_DijkstraSolved.Location = new System.Drawing.Point(501, 267);
            this.tv_DijkstraSolved.Name = "tv_DijkstraSolved";
            this.tv_DijkstraSolved.Size = new System.Drawing.Size(264, 316);
            this.tv_DijkstraSolved.TabIndex = 2;
            // 
            // tb_ClosedRead
            // 
            this.tb_ClosedRead.Location = new System.Drawing.Point(566, 49);
            this.tb_ClosedRead.Name = "tb_ClosedRead";
            this.tb_ClosedRead.Size = new System.Drawing.Size(199, 20);
            this.tb_ClosedRead.TabIndex = 3;
            // 
            // tb_OpenedRead
            // 
            this.tb_OpenedRead.Location = new System.Drawing.Point(566, 115);
            this.tb_OpenedRead.Name = "tb_OpenedRead";
            this.tb_OpenedRead.Size = new System.Drawing.Size(199, 20);
            this.tb_OpenedRead.TabIndex = 4;
            // 
            // tb_ClosedPrevious
            // 
            this.tb_ClosedPrevious.Location = new System.Drawing.Point(41, 49);
            this.tb_ClosedPrevious.Name = "tb_ClosedPrevious";
            this.tb_ClosedPrevious.ReadOnly = true;
            this.tb_ClosedPrevious.Size = new System.Drawing.Size(352, 20);
            this.tb_ClosedPrevious.TabIndex = 5;
            // 
            // tb_OpenedPrevious
            // 
            this.tb_OpenedPrevious.Location = new System.Drawing.Point(41, 115);
            this.tb_OpenedPrevious.Name = "tb_OpenedPrevious";
            this.tb_OpenedPrevious.ReadOnly = true;
            this.tb_OpenedPrevious.Size = new System.Drawing.Size(352, 20);
            this.tb_OpenedPrevious.TabIndex = 6;
            // 
            // lbl_ClosedPrevious
            // 
            this.lbl_ClosedPrevious.AutoSize = true;
            this.lbl_ClosedPrevious.Location = new System.Drawing.Point(41, 30);
            this.lbl_ClosedPrevious.Name = "lbl_ClosedPrevious";
            this.lbl_ClosedPrevious.Size = new System.Drawing.Size(90, 13);
            this.lbl_ClosedPrevious.TabIndex = 7;
            this.lbl_ClosedPrevious.Text = "Fermés (previous)";
            // 
            // lbl_ClosedRead
            // 
            this.lbl_ClosedRead.AutoSize = true;
            this.lbl_ClosedRead.Location = new System.Drawing.Point(563, 30);
            this.lbl_ClosedRead.Name = "lbl_ClosedRead";
            this.lbl_ClosedRead.Size = new System.Drawing.Size(73, 13);
            this.lbl_ClosedRead.TabIndex = 8;
            this.lbl_ClosedRead.Text = "Fermés (input)";
            // 
            // lbl_OpenedPrevious
            // 
            this.lbl_OpenedPrevious.AutoSize = true;
            this.lbl_OpenedPrevious.Location = new System.Drawing.Point(41, 99);
            this.lbl_OpenedPrevious.Name = "lbl_OpenedPrevious";
            this.lbl_OpenedPrevious.Size = new System.Drawing.Size(93, 13);
            this.lbl_OpenedPrevious.TabIndex = 9;
            this.lbl_OpenedPrevious.Text = "Ouverts (previous)";
            // 
            // lbl_OpenedRead
            // 
            this.lbl_OpenedRead.AutoSize = true;
            this.lbl_OpenedRead.Location = new System.Drawing.Point(563, 99);
            this.lbl_OpenedRead.Name = "lbl_OpenedRead";
            this.lbl_OpenedRead.Size = new System.Drawing.Size(76, 13);
            this.lbl_OpenedRead.TabIndex = 10;
            this.lbl_OpenedRead.Text = "Ouverts (input)";
            // 
            // bt_ClosedOpenRead
            // 
            this.bt_ClosedOpenRead.Location = new System.Drawing.Point(622, 162);
            this.bt_ClosedOpenRead.Name = "bt_ClosedOpenRead";
            this.bt_ClosedOpenRead.Size = new System.Drawing.Size(75, 23);
            this.bt_ClosedOpenRead.TabIndex = 11;
            this.bt_ClosedOpenRead.Text = "Send";
            this.bt_ClosedOpenRead.UseVisualStyleBackColor = true;
            this.bt_ClosedOpenRead.Click += new System.EventHandler(this.bt_ClosedOpenRead_Click);
            // 
            // DijkstraAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 624);
            this.Controls.Add(this.bt_ClosedOpenRead);
            this.Controls.Add(this.lbl_OpenedRead);
            this.Controls.Add(this.lbl_OpenedPrevious);
            this.Controls.Add(this.lbl_ClosedRead);
            this.Controls.Add(this.lbl_ClosedPrevious);
            this.Controls.Add(this.tb_OpenedPrevious);
            this.Controls.Add(this.tb_ClosedPrevious);
            this.Controls.Add(this.tb_OpenedRead);
            this.Controls.Add(this.tb_ClosedRead);
            this.Controls.Add(this.tv_DijkstraSolved);
            this.Controls.Add(this.lb_DijkstraSolved);
            this.Controls.Add(this.lb_MatriceGraphe);
            this.Name = "DijkstraAForm";
            this.Text = "Dijkstra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_MatriceGraphe;
        private System.Windows.Forms.ListBox lb_DijkstraSolved;
        private System.Windows.Forms.TreeView tv_DijkstraSolved;
        private System.Windows.Forms.TextBox tb_ClosedRead;
        private System.Windows.Forms.TextBox tb_OpenedRead;
        private System.Windows.Forms.TextBox tb_ClosedPrevious;
        private System.Windows.Forms.TextBox tb_OpenedPrevious;
        private System.Windows.Forms.Label lbl_ClosedPrevious;
        private System.Windows.Forms.Label lbl_ClosedRead;
        private System.Windows.Forms.Label lbl_OpenedPrevious;
        private System.Windows.Forms.Label lbl_OpenedRead;
        private System.Windows.Forms.Button bt_ClosedOpenRead;
    }
}