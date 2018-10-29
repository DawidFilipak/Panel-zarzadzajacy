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
namespace Panel_zarządzający
{
    ///<summary>Klasa dodaje nowego pracownika </summary>
    

    public partial class Rejestracja : Form
    {
        
           public  int Add(int liczbaA, int liczbaB)
            {
               return liczbaA + liczbaB;
            }
           public int Sub(int liczbaA, int liczbaB)
            {
                return liczbaA - liczbaB;
            }
           public int Mul(int liczbaA, int liczbaB)
            {
                return liczbaA * liczbaB;
            }
            public int Div(int liczbaA, int liczbaB)
            {
          
            return liczbaA / liczbaB;
            }
        
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\STUDIA !!!!!\IV semestr\Programowanie\Panel-zarzadzajacy\Panel zarządzający\Panel zarządzający\Bazydanych\Bazydanych.mdf; Integrated Security = True";

       

        public Rejestracja()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Medota sluzy do dodawania nowego pracownika
        /// </summary>
        /// <returns>Dodaje nowe rekordy do tabeli Pracownicy</returns>
        /// <param name="sender">Odwołanie do przycisku Zapisz </param>
        /// <param name="e">Przekazuje określone zdarzenie, zapisuje dane</param>

        public void butt_zaloguj_Click(object sender, EventArgs e)
        {
            if (txtImie.Text == "" || txtNazwisko.Text == "" || txtAdres.Text == "" || txtEmail.Text == "" || txtLogin.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Proszę wprowadzić dane");
            }
            else
            {

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {   
                    if (txtPassword.Text == txtPotPassword.Text)
                    {
                       
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("PracownicyAdd", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@Imie", txtImie.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Nazwisko", txtNazwisko.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Adres", txtAdres.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Login", txtLogin.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Pracownik dodawny pomyślnie");
                        txtImie.Clear();
                        txtNazwisko.Clear();
                        txtAdres.Clear();
                        txtEmail.Clear();
                        txtLogin.Clear();
                        txtPassword.Clear();
                        txtPotPassword.Clear();
                    }
                   
                    else
                    {
                        MessageBox.Show("Nieprawidłowo wpisane hasło");
                        txtPassword.Clear();
                        txtPotPassword.Clear();
                    }
                }
            }

        }
        /// <summary>
        /// Metoda do czyszczenia wprowadzonych danych
        /// </summary>
        /// <param name="sender">Odwołanie do przycisku Wyczyść </param>
        /// <param name="e">Przekazuje zdarzenie, czyści wprowadzone dane w TextBoxach</param>

        public void butt_wyczysc_Click(object sender, EventArgs e)
        {
            txtImie.Clear();
            txtNazwisko.Clear();
            txtAdres.Clear();
            txtEmail.Clear();
            txtLogin.Clear();
            txtPassword.Clear();
            txtPotPassword.Clear();
        }

       
    }
}
