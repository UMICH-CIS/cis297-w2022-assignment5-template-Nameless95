namespace DisplayTable
{
    partial class DisplayAuthorsTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAuthorsTable));
            this.authorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.authorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.authorDataGridView = new System.Windows.Forms.DataGridView();
            this.titlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LastName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.userinput = new System.Windows.Forms.TextBox();
            this.Resetbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingNavigator)).BeginInit();
            this.authorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // authorBindingNavigator
            // 
            this.authorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.authorBindingNavigator.BindingSource = this.authorBindingSource;
            this.authorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.authorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.authorBindingNavigator.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.authorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.authorBindingNavigatorSaveItem});
            this.authorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.authorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.authorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.authorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.authorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.authorBindingNavigator.Name = "authorBindingNavigator";
            this.authorBindingNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.authorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.authorBindingNavigator.Size = new System.Drawing.Size(706, 43);
            this.authorBindingNavigator.TabIndex = 0;
            this.authorBindingNavigator.Text = "bindingNavigator1";
            this.authorBindingNavigator.RefreshItems += new System.EventHandler(this.authorBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 40);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(24, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // authorBindingNavigatorSaveItem
            // 
            this.authorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.authorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("authorBindingNavigatorSaveItem.Image")));
            this.authorBindingNavigatorSaveItem.Name = "authorBindingNavigatorSaveItem";
            this.authorBindingNavigatorSaveItem.Size = new System.Drawing.Size(40, 40);
            this.authorBindingNavigatorSaveItem.Text = "Save Data";
            this.authorBindingNavigatorSaveItem.Click += new System.EventHandler(this.authorBindingNavigatorSaveItem_Click);
            // 
            // authorDataGridView
            // 
            this.authorDataGridView.AutoGenerateColumns = false;
            this.authorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.authorDataGridView.DataSource = this.authorBindingSource;
            this.authorDataGridView.Location = new System.Drawing.Point(0, 215);
            this.authorDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.authorDataGridView.Name = "authorDataGridView";
            this.authorDataGridView.RowTemplate.Height = 37;
            this.authorDataGridView.Size = new System.Drawing.Size(522, 228);
            this.authorDataGridView.TabIndex = 1;
            this.authorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorDataGridView_CellContentClick);
            // 
            // titlesBindingSource
            // 
            this.titlesBindingSource.DataMember = "Titles";
            this.titlesBindingSource.DataSource = this.authorBindingSource;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(BooksExamples.Author);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(118, 124);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(55, 13);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "LastName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userinput
            // 
            this.userinput.Location = new System.Drawing.Point(179, 121);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(100, 20);
            this.userinput.TabIndex = 5;
            // 
            // Resetbutton
            // 
            this.Resetbutton.Location = new System.Drawing.Point(204, 166);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(75, 23);
            this.Resetbutton.TabIndex = 6;
            this.Resetbutton.Text = "ResetButton";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // DisplayAuthorsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 546);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.userinput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.authorDataGridView);
            this.Controls.Add(this.authorBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "DisplayAuthorsTable";
            this.Text = "Display Authors Table";
            this.Load += new System.EventHandler(this.DisplayAuthorsTable_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingNavigator)).EndInit();
            this.authorBindingNavigator.ResumeLayout(false);
            this.authorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.BindingNavigator authorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton authorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView authorDataGridView;
        private System.Windows.Forms.BindingSource titlesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userinput;
        private System.Windows.Forms.Button Resetbutton;
    }
}

