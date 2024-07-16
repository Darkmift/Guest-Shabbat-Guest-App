namespace Guest_Shabbat_Guest_App
{
    partial class GuestForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label_welcome = new ReaLTaiizor.Controls.MaterialLabel();
            label_register = new ReaLTaiizor.Controls.MaterialLabel();
            textbox_enterName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label_addName = new Label();
            label_confirm = new Label();
            dataGridView_guests = new ReaLTaiizor.Controls.PoisonDataGridView();
            name = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_guests).BeginInit();
            SuspendLayout();
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Depth = 0;
            label_welcome.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            label_welcome.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            label_welcome.Location = new Point(75, 83);
            label_welcome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(181, 41);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "ברוכים הבאים";
            // 
            // label_register
            // 
            label_register.AutoSize = true;
            label_register.Depth = 0;
            label_register.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            label_register.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            label_register.Location = new Point(75, 137);
            label_register.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_register.Name = "label_register";
            label_register.Size = new Size(125, 29);
            label_register.TabIndex = 1;
            label_register.Text = "הרשמה לאירוע";
            // 
            // textbox_enterName
            // 
            textbox_enterName.AnimateReadOnly = false;
            textbox_enterName.AutoCompleteMode = AutoCompleteMode.None;
            textbox_enterName.AutoCompleteSource = AutoCompleteSource.None;
            textbox_enterName.BackgroundImageLayout = ImageLayout.None;
            textbox_enterName.CharacterCasing = CharacterCasing.Normal;
            textbox_enterName.Depth = 0;
            textbox_enterName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textbox_enterName.HideSelection = true;
            textbox_enterName.LeadingIcon = null;
            textbox_enterName.Location = new Point(75, 191);
            textbox_enterName.MaxLength = 32767;
            textbox_enterName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textbox_enterName.Name = "textbox_enterName";
            textbox_enterName.PasswordChar = '\0';
            textbox_enterName.PrefixSuffixText = null;
            textbox_enterName.ReadOnly = false;
            textbox_enterName.RightToLeft = RightToLeft.No;
            textbox_enterName.SelectedText = "";
            textbox_enterName.SelectionLength = 0;
            textbox_enterName.SelectionStart = 0;
            textbox_enterName.ShortcutsEnabled = true;
            textbox_enterName.Size = new Size(207, 48);
            textbox_enterName.TabIndex = 2;
            textbox_enterName.TabStop = false;
            textbox_enterName.TextAlign = HorizontalAlignment.Left;
            textbox_enterName.TrailingIcon = null;
            textbox_enterName.UseSystemPasswordChar = false;
            // 
            // label_addName
            // 
            label_addName.AutoSize = true;
            label_addName.BackColor = Color.FromArgb(61, 81, 181);
            label_addName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_addName.ForeColor = SystemColors.ButtonHighlight;
            label_addName.Location = new Point(75, 260);
            label_addName.MinimumSize = new Size(207, 48);
            label_addName.Name = "label_addName";
            label_addName.Size = new Size(207, 48);
            label_addName.TabIndex = 5;
            label_addName.Text = "הוספה";
            label_addName.TextAlign = ContentAlignment.MiddleCenter;
            label_addName.Click += label_addName_Click;
            // 
            // label_confirm
            // 
            label_confirm.AutoSize = true;
            label_confirm.BackColor = Color.DarkGreen;
            label_confirm.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_confirm.ForeColor = SystemColors.ButtonHighlight;
            label_confirm.Location = new Point(75, 590);
            label_confirm.MinimumSize = new Size(207, 48);
            label_confirm.Name = "label_confirm";
            label_confirm.Size = new Size(207, 48);
            label_confirm.TabIndex = 6;
            label_confirm.Text = "אישור";
            label_confirm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView_guests
            // 
            dataGridView_guests.AllowUserToResizeRows = false;
            dataGridView_guests.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridView_guests.BorderStyle = BorderStyle.None;
            dataGridView_guests.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView_guests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_guests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_guests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_guests.Columns.AddRange(new DataGridViewColumn[] { name });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_guests.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_guests.EnableHeadersVisualStyles = false;
            dataGridView_guests.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridView_guests.GridColor = Color.FromArgb(255, 255, 255);
            dataGridView_guests.Location = new Point(75, 345);
            dataGridView_guests.Name = "dataGridView_guests";
            dataGridView_guests.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_guests.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_guests.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView_guests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_guests.ShowEditingIcon = false;
            dataGridView_guests.Size = new Size(207, 188);
            dataGridView_guests.TabIndex = 7;
            dataGridView_guests.AllowUserToAddRows = false;
            dataGridView_guests.CellContentClick += dataGridView_guests_CellContentClick;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "שם";
            name.Name = "name";
            name.ReadOnly = true;
            name.Resizable = DataGridViewTriState.False;
            // 
            // GuestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 664);
            Controls.Add(dataGridView_guests);
            Controls.Add(label_confirm);
            Controls.Add(label_addName);
            Controls.Add(textbox_enterName);
            Controls.Add(label_register);
            Controls.Add(label_welcome);
            Name = "GuestForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "אורחים";
            ((System.ComponentModel.ISupportInitialize)dataGridView_guests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel label_welcome;
        private ReaLTaiizor.Controls.MaterialLabel label_register;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_enterName;
        private Label label_addName;
        private Label label_confirm;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridView_guests;
        private DataGridViewTextBoxColumn name;
    }
}