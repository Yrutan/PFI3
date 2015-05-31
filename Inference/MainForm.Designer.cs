namespace Inference
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.RBTN_F1 = new System.Windows.Forms.RadioButton();
            this.RBTN_F2 = new System.Windows.Forms.RadioButton();
            this.RBTN_F3 = new System.Windows.Forms.RadioButton();
            this.RBTN_F4 = new System.Windows.Forms.RadioButton();
            this.RBTN_F5 = new System.Windows.Forms.RadioButton();
            this.LB_Borne_a = new System.Windows.Forms.Label();
            this.LB_Borne_b = new System.Windows.Forms.Label();
            this.LB_Probabilite = new System.Windows.Forms.Label();
            this.LB_Estimation_Ponctuelle = new System.Windows.Forms.Label();
            this.LB_Intervalle = new System.Windows.Forms.Label();
            this.LB_Marge_Erreur = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BTN_Executer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RBTN_F1
            // 
            this.RBTN_F1.AutoSize = true;
            this.RBTN_F1.Location = new System.Drawing.Point(12, 21);
            this.RBTN_F1.Name = "RBTN_F1";
            this.RBTN_F1.Size = new System.Drawing.Size(34, 17);
            this.RBTN_F1.TabIndex = 1;
            this.RBTN_F1.TabStop = true;
            this.RBTN_F1.Text = "f1";
            this.RBTN_F1.UseVisualStyleBackColor = true;
            // 
            // RBTN_F2
            // 
            this.RBTN_F2.AutoSize = true;
            this.RBTN_F2.Location = new System.Drawing.Point(12, 44);
            this.RBTN_F2.Name = "RBTN_F2";
            this.RBTN_F2.Size = new System.Drawing.Size(34, 17);
            this.RBTN_F2.TabIndex = 1;
            this.RBTN_F2.TabStop = true;
            this.RBTN_F2.Text = "f2";
            this.RBTN_F2.UseVisualStyleBackColor = true;
            // 
            // RBTN_F3
            // 
            this.RBTN_F3.AutoSize = true;
            this.RBTN_F3.Location = new System.Drawing.Point(12, 67);
            this.RBTN_F3.Name = "RBTN_F3";
            this.RBTN_F3.Size = new System.Drawing.Size(34, 17);
            this.RBTN_F3.TabIndex = 1;
            this.RBTN_F3.TabStop = true;
            this.RBTN_F3.Text = "f3";
            this.RBTN_F3.UseVisualStyleBackColor = true;
            // 
            // RBTN_F4
            // 
            this.RBTN_F4.AutoSize = true;
            this.RBTN_F4.Location = new System.Drawing.Point(12, 90);
            this.RBTN_F4.Name = "RBTN_F4";
            this.RBTN_F4.Size = new System.Drawing.Size(34, 17);
            this.RBTN_F4.TabIndex = 1;
            this.RBTN_F4.TabStop = true;
            this.RBTN_F4.Text = "f4";
            this.RBTN_F4.UseVisualStyleBackColor = true;
            // 
            // RBTN_F5
            // 
            this.RBTN_F5.AutoSize = true;
            this.RBTN_F5.Location = new System.Drawing.Point(12, 113);
            this.RBTN_F5.Name = "RBTN_F5";
            this.RBTN_F5.Size = new System.Drawing.Size(34, 17);
            this.RBTN_F5.TabIndex = 1;
            this.RBTN_F5.TabStop = true;
            this.RBTN_F5.Text = "f5";
            this.RBTN_F5.UseVisualStyleBackColor = true;
            // 
            // LB_Borne_a
            // 
            this.LB_Borne_a.AutoSize = true;
            this.LB_Borne_a.Location = new System.Drawing.Point(220, 27);
            this.LB_Borne_a.Name = "LB_Borne_a";
            this.LB_Borne_a.Size = new System.Drawing.Size(52, 13);
            this.LB_Borne_a.TabIndex = 2;
            this.LB_Borne_a.Text = "borne a : ";
            // 
            // LB_Borne_b
            // 
            this.LB_Borne_b.AutoSize = true;
            this.LB_Borne_b.Location = new System.Drawing.Point(220, 54);
            this.LB_Borne_b.Name = "LB_Borne_b";
            this.LB_Borne_b.Size = new System.Drawing.Size(49, 13);
            this.LB_Borne_b.TabIndex = 2;
            this.LB_Borne_b.Text = "borne b :";
            // 
            // LB_Probabilite
            // 
            this.LB_Probabilite.AutoSize = true;
            this.LB_Probabilite.Location = new System.Drawing.Point(220, 136);
            this.LB_Probabilite.Name = "LB_Probabilite";
            this.LB_Probabilite.Size = new System.Drawing.Size(62, 13);
            this.LB_Probabilite.TabIndex = 2;
            this.LB_Probabilite.Text = "Probabilité :";
            // 
            // LB_Estimation_Ponctuelle
            // 
            this.LB_Estimation_Ponctuelle.AutoSize = true;
            this.LB_Estimation_Ponctuelle.Location = new System.Drawing.Point(220, 113);
            this.LB_Estimation_Ponctuelle.Name = "LB_Estimation_Ponctuelle";
            this.LB_Estimation_Ponctuelle.Size = new System.Drawing.Size(113, 13);
            this.LB_Estimation_Ponctuelle.TabIndex = 2;
            this.LB_Estimation_Ponctuelle.Text = "Estimation ponctuelle :";
            // 
            // LB_Intervalle
            // 
            this.LB_Intervalle.AutoSize = true;
            this.LB_Intervalle.Location = new System.Drawing.Point(220, 159);
            this.LB_Intervalle.Name = "LB_Intervalle";
            this.LB_Intervalle.Size = new System.Drawing.Size(121, 13);
            this.LB_Intervalle.TabIndex = 2;
            this.LB_Intervalle.Text = "Intervalle de confiance :";
            // 
            // LB_Marge_Erreur
            // 
            this.LB_Marge_Erreur.AutoSize = true;
            this.LB_Marge_Erreur.Location = new System.Drawing.Point(220, 181);
            this.LB_Marge_Erreur.Name = "LB_Marge_Erreur";
            this.LB_Marge_Erreur.Size = new System.Drawing.Size(81, 13);
            this.LB_Marge_Erreur.TabIndex = 2;
            this.LB_Marge_Erreur.Text = "Marge d\'erreur :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(279, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(54, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(279, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(54, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // BTN_Executer
            // 
            this.BTN_Executer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Executer.Location = new System.Drawing.Point(223, 224);
            this.BTN_Executer.Name = "BTN_Executer";
            this.BTN_Executer.Size = new System.Drawing.Size(78, 29);
            this.BTN_Executer.TabIndex = 4;
            this.BTN_Executer.Text = "Exécuter";
            this.BTN_Executer.UseVisualStyleBackColor = true;
            this.BTN_Executer.Click += new System.EventHandler(this.BTN_Executer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 284);
            this.Controls.Add(this.BTN_Executer);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LB_Estimation_Ponctuelle);
            this.Controls.Add(this.LB_Marge_Erreur);
            this.Controls.Add(this.LB_Intervalle);
            this.Controls.Add(this.LB_Probabilite);
            this.Controls.Add(this.LB_Borne_b);
            this.Controls.Add(this.LB_Borne_a);
            this.Controls.Add(this.RBTN_F5);
            this.Controls.Add(this.RBTN_F4);
            this.Controls.Add(this.RBTN_F3);
            this.Controls.Add(this.RBTN_F2);
            this.Controls.Add(this.RBTN_F1);
            this.Name = "MainForm";
            this.Text = "Inférence et probabilités";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBTN_F1;
        private System.Windows.Forms.RadioButton RBTN_F2;
        private System.Windows.Forms.RadioButton RBTN_F3;
        private System.Windows.Forms.RadioButton RBTN_F4;
        private System.Windows.Forms.RadioButton RBTN_F5;
        private System.Windows.Forms.Label LB_Borne_a;
        private System.Windows.Forms.Label LB_Borne_b;
        private System.Windows.Forms.Label LB_Probabilite;
        private System.Windows.Forms.Label LB_Estimation_Ponctuelle;
        private System.Windows.Forms.Label LB_Intervalle;
        private System.Windows.Forms.Label LB_Marge_Erreur;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BTN_Executer;
    }
}

