namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBaddPio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBaddName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBaddProductNoOf = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBaddProducentProduct = new System.Windows.Forms.TextBox();
            this.TBaddCena = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBaddNameProduct = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CBklient = new System.Windows.Forms.ComboBox();
            this.CBProduct = new System.Windows.Forms.ComboBox();
            this.ZamowienieAddIlosc = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewZamowienia = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.FiltrKlientName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.FiltrProducent = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBaddPio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBaddProductNoOf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBaddCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZamowienieAddIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZamowienia)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 534);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(968, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Klientci";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(421, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Usun Zaznaczone";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBaddPio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBaddName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(200, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj Klienta";
            // 
            // TBaddPio
            // 
            this.TBaddPio.Location = new System.Drawing.Point(79, 60);
            this.TBaddPio.Name = "TBaddPio";
            this.TBaddPio.Size = new System.Drawing.Size(120, 20);
            this.TBaddPio.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Piorytet";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa Firmy";
            // 
            // TBaddName
            // 
            this.TBaddName.Location = new System.Drawing.Point(79, 19);
            this.TBaddName.Name = "TBaddName";
            this.TBaddName.Size = new System.Drawing.Size(120, 20);
            this.TBaddName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj Klienta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridViewProduct);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produkty";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(421, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Usun Zaznaczone";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBaddProductNoOf);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TBaddProducentProduct);
            this.groupBox2.Controls.Add(this.TBaddCena);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TBaddNameProduct);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(200, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 191);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj Produkt";
            // 
            // TBaddProductNoOf
            // 
            this.TBaddProductNoOf.Location = new System.Drawing.Point(79, 72);
            this.TBaddProductNoOf.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TBaddProductNoOf.Name = "TBaddProductNoOf";
            this.TBaddProductNoOf.Size = new System.Drawing.Size(120, 20);
            this.TBaddProductNoOf.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ilosc";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Producent";
            // 
            // TBaddProducentProduct
            // 
            this.TBaddProducentProduct.Location = new System.Drawing.Point(79, 45);
            this.TBaddProducentProduct.Name = "TBaddProducentProduct";
            this.TBaddProducentProduct.Size = new System.Drawing.Size(120, 20);
            this.TBaddProducentProduct.TabIndex = 8;
            // 
            // TBaddCena
            // 
            this.TBaddCena.DecimalPlaces = 2;
            this.TBaddCena.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.TBaddCena.Location = new System.Drawing.Point(79, 98);
            this.TBaddCena.Name = "TBaddCena";
            this.TBaddCena.Size = new System.Drawing.Size(120, 20);
            this.TBaddCena.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Produkt";
            // 
            // TBaddNameProduct
            // 
            this.TBaddNameProduct.Location = new System.Drawing.Point(79, 19);
            this.TBaddNameProduct.Name = "TBaddNameProduct";
            this.TBaddNameProduct.Size = new System.Drawing.Size(120, 20);
            this.TBaddNameProduct.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dodaj Klienta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(200, 30);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(700, 242);
            this.dataGridViewProduct.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.dataGridViewZamowienia);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(968, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Zamowienia";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(421, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Usun Zaznaczone";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CBklient);
            this.groupBox3.Controls.Add(this.CBProduct);
            this.groupBox3.Controls.Add(this.ZamowienieAddIlosc);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(200, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 191);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodaj Zamowienie";
            // 
            // CBklient
            // 
            this.CBklient.FormattingEnabled = true;
            this.CBklient.Location = new System.Drawing.Point(79, 47);
            this.CBklient.Name = "CBklient";
            this.CBklient.Size = new System.Drawing.Size(121, 21);
            this.CBklient.TabIndex = 12;
            // 
            // CBProduct
            // 
            this.CBProduct.FormattingEnabled = true;
            this.CBProduct.Location = new System.Drawing.Point(78, 19);
            this.CBProduct.Name = "CBProduct";
            this.CBProduct.Size = new System.Drawing.Size(121, 21);
            this.CBProduct.TabIndex = 8;
            // 
            // ZamowienieAddIlosc
            // 
            this.ZamowienieAddIlosc.Location = new System.Drawing.Point(79, 72);
            this.ZamowienieAddIlosc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ZamowienieAddIlosc.Name = "ZamowienieAddIlosc";
            this.ZamowienieAddIlosc.Size = new System.Drawing.Size(120, 20);
            this.ZamowienieAddIlosc.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ilosc";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Klient";
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Produkt";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Dodaj Klienta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewZamowienia
            // 
            this.dataGridViewZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZamowienia.Location = new System.Drawing.Point(200, 30);
            this.dataGridViewZamowienia.Name = "dataGridViewZamowienia";
            this.dataGridViewZamowienia.Size = new System.Drawing.Size(700, 242);
            this.dataGridViewZamowienia.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(897, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Clear All";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // FiltrKlientName
            // 
            this.FiltrKlientName.Location = new System.Drawing.Point(71, 19);
            this.FiltrKlientName.Name = "FiltrKlientName";
            this.FiltrKlientName.Size = new System.Drawing.Size(100, 20);
            this.FiltrKlientName.TabIndex = 10;
            this.FiltrKlientName.TextChanged += new System.EventHandler(this.FiltrKlientName_TextChanged);
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nazwa";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.FiltrKlientName);
            this.groupBox4.Location = new System.Drawing.Point(17, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 102);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtr";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.FiltrProducent);
            this.groupBox5.Location = new System.Drawing.Point(17, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(177, 102);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtr";
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Producent";
            // 
            // FiltrProducent
            // 
            this.FiltrProducent.Location = new System.Drawing.Point(71, 19);
            this.FiltrProducent.Name = "FiltrProducent";
            this.FiltrProducent.Size = new System.Drawing.Size(100, 20);
            this.FiltrProducent.TabIndex = 10;
            this.FiltrProducent.TextChanged += new System.EventHandler(this.FiltrProducent_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 558);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBaddPio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBaddProductNoOf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBaddCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZamowienieAddIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZamowienia)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NumericUpDown TBaddPio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBaddName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown TBaddCena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBaddNameProduct;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBaddProducentProduct;
        private System.Windows.Forms.NumericUpDown TBaddProductNoOf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CBklient;
        private System.Windows.Forms.ComboBox CBProduct;
        private System.Windows.Forms.NumericUpDown ZamowienieAddIlosc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewZamowienia;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FiltrKlientName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FiltrProducent;
    }
}

