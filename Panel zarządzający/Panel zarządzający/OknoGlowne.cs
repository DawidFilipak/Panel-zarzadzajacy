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
    /// <summary>
    /// Okno główne programu
    /// </summary>
   

    public partial class OknoGlowne : Form
    {  

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\STUDIA !!!!!\IV semestr\Programowanie\Panel-zarzadzajacy\Panel zarządzający\Panel zarządzający\Bazydanych\Bazydanych.mdf; Integrated Security = True";

        

        public OknoGlowne()
        {  
            InitializeComponent();
            panelMontaze.Hide();
            panel2.Hide();
            panelData.Hide();
            panelNMontaz.Hide();
        }

        /// <summary>
        /// Metoda do wylogowania z programu
        /// </summary>
        /// <param name="sender">Odwołanie do przycisku Wyloguj </param>
        /// <param name="e">Przekazuje określone zdarzenie, wylogowuje z programu</param>


        private void Wyloguj_Click(object sender, EventArgs e)
        { 
            this.Close();
            new Logowanie().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panelData.Hide();
            panelNMontaz.Hide();
            panelMontaze.Hide();
        }
        /// <summary>
        /// Metoda do czyszczenia wprowadzonych danych
        /// </summary>
        /// <param name="sender">Odwołanie do przycisku Wyczyść </param>
        /// <param name="e">Przekazuje określone zdarzenie, czyści wprowadzone dane w TextBoxach</param>


        private void buttWyczusc_Click(object sender, EventArgs e)
        {
            tbklImie.Clear();
            tbklNazwisko.Clear();
            tbklAdres.Clear();
            tbklDowod.Clear();
            tbklPesel.Clear();
            tbklTelefon.Clear();
        }
        /// <summary>
        /// Sprawdza czy zostały odpowiednio wprowadzone dane jeśli tak klient zostaje dodany
        /// </summary>
        /// <returns> Dodaje nowe rekordy do tabeli Klienci</returns>
        /// <param name="sender"> Odwołanie do przycisku Dodaj </param>
        /// <param name="e"> Przekazuje określone zdarzenie, zapisuje wprowadzone dane do tabeli</param>

        private void buttDodajKlienta_Click(object sender, EventArgs e)
        { 
            if (tbklImie.Text == "" || tbklNazwisko.Text == "" || tbklAdres.Text == "" || tbklDowod.Text == "" || tbklPesel.Text == "" || tbklTelefon.Text == "")
            {
                MessageBox.Show("Proszę wprowadzić dane");
            }
            else
            {

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    if (tbklDowod.Text.Length == 9)
                    {
                        
                        if (tbklPesel.Text.Length == 11)
                        {
                            if (tbklTelefon.Text.Length == 9)
                            {
                               
                                sqlCon.Open();
                                SqlCommand sqlCmd = new SqlCommand("KlienciAdd", sqlCon);
                                sqlCmd.CommandType = CommandType.StoredProcedure;

                                sqlCmd.Parameters.AddWithValue("@Imie", tbklImie.Text.Trim());
                                sqlCmd.Parameters.AddWithValue("@Nazwisko", tbklNazwisko.Text.Trim());
                                sqlCmd.Parameters.AddWithValue("@Adres", tbklAdres.Text.Trim());
                                sqlCmd.Parameters.AddWithValue("@NrDowodu", tbklDowod.Text.Trim());
                                sqlCmd.Parameters.AddWithValue("@Pesel", tbklPesel.Text.Trim());
                                sqlCmd.Parameters.AddWithValue("@NrTelefonu", tbklTelefon.Text.Trim());
                                sqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Klient dodawny pomyślnie");
                                tbklImie.Clear();
                                tbklNazwisko.Clear();
                                tbklAdres.Clear();
                                tbklDowod.Clear();
                                tbklPesel.Clear();
                                tbklTelefon.Clear();
                            }
                            else { MessageBox.Show("Proszę poprawić Numer telefonu"); }
                        }
                        else { MessageBox.Show("Proszę poprawić pesel"); }
                    }
                    
                    else { MessageBox.Show("Proszę poprawić Numer dowodu"); }

                    sqlCon.Close();
                   
                }
            }

        }
        private void buttCofnij_Click(object sender, EventArgs e)
        {
            panel2.Hide() ;
            
        }
        /// <summary>
        /// Metoda wyświetla baze klientów
        /// </summary>
        /// <param name="sender">Odwołanie do przycisku Lista Klientów </param>
        /// <param name="e">Przekazuje określone zdarzenie, wyświetla tabele z danymi</param>

        private void label2_Click(object sender, EventArgs e)
        {
            panelData.Show();
            panel2.Hide();
            panelNMontaz.Hide();
            panelMontaze.Hide();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                DataTable returnTable = new DataTable();
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "Select * from Klienci";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(returnTable);
                sqlCon.Close();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = returnTable;
            }
            
        }

        
        private void label4_Click(object sender, EventArgs e)
        {
            panelNMontaz.Show();
            panel2.Hide();
            panelData.Hide();
            panelMontaze.Hide();
            
            
        }
        /// <summary>
        /// Metoda czyści wprowadzone dane dodawania nowego klienta
        /// </summary>
        /// <param name="sender">Odwołanie do przycisku Wyczyść </param>
        /// <param name="e">Przekazuje określone zdarzenie, czyści wprowadzone dane</param>

        private void buttWyczyscNmontaz_Click(object sender, EventArgs e)
        {
            tbNMImie.Clear();
            tbNMNazwisko.Clear();
            tbNMadres.Clear();
        }
        private void buttCofNmontaz_Click(object sender, EventArgs e)
        {
            panelNMontaz.Hide();
        }

        /// <summary>
        /// Wyswietla tabele z danymi
        /// </summary>
       
        private void OknoGlowne_Load(object sender, EventArgs e)
        {  
            this.pracownicyTableAdapter.Fill(this.bazydanychDataSet.Pracownicy);
        }

        /// <summary>
        /// Metoda służąca do dodawania nowego montażu do bazy danych
        /// </summary>
        /// <returns>Dodaje nowe rekordy do tabeli montaże</returns>
        /// <param name="sender">Odwołanie do przycisku Zapisz </param>
        /// <param name="e">Przekazuje określone zdarzenie, zapisuje dane do tabeli Montaże</param>

        private void ButtZapiszNmontaz_Click(object sender, EventArgs e)
        {

            if (tbNMImie.Text == "" || tbNMNazwisko.Text == "" || tbNMadres.Text == "" )
            {
                MessageBox.Show("Proszę wprowadzić dane");
            }
            else
            {

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    
                            
                                
                                sqlCon.Open();
                                SqlCommand sqlCmd = new SqlCommand("MontazeAdd", sqlCon);
                                sqlCmd.CommandType = CommandType.StoredProcedure;

                                sqlCmd.Parameters.AddWithValue("@Imie",tbNMImie.Text.Trim());
                                sqlCmd.Parameters.AddWithValue("@Nazwisko", tbNMNazwisko.Text.Trim());
                                sqlCmd.Parameters.AddWithValue("@Adres", tbNMadres.Text.Trim());
                                sqlCmd.Parameters.AddWithValue("@Pracownik", cbPracownik.Text.Trim());
                                sqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Montaż dodawny pomyślnie");
                                tbNMImie.Clear();
                                tbNMNazwisko.Clear();
                                tbNMadres.Clear();
                              
                    sqlCon.Close();

                }
            }
        }
        /// <summary>
        /// Metoda służąca do wyświetlenia montaży
        /// </summary>
        /// <param name="sender">Odwołanie do przycisku Lista montaży </param>
        /// <param name="e">Przekazuje określone zdarzenie, wyświetla tabele z danymi</param>

        private void label5_Click(object sender, EventArgs e)
        {
            panelMontaze.Show();
            panelNMontaz.Hide();
            panel2.Hide();
            panelData.Hide();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                DataTable returnTable = new DataTable();
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "Select * from Montaze";
               SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(returnTable);
                sqlCon.Close();
                tabelaMontazy.AutoGenerateColumns = true;
                tabelaMontazy.DataSource = returnTable;

            }
        }

        private void buttCofnij2_Click(object sender, EventArgs e)
        {
            panelMontaze.Hide();
        }
    }
}
