using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using System.Data.Linq;
using Panel_zarządzający.Bazydanych;

namespace Panel_zarządzający
{
    ///<summary>Klasa służąca do logowania</summary>
   
      
    public partial class Logowanie : Form
    {

        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\STUDIA !!!!!\IV semestr\Programowanie\Panel-zarzadzajacy\Panel zarządzający\Panel zarządzający\Bazydanych\Bazydanych.mdf; Integrated Security = True";
       
     

        public Logowanie()
        {
            InitializeComponent();
           
        }
        

        private void butt_rejestracja_Click(object sender, EventArgs e)
        {
            new Rejestracja().Show();
        }

        ///<summary>
        ///Metoda służąca do sprawdzania danych pracownika
        ///</summary>
        /// <param name="sender">Odwołanie do przycisku Zaloguj </param>
        /// <param name="e">Przekazuje określone zdarzenie, nastepuje zalogowanie do glównego okna</param>


        private void butt_zaloguj_Click(object sender, EventArgs e)
        {
            
            DataTable result = null;
            
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {  
                sqlCon.Open();
                using (SqlCommand cmd = sqlCon.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText="Select Imie, Nazwisko from Pracownicy where Login = '" + login.Text + "' and password = '" + password.Text +"'";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                       
                        result = new DataTable();
                        da.Fill(result);
                        if (result.Rows.Count == 1)
                        {
                            
                            this.Hide();
                            new OknoGlowne().Show();
                            

                           
                        }
                        else
                        {
                            MessageBox.Show("Nieprawidłowy login lub hasło");
                        }

                       
                    }
                }
            }

            
        }
        /// <summary>
        /// Metoda służąca do czyszczenia wpisanych danych
        /// </summary>
        /// <param name="sender">Odwołanie do przycisku Wyczyść </param>
        /// <param name="e">Przekazuje określone zdarzenie, czyści wporwadzone dane</param>


        private void butt_wyczysc_Click(object sender, EventArgs e)
        {
           
            login.Clear();
            password.Clear();
        }
    }
}
