namespace Base_de_datos_SQLite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtnombre = new TextBox();
            txtid = new TextBox();
            btninsertar = new Button();
            btnactualizar = new Button();
            btneliminar = new Button();
            dgv = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 22);
            label1.TabIndex = 0;
            label1.Text = "BASe de datos en SQLite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 76);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 123);
            label3.Name = "label3";
            label3.Size = new Size(25, 17);
            label3.TabIndex = 2;
            label3.Text = "id:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(116, 73);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 3;
            // 
            // txtid
            // 
            txtid.Location = new Point(116, 120);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 23);
            txtid.TabIndex = 4;
            // 
            // btninsertar
            // 
            btninsertar.Location = new Point(116, 204);
            btninsertar.Name = "btninsertar";
            btninsertar.Size = new Size(75, 23);
            btninsertar.TabIndex = 5;
            btninsertar.Text = "Insertar";
            btninsertar.UseVisualStyleBackColor = true;
            btninsertar.Click += btninsertar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(116, 255);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(75, 23);
            btnactualizar.TabIndex = 6;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(116, 312);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(75, 23);
            btneliminar.TabIndex = 7;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // dgv
            // 
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Nombre, Id });
            dgv.Location = new Point(238, 63);
            dgv.Name = "dgv";
            dgv.Size = new Size(369, 272);
            dgv.TabIndex = 8;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 386);
            Controls.Add(dgv);
            Controls.Add(btneliminar);
            Controls.Add(btnactualizar);
            Controls.Add(btninsertar);
            Controls.Add(txtid);
            Controls.Add(txtnombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnombre;
        private TextBox txtid;
        private Button btninsertar;
        private Button btnactualizar;
        private Button btneliminar;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Id;
    }
}
