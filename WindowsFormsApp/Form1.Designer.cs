namespace WindowsFormsApp
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
            this.buttonTransferMachine = new System.Windows.Forms.Button();
            this.buttonTransferOnline = new System.Windows.Forms.Button();
            this.buttonTransferFaculties = new System.Windows.Forms.Button();
            this.buttonGetNbCopies = new System.Windows.Forms.Button();
            this.fieldUID = new System.Windows.Forms.TextBox();
            this.fieldAmountLeft = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAmountLeft = new System.Windows.Forms.Label();
            this.labelUID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUsername1 = new System.Windows.Forms.Label();
            this.labelAmountRight = new System.Windows.Forms.Label();
            this.fieldUsername1 = new System.Windows.Forms.TextBox();
            this.fieldAmountRight = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fieldUsername2 = new System.Windows.Forms.TextBox();
            this.labelUsername2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelConfirmation1 = new System.Windows.Forms.Label();
            this.labelConfirmation2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.montant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonShowTransactions = new System.Windows.Forms.Button();
            this.service1ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.service1ClientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fieldUID2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service1ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service1ClientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTransferMachine
            // 
            this.buttonTransferMachine.Location = new System.Drawing.Point(22, 130);
            this.buttonTransferMachine.Name = "buttonTransferMachine";
            this.buttonTransferMachine.Size = new System.Drawing.Size(300, 23);
            this.buttonTransferMachine.TabIndex = 0;
            this.buttonTransferMachine.Text = "Transfer from Machine";
            this.buttonTransferMachine.UseVisualStyleBackColor = true;
            this.buttonTransferMachine.Click += new System.EventHandler(this.buttonTransferMachine_Click);
            // 
            // buttonTransferOnline
            // 
            this.buttonTransferOnline.Location = new System.Drawing.Point(25, 130);
            this.buttonTransferOnline.Name = "buttonTransferOnline";
            this.buttonTransferOnline.Size = new System.Drawing.Size(142, 23);
            this.buttonTransferOnline.TabIndex = 1;
            this.buttonTransferOnline.Text = "Transfer from Online";
            this.buttonTransferOnline.UseVisualStyleBackColor = true;
            this.buttonTransferOnline.Click += new System.EventHandler(this.buttonTransferOnline_Click);
            // 
            // buttonTransferFaculties
            // 
            this.buttonTransferFaculties.Location = new System.Drawing.Point(197, 130);
            this.buttonTransferFaculties.Name = "buttonTransferFaculties";
            this.buttonTransferFaculties.Size = new System.Drawing.Size(150, 23);
            this.buttonTransferFaculties.TabIndex = 2;
            this.buttonTransferFaculties.Text = "Transfer from Faculties";
            this.buttonTransferFaculties.UseVisualStyleBackColor = true;
            this.buttonTransferFaculties.Click += new System.EventHandler(this.buttonTransferFaculties_Click);
            // 
            // buttonGetNbCopies
            // 
            this.buttonGetNbCopies.Location = new System.Drawing.Point(22, 102);
            this.buttonGetNbCopies.Name = "buttonGetNbCopies";
            this.buttonGetNbCopies.Size = new System.Drawing.Size(300, 23);
            this.buttonGetNbCopies.TabIndex = 3;
            this.buttonGetNbCopies.Text = "Get Number Of Copies";
            this.buttonGetNbCopies.UseVisualStyleBackColor = true;
            this.buttonGetNbCopies.Click += new System.EventHandler(this.buttonGetNbCopies_Click);
            // 
            // fieldUID
            // 
            this.fieldUID.Location = new System.Drawing.Point(142, 29);
            this.fieldUID.Name = "fieldUID";
            this.fieldUID.Size = new System.Drawing.Size(180, 20);
            this.fieldUID.TabIndex = 4;
            // 
            // fieldAmountLeft
            // 
            this.fieldAmountLeft.Location = new System.Drawing.Point(142, 67);
            this.fieldAmountLeft.Name = "fieldAmountLeft";
            this.fieldAmountLeft.Size = new System.Drawing.Size(180, 20);
            this.fieldAmountLeft.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelConfirmation1);
            this.panel1.Controls.Add(this.labelUID);
            this.panel1.Controls.Add(this.labelAmountLeft);
            this.panel1.Controls.Add(this.fieldUID);
            this.panel1.Controls.Add(this.fieldAmountLeft);
            this.panel1.Controls.Add(this.buttonTransferMachine);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 195);
            this.panel1.TabIndex = 6;
            // 
            // labelAmountLeft
            // 
            this.labelAmountLeft.AutoSize = true;
            this.labelAmountLeft.Location = new System.Drawing.Point(19, 74);
            this.labelAmountLeft.Name = "labelAmountLeft";
            this.labelAmountLeft.Size = new System.Drawing.Size(42, 13);
            this.labelAmountLeft.TabIndex = 7;
            this.labelAmountLeft.Text = "amount";
            // 
            // labelUID
            // 
            this.labelUID.AutoSize = true;
            this.labelUID.Location = new System.Drawing.Point(19, 35);
            this.labelUID.Name = "labelUID";
            this.labelUID.Size = new System.Drawing.Size(26, 13);
            this.labelUID.TabIndex = 8;
            this.labelUID.Text = "UID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelConfirmation2);
            this.panel2.Controls.Add(this.fieldAmountRight);
            this.panel2.Controls.Add(this.fieldUsername1);
            this.panel2.Controls.Add(this.labelAmountRight);
            this.panel2.Controls.Add(this.labelUsername1);
            this.panel2.Controls.Add(this.buttonTransferOnline);
            this.panel2.Controls.Add(this.buttonTransferFaculties);
            this.panel2.Location = new System.Drawing.Point(406, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 195);
            this.panel2.TabIndex = 7;
            // 
            // labelUsername1
            // 
            this.labelUsername1.AutoSize = true;
            this.labelUsername1.Location = new System.Drawing.Point(25, 35);
            this.labelUsername1.Name = "labelUsername1";
            this.labelUsername1.Size = new System.Drawing.Size(53, 13);
            this.labelUsername1.TabIndex = 3;
            this.labelUsername1.Text = "username";
            // 
            // labelAmountRight
            // 
            this.labelAmountRight.AutoSize = true;
            this.labelAmountRight.Location = new System.Drawing.Point(25, 73);
            this.labelAmountRight.Name = "labelAmountRight";
            this.labelAmountRight.Size = new System.Drawing.Size(42, 13);
            this.labelAmountRight.TabIndex = 4;
            this.labelAmountRight.Text = "amount";
            // 
            // fieldUsername1
            // 
            this.fieldUsername1.Location = new System.Drawing.Point(150, 32);
            this.fieldUsername1.Name = "fieldUsername1";
            this.fieldUsername1.Size = new System.Drawing.Size(197, 20);
            this.fieldUsername1.TabIndex = 5;
            // 
            // fieldAmountRight
            // 
            this.fieldAmountRight.Location = new System.Drawing.Point(150, 66);
            this.fieldAmountRight.Name = "fieldAmountRight";
            this.fieldAmountRight.Size = new System.Drawing.Size(197, 20);
            this.fieldAmountRight.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelResult);
            this.panel3.Controls.Add(this.labelUsername2);
            this.panel3.Controls.Add(this.fieldUsername2);
            this.panel3.Controls.Add(this.buttonGetNbCopies);
            this.panel3.Location = new System.Drawing.Point(12, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 196);
            this.panel3.TabIndex = 8;
            // 
            // fieldUsername2
            // 
            this.fieldUsername2.Location = new System.Drawing.Point(142, 51);
            this.fieldUsername2.Name = "fieldUsername2";
            this.fieldUsername2.Size = new System.Drawing.Size(180, 20);
            this.fieldUsername2.TabIndex = 4;
            // 
            // labelUsername2
            // 
            this.labelUsername2.AutoSize = true;
            this.labelUsername2.Location = new System.Drawing.Point(19, 58);
            this.labelUsername2.Name = "labelUsername2";
            this.labelUsername2.Size = new System.Drawing.Size(53, 13);
            this.labelUsername2.TabIndex = 5;
            this.labelUsername2.Text = "username";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(19, 156);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 6;
            // 
            // labelConfirmation1
            // 
            this.labelConfirmation1.AutoSize = true;
            this.labelConfirmation1.Location = new System.Drawing.Point(19, 166);
            this.labelConfirmation1.Name = "labelConfirmation1";
            this.labelConfirmation1.Size = new System.Drawing.Size(0, 13);
            this.labelConfirmation1.TabIndex = 9;
            // 
            // labelConfirmation2
            // 
            this.labelConfirmation2.AutoSize = true;
            this.labelConfirmation2.Location = new System.Drawing.Point(28, 166);
            this.labelConfirmation2.Name = "labelConfirmation2";
            this.labelConfirmation2.Size = new System.Drawing.Size(0, 13);
            this.labelConfirmation2.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.montant,
            this.idType,
            this.date});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(406, 305);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(365, 120);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // montant
            // 
            this.montant.Text = "montant";
            // 
            // idType
            // 
            this.idType.Text = "idType";
            // 
            // date
            // 
            this.date.Text = "date";
            this.date.Width = 101;
            // 
            // buttonShowTransactions
            // 
            this.buttonShowTransactions.Location = new System.Drawing.Point(589, 267);
            this.buttonShowTransactions.Name = "buttonShowTransactions";
            this.buttonShowTransactions.Size = new System.Drawing.Size(182, 23);
            this.buttonShowTransactions.TabIndex = 10;
            this.buttonShowTransactions.Text = "Voir les transactions";
            this.buttonShowTransactions.UseVisualStyleBackColor = true;
            this.buttonShowTransactions.Click += new System.EventHandler(this.buttonShowTransactions_Click);
            // 
            // service1ClientBindingSource
            // 
            this.service1ClientBindingSource.DataSource = typeof(WindowsFormsApp.ServiceReference1.Service1Client);
            // 
            // service1ClientBindingSource1
            // 
            this.service1ClientBindingSource1.DataSource = typeof(WindowsFormsApp.ServiceReference1.Service1Client);
            // 
            // fieldUID2
            // 
            this.fieldUID2.Location = new System.Drawing.Point(479, 269);
            this.fieldUID2.Name = "fieldUID2";
            this.fieldUID2.Size = new System.Drawing.Size(94, 20);
            this.fieldUID2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "UID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldUID2);
            this.Controls.Add(this.buttonShowTransactions);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service1ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service1ClientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTransferMachine;
        private System.Windows.Forms.Button buttonTransferOnline;
        private System.Windows.Forms.Button buttonTransferFaculties;
        private System.Windows.Forms.Button buttonGetNbCopies;
        private System.Windows.Forms.TextBox fieldUID;
        private System.Windows.Forms.TextBox fieldAmountLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAmountLeft;
        private System.Windows.Forms.Label labelUID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox fieldAmountRight;
        private System.Windows.Forms.Label labelAmountRight;
        private System.Windows.Forms.Label labelUsername1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelUsername2;
        private System.Windows.Forms.TextBox fieldUsername2;
        private System.Windows.Forms.TextBox fieldUsername1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelConfirmation1;
        private System.Windows.Forms.Label labelConfirmation2;
        private System.Windows.Forms.BindingSource service1ClientBindingSource1;
        private System.Windows.Forms.BindingSource service1ClientBindingSource;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader montant;
        private System.Windows.Forms.ColumnHeader idType;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button buttonShowTransactions;
        private System.Windows.Forms.TextBox fieldUID2;
        private System.Windows.Forms.Label label1;
    }
}

