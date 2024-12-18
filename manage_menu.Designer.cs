namespace LKS_JAKARTA_2024
{
    partial class manage_menu
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDeskripsi = new System.Windows.Forms.TextBox();
            this.inputBindingMenu = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxMenuName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuIngredientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMenu = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.harga_numeric = new System.Windows.Forms.NumericUpDown();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputBindingMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harga_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(708, 471);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 42);
            this.button5.TabIndex = 32;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(580, 471);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 42);
            this.button4.TabIndex = 31;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(762, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 41);
            this.button3.TabIndex = 30;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 41);
            this.button2.TabIndex = 29;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDeskripsi
            // 
            this.textBoxDeskripsi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inputBindingMenu, "Description", true));
            this.textBoxDeskripsi.Location = new System.Drawing.Point(162, 468);
            this.textBoxDeskripsi.Multiline = true;
            this.textBoxDeskripsi.Name = "textBoxDeskripsi";
            this.textBoxDeskripsi.Size = new System.Drawing.Size(245, 124);
            this.textBoxDeskripsi.TabIndex = 25;
            // 
            // inputBindingMenu
            // 
            this.inputBindingMenu.DataSource = typeof(LKS_JAKARTA_2024.Menus);
            // 
            // textBoxMenuName
            // 
            this.textBoxMenuName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inputBindingMenu, "Name", true));
            this.textBoxMenuName.Location = new System.Drawing.Point(162, 401);
            this.textBoxMenuName.Name = "textBoxMenuName";
            this.textBoxMenuName.Size = new System.Drawing.Size(245, 20);
            this.textBoxMenuName.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.kategori,
            this.descriptionDataGridViewTextBoxColumn,
            this.harga,
            this.nama_kategori,
            this.menuIngredientsDataGridViewTextBoxColumn,
            this.reservationDetailsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dgvMenu;
            this.dataGridView1.Location = new System.Drawing.Point(40, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1008, 209);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kategori
            // 
            this.kategori.DataPropertyName = "CategoryID";
            this.kategori.HeaderText = "Category";
            this.kategori.Name = "kategori";
            this.kategori.ReadOnly = true;
            this.kategori.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // harga
            // 
            this.harga.DataPropertyName = "Price";
            this.harga.HeaderText = "Price";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            this.harga.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nama_kategori
            // 
            this.nama_kategori.DataPropertyName = "Categories";
            this.nama_kategori.HeaderText = "Categories";
            this.nama_kategori.Name = "nama_kategori";
            this.nama_kategori.Visible = false;
            // 
            // menuIngredientsDataGridViewTextBoxColumn
            // 
            this.menuIngredientsDataGridViewTextBoxColumn.DataPropertyName = "MenuIngredients";
            this.menuIngredientsDataGridViewTextBoxColumn.HeaderText = "MenuIngredients";
            this.menuIngredientsDataGridViewTextBoxColumn.Name = "menuIngredientsDataGridViewTextBoxColumn";
            this.menuIngredientsDataGridViewTextBoxColumn.Visible = false;
            // 
            // reservationDetailsDataGridViewTextBoxColumn
            // 
            this.reservationDetailsDataGridViewTextBoxColumn.DataPropertyName = "ReservationDetails";
            this.reservationDetailsDataGridViewTextBoxColumn.HeaderText = "ReservationDetails";
            this.reservationDetailsDataGridViewTextBoxColumn.Name = "reservationDetailsDataGridViewTextBoxColumn";
            this.reservationDetailsDataGridViewTextBoxColumn.Visible = false;
            // 
            // dgvMenu
            // 
            this.dgvMenu.DataSource = typeof(LKS_JAKARTA_2024.Menus);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(117, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 30);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 600);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Menu Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Manage Menu";
            // 
            // harga_numeric
            // 
            this.harga_numeric.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inputBindingMenu, "Price", true));
            this.harga_numeric.Location = new System.Drawing.Point(162, 601);
            this.harga_numeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.harga_numeric.Name = "harga_numeric";
            this.harga_numeric.Size = new System.Drawing.Size(245, 20);
            this.harga_numeric.TabIndex = 33;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.DataSource = this.categoriesBindingSource;
            this.comboBoxKategori.DisplayMember = "Name";
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(162, 435);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(245, 21);
            this.comboBoxKategori.TabIndex = 34;
            this.comboBoxKategori.ValueMember = "ID";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataSource = typeof(LKS_JAKARTA_2024.Categories);
            // 
            // manage_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 674);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.harga_numeric);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDeskripsi);
            this.Controls.Add(this.textBoxMenuName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "manage_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manage_menu";
            this.Load += new System.EventHandler(this.manage_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputBindingMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harga_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDeskripsi;
        private System.Windows.Forms.TextBox textBoxMenuName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dgvMenu;
        private System.Windows.Forms.BindingSource inputBindingMenu;
        private System.Windows.Forms.NumericUpDown harga_numeric;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIngredientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationDetailsDataGridViewTextBoxColumn;
    }
}