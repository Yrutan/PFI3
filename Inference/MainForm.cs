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

        private int nombre_Points_valide = 0;

        private List<RadioButton> listeFonction = new List<RadioButton>();

        private Random random = new Random();


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
        }
        private bool Fonction1(Position p)
        {
            // f1(x) = -1 *( x^2 - 16x + 63)^(1/3)  + 4 
            // -1
            float value = -1;
            // value * ( x^2 - 16x + 63)^(1/3)
            value = value * float.Parse(Math.Pow(((p.X - 7.0F) / 5.0F), 1.0F/3.0F).ToString());
            // 
            value = value - (5.0F * float.Parse(Math.Pow(((p.X - 7.0F) / 5.0F), 3).ToString()));
            // value + 4
            value = value + 4.0F;
            return float.Parse(p.Y.ToString()) <= value;
        }
        private bool Fonction2(Position p)
        {
            // f2(x) = 3 * (x-7 /5)^5  - 5 * (x-7 /5)^3  + 3
            // 3
            float value = 3.0F;
            // value * (x-7 /5)^5
            value = value * float.Parse(Math.Pow( ( (p.X-7.0F)/5.0F),5).ToString() );
            // value - 5 * (x-7 /5)^3
            value = value - (5.0F * float.Parse(Math.Pow( ( (p.X-7.0F)/5.0F),3).ToString() ) );
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

        private void BTN_Executer_Click(object sender, EventArgs e)
        {
            // réinitialise à zéro pour le nouveau calcul
            nombre_Points_valide = 0;

            int fonction = 0;
            for (int i = 0; i < listeFonction.Count; i++)
            {
                if(listeFonction[i].Checked)
                {
                    fonction = i;
                    break; //optimisation
                }
            }

            Position point;
            bool pointValide = false;

            for (int i = 0; i < NOMBRE_POINTS_ALEATOIRE; i++ )
            {
                point.X = GenererFloatX();

                switch (fonction)
                {
                    case 1: point.Y = GenererFloatY(VALEUR_MAX_Y_F1);
                        Fonction1(point);
                        break;
                    case 2: point.Y = GenererFloatY(VALEUR_MAX_Y_F2);
                        pointValide = Fonction2(point);
                        break;
                    case 3: point.Y = GenererFloatY(VALEUR_MAX_Y_F3);
                        pointValide = Fonction3(point);
                        break;
                    case 4: point.Y = GenererFloatY(VALEUR_MAX_Y_F4);
                        pointValide = Fonction4(point);
                        break;
                    case 5: point.Y = GenererFloatY(VALEUR_MAX_Y_F5);
                        pointValide = Fonction5(point);
                        break;
                    default:
                        // problème avec le programme, il devrait toujours y avoir un radiobutton de sélectionné
                        MessageBox.Show("Un problème est survenu. Veuillez redémarrer le programme.");
                        break;
                }
                if(pointValide)
                {
                    nombre_Points_valide++;
                }
                else
                {
                    // ne rien faire
                }
            }

        }




    }
}
