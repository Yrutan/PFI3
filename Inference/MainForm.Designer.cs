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
            this.CBX_BorneA = new System.Windows.Forms.ComboBox();
            this.CBX_BorneB = new System.Windows.Forms.ComboBox();
            this.BTN_Executer = new System.Windows.Forms.Button();
            this.LB_Value_Estimation_Ponctuelle = new System.Windows.Forms.Label();
            this.LB_Value_Probabilite = new System.Windows.Forms.Label();
            this.LB_IntervalleConfiance = new System.Windows.Forms.Label();
            this.LB_Value_Marge_Erreur = new System.Windows.Forms.Label();
            this.LB_Aire = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_Value_Aire = new System.Windows.Forms.Label();
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
            this.RBTN_F2.TabIndex = 2;
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
            this.RBTN_F3.TabIndex = 3;
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
            this.RBTN_F4.TabIndex = 4;
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
            this.RBTN_F5.TabIndex = 5;
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
            this.LB_Probabilite.Location = new System.Drawing.Point(12, 191);
            this.LB_Probabilite.Name = "LB_Probabilite";
            this.LB_Probabilite.Size = new System.Drawing.Size(62, 13);
            this.LB_Probabilite.TabIndex = 2;
            this.LB_Probabilite.Text = "Probabilité :";
            // 
            // LB_Estimation_Ponctuelle
            // 
            this.LB_Estimation_Ponctuelle.AutoSize = true;
            this.LB_Estimation_Ponctuelle.Location = new System.Drawing.Point(12, 147);
            this.LB_Estimation_Ponctuelle.Name = "LB_Estimation_Ponctuelle";
            this.LB_Estimation_Ponctuelle.Size = new System.Drawing.Size(113, 13);
            this.LB_Estimation_Ponctuelle.TabIndex = 2;
            this.LB_Estimation_Ponctuelle.Text = "Estimation ponctuelle :";
            // 
            // LB_Intervalle
            // 
            this.LB_Intervalle.AutoSize = true;
            this.LB_Intervalle.Location = new System.Drawing.Point(12, 217);
            this.LB_Intervalle.Name = "LB_Intervalle";
            this.LB_Intervalle.Size = new System.Drawing.Size(121, 13);
            this.LB_Intervalle.TabIndex = 2;
            this.LB_Intervalle.Text = "Intervalle de confiance :";
            // 
            // LB_Marge_Erreur
            // 
            this.LB_Marge_Erreur.AutoSize = true;
            this.LB_Marge_Erreur.Location = new System.Drawing.Point(12, 239);
            this.LB_Marge_Erreur.Name = "LB_Marge_Erreur";
            this.LB_Marge_Erreur.Size = new System.Drawing.Size(81, 13);
            this.LB_Marge_Erreur.TabIndex = 2;
            this.LB_Marge_Erreur.Text = "Marge d\'erreur :";
            // 
            // CBX_BorneA
            // 
            this.CBX_BorneA.FormattingEnabled = true;
            this.CBX_BorneA.Location = new System.Drawing.Point(279, 23);
            this.CBX_BorneA.Name = "CBX_BorneA";
            this.CBX_BorneA.Size = new System.Drawing.Size(54, 21);
            this.CBX_BorneA.TabIndex = 6;
            // 
            // CBX_BorneB
            // 
            this.CBX_BorneB.FormattingEnabled = true;
            this.CBX_BorneB.Location = new System.Drawing.Point(279, 50);
            this.CBX_BorneB.Name = "CBX_BorneB";
            this.CBX_BorneB.Size = new System.Drawing.Size(54, 21);
            this.CBX_BorneB.TabIndex = 7;
            // 
            // BTN_Executer
            // 
            this.BTN_Executer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Executer.Location = new System.Drawing.Point(15, 264);
            this.BTN_Executer.Name = "BTN_Executer";
            this.BTN_Executer.Size = new System.Drawing.Size(78, 29);
            this.BTN_Executer.TabIndex = 8;
            this.BTN_Executer.Text = "Exécuter";
            this.BTN_Executer.UseVisualStyleBackColor = true;
            this.BTN_Executer.Click += new System.EventHandler(this.BTN_Executer_Click);
            // 
            // LB_Value_Estimation_Ponctuelle
            // 
            this.LB_Value_Estimation_Ponctuelle.AutoSize = true;
            this.LB_Value_Estimation_Ponctuelle.Location = new System.Drawing.Point(131, 147);
            this.LB_Value_Estimation_Ponctuelle.Name = "LB_Value_Estimation_Ponctuelle";
            this.LB_Value_Estimation_Ponctuelle.Size = new System.Drawing.Size(0, 13);
            this.LB_Value_Estimation_Ponctuelle.TabIndex = 5;
            // 
            // LB_Value_Probabilite
            // 
            this.LB_Value_Probabilite.AutoSize = true;
            this.LB_Value_Probabilite.Location = new System.Drawing.Point(131, 191);
            this.LB_Value_Probabilite.Name = "LB_Value_Probabilite";
            this.LB_Value_Probabilite.Size = new System.Drawing.Size(0, 13);
            this.LB_Value_Probabilite.TabIndex = 5;
            // 
            // LB_IntervalleConfiance
            // 
            this.LB_IntervalleConfiance.AutoSize = true;
            this.LB_IntervalleConfiance.Location = new System.Drawing.Point(131, 217);
            this.LB_IntervalleConfiance.Name = "LB_IntervalleConfiance";
            this.LB_IntervalleConfiance.Size = new System.Drawing.Size(0, 13);
            this.LB_IntervalleConfiance.TabIndex = 5;
            // 
            // LB_Value_Marge_Erreur
            // 
            this.LB_Value_Marge_Erreur.AutoSize = true;
            this.LB_Value_Marge_Erreur.Location = new System.Drawing.Point(131, 239);
            this.LB_Value_Marge_Erreur.Name = "LB_Value_Marge_Erreur";
            this.LB_Value_Marge_Erreur.Size = new System.Drawing.Size(0, 13);
            this.LB_Value_Marge_Erreur.TabIndex = 5;
            // 
            // LB_Aire
            // 
            this.LB_Aire.AutoSize = true;
            this.LB_Aire.Location = new System.Drawing.Point(12, 169);
            this.LB_Aire.Name = "LB_Aire";
            this.LB_Aire.Size = new System.Drawing.Size(67, 13);
            this.LB_Aire.TabIndex = 2;
            this.LB_Aire.Text = "Aire estimé : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // LB_Value_Aire
            // 
            this.LB_Value_Aire.AutoSize = true;
            this.LB_Value_Aire.Location = new System.Drawing.Point(133, 169);
            this.LB_Value_Aire.Name = "LB_Value_Aire";
            this.LB_Value_Aire.Size = new System.Drawing.Size(0, 13);
            this.LB_Value_Aire.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 328);
            this.Controls.Add(this.LB_Value_Marge_Erreur);
            this.Controls.Add(this.LB_IntervalleConfiance);
            this.Controls.Add(this.LB_Value_Aire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LB_Value_Probabilite);
            this.Controls.Add(this.LB_Value_Estimation_Ponctuelle);
            this.Controls.Add(this.BTN_Executer);
            this.Controls.Add(this.CBX_BorneB);
            this.Controls.Add(this.CBX_BorneA);
            this.Controls.Add(this.LB_Estimation_Ponctuelle);
            this.Controls.Add(this.LB_Marge_Erreur);
            this.Controls.Add(this.LB_Aire);
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
        private System.Windows.Forms.ComboBox CBX_BorneA;
        private System.Windows.Forms.ComboBox CBX_BorneB;
        private System.Windows.Forms.Button BTN_Executer;
        private System.Windows.Forms.Label LB_Value_Estimation_Ponctuelle;
        private System.Windows.Forms.Label LB_Value_Probabilite;
        private System.Windows.Forms.Label LB_IntervalleConfiance;
        private System.Windows.Forms.Label LB_Value_Marge_Erreur;
        private System.Windows.Forms.Label LB_Aire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_Value_Aire;
    }
}

