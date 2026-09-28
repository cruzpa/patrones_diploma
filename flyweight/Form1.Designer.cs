namespace flyweight
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se esten usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codigo generado por el Disenador de Windows Forms

        /// <summary>
        /// Metodo necesario para admitir el Disenador. No se puede modificar
        /// el contenido de este metodo con el editor de codigo.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(12, 15);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(42, 13);
            this.ownerLabel.TabIndex = 0;
            this.ownerLabel.Text = "Dueno";
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.Location = new System.Drawing.Point(80, 12);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(160, 20);
            this.ownerTextBox.TabIndex = 1;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(258, 15);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(44, 13);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Patente";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(320, 12);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(140, 20);
            this.numberTextBox.TabIndex = 3;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(12, 50);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(37, 13);
            this.companyLabel.TabIndex = 4;
            this.companyLabel.Text = "Marca";
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(80, 47);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(160, 20);
            this.companyTextBox.TabIndex = 5;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(258, 50);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(42, 13);
            this.modelLabel.TabIndex = 6;
            this.modelLabel.Text = "Modelo";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(320, 47);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(140, 20);
            this.modelTextBox.TabIndex = 7;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(478, 50);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(31, 13);
            this.colorLabel.TabIndex = 8;
            this.colorLabel.Text = "Color";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(525, 47);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(120, 20);
            this.colorTextBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(665, 37);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 35);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AllowUserToAddRows = false;
            this.carsDataGridView.AllowUserToDeleteRows = false;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Location = new System.Drawing.Point(12, 88);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.Size = new System.Drawing.Size(760, 180);
            this.carsDataGridView.TabIndex = 11;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Consolas", 9F);
            this.outputTextBox.Location = new System.Drawing.Point(12, 284);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(760, 145);
            this.outputTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.carsDataGridView);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(this.ownerLabel);
            this.Name = "Form1";
            this.Text = "Flyweight - Autos";
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}
