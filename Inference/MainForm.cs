﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Inference
{
    public partial class MainForm : Form
    {
        struct Position
        {
            public float X;
            public float Y;
        }


        public const int VALEUR_MAX_BORNE = 11;
        public const int VALEUR_MIN_BORNE = 0;

        public const int VALEUR_MIN_Y = 0;
        public const int VALEUR_MAX_Y_F1 = 5;
        public const int VALEUR_MAX_Y_F2 = 5;
        public const int VALEUR_MAX_Y_F3 = 12;
        public const int VALEUR_MAX_Y_F4 = 10;
        public const int VALEUR_MAX_Y_F5 = 4;



        public const int PRECISION_DECIMALES = 4;

        public const int NOMBRE_POINTS_ALEATOIRE = 10000;

        private int nombre_Points_valides = 0;

        private List<RadioButton> listeFonction = new List<RadioButton>();

        private Random random = new Random();

        private const float COTE_Z = 1.96F;


        private int fonction = 0;

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // ajout des radiobuttons dans une liste afin
            // de pouvoir les utiliser dans une boucle
            listeFonction.Add(RBTN_F1);
            listeFonction.Add(RBTN_F2);
            listeFonction.Add(RBTN_F3);
            listeFonction.Add(RBTN_F4);
            listeFonction.Add(RBTN_F5);

            // <= pour inclure la borne max
            for (int i = VALEUR_MIN_BORNE; i <= VALEUR_MAX_BORNE; i++)
            {
                CBX_BorneA.Items.Add(i);
                CBX_BorneB.Items.Add(i);
            }
            CBX_BorneA.SelectedIndex = 0;
            CBX_BorneB.SelectedIndex = CBX_BorneB.Items.Count-1;

        }

        private bool Fonction1(Position p)
        {
            // f1(x) = -1 *( x^2 - 16x + 63)^(1/3)  + 4 
            // -1
            // value * ( x^2 - 16x + 63)^(1/3)
            // value + 4
            float value = (float)Math.Pow(p.X, 2);
            value = value - (16 * p.X) + 63;
            value = (float)(-Math.Pow(value, (1.0F/ 3.0F))) + 4F;
            return p.Y <= value;
        }
        private bool Fonction2(Position p)
        {
            // f2(x) = 3 * (x-7 /5)^5  - 5 * (x-7 /5)^3  + 3
            // 3
            float value = 3.0F;
            // value * (x-7 /5)^5
            value = value * (float)Math.Pow( ( (p.X-7.0F) / 5.0F ), 5);
            // value - (5 * (x-7 /5)^3)
            value = value - (5.0F * (float)Math.Pow( ( (p.X-7.0F) / 5.0F ), 3) );
            // value + 3
            value = value + 3.0F;
            return float.Parse(p.Y.ToString() ) <= value;
        }

        private bool Fonction3(Position p)
        {
            float value = -(1.0f / 3.0f);
            value = value * float.Parse(Math.Pow((p.X - 6), 2).ToString());
            value += 12;
            return float.Parse(p.Y.ToString()) <= value;
        }

        private bool Fonction4(Position p)
        {
            double value = p.X + Math.Sin(p.X);
            return p.Y <= value;
        }

        private bool Fonction5(Position p)
        {
            double value = Math.Cos(p.X) + 3;
            return p.Y <= value;
        }

        public float GenererFloatX()
        {
            float randomNumber = random.Next(VALEUR_MIN_BORNE, VALEUR_MAX_BORNE+1);
            // donne un nombre entre 0.0F et 0.99F
            randomNumber += random.Next(0,100)%100;
            return randomNumber;
        }
        public float GenererFloatY(int valeurMax)
        {
            float randomNumber = random.Next(VALEUR_MIN_Y, valeurMax+1);
            // donne un nombre entre 0.0F et 0.99F
            randomNumber += random.Next(0, 100) % 100;
            return randomNumber;
        }
        public float GetMaxY()
        {
            float y = -1;
            switch (fonction)
            {
                case 0: y = VALEUR_MAX_Y_F1;
                    break;
                case 1: y = VALEUR_MAX_Y_F2;
                    break;
                case 2: y = VALEUR_MAX_Y_F3;
                    break;
                case 3: y = VALEUR_MAX_Y_F4;
                    break;
                case 4: y = VALEUR_MAX_Y_F5;
                    break;
            }
            return y;
        }


        private float CalculerEstimateurPonctuel()
        {
            // réinitialise à zéro pour le nouveau calcul
            nombre_Points_valides = 0;

            Position point;
            bool pointValide = false;

            for (int i = 0; i < NOMBRE_POINTS_ALEATOIRE; i++)
            {
                point.X = GenererFloatX();

                switch (fonction)
                {
                    case 0: point.Y = GenererFloatY(VALEUR_MAX_Y_F1);
                        Fonction1(point);
                        break;
                    case 1: point.Y = GenererFloatY(VALEUR_MAX_Y_F2);
                        pointValide = Fonction2(point);
                        break;
                    case 2: point.Y = GenererFloatY(VALEUR_MAX_Y_F3);
                        pointValide = Fonction3(point);
                        break;
                    case 3: point.Y = GenererFloatY(VALEUR_MAX_Y_F4);
                        pointValide = Fonction4(point);
                        break;
                    case 4: point.Y = GenererFloatY(VALEUR_MAX_Y_F5);
                        pointValide = Fonction5(point);
                        break;
                    default:
                        // problème avec le programme, il devrait toujours y avoir un radiobutton de sélectionné
                        MessageBox.Show("Un problème est survenu. Veuillez redémarrer le programme.");
                        break;
                }
                if (pointValide)
                {
                    nombre_Points_valides++;
                }
                else
                {
                    // ne rien faire
                }
            }

            float estimationPonctuelle = CalculerAire() * (nombre_Points_valides / NOMBRE_POINTS_ALEATOIRE);

            return estimationPonctuelle;
        }


        private float CalculerAire()
        {
            float hauteur = GetMaxY();
            float largeur = float.Parse(CBX_BorneB.Text) - float.Parse(CBX_BorneA.Text);
            float aire = hauteur * largeur;
            return aire;
        }

        private float CalculerMargeErreur()
        {
            float estimationPonctuelle = float.Parse(LB_Value_Estimation_Ponctuelle.Text);
            float me;

            // estimationPonctuelle
            me = estimationPonctuelle/100F;
            // estimationPonctuelle * (1 - estimationPonctuelle)
            me = me *(1.0F - estimationPonctuelle/100F);
            // tout ça / total
            me = me / NOMBRE_POINTS_ALEATOIRE;
            // la racine carré du résultat
            me = (float)Math.Sqrt(double.Parse(me.ToString()));
            // multiplié par la cote Z
            me = me * COTE_Z;
            me = (float)(Math.Round(me, PRECISION_DECIMALES+2) * 100F);
            return me;
        }

        private float CalculerProbabilite()
        {
            float probabilite = -1;
            float aire = CalculerAire();
            switch (fonction)
            {
                case 0: probabilite = (aire/ 24.9026F) * 100F;
                    break;
                case 1: probabilite = (aire / 36.2815F) * 100F;
                    break;
                case 2: probabilite = (aire / 94.1111F) * 100F;
                    break;
                case 3: probabilite = (aire / 94.1111F) * 100F;
                    break;
                case 4: probabilite = (aire / 94.1111F) * 100F;
                    break;
            }

            return probabilite;
        }


        private void BTN_Executer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listeFonction.Count; i++)
            {
                if (listeFonction[i].Checked)
                {
                    fonction = i;
                    break; //optimisation
                }
            }
            LB_Value_Estimation_Ponctuelle.Text = CalculerEstimateurPonctuel().ToString();
            LB_Value_Probabilite.Text = CalculerProbabilite().ToString();


            LB_Value_Marge_Erreur.Text = CalculerMargeErreur().ToString();


            if(LB_Value_Probabilite.Text.Length > PRECISION_DECIMALES)
            {
                LB_Value_Probabilite.Text = LB_Value_Probabilite.Text.Substring(0,PRECISION_DECIMALES+2);
            }

            LB_Value_Estimation_Ponctuelle.Text += "%";
            LB_Value_Probabilite.Text += "%";
        }



    }
}
