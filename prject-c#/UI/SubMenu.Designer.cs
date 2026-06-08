namespace UI
{
    partial class SubMenu
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
            SM_ButtonAddSale = new TabControl();
            tabPage1 = new TabPage();
            SM_DateTimeEndSale = new DateTimePicker();
            SM_DateTimeStartSale = new DateTimePicker();
            SM_CheckBoxForMemberSale = new CheckBox();
            label3 = new Label();
            SM_TextBoxPriceSale = new TextBox();
            SM_TextBoxCountSale = new TextBox();
            SM_TextBoxProIdSale = new TextBox();
            SM_TextBoxIdSale = new TextBox();
            dataGridView3 = new DataGridView();
            SM_ButtonDeleteSale = new Button();
            SM_ButtonUpdetaSale = new Button();
            SM_ButtonAddSales = new Button();
            tabPage2 = new TabPage();
            SM_ComboBoxCatPro = new ComboBox();
            label2 = new Label();
            SM_TextBoxQnttyPro = new TextBox();
            SM_TextBoxPricePro = new TextBox();
            SM_TextBoxNamePro = new TextBox();
            SM_TextBoxIdPro = new TextBox();
            dataGridView2 = new DataGridView();
            SM_ButtonDeletePro = new Button();
            SM_ButtonUpdatePro = new Button();
            SM_ButtonAddPro = new Button();
            tabPage3 = new TabPage();
            label1 = new Label();
            SM_TextBoxPhone = new TextBox();
            SM_TextBoxAdress = new TextBox();
            SM_TextBoxName = new TextBox();
            SM_TextBoxId = new TextBox();
            dataGridView1 = new DataGridView();
            SM_ButtonDeleteCus = new Button();
            SM_ButtonUpdateCus = new Button();
            SM_ButtonAddCus = new Button();
            subMenuTitle = new Label();
            backInSubMenu = new Button();
            SM_ButtonAddSale.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SM_ButtonAddSale
            // 
            SM_ButtonAddSale.Controls.Add(tabPage1);
            SM_ButtonAddSale.Controls.Add(tabPage2);
            SM_ButtonAddSale.Controls.Add(tabPage3);
            SM_ButtonAddSale.Location = new Point(3, 60);
            SM_ButtonAddSale.Name = "SM_ButtonAddSale";
            SM_ButtonAddSale.SelectedIndex = 0;
            SM_ButtonAddSale.Size = new Size(798, 390);
            SM_ButtonAddSale.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SM_DateTimeEndSale);
            tabPage1.Controls.Add(SM_DateTimeStartSale);
            tabPage1.Controls.Add(SM_CheckBoxForMemberSale);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(SM_TextBoxPriceSale);
            tabPage1.Controls.Add(SM_TextBoxCountSale);
            tabPage1.Controls.Add(SM_TextBoxProIdSale);
            tabPage1.Controls.Add(SM_TextBoxIdSale);
            tabPage1.Controls.Add(dataGridView3);
            tabPage1.Controls.Add(SM_ButtonDeleteSale);
            tabPage1.Controls.Add(SM_ButtonUpdetaSale);
            tabPage1.Controls.Add(SM_ButtonAddSales);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(790, 362);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "מבצעים";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // SM_DateTimeEndSale
            // 
            SM_DateTimeEndSale.Location = new Point(254, 297);
            SM_DateTimeEndSale.Name = "SM_DateTimeEndSale";
            SM_DateTimeEndSale.Size = new Size(128, 23);
            SM_DateTimeEndSale.TabIndex = 29;
            // 
            // SM_DateTimeStartSale
            // 
            SM_DateTimeStartSale.Location = new Point(254, 257);
            SM_DateTimeStartSale.Name = "SM_DateTimeStartSale";
            SM_DateTimeStartSale.Size = new Size(128, 23);
            SM_DateTimeStartSale.TabIndex = 28;
            // 
            // SM_CheckBoxForMemberSale
            // 
            SM_CheckBoxForMemberSale.AutoSize = true;
            SM_CheckBoxForMemberSale.Location = new Point(254, 337);
            SM_CheckBoxForMemberSale.Name = "SM_CheckBoxForMemberSale";
            SM_CheckBoxForMemberSale.Size = new Size(141, 19);
            SM_CheckBoxForMemberSale.TabIndex = 27;
            SM_CheckBoxForMemberSale.Text = ":האם המבצע ללקוחות";
            SM_CheckBoxForMemberSale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Adam", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(576, 227);
            label3.Name = "label3";
            label3.Size = new Size(118, 19);
            label3.TabIndex = 25;
            label3.Text = ":פרטים על מבצע ";
            // 
            // SM_TextBoxPriceSale
            // 
            SM_TextBoxPriceSale.Location = new Point(409, 297);
            SM_TextBoxPriceSale.Name = "SM_TextBoxPriceSale";
            SM_TextBoxPriceSale.PlaceholderText = ":הכנס מחיר";
            SM_TextBoxPriceSale.Size = new Size(128, 23);
            SM_TextBoxPriceSale.TabIndex = 24;
            // 
            // SM_TextBoxCountSale
            // 
            SM_TextBoxCountSale.Location = new Point(409, 257);
            SM_TextBoxCountSale.Name = "SM_TextBoxCountSale";
            SM_TextBoxCountSale.PlaceholderText = ":הכנס כמות נדרשת למבצע";
            SM_TextBoxCountSale.Size = new Size(128, 23);
            SM_TextBoxCountSale.TabIndex = 23;
            // 
            // SM_TextBoxProIdSale
            // 
            SM_TextBoxProIdSale.Location = new Point(566, 297);
            SM_TextBoxProIdSale.Name = "SM_TextBoxProIdSale";
            SM_TextBoxProIdSale.PlaceholderText = ":הכנס מקט מוצר";
            SM_TextBoxProIdSale.Size = new Size(128, 23);
            SM_TextBoxProIdSale.TabIndex = 22;
            // 
            // SM_TextBoxIdSale
            // 
            SM_TextBoxIdSale.Location = new Point(566, 257);
            SM_TextBoxIdSale.Name = "SM_TextBoxIdSale";
            SM_TextBoxIdSale.PlaceholderText = ":מקט";
            SM_TextBoxIdSale.Size = new Size(128, 23);
            SM_TextBoxIdSale.TabIndex = 21;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(22, 21);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(746, 196);
            dataGridView3.TabIndex = 20;
            dataGridView3.SelectionChanged += dataGridView3_SelectionChanged;
            // 
            // SM_ButtonDeleteSale
            // 
            SM_ButtonDeleteSale.Location = new Point(56, 312);
            SM_ButtonDeleteSale.Name = "SM_ButtonDeleteSale";
            SM_ButtonDeleteSale.Size = new Size(148, 31);
            SM_ButtonDeleteSale.TabIndex = 19;
            SM_ButtonDeleteSale.Text = "מחיקת המבצע";
            SM_ButtonDeleteSale.UseVisualStyleBackColor = true;
            SM_ButtonDeleteSale.Click += SM_ButtonDeleteSale_Click;
            // 
            // SM_ButtonUpdetaSale
            // 
            SM_ButtonUpdetaSale.Location = new Point(56, 275);
            SM_ButtonUpdetaSale.Name = "SM_ButtonUpdetaSale";
            SM_ButtonUpdetaSale.Size = new Size(148, 31);
            SM_ButtonUpdetaSale.TabIndex = 18;
            SM_ButtonUpdetaSale.Text = "עדכון המבצע";
            SM_ButtonUpdetaSale.UseVisualStyleBackColor = true;
            SM_ButtonUpdetaSale.Click += SM_ButtonUpdetaSale_Click;
            // 
            // SM_ButtonAddSales
            // 
            SM_ButtonAddSales.Location = new Point(56, 238);
            SM_ButtonAddSales.Name = "SM_ButtonAddSales";
            SM_ButtonAddSales.Size = new Size(148, 31);
            SM_ButtonAddSales.TabIndex = 17;
            SM_ButtonAddSales.Text = "הוספת המבצע";
            SM_ButtonAddSales.UseVisualStyleBackColor = true;
            SM_ButtonAddSales.Click += SM_ButtonAddSales_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(SM_ComboBoxCatPro);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(SM_TextBoxQnttyPro);
            tabPage2.Controls.Add(SM_TextBoxPricePro);
            tabPage2.Controls.Add(SM_TextBoxNamePro);
            tabPage2.Controls.Add(SM_TextBoxIdPro);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(SM_ButtonDeletePro);
            tabPage2.Controls.Add(SM_ButtonUpdatePro);
            tabPage2.Controls.Add(SM_ButtonAddPro);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(790, 362);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "מוצרים";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // SM_ComboBoxCatPro
            // 
            SM_ComboBoxCatPro.FormatString = "קטגוריה";
            SM_ComboBoxCatPro.FormattingEnabled = true;
            SM_ComboBoxCatPro.Location = new Point(324, 236);
            SM_ComboBoxCatPro.Name = "SM_ComboBoxCatPro";
            SM_ComboBoxCatPro.Size = new Size(170, 23);
            SM_ComboBoxCatPro.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Adam", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(578, 243);
            label2.Name = "label2";
            label2.Size = new Size(114, 19);
            label2.TabIndex = 25;
            label2.Text = ":פרטים על מוצר ";
            // 
            // SM_TextBoxQnttyPro
            // 
            SM_TextBoxQnttyPro.Location = new Point(324, 315);
            SM_TextBoxQnttyPro.Name = "SM_TextBoxQnttyPro";
            SM_TextBoxQnttyPro.PlaceholderText = ":הכנס כמות";
            SM_TextBoxQnttyPro.Size = new Size(170, 23);
            SM_TextBoxQnttyPro.TabIndex = 24;
            // 
            // SM_TextBoxPricePro
            // 
            SM_TextBoxPricePro.Location = new Point(324, 277);
            SM_TextBoxPricePro.Name = "SM_TextBoxPricePro";
            SM_TextBoxPricePro.PlaceholderText = ":הכנס מחיר ליחידה";
            SM_TextBoxPricePro.Size = new Size(170, 23);
            SM_TextBoxPricePro.TabIndex = 23;
            // 
            // SM_TextBoxNamePro
            // 
            SM_TextBoxNamePro.Location = new Point(523, 315);
            SM_TextBoxNamePro.Name = "SM_TextBoxNamePro";
            SM_TextBoxNamePro.PlaceholderText = ":הכנס שם ";
            SM_TextBoxNamePro.Size = new Size(170, 23);
            SM_TextBoxNamePro.TabIndex = 22;
            // 
            // SM_TextBoxIdPro
            // 
            SM_TextBoxIdPro.Location = new Point(523, 277);
            SM_TextBoxIdPro.Name = "SM_TextBoxIdPro";
            SM_TextBoxIdPro.PlaceholderText = ":מקט";
            SM_TextBoxIdPro.Size = new Size(170, 23);
            SM_TextBoxIdPro.TabIndex = 21;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(22, 21);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(746, 196);
            dataGridView2.TabIndex = 20;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // SM_ButtonDeletePro
            // 
            SM_ButtonDeletePro.Location = new Point(98, 310);
            SM_ButtonDeletePro.Name = "SM_ButtonDeletePro";
            SM_ButtonDeletePro.Size = new Size(188, 31);
            SM_ButtonDeletePro.TabIndex = 19;
            SM_ButtonDeletePro.Text = "מחיקת המוצר";
            SM_ButtonDeletePro.UseVisualStyleBackColor = true;
            SM_ButtonDeletePro.Click += SM_ButtonDeletePro_Click;
            // 
            // SM_ButtonUpdatePro
            // 
            SM_ButtonUpdatePro.Location = new Point(98, 273);
            SM_ButtonUpdatePro.Name = "SM_ButtonUpdatePro";
            SM_ButtonUpdatePro.Size = new Size(188, 31);
            SM_ButtonUpdatePro.TabIndex = 18;
            SM_ButtonUpdatePro.Text = "עדכון המוצר";
            SM_ButtonUpdatePro.UseVisualStyleBackColor = true;
            SM_ButtonUpdatePro.Click += SM_ButtonUpdatePro_Click;
            // 
            // SM_ButtonAddPro
            // 
            SM_ButtonAddPro.Location = new Point(98, 236);
            SM_ButtonAddPro.Name = "SM_ButtonAddPro";
            SM_ButtonAddPro.Size = new Size(188, 31);
            SM_ButtonAddPro.TabIndex = 17;
            SM_ButtonAddPro.Text = "הוספת המוצר";
            SM_ButtonAddPro.UseVisualStyleBackColor = true;
            SM_ButtonAddPro.Click += SM_ButtonAddPro_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(SM_TextBoxPhone);
            tabPage3.Controls.Add(SM_TextBoxAdress);
            tabPage3.Controls.Add(SM_TextBoxName);
            tabPage3.Controls.Add(SM_TextBoxId);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Controls.Add(SM_ButtonDeleteCus);
            tabPage3.Controls.Add(SM_ButtonUpdateCus);
            tabPage3.Controls.Add(SM_ButtonAddCus);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(790, 362);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "לקוחות";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Adam", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(579, 242);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 16;
            label1.Text = ":פרטים על לקוח ";
            // 
            // SM_TextBoxPhone
            // 
            SM_TextBoxPhone.Location = new Point(325, 314);
            SM_TextBoxPhone.Name = "SM_TextBoxPhone";
            SM_TextBoxPhone.PlaceholderText = ":הכנס פלאפון";
            SM_TextBoxPhone.Size = new Size(170, 23);
            SM_TextBoxPhone.TabIndex = 15;
            // 
            // SM_TextBoxAdress
            // 
            SM_TextBoxAdress.Location = new Point(325, 276);
            SM_TextBoxAdress.Name = "SM_TextBoxAdress";
            SM_TextBoxAdress.PlaceholderText = ":הכנס כתובת";
            SM_TextBoxAdress.Size = new Size(170, 23);
            SM_TextBoxAdress.TabIndex = 14;
            // 
            // SM_TextBoxName
            // 
            SM_TextBoxName.Location = new Point(524, 314);
            SM_TextBoxName.Name = "SM_TextBoxName";
            SM_TextBoxName.PlaceholderText = ":הכנס שם מלא";
            SM_TextBoxName.Size = new Size(170, 23);
            SM_TextBoxName.TabIndex = 13;
            // 
            // SM_TextBoxId
            // 
            SM_TextBoxId.Location = new Point(524, 276);
            SM_TextBoxId.Name = "SM_TextBoxId";
            SM_TextBoxId.PlaceholderText = ":.הכנס ת.ז";
            SM_TextBoxId.Size = new Size(170, 23);
            SM_TextBoxId.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(746, 196);
            dataGridView1.TabIndex = 11;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // SM_ButtonDeleteCus
            // 
            SM_ButtonDeleteCus.Location = new Point(97, 309);
            SM_ButtonDeleteCus.Name = "SM_ButtonDeleteCus";
            SM_ButtonDeleteCus.Size = new Size(188, 31);
            SM_ButtonDeleteCus.TabIndex = 10;
            SM_ButtonDeleteCus.Text = "מחיקת הלקוח";
            SM_ButtonDeleteCus.UseVisualStyleBackColor = true;
            SM_ButtonDeleteCus.Click += SM_ButtonDeleteCus_Click;
            // 
            // SM_ButtonUpdateCus
            // 
            SM_ButtonUpdateCus.Location = new Point(97, 272);
            SM_ButtonUpdateCus.Name = "SM_ButtonUpdateCus";
            SM_ButtonUpdateCus.Size = new Size(188, 31);
            SM_ButtonUpdateCus.TabIndex = 9;
            SM_ButtonUpdateCus.Text = "עדכון הלקוח";
            SM_ButtonUpdateCus.UseVisualStyleBackColor = true;
            SM_ButtonUpdateCus.Click += SM_ButtonUpdateCus_Click;
            // 
            // SM_ButtonAddCus
            // 
            SM_ButtonAddCus.Location = new Point(97, 235);
            SM_ButtonAddCus.Name = "SM_ButtonAddCus";
            SM_ButtonAddCus.Size = new Size(188, 31);
            SM_ButtonAddCus.TabIndex = 8;
            SM_ButtonAddCus.Text = "הוספת הלקוח";
            SM_ButtonAddCus.UseVisualStyleBackColor = true;
            SM_ButtonAddCus.Click += SM_ButtonAddCus_Click;
            // 
            // subMenuTitle
            // 
            subMenuTitle.AutoSize = true;
            subMenuTitle.Font = new Font("Adam", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subMenuTitle.Location = new Point(182, 20);
            subMenuTitle.Name = "subMenuTitle";
            subMenuTitle.Size = new Size(454, 37);
            subMenuTitle.TabIndex = 1;
            subMenuTitle.Text = ".ניהול מידע - לקוחות. מוצרים. מבצעים";
            // 
            // backInSubMenu
            // 
            backInSubMenu.Location = new Point(741, 20);
            backInSubMenu.Name = "backInSubMenu";
            backInSubMenu.Size = new Size(34, 23);
            backInSubMenu.TabIndex = 2;
            backInSubMenu.Text = "➡️";
            backInSubMenu.UseVisualStyleBackColor = true;
            backInSubMenu.Click += backInSubMenu_Click;
            // 
            // SubMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backInSubMenu);
            Controls.Add(subMenuTitle);
            Controls.Add(SM_ButtonAddSale);
            Name = "SubMenu";
            Text = "SubMenu";
            Load += SubMenu_Load;
            SM_ButtonAddSale.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl SM_ButtonAddSale;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button SM_ButtonDeleteCus;
        private Button SM_ButtonUpdateCus;
        private Button SM_ButtonAddCus;
        private Label subMenuTitle;
        private DataGridView dataGridView1;
        private TextBox SM_TextBoxName;
        private TextBox SM_TextBoxId;
        private TextBox SM_TextBoxPhone;
        private TextBox SM_TextBoxAdress;
        private Label label1;
        private Label label3;
        private TextBox SM_TextBoxPriceSale;
        private TextBox SM_TextBoxCountSale;
        private TextBox SM_TextBoxProIdSale;
        private TextBox SM_TextBoxIdSale;
        private DataGridView dataGridView3;
        private Button SM_ButtonDeleteSale;
        private Button SM_ButtonUpdetaSale;
        private Button SM_ButtonAddSales;
        private Label label2;
        private TextBox SM_TextBoxQnttyPro;
        private TextBox SM_TextBoxPricePro;
        private TextBox SM_TextBoxNamePro;
        private TextBox SM_TextBoxIdPro;
        private DataGridView dataGridView2;
        private Button SM_ButtonDeletePro;
        private Button SM_ButtonUpdatePro;
        private Button SM_ButtonAddPro;
        private ComboBox SM_ComboBoxCatPro;
        private CheckBox SM_CheckBoxForMemberSale;
        private DateTimePicker SM_DateTimeStartSale;
        private DateTimePicker SM_DateTimeEndSale;
        private Button backInSubMenu;
    }
}