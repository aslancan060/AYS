namespace BKS
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStok;
        private System.Windows.Forms.TabPage tabPageSatis;
        private System.Windows.Forms.TabPage tabPageGelirGider;

        private System.Windows.Forms.DataGridView dataGridViewStok;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Button btnAddStock;

        private System.Windows.Forms.ComboBox comboBoxStok;
        private System.Windows.Forms.NumericUpDown numericQuantitySold;
        private System.Windows.Forms.Button btnMakeSale;

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.RadioButton radioIncome;
        private System.Windows.Forms.RadioButton radioExpense;
        private System.Windows.Forms.Button btnAddIncomeExpense;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            tabPageStok = new TabPage();
            groupBox7 = new GroupBox();
            checkAktif = new CheckBox();
            checkOdemeDurum = new CheckBox();
            groupBox6 = new GroupBox();
            numericPrice = new NumericUpDown();
            groupBox5 = new GroupBox();
            dateDogum = new DateTimePicker();
            groupBox4 = new GroupBox();
            textOgrenciKod = new TextBox();
            groupBox3 = new GroupBox();
            txtOgrenciAd = new TextBox();
            groupBox2 = new GroupBox();
            textSoyad = new TextBox();
            groupBox1 = new GroupBox();
            textBabaAd = new TextBox();
            groupBox = new GroupBox();
            cmbogrsınıf = new ComboBox();
            dataGridViewStok = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ödemeDetaylarıToolStripMenuItem = new ToolStripMenuItem();
            btnAddStock = new Button();
            tabPageSatis = new TabPage();
            groupBox9 = new GroupBox();
            numericQuantitySold = new NumericUpDown();
            groupBox8 = new GroupBox();
            comboBoxStok = new ComboBox();
            dataOgrVw = new DataGridView();
            btnMakeSale = new Button();
            tabPageGelirGider = new TabPage();
            dataGridOdeme = new DataGridView();
            txtDescription = new TextBox();
            numericAmount = new NumericUpDown();
            radioIncome = new RadioButton();
            radioExpense = new RadioButton();
            btnAddIncomeExpense = new Button();
            tabPage1 = new TabPage();
            salesGrid = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            tabControl.SuspendLayout();
            tabPageStok.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStok).BeginInit();
            contextMenuStrip1.SuspendLayout();
            tabPageSatis.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantitySold).BeginInit();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataOgrVw).BeginInit();
            tabPageGelirGider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOdeme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAmount).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salesGrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageStok);
            tabControl.Controls.Add(tabPageSatis);
            tabControl.Controls.Add(tabPageGelirGider);
            tabControl.Controls.Add(tabPage1);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1241, 609);
            tabControl.TabIndex = 0;
            // 
            // tabPageStok
            // 
            tabPageStok.Controls.Add(groupBox7);
            tabPageStok.Controls.Add(groupBox6);
            tabPageStok.Controls.Add(groupBox5);
            tabPageStok.Controls.Add(groupBox4);
            tabPageStok.Controls.Add(groupBox3);
            tabPageStok.Controls.Add(groupBox2);
            tabPageStok.Controls.Add(groupBox1);
            tabPageStok.Controls.Add(groupBox);
            tabPageStok.Controls.Add(dataGridViewStok);
            tabPageStok.Controls.Add(btnAddStock);
            tabPageStok.Location = new Point(4, 24);
            tabPageStok.Name = "tabPageStok";
            tabPageStok.Size = new Size(1233, 581);
            tabPageStok.TabIndex = 0;
            tabPageStok.Text = "Öğrenci Yönetimi";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(checkAktif);
            groupBox7.Controls.Add(checkOdemeDurum);
            groupBox7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox7.ForeColor = Color.DarkSlateBlue;
            groupBox7.Location = new Point(806, 394);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(299, 54);
            groupBox7.TabIndex = 20;
            groupBox7.TabStop = false;
            groupBox7.Text = "Aktif mi Ödeme Durumu";
            // 
            // checkAktif
            // 
            checkAktif.AutoSize = true;
            checkAktif.Location = new Point(6, 24);
            checkAktif.Name = "checkAktif";
            checkAktif.Size = new Size(144, 23);
            checkAktif.TabIndex = 10;
            checkAktif.Text = "Aktif Öğrenci mi?";
            checkAktif.UseVisualStyleBackColor = true;
            // 
            // checkOdemeDurum
            // 
            checkOdemeDurum.AutoSize = true;
            checkOdemeDurum.Location = new Point(156, 24);
            checkOdemeDurum.Name = "checkOdemeDurum";
            checkOdemeDurum.Size = new Size(134, 23);
            checkOdemeDurum.TabIndex = 11;
            checkOdemeDurum.Text = "Ödeme Durumu";
            checkOdemeDurum.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(numericPrice);
            groupBox6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox6.ForeColor = Color.DarkSlateBlue;
            groupBox6.Location = new Point(832, 337);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(238, 51);
            groupBox6.TabIndex = 19;
            groupBox6.TabStop = false;
            groupBox6.Text = "Öğrenci Ödeme Tutarı";
            // 
            // numericPrice
            // 
            numericPrice.DecimalPlaces = 2;
            numericPrice.Location = new Point(31, 20);
            numericPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(188, 25);
            numericPrice.TabIndex = 3;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dateDogum);
            groupBox5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox5.ForeColor = Color.DarkSlateBlue;
            groupBox5.Location = new Point(832, 284);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(238, 51);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "Öğrenci Doğum Tarihi";
            // 
            // dateDogum
            // 
            dateDogum.Location = new Point(17, 22);
            dateDogum.Name = "dateDogum";
            dateDogum.Size = new Size(200, 25);
            dateDogum.TabIndex = 9;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textOgrenciKod);
            groupBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox4.ForeColor = Color.DarkSlateBlue;
            groupBox4.Location = new Point(832, 231);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(238, 51);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Öğrenci Numarası";
            // 
            // textOgrenciKod
            // 
            textOgrenciKod.Location = new Point(21, 22);
            textOgrenciKod.Name = "textOgrenciKod";
            textOgrenciKod.PlaceholderText = "Öğrenci Numarası";
            textOgrenciKod.Size = new Size(200, 25);
            textOgrenciKod.TabIndex = 8;
            textOgrenciKod.TextChanged += textBox4_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtOgrenciAd);
            groupBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox3.ForeColor = Color.DarkSlateBlue;
            groupBox3.Location = new Point(832, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 51);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Öğrenci Adı";
            // 
            // txtOgrenciAd
            // 
            txtOgrenciAd.Location = new Point(21, 22);
            txtOgrenciAd.Name = "txtOgrenciAd";
            txtOgrenciAd.PlaceholderText = "Öğrenci Adı";
            txtOgrenciAd.Size = new Size(200, 25);
            txtOgrenciAd.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textSoyad);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.DarkSlateBlue;
            groupBox2.Location = new Point(832, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 47);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Öğrenci Soyadı";
            // 
            // textSoyad
            // 
            textSoyad.Location = new Point(19, 16);
            textSoyad.Name = "textSoyad";
            textSoyad.PlaceholderText = "Öğrenci Soyadı";
            textSoyad.Size = new Size(200, 25);
            textSoyad.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBabaAd);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.DarkSlateBlue;
            groupBox1.Location = new Point(832, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 60);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Baba Adı";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBabaAd
            // 
            textBabaAd.Location = new Point(20, 24);
            textBabaAd.Name = "textBabaAd";
            textBabaAd.PlaceholderText = "Öğrenci Baba Adı";
            textBabaAd.Size = new Size(200, 25);
            textBabaAd.TabIndex = 6;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(cmbogrsınıf);
            groupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox.ForeColor = Color.DarkSlateBlue;
            groupBox.Location = new Point(832, 176);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(238, 60);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Sınıf Bilgileri";
            // 
            // cmbogrsınıf
            // 
            cmbogrsınıf.FormattingEnabled = true;
            cmbogrsınıf.Location = new Point(19, 24);
            cmbogrsınıf.Name = "cmbogrsınıf";
            cmbogrsınıf.Size = new Size(200, 25);
            cmbogrsınıf.TabIndex = 13;
            // 
            // dataGridViewStok
            // 
            dataGridViewStok.ContextMenuStrip = contextMenuStrip1;
            dataGridViewStok.Location = new Point(20, 23);
            dataGridViewStok.Name = "dataGridViewStok";
            dataGridViewStok.Size = new Size(750, 377);
            dataGridViewStok.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ödemeDetaylarıToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(163, 26);
            contextMenuStrip1.Text = "Ödeme Detayları";
            // 
            // ödemeDetaylarıToolStripMenuItem
            // 
            ödemeDetaylarıToolStripMenuItem.Name = "ödemeDetaylarıToolStripMenuItem";
            ödemeDetaylarıToolStripMenuItem.Size = new Size(162, 22);
            ödemeDetaylarıToolStripMenuItem.Text = "Ödeme Detayları";
            ödemeDetaylarıToolStripMenuItem.Click += ödemeDetaylarıToolStripMenuItem_Click_1;
            // 
            // btnAddStock
            // 
            btnAddStock.BackColor = Color.MediumSlateBlue;
            btnAddStock.FlatAppearance.BorderSize = 0;
            btnAddStock.FlatStyle = FlatStyle.Flat;
            btnAddStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddStock.ForeColor = Color.White;
            btnAddStock.Location = new Point(982, 466);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(123, 30);
            btnAddStock.TabIndex = 4;
            btnAddStock.Text = "Öğrenci Ekle";
            btnAddStock.UseVisualStyleBackColor = false;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // tabPageSatis
            // 
            tabPageSatis.Controls.Add(groupBox9);
            tabPageSatis.Controls.Add(groupBox8);
            tabPageSatis.Controls.Add(dataOgrVw);
            tabPageSatis.Controls.Add(btnMakeSale);
            tabPageSatis.Location = new Point(4, 24);
            tabPageSatis.Name = "tabPageSatis";
            tabPageSatis.Size = new Size(1233, 581);
            tabPageSatis.TabIndex = 1;
            tabPageSatis.Text = "Öğrenci Ödeme Yönetimi";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(numericQuantitySold);
            groupBox9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox9.ForeColor = Color.DarkSlateBlue;
            groupBox9.Location = new Point(874, 434);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(170, 60);
            groupBox9.TabIndex = 5;
            groupBox9.TabStop = false;
            groupBox9.Text = "Öğrenci Ücreti";
            // 
            // numericQuantitySold
            // 
            numericQuantitySold.Location = new Point(22, 24);
            numericQuantitySold.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericQuantitySold.Name = "numericQuantitySold";
            numericQuantitySold.Size = new Size(120, 25);
            numericQuantitySold.TabIndex = 1;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(comboBoxStok);
            groupBox8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox8.ForeColor = Color.DarkSlateBlue;
            groupBox8.Location = new Point(609, 434);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(238, 60);
            groupBox8.TabIndex = 4;
            groupBox8.TabStop = false;
            groupBox8.Text = "Öğrenci Seçimi";
            // 
            // comboBoxStok
            // 
            comboBoxStok.Location = new Point(17, 24);
            comboBoxStok.Name = "comboBoxStok";
            comboBoxStok.Size = new Size(200, 25);
            comboBoxStok.TabIndex = 0;
            // 
            // dataOgrVw
            // 
            dataOgrVw.ContextMenuStrip = contextMenuStrip1;
            dataOgrVw.Location = new Point(3, 3);
            dataOgrVw.Name = "dataOgrVw";
            dataOgrVw.Size = new Size(1222, 377);
            dataOgrVw.TabIndex = 3;
            dataOgrVw.CellContentClick += dataOgrVw_CellContentClick;
            // 
            // btnMakeSale
            // 
            btnMakeSale.Location = new Point(1050, 459);
            btnMakeSale.Name = "btnMakeSale";
            btnMakeSale.Size = new Size(124, 23);
            btnMakeSale.TabIndex = 2;
            btnMakeSale.Text = "Ödeme Girişi";
            btnMakeSale.Click += btnMakeSale_Click;
            // 
            // tabPageGelirGider
            // 
            tabPageGelirGider.Controls.Add(dataGridOdeme);
            tabPageGelirGider.Controls.Add(txtDescription);
            tabPageGelirGider.Controls.Add(numericAmount);
            tabPageGelirGider.Controls.Add(radioIncome);
            tabPageGelirGider.Controls.Add(radioExpense);
            tabPageGelirGider.Controls.Add(btnAddIncomeExpense);
            tabPageGelirGider.Location = new Point(4, 24);
            tabPageGelirGider.Name = "tabPageGelirGider";
            tabPageGelirGider.Size = new Size(1233, 581);
            tabPageGelirGider.TabIndex = 2;
            tabPageGelirGider.Text = "Gelir-Gider Yönetimi";
            // 
            // dataGridOdeme
            // 
            dataGridOdeme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOdeme.Location = new Point(20, 64);
            dataGridOdeme.Name = "dataGridOdeme";
            dataGridOdeme.Size = new Size(755, 340);
            dataGridOdeme.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 20);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Açıklama";
            txtDescription.Size = new Size(300, 23);
            txtDescription.TabIndex = 0;
            // 
            // numericAmount
            // 
            numericAmount.DecimalPlaces = 2;
            numericAmount.Location = new Point(350, 20);
            numericAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericAmount.Name = "numericAmount";
            numericAmount.Size = new Size(120, 23);
            numericAmount.TabIndex = 1;
            // 
            // radioIncome
            // 
            radioIncome.Location = new Point(500, 20);
            radioIncome.Name = "radioIncome";
            radioIncome.Size = new Size(104, 24);
            radioIncome.TabIndex = 2;
            radioIncome.Text = "Gelir";
            // 
            // radioExpense
            // 
            radioExpense.Location = new Point(610, 20);
            radioExpense.Name = "radioExpense";
            radioExpense.Size = new Size(104, 24);
            radioExpense.TabIndex = 3;
            radioExpense.Text = "Gider";
            // 
            // btnAddIncomeExpense
            // 
            btnAddIncomeExpense.Location = new Point(720, 21);
            btnAddIncomeExpense.Name = "btnAddIncomeExpense";
            btnAddIncomeExpense.Size = new Size(75, 23);
            btnAddIncomeExpense.TabIndex = 4;
            btnAddIncomeExpense.Text = "Ekle";
            btnAddIncomeExpense.Click += btnAddIncomeExpense_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(salesGrid);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1233, 581);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Özel Raporlar";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // salesGrid
            // 
            salesGrid.AllowDrop = true;
            salesGrid.AllowUserToOrderColumns = true;
            salesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesGrid.Location = new Point(6, 6);
            salesGrid.Name = "salesGrid";
            salesGrid.Size = new Size(1224, 557);
            salesGrid.TabIndex = 0;
            salesGrid.CellContentClick += salesGrid_CellContentClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Form2
            // 
            ClientSize = new Size(1241, 609);
            Controls.Add(tabControl);
            Name = "Form2";
            Text = "Anaokulu Yönetimi Sistemi";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            tabControl.ResumeLayout(false);
            tabPageStok.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStok).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            tabPageSatis.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericQuantitySold).EndInit();
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataOgrVw).EndInit();
            tabPageGelirGider.ResumeLayout(false);
            tabPageGelirGider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOdeme).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAmount).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)salesGrid).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dataGridOdeme;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TabPage tabPage1;
        private DataGridView salesGrid;
        private TextBox textBabaAd;
        private TextBox textSoyad;
        private DateTimePicker dateDogum;
        private TextBox textOgrenciKod;
        private CheckBox checkOdemeDurum;
        private CheckBox checkAktif;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ödemeDetaylarıToolStripMenuItem;
        private ComboBox cmbogrsınıf;
        private GroupBox groupBox;
        private GroupBox groupBox1;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView dataOgrVw;
        private GroupBox groupBox9;
        private GroupBox groupBox8;
    }
}