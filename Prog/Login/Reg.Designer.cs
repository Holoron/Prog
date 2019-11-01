namespace Prog
{
    partial class Reg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBPref = new System.Windows.Forms.ComboBox();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Regis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UserTA = new Prog.sqlDataSetTableAdapters.UserTableAdapter();
            this.sqlDataSet1 = new Prog.sqlDataSet();
            this.LoginList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Почта";
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(156, 67);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(190, 20);
            this.TBEmail.TabIndex = 6;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(156, 92);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(190, 20);
            this.TBPass.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Назначение";
            // 
            // CBPref
            // 
            this.CBPref.FormattingEnabled = true;
            this.CBPref.Items.AddRange(new object[] {
            "Покупатель",
            "Риэлтор"});
            this.CBPref.Location = new System.Drawing.Point(156, 118);
            this.CBPref.Name = "CBPref";
            this.CBPref.Size = new System.Drawing.Size(190, 21);
            this.CBPref.TabIndex = 11;
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(156, 145);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(190, 20);
            this.TBPhone.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Телефон";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(156, 171);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(190, 20);
            this.TBName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(115, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Имя";
            // 
            // Regis
            // 
            this.Regis.Location = new System.Drawing.Point(156, 197);
            this.Regis.Name = "Regis";
            this.Regis.Size = new System.Drawing.Size(135, 23);
            this.Regis.TabIndex = 16;
            this.Regis.Text = "Зарегистрироваться";
            this.Regis.UseVisualStyleBackColor = true;
            this.Regis.Click += new System.EventHandler(this.Regis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserTA
            // 
            this.UserTA.ClearBeforeFill = true;
            // 
            // sqlDataSet1
            // 
            this.sqlDataSet1.DataSetName = "sqlDataSet";
            this.sqlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoginList
            // 
            this.LoginList.AllowUserToAddRows = false;
            this.LoginList.AllowUserToDeleteRows = false;
            this.LoginList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoginList.Location = new System.Drawing.Point(452, 53);
            this.LoginList.Name = "LoginList";
            this.LoginList.ReadOnly = true;
            this.LoginList.RowHeadersVisible = false;
            this.LoginList.Size = new System.Drawing.Size(190, 167);
            this.LoginList.TabIndex = 18;
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(745, 270);
            this.Controls.Add(this.LoginList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Regis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBPhone);
            this.Controls.Add(this.CBPref);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reg";
            this.Text = "Reg";
            this.Load += new System.EventHandler(this.Reg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBPref;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Regis;
        private System.Windows.Forms.Button button1;
        private sqlDataSetTableAdapters.UserTableAdapter UserTA;
        private sqlDataSet sqlDataSet1;
        private System.Windows.Forms.DataGridView LoginList;
    }
}