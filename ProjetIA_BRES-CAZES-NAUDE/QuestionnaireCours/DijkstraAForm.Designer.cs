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
            this.pb_graph = new System.Windows.Forms.PictureBox();
            this.lbl_Correctness = new System.Windows.Forms.Label();
            this.lbl_IndicationsInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Instructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_graph)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MatriceGraphe
            // 
            this.lb_MatriceGraphe.FormattingEnabled = true;
            this.lb_MatriceGraphe.ItemHeight = 20;
            this.lb_MatriceGraphe.Location = new System.Drawing.Point(30, 640);
            this.lb_MatriceGraphe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_MatriceGraphe.Name = "lb_MatriceGraphe";
            this.lb_MatriceGraphe.Size = new System.Drawing.Size(190, 224);
            this.lb_MatriceGraphe.TabIndex = 0;
            // 
            // lb_DijkstraSolved
            // 
            this.lb_DijkstraSolved.FormattingEnabled = true;
            this.lb_DijkstraSolved.ItemHeight = 20;
            this.lb_DijkstraSolved.Location = new System.Drawing.Point(228, 640);
            this.lb_DijkstraSolved.Margin = new System.Windows.Forms.Padding(4, 5, 4, 29);
            this.lb_DijkstraSolved.Name = "lb_DijkstraSolved";
            this.lb_DijkstraSolved.Size = new System.Drawing.Size(196, 224);
            this.lb_DijkstraSolved.TabIndex = 1;
            // 
            // tv_DijkstraSolved
            // 
            this.tv_DijkstraSolved.Location = new System.Drawing.Point(432, 640);
            this.tv_DijkstraSolved.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tv_DijkstraSolved.Name = "tv_DijkstraSolved";
            this.tv_DijkstraSolved.Size = new System.Drawing.Size(288, 224);
            this.tv_DijkstraSolved.TabIndex = 2;
            // 
            // tb_ClosedRead
            // 
            this.tb_ClosedRead.Location = new System.Drawing.Point(420, 390);
            this.tb_ClosedRead.Margin = new System.Windows.Forms.Padding(4, 5, 30, 5);
            this.tb_ClosedRead.Name = "tb_ClosedRead";
            this.tb_ClosedRead.Size = new System.Drawing.Size(300, 26);
            this.tb_ClosedRead.TabIndex = 3;
            // 
            // tb_OpenedRead
            // 
            this.tb_OpenedRead.Location = new System.Drawing.Point(420, 492);
            this.tb_OpenedRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_OpenedRead.Name = "tb_OpenedRead";
            this.tb_OpenedRead.Size = new System.Drawing.Size(300, 26);
            this.tb_OpenedRead.TabIndex = 4;
            this.tb_OpenedRead.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            // 
            // tb_ClosedPrevious
            // 
            this.tb_ClosedPrevious.Location = new System.Drawing.Point(30, 390);
            this.tb_ClosedPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_ClosedPrevious.Name = "tb_ClosedPrevious";
            this.tb_ClosedPrevious.ReadOnly = true;
            this.tb_ClosedPrevious.Size = new System.Drawing.Size(300, 26);
            this.tb_ClosedPrevious.TabIndex = 5;
            // 
            // tb_OpenedPrevious
            // 
            this.tb_OpenedPrevious.Location = new System.Drawing.Point(30, 492);
            this.tb_OpenedPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_OpenedPrevious.Name = "tb_OpenedPrevious";
            this.tb_OpenedPrevious.ReadOnly = true;
            this.tb_OpenedPrevious.Size = new System.Drawing.Size(300, 26);
            this.tb_OpenedPrevious.TabIndex = 6;
            // 
            // lbl_ClosedPrevious
            // 
            this.lbl_ClosedPrevious.AutoSize = true;
            this.lbl_ClosedPrevious.Location = new System.Drawing.Point(30, 361);
            this.lbl_ClosedPrevious.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ClosedPrevious.Name = "lbl_ClosedPrevious";
            this.lbl_ClosedPrevious.Size = new System.Drawing.Size(153, 20);
            this.lbl_ClosedPrevious.TabIndex = 7;
            this.lbl_ClosedPrevious.Text = " Fermés (précédent)";
            // 
            // lbl_ClosedRead
            // 
            this.lbl_ClosedRead.AutoSize = true;
            this.lbl_ClosedRead.Location = new System.Drawing.Point(416, 361);
            this.lbl_ClosedRead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ClosedRead.Name = "lbl_ClosedRead";
            this.lbl_ClosedRead.Size = new System.Drawing.Size(63, 20);
            this.lbl_ClosedRead.TabIndex = 8;
            this.lbl_ClosedRead.Text = "Fermés";
            // 
            // lbl_OpenedPrevious
            // 
            this.lbl_OpenedPrevious.AutoSize = true;
            this.lbl_OpenedPrevious.Location = new System.Drawing.Point(30, 467);
            this.lbl_OpenedPrevious.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OpenedPrevious.Name = "lbl_OpenedPrevious";
            this.lbl_OpenedPrevious.Size = new System.Drawing.Size(150, 20);
            this.lbl_OpenedPrevious.TabIndex = 9;
            this.lbl_OpenedPrevious.Text = "Ouverts (précédent)";
            // 
            // lbl_OpenedRead
            // 
            this.lbl_OpenedRead.AutoSize = true;
            this.lbl_OpenedRead.Location = new System.Drawing.Point(416, 467);
            this.lbl_OpenedRead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OpenedRead.Name = "lbl_OpenedRead";
            this.lbl_OpenedRead.Size = new System.Drawing.Size(64, 20);
            this.lbl_OpenedRead.TabIndex = 10;
            this.lbl_OpenedRead.Text = "Ouverts";
            // 
            // bt_ClosedOpenRead
            // 
            this.bt_ClosedOpenRead.Location = new System.Drawing.Point(510, 554);
            this.bt_ClosedOpenRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_ClosedOpenRead.Name = "bt_ClosedOpenRead";
            this.bt_ClosedOpenRead.Size = new System.Drawing.Size(120, 35);
            this.bt_ClosedOpenRead.TabIndex = 11;
            this.bt_ClosedOpenRead.Text = "Valider";
            this.bt_ClosedOpenRead.UseVisualStyleBackColor = true;
            this.bt_ClosedOpenRead.Click += new System.EventHandler(this.bt_ClosedOpenRead_Click);
            // 
            // pb_graph
            // 
            this.pb_graph.ImageLocation = "../../SujetGraph.png";
            this.pb_graph.Location = new System.Drawing.Point(73, 81);
            this.pb_graph.Name = "pb_graph";
            this.pb_graph.Size = new System.Drawing.Size(600, 200);
            this.pb_graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_graph.TabIndex = 12;
            this.pb_graph.TabStop = false;
            // 
            // lbl_Correctness
            // 
            this.lbl_Correctness.AutoSize = true;
            this.lbl_Correctness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correctness.Location = new System.Drawing.Point(115, 561);
            this.lbl_Correctness.Name = "lbl_Correctness";
            this.lbl_Correctness.Size = new System.Drawing.Size(0, 20);
            this.lbl_Correctness.TabIndex = 13;
            // 
            // lbl_IndicationsInput
            // 
            this.lbl_IndicationsInput.AutoSize = true;
            this.lbl_IndicationsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IndicationsInput.Location = new System.Drawing.Point(413, 315);
            this.lbl_IndicationsInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IndicationsInput.Name = "lbl_IndicationsInput";
            this.lbl_IndicationsInput.Size = new System.Drawing.Size(0, 20);
            this.lbl_IndicationsInput.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "____________________________________________________________________________";
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instructions.Location = new System.Drawing.Point(49, 29);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(40, 20);
            this.lbl_Instructions.TabIndex = 16;
            this.lbl_Instructions.Text = "test";
            // 
            // DijkstraAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(748, 875);
            this.Controls.Add(this.lbl_Instructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_IndicationsInput);
            this.Controls.Add(this.lbl_Correctness);
            this.Controls.Add(this.pb_graph);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DijkstraAForm";
            this.Text = "Dijkstra";
            ((System.ComponentModel.ISupportInitialize)(this.pb_graph)).EndInit();
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
        private System.Windows.Forms.PictureBox pb_graph;
        private System.Windows.Forms.Label lbl_Correctness;
        private System.Windows.Forms.Label lbl_IndicationsInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Instructions;
    }
}