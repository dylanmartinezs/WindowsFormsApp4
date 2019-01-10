namespace WindowsFormsApp4 {
    partial class AddContactForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AddProductTitleLbl = new System.Windows.Forms.Label();
            this.AddProductCodeLbl = new System.Windows.Forms.Label();
            this.AddProductCodeTxt = new System.Windows.Forms.TextBox();
            this.AddProductNameTxt = new System.Windows.Forms.TextBox();
            this.AddProductNameLbl = new System.Windows.Forms.Label();
            this.AddProductQuantityLbl = new System.Windows.Forms.Label();
            this.AddProductQuantityNum = new System.Windows.Forms.NumericUpDown();
            this.AddProductCostNum = new System.Windows.Forms.NumericUpDown();
            this.AddProductCostLbl = new System.Windows.Forms.Label();
            this.AddProductDescTxt = new System.Windows.Forms.TextBox();
            this.AddProductDescLbl = new System.Windows.Forms.Label();
            this.AddProductTypeTxt = new System.Windows.Forms.TextBox();
            this.AddProductTypeLbl = new System.Windows.Forms.Label();
            this.AddProductOkBtn = new System.Windows.Forms.Button();
            this.AddProductCancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductQuantityNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductCostNum)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductTitleLbl
            // 
            this.AddProductTitleLbl.AutoSize = true;
            this.AddProductTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductTitleLbl.Location = new System.Drawing.Point(79, 32);
            this.AddProductTitleLbl.Name = "AddProductTitleLbl";
            this.AddProductTitleLbl.Size = new System.Drawing.Size(222, 25);
            this.AddProductTitleLbl.TabIndex = 0;
            this.AddProductTitleLbl.Text = "Agregar nuevo producto";
            // 
            // AddProductCodeLbl
            // 
            this.AddProductCodeLbl.AutoSize = true;
            this.AddProductCodeLbl.Location = new System.Drawing.Point(25, 86);
            this.AddProductCodeLbl.Name = "AddProductCodeLbl";
            this.AddProductCodeLbl.Size = new System.Drawing.Size(43, 13);
            this.AddProductCodeLbl.TabIndex = 1;
            this.AddProductCodeLbl.Text = "Código:";
            // 
            // AddProductCodeTxt
            // 
            this.AddProductCodeTxt.Location = new System.Drawing.Point(97, 83);
            this.AddProductCodeTxt.Name = "AddProductCodeTxt";
            this.AddProductCodeTxt.Size = new System.Drawing.Size(233, 20);
            this.AddProductCodeTxt.TabIndex = 2;
            // 
            // AddProductNameTxt
            // 
            this.AddProductNameTxt.Location = new System.Drawing.Point(97, 132);
            this.AddProductNameTxt.Name = "AddProductNameTxt";
            this.AddProductNameTxt.Size = new System.Drawing.Size(233, 20);
            this.AddProductNameTxt.TabIndex = 4;
            // 
            // AddProductNameLbl
            // 
            this.AddProductNameLbl.AutoSize = true;
            this.AddProductNameLbl.Location = new System.Drawing.Point(25, 135);
            this.AddProductNameLbl.Name = "AddProductNameLbl";
            this.AddProductNameLbl.Size = new System.Drawing.Size(47, 13);
            this.AddProductNameLbl.TabIndex = 3;
            this.AddProductNameLbl.Text = "Nombre:";
            // 
            // AddProductQuantityLbl
            // 
            this.AddProductQuantityLbl.AutoSize = true;
            this.AddProductQuantityLbl.Location = new System.Drawing.Point(25, 185);
            this.AddProductQuantityLbl.Name = "AddProductQuantityLbl";
            this.AddProductQuantityLbl.Size = new System.Drawing.Size(52, 13);
            this.AddProductQuantityLbl.TabIndex = 5;
            this.AddProductQuantityLbl.Text = "Cantidad:";
            // 
            // AddProductQuantityNum
            // 
            this.AddProductQuantityNum.Location = new System.Drawing.Point(97, 183);
            this.AddProductQuantityNum.Name = "AddProductQuantityNum";
            this.AddProductQuantityNum.Size = new System.Drawing.Size(233, 20);
            this.AddProductQuantityNum.TabIndex = 6;
            // 
            // AddProductCostNum
            // 
            this.AddProductCostNum.Location = new System.Drawing.Point(97, 235);
            this.AddProductCostNum.Name = "AddProductCostNum";
            this.AddProductCostNum.Size = new System.Drawing.Size(233, 20);
            this.AddProductCostNum.TabIndex = 8;
            // 
            // AddProductCostLbl
            // 
            this.AddProductCostLbl.AutoSize = true;
            this.AddProductCostLbl.Location = new System.Drawing.Point(25, 237);
            this.AddProductCostLbl.Name = "AddProductCostLbl";
            this.AddProductCostLbl.Size = new System.Drawing.Size(40, 13);
            this.AddProductCostLbl.TabIndex = 7;
            this.AddProductCostLbl.Text = "Precio:";
            // 
            // AddProductDescTxt
            // 
            this.AddProductDescTxt.Location = new System.Drawing.Point(97, 285);
            this.AddProductDescTxt.Name = "AddProductDescTxt";
            this.AddProductDescTxt.Size = new System.Drawing.Size(233, 20);
            this.AddProductDescTxt.TabIndex = 10;
            // 
            // AddProductDescLbl
            // 
            this.AddProductDescLbl.AutoSize = true;
            this.AddProductDescLbl.Location = new System.Drawing.Point(25, 288);
            this.AddProductDescLbl.Name = "AddProductDescLbl";
            this.AddProductDescLbl.Size = new System.Drawing.Size(66, 13);
            this.AddProductDescLbl.TabIndex = 9;
            this.AddProductDescLbl.Text = "Descripción:";
            // 
            // AddProductTypeTxt
            // 
            this.AddProductTypeTxt.Location = new System.Drawing.Point(97, 337);
            this.AddProductTypeTxt.Name = "AddProductTypeTxt";
            this.AddProductTypeTxt.Size = new System.Drawing.Size(233, 20);
            this.AddProductTypeTxt.TabIndex = 12;
            // 
            // AddProductTypeLbl
            // 
            this.AddProductTypeLbl.AutoSize = true;
            this.AddProductTypeLbl.Location = new System.Drawing.Point(25, 340);
            this.AddProductTypeLbl.Name = "AddProductTypeLbl";
            this.AddProductTypeLbl.Size = new System.Drawing.Size(31, 13);
            this.AddProductTypeLbl.TabIndex = 11;
            this.AddProductTypeLbl.Text = "Tipo:";
            // 
            // AddProductOkBtn
            // 
            this.AddProductOkBtn.Location = new System.Drawing.Point(246, 390);
            this.AddProductOkBtn.Name = "AddProductOkBtn";
            this.AddProductOkBtn.Size = new System.Drawing.Size(102, 37);
            this.AddProductOkBtn.TabIndex = 13;
            this.AddProductOkBtn.Text = "Aceptar";
            this.AddProductOkBtn.UseVisualStyleBackColor = true;
            // 
            // AddProductCancelBtn
            // 
            this.AddProductCancelBtn.Location = new System.Drawing.Point(29, 390);
            this.AddProductCancelBtn.Name = "AddProductCancelBtn";
            this.AddProductCancelBtn.Size = new System.Drawing.Size(102, 37);
            this.AddProductCancelBtn.TabIndex = 14;
            this.AddProductCancelBtn.Text = "Cancelar";
            this.AddProductCancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.AddProductCancelBtn);
            this.Controls.Add(this.AddProductOkBtn);
            this.Controls.Add(this.AddProductTypeTxt);
            this.Controls.Add(this.AddProductTypeLbl);
            this.Controls.Add(this.AddProductDescTxt);
            this.Controls.Add(this.AddProductDescLbl);
            this.Controls.Add(this.AddProductCostNum);
            this.Controls.Add(this.AddProductCostLbl);
            this.Controls.Add(this.AddProductQuantityNum);
            this.Controls.Add(this.AddProductQuantityLbl);
            this.Controls.Add(this.AddProductNameTxt);
            this.Controls.Add(this.AddProductNameLbl);
            this.Controls.Add(this.AddProductCodeTxt);
            this.Controls.Add(this.AddProductCodeLbl);
            this.Controls.Add(this.AddProductTitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddContactForm";
            this.Text = "Agregar Productoç";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddProductQuantityNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductCostNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductTitleLbl;
        private System.Windows.Forms.Label AddProductCodeLbl;
        private System.Windows.Forms.TextBox AddProductCodeTxt;
        private System.Windows.Forms.TextBox AddProductNameTxt;
        private System.Windows.Forms.Label AddProductNameLbl;
        private System.Windows.Forms.Label AddProductQuantityLbl;
        private System.Windows.Forms.NumericUpDown AddProductQuantityNum;
        private System.Windows.Forms.NumericUpDown AddProductCostNum;
        private System.Windows.Forms.Label AddProductCostLbl;
        private System.Windows.Forms.TextBox AddProductDescTxt;
        private System.Windows.Forms.Label AddProductDescLbl;
        private System.Windows.Forms.TextBox AddProductTypeTxt;
        private System.Windows.Forms.Label AddProductTypeLbl;
        private System.Windows.Forms.Button AddProductOkBtn;
        private System.Windows.Forms.Button AddProductCancelBtn;
    }
}