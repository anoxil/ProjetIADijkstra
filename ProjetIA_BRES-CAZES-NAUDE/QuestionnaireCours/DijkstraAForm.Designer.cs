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
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.bt_Answers = new System.Windows.Forms.Button();
            this.tv_input = new System.Windows.Forms.TreeView();
            this.bt_sendTvInput = new System.Windows.Forms.Button();
            this.bt_changeNodeTvInput = new System.Windows.Forms.Button();
            this.tb_changeNodeTvInput = new System.Windows.Forms.TextBox();
            this.lbl_tvInput = new System.Windows.Forms.Label();
            this.lbl_line = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_graph)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ClosedRead
            // 
            this.tb_ClosedRead.Location = new System.Drawing.Point(280, 253);
            this.tb_ClosedRead.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.tb_ClosedRead.Name = "tb_ClosedRead";
            this.tb_ClosedRead.Size = new System.Drawing.Size(201, 20);
            this.tb_ClosedRead.TabIndex = 3;
            // 
            // tb_OpenedRead
            // 
            this.tb_OpenedRead.Location = new System.Drawing.Point(280, 320);
            this.tb_OpenedRead.Name = "tb_OpenedRead";
            this.tb_OpenedRead.Size = new System.Drawing.Size(201, 20);
            this.tb_OpenedRead.TabIndex = 4;
            this.tb_OpenedRead.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            // 
            // tb_ClosedPrevious
            // 
            this.tb_ClosedPrevious.Location = new System.Drawing.Point(20, 253);
            this.tb_ClosedPrevious.Name = "tb_ClosedPrevious";
            this.tb_ClosedPrevious.ReadOnly = true;
            this.tb_ClosedPrevious.Size = new System.Drawing.Size(201, 20);
            this.tb_ClosedPrevious.TabIndex = 5;
            // 
            // tb_OpenedPrevious
            // 
            this.tb_OpenedPrevious.Location = new System.Drawing.Point(20, 320);
            this.tb_OpenedPrevious.Name = "tb_OpenedPrevious";
            this.tb_OpenedPrevious.ReadOnly = true;
            this.tb_OpenedPrevious.Size = new System.Drawing.Size(201, 20);
            this.tb_OpenedPrevious.TabIndex = 6;
            // 
            // lbl_ClosedPrevious
            // 
            this.lbl_ClosedPrevious.AutoSize = true;
            this.lbl_ClosedPrevious.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ClosedPrevious.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClosedPrevious.Location = new System.Drawing.Point(20, 235);
            this.lbl_ClosedPrevious.Name = "lbl_ClosedPrevious";
            this.lbl_ClosedPrevious.Size = new System.Drawing.Size(108, 13);
            this.lbl_ClosedPrevious.TabIndex = 7;
            this.lbl_ClosedPrevious.Text = " Fermés (précédent)";
            // 
            // lbl_ClosedRead
            // 
            this.lbl_ClosedRead.AutoSize = true;
            this.lbl_ClosedRead.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ClosedRead.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClosedRead.Location = new System.Drawing.Point(277, 235);
            this.lbl_ClosedRead.Name = "lbl_ClosedRead";
            this.lbl_ClosedRead.Size = new System.Drawing.Size(50, 13);
            this.lbl_ClosedRead.TabIndex = 8;
            this.lbl_ClosedRead.Text = "Fermés";
            // 
            // lbl_OpenedPrevious
            // 
            this.lbl_OpenedPrevious.AutoSize = true;
            this.lbl_OpenedPrevious.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OpenedPrevious.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenedPrevious.Location = new System.Drawing.Point(20, 304);
            this.lbl_OpenedPrevious.Name = "lbl_OpenedPrevious";
            this.lbl_OpenedPrevious.Size = new System.Drawing.Size(108, 13);
            this.lbl_OpenedPrevious.TabIndex = 9;
            this.lbl_OpenedPrevious.Text = "Ouverts (précédent)";
            // 
            // lbl_OpenedRead
            // 
            this.lbl_OpenedRead.AutoSize = true;
            this.lbl_OpenedRead.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OpenedRead.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenedRead.Location = new System.Drawing.Point(277, 304);
            this.lbl_OpenedRead.Name = "lbl_OpenedRead";
            this.lbl_OpenedRead.Size = new System.Drawing.Size(54, 13);
            this.lbl_OpenedRead.TabIndex = 10;
            this.lbl_OpenedRead.Text = "Ouverts";
            // 
            // bt_ClosedOpenRead
            // 
            this.bt_ClosedOpenRead.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ClosedOpenRead.Location = new System.Drawing.Point(340, 360);
            this.bt_ClosedOpenRead.Margin = new System.Windows.Forms.Padding(3, 3, 3, 19);
            this.bt_ClosedOpenRead.Name = "bt_ClosedOpenRead";
            this.bt_ClosedOpenRead.Size = new System.Drawing.Size(80, 23);
            this.bt_ClosedOpenRead.TabIndex = 11;
            this.bt_ClosedOpenRead.Text = "Valider";
            this.bt_ClosedOpenRead.UseVisualStyleBackColor = true;
            this.bt_ClosedOpenRead.Click += new System.EventHandler(this.bt_ClosedOpenRead_Click);
            // 
            // pb_graph
            // 
            this.pb_graph.Location = new System.Drawing.Point(49, 53);
            this.pb_graph.Margin = new System.Windows.Forms.Padding(2);
            this.pb_graph.Name = "pb_graph";
            this.pb_graph.Size = new System.Drawing.Size(400, 130);
            this.pb_graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_graph.TabIndex = 12;
            this.pb_graph.TabStop = false;
            // 
            // lbl_Correctness
            // 
            this.lbl_Correctness.AutoSize = true;
            this.lbl_Correctness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correctness.Location = new System.Drawing.Point(77, 365);
            this.lbl_Correctness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Correctness.Name = "lbl_Correctness";
            this.lbl_Correctness.Size = new System.Drawing.Size(0, 13);
            this.lbl_Correctness.TabIndex = 13;
            // 
            // lbl_IndicationsInput
            // 
            this.lbl_IndicationsInput.AutoSize = true;
            this.lbl_IndicationsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IndicationsInput.Location = new System.Drawing.Point(275, 205);
            this.lbl_IndicationsInput.Name = "lbl_IndicationsInput";
            this.lbl_IndicationsInput.Size = new System.Drawing.Size(0, 13);
            this.lbl_IndicationsInput.TabIndex = 14;
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instructions.Location = new System.Drawing.Point(144, 19);
            this.lbl_Instructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(0, 13);
            this.lbl_Instructions.TabIndex = 16;
            // 
            // bt_Answers
            // 
            this.bt_Answers.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Answers.Location = new System.Drawing.Point(67, 200);
            this.bt_Answers.Name = "bt_Answers";
            this.bt_Answers.Size = new System.Drawing.Size(80, 23);
            this.bt_Answers.TabIndex = 18;
            this.bt_Answers.Text = "Réponses";
            this.bt_Answers.UseVisualStyleBackColor = true;
            this.bt_Answers.Click += new System.EventHandler(this.bt_Answers_Click);
            // 
            // tv_input
            // 
            this.tv_input.Location = new System.Drawing.Point(548, 142);
            this.tv_input.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.tv_input.Name = "tv_input";
            this.tv_input.Size = new System.Drawing.Size(162, 140);
            this.tv_input.TabIndex = 19;
            // 
            // bt_sendTvInput
            // 
            this.bt_sendTvInput.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sendTvInput.Location = new System.Drawing.Point(637, 320);
            this.bt_sendTvInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 19);
            this.bt_sendTvInput.Name = "bt_sendTvInput";
            this.bt_sendTvInput.Size = new System.Drawing.Size(73, 63);
            this.bt_sendTvInput.TabIndex = 20;
            this.bt_sendTvInput.Text = "Valider";
            this.bt_sendTvInput.UseVisualStyleBackColor = true;
            this.bt_sendTvInput.Click += new System.EventHandler(this.bt_sendTvInput_Click);
            // 
            // bt_changeNodeTvInput
            // 
            this.bt_changeNodeTvInput.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_changeNodeTvInput.Location = new System.Drawing.Point(548, 360);
            this.bt_changeNodeTvInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 19);
            this.bt_changeNodeTvInput.Name = "bt_changeNodeTvInput";
            this.bt_changeNodeTvInput.Size = new System.Drawing.Size(73, 23);
            this.bt_changeNodeTvInput.TabIndex = 21;
            this.bt_changeNodeTvInput.Text = "Modifier";
            this.bt_changeNodeTvInput.UseVisualStyleBackColor = true;
            this.bt_changeNodeTvInput.Click += new System.EventHandler(this.bt_changeNodeTvInput_Click);
            // 
            // tb_changeNodeTvInput
            // 
            this.tb_changeNodeTvInput.Location = new System.Drawing.Point(548, 320);
            this.tb_changeNodeTvInput.Name = "tb_changeNodeTvInput";
            this.tb_changeNodeTvInput.Size = new System.Drawing.Size(73, 20);
            this.tb_changeNodeTvInput.TabIndex = 22;
            this.tb_changeNodeTvInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            // 
            // lbl_tvInput
            // 
            this.lbl_tvInput.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tvInput.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tvInput.Location = new System.Drawing.Point(549, 53);
            this.lbl_tvInput.Name = "lbl_tvInput";
            this.lbl_tvInput.Size = new System.Drawing.Size(162, 61);
            this.lbl_tvInput.TabIndex = 23;
            this.lbl_tvInput.Text = "Veuillez sélectionner chaque node de l\'arbre et rentrer sa valeur correcte sous l" +
    "a forme node:cost (i.e. A:0, C:7, G:14, ...)";
            this.lbl_tvInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_line
            // 
            this.lbl_line.BackColor = System.Drawing.Color.Transparent;
            this.lbl_line.Location = new System.Drawing.Point(511, 77);
            this.lbl_line.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(11, 330);
            this.lbl_line.TabIndex = 24;
            this.lbl_line.Text = "||||||||||||||||||||||||||||||||||||||||||";
            // 
            // DijkstraAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 401);
            this.Controls.Add(this.lbl_line);
            this.Controls.Add(this.lbl_tvInput);
            this.Controls.Add(this.tb_changeNodeTvInput);
            this.Controls.Add(this.bt_changeNodeTvInput);
            this.Controls.Add(this.bt_sendTvInput);
            this.Controls.Add(this.tv_input);
            this.Controls.Add(this.bt_Answers);
            this.Controls.Add(this.lbl_Instructions);
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
            this.Name = "DijkstraAForm";
            this.Text = "Dijkstra";
            this.Load += new System.EventHandler(this.DijkstraAForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lbl_Instructions;
        private System.Windows.Forms.Button bt_Answers;
        private System.Windows.Forms.TreeView tv_input;
        private System.Windows.Forms.Button bt_sendTvInput;
        private System.Windows.Forms.Button bt_changeNodeTvInput;
        private System.Windows.Forms.TextBox tb_changeNodeTvInput;
        private System.Windows.Forms.Label lbl_tvInput;
        private System.Windows.Forms.Label lbl_line;
    }
}