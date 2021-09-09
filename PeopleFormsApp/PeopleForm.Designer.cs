
namespace PeopleFormsApp
{
    partial class PeopleForm
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
            this.gbPerson = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbAndroid = new System.Windows.Forms.RadioButton();
            this.rbApple = new System.Windows.Forms.RadioButton();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbPeople = new System.Windows.Forms.GroupBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.lblVisiblePeople = new System.Windows.Forms.Label();
            this.lblTotalPeople = new System.Windows.Forms.Label();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.rbShowAndroid = new System.Windows.Forms.RadioButton();
            this.rbShowApple = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.gbPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPerson
            // 
            this.gbPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPerson.Controls.Add(this.btnAdd);
            this.gbPerson.Controls.Add(this.btnClear);
            this.gbPerson.Controls.Add(this.rbAndroid);
            this.gbPerson.Controls.Add(this.rbApple);
            this.gbPerson.Controls.Add(this.numAge);
            this.gbPerson.Controls.Add(this.txtLastName);
            this.gbPerson.Controls.Add(this.txtFirstName);
            this.gbPerson.Controls.Add(this.lblMobile);
            this.gbPerson.Controls.Add(this.lblAge);
            this.gbPerson.Controls.Add(this.lblLastName);
            this.gbPerson.Controls.Add(this.lblFirstName);
            this.gbPerson.Location = new System.Drawing.Point(49, 45);
            this.gbPerson.Name = "gbPerson";
            this.gbPerson.Size = new System.Drawing.Size(482, 223);
            this.gbPerson.TabIndex = 0;
            this.gbPerson.TabStop = false;
            this.gbPerson.Text = "Person";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Location = new System.Drawing.Point(340, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.Location = new System.Drawing.Point(239, 194);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbAndroid
            // 
            this.rbAndroid.AutoSize = true;
            this.rbAndroid.Location = new System.Drawing.Point(181, 155);
            this.rbAndroid.Name = "rbAndroid";
            this.rbAndroid.Size = new System.Drawing.Size(68, 19);
            this.rbAndroid.TabIndex = 9;
            this.rbAndroid.TabStop = true;
            this.rbAndroid.Text = "Android";
            this.rbAndroid.UseVisualStyleBackColor = true;
            // 
            // rbApple
            // 
            this.rbApple.AutoSize = true;
            this.rbApple.Location = new System.Drawing.Point(102, 155);
            this.rbApple.Name = "rbApple";
            this.rbApple.Size = new System.Drawing.Size(56, 19);
            this.rbApple.TabIndex = 8;
            this.rbApple.TabStop = true;
            this.rbApple.Text = "Apple";
            this.rbApple.UseVisualStyleBackColor = true;
            // 
            // numAge
            // 
            this.numAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAge.Location = new System.Drawing.Point(102, 114);
            this.numAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(320, 23);
            this.numAge.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(102, 71);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(320, 23);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(102, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(320, 23);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(16, 157);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(44, 15);
            this.lblMobile.TabIndex = 7;
            this.lblMobile.Text = "Mobile";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(16, 116);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 15);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(16, 74);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 15);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(16, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // gbPeople
            // 
            this.gbPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPeople.Controls.Add(this.btnDeleteAll);
            this.gbPeople.Controls.Add(this.lblVisiblePeople);
            this.gbPeople.Controls.Add(this.lblTotalPeople);
            this.gbPeople.Controls.Add(this.dgvPeople);
            this.gbPeople.Controls.Add(this.rbShowAndroid);
            this.gbPeople.Controls.Add(this.rbShowApple);
            this.gbPeople.Controls.Add(this.rbShowAll);
            this.gbPeople.Location = new System.Drawing.Point(49, 298);
            this.gbPeople.Name = "gbPeople";
            this.gbPeople.Size = new System.Drawing.Size(482, 428);
            this.gbPeople.TabIndex = 12;
            this.gbPeople.TabStop = false;
            this.gbPeople.Text = "People";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAll.Location = new System.Drawing.Point(369, 392);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteAll.TabIndex = 19;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // lblVisiblePeople
            // 
            this.lblVisiblePeople.AutoSize = true;
            this.lblVisiblePeople.Location = new System.Drawing.Point(121, 396);
            this.lblVisiblePeople.Name = "lblVisiblePeople";
            this.lblVisiblePeople.Size = new System.Drawing.Size(91, 15);
            this.lblVisiblePeople.TabIndex = 18;
            this.lblVisiblePeople.Text = "Visible People: ?";
            // 
            // lblTotalPeople
            // 
            this.lblTotalPeople.AutoSize = true;
            this.lblTotalPeople.Location = new System.Drawing.Point(16, 396);
            this.lblTotalPeople.Name = "lblTotalPeople";
            this.lblTotalPeople.Size = new System.Drawing.Size(82, 15);
            this.lblTotalPeople.TabIndex = 17;
            this.lblTotalPeople.Text = "Total People: ?";
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.AllowUserToResizeRows = false;
            this.dgvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Location = new System.Drawing.Point(16, 90);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.RowTemplate.Height = 25;
            this.dgvPeople.Size = new System.Drawing.Size(450, 284);
            this.dgvPeople.TabIndex = 16;
            // 
            // rbShowAndroid
            // 
            this.rbShowAndroid.AutoSize = true;
            this.rbShowAndroid.Location = new System.Drawing.Point(309, 52);
            this.rbShowAndroid.Name = "rbShowAndroid";
            this.rbShowAndroid.Size = new System.Drawing.Size(157, 19);
            this.rbShowAndroid.TabIndex = 15;
            this.rbShowAndroid.TabStop = true;
            this.rbShowAndroid.Text = "Only show Android users";
            this.rbShowAndroid.UseVisualStyleBackColor = true;
            this.rbShowAndroid.CheckedChanged += new System.EventHandler(this.rbShowAndroid_CheckedChanged);
            // 
            // rbShowApple
            // 
            this.rbShowApple.AutoSize = true;
            this.rbShowApple.Location = new System.Drawing.Point(136, 52);
            this.rbShowApple.Name = "rbShowApple";
            this.rbShowApple.Size = new System.Drawing.Size(145, 19);
            this.rbShowApple.TabIndex = 14;
            this.rbShowApple.TabStop = true;
            this.rbShowApple.Text = "Only show Apple users";
            this.rbShowApple.UseVisualStyleBackColor = true;
            this.rbShowApple.CheckedChanged += new System.EventHandler(this.rbShowApple_CheckedChanged);
            this.rbShowApple.Click += new System.EventHandler(this.rbShowApple_Click);
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Location = new System.Drawing.Point(16, 52);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(99, 19);
            this.rbShowAll.TabIndex = 13;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Show all users";
            this.rbShowAll.UseVisualStyleBackColor = true;
            this.rbShowAll.CheckedChanged += new System.EventHandler(this.rbShowAll_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(418, 732);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 27);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 794);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbPeople);
            this.Controls.Add(this.gbPerson);
            this.Name = "PeopleForm";
            this.Text = "People";
            this.Load += new System.EventHandler(this.PeopleForm_Load);
            this.gbPerson.ResumeLayout(false);
            this.gbPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.gbPeople.ResumeLayout(false);
            this.gbPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPerson;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.RadioButton rbAndroid;
        private System.Windows.Forms.RadioButton rbApple;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbPeople;
        private System.Windows.Forms.RadioButton rbShowAndroid;
        private System.Windows.Forms.RadioButton rbShowApple;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Label lblTotalPeople;
        private System.Windows.Forms.Label lblVisiblePeople;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnClose;
    }
}

