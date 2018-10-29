namespace Panel_zarządzający
{
    partial class OknoGlowne
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoGlowne));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Wyloguj = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttCofnij = new System.Windows.Forms.Button();
            this.buttDodajKlienta = new System.Windows.Forms.Button();
            this.buttWyczusc = new System.Windows.Forms.Button();
            this.tbklTelefon = new System.Windows.Forms.TextBox();
            this.tbklPesel = new System.Windows.Forms.TextBox();
            this.tbklDowod = new System.Windows.Forms.TextBox();
            this.tbklAdres = new System.Windows.Forms.TextBox();
            this.tbklNazwisko = new System.Windows.Forms.TextBox();
            this.tbklImie = new System.Windows.Forms.TextBox();
            this.txtklNrtel = new System.Windows.Forms.Label();
            this.txtklPesel = new System.Windows.Forms.Label();
            this.txtklNrdowodu = new System.Windows.Forms.Label();
            this.txtklAdres = new System.Windows.Forms.Label();
            this.txtklNazwisko = new System.Windows.Forms.Label();
            this.txtklImie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelNMontaz = new System.Windows.Forms.Panel();
            this.ButtZapiszNmontaz = new System.Windows.Forms.Button();
            this.buttWyczyscNmontaz = new System.Windows.Forms.Button();
            this.buttCofNmontaz = new System.Windows.Forms.Button();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.pracownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazydanychDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazydanychDataSet = new Panel_zarządzający.BazydanychDataSet();
            this.tbNMadres = new System.Windows.Forms.TextBox();
            this.tbNMNazwisko = new System.Windows.Forms.TextBox();
            this.tbNMImie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNMontaz = new System.Windows.Forms.Label();
            this.pracownicyTableAdapter = new Panel_zarządzający.BazydanychDataSetTableAdapters.PracownicyTableAdapter();
            this.panelMontaze = new System.Windows.Forms.Panel();
            this.buttCofnij2 = new System.Windows.Forms.Button();
            this.tabelaMontazy = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelNMontaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazydanychDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazydanychDataSet)).BeginInit();
            this.panelMontaze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMontazy)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 58);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baza Klientów";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nowy Klient";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nowy montaż";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lista montaży";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Wyloguj
            // 
            this.Wyloguj.Location = new System.Drawing.Point(14, 296);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(75, 23);
            this.Wyloguj.TabIndex = 8;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.UseVisualStyleBackColor = true;
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dataGridView1);
            this.panelData.Location = new System.Drawing.Point(117, 74);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(452, 325);
            this.panelData.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttCofnij
            // 
            this.buttCofnij.Location = new System.Drawing.Point(6, 286);
            this.buttCofnij.Name = "buttCofnij";
            this.buttCofnij.Size = new System.Drawing.Size(75, 23);
            this.buttCofnij.TabIndex = 17;
            this.buttCofnij.Text = "Cofnij";
            this.buttCofnij.UseVisualStyleBackColor = true;
            this.buttCofnij.Click += new System.EventHandler(this.buttCofnij_Click);
            // 
            // buttDodajKlienta
            // 
            this.buttDodajKlienta.Location = new System.Drawing.Point(105, 248);
            this.buttDodajKlienta.Name = "buttDodajKlienta";
            this.buttDodajKlienta.Size = new System.Drawing.Size(75, 23);
            this.buttDodajKlienta.TabIndex = 16;
            this.buttDodajKlienta.Text = "Dodaj klienta";
            this.buttDodajKlienta.UseVisualStyleBackColor = true;
            this.buttDodajKlienta.Click += new System.EventHandler(this.buttDodajKlienta_Click);
            // 
            // buttWyczusc
            // 
            this.buttWyczusc.Location = new System.Drawing.Point(6, 248);
            this.buttWyczusc.Name = "buttWyczusc";
            this.buttWyczusc.Size = new System.Drawing.Size(75, 23);
            this.buttWyczusc.TabIndex = 15;
            this.buttWyczusc.Text = "Wyczyść";
            this.buttWyczusc.UseVisualStyleBackColor = true;
            this.buttWyczusc.Click += new System.EventHandler(this.buttWyczusc_Click);
            // 
            // tbklTelefon
            // 
            this.tbklTelefon.Location = new System.Drawing.Point(80, 197);
            this.tbklTelefon.Name = "tbklTelefon";
            this.tbklTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbklTelefon.TabIndex = 13;
            // 
            // tbklPesel
            // 
            this.tbklPesel.Location = new System.Drawing.Point(80, 168);
            this.tbklPesel.Name = "tbklPesel";
            this.tbklPesel.Size = new System.Drawing.Size(100, 20);
            this.tbklPesel.TabIndex = 12;
            // 
            // tbklDowod
            // 
            this.tbklDowod.Location = new System.Drawing.Point(80, 139);
            this.tbklDowod.Name = "tbklDowod";
            this.tbklDowod.Size = new System.Drawing.Size(100, 20);
            this.tbklDowod.TabIndex = 11;
            // 
            // tbklAdres
            // 
            this.tbklAdres.Location = new System.Drawing.Point(80, 111);
            this.tbklAdres.Name = "tbklAdres";
            this.tbklAdres.Size = new System.Drawing.Size(100, 20);
            this.tbklAdres.TabIndex = 10;
            // 
            // tbklNazwisko
            // 
            this.tbklNazwisko.Location = new System.Drawing.Point(80, 83);
            this.tbklNazwisko.Name = "tbklNazwisko";
            this.tbklNazwisko.Size = new System.Drawing.Size(100, 20);
            this.tbklNazwisko.TabIndex = 9;
            // 
            // tbklImie
            // 
            this.tbklImie.Location = new System.Drawing.Point(80, 57);
            this.tbklImie.Name = "tbklImie";
            this.tbklImie.Size = new System.Drawing.Size(100, 20);
            this.tbklImie.TabIndex = 8;
            // 
            // txtklNrtel
            // 
            this.txtklNrtel.AutoSize = true;
            this.txtklNrtel.Location = new System.Drawing.Point(3, 200);
            this.txtklNrtel.Name = "txtklNrtel";
            this.txtklNrtel.Size = new System.Drawing.Size(62, 13);
            this.txtklNrtel.TabIndex = 6;
            this.txtklNrtel.Text = "Nr telefonu:";
            // 
            // txtklPesel
            // 
            this.txtklPesel.AutoSize = true;
            this.txtklPesel.Location = new System.Drawing.Point(3, 171);
            this.txtklPesel.Name = "txtklPesel";
            this.txtklPesel.Size = new System.Drawing.Size(36, 13);
            this.txtklPesel.TabIndex = 5;
            this.txtklPesel.Text = "Pesel:";
            // 
            // txtklNrdowodu
            // 
            this.txtklNrdowodu.AutoSize = true;
            this.txtklNrdowodu.Location = new System.Drawing.Point(3, 142);
            this.txtklNrdowodu.Name = "txtklNrdowodu";
            this.txtklNrdowodu.Size = new System.Drawing.Size(62, 13);
            this.txtklNrdowodu.TabIndex = 4;
            this.txtklNrdowodu.Text = "Nr dowodu:";
            // 
            // txtklAdres
            // 
            this.txtklAdres.AutoSize = true;
            this.txtklAdres.Location = new System.Drawing.Point(3, 114);
            this.txtklAdres.Name = "txtklAdres";
            this.txtklAdres.Size = new System.Drawing.Size(37, 13);
            this.txtklAdres.TabIndex = 3;
            this.txtklAdres.Text = "Adres:";
            // 
            // txtklNazwisko
            // 
            this.txtklNazwisko.AutoSize = true;
            this.txtklNazwisko.Location = new System.Drawing.Point(3, 83);
            this.txtklNazwisko.Name = "txtklNazwisko";
            this.txtklNazwisko.Size = new System.Drawing.Size(59, 13);
            this.txtklNazwisko.TabIndex = 2;
            this.txtklNazwisko.Text = "Nazwisko: ";
            // 
            // txtklImie
            // 
            this.txtklImie.AutoSize = true;
            this.txtklImie.Location = new System.Drawing.Point(3, 57);
            this.txtklImie.Name = "txtklImie";
            this.txtklImie.Size = new System.Drawing.Size(32, 13);
            this.txtklImie.TabIndex = 1;
            this.txtklImie.Text = "Imię: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(123, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodawanie nowego Klienta";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttCofnij);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttDodajKlienta);
            this.panel2.Controls.Add(this.txtklImie);
            this.panel2.Controls.Add(this.buttWyczusc);
            this.panel2.Controls.Add(this.txtklNazwisko);
            this.panel2.Controls.Add(this.tbklTelefon);
            this.panel2.Controls.Add(this.txtklAdres);
            this.panel2.Controls.Add(this.tbklPesel);
            this.panel2.Controls.Add(this.txtklNrdowodu);
            this.panel2.Controls.Add(this.tbklDowod);
            this.panel2.Controls.Add(this.txtklPesel);
            this.panel2.Controls.Add(this.tbklAdres);
            this.panel2.Controls.Add(this.txtklNrtel);
            this.panel2.Controls.Add(this.tbklNazwisko);
            this.panel2.Controls.Add(this.tbklImie);
            this.panel2.Location = new System.Drawing.Point(120, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 327);
            this.panel2.TabIndex = 19;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMenu.Controls.Add(this.Wyloguj);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Location = new System.Drawing.Point(12, 76);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(102, 327);
            this.panelMenu.TabIndex = 20;
            // 
            // panelNMontaz
            // 
            this.panelNMontaz.Controls.Add(this.ButtZapiszNmontaz);
            this.panelNMontaz.Controls.Add(this.buttWyczyscNmontaz);
            this.panelNMontaz.Controls.Add(this.buttCofNmontaz);
            this.panelNMontaz.Controls.Add(this.cbPracownik);
            this.panelNMontaz.Controls.Add(this.tbNMadres);
            this.panelNMontaz.Controls.Add(this.tbNMNazwisko);
            this.panelNMontaz.Controls.Add(this.tbNMImie);
            this.panelNMontaz.Controls.Add(this.label10);
            this.panelNMontaz.Controls.Add(this.label9);
            this.panelNMontaz.Controls.Add(this.label8);
            this.panelNMontaz.Controls.Add(this.label7);
            this.panelNMontaz.Controls.Add(this.lblNMontaz);
            this.panelNMontaz.Location = new System.Drawing.Point(117, 76);
            this.panelNMontaz.Name = "panelNMontaz";
            this.panelNMontaz.Size = new System.Drawing.Size(455, 324);
            this.panelNMontaz.TabIndex = 21;
            // 
            // ButtZapiszNmontaz
            // 
            this.ButtZapiszNmontaz.Location = new System.Drawing.Point(108, 219);
            this.ButtZapiszNmontaz.Name = "ButtZapiszNmontaz";
            this.ButtZapiszNmontaz.Size = new System.Drawing.Size(75, 23);
            this.ButtZapiszNmontaz.TabIndex = 11;
            this.ButtZapiszNmontaz.Text = "Zapisz";
            this.ButtZapiszNmontaz.UseVisualStyleBackColor = true;
            this.ButtZapiszNmontaz.Click += new System.EventHandler(this.ButtZapiszNmontaz_Click);
            // 
            // buttWyczyscNmontaz
            // 
            this.buttWyczyscNmontaz.Location = new System.Drawing.Point(4, 219);
            this.buttWyczyscNmontaz.Name = "buttWyczyscNmontaz";
            this.buttWyczyscNmontaz.Size = new System.Drawing.Size(75, 23);
            this.buttWyczyscNmontaz.TabIndex = 10;
            this.buttWyczyscNmontaz.Text = "Wyczyść";
            this.buttWyczyscNmontaz.UseVisualStyleBackColor = true;
            this.buttWyczyscNmontaz.Click += new System.EventHandler(this.buttWyczyscNmontaz_Click);
            // 
            // buttCofNmontaz
            // 
            this.buttCofNmontaz.Location = new System.Drawing.Point(4, 256);
            this.buttCofNmontaz.Name = "buttCofNmontaz";
            this.buttCofNmontaz.Size = new System.Drawing.Size(75, 23);
            this.buttCofNmontaz.TabIndex = 9;
            this.buttCofNmontaz.Text = "Cofnij";
            this.buttCofNmontaz.UseVisualStyleBackColor = true;
            this.buttCofNmontaz.Click += new System.EventHandler(this.buttCofNmontaz_Click);
            // 
            // cbPracownik
            // 
            this.cbPracownik.DataSource = this.pracownicyBindingSource;
            this.cbPracownik.DisplayMember = "Nazwisko";
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(74, 155);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(121, 21);
            this.cbPracownik.TabIndex = 8;
            // 
            // pracownicyBindingSource
            // 
            this.pracownicyBindingSource.DataMember = "Pracownicy";
            this.pracownicyBindingSource.DataSource = this.bazydanychDataSetBindingSource;
            // 
            // bazydanychDataSetBindingSource
            // 
            this.bazydanychDataSetBindingSource.DataSource = this.bazydanychDataSet;
            this.bazydanychDataSetBindingSource.Position = 0;
            // 
            // bazydanychDataSet
            // 
            this.bazydanychDataSet.DataSetName = "BazydanychDataSet";
            this.bazydanychDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNMadres
            // 
            this.tbNMadres.Location = new System.Drawing.Point(74, 126);
            this.tbNMadres.Name = "tbNMadres";
            this.tbNMadres.Size = new System.Drawing.Size(100, 20);
            this.tbNMadres.TabIndex = 7;
            // 
            // tbNMNazwisko
            // 
            this.tbNMNazwisko.Location = new System.Drawing.Point(74, 90);
            this.tbNMNazwisko.Name = "tbNMNazwisko";
            this.tbNMNazwisko.Size = new System.Drawing.Size(100, 20);
            this.tbNMNazwisko.TabIndex = 6;
            // 
            // tbNMImie
            // 
            this.tbNMImie.Location = new System.Drawing.Point(74, 57);
            this.tbNMImie.Name = "tbNMImie";
            this.tbNMImie.Size = new System.Drawing.Size(100, 20);
            this.tbNMImie.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Pracownik:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Adres: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nazwisko: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Imię: ";
            // 
            // lblNMontaz
            // 
            this.lblNMontaz.AutoSize = true;
            this.lblNMontaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNMontaz.Location = new System.Drawing.Point(165, 12);
            this.lblNMontaz.Name = "lblNMontaz";
            this.lblNMontaz.Size = new System.Drawing.Size(92, 15);
            this.lblNMontaz.TabIndex = 0;
            this.lblNMontaz.Text = "Nowy montaż";
            // 
            // pracownicyTableAdapter
            // 
            this.pracownicyTableAdapter.ClearBeforeFill = true;
            // 
            // panelMontaze
            // 
            this.panelMontaze.Controls.Add(this.buttCofnij2);
            this.panelMontaze.Controls.Add(this.tabelaMontazy);
            this.panelMontaze.Controls.Add(this.label11);
            this.panelMontaze.Location = new System.Drawing.Point(117, 74);
            this.panelMontaze.Name = "panelMontaze";
            this.panelMontaze.Size = new System.Drawing.Size(455, 329);
            this.panelMontaze.TabIndex = 22;
            // 
            // buttCofnij2
            // 
            this.buttCofnij2.Location = new System.Drawing.Point(9, 289);
            this.buttCofnij2.Name = "buttCofnij2";
            this.buttCofnij2.Size = new System.Drawing.Size(75, 23);
            this.buttCofnij2.TabIndex = 2;
            this.buttCofnij2.Text = "Cofnij";
            this.buttCofnij2.UseVisualStyleBackColor = true;
            this.buttCofnij2.Click += new System.EventHandler(this.buttCofnij2_Click);
            // 
            // tabelaMontazy
            // 
            this.tabelaMontazy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaMontazy.Location = new System.Drawing.Point(6, 40);
            this.tabelaMontazy.Name = "tabelaMontazy";
            this.tabelaMontazy.Size = new System.Drawing.Size(443, 223);
            this.tabelaMontazy.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(165, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Lista montaży";
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.panelMontaze);
            this.Controls.Add(this.panelNMontaz);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OknoGlowne";
            this.Text = "OknoGlowne";
            this.Load += new System.EventHandler(this.OknoGlowne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelNMontaz.ResumeLayout(false);
            this.panelNMontaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazydanychDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazydanychDataSet)).EndInit();
            this.panelMontaze.ResumeLayout(false);
            this.panelMontaze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMontazy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Wyloguj;
        private System.Windows.Forms.Button buttCofnij;
        private System.Windows.Forms.Button buttDodajKlienta;
        private System.Windows.Forms.Button buttWyczusc;
        private System.Windows.Forms.TextBox tbklTelefon;
        private System.Windows.Forms.TextBox tbklPesel;
        private System.Windows.Forms.TextBox tbklDowod;
        private System.Windows.Forms.TextBox tbklAdres;
        private System.Windows.Forms.TextBox tbklNazwisko;
        private System.Windows.Forms.TextBox tbklImie;
        private System.Windows.Forms.Label txtklNrtel;
        private System.Windows.Forms.Label txtklPesel;
        private System.Windows.Forms.Label txtklNrdowodu;
        private System.Windows.Forms.Label txtklAdres;
        private System.Windows.Forms.Label txtklNazwisko;
        private System.Windows.Forms.Label txtklImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelNMontaz;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.TextBox tbNMadres;
        private System.Windows.Forms.TextBox tbNMNazwisko;
        private System.Windows.Forms.TextBox tbNMImie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNMontaz;
        private System.Windows.Forms.Button ButtZapiszNmontaz;
        private System.Windows.Forms.Button buttWyczyscNmontaz;
        private System.Windows.Forms.Button buttCofNmontaz;
        private System.Windows.Forms.BindingSource bazydanychDataSetBindingSource;
        private BazydanychDataSet bazydanychDataSet;
        private System.Windows.Forms.BindingSource pracownicyBindingSource;
        private BazydanychDataSetTableAdapters.PracownicyTableAdapter pracownicyTableAdapter;
        private System.Windows.Forms.Panel panelMontaze;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttCofnij2;
        private System.Windows.Forms.DataGridView tabelaMontazy;
    }
}