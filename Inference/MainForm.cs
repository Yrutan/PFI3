using System;
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

        // le nombre de points valides sous la courbe de la fonction choisi parmi le NOMBRE_POINTS_ALEATOIRE
        private int nombre_Points_valides = 0;

        private List<RadioButton> listeFonction = new List<RadioButton>();

        private Random random = new Random();

        // la cote z pour un niveau de confiance de 95%
        private const float COTE_Z = 1.96F;

        private float estimationPonctuelle = 0;
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

            TBX_BorneA.Text = "0";
            TBX_BorneB.Text = "11";


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
            value = value * float.Parse(Math.Pow((p.X - 6.0F), 2).ToString());
            value = value + 12.0F;
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

        public float GenererFloatX(float a , float b)
        {
            // obtient un nombre entre 0 et 1
            double randomNumber = random.NextDouble();
            // le multiplie pour obtenir un nombre entre l'interval voulu
            // Math.Abs retourne la valeur absolue de (a - b)
            randomNumber = randomNumber * Math.Abs(a - b);
            // ajoute la valeur minimum afin d'obtenir un nombre entre les valeurs voulues
            // Math.Min retourne le plus petit des deux nombres
            randomNumber = randomNumber + Math.Min(a,b);
            // arrondit pour qu'il ne reste plus que 2 décimales
            randomNumber = Math.Round(randomNumber, 2);

            return (float)randomNumber;
        }
        public float GenererFloatY()
        {
            // obtient un nombre entre 0 et 1
            double randomNumber = random.NextDouble();
            // le multiplie pour obtenir un nombre entre l'interval voulu
            randomNumber = randomNumber * (GetMaxY() - VALEUR_MIN_Y);
            // ajoute la valeur minimum afin d'obtenir un nombre entre les valeurs voulues
            randomNumber = randomNumber + VALEUR_MIN_Y;
            // arrondit pour qu'il ne reste plus que 2 décimales
            randomNumber = Math.Round(randomNumber, 2);

            return (float)randomNumber;
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


        private void GenererPointsEstimationPoncutelle()
        {
            nombre_Points_valides = 0;
            Position point;
            bool pointValide = false;

            float borneA = float.Parse(TBX_BorneA.Text);
            float borneB = float.Parse(TBX_BorneB.Text);

            for (int i = 0; i < NOMBRE_POINTS_ALEATOIRE; i++)
            {
                point.X = GenererFloatX(borneA, borneB);

                switch (fonction)
                {
                    case 0: point.Y = GenererFloatY();
                        Fonction1(point);
                        break;
                    case 1: point.Y = GenererFloatY();
                        pointValide = Fonction2(point);
                        break;
                    case 2: point.Y = GenererFloatY();
                        pointValide = Fonction3(point);
                        break;
                    case 3: point.Y = GenererFloatY();
                        pointValide = Fonction4(point);
                        break;
                    case 4: point.Y = GenererFloatY();
                        pointValide = Fonction5(point);
                        break;
                    default:
                        // problème avec le programme, il devrait toujours y avoir un bouton radio de sélectionné
                        MessageBox.Show("Un problème est survenu. Veuillez redémarrer le programme.");
                        break;
                }
                if (pointValide)
                {
                    nombre_Points_valides++;
                }
                else
                {
                    //si le point n'est pas valide, ne rien faire
                }
            }
        }

        private void CalculerEstimationPonctuel()
        {
            GenererPointsEstimationPoncutelle();
            estimationPonctuelle = CalculerAireRectangle() * 
                ((float)nombre_Points_valides / (float)NOMBRE_POINTS_ALEATOIRE);
        }


        private float CalculerAireRectangle()
        {
            float hauteur = GetMaxY();
            float largeur = float.Parse(TBX_BorneA.Text) - float.Parse(TBX_BorneB.Text);
            if(largeur < 0)
            {
                largeur = -largeur;
            }

            float aire = hauteur * largeur;
            return aire;
        }

        private float CalculerMargeErreur()
        {
            float margeErreur;

            // ( estimationPonctuelle * (1 - estimationPonctuelle) / NOMBRE_POINTS_ALEATOIRE )^(1/2)  * COTE_Z
            margeErreur = estimationPonctuelle/100F;
            margeErreur = margeErreur *(1.0F - estimationPonctuelle/100F);
            margeErreur = margeErreur / NOMBRE_POINTS_ALEATOIRE;
            // la racine carré du résultat
            margeErreur = (float)Math.Sqrt(double.Parse(margeErreur.ToString()));
            margeErreur = margeErreur * COTE_Z;
            margeErreur = margeErreur * 100F;
            // arrondir à 4 décimales
            margeErreur = (float)(Math.Round(margeErreur, PRECISION_DECIMALES));
            return margeErreur;
        }

        private float CalculerProbabilite()
        {
            double probabilite = 0;
            float margeErreur = CalculerMargeErreur();
            switch (fonction)
            {
                case 0:
                    probabilite = Math.Round((estimationPonctuelle / 24.9026F) * 100F, PRECISION_DECIMALES);
                    break;
                case 1:
                    probabilite = Math.Round((estimationPonctuelle / 36.2815F) * 100F, PRECISION_DECIMALES);
                    break;
                case 2:
                    probabilite = Math.Round((estimationPonctuelle / CalculerAireRectangle()) * 100F, PRECISION_DECIMALES);
                    break;
                case 3:
                    probabilite = Math.Round((estimationPonctuelle / 61.4956F) * 100F, PRECISION_DECIMALES);
                    break;
                case 4:
                    probabilite = Math.Round((estimationPonctuelle / 32.0F) * 100F, PRECISION_DECIMALES);
                    break;
            }


            return (float)probabilite;
        }

        private void BTN_Executer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listeFonction.Count; i++)
            {
                if (listeFonction[i].Checked)
                {
                    fonction = i;
                    break;
                }
            }
            CalculerEstimationPonctuel();

            LB_Value_Estimation_Ponctuelle.Text = estimationPonctuelle.ToString();
            
            LB_Value_Probabilite.Text = CalculerProbabilite().ToString() + "%";

            LB_Value_Probabilite.Text = CalculerProbabilite().ToString() + "%";

            LB_Value_Marge_Erreur.Text = CalculerMargeErreur().ToString() + "%";

            LB_Value_IntervalleConfiance.Text = (CalculerProbabilite() - CalculerMargeErreur()).ToString() + "%" 
                + " à " + (CalculerProbabilite() + CalculerMargeErreur()).ToString() + "%"; 
            
        }

        private void TBX_TextChanged(object sender, EventArgs e)
        {
            if(TBX_BorneA.Text.Length > 0 && TBX_BorneB.Text.Length > 0)
            {
                BTN_Executer.Enabled = true;
            }
            else
            {
                BTN_Executer.Enabled = false;
            }
        }

    }
}
