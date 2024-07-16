namespace Guest_Shabbat_Guest_App.Views
{
    partial class AddFoodForm
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
            label_categoryName = new ReaLTaiizor.Controls.MaterialLabel();
            dataGridView_categories = new DataGridView();
            CategoryName = new DataGridViewTextBoxColumn();
            label_addFood = new Label();
            textbox_addFood = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dataGridView_foods = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Guest = new DataGridViewTextBoxColumn();
            label_prevCategory = new Label();
            label_nextCategory = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_foods).BeginInit();
            SuspendLayout();
            // 
            // label_categoryName
            // 
            label_categoryName.AutoSize = true;
            label_categoryName.Depth = 0;
            label_categoryName.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            label_categoryName.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            label_categoryName.Location = new Point(94, 99);
            label_categoryName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_categoryName.Name = "label_categoryName";
            label_categoryName.Size = new Size(160, 41);
            label_categoryName.TabIndex = 0;
            label_categoryName.Text = "שם קטגוריה";
            // 
            // dataGridView_categories
            // 
            dataGridView_categories.AllowUserToAddRows = false;
            dataGridView_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_categories.Columns.AddRange(new DataGridViewColumn[] { CategoryName });
            dataGridView_categories.Location = new Point(49, 166);
            dataGridView_categories.Name = "dataGridView_categories";
            dataGridView_categories.Size = new Size(240, 150);
            dataGridView_categories.TabIndex = 1;
            dataGridView_categories.CellContentClick += dataGridView_categories_CellContentClick;
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryName.HeaderText = "קטגוריה";
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            CategoryName.Resizable = DataGridViewTriState.False;
            // 
            // label_addFood
            // 
            label_addFood.AutoSize = true;
            label_addFood.BackColor = Color.FromArgb(61, 81, 181);
            label_addFood.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_addFood.ForeColor = SystemColors.ButtonHighlight;
            label_addFood.Location = new Point(78, 422);
            label_addFood.Margin = new Padding(2, 0, 2, 0);
            label_addFood.MinimumSize = new Size(188, 39);
            label_addFood.Name = "label_addFood";
            label_addFood.Size = new Size(188, 39);
            label_addFood.TabIndex = 10;
            label_addFood.Text = "הוספת מאכל";
            label_addFood.TextAlign = ContentAlignment.MiddleCenter;
            label_addFood.Click += label_addFood_Click;
            // 
            // textbox_addFood
            // 
            textbox_addFood.AnimateReadOnly = false;
            textbox_addFood.AutoCompleteMode = AutoCompleteMode.None;
            textbox_addFood.AutoCompleteSource = AutoCompleteSource.None;
            textbox_addFood.BackgroundImageLayout = ImageLayout.None;
            textbox_addFood.CharacterCasing = CharacterCasing.Normal;
            textbox_addFood.Depth = 0;
            textbox_addFood.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textbox_addFood.HideSelection = true;
            textbox_addFood.LeadingIcon = null;
            textbox_addFood.Location = new Point(78, 352);
            textbox_addFood.MaxLength = 32767;
            textbox_addFood.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textbox_addFood.Name = "textbox_addFood";
            textbox_addFood.PasswordChar = '\0';
            textbox_addFood.PrefixSuffixText = null;
            textbox_addFood.ReadOnly = false;
            textbox_addFood.RightToLeft = RightToLeft.Yes;
            textbox_addFood.SelectedText = "";
            textbox_addFood.SelectionLength = 0;
            textbox_addFood.SelectionStart = 0;
            textbox_addFood.ShortcutsEnabled = true;
            textbox_addFood.Size = new Size(188, 48);
            textbox_addFood.TabIndex = 11;
            textbox_addFood.TabStop = false;
            textbox_addFood.TextAlign = HorizontalAlignment.Left;
            textbox_addFood.TrailingIcon = null;
            textbox_addFood.UseSystemPasswordChar = false;
            // 
            // dataGridView_foods
            // 
            dataGridView_foods.AllowUserToAddRows = false;
            dataGridView_foods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_foods.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Guest });
            dataGridView_foods.Location = new Point(49, 481);
            dataGridView_foods.Name = "dataGridView_foods";
            dataGridView_foods.Size = new Size(240, 150);
            dataGridView_foods.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "שם מאכל";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            // 
            // Guest
            // 
            Guest.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Guest.HeaderText = "אורח";
            Guest.Name = "Guest";
            // 
            // label_prevCategory
            // 
            label_prevCategory.AutoSize = true;
            label_prevCategory.BackColor = Color.FromArgb(61, 81, 181);
            label_prevCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_prevCategory.ForeColor = SystemColors.ButtonHighlight;
            label_prevCategory.Location = new Point(30, 662);
            label_prevCategory.Margin = new Padding(2, 0, 2, 0);
            label_prevCategory.MinimumSize = new Size(100, 39);
            label_prevCategory.Name = "label_prevCategory";
            label_prevCategory.Padding = new Padding(12, 0, 12, 0);
            label_prevCategory.Size = new Size(134, 39);
            label_prevCategory.TabIndex = 13;
            label_prevCategory.Text = "קטגוריה קודמת";
            label_prevCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_nextCategory
            // 
            label_nextCategory.AutoSize = true;
            label_nextCategory.BackColor = Color.FromArgb(61, 81, 181);
            label_nextCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_nextCategory.ForeColor = SystemColors.ButtonHighlight;
            label_nextCategory.Location = new Point(181, 662);
            label_nextCategory.Margin = new Padding(2, 0, 2, 0);
            label_nextCategory.MinimumSize = new Size(100, 39);
            label_nextCategory.Name = "label_nextCategory";
            label_nextCategory.Padding = new Padding(12, 0, 12, 0);
            label_nextCategory.Size = new Size(128, 39);
            label_nextCategory.TabIndex = 14;
            label_nextCategory.Text = "קטגוריה הבאה";
            label_nextCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddFoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 758);
            Controls.Add(label_nextCategory);
            Controls.Add(label_prevCategory);
            Controls.Add(dataGridView_foods);
            Controls.Add(textbox_addFood);
            Controls.Add(label_addFood);
            Controls.Add(dataGridView_categories);
            Controls.Add(label_categoryName);
            Name = "AddFoodForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "בחירת מאכלים";
            ((System.ComponentModel.ISupportInitialize)dataGridView_categories).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_foods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel label_categoryName;
        private DataGridView dataGridView_categories;
        private Label label_addFood;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_addFood;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridView dataGridView_foods;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Guest;
        private DataGridView dataGridView2;
        private Label label_prevCategory;
        private Label label_nextCategory;
    }
}