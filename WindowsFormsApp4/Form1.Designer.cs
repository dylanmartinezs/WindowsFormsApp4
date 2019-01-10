namespace WindowsFormsApp4 {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MotherboardRadioBtn = new System.Windows.Forms.RadioButton();
            this.ProcessorRadioBtn = new System.Windows.Forms.RadioButton();
            this.PeripheralRadioBtn = new System.Windows.Forms.RadioButton();
            this.RAMRadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteDis = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.ProductQuantity,
            this.ProductCost,
            this.ProductDescription,
            this.ProductType,
            this.DeleteDis});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MotherboardRadioBtn
            // 
            this.MotherboardRadioBtn.AutoSize = true;
            this.MotherboardRadioBtn.Location = new System.Drawing.Point(121, 392);
            this.MotherboardRadioBtn.Name = "MotherboardRadioBtn";
            this.MotherboardRadioBtn.Size = new System.Drawing.Size(79, 17);
            this.MotherboardRadioBtn.TabIndex = 2;
            this.MotherboardRadioBtn.TabStop = true;
            this.MotherboardRadioBtn.Text = "Placa Base";
            this.MotherboardRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ProcessorRadioBtn
            // 
            this.ProcessorRadioBtn.AutoSize = true;
            this.ProcessorRadioBtn.Location = new System.Drawing.Point(121, 415);
            this.ProcessorRadioBtn.Name = "ProcessorRadioBtn";
            this.ProcessorRadioBtn.Size = new System.Drawing.Size(79, 17);
            this.ProcessorRadioBtn.TabIndex = 3;
            this.ProcessorRadioBtn.TabStop = true;
            this.ProcessorRadioBtn.Text = "Procesador";
            this.ProcessorRadioBtn.UseVisualStyleBackColor = true;
            // 
            // PeripheralRadioBtn
            // 
            this.PeripheralRadioBtn.AutoSize = true;
            this.PeripheralRadioBtn.Location = new System.Drawing.Point(220, 415);
            this.PeripheralRadioBtn.Name = "PeripheralRadioBtn";
            this.PeripheralRadioBtn.Size = new System.Drawing.Size(69, 17);
            this.PeripheralRadioBtn.TabIndex = 5;
            this.PeripheralRadioBtn.TabStop = true;
            this.PeripheralRadioBtn.Text = "Periférico";
            this.PeripheralRadioBtn.UseVisualStyleBackColor = true;
            this.PeripheralRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RAMRadioBtn
            // 
            this.RAMRadioBtn.AutoSize = true;
            this.RAMRadioBtn.Location = new System.Drawing.Point(220, 392);
            this.RAMRadioBtn.Name = "RAMRadioBtn";
            this.RAMRadioBtn.Size = new System.Drawing.Size(49, 17);
            this.RAMRadioBtn.TabIndex = 4;
            this.RAMRadioBtn.TabStop = true;
            this.RAMRadioBtn.Text = "RAM";
            this.RAMRadioBtn.UseVisualStyleBackColor = true;
            this.RAMRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Búsqueda";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 7;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(565, 401);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(75, 23);
            this.AddProductBtn.TabIndex = 8;
            this.AddProductBtn.Text = "Añadir";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            // 
            // ProductCode
            // 
            this.ProductCode.Frozen = true;
            this.ProductCode.HeaderText = "Código";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.ToolTipText = "E";
            // 
            // ProductName
            // 
            this.ProductName.Frozen = true;
            this.ProductName.HeaderText = "Nombre";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.Frozen = true;
            this.ProductQuantity.HeaderText = "Cantidad";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            // 
            // ProductCost
            // 
            this.ProductCost.Frozen = true;
            this.ProductCost.HeaderText = "Precio Unidad";
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.ReadOnly = true;
            // 
            // ProductDescription
            // 
            this.ProductDescription.Frozen = true;
            this.ProductDescription.HeaderText = "Descripción";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            // 
            // ProductType
            // 
            this.ProductType.Frozen = true;
            this.ProductType.HeaderText = "Tipo";
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // DeleteDis
            // 
            this.DeleteDis.Frozen = true;
            this.DeleteDis.HeaderText = "Paco";
            this.DeleteDis.Name = "DeleteDis";
            this.DeleteDis.ReadOnly = true;
            this.DeleteDis.Text = "✎";
            this.DeleteDis.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PeripheralRadioBtn);
            this.Controls.Add(this.RAMRadioBtn);
            this.Controls.Add(this.ProcessorRadioBtn);
            this.Controls.Add(this.MotherboardRadioBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MotherboardRadioBtn;
        private System.Windows.Forms.RadioButton ProcessorRadioBtn;
        private System.Windows.Forms.RadioButton PeripheralRadioBtn;
        private System.Windows.Forms.RadioButton RAMRadioBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteDis;
    }
}

