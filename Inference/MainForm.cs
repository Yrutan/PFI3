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

        public const float VALEUR_MAX_BORNE = 11.00F;
        public const float VALEUR_MIN_BORNE = 0.00F;

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

        private bool Fonction3(Point p)
        {
            float value = -(1.0f / 3.0f);
            value = value * float.Parse(Math.Pow((p.X - 6), 2).ToString());
            value += 12;
            return float.Parse(p.Y.ToString()) <= value;
        }

        private bool Fonction4(Point p)
        {
            double value = p.X + Math.Sin(p.X);
            return p.Y <= value;
        }

        private bool Fonction5(Point p)
        {
            double value = Math.Cos(p.X) + 3;
            return p.Y <= value;

        }

        private void BTN_Executer_Click(object sender, EventArgs e)
        {
            int fonction = 0;
            for (int i = 0; i < listeFonction.Count; i++)
            {
                if(listeFonction[i].Checked)
                {
                    fonction = i;
                    break; //optimisation
                }
            }

            float point_aleatoire = 0F;
            Point point;
            for (int i = 0; i < NOMBRE_POINTS_ALEATOIRE; i++ )
            {
                point_aleatoire = ;
                point.X = random.Next(0,11);
                point.Y = random.Next(0);
                switch (fonction)
                {
                    case 1: 
                        break;
                    case 2:
                        break;
                    case 3:
                        Fonction3();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        // problème avec le programme
                        break;
                }
            }

        }




    }
}
