namespace Prog
{
    partial class AunthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Aunth = new System.Windows.Forms.Button();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Reg = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSet = new Prog.sqlDataSet();
            this.userTableAdapter = new Prog.sqlDataSetTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Aunth
            // 
            this.Aunth.Location = new System.Drawing.Point(20, 147);
            this.Aunth.Name = "Aunth";
            this.Aunth.Size = new System.Drawing.Size(190, 23);
            this.Aunth.TabIndex = 3;
            this.Aunth.Text = "Авторизироваться";
            this.Aunth.UseVisualStyleBackColor = true;
            this.Aunth.Click += new System.EventHandler(this.Aunth_Click);
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(20, 121);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(190, 20);
            this.TBPass.TabIndex = 2;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(20, 77);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(190, 20);
            this.TBEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(131, 105);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Забыл пароль";
            // 
            // Reg
            // 
            this.Reg.Location = new System.Drawing.Point(20, 176);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(190, 23);
            this.Reg.TabIndex = 4;
            this.Reg.Text = "Регистрация";
            this.Reg.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.Users.AutoGenerateColumns = false;
            this.Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1});
            this.Users.DataSource = this.userBindingSource;
            this.Users.Location = new System.Drawing.Point(20, 216);
            this.Users.Name = "Users";
            this.Users.ReadOnly = true;
            this.Users.RowHeadersVisible = false;
            this.Users.Size = new System.Drawing.Size(190, 167);
            this.Users.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_user";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_user";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_role";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_role";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date_registration";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date_registration";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name_user";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name_user";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Foto_user";
            this.dataGridViewImageColumn1.HeaderText = "Foto_user";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.sqlDataSet;
            // 
            // sqlDataSet
            // 
            this.sqlDataSet.DataSetName = "sqlDataSet";
            this.sqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // AunthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(224, 345);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.Aunth);
            this.Name = "AunthForm";
            this.ShowIcon = false;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aunth;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.DataGridView Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idroleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateregistrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotouserDataGridViewImageColumn;
        private sqlDataSet sqlDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private sqlDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}

